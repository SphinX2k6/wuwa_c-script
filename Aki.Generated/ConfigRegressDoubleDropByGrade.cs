using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EA RID: 2026
	public class ConfigRegressDoubleDropByGrade : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F8E RID: 12174 RVA: 0x00169877 File Offset: 0x00167A77
		static ConfigRegressDoubleDropByGrade()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressDoubleDropByGrade.CreateStaticDefaultValue), new Action(ConfigRegressDoubleDropByGrade.ResetStaticDefaultValue));
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00169898 File Offset: 0x00167A98
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressDoubleDropByGrade.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressDoubleDropByGrade.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressDoubleDrop"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressDoubleDrop` where Grade=?")
			});
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00169917 File Offset: 0x00167B17
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressDoubleDropByGrade.LogPair = null;
			ConfigRegressDoubleDropByGrade.HandleId = 0;
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00169925 File Offset: 0x00167B25
		public static void Init()
		{
			ConfigRegressDoubleDropByGrade.HandleId = ConfigCommon.InitDataStatement(ConfigRegressDoubleDropByGrade.HandleId, "db_regressactivity.db", "select BinData from `RegressDoubleDrop` where Grade=?");
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00169940 File Offset: 0x00167B40
		public static RegressDoubleDrop? GetConfig(int p0Grade, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressDoubleDropByGrade.HandleId, ConfigRegressDoubleDropByGrade.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressDoubleDropByGrade");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Grade);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressDoubleDrop?(RegressDoubleDrop.GetRootAsRegressDoubleDrop(configBuffer));
				}
			}
			ConfigRegressDoubleDropByGrade.LogPair.Clear();
			ConfigRegressDoubleDropByGrade.LogPair.Add(new ValueTuple<string, object>("Grade", p0Grade));
			if (!ConfigCommon.BindInt(ConfigRegressDoubleDropByGrade.HandleId, 1, p0Grade, ConfigRegressDoubleDropByGrade.LogPair) || ConfigCommon.Step(ConfigRegressDoubleDropByGrade.HandleId, true, ConfigRegressDoubleDropByGrade.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressDoubleDropByGrade.HandleId, ConfigRegressDoubleDropByGrade.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressDoubleDropByGrade.HandleId, 0, ConfigRegressDoubleDropByGrade.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressDoubleDropByGrade.HandleId, ConfigRegressDoubleDropByGrade.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressDoubleDrop rootAsRegressDoubleDrop = RegressDoubleDrop.GetRootAsRegressDoubleDrop(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressDoubleDropByGrade");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Grade);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressDoubleDropByGrade.HandleId, ConfigRegressDoubleDropByGrade.LogPair);
			return new RegressDoubleDrop?(rootAsRegressDoubleDrop);
		}

		// Token: 0x0400374C RID: 14156
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400374D RID: 14157
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400374E RID: 14158
		private const string TABLE = "RegressDoubleDrop";

		// Token: 0x0400374F RID: 14159
		private const string COMMAND = "select BinData from `RegressDoubleDrop` where Grade=?";

		// Token: 0x04003750 RID: 14160
		private const string KEY_PREFIX = "RegressDoubleDropByGrade";

		// Token: 0x04003751 RID: 14161
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003752 RID: 14162
		private static int HandleId;
	}
}
