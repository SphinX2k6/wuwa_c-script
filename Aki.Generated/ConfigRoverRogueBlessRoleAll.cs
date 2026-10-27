using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E0 RID: 2272
	public class ConfigRoverRogueBlessRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003553 RID: 13651 RVA: 0x00186C78 File Offset: 0x00184E78
		static ConfigRoverRogueBlessRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessRoleAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00186C98 File Offset: 0x00184E98
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

		// Token: 0x06003555 RID: 13653 RVA: 0x00186D17 File Offset: 0x00184F17
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessRoleAll.LogPair = null;
			ConfigRoverRogueBlessRoleAll.HandleId = 0;
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x00186D25 File Offset: 0x00184F25
		public static void Init()
		{
			ConfigRoverRogueBlessRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessRoleAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBlessRole`");
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x00186D40 File Offset: 0x00184F40
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

		// Token: 0x04003E06 RID: 15878
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E07 RID: 15879
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E08 RID: 15880
		private const string TABLE = "RoverRogueBlessRole";

		// Token: 0x04003E09 RID: 15881
		private const string COMMAND = "select BinData from `RoverRogueBlessRole`";

		// Token: 0x04003E0A RID: 15882
		private const string KEY_PREFIX = "RoverRogueBlessRoleAll";

		// Token: 0x04003E0B RID: 15883
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E0C RID: 15884
		private static int HandleId;
	}
}
