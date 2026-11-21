using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002681 RID: 9857
[NullableContext(1)]
[Nullable(0)]
public class PerformMachine
{
	// Token: 0x06018AE2 RID: 101090 RVA: 0x0077C558 File Offset: 0x0077A758
	public PerformMachine(BasePerformComponent performComp, EPerformGroup group = EPerformGroup.DefaultGroup)
	{
		this.PerformComp = performComp;
		this.Group = group;
	}

	// Token: 0x06018AE3 RID: 101091 RVA: 0x0077C5A4 File Offset: 0x0077A7A4
	public void Init()
	{
		this.Modes[EPerformMode.Plot] = new PlotMode(EPerformMode.Plot, this.PerformComp, this);
		this.Modes[EPerformMode.Action] = new ActionMode(EPerformMode.Action, this.PerformComp, this);
		this.Modes[EPerformMode.Ecology] = new EcologyMode(EPerformMode.Ecology, this.PerformComp, this);
		this.EntityHandle = CreatureModel.Instance.GetEntityById(this.PerformComp.Entity.Id);
		EventSystem.Instance.AddWithTarget(this.PerformComp.Entity, EEventName.AnimCompActiveStateChange, new Action<bool>(this.OnAnimCompActiveStateChange));
	}

	// Token: 0x06018AE4 RID: 101092 RVA: 0x0077C644 File Offset: 0x0077A844
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

	// Token: 0x06018AE5 RID: 101093 RVA: 0x0077C70C File Offset: 0x0077A90C
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

	// Token: 0x06018AE6 RID: 101094 RVA: 0x0077C77C File Offset: 0x0077A97C
	public EPerformMode GetCurrentMode()
	{
		return this.CurrentMode;
	}

	// Token: 0x06018AE7 RID: 101095 RVA: 0x0077C784 File Offset: 0x0077A984
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

	// Token: 0x06018AE8 RID: 101096 RVA: 0x0077C808 File Offset: 0x0077AA08
	public bool EnableAction(int id, bool bEnable)
	{
		if (!this.PendingActionCache.ContainsKey(id))
		{
			return false;
		}
		this.PendingActionCache[id].IsValid = bEnable;
		return true;
	}

	// Token: 0x06018AE9 RID: 101097 RVA: 0x0077C82D File Offset: 0x0077AA2D
	public void Update()
	{
		if (this.PendingActionCache.Count > 0)
		{
			this.Refresh();
		}
	}

	// Token: 0x06018AEA RID: 101098 RVA: 0x0077C844 File Offset: 0x0077AA44
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

	// Token: 0x06018AEB RID: 101099 RVA: 0x0077C98F File Offset: 0x0077AB8F
	private bool CheckModeEnter(EPerformMode mode)
	{
		if (this.Modes[mode].CheckEnter())
		{
			this.CurrentMode = mode;
			return true;
		}
		return false;
	}

	// Token: 0x06018AEC RID: 101100 RVA: 0x0077C9AE File Offset: 0x0077ABAE
	private void ExecuteAction(IPerformActionBase actionInfo)
	{
		this.CurrentAction = actionInfo;
		actionInfo.Execute();
	}

	// Token: 0x06018AED RID: 101101 RVA: 0x0077C9BD File Offset: 0x0077ABBD
	private void OnActionFinish()
	{
		PerformActionPool.ReturnAction(this.CurrentAction);
		this.CurrentAction = null;
		this.Refresh();
	}

	// Token: 0x06018AEE RID: 101102 RVA: 0x0077C9D7 File Offset: 0x0077ABD7
	private void OnAnimCompActiveStateChange(bool enable)
	{
		if (enable)
		{
			this.Refresh();
		}
	}

	// Token: 0x0400D65B RID: 54875
	private readonly BasePerformComponent PerformComp;

	// Token: 0x0400D65C RID: 54876
	public readonly EPerformGroup Group;

	// Token: 0x0400D65D RID: 54877
	private int InstanceId;

	// Token: 0x0400D65E RID: 54878
	public Dictionary<EPerformMode, PerformModeBase> Modes = new Dictionary<EPerformMode, PerformModeBase>();

	// Token: 0x0400D65F RID: 54879
	private EPerformMode CurrentMode;

	// Token: 0x0400D660 RID: 54880
	private readonly Dictionary<int, IPerformActionBase> PendingActionCache = new Dictionary<int, IPerformActionBase>();

	// Token: 0x0400D661 RID: 54881
	[Nullable(2)]
	public IPerformActionBase CurrentAction;

	// Token: 0x0400D662 RID: 54882
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400D663 RID: 54883
	public int CurrentVolatileLoadId = -1;

	// Token: 0x0400D664 RID: 54884
	public int CurrentVolatileActionId = -1;

	// Token: 0x0400D665 RID: 54885
	public int CurrentVolatileMontageId = -1;
}
