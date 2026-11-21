using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000381 RID: 897
	public class ConfigGachaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600150B RID: 5387 RVA: 0x000D3F1C File Offset: 0x000D211C
		static ConfigGachaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaAll.CreateStaticDefaultValue), new Action(ConfigGachaAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000D3F3C File Offset: 0x000D213C
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

		// Token: 0x0600150D RID: 5389 RVA: 0x000D3FBB File Offset: 0x000D21BB
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaAll.LogPair = null;
			ConfigGachaAll.HandleId = 0;
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000D3FC9 File Offset: 0x000D21C9
		public static void Init()
		{
			ConfigGachaAll.HandleId = ConfigCommon.InitDataStatement(ConfigGachaAll.HandleId, "db_gacha.db", "select BinData from `Gacha`");
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000D3FE4 File Offset: 0x000D21E4
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

		// Token: 0x0400186B RID: 6251
		private const string DB = "db_gacha.db";

		// Token: 0x0400186C RID: 6252
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x0400186D RID: 6253
		private const string TABLE = "Gacha";

		// Token: 0x0400186E RID: 6254
		private const string COMMAND = "select BinData from `Gacha`";

		// Token: 0x0400186F RID: 6255
		private const string KEY_PREFIX = "GachaAll";

		// Token: 0x04001870 RID: 6256
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001871 RID: 6257
		private static int HandleId;
	}
}
