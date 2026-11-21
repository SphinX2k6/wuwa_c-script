using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BA RID: 2490
	public class ConfigSolarSchoolBehaviorByBehaviorId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A70 RID: 14960 RVA: 0x001A711B File Offset: 0x001A531B
		static ConfigSolarSchoolBehaviorByBehaviorId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolBehaviorByBehaviorId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolBehaviorByBehaviorId.ResetStaticDefaultValue));
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x001A713C File Offset: 0x001A533C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorByBehaviorId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolBehaviorByBehaviorId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolBehavior"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolBehavior` where BehaviorId=?")
			});
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x001A71BB File Offset: 0x001A53BB
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolBehaviorByBehaviorId.LogPair = null;
			ConfigSolarSchoolBehaviorByBehaviorId.HandleId = 0;
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x001A71C9 File Offset: 0x001A53C9
		public static void Init()
		{
			ConfigSolarSchoolBehaviorByBehaviorId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolBehaviorByBehaviorId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolBehavior` where BehaviorId=?");
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x001A71E4 File Offset: 0x001A53E4
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolBehavior> GetConfigList(int p0BehaviorId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolBehaviorByBehaviorId.HandleId, ConfigSolarSchoolBehaviorByBehaviorId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorByBehaviorId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BehaviorId);
				IReadOnlyList<SolarSchoolBehavior> readOnlyList = (IReadOnlyList<SolarSchoolBehavior>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolBehaviorByBehaviorId.LogPair.Clear();
			ConfigSolarSchoolBehaviorByBehaviorId.LogPair.Add(new ValueTuple<string, object>("BehaviorId", p0BehaviorId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolBehaviorByBehaviorId.HandleId, 1, p0BehaviorId, ConfigSolarSchoolBehaviorByBehaviorId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolBehaviorByBehaviorId.HandleId, ConfigSolarSchoolBehaviorByBehaviorId.LogPair);
				return null;
			}
			List<SolarSchoolBehavior> list = new List<SolarSchoolBehavior>();
			while (ConfigCommon.Step(ConfigSolarSchoolBehaviorByBehaviorId.HandleId, false, ConfigSolarSchoolBehaviorByBehaviorId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolBehaviorByBehaviorId.HandleId, 0, ConfigSolarSchoolBehaviorByBehaviorId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolBehaviorByBehaviorId.HandleId, ConfigSolarSchoolBehaviorByBehaviorId.LogPair);
					return null;
				}
				SolarSchoolBehavior rootAsSolarSchoolBehavior = SolarSchoolBehavior.GetRootAsSolarSchoolBehavior(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolBehavior);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolBehaviorByBehaviorId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BehaviorId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolBehaviorByBehaviorId.HandleId, ConfigSolarSchoolBehaviorByBehaviorId.LogPair);
			return list;
		}

		// Token: 0x040043FC RID: 17404
		private const string DB = "db_solarschool.db";

		// Token: 0x040043FD RID: 17405
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x040043FE RID: 17406
		private const string TABLE = "SolarSchoolBehavior";

		// Token: 0x040043FF RID: 17407
		private const string COMMAND = "select BinData from `SolarSchoolBehavior` where BehaviorId=?";

		// Token: 0x04004400 RID: 17408
		private const string KEY_PREFIX = "SolarSchoolBehaviorByBehaviorId";

		// Token: 0x04004401 RID: 17409
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004402 RID: 17410
		private static int HandleId;
	}
}
