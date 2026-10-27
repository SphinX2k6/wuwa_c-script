using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090E RID: 2318
	public class ConfigSheriffAnomalyByCriminalId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003667 RID: 13927 RVA: 0x0018CDB0 File Offset: 0x0018AFB0
		static ConfigSheriffAnomalyByCriminalId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffAnomalyByCriminalId.CreateStaticDefaultValue), new Action(ConfigSheriffAnomalyByCriminalId.ResetStaticDefaultValue));
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x0018CDD0 File Offset: 0x0018AFD0
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffAnomalyByCriminalId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffAnomalyByCriminalId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffAnomaly"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffAnomaly` where CriminalId=?")
			});
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x0018CE4F File Offset: 0x0018B04F
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffAnomalyByCriminalId.LogPair = null;
			ConfigSheriffAnomalyByCriminalId.HandleId = 0;
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0018CE5D File Offset: 0x0018B05D
		public static void Init()
		{
			ConfigSheriffAnomalyByCriminalId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffAnomalyByCriminalId.HandleId, "db_sheriff.db", "select BinData from `SheriffAnomaly` where CriminalId=?");
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x0018CE78 File Offset: 0x0018B078
		public static SheriffAnomaly? GetConfig(int p0CriminalId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffAnomalyByCriminalId.HandleId, ConfigSheriffAnomalyByCriminalId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyByCriminalId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CriminalId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffAnomaly?(SheriffAnomaly.GetRootAsSheriffAnomaly(configBuffer));
				}
			}
			ConfigSheriffAnomalyByCriminalId.LogPair.Clear();
			ConfigSheriffAnomalyByCriminalId.LogPair.Add(new ValueTuple<string, object>("CriminalId", p0CriminalId));
			if (!ConfigCommon.BindInt(ConfigSheriffAnomalyByCriminalId.HandleId, 1, p0CriminalId, ConfigSheriffAnomalyByCriminalId.LogPair) || ConfigCommon.Step(ConfigSheriffAnomalyByCriminalId.HandleId, true, ConfigSheriffAnomalyByCriminalId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyByCriminalId.HandleId, ConfigSheriffAnomalyByCriminalId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffAnomalyByCriminalId.HandleId, 0, ConfigSheriffAnomalyByCriminalId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffAnomalyByCriminalId.HandleId, ConfigSheriffAnomalyByCriminalId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffAnomaly rootAsSheriffAnomaly = SheriffAnomaly.GetRootAsSheriffAnomaly(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffAnomalyByCriminalId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CriminalId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffAnomalyByCriminalId.HandleId, ConfigSheriffAnomalyByCriminalId.LogPair);
			return new SheriffAnomaly?(rootAsSheriffAnomaly);
		}

		// Token: 0x04003F48 RID: 16200
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F49 RID: 16201
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F4A RID: 16202
		private const string TABLE = "SheriffAnomaly";

		// Token: 0x04003F4B RID: 16203
		private const string COMMAND = "select BinData from `SheriffAnomaly` where CriminalId=?";

		// Token: 0x04003F4C RID: 16204
		private const string KEY_PREFIX = "SheriffAnomalyByCriminalId";

		// Token: 0x04003F4D RID: 16205
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F4E RID: 16206
		private static int HandleId;
	}
}
