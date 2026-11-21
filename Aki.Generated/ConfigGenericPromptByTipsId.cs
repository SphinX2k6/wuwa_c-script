using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039A RID: 922
	public class ConfigGenericPromptByTipsId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015A2 RID: 5538 RVA: 0x000D77C9 File Offset: 0x000D59C9
		static ConfigGenericPromptByTipsId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGenericPromptByTipsId.CreateStaticDefaultValue), new Action(ConfigGenericPromptByTipsId.ResetStaticDefaultValue));
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000D77E8 File Offset: 0x000D59E8
		public static void CreateStaticDefaultValue()
		{
			ConfigGenericPromptByTipsId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGenericPromptByTipsId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_generic_tips.db"),
				new ValueTuple<string, object>("文件", "t.通用提示.xlsx"),
				new ValueTuple<string, object>("表名", "GenericPrompt"),
				new ValueTuple<string, object>("语句", "select BinData from `GenericPrompt` where TipsId=?")
			});
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x000D7867 File Offset: 0x000D5A67
		public static void ResetStaticDefaultValue()
		{
			ConfigGenericPromptByTipsId.LogPair = null;
			ConfigGenericPromptByTipsId.HandleId = 0;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x000D7875 File Offset: 0x000D5A75
		public static void Init()
		{
			ConfigGenericPromptByTipsId.HandleId = ConfigCommon.InitDataStatement(ConfigGenericPromptByTipsId.HandleId, "db_generic_tips.db", "select BinData from `GenericPrompt` where TipsId=?");
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000D7890 File Offset: 0x000D5A90
		public static GenericPrompt? GetConfig(string p0TipsId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGenericPromptByTipsId.HandleId, ConfigGenericPromptByTipsId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("GenericPromptByTipsId#" + p0TipsId);
				if (configBuffer != null)
				{
					return new GenericPrompt?(GenericPrompt.GetRootAsGenericPrompt(configBuffer));
				}
			}
			ConfigGenericPromptByTipsId.LogPair.Clear();
			ConfigGenericPromptByTipsId.LogPair.Add(new ValueTuple<string, object>("TipsId", p0TipsId));
			if (!ConfigCommon.BindString(ConfigGenericPromptByTipsId.HandleId, 1, p0TipsId, ConfigGenericPromptByTipsId.LogPair) || ConfigCommon.Step(ConfigGenericPromptByTipsId.HandleId, true, ConfigGenericPromptByTipsId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGenericPromptByTipsId.HandleId, ConfigGenericPromptByTipsId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGenericPromptByTipsId.HandleId, 0, ConfigGenericPromptByTipsId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGenericPromptByTipsId.HandleId, ConfigGenericPromptByTipsId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GenericPrompt rootAsGenericPrompt = GenericPrompt.GetRootAsGenericPrompt(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("GenericPromptByTipsId#" + p0TipsId, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGenericPromptByTipsId.HandleId, ConfigGenericPromptByTipsId.LogPair);
			return new GenericPrompt?(rootAsGenericPrompt);
		}

		// Token: 0x0400191A RID: 6426
		private const string DB = "db_generic_tips.db";

		// Token: 0x0400191B RID: 6427
		private const string FILE = "t.通用提示.xlsx";

		// Token: 0x0400191C RID: 6428
		private const string TABLE = "GenericPrompt";

		// Token: 0x0400191D RID: 6429
		private const string COMMAND = "select BinData from `GenericPrompt` where TipsId=?";

		// Token: 0x0400191E RID: 6430
		private const string KEY_PREFIX = "GenericPromptByTipsId";

		// Token: 0x0400191F RID: 6431
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001920 RID: 6432
		private static int HandleId;
	}
}
