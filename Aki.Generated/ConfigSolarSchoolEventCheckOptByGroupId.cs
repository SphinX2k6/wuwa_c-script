using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D2 RID: 2514
	public class ConfigSolarSchoolEventCheckOptByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B00 RID: 15104 RVA: 0x001AA3D8 File Offset: 0x001A85D8
		static ConfigSolarSchoolEventCheckOptByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEventCheckOptByGroupId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEventCheckOptByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x001AA3F8 File Offset: 0x001A85F8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEventCheckOptByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEventCheckOptByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEventCheckOpt"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEventCheckOpt` where GroupId=?")
			});
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x001AA477 File Offset: 0x001A8677
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEventCheckOptByGroupId.LogPair = null;
			ConfigSolarSchoolEventCheckOptByGroupId.HandleId = 0;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x001AA485 File Offset: 0x001A8685
		public static void Init()
		{
			ConfigSolarSchoolEventCheckOptByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEventCheckOptByGroupId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEventCheckOpt` where GroupId=?");
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x001AA4A0 File Offset: 0x001A86A0
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolEventCheckOpt> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEventCheckOptByGroupId.HandleId, ConfigSolarSchoolEventCheckOptByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEventCheckOptByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<SolarSchoolEventCheckOpt> readOnlyList = (IReadOnlyList<SolarSchoolEventCheckOpt>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolEventCheckOptByGroupId.LogPair.Clear();
			ConfigSolarSchoolEventCheckOptByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEventCheckOptByGroupId.HandleId, 1, p0GroupId, ConfigSolarSchoolEventCheckOptByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolEventCheckOptByGroupId.HandleId, ConfigSolarSchoolEventCheckOptByGroupId.LogPair);
				return null;
			}
			List<SolarSchoolEventCheckOpt> list = new List<SolarSchoolEventCheckOpt>();
			while (ConfigCommon.Step(ConfigSolarSchoolEventCheckOptByGroupId.HandleId, false, ConfigSolarSchoolEventCheckOptByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEventCheckOptByGroupId.HandleId, 0, ConfigSolarSchoolEventCheckOptByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolEventCheckOptByGroupId.HandleId, ConfigSolarSchoolEventCheckOptByGroupId.LogPair);
					return null;
				}
				SolarSchoolEventCheckOpt rootAsSolarSchoolEventCheckOpt = SolarSchoolEventCheckOpt.GetRootAsSolarSchoolEventCheckOpt(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolEventCheckOpt);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEventCheckOptByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEventCheckOptByGroupId.HandleId, ConfigSolarSchoolEventCheckOptByGroupId.LogPair);
			return list;
		}

		// Token: 0x040044A4 RID: 17572
		private const string DB = "db_solarschool.db";

		// Token: 0x040044A5 RID: 17573
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044A6 RID: 17574
		private const string TABLE = "SolarSchoolEventCheckOpt";

		// Token: 0x040044A7 RID: 17575
		private const string COMMAND = "select BinData from `SolarSchoolEventCheckOpt` where GroupId=?";

		// Token: 0x040044A8 RID: 17576
		private const string KEY_PREFIX = "SolarSchoolEventCheckOptByGroupId";

		// Token: 0x040044A9 RID: 17577
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044AA RID: 17578
		private static int HandleId;
	}
}
