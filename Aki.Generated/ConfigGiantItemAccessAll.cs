using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000393 RID: 915
	public class ConfigGiantItemAccessAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001578 RID: 5496 RVA: 0x000D2FB4 File Offset: 0x000D11B4
		static ConfigGiantItemAccessAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantItemAccessAll.CreateStaticDefaultValue), new Action(ConfigGiantItemAccessAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000D2FD4 File Offset: 0x000D11D4
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantItemAccessAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantItemAccessAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantItemAccess"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantItemAccess`")
			});
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x000D3053 File Offset: 0x000D1253
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantItemAccessAll.LogPair = null;
			ConfigGiantItemAccessAll.HandleId = 0;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x000D3061 File Offset: 0x000D1261
		public static void Init()
		{
			ConfigGiantItemAccessAll.HandleId = ConfigCommon.InitDataStatement(ConfigGiantItemAccessAll.HandleId, "db_giant.db", "select BinData from `GiantItemAccess`");
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000D307C File Offset: 0x000D127C
		[NullableContext(2)]
		public static IReadOnlyList<GiantItemAccess> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantItemAccessAll.HandleId, ConfigGiantItemAccessAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GiantItemAccess> readOnlyList = (IReadOnlyList<GiantItemAccess>)ConfigCommon.GetConfig("GiantItemAccessAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GiantItemAccess> list = new List<GiantItemAccess>();
			while (ConfigCommon.Step(ConfigGiantItemAccessAll.HandleId, false, ConfigGiantItemAccessAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantItemAccessAll.HandleId, 0, ConfigGiantItemAccessAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGiantItemAccessAll.HandleId, ConfigGiantItemAccessAll.LogPair);
					return null;
				}
				GiantItemAccess rootAsGiantItemAccess = GiantItemAccess.GetRootAsGiantItemAccess(new ByteBuffer(item2));
				list.Add(rootAsGiantItemAccess);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GiantItemAccessAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGiantItemAccessAll.HandleId, ConfigGiantItemAccessAll.LogPair);
			return list;
		}

		// Token: 0x040018E9 RID: 6377
		private const string DB = "db_giant.db";

		// Token: 0x040018EA RID: 6378
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x040018EB RID: 6379
		private const string TABLE = "GiantItemAccess";

		// Token: 0x040018EC RID: 6380
		private const string COMMAND = "select BinData from `GiantItemAccess`";

		// Token: 0x040018ED RID: 6381
		private const string KEY_PREFIX = "GiantItemAccessAll";

		// Token: 0x040018EE RID: 6382
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018EF RID: 6383
		private static int HandleId;
	}
}
