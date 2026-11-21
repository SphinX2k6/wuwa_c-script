using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005383 RID: 21379
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MotorFightConfig : ConfigBase
	{
		// Token: 0x06035356 RID: 217942 RVA: 0x00EDBFF7 File Offset: 0x00EDA1F7
		public IReadOnlyList<MotorFightRole> GetMotorFightRoleList(int activityId)
		{
			return ConfigMotorFightRoleByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06035357 RID: 217943 RVA: 0x00EDC000 File Offset: 0x00EDA200
		public MotorFightQuality? GetMotorFightQuality(int id)
		{
			return ConfigMotorFightQualityById.GetConfig(id, true);
		}

		// Token: 0x06035358 RID: 217944 RVA: 0x00EDC009 File Offset: 0x00EDA209
		public MotorFightItemType? GetMotorFightItemType(int id)
		{
			return ConfigMotorFightItemTypeById.GetConfig(id, true);
		}

		// Token: 0x06035359 RID: 217945 RVA: 0x00EDC012 File Offset: 0x00EDA212
		public MotorFightActivity? GetMotorFightActivityConfig(int id)
		{
			return ConfigMotorFightActivityByActivityId.GetConfig(id, true);
		}

		// Token: 0x0603535A RID: 217946 RVA: 0x00EDC01B File Offset: 0x00EDA21B
		public MotorFightLevelType? GetMotorFightLevelType(int id)
		{
			return ConfigMotorFightLevelTypeById.GetConfig(id, true);
		}

		// Token: 0x0603535B RID: 217947 RVA: 0x00EDC024 File Offset: 0x00EDA224
		public List<MotorFightAttrShow> GetMotorFightAttrShow()
		{
			List<MotorFightAttrShow> list = new List<MotorFightAttrShow>(ConfigMotorFightAttrShowAll.GetConfigList(true));
			list.Sort((MotorFightAttrShow a, MotorFightAttrShow b) => a.SortId - b.SortId);
			return list;
		}

		// Token: 0x0603535C RID: 217948 RVA: 0x00EDC056 File Offset: 0x00EDA256
		public MotorFightAttrShow? GetMotorFightAttrShowById(int id)
		{
			return ConfigMotorFightAttrShowById.GetConfig(id, true);
		}

		// Token: 0x0603535D RID: 217949 RVA: 0x00EDC05F File Offset: 0x00EDA25F
		public MotorFightRole? GetMotorFightRoleConfig(int id)
		{
			return ConfigMotorFightRoleById.GetConfig(id, true);
		}

		// Token: 0x0603535E RID: 217950 RVA: 0x00EDC068 File Offset: 0x00EDA268
		public MotorFightItem? GetMotorFightItemConfig(int id)
		{
			return ConfigMotorFightItemById.GetConfig(id, true);
		}

		// Token: 0x0603535F RID: 217951 RVA: 0x00EDC071 File Offset: 0x00EDA271
		public IReadOnlyList<MotorFightRank> GetMotorFightRobotRankList()
		{
			return ConfigMotorFightRankAll.GetConfigList(true);
		}

		// Token: 0x170067D0 RID: 26576
		// (get) Token: 0x06035360 RID: 217952 RVA: 0x00EDC079 File Offset: 0x00EDA279
		public static MotorFightConfig Instance
		{
			get
			{
				return MotorFightConfig._Instance;
			}
		}

		// Token: 0x06035361 RID: 217953 RVA: 0x00EDC080 File Offset: 0x00EDA280
		public static MotorFightConfig GetOrCreateInstance()
		{
			if (MotorFightConfig._Instance == null)
			{
				MotorFightConfig.CreateInstance();
			}
			return MotorFightConfig._Instance;
		}

		// Token: 0x06035362 RID: 217954 RVA: 0x00EDC094 File Offset: 0x00EDA294
		public static bool CreateInstance()
		{
			if (MotorFightConfig._Instance != null)
			{
				return true;
			}
			MotorFightConfig._Instance = new MotorFightConfig();
			return true;
		}

		// Token: 0x06035363 RID: 217955 RVA: 0x00EDC0AA File Offset: 0x00EDA2AA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035364 RID: 217956 RVA: 0x00EDC0AC File Offset: 0x00EDA2AC
		public static void ResetStaticDefaultValue()
		{
			MotorFightConfig._Instance = null;
		}

		// Token: 0x06035365 RID: 217957 RVA: 0x00EDC0B4 File Offset: 0x00EDA2B4
		static MotorFightConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorFightConfig.CreateStaticDefaultValue), new Action(MotorFightConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C118 RID: 114968
		[Nullable(2)]
		private static MotorFightConfig _Instance;
	}
}
