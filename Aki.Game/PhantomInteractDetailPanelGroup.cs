using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200246E RID: 9326
[NullableContext(2)]
[Nullable(0)]
public class PhantomInteractDetailPanelGroup
{
	// Token: 0x06012B9B RID: 76699 RVA: 0x0049E8C0 File Offset: 0x0049CAC0
	[NullableContext(1)]
	public UniTask CreateWithParent(UUIItem parent)
	{
		PhantomInteractDetailPanelGroup.<CreateWithParent>d__4 <CreateWithParent>d__;
		<CreateWithParent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateWithParent>d__.<>4__this = this;
		<CreateWithParent>d__.parent = parent;
		<CreateWithParent>d__.<>1__state = -1;
		<CreateWithParent>d__.<>t__builder.Start<PhantomInteractDetailPanelGroup.<CreateWithParent>d__4>(ref <CreateWithParent>d__);
		return <CreateWithParent>d__.<>t__builder.Task;
	}

	// Token: 0x06012B9C RID: 76700 RVA: 0x0049E90C File Offset: 0x0049CB0C
	public void RefreshDetailPanel(bool isShow, PhantomInteractDetailViewModel viewModel = null)
	{
		if (!isShow)
		{
			PhantomInteractDetailPanel specialContentPanel = this.SpecialContentPanel;
			if (specialContentPanel != null)
			{
				specialContentPanel.SetScrollListenerActive(false);
			}
			PhantomInteractDetailPanel normalContentPanel = this.NormalContentPanel;
			if (normalContentPanel != null)
			{
				normalContentPanel.SetScrollListenerActive(false);
			}
			PhantomInteractDetailPanel specialContentPanel2 = this.SpecialContentPanel;
			if (specialContentPanel2 != null)
			{
				specialContentPanel2.SetUiActive(false);
			}
			PhantomInteractDetailPanel normalContentPanel2 = this.NormalContentPanel;
			if (normalContentPanel2 != null)
			{
				normalContentPanel2.SetUiActive(false);
			}
			this.CurrentMonsterId = 0;
			return;
		}
		if (viewModel == null)
		{
			return;
		}
		this.RefreshPanelAsync(viewModel);
	}

	// Token: 0x06012B9D RID: 76701 RVA: 0x0049E978 File Offset: 0x0049CB78
	[NullableContext(1)]
	private UniTask RefreshPanelAsync(PhantomInteractDetailViewModel viewModel)
	{
		PhantomInteractDetailPanelGroup.<RefreshPanelAsync>d__6 <RefreshPanelAsync>d__;
		<RefreshPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshPanelAsync>d__.<>4__this = this;
		<RefreshPanelAsync>d__.viewModel = viewModel;
		<RefreshPanelAsync>d__.<>1__state = -1;
		<RefreshPanelAsync>d__.<>t__builder.Start<PhantomInteractDetailPanelGroup.<RefreshPanelAsync>d__6>(ref <RefreshPanelAsync>d__);
		return <RefreshPanelAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04008D06 RID: 36102
	private PhantomInteractDetailPanel SpecialContentPanel;

	// Token: 0x04008D07 RID: 36103
	private PhantomInteractDetailPanel NormalContentPanel;

	// Token: 0x04008D08 RID: 36104
	private int CurrentMonsterId;

	// Token: 0x04008D09 RID: 36105
	private bool IsSpecial;
}
