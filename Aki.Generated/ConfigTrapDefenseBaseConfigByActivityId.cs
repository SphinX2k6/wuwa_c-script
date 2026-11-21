using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF2 RID: 2802
	public class ConfigTrapDefenseBaseConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041C0 RID: 16832 RVA: 0x001D0960 File Offset: 0x001CEB60
		static ConfigTrapDefenseBaseConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBaseConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBaseConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x001D0980 File Offset: 0x001CEB80
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

		// Token: 0x060041C2 RID: 16834 RVA: 0x001D09FF File Offset: 0x001CEBFF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBaseConfigByActivityId.LogPair = null;
			ConfigTrapDefenseBaseConfigByActivityId.HandleId = 0;
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x001D0A0D File Offset: 0x001CEC0D
		public static void Init()
		{
			ConfigTrapDefenseBaseConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBaseConfigByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBaseConfig` where ActivityId=?");
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x001D0A28 File Offset: 0x001CEC28
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

		// Token: 0x04004C84 RID: 19588
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C85 RID: 19589
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004C86 RID: 19590
		private const string TABLE = "TrapDefenseBaseConfig";

		// Token: 0x04004C87 RID: 19591
		private const string COMMAND = "select BinData from `TrapDefenseBaseConfig` where ActivityId=?";

		// Token: 0x04004C88 RID: 19592
		private const string KEY_PREFIX = "TrapDefenseBaseConfigByActivityId";

		// Token: 0x04004C89 RID: 19593
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C8A RID: 19594
		private static int HandleId;
	}
}
