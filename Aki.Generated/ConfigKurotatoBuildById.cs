using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049C RID: 1180
	public class ConfigKurotatoBuildById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BB2 RID: 7090 RVA: 0x000F9707 File Offset: 0x000F7907
		static ConfigKurotatoBuildById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoBuildById.CreateStaticDefaultValue), new Action(ConfigKurotatoBuildById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000F9728 File Offset: 0x000F7928
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoBuildById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoBuildById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_抽取规则.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoBuild` where Id=?")
			});
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000F97A7 File Offset: 0x000F79A7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoBuildById.LogPair = null;
			ConfigKurotatoBuildById.HandleId = 0;
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000F97B5 File Offset: 0x000F79B5
		public static void Init()
		{
			ConfigKurotatoBuildById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoBuildById.HandleId, "db_kurotato.db", "select BinData from `KurotatoBuild` where Id=?");
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000F97D0 File Offset: 0x000F79D0
		public static KurotatoBuild? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoBuildById.HandleId, ConfigKurotatoBuildById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoBuild?(KurotatoBuild.GetRootAsKurotatoBuild(configBuffer));
				}
			}
			ConfigKurotatoBuildById.LogPair.Clear();
			ConfigKurotatoBuildById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoBuildById.HandleId, 1, p0Id, ConfigKurotatoBuildById.LogPair) || ConfigCommon.Step(ConfigKurotatoBuildById.HandleId, true, ConfigKurotatoBuildById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoBuildById.HandleId, ConfigKurotatoBuildById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoBuildById.HandleId, 0, ConfigKurotatoBuildById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoBuildById.HandleId, ConfigKurotatoBuildById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoBuild rootAsKurotatoBuild = KurotatoBuild.GetRootAsKurotatoBuild(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoBuildById.HandleId, ConfigKurotatoBuildById.LogPair);
			return new KurotatoBuild?(rootAsKurotatoBuild);
		}

		// Token: 0x04002028 RID: 8232
		private const string DB = "db_kurotato.db";

		// Token: 0x04002029 RID: 8233
		private const string FILE = "t.土豆兄弟_抽取规则.xlsx";

		// Token: 0x0400202A RID: 8234
		private const string TABLE = "KurotatoBuild";

		// Token: 0x0400202B RID: 8235
		private const string COMMAND = "select BinData from `KurotatoBuild` where Id=?";

		// Token: 0x0400202C RID: 8236
		private const string KEY_PREFIX = "KurotatoBuildById";

		// Token: 0x0400202D RID: 8237
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400202E RID: 8238
		private static int HandleId;
	}
}
