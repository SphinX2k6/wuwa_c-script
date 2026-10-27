using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A18 RID: 2584
	public class ConfigTrapDefenseActivityByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CA4 RID: 15524 RVA: 0x001B0B17 File Offset: 0x001AED17
		static ConfigTrapDefenseActivityByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseActivityByInstId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseActivityByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x001B0B38 File Offset: 0x001AED38
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseActivityByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseActivityByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseActivity` where InstId=?")
			});
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x001B0BB7 File Offset: 0x001AEDB7
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseActivityByInstId.LogPair = null;
			ConfigTrapDefenseActivityByInstId.HandleId = 0;
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x001B0BC5 File Offset: 0x001AEDC5
		public static void Init()
		{
			ConfigTrapDefenseActivityByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseActivityByInstId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseActivity` where InstId=?");
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x001B0BE0 File Offset: 0x001AEDE0
		public static TrapDefenseActivity? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseActivityByInstId.HandleId, ConfigTrapDefenseActivityByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseActivityByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseActivity?(TrapDefenseActivity.GetRootAsTrapDefenseActivity(configBuffer));
				}
			}
			ConfigTrapDefenseActivityByInstId.LogPair.Clear();
			ConfigTrapDefenseActivityByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseActivityByInstId.HandleId, 1, p0InstId, ConfigTrapDefenseActivityByInstId.LogPair) || ConfigCommon.Step(ConfigTrapDefenseActivityByInstId.HandleId, true, ConfigTrapDefenseActivityByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseActivityByInstId.HandleId, ConfigTrapDefenseActivityByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseActivityByInstId.HandleId, 0, ConfigTrapDefenseActivityByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseActivityByInstId.HandleId, ConfigTrapDefenseActivityByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseActivity rootAsTrapDefenseActivity = TrapDefenseActivity.GetRootAsTrapDefenseActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseActivityByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseActivityByInstId.HandleId, ConfigTrapDefenseActivityByInstId.LogPair);
			return new TrapDefenseActivity?(rootAsTrapDefenseActivity);
		}

		// Token: 0x0400468E RID: 18062
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400468F RID: 18063
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004690 RID: 18064
		private const string TABLE = "TrapDefenseActivity";

		// Token: 0x04004691 RID: 18065
		private const string COMMAND = "select BinData from `TrapDefenseActivity` where InstId=?";

		// Token: 0x04004692 RID: 18066
		private const string KEY_PREFIX = "TrapDefenseActivityByInstId";

		// Token: 0x04004693 RID: 18067
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004694 RID: 18068
		private static int HandleId;
	}
}
