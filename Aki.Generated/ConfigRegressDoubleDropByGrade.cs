using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CE RID: 1998
	public class ConfigRegressDoubleDropByGrade : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EE6 RID: 12006 RVA: 0x0016258F File Offset: 0x0016078F
		static ConfigRegressDoubleDropByGrade()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressDoubleDropByGrade.CreateStaticDefaultValue), new Action(ConfigRegressDoubleDropByGrade.ResetStaticDefaultValue));
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x001625B0 File Offset: 0x001607B0
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

		// Token: 0x06002EE8 RID: 12008 RVA: 0x0016262F File Offset: 0x0016082F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressDoubleDropByGrade.LogPair = null;
			ConfigRegressDoubleDropByGrade.HandleId = 0;
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x0016263D File Offset: 0x0016083D
		public static void Init()
		{
			ConfigRegressDoubleDropByGrade.HandleId = ConfigCommon.InitDataStatement(ConfigRegressDoubleDropByGrade.HandleId, "db_regressactivity.db", "select BinData from `RegressDoubleDrop` where Grade=?");
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00162658 File Offset: 0x00160858
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

		// Token: 0x04003688 RID: 13960
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003689 RID: 13961
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400368A RID: 13962
		private const string TABLE = "RegressDoubleDrop";

		// Token: 0x0400368B RID: 13963
		private const string COMMAND = "select BinData from `RegressDoubleDrop` where Grade=?";

		// Token: 0x0400368C RID: 13964
		private const string KEY_PREFIX = "RegressDoubleDropByGrade";

		// Token: 0x0400368D RID: 13965
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400368E RID: 13966
		private static int HandleId;
	}
}
