using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063E6 RID: 25574
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourActivityData : ActivityBaseData
	{
		// Token: 0x0604052A RID: 263466 RVA: 0x00F8EE6A File Offset: 0x00F8D06A
		protected override void OnInit(ActivityData data)
		{
			this.InitMotorParkourLevel();
		}

		// Token: 0x0604052B RID: 263467 RVA: 0x00F8EE74 File Offset: 0x00F8D074
		protected override void PhraseEx(ActivityData data)
		{
			MotorParkourActivityInfo motorParkourActivityInfo = data.MotorParkourActivityInfo;
			if (motorParkourActivityInfo == null)
			{
				return;
			}
			this.UpdateMotorParkourLevelList(motorParkourActivityInfo.MotorParkourLevelInfos);
		}

		// Token: 0x0604052C RID: 263468 RVA: 0x00F8EE98 File Offset: 0x00F8D098
		public override bool GetExDataRedPointShowState()
		{
			foreach (MotorParkourLevelData motorParkourLevelData in this.LevelDataList)
			{
				if (motorParkourLevelData.HasLevelRedDot || motorParkourLevelData.HasRewardRedDot)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604052D RID: 263469 RVA: 0x00F8EEFC File Offset: 0x00F8D0FC
		protected override bool GetExDataFinishShowState()
		{
			using (List<MotorParkourLevelData>.Enumerator enumerator = this.LevelDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsFinished)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0604052E RID: 263470 RVA: 0x00F8EF58 File Offset: 0x00F8D158
		private void InitMotorParkourLevel()
		{
			foreach (MotorParkour config in MotorParkourConfig.Instance.GetMotorParkourLevelByActivityId(base.Id))
			{
				MotorParkourLevelData motorParkourLevelData = new MotorParkourLevelData(config);
				this.MotorParkourLevelMap.Add(config.Id, motorParkourLevelData);
				this.LevelDataList.Add(motorParkourLevelData);
			}
			this.LevelDataList.Sort((MotorParkourLevelData a, MotorParkourLevelData b) => a.Id - b.Id);
			for (int i = 1; i < this.LevelDataList.Count; i++)
			{
				this.LevelDataList[i].PreMotorParkourLevelData = this.LevelDataList[i - 1];
			}
		}

		// Token: 0x0604052F RID: 263471 RVA: 0x00F8F030 File Offset: 0x00F8D230
		public void UpdateMotorParkourLevelList(IReadOnlyList<MotorParkourLevelInfo> infoList)
		{
			foreach (MotorParkourLevelInfo motorParkourLevelInfo in infoList)
			{
				int motorParkourId = motorParkourLevelInfo.MotorParkourId;
				MotorParkourLevelData motorParkourLevelData;
				if (!this.MotorParkourLevelMap.TryGetValue(motorParkourId, out motorParkourLevelData))
				{
					return;
				}
				motorParkourLevelData.UpdateTaskStatus(motorParkourLevelInfo.RewardStates);
				motorParkourLevelData.UnlockTime = motorParkourLevelInfo.UnlockTime;
				motorParkourLevelData.BestRecordTime = motorParkourLevelInfo.BestPassTime;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06040530 RID: 263472 RVA: 0x00F8F0C4 File Offset: 0x00F8D2C4
		public bool UpdateMotorParkourLevelBestRecordTime(int levelId, int time)
		{
			MotorParkourLevelData levelDataById = this.GetLevelDataById(levelId);
			if (time <= levelDataById.BestRecordTime || levelDataById.BestRecordTime == 0)
			{
				levelDataById.BestRecordTime = time;
				return true;
			}
			return false;
		}

		// Token: 0x06040531 RID: 263473 RVA: 0x00F8F0F4 File Offset: 0x00F8D2F4
		public MotorParkourLevelData GetSelectedLevelData()
		{
			int num = -1;
			int num2 = -1;
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				MotorParkourLevelData motorParkourLevelData = this.LevelDataList[i];
				if (motorParkourLevelData.HasRewardRedDot)
				{
					return motorParkourLevelData;
				}
				if (motorParkourLevelData.IsUnLock && !motorParkourLevelData.IsPass && num == -1)
				{
					num = i;
				}
				if (!motorParkourLevelData.IsUnLock && num2 == -1)
				{
					num2 = i;
				}
			}
			if (num != -1)
			{
				return this.LevelDataList[num];
			}
			if (num2 > 0)
			{
				return this.LevelDataList[num2 - 1];
			}
			return this.LevelDataList[this.LevelDataList.Count - 1];
		}

		// Token: 0x06040532 RID: 263474 RVA: 0x00F8F194 File Offset: 0x00F8D394
		public MotorParkourLevelData GetSelectedLevelDataInRewardView()
		{
			int num = -1;
			for (int i = 0; i < this.LevelDataList.Count; i++)
			{
				MotorParkourLevelData motorParkourLevelData = this.LevelDataList[i];
				if (motorParkourLevelData.HasRewardRedDot)
				{
					return motorParkourLevelData;
				}
				if (num == -1 && !motorParkourLevelData.IsFinished)
				{
					num = i;
				}
			}
			if (num != -1)
			{
				return this.LevelDataList[num];
			}
			return this.LevelDataList[0];
		}

		// Token: 0x06040533 RID: 263475 RVA: 0x00F8F1FC File Offset: 0x00F8D3FC
		public bool RewardHasRedDot()
		{
			using (List<MotorParkourLevelData>.Enumerator enumerator = this.LevelDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.HasRewardRedDot)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06040534 RID: 263476 RVA: 0x00F8F258 File Offset: 0x00F8D458
		public List<MotorParkourLevelData> GetLevelDataList()
		{
			return this.LevelDataList;
		}

		// Token: 0x06040535 RID: 263477 RVA: 0x00F8F260 File Offset: 0x00F8D460
		public MotorParkourLevelData GetLevelDataById(int levelId)
		{
			MotorParkourLevelData result;
			this.MotorParkourLevelMap.TryGetValue(levelId, out result);
			return result;
		}

		// Token: 0x06040536 RID: 263478 RVA: 0x00F8F280 File Offset: 0x00F8D480
		public int GetAllTaskNum()
		{
			int num = 0;
			foreach (MotorParkourLevelData motorParkourLevelData in this.LevelDataList)
			{
				num += motorParkourLevelData.AllTaskNum;
			}
			return num;
		}

		// Token: 0x06040537 RID: 263479 RVA: 0x00F8F2D8 File Offset: 0x00F8D4D8
		public int GetFinishedTaskNum()
		{
			int num = 0;
			foreach (MotorParkourLevelData motorParkourLevelData in this.LevelDataList)
			{
				num += motorParkourLevelData.FinishedTaskNum;
			}
			return num;
		}

		// Token: 0x04021768 RID: 137064
		private readonly Dictionary<int, MotorParkourLevelData> MotorParkourLevelMap = new Dictionary<int, MotorParkourLevelData>();

		// Token: 0x04021769 RID: 137065
		private readonly List<MotorParkourLevelData> LevelDataList = new List<MotorParkourLevelData>();
	}
}
