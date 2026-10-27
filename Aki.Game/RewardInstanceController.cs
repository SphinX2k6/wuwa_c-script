using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200135E RID: 4958
[NullableContext(1)]
[Nullable(0)]
public class RewardInstanceController
{
	// Token: 0x06008A1D RID: 35357 RVA: 0x001D8496 File Offset: 0x001D6696
	public void RegisterMainView(RewardMainView mainView)
	{
		this.MainView = mainView;
	}

	// Token: 0x06008A1E RID: 35358 RVA: 0x001D84A0 File Offset: 0x001D66A0
	public UniTask InitMainView()
	{
		RewardInstanceController.<InitMainView>d__4 <InitMainView>d__;
		<InitMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMainView>d__.<>4__this = this;
		<InitMainView>d__.<>1__state = -1;
		<InitMainView>d__.<>t__builder.Start<RewardInstanceController.<InitMainView>d__4>(ref <InitMainView>d__);
		return <InitMainView>d__.<>t__builder.Task;
	}

	// Token: 0x06008A1F RID: 35359 RVA: 0x001D84E3 File Offset: 0x001D66E3
	public void RefreshTabList()
	{
		MoonChasingModel.Instance.GetRewardTabList();
		this.TabDataList = new List<UiDynamicTab>();
		this.MainView.SetTabState(0, true, true);
	}

	// Token: 0x06008A20 RID: 35360 RVA: 0x001D850C File Offset: 0x001D670C
	public void TabItemToggleClick(int index)
	{
		if (index != this.CurrentTabIndex)
		{
			this.MainView.SetTabState(this.CurrentTabIndex, false, true);
		}
		this.CurrentTabIndex = index;
		UiDynamicTab data = this.TabDataList[index];
		this.MainView.SwitchTabView(data, index);
	}

	// Token: 0x04003D98 RID: 15768
	private RewardMainView MainView;

	// Token: 0x04003D99 RID: 15769
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04003D9A RID: 15770
	private int CurrentTabIndex;
}
