using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x02006435 RID: 25653
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorDecalLinkMainViewModel
	{
		// Token: 0x1700947E RID: 38014
		// (get) Token: 0x060407FB RID: 264187 RVA: 0x00F9C438 File Offset: 0x00F9A638
		public int ActivityId
		{
			get
			{
				return this.ActivityIdPrivate;
			}
		}

		// Token: 0x060407FC RID: 264188 RVA: 0x00F9C440 File Offset: 0x00F9A640
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

		// Token: 0x060407FD RID: 264189 RVA: 0x00F9C51D File Offset: 0x00F9A71D
		public void SelectIpIndex(int index)
		{
			if (index < 0 || index >= this.IpList.Count)
			{
				return;
			}
			this.CurrentIpIndex = index;
		}

		// Token: 0x060407FE RID: 264190 RVA: 0x00F9C53C File Offset: 0x00F9A73C
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

		// Token: 0x060407FF RID: 264191 RVA: 0x00F9C57C File Offset: 0x00F9A77C
		public void RefreshIpTaskStates(Dictionary<int, ActivityTaskData> activityQuestData)
		{
			foreach (MotorDecalLinkIpViewModel motorDecalLinkIpViewModel in this.IpList)
			{
				motorDecalLinkIpViewModel.RefreshTaskStates(activityQuestData);
			}
			this.RefreshProgress(activityQuestData);
		}

		// Token: 0x06040800 RID: 264192 RVA: 0x00F9C5D4 File Offset: 0x00F9A7D4
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

		// Token: 0x06040801 RID: 264193 RVA: 0x00F9C674 File Offset: 0x00F9A874
		[NullableContext(2)]
		public MotorDecalLinkIpViewModel GetCurrentIpViewModel()
		{
			if (this.CurrentIpIndex < 0 || this.CurrentIpIndex >= this.IpList.Count)
			{
				return null;
			}
			return this.IpList[this.CurrentIpIndex];
		}

		// Token: 0x04021870 RID: 137328
		private int ActivityIdPrivate;

		// Token: 0x04021871 RID: 137329
		public int HelpId;

		// Token: 0x04021872 RID: 137330
		public string CaptionTitle = "";

		// Token: 0x04021873 RID: 137331
		public List<MotorDecalLinkIpViewModel> IpList = new List<MotorDecalLinkIpViewModel>();

		// Token: 0x04021874 RID: 137332
		public int CurrentIpIndex;

		// Token: 0x04021875 RID: 137333
		public string ProgressText = "";

		// Token: 0x04021876 RID: 137334
		public int ProgressCompletedCount;

		// Token: 0x04021877 RID: 137335
		public int ProgressTotalCount;

		// Token: 0x04021878 RID: 137336
		public bool HasFirstRead;

		// Token: 0x04021879 RID: 137337
		public bool HasRewardCanReceive;
	}
}
