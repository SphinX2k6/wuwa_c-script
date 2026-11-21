using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E9 RID: 2537
	public class ConfigSolarSchoolInstanceByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B8A RID: 15242 RVA: 0x001AD583 File Offset: 0x001AB783
		static ConfigSolarSchoolInstanceByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolInstanceByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolInstanceByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x001AD5A4 File Offset: 0x001AB7A4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolInstanceByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolInstanceByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_地点.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolInstance` where ActivityId=?")
			});
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x001AD623 File Offset: 0x001AB823
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolInstanceByActivityId.LogPair = null;
			ConfigSolarSchoolInstanceByActivityId.HandleId = 0;
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x001AD631 File Offset: 0x001AB831
		public static void Init()
		{
			ConfigSolarSchoolInstanceByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolInstanceByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolInstance` where ActivityId=?");
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x001AD64C File Offset: 0x001AB84C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolInstance> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolInstanceByActivityId.HandleId, ConfigSolarSchoolInstanceByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolInstanceByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolInstance> readOnlyList = (IReadOnlyList<SolarSchoolInstance>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolInstanceByActivityId.LogPair.Clear();
			ConfigSolarSchoolInstanceByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolInstanceByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolInstanceByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolInstanceByActivityId.HandleId, ConfigSolarSchoolInstanceByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolInstance> list = new List<SolarSchoolInstance>();
			while (ConfigCommon.Step(ConfigSolarSchoolInstanceByActivityId.HandleId, false, ConfigSolarSchoolInstanceByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolInstanceByActivityId.HandleId, 0, ConfigSolarSchoolInstanceByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolInstanceByActivityId.HandleId, ConfigSolarSchoolInstanceByActivityId.LogPair);
					return null;
				}
				SolarSchoolInstance rootAsSolarSchoolInstance = SolarSchoolInstance.GetRootAsSolarSchoolInstance(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolInstance);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolInstanceByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolInstanceByActivityId.HandleId, ConfigSolarSchoolInstanceByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004545 RID: 17733
		private const string DB = "db_solarschool.db";

		// Token: 0x04004546 RID: 17734
		private const string FILE = "d.第二索拉_地点.xlsx";

		// Token: 0x04004547 RID: 17735
		private const string TABLE = "SolarSchoolInstance";

		// Token: 0x04004548 RID: 17736
		private const string COMMAND = "select BinData from `SolarSchoolInstance` where ActivityId=?";

		// Token: 0x04004549 RID: 17737
		private const string KEY_PREFIX = "SolarSchoolInstanceByActivityId";

		// Token: 0x0400454A RID: 17738
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400454B RID: 17739
		private static int HandleId;
	}
}
