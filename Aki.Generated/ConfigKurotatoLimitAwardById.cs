using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A2 RID: 1186
	public class ConfigKurotatoLimitAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BD7 RID: 7127 RVA: 0x000F6BB7 File Offset: 0x000F4DB7
		static ConfigKurotatoLimitAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLimitAwardById.CreateStaticDefaultValue), new Action(ConfigKurotatoLimitAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x000F6BD8 File Offset: 0x000F4DD8
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

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000F6C57 File Offset: 0x000F4E57
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLimitAwardById.LogPair = null;
			ConfigKurotatoLimitAwardById.HandleId = 0;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x000F6C65 File Offset: 0x000F4E65
		public static void Init()
		{
			ConfigKurotatoLimitAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLimitAwardById.HandleId, "db_kurotato.db", "select BinData from `KurotatoLimitAward` where Id=?");
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x000F6C80 File Offset: 0x000F4E80
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

		// Token: 0x04002052 RID: 8274
		private const string DB = "db_kurotato.db";

		// Token: 0x04002053 RID: 8275
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04002054 RID: 8276
		private const string TABLE = "KurotatoLimitAward";

		// Token: 0x04002055 RID: 8277
		private const string COMMAND = "select BinData from `KurotatoLimitAward` where Id=?";

		// Token: 0x04002056 RID: 8278
		private const string KEY_PREFIX = "KurotatoLimitAwardById";

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
