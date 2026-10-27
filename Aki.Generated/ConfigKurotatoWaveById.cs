using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BB RID: 1211
	public class ConfigKurotatoWaveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C6D RID: 7277 RVA: 0x000F9E7F File Offset: 0x000F807F
		static ConfigKurotatoWaveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaveById.CreateStaticDefaultValue), new Action(ConfigKurotatoWaveById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000F9EA0 File Offset: 0x000F80A0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWaveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWaveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWave"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWave` where Id=?")
			});
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000F9F1F File Offset: 0x000F811F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaveById.LogPair = null;
			ConfigKurotatoWaveById.HandleId = 0;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000F9F2D File Offset: 0x000F812D
		public static void Init()
		{
			ConfigKurotatoWaveById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaveById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWave` where Id=?");
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000F9F48 File Offset: 0x000F8148
		public static KurotatoWave? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWaveById.HandleId, ConfigKurotatoWaveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWaveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoWave?(KurotatoWave.GetRootAsKurotatoWave(configBuffer));
				}
			}
			ConfigKurotatoWaveById.LogPair.Clear();
			ConfigKurotatoWaveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoWaveById.HandleId, 1, p0Id, ConfigKurotatoWaveById.LogPair) || ConfigCommon.Step(ConfigKurotatoWaveById.HandleId, true, ConfigKurotatoWaveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoWaveById.HandleId, ConfigKurotatoWaveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWaveById.HandleId, 0, ConfigKurotatoWaveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoWaveById.HandleId, ConfigKurotatoWaveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoWave rootAsKurotatoWave = KurotatoWave.GetRootAsKurotatoWave(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoWaveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoWaveById.HandleId, ConfigKurotatoWaveById.LogPair);
			return new KurotatoWave?(rootAsKurotatoWave);
		}

		// Token: 0x04002101 RID: 8449
		private const string DB = "db_kurotato.db";

		// Token: 0x04002102 RID: 8450
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x04002103 RID: 8451
		private const string TABLE = "KurotatoWave";

		// Token: 0x04002104 RID: 8452
		private const string COMMAND = "select BinData from `KurotatoWave` where Id=?";

		// Token: 0x04002105 RID: 8453
		private const string KEY_PREFIX = "KurotatoWaveById";

		// Token: 0x04002106 RID: 8454
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002107 RID: 8455
		private static int HandleId;
	}
}
