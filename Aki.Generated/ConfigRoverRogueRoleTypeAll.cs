using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F3 RID: 2291
	public class ConfigRoverRogueRoleTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035C5 RID: 13765 RVA: 0x0018941C File Offset: 0x0018761C
		static ConfigRoverRogueRoleTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleTypeAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0018943C File Offset: 0x0018763C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoleTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoleTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoleType"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoleType`")
			});
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x001894BB File Offset: 0x001876BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleTypeAll.LogPair = null;
			ConfigRoverRogueRoleTypeAll.HandleId = 0;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x001894C9 File Offset: 0x001876C9
		public static void Init()
		{
			ConfigRoverRogueRoleTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleTypeAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoleType`");
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x001894E4 File Offset: 0x001876E4
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueRoleType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoleTypeAll.HandleId, ConfigRoverRogueRoleTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoverRogueRoleType> readOnlyList = (IReadOnlyList<RoverRogueRoleType>)ConfigCommon.GetConfig("RoverRogueRoleTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoverRogueRoleType> list = new List<RoverRogueRoleType>();
			while (ConfigCommon.Step(ConfigRoverRogueRoleTypeAll.HandleId, false, ConfigRoverRogueRoleTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoleTypeAll.HandleId, 0, ConfigRoverRogueRoleTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueRoleTypeAll.HandleId, ConfigRoverRogueRoleTypeAll.LogPair);
					return null;
				}
				RoverRogueRoleType rootAsRoverRogueRoleType = RoverRogueRoleType.GetRootAsRoverRogueRoleType(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueRoleType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoverRogueRoleTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoleTypeAll.HandleId, ConfigRoverRogueRoleTypeAll.LogPair);
			return list;
		}

		// Token: 0x04003E8B RID: 16011
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E8C RID: 16012
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E8D RID: 16013
		private const string TABLE = "RoverRogueRoleType";

		// Token: 0x04003E8E RID: 16014
		private const string COMMAND = "select BinData from `RoverRogueRoleType`";

		// Token: 0x04003E8F RID: 16015
		private const string KEY_PREFIX = "RoverRogueRoleTypeAll";

		// Token: 0x04003E90 RID: 16016
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E91 RID: 16017
		private static int HandleId;
	}
}
