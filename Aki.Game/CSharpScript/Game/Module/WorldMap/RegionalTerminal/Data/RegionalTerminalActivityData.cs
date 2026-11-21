using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ResManager;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200378B RID: 14219
	[NullableContext(2)]
	[Nullable(0)]
	public class RegionalTerminalActivityData : RegionalTerminalGameplayData
	{
		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x06024F6A RID: 151402 RVA: 0x00A71CEE File Offset: 0x00A6FEEE
		private ActivityBaseData ActivityBaseData
		{
			get
			{
				return ActivityModel.Instance.GetActivityById(this.GameplayId);
			}
		}

		// Token: 0x06024F6B RID: 151403 RVA: 0x00A71D00 File Offset: 0x00A6FF00
		public override void TerminalFunction(Action<bool> callback = null)
		{
			if (this.ActivityBaseData == null)
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			if (!this.GetShowState())
			{
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			AreaTerminalActivitySkipLogEvent areaTerminalActivitySkipLogEvent = new AreaTerminalActivitySkipLogEvent();
			areaTerminalActivitySkipLogEvent.i_id = this.Id;
			if (this.ActivityBaseData.CanPreOpen() && !this.ActivityBaseData.IsUnLock())
			{
				ActivityController.Instance.OpenActivityById(this.ActivityBaseData.Id, EActivityViewOpenType.Other, null, null);
				if (callback != null)
				{
					callback(true);
				}
				areaTerminalActivitySkipLogEvent.i_type = 3;
				LogReportController.Instance.LogReport(areaTerminalActivitySkipLogEvent);
				return;
			}
			if (!SubPackageDownLoadModel.Instance.CheckActivityTeleportHaveSubPackage(this.ActivityBaseData.Id))
			{
				int[] downLoadSubPackageListArray = this.ActivityBaseData.LocalConfig.Value.GetDownLoadSubPackageListArray();
				foreach (int id in downLoadSubPackageListArray)
				{
					DownLoadSubPackage? downLoadSubPackageById = SubPackageConfig.Instance.GetDownLoadSubPackageById(id);
					if (downLoadSubPackageById != null)
					{
						foreach (int blockId in downLoadSubPackageById.Value.GetAreaArray())
						{
							if (ResourceManagerController.Instance.IsNeedReOpenMap(blockId))
							{
								SubPackageDownLoadModel.Instance.OpenBlockNeedReLoginConfirm();
								return;
							}
						}
					}
				}
				SubPackageDownLoadModel.Instance.OpenSubPackageDownLoadConfirmBySubPackageIds(this.ActivityBaseData.LocalConfig.Value.AreaTips, new List<int>(downLoadSubPackageListArray));
				return;
			}
			ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
			if (callback != null)
			{
				callback(true);
			}
			if (this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				areaTerminalActivitySkipLogEvent.i_type = 4;
			}
			else
			{
				areaTerminalActivitySkipLogEvent.i_type = 2;
			}
			LogReportController.Instance.LogReport(areaTerminalActivitySkipLogEvent);
		}

		// Token: 0x06024F6C RID: 151404 RVA: 0x00A71EAF File Offset: 0x00A700AF
		public override void BarFunction()
		{
			if (this.GetLockState())
			{
				RegionalTerminalController.Instance.OpenTerminalOverviewView(this.Id);
				return;
			}
			this.TerminalFunction(null);
		}

		// Token: 0x06024F6D RID: 151405 RVA: 0x00A71ED1 File Offset: 0x00A700D1
		public override bool GetShowState()
		{
			return ActivityModel.Instance.IsActivityOpen(this.GameplayId);
		}

		// Token: 0x06024F6E RID: 151406 RVA: 0x00A71EE4 File Offset: 0x00A700E4
		public override ERedDotName? GetRedDotName()
		{
			if (this.GetLockState())
			{
				return null;
			}
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			ERedDotName? result = (activityBaseData != null) ? activityBaseData.GetExternalButtonRedPointName() : null;
			if (result == null)
			{
				return null;
			}
			return result;
		}

		// Token: 0x06024F6F RID: 151407 RVA: 0x00A71F32 File Offset: 0x00A70132
		public override int GetRedDotId()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			if (activityBaseData == null)
			{
				return 0;
			}
			return activityBaseData.GetExternalButtonRedPointId();
		}

		// Token: 0x06024F70 RID: 151408 RVA: 0x00A71F45 File Offset: 0x00A70145
		public override bool GetRedDotState()
		{
			if (this.GetLockState())
			{
				return false;
			}
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			return activityBaseData != null && activityBaseData.GetExternalButtonRedPointState();
		}

		// Token: 0x06024F71 RID: 151409 RVA: 0x00A71F62 File Offset: 0x00A70162
		public override bool GetLockState()
		{
			if (!this.GetShowState())
			{
				return true;
			}
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			return activityBaseData == null || !activityBaseData.IsUnLock();
		}

		// Token: 0x06024F72 RID: 151410 RVA: 0x00A71F84 File Offset: 0x00A70184
		[NullableContext(1)]
		public override IRegionalTerminalViewParams GetViewParams()
		{
			bool lockState = this.GetLockState();
			bool flag = this.ActivityBaseData.CanPreOpen() && lockState;
			bool flag2 = this.ActivityBaseData.HasPreOpenCondition();
			bool flag3 = !flag && lockState;
			int num = 0;
			if (!flag2)
			{
				num = this.ActivityBaseData.ConditionGroupId;
			}
			else if (!flag)
			{
				num = this.ActivityBaseData.PreOpenConditionGroupId;
			}
			return new RegionalTerminalViewParams
			{
				ShowLockPanel = flag3,
				ShowButton = !flag3,
				LockClickFunc = delegate
				{
					ActivityController.Instance.OpenActivityConditionView(this.ActivityBaseData.Id);
					AreaTerminalActivitySkipLogEvent areaTerminalActivitySkipLogEvent = new AreaTerminalActivitySkipLogEvent();
					areaTerminalActivitySkipLogEvent.i_id = this.Id;
					areaTerminalActivitySkipLogEvent.i_type = 1;
					LogReportController.Instance.LogReport(areaTerminalActivitySkipLogEvent);
				},
				LockTxtId = ((num > 0) ? (LevelGeneralCommons.GetConditionGroupHintText(num) ?? "") : ""),
				ButtonTxtId = (flag ? "Terminal_Area_UnlockInAdvance" : base.GetGameplayConfig().UnlockButtonText)
			};
		}

		// Token: 0x06024F73 RID: 151411 RVA: 0x00A72040 File Offset: 0x00A70240
		public override List<TItem> GetRewardPreviewList()
		{
			List<TItem> rewardPreviewList = base.GetRewardPreviewList();
			if (rewardPreviewList != null && rewardPreviewList.Count > 0)
			{
				return rewardPreviewList;
			}
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			List<TItem> list = (activityBaseData != null) ? activityBaseData.GetPreviewReward(null) : null;
			if (list == null || list.Count <= 0)
			{
				return null;
			}
			return list;
		}
	}
}
