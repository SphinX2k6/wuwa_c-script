using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B9 RID: 2489
	public class ConfigSolarSchoolBehaviorByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A6A RID: 14954 RVA: 0x001A6EE3 File Offset: 0x001A50E3
		static ConfigSolarSchoolBehaviorByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBehaviorByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBehaviorByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x001A6F04 File Offset: 0x001A5104
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBehaviorByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBehavior"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBehavior` where ActivityId=?")
			});
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x001A6F83 File Offset: 0x001A5183
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorByActivityId.LogPair = null;
			ConfigSolarSchoolBehaviorByActivityId.HandleId = 0;
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x001A6F91 File Offset: 0x001A5191
		public static void Init()
		{
			ConfigSolarSchoolBehaviorByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBehaviorByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBehavior` where ActivityId=?");
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x001A6FAC File Offset: 0x001A51AC
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolBehavior> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBehaviorByActivityId.HandleId, ConfigSolarSchoolBehaviorByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolBehavior> readOnlyList = (IReadOnlyList<SolarSchoolBehavior>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolBehaviorByActivityId.LogPair.Clear();
			ConfigSolarSchoolBehaviorByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolBehaviorByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolBehaviorByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolBehaviorByActivityId.HandleId, ConfigSolarSchoolBehaviorByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolBehavior> list = new List<SolarSchoolBehavior>();
			while (ConfigCommon.Step(ConfigSolarSchoolBehaviorByActivityId.HandleId, false, ConfigSolarSchoolBehaviorByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBehaviorByActivityId.HandleId, 0, ConfigSolarSchoolBehaviorByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolBehaviorByActivityId.HandleId, ConfigSolarSchoolBehaviorByActivityId.LogPair);
					return null;
				}
				SolarSchoolBehavior rootAsSolarSchoolBehavior = SolarSchoolBehavior.GetRootAsSolarSchoolBehavior(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolBehavior);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBehaviorByActivityId.HandleId, ConfigSolarSchoolBehaviorByActivityId.LogPair);
			return list;
		}

		// Token: 0x040043F5 RID: 17397
		private const string DB = "db_solarschool.db";

		// Token: 0x040043F6 RID: 17398
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040043F7 RID: 17399
		private const string TABLE = "SolarSchoolBehavior";

		// Token: 0x040043F8 RID: 17400
		private const string COMMAND = "select BinData from `SolarSchoolBehavior` where ActivityId=?";

		// Token: 0x040043F9 RID: 17401
		private const string KEY_PREFIX = "SolarSchoolBehaviorByActivityId";

		// Token: 0x040043FA RID: 17402
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043FB RID: 17403
		private static int HandleId;
	}
}
