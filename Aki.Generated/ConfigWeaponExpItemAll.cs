using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7C RID: 2684
	public class ConfigWeaponExpItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EFC RID: 16124 RVA: 0x001BE460 File Offset: 0x001BC660
		static ConfigWeaponExpItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponExpItemAll.CreateStaticDefaultValue), new Action(ConfigWeaponExpItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x001BE480 File Offset: 0x001BC680
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponExpItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponExpItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponExpItem"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponExpItem`")
			});
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x001BE4FF File Offset: 0x001BC6FF
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponExpItemAll.LogPair = null;
			ConfigWeaponExpItemAll.HandleId = 0;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x001BE50D File Offset: 0x001BC70D
		public static void Init()
		{
			ConfigWeaponExpItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponExpItemAll.HandleId, "db_weapon.db", "select BinData from `WeaponExpItem`");
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x001BE528 File Offset: 0x001BC728
		[NullableContext(2)]
		public static IReadOnlyList<WeaponExpItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponExpItemAll.HandleId, ConfigWeaponExpItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WeaponExpItem> readOnlyList = (IReadOnlyList<WeaponExpItem>)ConfigCommon.GetConfig("WeaponExpItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WeaponExpItem> list = new List<WeaponExpItem>();
			while (ConfigCommon.Step(ConfigWeaponExpItemAll.HandleId, false, ConfigWeaponExpItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponExpItemAll.HandleId, 0, ConfigWeaponExpItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeaponExpItemAll.HandleId, ConfigWeaponExpItemAll.LogPair);
					return null;
				}
				WeaponExpItem rootAsWeaponExpItem = WeaponExpItem.GetRootAsWeaponExpItem(new ByteBuffer(item2));
				list.Add(rootAsWeaponExpItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WeaponExpItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeaponExpItemAll.HandleId, ConfigWeaponExpItemAll.LogPair);
			return list;
		}

		// Token: 0x0400494A RID: 18762
		private const string DB = "db_weapon.db";

		// Token: 0x0400494B RID: 18763
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x0400494C RID: 18764
		private const string TABLE = "WeaponExpItem";

		// Token: 0x0400494D RID: 18765
		private const string COMMAND = "select BinData from `WeaponExpItem`";

		// Token: 0x0400494E RID: 18766
		private const string KEY_PREFIX = "WeaponExpItemAll";

		// Token: 0x0400494F RID: 18767
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004950 RID: 18768
		private static int HandleId;
	}
}
