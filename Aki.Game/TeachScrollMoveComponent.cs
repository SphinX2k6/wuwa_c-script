using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02002229 RID: 8745
[NullableContext(1)]
[Nullable(0)]
public class TeachScrollMoveComponent : HotKeyComponent
{
	// Token: 0x0601597D RID: 88445 RVA: 0x00644322 File Offset: 0x00642522
	public TeachScrollMoveComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
	{
		InputDistributeController.Instance.BindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
	}

	// Token: 0x0601597E RID: 88446 RVA: 0x00644346 File Offset: 0x00642546
	protected override void OnClear()
	{
		InputDistributeController.Instance.UnBindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
	}

	// Token: 0x0601597F RID: 88447 RVA: 0x00644363 File Offset: 0x00642563
	private void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		this.IsMainKeyPress = (actionType == InputDistributeDefine.EActionType.Press);
		this.RefreshActiveState();
	}

	// Token: 0x06015980 RID: 88448 RVA: 0x00644378 File Offset: 0x00642578
	protected override void OnInputAxis(string axisName, float value)
	{
		if (value == 0f)
		{
			return;
		}
		if (this.Listener != null)
		{
			if ((double)Math.Abs(value) <= 0.1)
			{
				if (this.TempValue != 0f)
				{
					this.TempValue = 0f;
					UiNavigationNewController.Instance.ScrollBarChangeScheduleByListener(this.Listener, 0f);
				}
				return;
			}
			this.TempValue = value;
			UiNavigationNewController.Instance.ScrollBarChangeScheduleByListener(this.Listener, value);
		}
	}

	// Token: 0x06015981 RID: 88449 RVA: 0x006443F0 File Offset: 0x006425F0
	protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
	{
		string bindButtonTag = base.GetBindButtonTag();
		if (StringUtils.IsEmpty(bindButtonTag))
		{
			return;
		}
		this.Listener = viewHandle.GetActiveListenerByTag(bindButtonTag);
		this.RefreshActiveState();
	}

	// Token: 0x06015982 RID: 88450 RVA: 0x00644420 File Offset: 0x00642620
	protected void RefreshActiveState()
	{
		if (!this.IsMainKeyPress || !this.CheckInTeachDungeon() || this.Listener == null || !this.Listener.IsListenerActive())
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
			return;
		}
		base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
	}

	// Token: 0x06015983 RID: 88451 RVA: 0x0064445C File Offset: 0x0064265C
	private bool CheckInTeachDungeon()
	{
		int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
		return instanceId != 0 && InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.InstSubType == 7;
	}

	// Token: 0x0400B675 RID: 46709
	private const double THRESHOLD = 0.1;

	// Token: 0x0400B676 RID: 46710
	private float TempValue;

	// Token: 0x0400B677 RID: 46711
	private bool IsMainKeyPress;

	// Token: 0x0400B678 RID: 46712
	[Nullable(2)]
	private TsUiNavigationBehaviorListener Listener;
}
