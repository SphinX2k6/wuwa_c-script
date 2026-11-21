using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x020053B3 RID: 21427
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorDecalLinkMainViewModel
	{
		// Token: 0x170067E0 RID: 26592
		// (get) Token: 0x060354BC RID: 218300 RVA: 0x00EE33B4 File Offset: 0x00EE15B4
		public int ActivityId
		{
			get
			{
				return this.ActivityIdPrivate;
			}
		}

		// Token: 0x060354BD RID: 218301 RVA: 0x00EE33BC File Offset: 0x00EE15BC
		public void InitFromActivityDataIfNot(MotorDecalLinkData activityData)
		{
			int num = (activityData != null) ? activityData.Id : 0;
			if (this.ActivityIdPrivate == num)
			{
				return;
			}
			this.ActivityIdPrivate = num;
			this.HelpId = ((activityData != null) ? activityData.GetHelpId() : 0);
			this.CaptionTitle = ((activityData != null) ? activityData.GetTitleTextId() : "");
			IReadOnlyList<MotorDecalIp> ipConfigListByActivityId = MotorDecalLinkConfig.Instance.GetIpConfigListByActivityId(num);
			List<int> list = new List<int>();
			for (int i = 0; i < ipConfigListByActivityId.Count; i++)
			{
				MotorDecalIp config = ipConfigListByActivityId[i];
				MotorDecalLinkIpViewModel motorDecalLinkIpViewModel = new MotorDecalLinkIpViewModel();
				motorDecalLinkIpViewModel.InitFromConfig(config, i);
				motorDecalLinkIpViewModel.ActivityId = num;
				this.IpList.Add(motorDecalLinkIpViewModel);
				list.Add(config.Id);
			}
			string message = "MainViewModel初始化";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ipList", list);
			MotorDecalLinkUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SelectIpIndex(0);
		}

		// Token: 0x060354BE RID: 218302 RVA: 0x00EE3499 File Offset: 0x00EE1699
		public void SelectIpIndex(int index)
		{
			if (index < 0 || index >= this.IpList.Count)
			{
				return;
			}
			this.CurrentIpIndex = index;
		}

		// Token: 0x060354BF RID: 218303 RVA: 0x00EE34B8 File Offset: 0x00EE16B8
		public void MoveSelectIpIndex(int delta)
		{
			int num = this.CurrentIpIndex + delta;
			num %= this.IpList.Count;
			if (num < 0)
			{
				num += this.IpList.Count;
			}
			this.SelectIpIndex(num);
		}

		// Token: 0x060354C0 RID: 218304 RVA: 0x00EE34F8 File Offset: 0x00EE16F8
		public void RefreshIpTaskStates(Dictionary<int, ActivityTaskData> activityQuestData)
		{
			foreach (MotorDecalLinkIpViewModel motorDecalLinkIpViewModel in this.IpList)
			{
				motorDecalLinkIpViewModel.RefreshTaskStates(activityQuestData);
			}
			this.RefreshProgress(activityQuestData);
		}

		// Token: 0x060354C1 RID: 218305 RVA: 0x00EE3550 File Offset: 0x00EE1750
		private void RefreshProgress(Dictionary<int, ActivityTaskData> activityQuestData)
		{
			this.ProgressTotalCount = activityQuestData.Count;
			this.ProgressCompletedCount = 0;
			foreach (KeyValuePair<int, ActivityTaskData> keyValuePair in activityQuestData)
			{
				if (keyValuePair.Value.Status == EActivityTaskState.FinishedAndClaimed)
				{
					this.ProgressCompletedCount++;
				}
			}
			this.ProgressText = this.ProgressCompletedCount.ToString() + "/" + this.ProgressTotalCount.ToString();
		}

		// Token: 0x060354C2 RID: 218306 RVA: 0x00EE35F0 File Offset: 0x00EE17F0
		[NullableContext(2)]
		public MotorDecalLinkIpViewModel GetCurrentIpViewModel()
		{
			if (this.CurrentIpIndex < 0 || this.CurrentIpIndex >= this.IpList.Count)
			{
				return null;
			}
			return this.IpList[this.CurrentIpIndex];
		}

		// Token: 0x0401C19F RID: 115103
		private int ActivityIdPrivate;

		// Token: 0x0401C1A0 RID: 115104
		public int HelpId;

		// Token: 0x0401C1A1 RID: 115105
		public string CaptionTitle = "";

		// Token: 0x0401C1A2 RID: 115106
		public List<MotorDecalLinkIpViewModel> IpList = new List<MotorDecalLinkIpViewModel>();

		// Token: 0x0401C1A3 RID: 115107
		public int CurrentIpIndex;

		// Token: 0x0401C1A4 RID: 115108
		public string ProgressText = "";

		// Token: 0x0401C1A5 RID: 115109
		public int ProgressCompletedCount;

		// Token: 0x0401C1A6 RID: 115110
		public int ProgressTotalCount;

		// Token: 0x0401C1A7 RID: 115111
		public bool HasFirstRead;

		// Token: 0x0401C1A8 RID: 115112
		public bool HasRewardCanReceive;
	}
}
