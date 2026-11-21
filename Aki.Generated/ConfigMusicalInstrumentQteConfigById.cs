using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F5 RID: 1525
	public class ConfigMusicalInstrumentQteConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023CD RID: 9165 RVA: 0x001276FC File Offset: 0x001258FC
		static ConfigMusicalInstrumentQteConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMusicalInstrumentQteConfigById.CreateStaticDefaultValue), new Action(ConfigMusicalInstrumentQteConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0012771C File Offset: 0x0012591C
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

		// Token: 0x060023CF RID: 9167 RVA: 0x0012779B File Offset: 0x0012599B
		public static void ResetStaticDefaultValue()
		{
			ConfigMusicalInstrumentQteConfigById.LogPair = null;
			ConfigMusicalInstrumentQteConfigById.HandleId = 0;
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x001277A9 File Offset: 0x001259A9
		public static void Init()
		{
			ConfigMusicalInstrumentQteConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigMusicalInstrumentQteConfigById.HandleId, "db_musicalinstrumentqteconfig.db", "select BinData from `MusicalInstrumentQteConfig` where Id=?");
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x001277C4 File Offset: 0x001259C4
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

		// Token: 0x04002999 RID: 10649
		private const string DB = "db_musicalinstrumentqteconfig.db";

		// Token: 0x0400299A RID: 10650
		private const string FILE = "k.可视化编辑/c.Csv/y.乐器Qte玩法/*.csv*";

		// Token: 0x0400299B RID: 10651
		private const string TABLE = "MusicalInstrumentQteConfig";

		// Token: 0x0400299C RID: 10652
		private const string COMMAND = "select BinData from `MusicalInstrumentQteConfig` where Id=?";

		// Token: 0x0400299D RID: 10653
		private const string KEY_PREFIX = "MusicalInstrumentQteConfigById";

		// Token: 0x0400299E RID: 10654
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400299F RID: 10655
		private static int HandleId;
	}
}
