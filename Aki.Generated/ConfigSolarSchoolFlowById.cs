using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DF RID: 2527
	public class ConfigSolarSchoolFlowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B4E RID: 15182 RVA: 0x001ABFD7 File Offset: 0x001AA1D7
		static ConfigSolarSchoolFlowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolFlowById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolFlowById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x001ABFF8 File Offset: 0x001AA1F8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolFlowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolFlowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolFlow"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolFlow` where Id=?")
			});
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x001AC077 File Offset: 0x001AA277
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolFlowById.LogPair = null;
			ConfigSolarSchoolFlowById.HandleId = 0;
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x001AC085 File Offset: 0x001AA285
		public static void Init()
		{
			ConfigSolarSchoolFlowById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolFlowById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolFlow` where Id=?");
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x001AC0A0 File Offset: 0x001AA2A0
		public static SolarSchoolFlow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolFlowById.HandleId, ConfigSolarSchoolFlowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolFlowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolFlow?(SolarSchoolFlow.GetRootAsSolarSchoolFlow(configBuffer));
				}
			}
			ConfigSolarSchoolFlowById.LogPair.Clear();
			ConfigSolarSchoolFlowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolFlowById.HandleId, 1, p0Id, ConfigSolarSchoolFlowById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolFlowById.HandleId, true, ConfigSolarSchoolFlowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolFlowById.HandleId, ConfigSolarSchoolFlowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolFlowById.HandleId, 0, ConfigSolarSchoolFlowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolFlowById.HandleId, ConfigSolarSchoolFlowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolFlow rootAsSolarSchoolFlow = SolarSchoolFlow.GetRootAsSolarSchoolFlow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolFlowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolFlowById.HandleId, ConfigSolarSchoolFlowById.LogPair);
			return new SolarSchoolFlow?(rootAsSolarSchoolFlow);
		}

		// Token: 0x040044FF RID: 17663
		private const string DB = "db_solarschool.db";

		// Token: 0x04004500 RID: 17664
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x04004501 RID: 17665
		private const string TABLE = "SolarSchoolFlow";

		// Token: 0x04004502 RID: 17666
		private const string COMMAND = "select BinData from `SolarSchoolFlow` where Id=?";

		// Token: 0x04004503 RID: 17667
		private const string KEY_PREFIX = "SolarSchoolFlowById";

		// Token: 0x04004504 RID: 17668
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004505 RID: 17669
		private static int HandleId;
	}
}
