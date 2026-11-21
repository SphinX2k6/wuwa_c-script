using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AC RID: 1196
	public class ConfigKurotatoHandbookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C13 RID: 7187 RVA: 0x000FBA53 File Offset: 0x000F9C53
		static ConfigKurotatoHandbookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoHandbookById.CreateStaticDefaultValue), new Action(ConfigKurotatoHandbookById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000FBA74 File Offset: 0x000F9C74
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoHandbookById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoHandbookById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoHandbook"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoHandbook` where Id=?")
			});
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000FBAF3 File Offset: 0x000F9CF3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoHandbookById.LogPair = null;
			ConfigKurotatoHandbookById.HandleId = 0;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000FBB01 File Offset: 0x000F9D01
		public static void Init()
		{
			ConfigKurotatoHandbookById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoHandbookById.HandleId, "db_kurotato.db", "select BinData from `KurotatoHandbook` where Id=?");
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000FBB1C File Offset: 0x000F9D1C
		public static KurotatoHandbook? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoHandbookById.HandleId, ConfigKurotatoHandbookById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoHandbookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoHandbook?(KurotatoHandbook.GetRootAsKurotatoHandbook(configBuffer));
				}
			}
			ConfigKurotatoHandbookById.LogPair.Clear();
			ConfigKurotatoHandbookById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoHandbookById.HandleId, 1, p0Id, ConfigKurotatoHandbookById.LogPair) || ConfigCommon.Step(ConfigKurotatoHandbookById.HandleId, true, ConfigKurotatoHandbookById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoHandbookById.HandleId, ConfigKurotatoHandbookById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoHandbookById.HandleId, 0, ConfigKurotatoHandbookById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoHandbookById.HandleId, ConfigKurotatoHandbookById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoHandbook rootAsKurotatoHandbook = KurotatoHandbook.GetRootAsKurotatoHandbook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoHandbookById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoHandbookById.HandleId, ConfigKurotatoHandbookById.LogPair);
			return new KurotatoHandbook?(rootAsKurotatoHandbook);
		}

		// Token: 0x04002098 RID: 8344
		private const string DB = "db_kurotato.db";

		// Token: 0x04002099 RID: 8345
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x0400209A RID: 8346
		private const string TABLE = "KurotatoHandbook";

		// Token: 0x0400209B RID: 8347
		private const string COMMAND = "select BinData from `KurotatoHandbook` where Id=?";

		// Token: 0x0400209C RID: 8348
		private const string KEY_PREFIX = "KurotatoHandbookById";

		// Token: 0x0400209D RID: 8349
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400209E RID: 8350
		private static int HandleId;
	}
}
