using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093E RID: 2366
	public class ConfigRoverRogueRoleTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003787 RID: 14215 RVA: 0x0019663C File Offset: 0x0019483C
		static ConfigRoverRogueRoleTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleTypeAll.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x0019665C File Offset: 0x0019485C
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

		// Token: 0x06003789 RID: 14217 RVA: 0x001966DB File Offset: 0x001948DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleTypeAll.LogPair = null;
			ConfigRoverRogueRoleTypeAll.HandleId = 0;
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x001966E9 File Offset: 0x001948E9
		public static void Init()
		{
			ConfigRoverRogueRoleTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleTypeAll.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoleType`");
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00196704 File Offset: 0x00194904
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

		// Token: 0x04004098 RID: 16536
		private const string DB = "db_roverlike.db";

		// Token: 0x04004099 RID: 16537
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x0400409A RID: 16538
		private const string TABLE = "RoverRogueRoleType";

		// Token: 0x0400409B RID: 16539
		private const string COMMAND = "select BinData from `RoverRogueRoleType`";

		// Token: 0x0400409C RID: 16540
		private const string KEY_PREFIX = "RoverRogueRoleTypeAll";

		// Token: 0x0400409D RID: 16541
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400409E RID: 16542
		private static int HandleId;
	}
}
