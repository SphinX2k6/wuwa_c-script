using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A6 RID: 1190
	public class ConfigKurotatoExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BEE RID: 7150 RVA: 0x000FABAB File Offset: 0x000F8DAB
		static ConfigKurotatoExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoExpById.CreateStaticDefaultValue), new Action(ConfigKurotatoExpById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x000FABCC File Offset: 0x000F8DCC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoExpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoExpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoExp"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoExp` where Id=?")
			});
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x000FAC4B File Offset: 0x000F8E4B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoExpById.LogPair = null;
			ConfigKurotatoExpById.HandleId = 0;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x000FAC59 File Offset: 0x000F8E59
		public static void Init()
		{
			ConfigKurotatoExpById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoExpById.HandleId, "db_kurotato.db", "select BinData from `KurotatoExp` where Id=?");
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x000FAC74 File Offset: 0x000F8E74
		public static KurotatoExp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoExpById.HandleId, ConfigKurotatoExpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoExp?(KurotatoExp.GetRootAsKurotatoExp(configBuffer));
				}
			}
			ConfigKurotatoExpById.LogPair.Clear();
			ConfigKurotatoExpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoExpById.HandleId, 1, p0Id, ConfigKurotatoExpById.LogPair) || ConfigCommon.Step(ConfigKurotatoExpById.HandleId, true, ConfigKurotatoExpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoExpById.HandleId, ConfigKurotatoExpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoExpById.HandleId, 0, ConfigKurotatoExpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoExpById.HandleId, ConfigKurotatoExpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoExp rootAsKurotatoExp = KurotatoExp.GetRootAsKurotatoExp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoExpById.HandleId, ConfigKurotatoExpById.LogPair);
			return new KurotatoExp?(rootAsKurotatoExp);
		}

		// Token: 0x0400206E RID: 8302
		private const string DB = "db_kurotato.db";

		// Token: 0x0400206F RID: 8303
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04002070 RID: 8304
		private const string TABLE = "KurotatoExp";

		// Token: 0x04002071 RID: 8305
		private const string COMMAND = "select BinData from `KurotatoExp` where Id=?";

		// Token: 0x04002072 RID: 8306
		private const string KEY_PREFIX = "KurotatoExpById";

		// Token: 0x04002073 RID: 8307
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002074 RID: 8308
		private static int HandleId;
	}
}
