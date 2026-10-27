using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BD RID: 1213
	public class ConfigKurotatoWaveLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C79 RID: 7289 RVA: 0x000FA25B File Offset: 0x000F845B
		static ConfigKurotatoWaveLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaveLevelById.CreateStaticDefaultValue), new Action(ConfigKurotatoWaveLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x000FA27C File Offset: 0x000F847C
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

		// Token: 0x06001C7B RID: 7291 RVA: 0x000FA2FB File Offset: 0x000F84FB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaveLevelById.LogPair = null;
			ConfigKurotatoWaveLevelById.HandleId = 0;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000FA309 File Offset: 0x000F8509
		public static void Init()
		{
			ConfigKurotatoWaveLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaveLevelById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWaveLevel` where Id=?");
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x000FA324 File Offset: 0x000F8524
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

		// Token: 0x0400210F RID: 8463
		private const string DB = "db_kurotato.db";

		// Token: 0x04002110 RID: 8464
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x04002111 RID: 8465
		private const string TABLE = "KurotatoWaveLevel";

		// Token: 0x04002112 RID: 8466
		private const string COMMAND = "select BinData from `KurotatoWaveLevel` where Id=?";

		// Token: 0x04002113 RID: 8467
		private const string KEY_PREFIX = "KurotatoWaveLevelById";

		// Token: 0x04002114 RID: 8468
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002115 RID: 8469
		private static int HandleId;
	}
}
