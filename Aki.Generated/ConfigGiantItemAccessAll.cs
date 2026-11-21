using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A9 RID: 937
	public class ConfigGiantItemAccessAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015FC RID: 5628 RVA: 0x000D9708 File Offset: 0x000D7908
		static ConfigGiantItemAccessAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantItemAccessAll.CreateStaticDefaultValue), new Action(ConfigGiantItemAccessAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000D9728 File Offset: 0x000D7928
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

		// Token: 0x060015FE RID: 5630 RVA: 0x000D97A7 File Offset: 0x000D79A7
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantItemAccessAll.LogPair = null;
			ConfigGiantItemAccessAll.HandleId = 0;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000D97B5 File Offset: 0x000D79B5
		public static void Init()
		{
			ConfigGiantItemAccessAll.HandleId = ConfigCommon.InitDataStatement(ConfigGiantItemAccessAll.HandleId, "db_giant.db", "select BinData from `GiantItemAccess`");
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000D97D0 File Offset: 0x000D79D0
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

		// Token: 0x04001983 RID: 6531
		private const string DB = "db_giant.db";

		// Token: 0x04001984 RID: 6532
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x04001985 RID: 6533
		private const string TABLE = "GiantItemAccess";

		// Token: 0x04001986 RID: 6534
		private const string COMMAND = "select BinData from `GiantItemAccess`";

		// Token: 0x04001987 RID: 6535
		private const string KEY_PREFIX = "GiantItemAccessAll";

		// Token: 0x04001988 RID: 6536
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001989 RID: 6537
		private static int HandleId;
	}
}
