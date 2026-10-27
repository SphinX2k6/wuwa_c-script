using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200090F RID: 2319
	public class ConfigSheriffAnomalyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600366D RID: 13933 RVA: 0x0018CFF8 File Offset: 0x0018B1F8
		static ConfigSheriffAnomalyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffAnomalyById.CreateStaticDefaultValue), new Action(ConfigSheriffAnomalyById.ResetStaticDefaultValue));
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x0018D018 File Offset: 0x0018B218
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

		// Token: 0x0600366F RID: 13935 RVA: 0x0018D097 File Offset: 0x0018B297
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffAnomalyById.LogPair = null;
			ConfigSheriffAnomalyById.HandleId = 0;
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x0018D0A5 File Offset: 0x0018B2A5
		public static void Init()
		{
			ConfigSheriffAnomalyById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffAnomalyById.HandleId, "db_sheriff.db", "select BinData from `SheriffAnomaly` where Id=?");
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0018D0C0 File Offset: 0x0018B2C0
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

		// Token: 0x04003F4F RID: 16207
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F50 RID: 16208
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F51 RID: 16209
		private const string TABLE = "SheriffAnomaly";

		// Token: 0x04003F52 RID: 16210
		private const string COMMAND = "select BinData from `SheriffAnomaly` where Id=?";

		// Token: 0x04003F53 RID: 16211
		private const string KEY_PREFIX = "SheriffAnomalyById";

		// Token: 0x04003F54 RID: 16212
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F55 RID: 16213
		private static int HandleId;
	}
}
