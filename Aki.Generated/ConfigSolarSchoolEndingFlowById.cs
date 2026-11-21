using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CE RID: 2510
	public class ConfigSolarSchoolEndingFlowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AE8 RID: 15080 RVA: 0x001A9AB7 File Offset: 0x001A7CB7
		static ConfigSolarSchoolEndingFlowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEndingFlowById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEndingFlowById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x001A9AD8 File Offset: 0x001A7CD8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEndingFlowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEndingFlowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEndingFlow"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEndingFlow` where Id=?")
			});
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x001A9B57 File Offset: 0x001A7D57
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEndingFlowById.LogPair = null;
			ConfigSolarSchoolEndingFlowById.HandleId = 0;
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x001A9B65 File Offset: 0x001A7D65
		public static void Init()
		{
			ConfigSolarSchoolEndingFlowById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEndingFlowById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEndingFlow` where Id=?");
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x001A9B80 File Offset: 0x001A7D80
		public static SolarSchoolEndingFlow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEndingFlowById.HandleId, ConfigSolarSchoolEndingFlowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingFlowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolEndingFlow?(SolarSchoolEndingFlow.GetRootAsSolarSchoolEndingFlow(configBuffer));
				}
			}
			ConfigSolarSchoolEndingFlowById.LogPair.Clear();
			ConfigSolarSchoolEndingFlowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEndingFlowById.HandleId, 1, p0Id, ConfigSolarSchoolEndingFlowById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolEndingFlowById.HandleId, true, ConfigSolarSchoolEndingFlowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingFlowById.HandleId, ConfigSolarSchoolEndingFlowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEndingFlowById.HandleId, 0, ConfigSolarSchoolEndingFlowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingFlowById.HandleId, ConfigSolarSchoolEndingFlowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolEndingFlow rootAsSolarSchoolEndingFlow = SolarSchoolEndingFlow.GetRootAsSolarSchoolEndingFlow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingFlowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEndingFlowById.HandleId, ConfigSolarSchoolEndingFlowById.LogPair);
			return new SolarSchoolEndingFlow?(rootAsSolarSchoolEndingFlow);
		}

		// Token: 0x04004488 RID: 17544
		private const string DB = "db_solarschool.db";

		// Token: 0x04004489 RID: 17545
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x0400448A RID: 17546
		private const string TABLE = "SolarSchoolEndingFlow";

		// Token: 0x0400448B RID: 17547
		private const string COMMAND = "select BinData from `SolarSchoolEndingFlow` where Id=?";

		// Token: 0x0400448C RID: 17548
		private const string KEY_PREFIX = "SolarSchoolEndingFlowById";

		// Token: 0x0400448D RID: 17549
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400448E RID: 17550
		private static int HandleId;
	}
}
