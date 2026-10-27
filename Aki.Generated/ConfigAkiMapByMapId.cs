using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000093 RID: 147
	public class ConfigAkiMapByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000372 RID: 882 RVA: 0x0006D0CF File Offset: 0x0006B2CF
		static ConfigAkiMapByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAkiMapByMapId.CreateStaticDefaultValue), new Action(ConfigAkiMapByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0006D0F0 File Offset: 0x0006B2F0
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

		// Token: 0x06000374 RID: 884 RVA: 0x0006D16F File Offset: 0x0006B36F
		public static void ResetStaticDefaultValue()
		{
			ConfigAkiMapByMapId.LogPair = null;
			ConfigAkiMapByMapId.HandleId = 0;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0006D17D File Offset: 0x0006B37D
		public static void Init()
		{
			ConfigAkiMapByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigAkiMapByMapId.HandleId, "db_map.db", "select BinData from `AkiMap` where MapId=?");
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0006D198 File Offset: 0x0006B398
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

		// Token: 0x040003E9 RID: 1001
		private const string DB = "db_map.db";

		// Token: 0x040003EA RID: 1002
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040003EB RID: 1003
		private const string TABLE = "AkiMap";

		// Token: 0x040003EC RID: 1004
		private const string COMMAND = "select BinData from `AkiMap` where MapId=?";

		// Token: 0x040003ED RID: 1005
		private const string KEY_PREFIX = "AkiMapByMapId";

		// Token: 0x040003EE RID: 1006
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003EF RID: 1007
		private static int HandleId;
	}
}
