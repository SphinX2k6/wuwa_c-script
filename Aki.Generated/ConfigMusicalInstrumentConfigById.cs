using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DC RID: 1500
	public class ConfigMusicalInstrumentConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002337 RID: 9015 RVA: 0x00120A36 File Offset: 0x0011EC36
		static ConfigMusicalInstrumentConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicalInstrumentConfigById.CreateStaticDefaultValue), new Action(ConfigMusicalInstrumentConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00120A58 File Offset: 0x0011EC58
		public static void CreateStaticDefaultValue()
		{
			ConfigMusicalInstrumentConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMusicalInstrumentConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_musicalinstrumentconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/y.乐器/*.csv*"),
				new ValueTuple<string, object>("表名", "MusicalInstrumentConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MusicalInstrumentConfig` where Id=?")
			});
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00120AD7 File Offset: 0x0011ECD7
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicalInstrumentConfigById.LogPair = null;
			ConfigMusicalInstrumentConfigById.HandleId = 0;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00120AE5 File Offset: 0x0011ECE5
		public static void Init()
		{
			ConfigMusicalInstrumentConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigMusicalInstrumentConfigById.HandleId, "db_musicalinstrumentconfig.db", "select BinData from `MusicalInstrumentConfig` where Id=?");
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00120B00 File Offset: 0x0011ED00
		public static MusicalInstrumentConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMusicalInstrumentConfigById.HandleId, ConfigMusicalInstrumentConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MusicalInstrumentConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MusicalInstrumentConfig?(MusicalInstrumentConfig.GetRootAsMusicalInstrumentConfig(configBuffer));
				}
			}
			ConfigMusicalInstrumentConfigById.LogPair.Clear();
			ConfigMusicalInstrumentConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMusicalInstrumentConfigById.HandleId, 1, p0Id, ConfigMusicalInstrumentConfigById.LogPair) || ConfigCommon.Step(ConfigMusicalInstrumentConfigById.HandleId, true, ConfigMusicalInstrumentConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMusicalInstrumentConfigById.HandleId, ConfigMusicalInstrumentConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMusicalInstrumentConfigById.HandleId, 0, ConfigMusicalInstrumentConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMusicalInstrumentConfigById.HandleId, ConfigMusicalInstrumentConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MusicalInstrumentConfig rootAsMusicalInstrumentConfig = MusicalInstrumentConfig.GetRootAsMusicalInstrumentConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MusicalInstrumentConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMusicalInstrumentConfigById.HandleId, ConfigMusicalInstrumentConfigById.LogPair);
			return new MusicalInstrumentConfig?(rootAsMusicalInstrumentConfig);
		}

		// Token: 0x040028EA RID: 10474
		private const string DB = "db_musicalinstrumentconfig.db";

		// Token: 0x040028EB RID: 10475
		private const string FILE = "k.可视化编辑/c.Csv/y.乐器/*.csv*";

		// Token: 0x040028EC RID: 10476
		private const string TABLE = "MusicalInstrumentConfig";

		// Token: 0x040028ED RID: 10477
		private const string COMMAND = "select BinData from `MusicalInstrumentConfig` where Id=?";

		// Token: 0x040028EE RID: 10478
		private const string KEY_PREFIX = "MusicalInstrumentConfigById";

		// Token: 0x040028EF RID: 10479
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028F0 RID: 10480
		private static int HandleId;
	}
}
