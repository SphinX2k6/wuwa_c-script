using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000021 RID: 33
	public class ConfigAbyssRewardTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00061C60 File Offset: 0x0005FE60
		static ConfigAbyssRewardTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRewardTypeAll.CreateStaticDefaultValue), new Action(ConfigAbyssRewardTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00061C80 File Offset: 0x0005FE80
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRewardTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRewardTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRewardType"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRewardType`")
			});
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00061CFF File Offset: 0x0005FEFF
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRewardTypeAll.LogPair = null;
			ConfigAbyssRewardTypeAll.HandleId = 0;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00061D0D File Offset: 0x0005FF0D
		public static void Init()
		{
			ConfigAbyssRewardTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRewardTypeAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRewardType`");
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00061D28 File Offset: 0x0005FF28
		[NullableContext(2)]
		public static IReadOnlyList<AbyssRewardType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRewardTypeAll.HandleId, ConfigAbyssRewardTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssRewardType> readOnlyList = (IReadOnlyList<AbyssRewardType>)ConfigCommon.GetConfig("AbyssRewardTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssRewardType> list = new List<AbyssRewardType>();
			while (ConfigCommon.Step(ConfigAbyssRewardTypeAll.HandleId, false, ConfigAbyssRewardTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRewardTypeAll.HandleId, 0, ConfigAbyssRewardTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRewardTypeAll.HandleId, ConfigAbyssRewardTypeAll.LogPair);
					return null;
				}
				AbyssRewardType rootAsAbyssRewardType = AbyssRewardType.GetRootAsAbyssRewardType(new ByteBuffer(item2));
				list.Add(rootAsAbyssRewardType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssRewardTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRewardTypeAll.HandleId, ConfigAbyssRewardTypeAll.LogPair);
			return list;
		}

		// Token: 0x040000CB RID: 203
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000CC RID: 204
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000CD RID: 205
		private const string TABLE = "AbyssRewardType";

		// Token: 0x040000CE RID: 206
		private const string COMMAND = "select BinData from `AbyssRewardType`";

		// Token: 0x040000CF RID: 207
		private const string KEY_PREFIX = "AbyssRewardTypeAll";

		// Token: 0x040000D0 RID: 208
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000D1 RID: 209
		private static int HandleId;
	}
}
