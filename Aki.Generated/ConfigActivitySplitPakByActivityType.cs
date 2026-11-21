using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005B RID: 91
	public class ConfigActivitySplitPakByActivityType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000222 RID: 546 RVA: 0x000693E7 File Offset: 0x000675E7
		static ConfigActivitySplitPakByActivityType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivitySplitPakByActivityType.CreateStaticDefaultValue), new Action(ConfigActivitySplitPakByActivityType.ResetStaticDefaultValue));
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00069408 File Offset: 0x00067608
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

		// Token: 0x06000224 RID: 548 RVA: 0x00069487 File Offset: 0x00067687
		public static void ResetStaticDefaultValue()
		{
			ConfigActivitySplitPakByActivityType.LogPair = null;
			ConfigActivitySplitPakByActivityType.HandleId = 0;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00069495 File Offset: 0x00067695
		public static void Init()
		{
			ConfigActivitySplitPakByActivityType.HandleId = ConfigCommon.InitDataStatement(ConfigActivitySplitPakByActivityType.HandleId, "db_activity.db", "select BinData from `ActivitySplitPak` where ActivityType=?");
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000694B0 File Offset: 0x000676B0
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

		// Token: 0x04000261 RID: 609
		private const string DB = "db_activity.db";

		// Token: 0x04000262 RID: 610
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000263 RID: 611
		private const string TABLE = "ActivitySplitPak";

		// Token: 0x04000264 RID: 612
		private const string COMMAND = "select BinData from `ActivitySplitPak` where ActivityType=?";

		// Token: 0x04000265 RID: 613
		private const string KEY_PREFIX = "ActivitySplitPakByActivityType";

		// Token: 0x04000266 RID: 614
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000267 RID: 615
		private static int HandleId;
	}
}
