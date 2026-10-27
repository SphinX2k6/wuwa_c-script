using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02006398 RID: 25496
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class MultiMotorModel : ModelBase
	{
		// Token: 0x17009368 RID: 37736
		// (get) Token: 0x06040200 RID: 262656 RVA: 0x00F86188 File Offset: 0x00F84388
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

		// Token: 0x06040201 RID: 262657 RVA: 0x00F861B4 File Offset: 0x00F843B4
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

		// Token: 0x06040202 RID: 262658 RVA: 0x00F86220 File Offset: 0x00F84420
		public bool GetLevelUnLock(int levelId)
		{
			MultiMotorData activityData = this.ActivityData;
			MultiMotorLevelData multiMotorLevelData = (activityData != null) ? activityData.LevelDataMap.GetValueOrDefault(levelId) : null;
			return multiMotorLevelData != null && multiMotorLevelData.IsUnLock;
		}

		// Token: 0x06040203 RID: 262659 RVA: 0x00F86251 File Offset: 0x00F84451
		[NullableContext(2)]
		public Dictionary<int, int> GetLevelRankBattleMap()
		{
			if (this.ActivityData == null)
			{
				return null;
			}
			return this.ActivityData.LevelBattleRankMap;
		}

		// Token: 0x06040204 RID: 262660 RVA: 0x00F86268 File Offset: 0x00F84468
		public bool CheckInMultiMotorEditFormationState()
		{
			InstanceDungeon? dungeonConfig = BattleTeamModel.Instance.Context.GetDungeonConfig();
			return dungeonConfig != null && dungeonConfig.Value.InstSubType == 57;
		}

		// Token: 0x17009369 RID: 37737
		// (get) Token: 0x06040205 RID: 262661 RVA: 0x00F862A3 File Offset: 0x00F844A3
		public static MultiMotorModel Instance
		{
			get
			{
				return MultiMotorModel._Instance;
			}
		}

		// Token: 0x06040206 RID: 262662 RVA: 0x00F862AA File Offset: 0x00F844AA
		public static MultiMotorModel GetOrCreateInstance()
		{
			if (MultiMotorModel._Instance == null)
			{
				MultiMotorModel.CreateInstance();
			}
			return MultiMotorModel._Instance;
		}

		// Token: 0x06040207 RID: 262663 RVA: 0x00F862BE File Offset: 0x00F844BE
		public static bool CreateInstance()
		{
			if (MultiMotorModel._Instance != null)
			{
				return true;
			}
			MultiMotorModel._Instance = new MultiMotorModel();
			return true;
		}

		// Token: 0x06040208 RID: 262664 RVA: 0x00F862D4 File Offset: 0x00F844D4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040209 RID: 262665 RVA: 0x00F862D6 File Offset: 0x00F844D6
		public static void ResetStaticDefaultValue()
		{
			MultiMotorModel._Instance = null;
		}

		// Token: 0x0604020A RID: 262666 RVA: 0x00F862DE File Offset: 0x00F844DE
		static MultiMotorModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MultiMotorModel.CreateStaticDefaultValue), new Action(MultiMotorModel.ResetStaticDefaultValue));
		}

		// Token: 0x04021697 RID: 136855
		public int ActivityId;

		// Token: 0x04021698 RID: 136856
		public long StartFlowTime;

		// Token: 0x04021699 RID: 136857
		[Nullable(2)]
		private static MultiMotorModel _Instance;
	}
}
