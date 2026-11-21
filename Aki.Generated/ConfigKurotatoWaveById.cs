using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D1 RID: 1233
	public class ConfigKurotatoWaveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CF1 RID: 7409 RVA: 0x001005D3 File Offset: 0x000FE7D3
		static ConfigKurotatoWaveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaveById.CreateStaticDefaultValue), new Action(ConfigKurotatoWaveById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x001005F4 File Offset: 0x000FE7F4
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

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00100673 File Offset: 0x000FE873
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaveById.LogPair = null;
			ConfigKurotatoWaveById.HandleId = 0;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00100681 File Offset: 0x000FE881
		public static void Init()
		{
			ConfigKurotatoWaveById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaveById.HandleId, "db_kurotato.db", "select BinData from `KurotatoWave` where Id=?");
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0010069C File Offset: 0x000FE89C
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

		// Token: 0x0400219B RID: 8603
		private const string DB = "db_kurotato.db";

		// Token: 0x0400219C RID: 8604
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x0400219D RID: 8605
		private const string TABLE = "KurotatoWave";

		// Token: 0x0400219E RID: 8606
		private const string COMMAND = "select BinData from `KurotatoWave` where Id=?";

		// Token: 0x0400219F RID: 8607
		private const string KEY_PREFIX = "KurotatoWaveById";

		// Token: 0x040021A0 RID: 8608
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021A1 RID: 8609
		private static int HandleId;
	}
}
