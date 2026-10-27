using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000614 RID: 1556
	public class ConfigNounHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002488 RID: 9352 RVA: 0x001282A9 File Offset: 0x001264A9
		static ConfigNounHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounHandBookAll.CreateStaticDefaultValue), new Action(ConfigNounHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x001282C8 File Offset: 0x001264C8
		public static void CreateStaticDefaultValue()
		{
			ConfigNounHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNounHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "NounHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `NounHandBook`")
			});
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x00128347 File Offset: 0x00126547
		public static void ResetStaticDefaultValue()
		{
			ConfigNounHandBookAll.LogPair = null;
			ConfigNounHandBookAll.HandleId = 0;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00128355 File Offset: 0x00126555
		public static void Init()
		{
			ConfigNounHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigNounHandBookAll.HandleId, "db_handbook.db", "select BinData from `NounHandBook`");
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00128370 File Offset: 0x00126570
		[NullableContext(2)]
		public static IReadOnlyList<NounHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNounHandBookAll.HandleId, ConfigNounHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NounHandBook> readOnlyList = (IReadOnlyList<NounHandBook>)ConfigCommon.GetConfig("NounHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NounHandBook> list = new List<NounHandBook>();
			while (ConfigCommon.Step(ConfigNounHandBookAll.HandleId, false, ConfigNounHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNounHandBookAll.HandleId, 0, ConfigNounHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNounHandBookAll.HandleId, ConfigNounHandBookAll.LogPair);
					return null;
				}
				NounHandBook rootAsNounHandBook = NounHandBook.GetRootAsNounHandBook(new ByteBuffer(item2));
				list.Add(rootAsNounHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NounHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNounHandBookAll.HandleId, ConfigNounHandBookAll.LogPair);
			return list;
		}

		// Token: 0x04002A72 RID: 10866
		private const string DB = "db_handbook.db";

		// Token: 0x04002A73 RID: 10867
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002A74 RID: 10868
		private const string TABLE = "NounHandBook";

		// Token: 0x04002A75 RID: 10869
		private const string COMMAND = "select BinData from `NounHandBook`";

		// Token: 0x04002A76 RID: 10870
		private const string KEY_PREFIX = "NounHandBookAll";

		// Token: 0x04002A77 RID: 10871
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A78 RID: 10872
		private static int HandleId;
	}
}
