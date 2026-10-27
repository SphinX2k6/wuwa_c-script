using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000053 RID: 83
	public class ConfigActivitySplitPakByActivityType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00064B33 File Offset: 0x00062D33
		static ConfigActivitySplitPakByActivityType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivitySplitPakByActivityType.CreateStaticDefaultValue), new Action(ConfigActivitySplitPakByActivityType.ResetStaticDefaultValue));
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00064B54 File Offset: 0x00062D54
		public static void CreateStaticDefaultValue()
		{
			ConfigActivitySplitPakByActivityType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivitySplitPakByActivityType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivitySplitPak"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivitySplitPak` where ActivityType=?")
			});
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00064BD3 File Offset: 0x00062DD3
		public static void ResetStaticDefaultValue()
		{
			ConfigActivitySplitPakByActivityType.LogPair = null;
			ConfigActivitySplitPakByActivityType.HandleId = 0;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00064BE1 File Offset: 0x00062DE1
		public static void Init()
		{
			ConfigActivitySplitPakByActivityType.HandleId = ConfigCommon.InitDataStatement(ConfigActivitySplitPakByActivityType.HandleId, "db_activity.db", "select BinData from `ActivitySplitPak` where ActivityType=?");
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00064BFC File Offset: 0x00062DFC
		public static ActivitySplitPak? GetConfig(int p0ActivityType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivitySplitPakByActivityType.HandleId, ConfigActivitySplitPakByActivityType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivitySplitPakByActivityType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivitySplitPak?(ActivitySplitPak.GetRootAsActivitySplitPak(configBuffer));
				}
			}
			ConfigActivitySplitPakByActivityType.LogPair.Clear();
			ConfigActivitySplitPakByActivityType.LogPair.Add(new ValueTuple<string, object>("ActivityType", p0ActivityType));
			if (!ConfigCommon.BindInt(ConfigActivitySplitPakByActivityType.HandleId, 1, p0ActivityType, ConfigActivitySplitPakByActivityType.LogPair) || ConfigCommon.Step(ConfigActivitySplitPakByActivityType.HandleId, true, ConfigActivitySplitPakByActivityType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivitySplitPakByActivityType.HandleId, ConfigActivitySplitPakByActivityType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivitySplitPakByActivityType.HandleId, 0, ConfigActivitySplitPakByActivityType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivitySplitPakByActivityType.HandleId, ConfigActivitySplitPakByActivityType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivitySplitPak rootAsActivitySplitPak = ActivitySplitPak.GetRootAsActivitySplitPak(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivitySplitPakByActivityType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivitySplitPakByActivityType.HandleId, ConfigActivitySplitPakByActivityType.LogPair);
			return new ActivitySplitPak?(rootAsActivitySplitPak);
		}

		// Token: 0x04000229 RID: 553
		private const string DB = "db_activity.db";

		// Token: 0x0400022A RID: 554
		private const string FILE = "h.活动.xlsx";

		// Token: 0x0400022B RID: 555
		private const string TABLE = "ActivitySplitPak";

		// Token: 0x0400022C RID: 556
		private const string COMMAND = "select BinData from `ActivitySplitPak` where ActivityType=?";

		// Token: 0x0400022D RID: 557
		private const string KEY_PREFIX = "ActivitySplitPakByActivityType";

		// Token: 0x0400022E RID: 558
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400022F RID: 559
		private static int HandleId;
	}
}
