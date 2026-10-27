using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200000E RID: 14
	public class ConfigAbyssActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0005BE17 File Offset: 0x0005A017
		static ConfigAbyssActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigAbyssActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0005BE38 File Offset: 0x0005A038
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssActivity` where ActivityId=?")
			});
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0005BEB7 File Offset: 0x0005A0B7
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssActivityByActivityId.LogPair = null;
			ConfigAbyssActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0005BEC5 File Offset: 0x0005A0C5
		public static void Init()
		{
			ConfigAbyssActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssActivityByActivityId.HandleId, "db_dangoabyss.db", "select BinData from `AbyssActivity` where ActivityId=?");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0005BEE0 File Offset: 0x0005A0E0
		public static AbyssActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssActivityByActivityId.HandleId, ConfigAbyssActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssActivity?(AbyssActivity.GetRootAsAbyssActivity(configBuffer));
				}
			}
			ConfigAbyssActivityByActivityId.LogPair.Clear();
			ConfigAbyssActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigAbyssActivityByActivityId.HandleId, 1, p0ActivityId, ConfigAbyssActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigAbyssActivityByActivityId.HandleId, true, ConfigAbyssActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssActivityByActivityId.HandleId, ConfigAbyssActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssActivityByActivityId.HandleId, 0, ConfigAbyssActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssActivityByActivityId.HandleId, ConfigAbyssActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssActivity rootAsAbyssActivity = AbyssActivity.GetRootAsAbyssActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssActivityByActivityId.HandleId, ConfigAbyssActivityByActivityId.LogPair);
			return new AbyssActivity?(rootAsAbyssActivity);
		}

		// Token: 0x04000046 RID: 70
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000047 RID: 71
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x04000048 RID: 72
		private const string TABLE = "AbyssActivity";

		// Token: 0x04000049 RID: 73
		private const string COMMAND = "select BinData from `AbyssActivity` where ActivityId=?";

		// Token: 0x0400004A RID: 74
		private const string KEY_PREFIX = "AbyssActivityByActivityId";

		// Token: 0x0400004B RID: 75
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400004C RID: 76
		private static int HandleId;
	}
}
