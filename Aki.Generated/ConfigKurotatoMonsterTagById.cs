using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BE RID: 1214
	public class ConfigKurotatoMonsterTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C7F RID: 7295 RVA: 0x000FE007 File Offset: 0x000FC207
		static ConfigKurotatoMonsterTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterTagById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000FE028 File Offset: 0x000FC228
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

		// Token: 0x06001C81 RID: 7297 RVA: 0x000FE0A7 File Offset: 0x000FC2A7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterTagById.LogPair = null;
			ConfigKurotatoMonsterTagById.HandleId = 0;
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000FE0B5 File Offset: 0x000FC2B5
		public static void Init()
		{
			ConfigKurotatoMonsterTagById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterTagById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterTag` where Id=?");
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x000FE0D0 File Offset: 0x000FC2D0
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

		// Token: 0x04002116 RID: 8470
		private const string DB = "db_kurotato.db";

		// Token: 0x04002117 RID: 8471
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x04002118 RID: 8472
		private const string TABLE = "KurotatoMonsterTag";

		// Token: 0x04002119 RID: 8473
		private const string COMMAND = "select BinData from `KurotatoMonsterTag` where Id=?";

		// Token: 0x0400211A RID: 8474
		private const string KEY_PREFIX = "KurotatoMonsterTagById";

		// Token: 0x0400211B RID: 8475
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400211C RID: 8476
		private static int HandleId;
	}
}
