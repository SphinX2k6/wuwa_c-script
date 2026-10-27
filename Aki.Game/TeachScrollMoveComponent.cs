using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02002CD0 RID: 11472
[NullableContext(1)]
[Nullable(0)]
public class TeachScrollMoveComponent : HotKeyComponent
{
	// Token: 0x06018100 RID: 98560 RVA: 0x0061E77E File Offset: 0x0061C97E
	public TeachScrollMoveComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
	{
		InputDistributeController.Instance.BindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
	}

	// Token: 0x06018101 RID: 98561 RVA: 0x0061E7A2 File Offset: 0x0061C9A2
	protected override void OnClear()
	{
		InputDistributeController.Instance.UnBindAction("组合主键", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCombineButton));
	}

	// Token: 0x06018102 RID: 98562 RVA: 0x0061E7BF File Offset: 0x0061C9BF
	private void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		this.IsMainKeyPress = (actionType == InputDistributeDefine.EActionType.Press);
		this.RefreshActiveState();
	}

	// Token: 0x06018103 RID: 98563 RVA: 0x0061E7D4 File Offset: 0x0061C9D4
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

	// Token: 0x06018104 RID: 98564 RVA: 0x0061E84C File Offset: 0x0061CA4C
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

	// Token: 0x06018105 RID: 98565 RVA: 0x0061E87C File Offset: 0x0061CA7C
	protected void RefreshActiveState()
	{
		if (!this.IsMainKeyPress || !this.CheckInTeachDungeon() || this.Listener == null || !this.Listener.IsListenerActive())
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
			return;
		}
		base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
	}

	// Token: 0x06018106 RID: 98566 RVA: 0x0061E8B8 File Offset: 0x0061CAB8
	private bool CheckInTeachDungeon()
	{
		int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
		return instanceId != 0 && InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.InstSubType == 7;
	}

	// Token: 0x0400B309 RID: 45833
	private const double THRESHOLD = 0.1;

	// Token: 0x0400B30A RID: 45834
	private float TempValue;

	// Token: 0x0400B30B RID: 45835
	private bool IsMainKeyPress;

	// Token: 0x0400B30C RID: 45836
	[Nullable(2)]
	private TsUiNavigationBehaviorListener Listener;
}
