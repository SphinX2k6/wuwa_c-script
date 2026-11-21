using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095A RID: 2394
	public class ConfigSheriffAnomalyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600382F RID: 14383 RVA: 0x0019A218 File Offset: 0x00198418
		static ConfigSheriffAnomalyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffAnomalyById.CreateStaticDefaultValue), new Action(ConfigSheriffAnomalyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x0019A238 File Offset: 0x00198438
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffAnomalyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffAnomalyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffAnomaly"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffAnomaly` where Id=?")
			});
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x0019A2B7 File Offset: 0x001984B7
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffAnomalyById.LogPair = null;
			ConfigSheriffAnomalyById.HandleId = 0;
		}

		// Token: 0x06003832 RID: 14386 RVA: 0x0019A2C5 File Offset: 0x001984C5
		public static void Init()
		{
			ConfigSheriffAnomalyById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffAnomalyById.HandleId, "db_sheriff.db", "select BinData from `SheriffAnomaly` where Id=?");
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x0019A2E0 File Offset: 0x001984E0
		public static SheriffAnomaly? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffAnomalyById.HandleId, ConfigSheriffAnomalyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffAnomaly?(SheriffAnomaly.GetRootAsSheriffAnomaly(configBuffer));
				}
			}
			ConfigSheriffAnomalyById.LogPair.Clear();
			ConfigSheriffAnomalyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffAnomalyById.HandleId, 1, p0Id, ConfigSheriffAnomalyById.LogPair) || ConfigCommon.Step(ConfigSheriffAnomalyById.HandleId, true, ConfigSheriffAnomalyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyById.HandleId, ConfigSheriffAnomalyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffAnomalyById.HandleId, 0, ConfigSheriffAnomalyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyById.HandleId, ConfigSheriffAnomalyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffAnomaly rootAsSheriffAnomaly = SheriffAnomaly.GetRootAsSheriffAnomaly(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffAnomalyById.HandleId, ConfigSheriffAnomalyById.LogPair);
			return new SheriffAnomaly?(rootAsSheriffAnomaly);
		}

		// Token: 0x0400415C RID: 16732
		private const string DB = "db_sheriff.db";

		// Token: 0x0400415D RID: 16733
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x0400415E RID: 16734
		private const string TABLE = "SheriffAnomaly";

		// Token: 0x0400415F RID: 16735
		private const string COMMAND = "select BinData from `SheriffAnomaly` where Id=?";

		// Token: 0x04004160 RID: 16736
		private const string KEY_PREFIX = "SheriffAnomalyById";

		// Token: 0x04004161 RID: 16737
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004162 RID: 16738
		private static int HandleId;
	}
}
