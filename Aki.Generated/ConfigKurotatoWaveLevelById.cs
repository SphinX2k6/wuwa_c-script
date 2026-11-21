using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D3 RID: 1235
	public class ConfigKurotatoWaveLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CFD RID: 7421 RVA: 0x001009AF File Offset: 0x000FEBAF
		static ConfigKurotatoWaveLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaveLevelById.CreateStaticDefaultValue), new Action(ConfigKurotatoWaveLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x001009D0 File Offset: 0x000FEBD0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWaveLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWaveLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWaveLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWaveLevel` where Id=?")
			});
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00100A4F File Offset: 0x000FEC4F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaveLevelById.LogPair = null;
			ConfigKurotatoWaveLevelById.HandleId = 0;
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00100A5D File Offset: 0x000FEC5D
		public static void Init()
		{
			ConfigKurotatoWaveLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaveLevelById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWaveLevel` where Id=?");
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00100A78 File Offset: 0x000FEC78
		public static KurotatoWaveLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWaveLevelById.HandleId, ConfigKurotatoWaveLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWaveLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoWaveLevel?(KurotatoWaveLevel.GetRootAsKurotatoWaveLevel(configBuffer));
				}
			}
			ConfigKurotatoWaveLevelById.LogPair.Clear();
			ConfigKurotatoWaveLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoWaveLevelById.HandleId, 1, p0Id, ConfigKurotatoWaveLevelById.LogPair) || ConfigCommon.Step(ConfigKurotatoWaveLevelById.HandleId, true, ConfigKurotatoWaveLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoWaveLevelById.HandleId, ConfigKurotatoWaveLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWaveLevelById.HandleId, 0, ConfigKurotatoWaveLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoWaveLevelById.HandleId, ConfigKurotatoWaveLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoWaveLevel rootAsKurotatoWaveLevel = KurotatoWaveLevel.GetRootAsKurotatoWaveLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWaveLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoWaveLevelById.HandleId, ConfigKurotatoWaveLevelById.LogPair);
			return new KurotatoWaveLevel?(rootAsKurotatoWaveLevel);
		}

		// Token: 0x040021A9 RID: 8617
		private const string DB = "db_kurotato.db";

		// Token: 0x040021AA RID: 8618
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040021AB RID: 8619
		private const string TABLE = "KurotatoWaveLevel";

		// Token: 0x040021AC RID: 8620
		private const string COMMAND = "select BinData from `KurotatoWaveLevel` where Id=?";

		// Token: 0x040021AD RID: 8621
		private const string KEY_PREFIX = "KurotatoWaveLevelById";

		// Token: 0x040021AE RID: 8622
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021AF RID: 8623
		private static int HandleId;
	}
}
