using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000812 RID: 2066
[NullableContext(1)]
[Nullable(0)]
public class RewardInstanceController
{
	// Token: 0x06005DB8 RID: 23992 RVA: 0x001E12F3 File Offset: 0x001DF4F3
	public void RegisterMainView(RewardMainView mainView)
	{
		this.MainView = mainView;
	}

	// Token: 0x06005DB9 RID: 23993 RVA: 0x001E12FC File Offset: 0x001DF4FC
	public UniTask InitMainView()
	{
		RewardInstanceController.<InitMainView>d__4 <InitMainView>d__;
		<InitMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitMainView>d__.<>4__this = this;
		<InitMainView>d__.<>1__state = -1;
		<InitMainView>d__.<>t__builder.Start<RewardInstanceController.<InitMainView>d__4>(ref <InitMainView>d__);
		return <InitMainView>d__.<>t__builder.Task;
	}

	// Token: 0x06005DBA RID: 23994 RVA: 0x001E133F File Offset: 0x001DF53F
	public void RefreshTabList()
	{
		MoonChasingModel.Instance.GetRewardTabList();
		this.TabDataList = new List<UiDynamicTab>();
		this.MainView.SetTabState(0, true, true);
	}

	// Token: 0x06005DBB RID: 23995 RVA: 0x001E1368 File Offset: 0x001DF568
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

	// Token: 0x04003E30 RID: 15920
	private RewardMainView MainView;

	// Token: 0x04003E31 RID: 15921
	protected List<UiDynamicTab> TabDataList = new List<UiDynamicTab>();

	// Token: 0x04003E32 RID: 15922
	private int CurrentTabIndex;
}
