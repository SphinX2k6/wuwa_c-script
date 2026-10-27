using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200664E RID: 26190
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityEncircleConfig : ConfigBase
	{
		// Token: 0x06041A66 RID: 268902 RVA: 0x00FECAC7 File Offset: 0x00FEACC7
		public IReadOnlyList<EncircleMap> GetEncircleMap(int mapId)
		{
			return ConfigEncircleMapByMapId.GetConfigList(mapId, true);
		}

		// Token: 0x06041A67 RID: 268903 RVA: 0x00FECAD0 File Offset: 0x00FEACD0
		public IReadOnlyList<EncircleChallengeGroup> GetEncircleGroups(int activityId)
		{
			return ConfigEncircleChallengeGroupByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06041A68 RID: 268904 RVA: 0x00FECAD9 File Offset: 0x00FEACD9
		public EncircleChallengeGroup? GetEncircleGroup(int groupId)
		{
			return ConfigEncircleChallengeGroupById.GetConfig(groupId, true);
		}

		// Token: 0x06041A69 RID: 268905 RVA: 0x00FECAE4 File Offset: 0x00FEACE4
		public int[] GetEncircleChallenges(int activityId, int levelId)
		{
			IReadOnlyList<EncircleChallengeGroup> encircleGroups = this.GetEncircleGroups(activityId);
			if (encircleGroups != null && encircleGroups.Count > 0)
			{
				return encircleGroups[levelId - 1].Challenges();
			}
			return null;
		}

		// Token: 0x06041A6A RID: 268906 RVA: 0x00FECB18 File Offset: 0x00FEAD18
		public EncircleChallenge? GetEncircleChallengeConfig(int challengeId)
		{
			return ConfigEncircleChallengeById.GetConfig(challengeId, true);
		}

		// Token: 0x06041A6B RID: 268907 RVA: 0x00FECB24 File Offset: 0x00FEAD24
		public EncircleHexType? GetMapItemType(int typeId)
		{
			if (ConfigEncircleMapItemById.GetConfig(typeId, true) == null)
			{
				return null;
			}
			EncircleMapItem? encircleMapItem;
			return new EncircleHexType?(encircleMapItem.GetValueOrDefault().Type);
		}

		// Token: 0x06041A6C RID: 268908 RVA: 0x00FECB60 File Offset: 0x00FEAD60
		public string GetMapItemMemo(int typeId)
		{
			if (ConfigEncircleMapItemById.GetConfig(typeId, true) == null)
			{
				return null;
			}
			EncircleMapItem? encircleMapItem;
			return encircleMapItem.GetValueOrDefault().Memo;
		}

		// Token: 0x06041A6D RID: 268909 RVA: 0x00FECB90 File Offset: 0x00FEAD90
		public string GetMapItemResource(int typeId)
		{
			if (ConfigEncircleMapItemById.GetConfig(typeId, true) == null)
			{
				return null;
			}
			EncircleMapItem? encircleMapItem;
			return encircleMapItem.GetValueOrDefault().ResourcePath;
		}

		// Token: 0x17009618 RID: 38424
		// (get) Token: 0x06041A6E RID: 268910 RVA: 0x00FECBBF File Offset: 0x00FEADBF
		[Nullable(1)]
		public static ActivityEncircleConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return ActivityEncircleConfig._Instance;
			}
		}

		// Token: 0x06041A6F RID: 268911 RVA: 0x00FECBC6 File Offset: 0x00FEADC6
		[NullableContext(1)]
		public static ActivityEncircleConfig GetOrCreateInstance()
		{
			if (ActivityEncircleConfig._Instance == null)
			{
				ActivityEncircleConfig.CreateInstance();
			}
			return ActivityEncircleConfig._Instance;
		}

		// Token: 0x06041A70 RID: 268912 RVA: 0x00FECBDA File Offset: 0x00FEADDA
		public static bool CreateInstance()
		{
			if (ActivityEncircleConfig._Instance != null)
			{
				return true;
			}
			ActivityEncircleConfig._Instance = new ActivityEncircleConfig();
			return true;
		}

		// Token: 0x06041A71 RID: 268913 RVA: 0x00FECBF0 File Offset: 0x00FEADF0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041A72 RID: 268914 RVA: 0x00FECBF2 File Offset: 0x00FEADF2
		public static void ResetStaticDefaultValue()
		{
			ActivityEncircleConfig._Instance = null;
		}

		// Token: 0x06041A73 RID: 268915 RVA: 0x00FECBFA File Offset: 0x00FEADFA
		static ActivityEncircleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityEncircleConfig.CreateStaticDefaultValue), new Action(ActivityEncircleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0402228B RID: 139915
		private static ActivityEncircleConfig _Instance;
	}
}
