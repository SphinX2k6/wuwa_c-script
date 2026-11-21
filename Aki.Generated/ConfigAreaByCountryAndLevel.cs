using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A9 RID: 169
	public class ConfigAreaByCountryAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x0007385B File Offset: 0x00071A5B
		static ConfigAreaByCountryAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaByCountryAndLevel.CreateStaticDefaultValue), new Action(ConfigAreaByCountryAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0007387C File Offset: 0x00071A7C
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

		// Token: 0x060003F9 RID: 1017 RVA: 0x000738FB File Offset: 0x00071AFB
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaByCountryAndLevel.LogPair = null;
			ConfigAreaByCountryAndLevel.HandleId = 0;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00073909 File Offset: 0x00071B09
		public static void Init()
		{
			ConfigAreaByCountryAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigAreaByCountryAndLevel.HandleId, "db_area.db", "select BinData from `Area` where CountryId=? And Level=?");
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00073924 File Offset: 0x00071B24
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

		// Token: 0x04000483 RID: 1155
		private const string DB = "db_area.db";

		// Token: 0x04000484 RID: 1156
		private const string FILE = "q.区域.xlsx";

		// Token: 0x04000485 RID: 1157
		private const string TABLE = "Area";

		// Token: 0x04000486 RID: 1158
		private const string COMMAND = "select BinData from `Area` where CountryId=? And Level=?";

		// Token: 0x04000487 RID: 1159
		private const string KEY_PREFIX = "AreaByCountryAndLevel";

		// Token: 0x04000488 RID: 1160
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000489 RID: 1161
		private static int HandleId;
	}
}
