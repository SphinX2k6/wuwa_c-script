using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BB RID: 1211
	public class ConfigKurotatoMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C6D RID: 7277 RVA: 0x000FD9E4 File Offset: 0x000FBBE4
		static ConfigKurotatoMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000FDA04 File Offset: 0x000FBC04
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonster` where Id=?")
			});
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000FDA83 File Offset: 0x000FBC83
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterById.LogPair = null;
			ConfigKurotatoMonsterById.HandleId = 0;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000FDA91 File Offset: 0x000FBC91
		public static void Init()
		{
			ConfigKurotatoMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonster` where Id=?");
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000FDAAC File Offset: 0x000FBCAC
		public static KurotatoMonster? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterById.HandleId, ConfigKurotatoMonsterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoMonster?(KurotatoMonster.GetRootAsKurotatoMonster(configBuffer));
				}
			}
			ConfigKurotatoMonsterById.LogPair.Clear();
			ConfigKurotatoMonsterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoMonsterById.HandleId, 1, p0Id, ConfigKurotatoMonsterById.LogPair) || ConfigCommon.Step(ConfigKurotatoMonsterById.HandleId, true, ConfigKurotatoMonsterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterById.HandleId, ConfigKurotatoMonsterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterById.HandleId, 0, ConfigKurotatoMonsterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterById.HandleId, ConfigKurotatoMonsterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoMonster rootAsKurotatoMonster = KurotatoMonster.GetRootAsKurotatoMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterById.HandleId, ConfigKurotatoMonsterById.LogPair);
			return new KurotatoMonster?(rootAsKurotatoMonster);
		}

		// Token: 0x04002101 RID: 8449
		private const string DB = "db_kurotato.db";

		// Token: 0x04002102 RID: 8450
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002103 RID: 8451
		private const string TABLE = "KurotatoMonster";

		// Token: 0x04002104 RID: 8452
		private const string COMMAND = "select BinData from `KurotatoMonster` where Id=?";

		// Token: 0x04002105 RID: 8453
		private const string KEY_PREFIX = "KurotatoMonsterById";

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
