using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000911 RID: 2321
	public class ConfigSheriffAnomalyByQuestionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003679 RID: 13945 RVA: 0x0018D488 File Offset: 0x0018B688
		static ConfigSheriffAnomalyByQuestionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffAnomalyByQuestionId.CreateStaticDefaultValue), new Action(ConfigSheriffAnomalyByQuestionId.ResetStaticDefaultValue));
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x0018D4A8 File Offset: 0x0018B6A8
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffAnomalyByQuestionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffAnomalyByQuestionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffAnomaly"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffAnomaly` where QuestionId=?")
			});
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x0018D527 File Offset: 0x0018B727
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffAnomalyByQuestionId.LogPair = null;
			ConfigSheriffAnomalyByQuestionId.HandleId = 0;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x0018D535 File Offset: 0x0018B735
		public static void Init()
		{
			ConfigSheriffAnomalyByQuestionId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffAnomalyByQuestionId.HandleId, "db_sheriff.db", "select BinData from `SheriffAnomaly` where QuestionId=?");
		}

		// Token: 0x0600367D RID: 13949 RVA: 0x0018D550 File Offset: 0x0018B750
		public static SheriffAnomaly? GetConfig(int p0QuestionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffAnomalyByQuestionId.HandleId, ConfigSheriffAnomalyByQuestionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyByQuestionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffAnomaly?(SheriffAnomaly.GetRootAsSheriffAnomaly(configBuffer));
				}
			}
			ConfigSheriffAnomalyByQuestionId.LogPair.Clear();
			ConfigSheriffAnomalyByQuestionId.LogPair.Add(new ValueTuple<string, object>("QuestionId", p0QuestionId));
			if (!ConfigCommon.BindInt(ConfigSheriffAnomalyByQuestionId.HandleId, 1, p0QuestionId, ConfigSheriffAnomalyByQuestionId.LogPair) || ConfigCommon.Step(ConfigSheriffAnomalyByQuestionId.HandleId, true, ConfigSheriffAnomalyByQuestionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyByQuestionId.HandleId, ConfigSheriffAnomalyByQuestionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffAnomalyByQuestionId.HandleId, 0, ConfigSheriffAnomalyByQuestionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyByQuestionId.HandleId, ConfigSheriffAnomalyByQuestionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffAnomaly rootAsSheriffAnomaly = SheriffAnomaly.GetRootAsSheriffAnomaly(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyByQuestionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffAnomalyByQuestionId.HandleId, ConfigSheriffAnomalyByQuestionId.LogPair);
			return new SheriffAnomaly?(rootAsSheriffAnomaly);
		}

		// Token: 0x04003F5D RID: 16221
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F5E RID: 16222
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F5F RID: 16223
		private const string TABLE = "SheriffAnomaly";

		// Token: 0x04003F60 RID: 16224
		private const string COMMAND = "select BinData from `SheriffAnomaly` where QuestionId=?";

		// Token: 0x04003F61 RID: 16225
		private const string KEY_PREFIX = "SheriffAnomalyByQuestionId";

		// Token: 0x04003F62 RID: 16226
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F63 RID: 16227
		private static int HandleId;
	}
}
