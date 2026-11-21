using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F2 RID: 242
	public class ConfigBattleLinkCharacterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x0007D53C File Offset: 0x0007B73C
		static ConfigBattleLinkCharacterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattleLinkCharacterAll.CreateStaticDefaultValue), new Action(ConfigBattleLinkCharacterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0007D55C File Offset: 0x0007B75C
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

		// Token: 0x060005AF RID: 1455 RVA: 0x0007D5DB File Offset: 0x0007B7DB
		public static void ResetStaticDefaultValue()
		{
			ConfigBattleLinkCharacterAll.LogPair = null;
			ConfigBattleLinkCharacterAll.HandleId = 0;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0007D5E9 File Offset: 0x0007B7E9
		public static void Init()
		{
			ConfigBattleLinkCharacterAll.HandleId = ConfigCommon.InitDataStatement(ConfigBattleLinkCharacterAll.HandleId, "db_dreamlink.db", "select BinData from `BattleLinkCharacter`");
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0007D604 File Offset: 0x0007B804
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

		// Token: 0x04000682 RID: 1666
		private const string DB = "db_dreamlink.db";

		// Token: 0x04000683 RID: 1667
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04000684 RID: 1668
		private const string TABLE = "BattleLinkCharacter";

		// Token: 0x04000685 RID: 1669
		private const string COMMAND = "select BinData from `BattleLinkCharacter`";

		// Token: 0x04000686 RID: 1670
		private const string KEY_PREFIX = "BattleLinkCharacterAll";

		// Token: 0x04000687 RID: 1671
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000688 RID: 1672
		private static int HandleId;
	}
}
