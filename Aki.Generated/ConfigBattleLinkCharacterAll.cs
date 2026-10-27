using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E3 RID: 227
	public class ConfigBattleLinkCharacterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x00077BD8 File Offset: 0x00075DD8
		static ConfigBattleLinkCharacterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleLinkCharacterAll.CreateStaticDefaultValue), new Action(ConfigBattleLinkCharacterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00077BF8 File Offset: 0x00075DF8
		public static void CreateStaticDefaultValue()
		{
			ConfigBattleLinkCharacterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattleLinkCharacterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "BattleLinkCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `BattleLinkCharacter`")
			});
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00077C77 File Offset: 0x00075E77
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleLinkCharacterAll.LogPair = null;
			ConfigBattleLinkCharacterAll.HandleId = 0;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00077C85 File Offset: 0x00075E85
		public static void Init()
		{
			ConfigBattleLinkCharacterAll.HandleId = ConfigCommon.InitDataStatement(ConfigBattleLinkCharacterAll.HandleId, "db_dreamlink.db", "select BinData from `BattleLinkCharacter`");
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00077CA0 File Offset: 0x00075EA0
		[NullableContext(2)]
		public static IReadOnlyList<BattleLinkCharacter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattleLinkCharacterAll.HandleId, ConfigBattleLinkCharacterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BattleLinkCharacter> readOnlyList = (IReadOnlyList<BattleLinkCharacter>)ConfigCommon.GetConfig("BattleLinkCharacterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BattleLinkCharacter> list = new List<BattleLinkCharacter>();
			while (ConfigCommon.Step(ConfigBattleLinkCharacterAll.HandleId, false, ConfigBattleLinkCharacterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattleLinkCharacterAll.HandleId, 0, ConfigBattleLinkCharacterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBattleLinkCharacterAll.HandleId, ConfigBattleLinkCharacterAll.LogPair);
					return null;
				}
				BattleLinkCharacter rootAsBattleLinkCharacter = BattleLinkCharacter.GetRootAsBattleLinkCharacter(new ByteBuffer(item2));
				list.Add(rootAsBattleLinkCharacter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BattleLinkCharacterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBattleLinkCharacterAll.HandleId, ConfigBattleLinkCharacterAll.LogPair);
			return list;
		}

		// Token: 0x04000619 RID: 1561
		private const string DB = "db_dreamlink.db";

		// Token: 0x0400061A RID: 1562
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x0400061B RID: 1563
		private const string TABLE = "BattleLinkCharacter";

		// Token: 0x0400061C RID: 1564
		private const string COMMAND = "select BinData from `BattleLinkCharacter`";

		// Token: 0x0400061D RID: 1565
		private const string KEY_PREFIX = "BattleLinkCharacterAll";

		// Token: 0x0400061E RID: 1566
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400061F RID: 1567
		private static int HandleId;
	}
}
