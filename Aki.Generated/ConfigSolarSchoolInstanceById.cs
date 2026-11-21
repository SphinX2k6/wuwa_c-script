using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EA RID: 2538
	public class ConfigSolarSchoolInstanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B90 RID: 15248 RVA: 0x001AD7BB File Offset: 0x001AB9BB
		static ConfigSolarSchoolInstanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolInstanceById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolInstanceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x001AD7DC File Offset: 0x001AB9DC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolInstanceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolInstanceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolInstance` where Id=?")
			});
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x001AD85B File Offset: 0x001ABA5B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolInstanceById.LogPair = null;
			ConfigSolarSchoolInstanceById.HandleId = 0;
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x001AD869 File Offset: 0x001ABA69
		public static void Init()
		{
			ConfigSolarSchoolInstanceById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolInstanceById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolInstance` where Id=?");
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x001AD884 File Offset: 0x001ABA84
		public static SolarSchoolInstance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolInstanceById.HandleId, ConfigSolarSchoolInstanceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolInstanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolInstance?(SolarSchoolInstance.GetRootAsSolarSchoolInstance(configBuffer));
				}
			}
			ConfigSolarSchoolInstanceById.LogPair.Clear();
			ConfigSolarSchoolInstanceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolInstanceById.HandleId, 1, p0Id, ConfigSolarSchoolInstanceById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolInstanceById.HandleId, true, ConfigSolarSchoolInstanceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolInstanceById.HandleId, ConfigSolarSchoolInstanceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolInstanceById.HandleId, 0, ConfigSolarSchoolInstanceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolInstanceById.HandleId, ConfigSolarSchoolInstanceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolInstance rootAsSolarSchoolInstance = SolarSchoolInstance.GetRootAsSolarSchoolInstance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolInstanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolInstanceById.HandleId, ConfigSolarSchoolInstanceById.LogPair);
			return new SolarSchoolInstance?(rootAsSolarSchoolInstance);
		}

		// Token: 0x0400454C RID: 17740
		private const string DB = "db_solarschool.db";

		// Token: 0x0400454D RID: 17741
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x0400454E RID: 17742
		private const string TABLE = "SolarSchoolInstance";

		// Token: 0x0400454F RID: 17743
		private const string COMMAND = "select BinData from `SolarSchoolInstance` where Id=?";

		// Token: 0x04004550 RID: 17744
		private const string KEY_PREFIX = "SolarSchoolInstanceById";

		// Token: 0x04004551 RID: 17745
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004552 RID: 17746
		private static int HandleId;
	}
}
