using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B3 RID: 1203
	public class ConfigKurotatoRewardTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C3D RID: 7229 RVA: 0x000F8E5B File Offset: 0x000F705B
		static ConfigKurotatoRewardTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoRewardTabById.CreateStaticDefaultValue), new Action(ConfigKurotatoRewardTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x000F8E7C File Offset: 0x000F707C
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

		// Token: 0x06001C3F RID: 7231 RVA: 0x000F8EFB File Offset: 0x000F70FB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoRewardTabById.LogPair = null;
			ConfigKurotatoRewardTabById.HandleId = 0;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000F8F09 File Offset: 0x000F7109
		public static void Init()
		{
			ConfigKurotatoRewardTabById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoRewardTabById.HandleId, "db_kurotato.db", "select BinData from `KurotatoRewardTab` where Id=?");
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000F8F24 File Offset: 0x000F7124
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

		// Token: 0x040020C9 RID: 8393
		private const string DB = "db_kurotato.db";

		// Token: 0x040020CA RID: 8394
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x040020CB RID: 8395
		private const string TABLE = "KurotatoRewardTab";

		// Token: 0x040020CC RID: 8396
		private const string COMMAND = "select BinData from `KurotatoRewardTab` where Id=?";

		// Token: 0x040020CD RID: 8397
		private const string KEY_PREFIX = "KurotatoRewardTabById";

		// Token: 0x040020CE RID: 8398
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020CF RID: 8399
		private static int HandleId;
	}
}
