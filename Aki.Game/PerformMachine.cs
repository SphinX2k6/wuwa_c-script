using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02003126 RID: 12582
[NullableContext(1)]
[Nullable(0)]
public class PerformMachine
{
	// Token: 0x0601B087 RID: 110727 RVA: 0x007564EC File Offset: 0x007546EC
	public PerformMachine(BasePerformComponent performComp, EPerformGroup group = EPerformGroup.DefaultGroup)
	{
		this.PerformComp = performComp;
		this.Group = group;
	}

	// Token: 0x0601B088 RID: 110728 RVA: 0x00756538 File Offset: 0x00754738
	public void Init()
	{
		this.Modes[EPerformMode.Plot] = new PlotMode(EPerformMode.Plot, this.PerformComp, this);
		this.Modes[EPerformMode.Action] = new ActionMode(EPerformMode.Action, this.PerformComp, this);
		this.Modes[EPerformMode.Ecology] = new EcologyMode(EPerformMode.Ecology, this.PerformComp, this);
		this.EntityHandle = CreatureModel.Instance.GetEntityById(this.PerformComp.Entity.Id);
		EventSystem.Instance.AddWithTarget(this.PerformComp.Entity, EEventName.AnimCompActiveStateChange, new Action<bool>(this.OnAnimCompActiveStateChange));
	}

	// Token: 0x0601B089 RID: 110729 RVA: 0x007565D8 File Offset: 0x007547D8
	public void Clear()
	{
		foreach (PerformModeBase performModeBase in this.Modes.Values)
		{
			performModeBase.Clear();
		}
		this.Modes.Clear();
		if (this.CurrentAction != null)
		{
			PerformActionPool.ReturnAction(this.CurrentAction);
		}
		this.CurrentAction = null;
		this.PendingActionCache.Clear();
		this.EntityHandle = null;
		this.CurrentVolatileLoadId = -1;
		this.CurrentVolatileActionId = -1;
		this.CurrentVolatileMontageId = -1;
		EventSystem.Instance.RemoveWithTarget(this.PerformComp.Entity, EEventName.AnimCompActiveStateChange, new Action<bool>(this.OnAnimCompActiveStateChange));
	}

	// Token: 0x0601B08A RID: 110730 RVA: 0x007566A0 File Offset: 0x007548A0
	public void CleanAction()
	{
		if (this.CurrentAction != null)
		{
			PerformActionPool.ReturnAction(this.CurrentAction);
			this.CurrentAction = null;
		}
		foreach (PerformModeBase performModeBase in this.Modes.Values)
		{
			performModeBase.Clear();
		}
	}

	// Token: 0x0601B08B RID: 110731 RVA: 0x00756710 File Offset: 0x00754910
	public EPerformMode GetCurrentMode()
	{
		return this.CurrentMode;
	}

	// Token: 0x0601B08C RID: 110732 RVA: 0x00756718 File Offset: 0x00754918
	[NullableContext(2)]
	public int DoAction(EPerformMode mode, EPerformAction actionType, [Nullable(1)] IActionParamMap param, Action<int> onBeforeExecute = null, Action<int> onAfterExecute = null, bool bPersistent = false)
	{
		this.InstanceId++;
		int instanceId = this.InstanceId;
		IPerformActionBase action = PerformActionPool.GetAction(actionType, instanceId, param, this.PerformComp, this.Group, new Action(this.OnActionFinish), onBeforeExecute, onAfterExecute);
		action.IsValid = true;
		action.Mode = mode;
		action.IsPersistent = bPersistent;
		this.PendingActionCache[instanceId] = action;
		this.Modes[mode].PushAction(action, false);
		this.Refresh();
		return instanceId;
	}

	// Token: 0x0601B08D RID: 110733 RVA: 0x0075679C File Offset: 0x0075499C
	public bool EnableAction(int id, bool bEnable)
	{
		if (!this.PendingActionCache.ContainsKey(id))
		{
			return false;
		}
		this.PendingActionCache[id].IsValid = bEnable;
		return true;
	}

	// Token: 0x0601B08E RID: 110734 RVA: 0x007567C1 File Offset: 0x007549C1
	public void Update()
	{
		if (this.PendingActionCache.Count > 0)
		{
			this.Refresh();
		}
	}

