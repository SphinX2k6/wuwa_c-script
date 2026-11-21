using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001953 RID: 6483
[NullableContext(2)]
[Nullable(0)]
public class PhantomInteractDetailPanelGroup
{
	// Token: 0x06010053 RID: 65619 RVA: 0x004AC02C File Offset: 0x004AA22C
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

	// Token: 0x06010054 RID: 65620 RVA: 0x004AC078 File Offset: 0x004AA278
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

	// Token: 0x06010055 RID: 65621 RVA: 0x004AC0E4 File Offset: 0x004AA2E4
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

	// Token: 0x04008E4D RID: 36429
	private PhantomInteractDetailPanel SpecialContentPanel;

	// Token: 0x04008E4E RID: 36430
	private PhantomInteractDetailPanel NormalContentPanel;

	// Token: 0x04008E4F RID: 36431
	private int CurrentMonsterId;

	// Token: 0x04008E50 RID: 36432
	private bool IsSpecial;
}
