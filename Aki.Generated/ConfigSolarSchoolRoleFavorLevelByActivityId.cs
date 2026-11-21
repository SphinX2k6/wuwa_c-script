using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A11 RID: 2577
	public class ConfigSolarSchoolRoleFavorLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C7A RID: 15482 RVA: 0x001B284B File Offset: 0x001B0A4B
		static ConfigSolarSchoolRoleFavorLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleFavorLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleFavorLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x001B286C File Offset: 0x001B0A6C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleFavorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleFavorLevel` where ActivityId=?")
			});
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x001B28EB File Offset: 0x001B0AEB
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair = null;
			ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId = 0;
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x001B28F9 File Offset: 0x001B0AF9
		public static void Init()
		{
			ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleFavorLevel` where ActivityId=?");
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x001B2914 File Offset: 0x001B0B14
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleFavorLevel> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId, ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleFavorLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolRoleFavorLevel> readOnlyList = (IReadOnlyList<SolarSchoolRoleFavorLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair.Clear();
			ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId, ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolRoleFavorLevel> list = new List<SolarSchoolRoleFavorLevel>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId, false, ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId, 0, ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId, ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair);
					return null;
				}
				SolarSchoolRoleFavorLevel rootAsSolarSchoolRoleFavorLevel = SolarSchoolRoleFavorLevel.GetRootAsSolarSchoolRoleFavorLevel(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleFavorLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleFavorLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByActivityId.HandleId, ConfigSolarSchoolRoleFavorLevelByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400465D RID: 18013
		private const string DB = "db_solarschool.db";

		// Token: 0x0400465E RID: 18014
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x0400465F RID: 18015
		private const string TABLE = "SolarSchoolRoleFavorLevel";

		// Token: 0x04004660 RID: 18016
		private const string COMMAND = "select BinData from `SolarSchoolRoleFavorLevel` where ActivityId=?";

		// Token: 0x04004661 RID: 18017
		private const string KEY_PREFIX = "SolarSchoolRoleFavorLevelByActivityId";

		// Token: 0x04004662 RID: 18018
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004663 RID: 18019
		private static int HandleId;
	}
}
