using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000496 RID: 1174
	public class ConfigKurotatoHandbookById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B8F RID: 7055 RVA: 0x000F52FF File Offset: 0x000F34FF
		static ConfigKurotatoHandbookById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoHandbookById.CreateStaticDefaultValue), new Action(ConfigKurotatoHandbookById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000F5320 File Offset: 0x000F3520
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

		// Token: 0x06001B91 RID: 7057 RVA: 0x000F539F File Offset: 0x000F359F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoHandbookById.LogPair = null;
			ConfigKurotatoHandbookById.HandleId = 0;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000F53AD File Offset: 0x000F35AD
		public static void Init()
		{
			ConfigKurotatoHandbookById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoHandbookById.HandleId, "db_kurotato.db", "select BinData from `KurotatoHandbook` where Id=?");
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000F53C8 File Offset: 0x000F35C8
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

		// Token: 0x04001FFE RID: 8190
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FFF RID: 8191
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04002000 RID: 8192
		private const string TABLE = "KurotatoHandbook";

		// Token: 0x04002001 RID: 8193
		private const string COMMAND = "select BinData from `KurotatoHandbook` where Id=?";

		// Token: 0x04002002 RID: 8194
		private const string KEY_PREFIX = "KurotatoHandbookById";

		// Token: 0x04002003 RID: 8195
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002004 RID: 8196
		private static int HandleId;
	}
}
