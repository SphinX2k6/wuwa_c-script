using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200007A RID: 122
	public class ConfigAdviceWordAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002DC RID: 732 RVA: 0x00069A44 File Offset: 0x00067C44
		static ConfigAdviceWordAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordAll.CreateStaticDefaultValue), new Action(ConfigAdviceWordAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00069A64 File Offset: 0x00067C64
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceWordAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceWordAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceWord"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceWord`")
			});
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00069AE3 File Offset: 0x00067CE3
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordAll.LogPair = null;
			ConfigAdviceWordAll.HandleId = 0;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00069AF1 File Offset: 0x00067CF1
		public static void Init()
		{
			ConfigAdviceWordAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordAll.HandleId, "db_advice.db", "select BinData from `AdviceWord`");
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00069B0C File Offset: 0x00067D0C
		[NullableContext(2)]
		public static IReadOnlyList<AdviceWord> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceWordAll.HandleId, ConfigAdviceWordAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdviceWord> readOnlyList = (IReadOnlyList<AdviceWord>)ConfigCommon.GetConfig("AdviceWordAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdviceWord> list = new List<AdviceWord>();
			while (ConfigCommon.Step(ConfigAdviceWordAll.HandleId, false, ConfigAdviceWordAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceWordAll.HandleId, 0, ConfigAdviceWordAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdviceWordAll.HandleId, ConfigAdviceWordAll.LogPair);
					return null;
				}
				AdviceWord rootAsAdviceWord = AdviceWord.GetRootAsAdviceWord(new ByteBuffer(item2));
				list.Add(rootAsAdviceWord);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdviceWordAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdviceWordAll.HandleId, ConfigAdviceWordAll.LogPair);
			return list;
		}

		// Token: 0x0400033A RID: 826
		private const string DB = "db_advice.db";

		// Token: 0x0400033B RID: 827
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x0400033C RID: 828
		private const string TABLE = "AdviceWord";

		// Token: 0x0400033D RID: 829
		private const string COMMAND = "select BinData from `AdviceWord`";

		// Token: 0x0400033E RID: 830
		private const string KEY_PREFIX = "AdviceWordAll";

		// Token: 0x0400033F RID: 831
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000340 RID: 832
		private static int HandleId;
	}
}
