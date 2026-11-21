using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F4 RID: 1780
	public class ConfigPhotographHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029C8 RID: 10696 RVA: 0x00149018 File Offset: 0x00147218
		static ConfigPhotographHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotographHandBookAll.CreateStaticDefaultValue), new Action(ConfigPhotographHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00149038 File Offset: 0x00147238
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotographHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotographHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhotographHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotographHandBook`")
			});
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x001490B7 File Offset: 0x001472B7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotographHandBookAll.LogPair = null;
			ConfigPhotographHandBookAll.HandleId = 0;
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x001490C5 File Offset: 0x001472C5
		public static void Init()
		{
			ConfigPhotographHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotographHandBookAll.HandleId, "db_handbook.db", "select BinData from `PhotographHandBook`");
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x001490E0 File Offset: 0x001472E0
		[NullableContext(2)]
		public static IReadOnlyList<PhotographHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotographHandBookAll.HandleId, ConfigPhotographHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotographHandBook> readOnlyList = (IReadOnlyList<PhotographHandBook>)ConfigCommon.GetConfig("PhotographHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotographHandBook> list = new List<PhotographHandBook>();
			while (ConfigCommon.Step(ConfigPhotographHandBookAll.HandleId, false, ConfigPhotographHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotographHandBookAll.HandleId, 0, ConfigPhotographHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotographHandBookAll.HandleId, ConfigPhotographHandBookAll.LogPair);
					return null;
				}
				PhotographHandBook rootAsPhotographHandBook = PhotographHandBook.GetRootAsPhotographHandBook(new ByteBuffer(item2));
				list.Add(rootAsPhotographHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotographHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotographHandBookAll.HandleId, ConfigPhotographHandBookAll.LogPair);
			return list;
		}

		// Token: 0x04003092 RID: 12434
		private const string DB = "db_handbook.db";

		// Token: 0x04003093 RID: 12435
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04003094 RID: 12436
		private const string TABLE = "PhotographHandBook";

		// Token: 0x04003095 RID: 12437
		private const string COMMAND = "select BinData from `PhotographHandBook`";

		// Token: 0x04003096 RID: 12438
		private const string KEY_PREFIX = "PhotographHandBookAll";

		// Token: 0x04003097 RID: 12439
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003098 RID: 12440
		private static int HandleId;
	}
}
