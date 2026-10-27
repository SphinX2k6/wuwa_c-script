using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000094 RID: 148
	public class ConfigAkiMapSourceByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000378 RID: 888 RVA: 0x0006D318 File Offset: 0x0006B518
		static ConfigAkiMapSourceByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAkiMapSourceByMapId.CreateStaticDefaultValue), new Action(ConfigAkiMapSourceByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0006D338 File Offset: 0x0006B538
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

		// Token: 0x0600037A RID: 890 RVA: 0x0006D3B7 File Offset: 0x0006B5B7
		public static void ResetStaticDefaultValue()
		{
			ConfigAkiMapSourceByMapId.LogPair = null;
			ConfigAkiMapSourceByMapId.HandleId = 0;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0006D3C5 File Offset: 0x0006B5C5
		public static void Init()
		{
			ConfigAkiMapSourceByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigAkiMapSourceByMapId.HandleId, "db_instance_dungeon.db", "select BinData from `AkiMapSource` where MapId=?");
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0006D3E0 File Offset: 0x0006B5E0
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

		// Token: 0x040003F0 RID: 1008
		private const string DB = "db_instance_dungeon.db";

		// Token: 0x040003F1 RID: 1009
		private const string FILE = "f.副本.xlsx";

		// Token: 0x040003F2 RID: 1010
		private const string TABLE = "AkiMapSource";

		// Token: 0x040003F3 RID: 1011
		private const string COMMAND = "select BinData from `AkiMapSource` where MapId=?";

		// Token: 0x040003F4 RID: 1012
		private const string KEY_PREFIX = "AkiMapSourceByMapId";

		// Token: 0x040003F5 RID: 1013
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003F6 RID: 1014
		private static int HandleId;
	}
}
