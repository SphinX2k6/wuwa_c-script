using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B53 RID: 2899
	public class ConfigWeaponHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004406 RID: 17414 RVA: 0x001DDBD0 File Offset: 0x001DBDD0
		static ConfigWeaponHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponHandBookAll.CreateStaticDefaultValue), new Action(ConfigWeaponHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x001DDBF0 File Offset: 0x001DBDF0
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponHandBook`")
			});
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x001DDC6F File Offset: 0x001DBE6F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponHandBookAll.LogPair = null;
			ConfigWeaponHandBookAll.HandleId = 0;
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x001DDC7D File Offset: 0x001DBE7D
		public static void Init()
		{
			ConfigWeaponHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponHandBookAll.HandleId, "db_handbook.db", "select BinData from `WeaponHandBook`");
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x001DDC98 File Offset: 0x001DBE98
		[NullableContext(2)]
		public static IReadOnlyList<WeaponHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponHandBookAll.HandleId, ConfigWeaponHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WeaponHandBook> readOnlyList = (IReadOnlyList<WeaponHandBook>)ConfigCommon.GetConfig("WeaponHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WeaponHandBook> list = new List<WeaponHandBook>();
			while (ConfigCommon.Step(ConfigWeaponHandBookAll.HandleId, false, ConfigWeaponHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponHandBookAll.HandleId, 0, ConfigWeaponHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeaponHandBookAll.HandleId, ConfigWeaponHandBookAll.LogPair);
					return null;
				}
				WeaponHandBook rootAsWeaponHandBook = WeaponHandBook.GetRootAsWeaponHandBook(new ByteBuffer(item2));
				list.Add(rootAsWeaponHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WeaponHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeaponHandBookAll.HandleId, ConfigWeaponHandBookAll.LogPair);
			return list;
		}

		// Token: 0x04004F2B RID: 20267
		private const string DB = "db_handbook.db";

		// Token: 0x04004F2C RID: 20268
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04004F2D RID: 20269
		private const string TABLE = "WeaponHandBook";

		// Token: 0x04004F2E RID: 20270
		private const string COMMAND = "select BinData from `WeaponHandBook`";

		// Token: 0x04004F2F RID: 20271
		private const string KEY_PREFIX = "WeaponHandBookAll";

		// Token: 0x04004F30 RID: 20272
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F31 RID: 20273
		private static int HandleId;
	}
}
