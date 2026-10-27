using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200036C RID: 876
	public class ConfigGachaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600148D RID: 5261 RVA: 0x000CDA10 File Offset: 0x000CBC10
		static ConfigGachaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaAll.CreateStaticDefaultValue), new Action(ConfigGachaAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x000CDA30 File Offset: 0x000CBC30
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "Gacha"),
				new ValueTuple<string, object>("语句", "select BinData from `Gacha`")
			});
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x000CDAAF File Offset: 0x000CBCAF
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaAll.LogPair = null;
			ConfigGachaAll.HandleId = 0;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000CDABD File Offset: 0x000CBCBD
		public static void Init()
		{
			ConfigGachaAll.HandleId = ConfigCommon.InitDataStatement(ConfigGachaAll.HandleId, "db_gacha.db", "select BinData from `Gacha`");
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x000CDAD8 File Offset: 0x000CBCD8
		[NullableContext(2)]
		public static IReadOnlyList<Gacha> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaAll.HandleId, ConfigGachaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Gacha> readOnlyList = (IReadOnlyList<Gacha>)ConfigCommon.GetConfig("GachaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Gacha> list = new List<Gacha>();
			while (ConfigCommon.Step(ConfigGachaAll.HandleId, false, ConfigGachaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaAll.HandleId, 0, ConfigGachaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGachaAll.HandleId, ConfigGachaAll.LogPair);
					return null;
				}
				Gacha rootAsGacha = Gacha.GetRootAsGacha(new ByteBuffer(item2));
				list.Add(rootAsGacha);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GachaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGachaAll.HandleId, ConfigGachaAll.LogPair);
			return list;
		}

		// Token: 0x040017D8 RID: 6104
		private const string DB = "db_gacha.db";

		// Token: 0x040017D9 RID: 6105
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040017DA RID: 6106
		private const string TABLE = "Gacha";

		// Token: 0x040017DB RID: 6107
		private const string COMMAND = "select BinData from `Gacha`";

		// Token: 0x040017DC RID: 6108
		private const string KEY_PREFIX = "GachaAll";

		// Token: 0x040017DD RID: 6109
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017DE RID: 6110
		private static int HandleId;
	}
}
