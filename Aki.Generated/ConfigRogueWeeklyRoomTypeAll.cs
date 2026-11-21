using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000897 RID: 2199
	public class ConfigRogueWeeklyRoomTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600339C RID: 13212 RVA: 0x00180A6C File Offset: 0x0017EC6C
		static ConfigRogueWeeklyRoomTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRoomTypeAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRoomTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00180A8C File Offset: 0x0017EC8C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyRoomTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyRoomType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyRoomType`")
			});
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00180B0B File Offset: 0x0017ED0B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomTypeAll.LogPair = null;
			ConfigRogueWeeklyRoomTypeAll.HandleId = 0;
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00180B19 File Offset: 0x0017ED19
		public static void Init()
		{
			ConfigRogueWeeklyRoomTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRoomTypeAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyRoomType`");
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00180B34 File Offset: 0x0017ED34
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyRoomType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyRoomTypeAll.HandleId, ConfigRogueWeeklyRoomTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueWeeklyRoomType> readOnlyList = (IReadOnlyList<RogueWeeklyRoomType>)ConfigCommon.GetConfig("RogueWeeklyRoomTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueWeeklyRoomType> list = new List<RogueWeeklyRoomType>();
			while (ConfigCommon.Step(ConfigRogueWeeklyRoomTypeAll.HandleId, false, ConfigRogueWeeklyRoomTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyRoomTypeAll.HandleId, 0, ConfigRogueWeeklyRoomTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyRoomTypeAll.HandleId, ConfigRogueWeeklyRoomTypeAll.LogPair);
					return null;
				}
				RogueWeeklyRoomType rootAsRogueWeeklyRoomType = RogueWeeklyRoomType.GetRootAsRogueWeeklyRoomType(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyRoomType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueWeeklyRoomTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyRoomTypeAll.HandleId, ConfigRogueWeeklyRoomTypeAll.LogPair);
			return list;
		}

		// Token: 0x04003C07 RID: 15367
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003C08 RID: 15368
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003C09 RID: 15369
		private const string TABLE = "RogueWeeklyRoomType";

		// Token: 0x04003C0A RID: 15370
		private const string COMMAND = "select BinData from `RogueWeeklyRoomType`";

		// Token: 0x04003C0B RID: 15371
		private const string KEY_PREFIX = "RogueWeeklyRoomTypeAll";

		// Token: 0x04003C0C RID: 15372
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C0D RID: 15373
		private static int HandleId;
	}
}
