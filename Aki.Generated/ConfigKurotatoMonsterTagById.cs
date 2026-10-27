using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A8 RID: 1192
	public class ConfigKurotatoMonsterTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BFB RID: 7163 RVA: 0x000F78B3 File Offset: 0x000F5AB3
		static ConfigKurotatoMonsterTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterTagById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000F78D4 File Offset: 0x000F5AD4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonsterTag"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonsterTag` where Id=?")
			});
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000F7953 File Offset: 0x000F5B53
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterTagById.LogPair = null;
			ConfigKurotatoMonsterTagById.HandleId = 0;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000F7961 File Offset: 0x000F5B61
		public static void Init()
		{
			ConfigKurotatoMonsterTagById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterTagById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterTag` where Id=?");
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x000F797C File Offset: 0x000F5B7C
		public static KurotatoMonsterTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterTagById.HandleId, ConfigKurotatoMonsterTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoMonsterTag?(KurotatoMonsterTag.GetRootAsKurotatoMonsterTag(configBuffer));
				}
			}
			ConfigKurotatoMonsterTagById.LogPair.Clear();
			ConfigKurotatoMonsterTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoMonsterTagById.HandleId, 1, p0Id, ConfigKurotatoMonsterTagById.LogPair) || ConfigCommon.Step(ConfigKurotatoMonsterTagById.HandleId, true, ConfigKurotatoMonsterTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterTagById.HandleId, ConfigKurotatoMonsterTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterTagById.HandleId, 0, ConfigKurotatoMonsterTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterTagById.HandleId, ConfigKurotatoMonsterTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoMonsterTag rootAsKurotatoMonsterTag = KurotatoMonsterTag.GetRootAsKurotatoMonsterTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterTagById.HandleId, ConfigKurotatoMonsterTagById.LogPair);
			return new KurotatoMonsterTag?(rootAsKurotatoMonsterTag);
		}

		// Token: 0x0400207C RID: 8316
		private const string DB = "db_kurotato.db";

		// Token: 0x0400207D RID: 8317
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x0400207E RID: 8318
		private const string TABLE = "KurotatoMonsterTag";

		// Token: 0x0400207F RID: 8319
		private const string COMMAND = "select BinData from `KurotatoMonsterTag` where Id=?";

		// Token: 0x04002080 RID: 8320
		private const string KEY_PREFIX = "KurotatoMonsterTagById";

		// Token: 0x04002081 RID: 8321
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002082 RID: 8322
		private static int HandleId;
	}
}
