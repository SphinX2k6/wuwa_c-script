using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000782 RID: 1922
	public class ConfigPsFeedbackById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D1D RID: 11549 RVA: 0x0015BB97 File Offset: 0x00159D97
		static ConfigPsFeedbackById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPsFeedbackById.CreateStaticDefaultValue), new Action(ConfigPsFeedbackById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x0015BBB8 File Offset: 0x00159DB8
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

		// Token: 0x06002D1F RID: 11551 RVA: 0x0015BC37 File Offset: 0x00159E37
		public static void ResetStaticDefaultValue()
		{
			ConfigPsFeedbackById.LogPair = null;
			ConfigPsFeedbackById.HandleId = 0;
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x0015BC45 File Offset: 0x00159E45
		public static void Init()
		{
			ConfigPsFeedbackById.HandleId = ConfigCommon.InitDataStatement(ConfigPsFeedbackById.HandleId, "db_input_settings.db", "select BinData from `PsFeedback` where Id=?");
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0015BC60 File Offset: 0x00159E60
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

		// Token: 0x04003474 RID: 13428
		private const string DB = "db_input_settings.db";

		// Token: 0x04003475 RID: 13429
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04003476 RID: 13430
		private const string TABLE = "PsFeedback";

		// Token: 0x04003477 RID: 13431
		private const string COMMAND = "select BinData from `PsFeedback` where Id=?";

		// Token: 0x04003478 RID: 13432
		private const string KEY_PREFIX = "PsFeedbackById";

		// Token: 0x04003479 RID: 13433
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400347A RID: 13434
		private static int HandleId;
	}
}
