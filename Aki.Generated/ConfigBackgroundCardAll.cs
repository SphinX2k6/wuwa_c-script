using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000ED RID: 237
	public class ConfigBackgroundCardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0007CA34 File Offset: 0x0007AC34
		static ConfigBackgroundCardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBackgroundCardAll.CreateStaticDefaultValue), new Action(ConfigBackgroundCardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0007CA54 File Offset: 0x0007AC54
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

		// Token: 0x06000591 RID: 1425 RVA: 0x0007CAD3 File Offset: 0x0007ACD3
		public static void ResetStaticDefaultValue()
		{
			ConfigBackgroundCardAll.LogPair = null;
			ConfigBackgroundCardAll.HandleId = 0;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0007CAE1 File Offset: 0x0007ACE1
		public static void Init()
		{
			ConfigBackgroundCardAll.HandleId = ConfigCommon.InitDataStatement(ConfigBackgroundCardAll.HandleId, "db_personal_card.db", "select BinData from `BackgroundCard`");
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0007CAFC File Offset: 0x0007ACFC
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

		// Token: 0x0400065F RID: 1631
		private const string DB = "db_personal_card.db";

		// Token: 0x04000660 RID: 1632
		private const string FILE = "m.名片.xlsx";

		// Token: 0x04000661 RID: 1633
		private const string TABLE = "BackgroundCard";

		// Token: 0x04000662 RID: 1634
		private const string COMMAND = "select BinData from `BackgroundCard`";

		// Token: 0x04000663 RID: 1635
		private const string KEY_PREFIX = "BackgroundCardAll";

		// Token: 0x04000664 RID: 1636
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000665 RID: 1637
		private static int HandleId;
	}
}
