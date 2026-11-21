using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F4 RID: 1524
	public class ConfigMusicalInstrumentConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023C7 RID: 9159 RVA: 0x001274B2 File Offset: 0x001256B2
		static ConfigMusicalInstrumentConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicalInstrumentConfigById.CreateStaticDefaultValue), new Action(ConfigMusicalInstrumentConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x001274D4 File Offset: 0x001256D4
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

		// Token: 0x060023C9 RID: 9161 RVA: 0x00127553 File Offset: 0x00125753
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicalInstrumentConfigById.LogPair = null;
			ConfigMusicalInstrumentConfigById.HandleId = 0;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00127561 File Offset: 0x00125761
		public static void Init()
		{
			ConfigMusicalInstrumentConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigMusicalInstrumentConfigById.HandleId, "db_musicalinstrumentconfig.db", "select BinData from `MusicalInstrumentConfig` where Id=?");
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0012757C File Offset: 0x0012577C
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

		// Token: 0x04002992 RID: 10642
		private const string DB = "db_musicalinstrumentconfig.db";

		// Token: 0x04002993 RID: 10643
		private const string FILE = "k.可视化编辑/c.Csv/y.乐器/*.csv*";

		// Token: 0x04002994 RID: 10644
		private const string TABLE = "MusicalInstrumentConfig";

		// Token: 0x04002995 RID: 10645
		private const string COMMAND = "select BinData from `MusicalInstrumentConfig` where Id=?";

		// Token: 0x04002996 RID: 10646
		private const string KEY_PREFIX = "MusicalInstrumentConfigById";

		// Token: 0x04002997 RID: 10647
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002998 RID: 10648
		private static int HandleId;
	}
}
