using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007F RID: 127
	public class ConfigAiAlertById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0006A434 File Offset: 0x00068634
		static ConfigAiAlertById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiAlertById.CreateStaticDefaultValue), new Action(ConfigAiAlertById.ResetStaticDefaultValue));
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0006A454 File Offset: 0x00068654
		public static void CreateStaticDefaultValue()
		{
			ConfigAiAlertById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiAlertById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI警戒.xlsx"),
				new ValueTuple<string, object>("表名", "AiAlert"),
				new ValueTuple<string, object>("语句", "select BinData from `AiAlert` where Id=?")
			});
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0006A4D3 File Offset: 0x000686D3
		public static void ResetStaticDefaultValue()
		{
			ConfigAiAlertById.LogPair = null;
			ConfigAiAlertById.HandleId = 0;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0006A4E1 File Offset: 0x000686E1
		public static void Init()
		{
			ConfigAiAlertById.HandleId = ConfigCommon.InitDataStatement(ConfigAiAlertById.HandleId, "db_ai.db", "select BinData from `AiAlert` where Id=?");
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0006A4FC File Offset: 0x000686FC
		public static AiAlert? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiAlertById.HandleId, ConfigAiAlertById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiAlertById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiAlert?(AiAlert.GetRootAsAiAlert(configBuffer));
				}
			}
			ConfigAiAlertById.LogPair.Clear();
			ConfigAiAlertById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiAlertById.HandleId, 1, p0Id, ConfigAiAlertById.LogPair) || ConfigCommon.Step(ConfigAiAlertById.HandleId, true, ConfigAiAlertById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiAlertById.HandleId, ConfigAiAlertById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiAlertById.HandleId, 0, ConfigAiAlertById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiAlertById.HandleId, ConfigAiAlertById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiAlert rootAsAiAlert = AiAlert.GetRootAsAiAlert(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiAlertById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiAlertById.HandleId, ConfigAiAlertById.LogPair);
			return new AiAlert?(rootAsAiAlert);
		}

		// Token: 0x0400035D RID: 861
		private const string DB = "db_ai.db";

		// Token: 0x0400035E RID: 862
		private const string FILE = "a.AI警戒.xlsx";

		// Token: 0x0400035F RID: 863
		private const string TABLE = "AiAlert";

		// Token: 0x04000360 RID: 864
		private const string COMMAND = "select BinData from `AiAlert` where Id=?";

		// Token: 0x04000361 RID: 865
		private const string KEY_PREFIX = "AiAlertById";

		// Token: 0x04000362 RID: 866
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000363 RID: 867
		private static int HandleId;
	}
}
