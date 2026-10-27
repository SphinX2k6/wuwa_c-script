using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087B RID: 2171
	public class ConfigRogueWeeklyRoomTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032F4 RID: 13044 RVA: 0x00179784 File Offset: 0x00177984
		static ConfigRogueWeeklyRoomTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRoomTypeAll.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRoomTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x001797A4 File Offset: 0x001779A4
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

		// Token: 0x060032F6 RID: 13046 RVA: 0x00179823 File Offset: 0x00177A23
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRoomTypeAll.LogPair = null;
			ConfigRogueWeeklyRoomTypeAll.HandleId = 0;
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00179831 File Offset: 0x00177A31
		public static void Init()
		{
			ConfigRogueWeeklyRoomTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRoomTypeAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyRoomType`");
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0017984C File Offset: 0x00177A4C
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

		// Token: 0x04003B43 RID: 15171
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B44 RID: 15172
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B45 RID: 15173
		private const string TABLE = "RogueWeeklyRoomType";

		// Token: 0x04003B46 RID: 15174
		private const string COMMAND = "select BinData from `RogueWeeklyRoomType`";

		// Token: 0x04003B47 RID: 15175
		private const string KEY_PREFIX = "RogueWeeklyRoomTypeAll";

		// Token: 0x04003B48 RID: 15176
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B49 RID: 15177
		private static int HandleId;
	}
}
