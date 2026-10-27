using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F9D RID: 24477
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPickRoleChoicePanel : UiPanelBase
	{
		// Token: 0x0603E15B RID: 254299 RVA: 0x00EFE16B File Offset: 0x00EFC36B
		public TotalTopUpPickRoleChoicePanel(List<ITotalTopUpPickRoleRewardItemData> rewardDataList)
		{
			this.RewardDataList = rewardDataList;
		}

		// Token: 0x0603E15C RID: 254300 RVA: 0x00EFE19C File Offset: 0x00EFC39C
		public void SetSelectCallback(Action<ITotalTopUpPickRoleRewardItemData> callback)
		{
			this.SelectCallBack = callback;
		}

		// Token: 0x0603E15D RID: 254301 RVA: 0x00EFE1A8 File Offset: 0x00EFC3A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			foreach (int item in this.PosNodeList)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(item, typeof(UUIItem)));
			}
		}

		// Token: 0x0603E15E RID: 254302 RVA: 0x00EFE1F4 File Offset: 0x00EFC3F4
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPickRoleChoicePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPickRoleChoicePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E15F RID: 254303 RVA: 0x00EFE237 File Offset: 0x00EFC437
		private void OnClickItemCallback(ITotalTopUpPickRoleRewardItemData data)
		{
			this.SelectItem(data.Index);
		}

		// Token: 0x0603E160 RID: 254304 RVA: 0x00EFE248 File Offset: 0x00EFC448
		public void SelectItem(int index)
		{
			for (int i = 0; i < this.RewardItems.Count; i++)
			{
				TotalTopUpPickRoleRewardItem totalTopUpPickRoleRewardItem = this.RewardItems[i];
				bool selected = i == index;
				totalTopUpPickRoleRewardItem.SetSelected(selected);
			}
			if (this.SelectCallBack != null)
			{
				ITotalTopUpPickRoleRewardItemData obj = this.RewardDataList[index];
				this.SelectCallBack(obj);
			}
		}

		// Token: 0x040206E0 RID: 132832
		private readonly int[] PosNodeList = new int[]
		{
			0,
			1,
			2,
			3
		};

		// Token: 0x040206E1 RID: 132833
		private readonly List<TotalTopUpPickRoleRewardItem> RewardItems = new List<TotalTopUpPickRoleRewardItem>();

		// Token: 0x040206E2 RID: 132834
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ITotalTopUpPickRoleRewardItemData> SelectCallBack;

		// Token: 0x040206E3 RID: 132835
		private readonly List<ITotalTopUpPickRoleRewardItemData> RewardDataList;
	}
}
