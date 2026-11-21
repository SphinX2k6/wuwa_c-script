using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C9 RID: 1225
	public class ConfigKurotatoRewardTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CC1 RID: 7361 RVA: 0x000FF5AF File Offset: 0x000FD7AF
		static ConfigKurotatoRewardTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoRewardTabById.CreateStaticDefaultValue), new Action(ConfigKurotatoRewardTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x000FF5D0 File Offset: 0x000FD7D0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoRewardTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoRewardTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoRewardTab` where Id=?")
			});
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000FF64F File Offset: 0x000FD84F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoRewardTabById.LogPair = null;
			ConfigKurotatoRewardTabById.HandleId = 0;
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000FF65D File Offset: 0x000FD85D
		public static void Init()
		{
			ConfigKurotatoRewardTabById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoRewardTabById.HandleId, "db_kurotato.db", "select BinData from `KurotatoRewardTab` where Id=?");
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x000FF678 File Offset: 0x000FD878
		public static KurotatoRewardTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoRewardTabById.HandleId, ConfigKurotatoRewardTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoRewardTab?(KurotatoRewardTab.GetRootAsKurotatoRewardTab(configBuffer));
				}
			}
			ConfigKurotatoRewardTabById.LogPair.Clear();
			ConfigKurotatoRewardTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoRewardTabById.HandleId, 1, p0Id, ConfigKurotatoRewardTabById.LogPair) || ConfigCommon.Step(ConfigKurotatoRewardTabById.HandleId, true, ConfigKurotatoRewardTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoRewardTabById.HandleId, ConfigKurotatoRewardTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoRewardTabById.HandleId, 0, ConfigKurotatoRewardTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoRewardTabById.HandleId, ConfigKurotatoRewardTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoRewardTab rootAsKurotatoRewardTab = KurotatoRewardTab.GetRootAsKurotatoRewardTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoRewardTabById.HandleId, ConfigKurotatoRewardTabById.LogPair);
			return new KurotatoRewardTab?(rootAsKurotatoRewardTab);
		}

		// Token: 0x04002163 RID: 8547
		private const string DB = "db_kurotato.db";

		// Token: 0x04002164 RID: 8548
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04002165 RID: 8549
		private const string TABLE = "KurotatoRewardTab";

		// Token: 0x04002166 RID: 8550
		private const string COMMAND = "select BinData from `KurotatoRewardTab` where Id=?";

		// Token: 0x04002167 RID: 8551
		private const string KEY_PREFIX = "KurotatoRewardTabById";

		// Token: 0x04002168 RID: 8552
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002169 RID: 8553
		private static int HandleId;
	}
}
