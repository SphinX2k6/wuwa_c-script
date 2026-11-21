using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005364 RID: 21348
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourActivityData : ActivityBaseData
	{
		// Token: 0x060351EB RID: 217579 RVA: 0x00ED5E02 File Offset: 0x00ED4002
		protected override void OnInit(ActivityData data)
		{
			this.InitMotorParkourLevel();
		}

		// Token: 0x060351EC RID: 217580 RVA: 0x00ED5E0C File Offset: 0x00ED400C
		protected override void PhraseEx(ActivityData data)
		{
			MotorParkourActivityInfo motorParkourActivityInfo = data.MotorParkourActivityInfo;
			if (motorParkourActivityInfo == null)
			{
				return;
			}
			this.UpdateMotorParkourLevelList(motorParkourActivityInfo.MotorParkourLevelInfos);
		}

		// Token: 0x060351ED RID: 217581 RVA: 0x00ED5E30 File Offset: 0x00ED4030
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

		// Token: 0x060351EE RID: 217582 RVA: 0x00ED5E94 File Offset: 0x00ED4094
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

		// Token: 0x060351EF RID: 217583 RVA: 0x00ED5EF0 File Offset: 0x00ED40F0
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

		// Token: 0x060351F0 RID: 217584 RVA: 0x00ED5FC8 File Offset: 0x00ED41C8
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

		// Token: 0x060351F1 RID: 217585 RVA: 0x00ED605C File Offset: 0x00ED425C
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

		// Token: 0x060351F2 RID: 217586 RVA: 0x00ED608C File Offset: 0x00ED428C
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

		// Token: 0x060351F3 RID: 217587 RVA: 0x00ED612C File Offset: 0x00ED432C
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

		// Token: 0x060351F4 RID: 217588 RVA: 0x00ED6194 File Offset: 0x00ED4394
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

		// Token: 0x060351F5 RID: 217589 RVA: 0x00ED61F0 File Offset: 0x00ED43F0
		public List<MotorParkourLevelData> GetLevelDataList()
		{
			return this.LevelDataList;
		}

		// Token: 0x060351F6 RID: 217590 RVA: 0x00ED61F8 File Offset: 0x00ED43F8
		public MotorParkourLevelData GetLevelDataById(int levelId)
		{
			MotorParkourLevelData result;
			this.MotorParkourLevelMap.TryGetValue(levelId, out result);
			return result;
		}

		// Token: 0x060351F7 RID: 217591 RVA: 0x00ED6218 File Offset: 0x00ED4418
		public int GetAllTaskNum()
		{
			int num = 0;
			foreach (MotorParkourLevelData motorParkourLevelData in this.LevelDataList)
			{
				num += motorParkourLevelData.AllTaskNum;
			}
			return num;
		}

		// Token: 0x060351F8 RID: 217592 RVA: 0x00ED6270 File Offset: 0x00ED4470
		public int GetFinishedTaskNum()
		{
			int num = 0;
			foreach (MotorParkourLevelData motorParkourLevelData in this.LevelDataList)
			{
				num += motorParkourLevelData.FinishedTaskNum;
			}
			return num;
		}

		// Token: 0x0401C097 RID: 114839
		private readonly Dictionary<int, MotorParkourLevelData> MotorParkourLevelMap = new Dictionary<int, MotorParkourLevelData>();

		// Token: 0x0401C098 RID: 114840
		private readonly List<MotorParkourLevelData> LevelDataList = new List<MotorParkourLevelData>();
	}
}
