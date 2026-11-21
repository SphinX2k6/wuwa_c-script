using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DA RID: 1242
	public class ConfigKurotatoWeaponGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D27 RID: 7463 RVA: 0x00101830 File Offset: 0x000FFA30
		static ConfigKurotatoWeaponGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponGroupAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00101850 File Offset: 0x000FFA50
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeaponGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeaponGroup`")
			});
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x001018CF File Offset: 0x000FFACF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponGroupAll.LogPair = null;
			ConfigKurotatoWeaponGroupAll.HandleId = 0;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x001018DD File Offset: 0x000FFADD
		public static void Init()
		{
			ConfigKurotatoWeaponGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponGroupAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeaponGroup`");
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x001018F8 File Offset: 0x000FFAF8
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoWeaponGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponGroupAll.HandleId, ConfigKurotatoWeaponGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoWeaponGroup> readOnlyList = (IReadOnlyList<KurotatoWeaponGroup>)ConfigCommon.GetConfig("KurotatoWeaponGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoWeaponGroup> list = new List<KurotatoWeaponGroup>();
			while (ConfigCommon.Step(ConfigKurotatoWeaponGroupAll.HandleId, false, ConfigKurotatoWeaponGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponGroupAll.HandleId, 0, ConfigKurotatoWeaponGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoWeaponGroupAll.HandleId, ConfigKurotatoWeaponGroupAll.LogPair);
					return null;
				}
				KurotatoWeaponGroup rootAsKurotatoWeaponGroup = KurotatoWeaponGroup.GetRootAsKurotatoWeaponGroup(new ByteBuffer(item2));
				list.Add(rootAsKurotatoWeaponGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoWeaponGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponGroupAll.HandleId, ConfigKurotatoWeaponGroupAll.LogPair);
			return list;
		}

		// Token: 0x040021DA RID: 8666
		private const string DB = "db_kurotato.db";

		// Token: 0x040021DB RID: 8667
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x040021DC RID: 8668
		private const string TABLE = "KurotatoWeaponGroup";

		// Token: 0x040021DD RID: 8669
		private const string COMMAND = "select BinData from `KurotatoWeaponGroup`";

		// Token: 0x040021DE RID: 8670
		private const string KEY_PREFIX = "KurotatoWeaponGroupAll";

		// Token: 0x040021DF RID: 8671
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021E0 RID: 8672
		private static int HandleId;
	}
}