	// Token: 0x0601B08F RID: 110735 RVA: 0x007567D8 File Offset: 0x007549D8
	private void Refresh()
	{
		IPerformActionBase currentAction = this.CurrentAction;
		if (currentAction != null && currentAction.IsAtomic)
		{
			return;
		}
		BaseAnimationComponent component = this.PerformComp.Entity.GetComponent<BaseAnimationComponent>();
		if (component == null || !component.Active)
		{
			return;
		}
		bool flag = true;
		if (this.CurrentMode != EPerformMode.Undetermined && this.Modes[this.CurrentMode].CheckExit())
		{
			this.CurrentMode = EPerformMode.Undetermined;
		}
		if (this.CurrentMode == EPerformMode.Undetermined)
		{
			flag = (this.CheckModeEnter(EPerformMode.Plot) || this.CheckModeEnter(EPerformMode.Action) || this.CheckModeEnter(EPerformMode.Ecology));
		}
		if (!flag)
		{
			return;
		}
		IPerformActionBase performActionBase = this.Modes[this.CurrentMode].PopAction();
		if (performActionBase == null)
		{
			return;
		}
		this.PendingActionCache.Remove(performActionBase.Id);
		if (this.CurrentAction != null)
		{
			if (!this.CurrentAction.IsPersistent || this.CurrentAction.Mode == this.CurrentMode)
			{
				PerformActionPool.ReturnAction(this.CurrentAction);
			}
			else
			{
				this.CurrentAction.Interrupt();
				this.PendingActionCache[performActionBase.Id] = performActionBase;
				this.Modes[this.CurrentAction.Mode].PushAction(this.CurrentAction, true);
			}
		}
		this.CurrentAction = null;
		this.ExecuteAction(performActionBase);
		this.Refresh();
	}

	// Token: 0x0601B090 RID: 110736 RVA: 0x00756923 File Offset: 0x00754B23
	private bool CheckModeEnter(EPerformMode mode)
	{
		if (this.Modes[mode].CheckEnter())
		{
			this.CurrentMode = mode;
			return true;
		}
		return false;
	}

	// Token: 0x0601B091 RID: 110737 RVA: 0x00756942 File Offset: 0x00754B42
	private void ExecuteAction(IPerformActionBase actionInfo)
	{
		this.CurrentAction = actionInfo;
		actionInfo.Execute();
	}

	// Token: 0x0601B092 RID: 110738 RVA: 0x00756951 File Offset: 0x00754B51
	private void OnActionFinish()
	{
		PerformActionPool.ReturnAction(this.CurrentAction);
		this.CurrentAction = null;
		this.Refresh();
	}

	// Token: 0x0601B093 RID: 110739 RVA: 0x0075696B File Offset: 0x00754B6B
	private void OnAnimCompActiveStateChange(bool enable)
	{
		if (enable)
		{
			this.Refresh();
		}
	}

	// Token: 0x0400D239 RID: 53817
	private readonly BasePerformComponent PerformComp;

	// Token: 0x0400D23A RID: 53818
	public readonly EPerformGroup Group;

	// Token: 0x0400D23B RID: 53819
	private int InstanceId;

	// Token: 0x0400D23C RID: 53820
	public Dictionary<EPerformMode, PerformModeBase> Modes = new Dictionary<EPerformMode, PerformModeBase>();

	// Token: 0x0400D23D RID: 53821
	private EPerformMode CurrentMode;

	// Token: 0x0400D23E RID: 53822
	private readonly Dictionary<int, IPerformActionBase> PendingActionCache = new Dictionary<int, IPerformActionBase>();

	// Token: 0x0400D23F RID: 53823
	[Nullable(2)]
	public IPerformActionBase CurrentAction;

	// Token: 0x0400D240 RID: 53824
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400D241 RID: 53825
	public int CurrentVolatileLoadId = -1;

	// Token: 0x0400D242 RID: 53826
	public int CurrentVolatileActionId = -1;

	// Token: 0x0400D243 RID: 53827
	public int CurrentVolatileMontageId = -1;
}
