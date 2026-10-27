using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7E RID: 2686
	public class ConfigWeaponHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F08 RID: 16136 RVA: 0x001BE83C File Offset: 0x001BCA3C
		static ConfigWeaponHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponHandBookAll.CreateStaticDefaultValue), new Action(ConfigWeaponHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x001BE85C File Offset: 0x001BCA5C
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

		// Token: 0x06003F0A RID: 16138 RVA: 0x001BE8DB File Offset: 0x001BCADB
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponHandBookAll.LogPair = null;
			ConfigWeaponHandBookAll.HandleId = 0;
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x001BE8E9 File Offset: 0x001BCAE9
		public static void Init()
		{
			ConfigWeaponHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponHandBookAll.HandleId, "db_handbook.db", "select BinData from `WeaponHandBook`");
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x001BE904 File Offset: 0x001BCB04
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

		// Token: 0x04004958 RID: 18776
		private const string DB = "db_handbook.db";

		// Token: 0x04004959 RID: 18777
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400495A RID: 18778
		private const string TABLE = "WeaponHandBook";

		// Token: 0x0400495B RID: 18779
		private const string COMMAND = "select BinData from `WeaponHandBook`";

		// Token: 0x0400495C RID: 18780
		private const string KEY_PREFIX = "WeaponHandBookAll";

		// Token: 0x0400495D RID: 18781
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400495E RID: 18782
		private static int HandleId;
	}
}
