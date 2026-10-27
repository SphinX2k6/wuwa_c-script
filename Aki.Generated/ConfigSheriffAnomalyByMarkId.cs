using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000910 RID: 2320
	public class ConfigSheriffAnomalyByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003673 RID: 13939 RVA: 0x0018D240 File Offset: 0x0018B440
		static ConfigSheriffAnomalyByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffAnomalyByMarkId.CreateStaticDefaultValue), new Action(ConfigSheriffAnomalyByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0018D260 File Offset: 0x0018B460
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffAnomalyByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffAnomalyByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffAnomaly"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffAnomaly` where MarkId=?")
			});
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x0018D2DF File Offset: 0x0018B4DF
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffAnomalyByMarkId.LogPair = null;
			ConfigSheriffAnomalyByMarkId.HandleId = 0;
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x0018D2ED File Offset: 0x0018B4ED
		public static void Init()
		{
			ConfigSheriffAnomalyByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffAnomalyByMarkId.HandleId, "db_sheriff.db", "select BinData from `SheriffAnomaly` where MarkId=?");
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x0018D308 File Offset: 0x0018B508
		public static SheriffAnomaly? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffAnomalyByMarkId.HandleId, ConfigSheriffAnomalyByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffAnomaly?(SheriffAnomaly.GetRootAsSheriffAnomaly(configBuffer));
				}
			}
			ConfigSheriffAnomalyByMarkId.LogPair.Clear();
			ConfigSheriffAnomalyByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigSheriffAnomalyByMarkId.HandleId, 1, p0MarkId, ConfigSheriffAnomalyByMarkId.LogPair) || ConfigCommon.Step(ConfigSheriffAnomalyByMarkId.HandleId, true, ConfigSheriffAnomalyByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyByMarkId.HandleId, ConfigSheriffAnomalyByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffAnomalyByMarkId.HandleId, 0, ConfigSheriffAnomalyByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyByMarkId.HandleId, ConfigSheriffAnomalyByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffAnomaly rootAsSheriffAnomaly = SheriffAnomaly.GetRootAsSheriffAnomaly(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffAnomalyByMarkId.HandleId, ConfigSheriffAnomalyByMarkId.LogPair);
			return new SheriffAnomaly?(rootAsSheriffAnomaly);
		}

		// Token: 0x04003F56 RID: 16214
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F57 RID: 16215
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F58 RID: 16216
		private const string TABLE = "SheriffAnomaly";

		// Token: 0x04003F59 RID: 16217
		private const string COMMAND = "select BinData from `SheriffAnomaly` where MarkId=?";

		// Token: 0x04003F5A RID: 16218
		private const string KEY_PREFIX = "SheriffAnomalyByMarkId";

		// Token: 0x04003F5B RID: 16219
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F5C RID: 16220
		private static int HandleId;
	}
}
