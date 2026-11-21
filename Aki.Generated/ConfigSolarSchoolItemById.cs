using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009ED RID: 2541
	public class ConfigSolarSchoolItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BA2 RID: 15266 RVA: 0x001ADDCF File Offset: 0x001ABFCF
		static ConfigSolarSchoolItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolItemById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x001ADDF0 File Offset: 0x001ABFF0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolItem` where Id=?")
			});
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x001ADE6F File Offset: 0x001AC06F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolItemById.LogPair = null;
			ConfigSolarSchoolItemById.HandleId = 0;
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x001ADE7D File Offset: 0x001AC07D
		public static void Init()
		{
			ConfigSolarSchoolItemById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolItemById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolItem` where Id=?");
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x001ADE98 File Offset: 0x001AC098
		public static SolarSchoolItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolItemById.HandleId, ConfigSolarSchoolItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolItem?(SolarSchoolItem.GetRootAsSolarSchoolItem(configBuffer));
				}
			}
			ConfigSolarSchoolItemById.LogPair.Clear();
			ConfigSolarSchoolItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolItemById.HandleId, 1, p0Id, ConfigSolarSchoolItemById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolItemById.HandleId, true, ConfigSolarSchoolItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolItemById.HandleId, ConfigSolarSchoolItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolItemById.HandleId, 0, ConfigSolarSchoolItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolItemById.HandleId, ConfigSolarSchoolItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolItem rootAsSolarSchoolItem = SolarSchoolItem.GetRootAsSolarSchoolItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolItemById.HandleId, ConfigSolarSchoolItemById.LogPair);
			return new SolarSchoolItem?(rootAsSolarSchoolItem);
		}

		// Token: 0x04004561 RID: 17761
		private const string DB = "db_solarschool.db";

		// Token: 0x04004562 RID: 17762
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x04004563 RID: 17763
		private const string TABLE = "SolarSchoolItem";

		// Token: 0x04004564 RID: 17764
		private const string COMMAND = "select BinData from `SolarSchoolItem` where Id=?";

		// Token: 0x04004565 RID: 17765
		private const string KEY_PREFIX = "SolarSchoolItemById";

		// Token: 0x04004566 RID: 17766
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004567 RID: 17767
		private static int HandleId;
	}
}
