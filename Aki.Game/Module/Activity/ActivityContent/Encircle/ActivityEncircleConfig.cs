using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02002FFB RID: 12283
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityEncircleConfig : ConfigBase
	{
		// Token: 0x0601D284 RID: 119428 RVA: 0x008E850B File Offset: 0x008E670B
		public IReadOnlyList<EncircleMap> GetEncircleMap(int mapId)
		{
			return ConfigEncircleMapByMapId.GetConfigList(mapId, true);
		}

		// Token: 0x0601D285 RID: 119429 RVA: 0x008E8514 File Offset: 0x008E6714
		public IReadOnlyList<EncircleChallengeGroup> GetEncircleGroups(int activityId)
		{
			return ConfigEncircleChallengeGroupByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x0601D286 RID: 119430 RVA: 0x008E851D File Offset: 0x008E671D
		public EncircleChallengeGroup? GetEncircleGroup(int groupId)
		{
			return ConfigEncircleChallengeGroupById.GetConfig(groupId, true);
		}

		// Token: 0x0601D287 RID: 119431 RVA: 0x008E8528 File Offset: 0x008E6728
		public int[] GetEncircleChallenges(int activityId, int levelId)
		{
			IReadOnlyList<EncircleChallengeGroup> encircleGroups = this.GetEncircleGroups(activityId);
			if (encircleGroups != null && encircleGroups.Count > 0)
			{
				return encircleGroups[levelId - 1].Challenges();
			}
			return null;
		}

		// Token: 0x0601D288 RID: 119432 RVA: 0x008E855C File Offset: 0x008E675C
		public EncircleChallenge? GetEncircleChallengeConfig(int challengeId)
		{
			return ConfigEncircleChallengeById.GetConfig(challengeId, true);
		}

		// Token: 0x0601D289 RID: 119433 RVA: 0x008E8568 File Offset: 0x008E6768
		public EncircleHexType? GetMapItemType(int typeId)
		{
			if (ConfigEncircleMapItemById.GetConfig(typeId, true) == null)
			{
				return null;
			}
			EncircleMapItem? encircleMapItem;
			return new EncircleHexType?(encircleMapItem.GetValueOrDefault().Type);
		}

		// Token: 0x0601D28A RID: 119434 RVA: 0x008E85A4 File Offset: 0x008E67A4
		public string GetMapItemMemo(int typeId)
		{
			if (ConfigEncircleMapItemById.GetConfig(typeId, true) == null)
			{
				return null;
			}
			EncircleMapItem? encircleMapItem;
			return encircleMapItem.GetValueOrDefault().Memo;
		}

		// Token: 0x0601D28B RID: 119435 RVA: 0x008E85D4 File Offset: 0x008E67D4
		public string GetMapItemResource(int typeId)
		{
			if (ConfigEncircleMapItemById.GetConfig(typeId, true) == null)
			{
				return null;
			}
			EncircleMapItem? encircleMapItem;
			return encircleMapItem.GetValueOrDefault().ResourcePath;
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0601D28C RID: 119436 RVA: 0x008E8603 File Offset: 0x008E6803
		[Nullable(1)]
		public static ActivityEncircleConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return ActivityEncircleConfig._Instance;
			}
		}

		// Token: 0x0601D28D RID: 119437 RVA: 0x008E860A File Offset: 0x008E680A
		[NullableContext(1)]
		public static ActivityEncircleConfig GetOrCreateInstance()
		{
			if (ActivityEncircleConfig._Instance == null)
			{
				ActivityEncircleConfig.CreateInstance();
			}
			return ActivityEncircleConfig._Instance;
		}

		// Token: 0x0601D28E RID: 119438 RVA: 0x008E861E File Offset: 0x008E681E
		public static bool CreateInstance()
		{
			if (ActivityEncircleConfig._Instance != null)
			{
				return true;
			}
			ActivityEncircleConfig._Instance = new ActivityEncircleConfig();
			return true;
		}

		// Token: 0x0601D28F RID: 119439 RVA: 0x008E8634 File Offset: 0x008E6834
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601D290 RID: 119440 RVA: 0x008E8636 File Offset: 0x008E6836
		public static void ResetStaticDefaultValue()
		{
			ActivityEncircleConfig._Instance = null;
		}

		// Token: 0x0601D291 RID: 119441 RVA: 0x008E863E File Offset: 0x008E683E
		static ActivityEncircleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityEncircleConfig.CreateStaticDefaultValue), new Action(ActivityEncircleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0400F595 RID: 62869
		private static ActivityEncircleConfig _Instance;
	}
}
