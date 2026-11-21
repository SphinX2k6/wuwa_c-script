using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009C RID: 156
	public class ConfigAkiMapSourceByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x00071BCC File Offset: 0x0006FDCC
		static ConfigAkiMapSourceByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAkiMapSourceByMapId.CreateStaticDefaultValue), new Action(ConfigAkiMapSourceByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00071BEC File Offset: 0x0006FDEC
		public static void CreateStaticDefaultValue()
		{
			ConfigAkiMapSourceByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAkiMapSourceByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_instance_dungeon.db"),
				new ValueTuple<string, object>("文件", "f.副本.xlsx"),
				new ValueTuple<string, object>("表名", "AkiMapSource"),
				new ValueTuple<string, object>("语句", "select BinData from `AkiMapSource` where MapId=?")
			});
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00071C6B File Offset: 0x0006FE6B
		public static void ResetStaticDefaultValue()
		{
			ConfigAkiMapSourceByMapId.LogPair = null;
			ConfigAkiMapSourceByMapId.HandleId = 0;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00071C79 File Offset: 0x0006FE79
		public static void Init()
		{
			ConfigAkiMapSourceByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigAkiMapSourceByMapId.HandleId, "db_instance_dungeon.db", "select BinData from `AkiMapSource` where MapId=?");
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00071C94 File Offset: 0x0006FE94
		public static AkiMapSource? GetConfig(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAkiMapSourceByMapId.HandleId, ConfigAkiMapSourceByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AkiMapSourceByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AkiMapSource?(AkiMapSource.GetRootAsAkiMapSource(configBuffer));
				}
			}
			ConfigAkiMapSourceByMapId.LogPair.Clear();
			ConfigAkiMapSourceByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigAkiMapSourceByMapId.HandleId, 1, p0MapId, ConfigAkiMapSourceByMapId.LogPair) || ConfigCommon.Step(ConfigAkiMapSourceByMapId.HandleId, true, ConfigAkiMapSourceByMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAkiMapSourceByMapId.HandleId, ConfigAkiMapSourceByMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAkiMapSourceByMapId.HandleId, 0, ConfigAkiMapSourceByMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAkiMapSourceByMapId.HandleId, ConfigAkiMapSourceByMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AkiMapSource rootAsAkiMapSource = AkiMapSource.GetRootAsAkiMapSource(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AkiMapSourceByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAkiMapSourceByMapId.HandleId, ConfigAkiMapSourceByMapId.LogPair);
			return new AkiMapSource?(rootAsAkiMapSource);
		}

		// Token: 0x04000428 RID: 1064
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x04000429 RID: 1065
		private const string FILE = "f.副本.xlsx";

		// Token: 0x0400042A RID: 1066
		private const string TABLE = "AkiMapSource";

		// Token: 0x0400042B RID: 1067
		private const string COMMAND = "select BinData from `AkiMapSource` where MapId=?";

		// Token: 0x0400042C RID: 1068
		private const string KEY_PREFIX = "AkiMapSourceByMapId";

		// Token: 0x0400042D RID: 1069
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400042E RID: 1070
		private static int HandleId;
	}
}
