using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C7 RID: 1223
	public class ConfigKurotatoResAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CB5 RID: 7349 RVA: 0x000FF1D3 File Offset: 0x000FD3D3
		static ConfigKurotatoResAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoResAwardById.CreateStaticDefaultValue), new Action(ConfigKurotatoResAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000FF1F4 File Offset: 0x000FD3F4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoResAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoResAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoResAward"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoResAward` where Id=?")
			});
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000FF273 File Offset: 0x000FD473
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoResAwardById.LogPair = null;
			ConfigKurotatoResAwardById.HandleId = 0;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000FF281 File Offset: 0x000FD481
		public static void Init()
		{
			ConfigKurotatoResAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoResAwardById.HandleId, "db_kurotato.db", "select BinData from `KurotatoResAward` where Id=?");
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000FF29C File Offset: 0x000FD49C
		public static KurotatoResAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoResAwardById.HandleId, ConfigKurotatoResAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoResAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoResAward?(KurotatoResAward.GetRootAsKurotatoResAward(configBuffer));
				}
			}
			ConfigKurotatoResAwardById.LogPair.Clear();
			ConfigKurotatoResAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoResAwardById.HandleId, 1, p0Id, ConfigKurotatoResAwardById.LogPair) || ConfigCommon.Step(ConfigKurotatoResAwardById.HandleId, true, ConfigKurotatoResAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoResAwardById.HandleId, ConfigKurotatoResAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoResAwardById.HandleId, 0, ConfigKurotatoResAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoResAwardById.HandleId, ConfigKurotatoResAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoResAward rootAsKurotatoResAward = KurotatoResAward.GetRootAsKurotatoResAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoResAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoResAwardById.HandleId, ConfigKurotatoResAwardById.LogPair);
			return new KurotatoResAward?(rootAsKurotatoResAward);
		}

		// Token: 0x04002155 RID: 8533
		private const string DB = "db_kurotato.db";

		// Token: 0x04002156 RID: 8534
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04002157 RID: 8535
		private const string TABLE = "KurotatoResAward";

		// Token: 0x04002158 RID: 8536
		private const string COMMAND = "select BinData from `KurotatoResAward` where Id=?";

		// Token: 0x04002159 RID: 8537
		private const string KEY_PREFIX = "KurotatoResAwardById";

		// Token: 0x0400215A RID: 8538
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400215B RID: 8539
		private static int HandleId;
	}
}
