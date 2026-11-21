using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095B RID: 2395
	public class ConfigSheriffAnomalyByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003835 RID: 14389 RVA: 0x0019A460 File Offset: 0x00198660
		static ConfigSheriffAnomalyByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffAnomalyByMarkId.CreateStaticDefaultValue), new Action(ConfigSheriffAnomalyByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x0019A480 File Offset: 0x00198680
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

		// Token: 0x06003837 RID: 14391 RVA: 0x0019A4FF File Offset: 0x001986FF
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffAnomalyByMarkId.LogPair = null;
			ConfigSheriffAnomalyByMarkId.HandleId = 0;
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x0019A50D File Offset: 0x0019870D
		public static void Init()
		{
			ConfigSheriffAnomalyByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffAnomalyByMarkId.HandleId, "db_sheriff.db", "select BinData from `SheriffAnomaly` where MarkId=?");
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x0019A528 File Offset: 0x00198728
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

		// Token: 0x04004163 RID: 16739
		private const string DB = "db_sheriff.db";

		// Token: 0x04004164 RID: 16740
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04004165 RID: 16741
		private const string TABLE = "SheriffAnomaly";

		// Token: 0x04004166 RID: 16742
		private const string COMMAND = "select BinData from `SheriffAnomaly` where MarkId=?";

		// Token: 0x04004167 RID: 16743
		private const string KEY_PREFIX = "SheriffAnomalyByMarkId";

		// Token: 0x04004168 RID: 16744
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004169 RID: 16745
		private static int HandleId;
	}
}
