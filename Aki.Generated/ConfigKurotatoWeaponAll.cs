using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D5 RID: 1237
	public class ConfigKurotatoWeaponAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D09 RID: 7433 RVA: 0x00100E40 File Offset: 0x000FF040
		static ConfigKurotatoWeaponAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00100E60 File Offset: 0x000FF060
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeapon"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeapon`")
			});
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00100EDF File Offset: 0x000FF0DF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponAll.LogPair = null;
			ConfigKurotatoWeaponAll.HandleId = 0;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00100EED File Offset: 0x000FF0ED
		public static void Init()
		{
			ConfigKurotatoWeaponAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeapon`");
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00100F08 File Offset: 0x000FF108
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoWeapon> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponAll.HandleId, ConfigKurotatoWeaponAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoWeapon> readOnlyList = (IReadOnlyList<KurotatoWeapon>)ConfigCommon.GetConfig("KurotatoWeaponAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoWeapon> list = new List<KurotatoWeapon>();
			while (ConfigCommon.Step(ConfigKurotatoWeaponAll.HandleId, false, ConfigKurotatoWeaponAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponAll.HandleId, 0, ConfigKurotatoWeaponAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoWeaponAll.HandleId, ConfigKurotatoWeaponAll.LogPair);
					return null;
				}
				KurotatoWeapon rootAsKurotatoWeapon = KurotatoWeapon.GetRootAsKurotatoWeapon(new ByteBuffer(item2));
				list.Add(rootAsKurotatoWeapon);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoWeaponAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponAll.HandleId, ConfigKurotatoWeaponAll.LogPair);
			return list;
		}

		// Token: 0x040021B7 RID: 8631
		private const string DB = "db_kurotato.db";

		// Token: 0x040021B8 RID: 8632
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x040021B9 RID: 8633
		private const string TABLE = "KurotatoWeapon";

		// Token: 0x040021BA RID: 8634
		private const string COMMAND = "select BinData from `KurotatoWeapon`";

		// Token: 0x040021BB RID: 8635
		private const string KEY_PREFIX = "KurotatoWeaponAll";

		// Token: 0x040021BC RID: 8636
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021BD RID: 8637
		private static int HandleId;
	}
}
