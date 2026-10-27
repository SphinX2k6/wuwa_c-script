using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000384 RID: 900
	public class ConfigGenericPromptByTipsId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x000D1075 File Offset: 0x000CF275
		static ConfigGenericPromptByTipsId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGenericPromptByTipsId.CreateStaticDefaultValue), new Action(ConfigGenericPromptByTipsId.ResetStaticDefaultValue));
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000D1094 File Offset: 0x000CF294
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

		// Token: 0x06001520 RID: 5408 RVA: 0x000D1113 File Offset: 0x000CF313
		public static void ResetStaticDefaultValue()
		{
			ConfigGenericPromptByTipsId.LogPair = null;
			ConfigGenericPromptByTipsId.HandleId = 0;
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000D1121 File Offset: 0x000CF321
		public static void Init()
		{
			ConfigGenericPromptByTipsId.HandleId = ConfigCommon.InitDataStatement(ConfigGenericPromptByTipsId.HandleId, "db_generic_tips.db", "select BinData from `GenericPrompt` where TipsId=?");
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000D113C File Offset: 0x000CF33C
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

		// Token: 0x04001880 RID: 6272
		private const string DB = "db_generic_tips.db";

		// Token: 0x04001881 RID: 6273
		private const string FILE = "t.通用提示.xlsx";

		// Token: 0x04001882 RID: 6274
		private const string TABLE = "GenericPrompt";

		// Token: 0x04001883 RID: 6275
		private const string COMMAND = "select BinData from `GenericPrompt` where TipsId=?";

		// Token: 0x04001884 RID: 6276
		private const string KEY_PREFIX = "GenericPromptByTipsId";

		// Token: 0x04001885 RID: 6277
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001886 RID: 6278
		private static int HandleId;
	}
}
