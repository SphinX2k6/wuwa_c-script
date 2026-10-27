using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006405 RID: 25605
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MotorFightConfig : ConfigBase
	{
		// Token: 0x06040695 RID: 263829 RVA: 0x00F95057 File Offset: 0x00F93257
		public IReadOnlyList<MotorFightRole> GetMotorFightRoleList(int activityId)
		{
			return ConfigMotorFightRoleByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06040696 RID: 263830 RVA: 0x00F95060 File Offset: 0x00F93260
		public MotorFightQuality? GetMotorFightQuality(int id)
		{
			return ConfigMotorFightQualityById.GetConfig(id, true);
		}

		// Token: 0x06040697 RID: 263831 RVA: 0x00F95069 File Offset: 0x00F93269
		public MotorFightItemType? GetMotorFightItemType(int id)
		{
			return ConfigMotorFightItemTypeById.GetConfig(id, true);
		}

		// Token: 0x06040698 RID: 263832 RVA: 0x00F95072 File Offset: 0x00F93272
		public MotorFightActivity? GetMotorFightActivityConfig(int id)
		{
			return ConfigMotorFightActivityByActivityId.GetConfig(id, true);
		}

		// Token: 0x06040699 RID: 263833 RVA: 0x00F9507B File Offset: 0x00F9327B
		public MotorFightLevelType? GetMotorFightLevelType(int id)
		{
			return ConfigMotorFightLevelTypeById.GetConfig(id, true);
		}

		// Token: 0x0604069A RID: 263834 RVA: 0x00F95084 File Offset: 0x00F93284
		public List<MotorFightAttrShow> GetMotorFightAttrShow()
		{
			List<MotorFightAttrShow> list = new List<MotorFightAttrShow>(ConfigMotorFightAttrShowAll.GetConfigList(true));
			list.Sort((MotorFightAttrShow a, MotorFightAttrShow b) => a.SortId - b.SortId);
			return list;
		}

		// Token: 0x0604069B RID: 263835 RVA: 0x00F950B6 File Offset: 0x00F932B6
		public MotorFightAttrShow? GetMotorFightAttrShowById(int id)
		{
			return ConfigMotorFightAttrShowById.GetConfig(id, true);
		}

		// Token: 0x0604069C RID: 263836 RVA: 0x00F950BF File Offset: 0x00F932BF
		public MotorFightRole? GetMotorFightRoleConfig(int id)
		{
			return ConfigMotorFightRoleById.GetConfig(id, true);
		}

		// Token: 0x0604069D RID: 263837 RVA: 0x00F950C8 File Offset: 0x00F932C8
		public MotorFightItem? GetMotorFightItemConfig(int id)
		{
			return ConfigMotorFightItemById.GetConfig(id, true);
		}

		// Token: 0x0604069E RID: 263838 RVA: 0x00F950D1 File Offset: 0x00F932D1
		public IReadOnlyList<MotorFightRank> GetMotorFightRobotRankList()
		{
			return ConfigMotorFightRankAll.GetConfigList(true);
		}

		// Token: 0x1700946E RID: 37998
		// (get) Token: 0x0604069F RID: 263839 RVA: 0x00F950D9 File Offset: 0x00F932D9
		public static MotorFightConfig Instance
		{
			get
			{
				return MotorFightConfig._Instance;
			}
		}

		// Token: 0x060406A0 RID: 263840 RVA: 0x00F950E0 File Offset: 0x00F932E0
		public static MotorFightConfig GetOrCreateInstance()
		{
			if (MotorFightConfig._Instance == null)
			{
				MotorFightConfig.CreateInstance();
			}
			return MotorFightConfig._Instance;
		}

		// Token: 0x060406A1 RID: 263841 RVA: 0x00F950F4 File Offset: 0x00F932F4
		public static bool CreateInstance()
		{
			if (MotorFightConfig._Instance != null)
			{
				return true;
			}
			MotorFightConfig._Instance = new MotorFightConfig();
			return true;
		}

		// Token: 0x060406A2 RID: 263842 RVA: 0x00F9510A File Offset: 0x00F9330A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060406A3 RID: 263843 RVA: 0x00F9510C File Offset: 0x00F9330C
		public static void ResetStaticDefaultValue()
		{
			MotorFightConfig._Instance = null;
		}

		// Token: 0x060406A4 RID: 263844 RVA: 0x00F95114 File Offset: 0x00F93314
		static MotorFightConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorFightConfig.CreateStaticDefaultValue), new Action(MotorFightConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040217E9 RID: 137193
		[Nullable(2)]
		private static MotorFightConfig _Instance;
	}
}
