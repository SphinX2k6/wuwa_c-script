using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000768 RID: 1896
	public class ConfigPsFeedbackById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C81 RID: 11393 RVA: 0x00154C8B File Offset: 0x00152E8B
		static ConfigPsFeedbackById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPsFeedbackById.CreateStaticDefaultValue), new Action(ConfigPsFeedbackById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x00154CAC File Offset: 0x00152EAC
		public static void CreateStaticDefaultValue()
		{
			ConfigPsFeedbackById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPsFeedbackById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "PsFeedback"),
				new ValueTuple<string, object>("语句", "select BinData from `PsFeedback` where Id=?")
			});
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x00154D2B File Offset: 0x00152F2B
		public static void ResetStaticDefaultValue()
		{
			ConfigPsFeedbackById.LogPair = null;
			ConfigPsFeedbackById.HandleId = 0;
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x00154D39 File Offset: 0x00152F39
		public static void Init()
		{
			ConfigPsFeedbackById.HandleId = ConfigCommon.InitDataStatement(ConfigPsFeedbackById.HandleId, "db_input_settings.db", "select BinData from `PsFeedback` where Id=?");
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x00154D54 File Offset: 0x00152F54
		public static PsFeedback? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPsFeedbackById.HandleId, ConfigPsFeedbackById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("PsFeedbackById#" + p0Id);
				if (configBuffer != null)
				{
					return new PsFeedback?(PsFeedback.GetRootAsPsFeedback(configBuffer));
				}
			}
			ConfigPsFeedbackById.LogPair.Clear();
			ConfigPsFeedbackById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigPsFeedbackById.HandleId, 1, p0Id, ConfigPsFeedbackById.LogPair) || ConfigCommon.Step(ConfigPsFeedbackById.HandleId, true, ConfigPsFeedbackById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPsFeedbackById.HandleId, ConfigPsFeedbackById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPsFeedbackById.HandleId, 0, ConfigPsFeedbackById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPsFeedbackById.HandleId, ConfigPsFeedbackById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PsFeedback rootAsPsFeedback = PsFeedback.GetRootAsPsFeedback(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("PsFeedbackById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPsFeedbackById.HandleId, ConfigPsFeedbackById.LogPair);
			return new PsFeedback?(rootAsPsFeedback);
		}

		// Token: 0x040033BE RID: 13246
		private const string DB = "db_input_settings.db";

		// Token: 0x040033BF RID: 13247
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x040033C0 RID: 13248
		private const string TABLE = "PsFeedback";

		// Token: 0x040033C1 RID: 13249
		private const string COMMAND = "select BinData from `PsFeedback` where Id=?";

		// Token: 0x040033C2 RID: 13250
		private const string KEY_PREFIX = "PsFeedbackById";

		// Token: 0x040033C3 RID: 13251
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033C4 RID: 13252
		private static int HandleId;
	}
}
