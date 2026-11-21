using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A2 RID: 1186
	public class ConfigKurotatoDeathrattleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BD6 RID: 7126 RVA: 0x000FA340 File Offset: 0x000F8540
		static ConfigKurotatoDeathrattleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoDeathrattleById.CreateStaticDefaultValue), new Action(ConfigKurotatoDeathrattleById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x000FA360 File Offset: 0x000F8560
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoDeathrattleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoDeathrattleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoDeathrattle"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoDeathrattle` where Id=?")
			});
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000FA3DF File Offset: 0x000F85DF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoDeathrattleById.LogPair = null;
			ConfigKurotatoDeathrattleById.HandleId = 0;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000FA3ED File Offset: 0x000F85ED
		public static void Init()
		{
			ConfigKurotatoDeathrattleById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoDeathrattleById.HandleId, "db_kurotato.db", "select BinData from `KurotatoDeathrattle` where Id=?");
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x000FA408 File Offset: 0x000F8608
		public static KurotatoDeathrattle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoDeathrattleById.HandleId, ConfigKurotatoDeathrattleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoDeathrattleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoDeathrattle?(KurotatoDeathrattle.GetRootAsKurotatoDeathrattle(configBuffer));
				}
			}
			ConfigKurotatoDeathrattleById.LogPair.Clear();
			ConfigKurotatoDeathrattleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoDeathrattleById.HandleId, 1, p0Id, ConfigKurotatoDeathrattleById.LogPair) || ConfigCommon.Step(ConfigKurotatoDeathrattleById.HandleId, true, ConfigKurotatoDeathrattleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoDeathrattleById.HandleId, ConfigKurotatoDeathrattleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoDeathrattleById.HandleId, 0, ConfigKurotatoDeathrattleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoDeathrattleById.HandleId, ConfigKurotatoDeathrattleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoDeathrattle rootAsKurotatoDeathrattle = KurotatoDeathrattle.GetRootAsKurotatoDeathrattle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoDeathrattleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoDeathrattleById.HandleId, ConfigKurotatoDeathrattleById.LogPair);
			return new KurotatoDeathrattle?(rootAsKurotatoDeathrattle);
		}

		// Token: 0x04002052 RID: 8274
		private const string DB = "db_kurotato.db";

		// Token: 0x04002053 RID: 8275
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002054 RID: 8276
		private const string TABLE = "KurotatoDeathrattle";

		// Token: 0x04002055 RID: 8277
		private const string COMMAND = "select BinData from `KurotatoDeathrattle` where Id=?";

		// Token: 0x04002056 RID: 8278
		private const string KEY_PREFIX = "KurotatoDeathrattleById";

		// Token: 0x04002057 RID: 8279
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002058 RID: 8280
		private static int HandleId;
	}
}
