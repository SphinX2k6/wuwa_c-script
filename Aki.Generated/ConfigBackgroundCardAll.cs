using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DE RID: 222
	public class ConfigBackgroundCardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x000770D0 File Offset: 0x000752D0
		static ConfigBackgroundCardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBackgroundCardAll.CreateStaticDefaultValue), new Action(ConfigBackgroundCardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000770F0 File Offset: 0x000752F0
		public static void CreateStaticDefaultValue()
		{
			ConfigBackgroundCardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBackgroundCardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_personal_card.db"),
				new ValueTuple<string, object>("文件", "m.名片.xlsx"),
				new ValueTuple<string, object>("表名", "BackgroundCard"),
				new ValueTuple<string, object>("语句", "select BinData from `BackgroundCard`")
			});
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0007716F File Offset: 0x0007536F
		public static void ResetStaticDefaultValue()
		{
			ConfigBackgroundCardAll.LogPair = null;
			ConfigBackgroundCardAll.HandleId = 0;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0007717D File Offset: 0x0007537D
		public static void Init()
		{
			ConfigBackgroundCardAll.HandleId = ConfigCommon.InitDataStatement(ConfigBackgroundCardAll.HandleId, "db_personal_card.db", "select BinData from `BackgroundCard`");
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00077198 File Offset: 0x00075398
		[NullableContext(2)]
		public static IReadOnlyList<BackgroundCard> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBackgroundCardAll.HandleId, ConfigBackgroundCardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BackgroundCard> readOnlyList = (IReadOnlyList<BackgroundCard>)ConfigCommon.GetConfig("BackgroundCardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BackgroundCard> list = new List<BackgroundCard>();
			while (ConfigCommon.Step(ConfigBackgroundCardAll.HandleId, false, ConfigBackgroundCardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBackgroundCardAll.HandleId, 0, ConfigBackgroundCardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBackgroundCardAll.HandleId, ConfigBackgroundCardAll.LogPair);
					return null;
				}
				BackgroundCard rootAsBackgroundCard = BackgroundCard.GetRootAsBackgroundCard(new ByteBuffer(item2));
				list.Add(rootAsBackgroundCard);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BackgroundCardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBackgroundCardAll.HandleId, ConfigBackgroundCardAll.LogPair);
			return list;
		}

		// Token: 0x040005F6 RID: 1526
		private const string DB = "db_personal_card.db";

		// Token: 0x040005F7 RID: 1527
		private const string FILE = "m.名片.xlsx";

		// Token: 0x040005F8 RID: 1528
		private const string TABLE = "BackgroundCard";

		// Token: 0x040005F9 RID: 1529
		private const string COMMAND = "select BinData from `BackgroundCard`";

		// Token: 0x040005FA RID: 1530
		private const string KEY_PREFIX = "BackgroundCardAll";

		// Token: 0x040005FB RID: 1531
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005FC RID: 1532
		private static int HandleId;
	}
}
