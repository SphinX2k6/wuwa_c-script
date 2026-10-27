using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ResManager;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200485A RID: 18522
	[NullableContext(2)]
	[Nullable(0)]
	public class RegionalTerminalActivityData : RegionalTerminalGameplayData
	{
		// Token: 0x17007917 RID: 30999
		// (get) Token: 0x0603079B RID: 198555 RVA: 0x00B41AAA File Offset: 0x00B3FCAA
		private ActivityBaseData ActivityBaseData
		{
			get
			{
				return ActivityModel.Instance.GetActivityById(this.GameplayId);
			}
		}

		// Token: 0x0603079C RID: 198556 RVA: 0x00B41ABC File Offset: 0x00B3FCBC
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
				SubPackageDownLoadModel.Instance.OpenSubPackageDownLoadConfirmBySubPackageIds(this.ActivityBaseData.LocalConfig.Value.AreaTips, downLoadSubPackageListArray.ToList<int>());
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

		// Token: 0x0603079D RID: 198557 RVA: 0x00B41C6B File Offset: 0x00B3FE6B
		public override void BarFunction()
		{
			if (this.GetLockState())
			{
				RegionalTerminalController.Instance.OpenTerminalOverviewView(this.Id);
				return;
			}
			this.TerminalFunction(null);
		}

		// Token: 0x0603079E RID: 198558 RVA: 0x00B41C8D File Offset: 0x00B3FE8D
		public override bool GetShowState()
		{
			return ActivityModel.Instance.IsActivityOpen(this.GameplayId);
		}

		// Token: 0x0603079F RID: 198559 RVA: 0x00B41CA0 File Offset: 0x00B3FEA0
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

		// Token: 0x060307A0 RID: 198560 RVA: 0x00B41CEE File Offset: 0x00B3FEEE
		public override int GetRedDotId()
		{
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			if (activityBaseData == null)
			{
				return 0;
			}
			return activityBaseData.GetExternalButtonRedPointId();
		}

		// Token: 0x060307A1 RID: 198561 RVA: 0x00B41D01 File Offset: 0x00B3FF01
		public override bool GetRedDotState()
		{
			if (this.GetLockState())
			{
				return false;
			}
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			return activityBaseData != null && activityBaseData.GetExternalButtonRedPointState();
		}

		// Token: 0x060307A2 RID: 198562 RVA: 0x00B41D1E File Offset: 0x00B3FF1E
		public override bool GetLockState()
		{
			if (!this.GetShowState())
			{
				return true;
			}
			ActivityBaseData activityBaseData = this.ActivityBaseData;
			return activityBaseData == null || !activityBaseData.IsUnLock();
		}

		// Token: 0x060307A3 RID: 198563 RVA: 0x00B41D40 File Offset: 0x00B3FF40
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

		// Token: 0x060307A4 RID: 198564 RVA: 0x00B41DFC File Offset: 0x00B3FFFC
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
