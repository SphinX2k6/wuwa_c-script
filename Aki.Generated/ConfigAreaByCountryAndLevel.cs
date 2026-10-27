using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A1 RID: 161
	public class ConfigAreaByCountryAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0006EFA7 File Offset: 0x0006D1A7
		static ConfigAreaByCountryAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaByCountryAndLevel.CreateStaticDefaultValue), new Action(ConfigAreaByCountryAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0006EFC8 File Offset: 0x0006D1C8
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaByCountryAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaByCountryAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "Area"),
				new ValueTuple<string, object>("语句", "select BinData from `Area` where CountryId=? And Level=?")
			});
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0006F047 File Offset: 0x0006D247
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaByCountryAndLevel.LogPair = null;
			ConfigAreaByCountryAndLevel.HandleId = 0;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0006F055 File Offset: 0x0006D255
		public static void Init()
		{
			ConfigAreaByCountryAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigAreaByCountryAndLevel.HandleId, "db_area.db", "select BinData from `Area` where CountryId=? And Level=?");
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0006F070 File Offset: 0x0006D270
		[NullableContext(2)]
		public static IReadOnlyList<Area> GetConfigList(int p0CountryId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaByCountryAndLevel.HandleId, ConfigAreaByCountryAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByCountryAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CountryId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				IReadOnlyList<Area> readOnlyList = (IReadOnlyList<Area>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAreaByCountryAndLevel.LogPair.Clear();
			ConfigAreaByCountryAndLevel.LogPair.Add(new ValueTuple<string, object>("CountryId", p0CountryId));
			ConfigAreaByCountryAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigAreaByCountryAndLevel.HandleId, 1, p0CountryId, ConfigAreaByCountryAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigAreaByCountryAndLevel.HandleId, 2, p1Level, ConfigAreaByCountryAndLevel.LogPair))
			{
				ConfigCommon.Reset(ConfigAreaByCountryAndLevel.HandleId, ConfigAreaByCountryAndLevel.LogPair);
				return null;
			}
			List<Area> list = new List<Area>();
			while (ConfigCommon.Step(ConfigAreaByCountryAndLevel.HandleId, false, ConfigAreaByCountryAndLevel.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaByCountryAndLevel.HandleId, 0, ConfigAreaByCountryAndLevel.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaByCountryAndLevel.HandleId, ConfigAreaByCountryAndLevel.LogPair);
					return null;
				}
				Area rootAsArea = Area.GetRootAsArea(new ByteBuffer(item2));
				list.Add(rootAsArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByCountryAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CountryId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaByCountryAndLevel.HandleId, ConfigAreaByCountryAndLevel.LogPair);
			return list;
		}

		// Token: 0x0400044B RID: 1099
		private const string DB = "db_area.db";

		// Token: 0x0400044C RID: 1100
		private const string FILE = "q.区域.xlsx";

		// Token: 0x0400044D RID: 1101
		private const string TABLE = "Area";

		// Token: 0x0400044E RID: 1102
		private const string COMMAND = "select BinData from `Area` where CountryId=? And Level=?";

		// Token: 0x0400044F RID: 1103
		private const string KEY_PREFIX = "AreaByCountryAndLevel";

		// Token: 0x04000450 RID: 1104
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000451 RID: 1105
		private static int HandleId;
	}
}
