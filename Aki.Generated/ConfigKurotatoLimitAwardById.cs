using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B8 RID: 1208
	public class ConfigKurotatoLimitAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C5B RID: 7259 RVA: 0x000FD30B File Offset: 0x000FB50B
		static ConfigKurotatoLimitAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLimitAwardById.CreateStaticDefaultValue), new Action(ConfigKurotatoLimitAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000FD32C File Offset: 0x000FB52C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLimitAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLimitAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLimitAward"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLimitAward` where Id=?")
			});
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000FD3AB File Offset: 0x000FB5AB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLimitAwardById.LogPair = null;
			ConfigKurotatoLimitAwardById.HandleId = 0;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000FD3B9 File Offset: 0x000FB5B9
		public static void Init()
		{
			ConfigKurotatoLimitAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLimitAwardById.HandleId, "db_kurotato.db", "select BinData from `KurotatoLimitAward` where Id=?");
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x000FD3D4 File Offset: 0x000FB5D4
		public static KurotatoLimitAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLimitAwardById.HandleId, ConfigKurotatoLimitAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLimitAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoLimitAward?(KurotatoLimitAward.GetRootAsKurotatoLimitAward(configBuffer));
				}
			}
			ConfigKurotatoLimitAwardById.LogPair.Clear();
			ConfigKurotatoLimitAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoLimitAwardById.HandleId, 1, p0Id, ConfigKurotatoLimitAwardById.LogPair) || ConfigCommon.Step(ConfigKurotatoLimitAwardById.HandleId, true, ConfigKurotatoLimitAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoLimitAwardById.HandleId, ConfigKurotatoLimitAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLimitAwardById.HandleId, 0, ConfigKurotatoLimitAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoLimitAwardById.HandleId, ConfigKurotatoLimitAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoLimitAward rootAsKurotatoLimitAward = KurotatoLimitAward.GetRootAsKurotatoLimitAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLimitAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoLimitAwardById.HandleId, ConfigKurotatoLimitAwardById.LogPair);
			return new KurotatoLimitAward?(rootAsKurotatoLimitAward);
		}

		// Token: 0x040020EC RID: 8428
		private const string DB = "db_kurotato.db";

		// Token: 0x040020ED RID: 8429
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x040020EE RID: 8430
		private const string TABLE = "KurotatoLimitAward";

		// Token: 0x040020EF RID: 8431
		private const string COMMAND = "select BinData from `KurotatoLimitAward` where Id=?";

		// Token: 0x040020F0 RID: 8432
		private const string KEY_PREFIX = "KurotatoLimitAwardById";

		// Token: 0x040020F1 RID: 8433
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020F2 RID: 8434
		private static int HandleId;
	}
}
