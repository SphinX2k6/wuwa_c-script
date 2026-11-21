using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B0 RID: 2480
	public class ConfigSolarSchoolAffairsOptionByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A34 RID: 14900 RVA: 0x001A5CA8 File Offset: 0x001A3EA8
		static ConfigSolarSchoolAffairsOptionByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAffairsOptionByGroupId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAffairsOptionByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x001A5CC8 File Offset: 0x001A3EC8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAffairsOptionByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAffairsOptionByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAffairsOption"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAffairsOption` where GroupId=?")
			});
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x001A5D47 File Offset: 0x001A3F47
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAffairsOptionByGroupId.LogPair = null;
			ConfigSolarSchoolAffairsOptionByGroupId.HandleId = 0;
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x001A5D55 File Offset: 0x001A3F55
		public static void Init()
		{
			ConfigSolarSchoolAffairsOptionByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAffairsOptionByGroupId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAffairsOption` where GroupId=?");
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x001A5D70 File Offset: 0x001A3F70
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolAffairsOption> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAffairsOptionByGroupId.HandleId, ConfigSolarSchoolAffairsOptionByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAffairsOptionByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<SolarSchoolAffairsOption> readOnlyList = (IReadOnlyList<SolarSchoolAffairsOption>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolAffairsOptionByGroupId.LogPair.Clear();
			ConfigSolarSchoolAffairsOptionByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolAffairsOptionByGroupId.HandleId, 1, p0GroupId, ConfigSolarSchoolAffairsOptionByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolAffairsOptionByGroupId.HandleId, ConfigSolarSchoolAffairsOptionByGroupId.LogPair);
				return null;
			}
			List<SolarSchoolAffairsOption> list = new List<SolarSchoolAffairsOption>();
			while (ConfigCommon.Step(ConfigSolarSchoolAffairsOptionByGroupId.HandleId, false, ConfigSolarSchoolAffairsOptionByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAffairsOptionByGroupId.HandleId, 0, ConfigSolarSchoolAffairsOptionByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolAffairsOptionByGroupId.HandleId, ConfigSolarSchoolAffairsOptionByGroupId.LogPair);
					return null;
				}
				SolarSchoolAffairsOption rootAsSolarSchoolAffairsOption = SolarSchoolAffairsOption.GetRootAsSolarSchoolAffairsOption(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolAffairsOption);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolAffairsOptionByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAffairsOptionByGroupId.HandleId, ConfigSolarSchoolAffairsOptionByGroupId.LogPair);
			return list;
		}

		// Token: 0x040043B6 RID: 17334
		private const string DB = "db_solarschool.db";

		// Token: 0x040043B7 RID: 17335
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040043B8 RID: 17336
		private const string TABLE = "SolarSchoolAffairsOption";

		// Token: 0x040043B9 RID: 17337
		private const string COMMAND = "select BinData from `SolarSchoolAffairsOption` where GroupId=?";

		// Token: 0x040043BA RID: 17338
		private const string KEY_PREFIX = "SolarSchoolAffairsOptionByGroupId";

		// Token: 0x040043BB RID: 17339
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043BC RID: 17340
		private static int HandleId;
	}
}
