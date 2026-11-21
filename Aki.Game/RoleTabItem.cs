using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000E7C RID: 3708
[NullableContext(1)]
[Nullable(0)]
public class RoleTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x06009495 RID: 38037 RVA: 0x002C1200 File Offset: 0x002BF400
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTabItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTabItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009496 RID: 38038 RVA: 0x002C1243 File Offset: 0x002BF443
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.OnRefresh(data, isSelected, gridIndex);
		UiPanelBase warningItem = this.WarningItem;
		if (warningItem == null)
		{
			return;
		}
		warningItem.SetUiActive(this.IsConflict(gridIndex));
	}

	// Token: 0x06009497 RID: 38039 RVA: 0x002C126A File Offset: 0x002BF46A
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x06009498 RID: 38040 RVA: 0x002C128E File Offset: 0x002BF48E
	public override void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDotAndClearData(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x04005726 RID: 22310
	[Nullable(2)]
	private UiPanelBase WarningItem;

	// Token: 0x04005727 RID: 22311
	public Func<int, bool> IsConflict = (int index) => false;
}
