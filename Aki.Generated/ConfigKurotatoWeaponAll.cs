using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BF RID: 1215
	public class ConfigKurotatoWeaponAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C85 RID: 7301 RVA: 0x000FA6EC File Offset: 0x000F88EC
		static ConfigKurotatoWeaponAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x000FA70C File Offset: 0x000F890C
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

		// Token: 0x06001C87 RID: 7303 RVA: 0x000FA78B File Offset: 0x000F898B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponAll.LogPair = null;
			ConfigKurotatoWeaponAll.HandleId = 0;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x000FA799 File Offset: 0x000F8999
		public static void Init()
		{
			ConfigKurotatoWeaponAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeapon`");
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000FA7B4 File Offset: 0x000F89B4
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

		// Token: 0x0400211D RID: 8477
		private const string DB = "db_kurotato.db";

		// Token: 0x0400211E RID: 8478
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x0400211F RID: 8479
		private const string TABLE = "KurotatoWeapon";

		// Token: 0x04002120 RID: 8480
		private const string COMMAND = "select BinData from `KurotatoWeapon`";

		// Token: 0x04002121 RID: 8481
		private const string KEY_PREFIX = "KurotatoWeaponAll";

		// Token: 0x04002122 RID: 8482
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002123 RID: 8483
		private static int HandleId;
	}
}
