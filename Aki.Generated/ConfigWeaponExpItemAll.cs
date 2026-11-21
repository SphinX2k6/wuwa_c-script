using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B51 RID: 2897
	public class ConfigWeaponExpItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043FA RID: 17402 RVA: 0x001DD7F4 File Offset: 0x001DB9F4
		static ConfigWeaponExpItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponExpItemAll.CreateStaticDefaultValue), new Action(ConfigWeaponExpItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x001DD814 File Offset: 0x001DBA14
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

		// Token: 0x060043FC RID: 17404 RVA: 0x001DD893 File Offset: 0x001DBA93
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponExpItemAll.LogPair = null;
			ConfigWeaponExpItemAll.HandleId = 0;
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x001DD8A1 File Offset: 0x001DBAA1
		public static void Init()
		{
			ConfigWeaponExpItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponExpItemAll.HandleId, "db_weapon.db", "select BinData from `WeaponExpItem`");
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x001DD8BC File Offset: 0x001DBABC
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

		// Token: 0x04004F1D RID: 20253
		private const string DB = "db_weapon.db";

		// Token: 0x04004F1E RID: 20254
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F1F RID: 20255
		private const string TABLE = "WeaponExpItem";

		// Token: 0x04004F20 RID: 20256
		private const string COMMAND = "select BinData from `WeaponExpItem`";

		// Token: 0x04004F21 RID: 20257
		private const string KEY_PREFIX = "WeaponExpItemAll";

		// Token: 0x04004F22 RID: 20258
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F23 RID: 20259
		private static int HandleId;
	}
}
