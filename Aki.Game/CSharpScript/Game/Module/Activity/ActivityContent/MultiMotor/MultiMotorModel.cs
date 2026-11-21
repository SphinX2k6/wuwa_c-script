using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02005316 RID: 21270
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MultiMotorModel : ModelBase
	{
		// Token: 0x170066CA RID: 26314
		// (get) Token: 0x06034EC1 RID: 216769 RVA: 0x00ECD0FC File Offset: 0x00ECB2FC
		[Nullable(2)]
		public MultiMotorData ActivityData
		{
			[NullableContext(2)]
			get
			{
				ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(this.ActivityId);
				if (activityById == null)
				{
					return null;
				}
				return activityById as MultiMotorData;
			}
		}

		// Token: 0x06034EC2 RID: 216770 RVA: 0x00ECD128 File Offset: 0x00ECB328
		public List<int> GetCurrentOpenActivityAllLevel()
		{
			IReadOnlyList<OnlineMotorLevel> allMotorMultiParkourLevel = MultiMotorConfig.Instance.GetAllMotorMultiParkourLevel();
			List<int> list = new List<int>();
			IReadOnlyList<OnlineMotorLevel> readOnlyList = allMotorMultiParkourLevel;
			foreach (OnlineMotorLevel onlineMotorLevel in (readOnlyList ?? new List<OnlineMotorLevel>()))
			{
				list.Add(onlineMotorLevel.Id);
			}
			return list;
		}

		// Token: 0x06034EC3 RID: 216771 RVA: 0x00ECD194 File Offset: 0x00ECB394
		public bool GetLevelUnLock(int levelId)
		{
			MultiMotorData activityData = this.ActivityData;
			MultiMotorLevelData multiMotorLevelData = (activityData != null) ? activityData.LevelDataMap.GetValueOrDefault(levelId) : null;
			return multiMotorLevelData != null && multiMotorLevelData.IsUnLock;
		}

		// Token: 0x06034EC4 RID: 216772 RVA: 0x00ECD1C5 File Offset: 0x00ECB3C5
		[NullableContext(2)]
		public Dictionary<int, int> GetLevelRankBattleMap()
		{
			if (this.ActivityData == null)
			{
				return null;
			}
			return this.ActivityData.LevelBattleRankMap;
		}

		// Token: 0x06034EC5 RID: 216773 RVA: 0x00ECD1DC File Offset: 0x00ECB3DC
		public bool CheckInMultiMotorEditFormationState()
		{
			InstanceDungeon? dungeonConfig = BattleTeamModel.Instance.Context.GetDungeonConfig();
			return dungeonConfig != null && dungeonConfig.Value.InstSubType == 57;
		}

		// Token: 0x170066CB RID: 26315
		// (get) Token: 0x06034EC6 RID: 216774 RVA: 0x00ECD217 File Offset: 0x00ECB417
		public static MultiMotorModel Instance
		{
			get
			{
				return MultiMotorModel._Instance;
			}
		}

		// Token: 0x06034EC7 RID: 216775 RVA: 0x00ECD21E File Offset: 0x00ECB41E
		public static MultiMotorModel GetOrCreateInstance()
		{
			if (MultiMotorModel._Instance == null)
			{
				MultiMotorModel.CreateInstance();
			}
			return MultiMotorModel._Instance;
		}

		// Token: 0x06034EC8 RID: 216776 RVA: 0x00ECD232 File Offset: 0x00ECB432
		public static bool CreateInstance()
		{
			if (MultiMotorModel._Instance != null)
			{
				return true;
			}
			MultiMotorModel._Instance = new MultiMotorModel();
			return true;
		}

		// Token: 0x06034EC9 RID: 216777 RVA: 0x00ECD248 File Offset: 0x00ECB448
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034ECA RID: 216778 RVA: 0x00ECD24A File Offset: 0x00ECB44A
		public static void ResetStaticDefaultValue()
		{
			MultiMotorModel._Instance = null;
		}

		// Token: 0x06034ECB RID: 216779 RVA: 0x00ECD252 File Offset: 0x00ECB452
		static MultiMotorModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MultiMotorModel.CreateStaticDefaultValue), new Action(MultiMotorModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401BFC6 RID: 114630
		public int ActivityId;

		// Token: 0x0401BFC7 RID: 114631
		public long StartFlowTime;

		// Token: 0x0401BFC8 RID: 114632
		[Nullable(2)]
		private static MultiMotorModel _Instance;
	}
}
