using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DD RID: 1501
	public class ConfigMusicalInstrumentQteConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600233D RID: 9021 RVA: 0x00120C80 File Offset: 0x0011EE80
		static ConfigMusicalInstrumentQteConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicalInstrumentQteConfigById.CreateStaticDefaultValue), new Action(ConfigMusicalInstrumentQteConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00120CA0 File Offset: 0x0011EEA0
		public static void CreateStaticDefaultValue()
		{
			ConfigMusicalInstrumentQteConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMusicalInstrumentQteConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_musicalinstrumentqteconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/y.乐器Qte玩法/*.csv*"),
				new ValueTuple<string, object>("表名", "MusicalInstrumentQteConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MusicalInstrumentQteConfig` where Id=?")
			});
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00120D1F File Offset: 0x0011EF1F
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicalInstrumentQteConfigById.LogPair = null;
			ConfigMusicalInstrumentQteConfigById.HandleId = 0;
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00120D2D File Offset: 0x0011EF2D
		public static void Init()
		{
			ConfigMusicalInstrumentQteConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigMusicalInstrumentQteConfigById.HandleId, "db_musicalinstrumentqteconfig.db", "select BinData from `MusicalInstrumentQteConfig` where Id=?");
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00120D48 File Offset: 0x0011EF48
		public static MusicalInstrumentQteConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMusicalInstrumentQteConfigById.HandleId, ConfigMusicalInstrumentQteConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MusicalInstrumentQteConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MusicalInstrumentQteConfig?(MusicalInstrumentQteConfig.GetRootAsMusicalInstrumentQteConfig(configBuffer));
				}
			}
			ConfigMusicalInstrumentQteConfigById.LogPair.Clear();
			ConfigMusicalInstrumentQteConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMusicalInstrumentQteConfigById.HandleId, 1, p0Id, ConfigMusicalInstrumentQteConfigById.LogPair) || ConfigCommon.Step(ConfigMusicalInstrumentQteConfigById.HandleId, true, ConfigMusicalInstrumentQteConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMusicalInstrumentQteConfigById.HandleId, ConfigMusicalInstrumentQteConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMusicalInstrumentQteConfigById.HandleId, 0, ConfigMusicalInstrumentQteConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMusicalInstrumentQteConfigById.HandleId, ConfigMusicalInstrumentQteConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MusicalInstrumentQteConfig rootAsMusicalInstrumentQteConfig = MusicalInstrumentQteConfig.GetRootAsMusicalInstrumentQteConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MusicalInstrumentQteConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMusicalInstrumentQteConfigById.HandleId, ConfigMusicalInstrumentQteConfigById.LogPair);
			return new MusicalInstrumentQteConfig?(rootAsMusicalInstrumentQteConfig);
		}

		// Token: 0x040028F1 RID: 10481
		private const string DB = "db_musicalinstrumentqteconfig.db";

		// Token: 0x040028F2 RID: 10482
		private const string FILE = "k.可视化编辑/c.Csv/y.乐器Qte玩法/*.csv*";

		// Token: 0x040028F3 RID: 10483
		private const string TABLE = "MusicalInstrumentQteConfig";

		// Token: 0x040028F4 RID: 10484
		private const string COMMAND = "select BinData from `MusicalInstrumentQteConfig` where Id=?";

		// Token: 0x040028F5 RID: 10485
		private const string KEY_PREFIX = "MusicalInstrumentQteConfigById";

		// Token: 0x040028F6 RID: 10486
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028F7 RID: 10487
		private static int HandleId;
	}
}
