using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092B RID: 2347
	public class ConfigRoverRogueBlessRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003715 RID: 14101 RVA: 0x00193E98 File Offset: 0x00192098
		static ConfigRoverRogueBlessRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessRoleAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00193EB8 File Offset: 0x001920B8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueBlessRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueBlessRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueBlessRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueBlessRole`")
			});
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00193F37 File Offset: 0x00192137
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessRoleAll.LogPair = null;
			ConfigRoverRogueBlessRoleAll.HandleId = 0;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00193F45 File Offset: 0x00192145
		public static void Init()
		{
			ConfigRoverRogueBlessRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessRoleAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBlessRole`");
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00193F60 File Offset: 0x00192160
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueBlessRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueBlessRoleAll.HandleId, ConfigRoverRogueBlessRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueBlessRole> readOnlyList = (IReadOnlyList<RoverRogueBlessRole>)ConfigCommon.GetConfig("RoverRogueBlessRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueBlessRole> list = new List<RoverRogueBlessRole>();
			while (ConfigCommon.Step(ConfigRoverRogueBlessRoleAll.HandleId, false, ConfigRoverRogueBlessRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueBlessRoleAll.HandleId, 0, ConfigRoverRogueBlessRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueBlessRoleAll.HandleId, ConfigRoverRogueBlessRoleAll.LogPair);
					return null;
				}
				RoverRogueBlessRole rootAsRoverRogueBlessRole = RoverRogueBlessRole.GetRootAsRoverRogueBlessRole(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueBlessRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueBlessRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueBlessRoleAll.HandleId, ConfigRoverRogueBlessRoleAll.LogPair);
			return list;
		}

		// Token: 0x04004013 RID: 16403
		private const string DB = "db_roverlike.db";

		// Token: 0x04004014 RID: 16404
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04004015 RID: 16405
		private const string TABLE = "RoverRogueBlessRole";

		// Token: 0x04004016 RID: 16406
		private const string COMMAND = "select BinData from `RoverRogueBlessRole`";

		// Token: 0x04004017 RID: 16407
		private const string KEY_PREFIX = "RoverRogueBlessRoleAll";

		// Token: 0x04004018 RID: 16408
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004019 RID: 16409
		private static int HandleId;
	}
}
