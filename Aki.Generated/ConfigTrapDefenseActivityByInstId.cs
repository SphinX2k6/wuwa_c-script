using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AED RID: 2797
	public class ConfigTrapDefenseActivityByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041A2 RID: 16802 RVA: 0x001CFEAB File Offset: 0x001CE0AB
		static ConfigTrapDefenseActivityByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseActivityByInstId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseActivityByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x001CFECC File Offset: 0x001CE0CC
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

		// Token: 0x060041A4 RID: 16804 RVA: 0x001CFF4B File Offset: 0x001CE14B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseActivityByInstId.LogPair = null;
			ConfigTrapDefenseActivityByInstId.HandleId = 0;
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x001CFF59 File Offset: 0x001CE159
		public static void Init()
		{
			ConfigTrapDefenseActivityByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseActivityByInstId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseActivity` where InstId=?");
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x001CFF74 File Offset: 0x001CE174
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

		// Token: 0x04004C61 RID: 19553
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C62 RID: 19554
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004C63 RID: 19555
		private const string TABLE = "TrapDefenseActivity";

		// Token: 0x04004C64 RID: 19556
		private const string COMMAND = "select BinData from `TrapDefenseActivity` where InstId=?";

		// Token: 0x04004C65 RID: 19557
		private const string KEY_PREFIX = "TrapDefenseActivityByInstId";

		// Token: 0x04004C66 RID: 19558
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C67 RID: 19559
		private static int HandleId;
	}
}
