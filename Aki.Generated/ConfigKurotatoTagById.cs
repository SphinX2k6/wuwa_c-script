using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CF RID: 1231
	public class ConfigKurotatoTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CE5 RID: 7397 RVA: 0x001001F7 File Offset: 0x000FE3F7
		static ConfigKurotatoTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoTagById.CreateStaticDefaultValue), new Action(ConfigKurotatoTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00100218 File Offset: 0x000FE418
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_标签.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoTag"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoTag` where Id=?")
			});
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00100297 File Offset: 0x000FE497
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoTagById.LogPair = null;
			ConfigKurotatoTagById.HandleId = 0;
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x001002A5 File Offset: 0x000FE4A5
		public static void Init()
		{
			ConfigKurotatoTagById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoTagById.HandleId, "db_kurotato.db", "select BinData from `KurotatoTag` where Id=?");
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x001002C0 File Offset: 0x000FE4C0
		public static KurotatoTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoTagById.HandleId, ConfigKurotatoTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoTag?(KurotatoTag.GetRootAsKurotatoTag(configBuffer));
				}
			}
			ConfigKurotatoTagById.LogPair.Clear();
			ConfigKurotatoTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoTagById.HandleId, 1, p0Id, ConfigKurotatoTagById.LogPair) || ConfigCommon.Step(ConfigKurotatoTagById.HandleId, true, ConfigKurotatoTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoTagById.HandleId, ConfigKurotatoTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoTagById.HandleId, 0, ConfigKurotatoTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoTagById.HandleId, ConfigKurotatoTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoTag rootAsKurotatoTag = KurotatoTag.GetRootAsKurotatoTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoTagById.HandleId, ConfigKurotatoTagById.LogPair);
			return new KurotatoTag?(rootAsKurotatoTag);
		}

		// Token: 0x0400218D RID: 8589
		private const string DB = "db_kurotato.db";

		// Token: 0x0400218E RID: 8590
		private const string FILE = "t.土豆兄弟_标签.xlsx";

		// Token: 0x0400218F RID: 8591
		private const string TABLE = "KurotatoTag";

		// Token: 0x04002190 RID: 8592
		private const string COMMAND = "select BinData from `KurotatoTag` where Id=?";

		// Token: 0x04002191 RID: 8593
		private const string KEY_PREFIX = "KurotatoTagById";

		// Token: 0x04002192 RID: 8594
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002193 RID: 8595
		private static int HandleId;
	}
}
