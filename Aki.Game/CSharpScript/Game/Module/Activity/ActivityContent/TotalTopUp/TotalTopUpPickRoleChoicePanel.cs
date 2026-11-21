using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F84 RID: 20356
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpPickRoleChoicePanel : UiPanelBase
	{
		// Token: 0x060330F5 RID: 209141 RVA: 0x00E4FE23 File Offset: 0x00E4E023
		public TotalTopUpPickRoleChoicePanel(List<ITotalTopUpPickRoleRewardItemData> rewardDataList)
		{
			this.RewardDataList = rewardDataList;
		}

		// Token: 0x060330F6 RID: 209142 RVA: 0x00E4FE54 File Offset: 0x00E4E054
		public void SetSelectCallback(Action<ITotalTopUpPickRoleRewardItemData> callback)
		{
			this.SelectCallBack = callback;
		}

		// Token: 0x060330F7 RID: 209143 RVA: 0x00E4FE60 File Offset: 0x00E4E060
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>();
			foreach (int item in this.PosNodeList)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(item, typeof(UUIItem)));
			}
		}

		// Token: 0x060330F8 RID: 209144 RVA: 0x00E4FEAC File Offset: 0x00E4E0AC
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPickRoleChoicePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPickRoleChoicePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060330F9 RID: 209145 RVA: 0x00E4FEEF File Offset: 0x00E4E0EF
		private void OnClickItemCallback(ITotalTopUpPickRoleRewardItemData data)
		{
			this.SelectItem(data.Index);
		}

		// Token: 0x060330FA RID: 209146 RVA: 0x00E4FF00 File Offset: 0x00E4E100
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

		// Token: 0x0401B1B2 RID: 111026
		private readonly int[] PosNodeList = new int[]
		{
			0,
			1,
			2,
			3
		};

		// Token: 0x0401B1B3 RID: 111027
		private readonly List<TotalTopUpPickRoleRewardItem> RewardItems = new List<TotalTopUpPickRoleRewardItem>();

		// Token: 0x0401B1B4 RID: 111028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ITotalTopUpPickRoleRewardItemData> SelectCallBack;

		// Token: 0x0401B1B5 RID: 111029
		private readonly List<ITotalTopUpPickRoleRewardItemData> RewardDataList;
	}
}
