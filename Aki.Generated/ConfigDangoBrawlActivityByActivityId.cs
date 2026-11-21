using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D4 RID: 468
	public class ConfigDangoBrawlActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AFB RID: 2811 RVA: 0x0009B41C File Offset: 0x0009961C
		static ConfigDangoBrawlActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigDangoBrawlActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0009B43C File Offset: 0x0009963C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlActivity` where ActivityId=?")
			});
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0009B4BB File Offset: 0x000996BB
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlActivityByActivityId.LogPair = null;
			ConfigDangoBrawlActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0009B4C9 File Offset: 0x000996C9
		public static void Init()
		{
			ConfigDangoBrawlActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlActivityByActivityId.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlActivity` where ActivityId=?");
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0009B4E4 File Offset: 0x000996E4
		public static DangoBrawlActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlActivityByActivityId.HandleId, ConfigDangoBrawlActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlActivity?(DangoBrawlActivity.GetRootAsDangoBrawlActivity(configBuffer));
				}
			}
			ConfigDangoBrawlActivityByActivityId.LogPair.Clear();
			ConfigDangoBrawlActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlActivityByActivityId.HandleId, 1, p0ActivityId, ConfigDangoBrawlActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigDangoBrawlActivityByActivityId.HandleId, true, ConfigDangoBrawlActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlActivityByActivityId.HandleId, ConfigDangoBrawlActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlActivityByActivityId.HandleId, 0, ConfigDangoBrawlActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlActivityByActivityId.HandleId, ConfigDangoBrawlActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlActivity rootAsDangoBrawlActivity = DangoBrawlActivity.GetRootAsDangoBrawlActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlActivityByActivityId.HandleId, ConfigDangoBrawlActivityByActivityId.LogPair);
			return new DangoBrawlActivity?(rootAsDangoBrawlActivity);
		}

		// Token: 0x04000CB0 RID: 3248
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CB1 RID: 3249
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CB2 RID: 3250
		private const string TABLE = "DangoBrawlActivity";

		// Token: 0x04000CB3 RID: 3251
		private const string COMMAND = "select BinData from `DangoBrawlActivity` where ActivityId=?";

		// Token: 0x04000CB4 RID: 3252
		private const string KEY_PREFIX = "DangoBrawlActivityByActivityId";

		// Token: 0x04000CB5 RID: 3253
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CB6 RID: 3254
		private static int HandleId;
	}
}
