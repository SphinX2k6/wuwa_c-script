using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020019BE RID: 6590
[NullableContext(1)]
[Nullable(0)]
public class RoleTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0600C08B RID: 49291 RVA: 0x002B6270 File Offset: 0x002B4470
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTabItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTabItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C08C RID: 49292 RVA: 0x002B62B3 File Offset: 0x002B44B3
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

	// Token: 0x0600C08D RID: 49293 RVA: 0x002B62DA File Offset: 0x002B44DA
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}

	// Token: 0x0600C08E RID: 49294 RVA: 0x002B62FE File Offset: 0x002B44FE
	public override void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDotAndClearData(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x04005674 RID: 22132
	[Nullable(2)]
	private UiPanelBase WarningItem;

	// Token: 0x04005675 RID: 22133
	public Func<int, bool> IsConflict = (int index) => false;
}
