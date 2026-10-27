using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x02006436 RID: 25654
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorDecalLinkIpViewModel
	{
		// Token: 0x06040803 RID: 264195 RVA: 0x00F9C6D0 File Offset: 0x00F9A8D0
		public string GetNameLogoPath()
		{
			bool flag = LanguageSystem.Instance.PackageLanguage == "zh-Hans";
			bool flag2 = this.ChineseNameLogoPath.Length > 0;
			if (!flag || !flag2)
			{
				return this.DefaultNameLogoPath;
			}
			return this.ChineseNameLogoPath;
		}

		// Token: 0x06040804 RID: 264196 RVA: 0x00F9C714 File Offset: 0x00F9A914
		public unsafe void InitFromConfig(MotorDecalIp config, int index)
		{
			this.IpId = config.Id;
			this.IpIndex = index;
			this.StickerList = new List<int>();
			for (int i = 0; i < config.IpStickerListLength; i++)
			{
				this.StickerList.Add(config.IpStickerList(i));
			}
			this.DefaultNameLogoPath = (config.IpNamePath ?? "");
			this.ChineseNameLogoPath = (config.IpNamePathCN ?? "");
			this.MainPicturePath = config.BackgroundPath;
			this.TaskIdList = new List<int>();
			foreach (MotorDecalQuest motorDecalQuest in MotorDecalLinkConfig.Instance.GetTaskConfigListByIpId(config.Id))
			{
				this.TaskIdList.Add(motorDecalQuest.TaskId);
			}
			this.RefreshDecalDisplayFromStickerList();
			string message = "MotorDecalLinkIpViewModel初始化";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ipId", this.IpId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("defaultNameLogoPath", this.DefaultNameLogoPath);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("nameLogoPathCn", this.ChineseNameLogoPath);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("resolvedNameLogoPath", this.GetNameLogoPath());
			MotorDecalLinkUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x06040805 RID: 264197 RVA: 0x00F9C898 File Offset: 0x00F9AA98
		private void RefreshDecalDisplayFromStickerList()
		{
			this.DecalTexturePaths.Clear();
			this.DecalPreviewPaths.Clear();
			MotorDiyConfig instance = MotorDiyConfig.Instance;
			MotorDecalLinkConfig instance2 = MotorDecalLinkConfig.Instance;
			if (instance == null || this.StickerList.Count == 0)
			{
				return;
			}
			foreach (int num in this.StickerList)
			{
				MotorSticker? motorStickerConfig = instance.GetMotorStickerConfig(num);
				string item;
				if (motorStickerConfig == null)
				{
					item = "";
				}
				else
				{
					string text;
					if ((text = motorStickerConfig.Value.StickerIconPath) == null)
					{
						text = (motorStickerConfig.Value.Icon ?? "");
					}
					item = text;
				}
				this.DecalTexturePaths.Add(item);
				MotorDecalPreview? motorDecalPreview = (instance2 != null) ? instance2.GetStickerPreviewConfig(num) : null;
				string item2 = (motorDecalPreview != null) ? (motorDecalPreview.Value.PreviewPath ?? "") : "";
				this.DecalPreviewPaths.Add(item2);
			}
		}

		// Token: 0x06040806 RID: 264198 RVA: 0x00F9C9C4 File Offset: 0x00F9ABC4
		public void RefreshTaskStates(Dictionary<int, ActivityTaskData> activityQuestData)
		{
			this.TaskStateMap.Clear();
			foreach (int key in this.TaskIdList)
			{
				ActivityTaskData value;
				if (activityQuestData.TryGetValue(key, out value))
				{
					this.TaskStateMap[key] = value;
				}
			}
			this.RefreshQuestViewModelList();
		}

		// Token: 0x06040807 RID: 264199 RVA: 0x00F9CA3C File Offset: 0x00F9AC3C
		public void RefreshQuestViewModelList()
		{
			IEnumerable<MotorDecalQuest> taskConfigListByIpId = MotorDecalLinkConfig.Instance.GetTaskConfigListByIpId(this.IpId);
			List<List<MotorDecalQuest>> list = new List<List<MotorDecalQuest>>
			{
				new List<MotorDecalQuest>(),
				new List<MotorDecalQuest>(),
				new List<MotorDecalQuest>()
			};
			foreach (MotorDecalQuest item in taskConfigListByIpId)
			{
				ActivityTaskData activityTaskData;
				EActivityTaskState eactivityTaskState = this.TaskStateMap.TryGetValue(item.TaskId, out activityTaskData) ? activityTaskData.Status : EActivityTaskState.Active;
				if (eactivityTaskState == EActivityTaskState.FinishedAndUnclaimed)
				{
					list[0].Add(item);
				}
				else if (eactivityTaskState == EActivityTaskState.FinishedAndClaimed)
				{
					list[2].Add(item);
				}
				else
				{
					list[1].Add(item);
				}
			}
			List<int> list2 = new List<int>();
			foreach (List<MotorDecalQuest> list3 in list)
			{
				list3.Sort((MotorDecalQuest a, MotorDecalQuest b) => a.Sort - b.Sort);
				foreach (MotorDecalQuest motorDecalQuest in list3)
				{
					list2.Add(motorDecalQuest.TaskId);
				}
			}
			this.QuestViewModelList.Clear();
			foreach (int num in list2)
			{
				ActivityTaskData activityTaskData2;
				this.TaskStateMap.TryGetValue(num, out activityTaskData2);
				MotorDecalLinkQuestViewModel motorDecalLinkQuestViewModel = new MotorDecalLinkQuestViewModel();
				motorDecalLinkQuestViewModel.TaskId = num;
				motorDecalLinkQuestViewModel.IpId = this.IpId;
				motorDecalLinkQuestViewModel.ActivityId = this.ActivityId;
				motorDecalLinkQuestViewModel.Current = ((activityTaskData2 != null) ? activityTaskData2.Current : 0);
				motorDecalLinkQuestViewModel.Target = ((activityTaskData2 != null) ? activityTaskData2.Target : 1);
				motorDecalLinkQuestViewModel.Status = ((activityTaskData2 != null) ? activityTaskData2.Status : EActivityTaskState.Active);
				MotorDecalQuest? taskConfig = MotorDecalLinkConfig.Instance.GetTaskConfig(num);
				if (taskConfig != null)
				{
					motorDecalLinkQuestViewModel.TaskName = taskConfig.Value.TaskName;
					motorDecalLinkQuestViewModel.AccessId = taskConfig.Value.AccessId;
					for (int i = 0; i < taskConfig.Value.RewardInfoLength; i++)
					{
						DicIntInt? dicIntInt = taskConfig.Value.RewardInfo(i);
						if (dicIntInt != null)
						{
							motorDecalLinkQuestViewModel.RewardInfo[dicIntInt.Value.Key] = dicIntInt.Value.Value;
						}
					}
				}
				this.QuestViewModelList.Add(motorDecalLinkQuestViewModel);
			}
		}

		// Token: 0x0402187A RID: 137338
		public int IpId;

		// Token: 0x0402187B RID: 137339
		public int ActivityId;

		// Token: 0x0402187C RID: 137340
		public int IpIndex;

		// Token: 0x0402187D RID: 137341
		public List<int> StickerList = new List<int>();

		// Token: 0x0402187E RID: 137342
		public List<int> TaskIdList = new List<int>();

		// Token: 0x0402187F RID: 137343
		private string DefaultNameLogoPath = "";

		// Token: 0x04021880 RID: 137344
		private string ChineseNameLogoPath = "";

		// Token: 0x04021881 RID: 137345
		public string MainPicturePath = "";

		// Token: 0x04021882 RID: 137346
		public List<MotorDecalLinkQuestViewModel> QuestViewModelList = new List<MotorDecalLinkQuestViewModel>();

		// Token: 0x04021883 RID: 137347
		public List<string> DecalTexturePaths = new List<string>();

		// Token: 0x04021884 RID: 137348
		public List<string> DecalPreviewPaths = new List<string>();

		// Token: 0x04021885 RID: 137349
		private readonly Dictionary<int, ActivityTaskData> TaskStateMap = new Dictionary<int, ActivityTaskData>();
	}
}
