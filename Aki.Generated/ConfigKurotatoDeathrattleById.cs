using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048C RID: 1164
	public class ConfigKurotatoDeathrattleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B52 RID: 6994 RVA: 0x000F3BEC File Offset: 0x000F1DEC
		static ConfigKurotatoDeathrattleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoDeathrattleById.CreateStaticDefaultValue), new Action(ConfigKurotatoDeathrattleById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x000F3C0C File Offset: 0x000F1E0C
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

		// Token: 0x06001B54 RID: 6996 RVA: 0x000F3C8B File Offset: 0x000F1E8B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoDeathrattleById.LogPair = null;
			ConfigKurotatoDeathrattleById.HandleId = 0;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000F3C99 File Offset: 0x000F1E99
		public static void Init()
		{
			ConfigKurotatoDeathrattleById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoDeathrattleById.HandleId, "db_kurotato.db", "select BinData from `KurotatoDeathrattle` where Id=?");
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x000F3CB4 File Offset: 0x000F1EB4
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

		// Token: 0x04001FB8 RID: 8120
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FB9 RID: 8121
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04001FBA RID: 8122
		private const string TABLE = "KurotatoDeathrattle";

		// Token: 0x04001FBB RID: 8123
		private const string COMMAND = "select BinData from `KurotatoDeathrattle` where Id=?";

		// Token: 0x04001FBC RID: 8124
		private const string KEY_PREFIX = "KurotatoDeathrattleById";

		// Token: 0x04001FBD RID: 8125
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FBE RID: 8126
		private static int HandleId;
	}
}
