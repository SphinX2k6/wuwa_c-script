using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1D RID: 2589
	public class ConfigTrapDefenseBaseConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CC2 RID: 15554 RVA: 0x001B15CC File Offset: 0x001AF7CC
		static ConfigTrapDefenseBaseConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBaseConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBaseConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x001B15EC File Offset: 0x001AF7EC
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBaseConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBaseConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBaseConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBaseConfig` where ActivityId=?")
			});
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x001B166B File Offset: 0x001AF86B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBaseConfigByActivityId.LogPair = null;
			ConfigTrapDefenseBaseConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x001B1679 File Offset: 0x001AF879
		public static void Init()
		{
			ConfigTrapDefenseBaseConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBaseConfigByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBaseConfig` where ActivityId=?");
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x001B1694 File Offset: 0x001AF894
		public static TrapDefenseBaseConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBaseConfigByActivityId.HandleId, ConfigTrapDefenseBaseConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBaseConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBaseConfig?(TrapDefenseBaseConfig.GetRootAsTrapDefenseBaseConfig(configBuffer));
				}
			}
			ConfigTrapDefenseBaseConfigByActivityId.LogPair.Clear();
			ConfigTrapDefenseBaseConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBaseConfigByActivityId.HandleId, 1, p0ActivityId, ConfigTrapDefenseBaseConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBaseConfigByActivityId.HandleId, true, ConfigTrapDefenseBaseConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBaseConfigByActivityId.HandleId, ConfigTrapDefenseBaseConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBaseConfigByActivityId.HandleId, 0, ConfigTrapDefenseBaseConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBaseConfigByActivityId.HandleId, ConfigTrapDefenseBaseConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBaseConfig rootAsTrapDefenseBaseConfig = TrapDefenseBaseConfig.GetRootAsTrapDefenseBaseConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBaseConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBaseConfigByActivityId.HandleId, ConfigTrapDefenseBaseConfigByActivityId.LogPair);
			return new TrapDefenseBaseConfig?(rootAsTrapDefenseBaseConfig);
		}

		// Token: 0x040046B1 RID: 18097
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046B2 RID: 18098
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x040046B3 RID: 18099
		private const string TABLE = "TrapDefenseBaseConfig";

		// Token: 0x040046B4 RID: 18100
		private const string COMMAND = "select BinData from `TrapDefenseBaseConfig` where ActivityId=?";

		// Token: 0x040046B5 RID: 18101
		private const string KEY_PREFIX = "TrapDefenseBaseConfigByActivityId";

		// Token: 0x040046B6 RID: 18102
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046B7 RID: 18103
		private static int HandleId;
	}
}
