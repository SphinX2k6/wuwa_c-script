using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009B RID: 155
	public class ConfigAkiMapByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x00071983 File Offset: 0x0006FB83
		static ConfigAkiMapByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAkiMapByMapId.CreateStaticDefaultValue), new Action(ConfigAkiMapByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000719A4 File Offset: 0x0006FBA4
		public static void CreateStaticDefaultValue()
		{
			ConfigAkiMapByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAkiMapByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "AkiMap"),
				new ValueTuple<string, object>("语句", "select BinData from `AkiMap` where MapId=?")
			});
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00071A23 File Offset: 0x0006FC23
		public static void ResetStaticDefaultValue()
		{
			ConfigAkiMapByMapId.LogPair = null;
			ConfigAkiMapByMapId.HandleId = 0;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00071A31 File Offset: 0x0006FC31
		public static void Init()
		{
			ConfigAkiMapByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigAkiMapByMapId.HandleId, "db_map.db", "select BinData from `AkiMap` where MapId=?");
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00071A4C File Offset: 0x0006FC4C
		public static AkiMap? GetConfig(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAkiMapByMapId.HandleId, ConfigAkiMapByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AkiMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AkiMap?(AkiMap.GetRootAsAkiMap(configBuffer));
				}
			}
			ConfigAkiMapByMapId.LogPair.Clear();
			ConfigAkiMapByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigAkiMapByMapId.HandleId, 1, p0MapId, ConfigAkiMapByMapId.LogPair) || ConfigCommon.Step(ConfigAkiMapByMapId.HandleId, true, ConfigAkiMapByMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAkiMapByMapId.HandleId, ConfigAkiMapByMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAkiMapByMapId.HandleId, 0, ConfigAkiMapByMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAkiMapByMapId.HandleId, ConfigAkiMapByMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AkiMap rootAsAkiMap = AkiMap.GetRootAsAkiMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AkiMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAkiMapByMapId.HandleId, ConfigAkiMapByMapId.LogPair);
			return new AkiMap?(rootAsAkiMap);
		}

		// Token: 0x04000421 RID: 1057
		private const string DB = "db_map.db";

		// Token: 0x04000422 RID: 1058
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04000423 RID: 1059
		private const string TABLE = "AkiMap";

		// Token: 0x04000424 RID: 1060
		private const string COMMAND = "select BinData from `AkiMap` where MapId=?";

		// Token: 0x04000425 RID: 1061
		private const string KEY_PREFIX = "AkiMapByMapId";

		// Token: 0x04000426 RID: 1062
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000427 RID: 1063
		private static int HandleId;
	}
}
