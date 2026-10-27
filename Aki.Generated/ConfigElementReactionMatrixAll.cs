using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000264 RID: 612
	public class ConfigElementReactionMatrixAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x000AA9C0 File Offset: 0x000A8BC0
		static ConfigElementReactionMatrixAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementReactionMatrixAll.CreateStaticDefaultValue), new Action(ConfigElementReactionMatrixAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000AA9E0 File Offset: 0x000A8BE0
		public static void CreateStaticDefaultValue()
		{
			ConfigElementReactionMatrixAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementReactionMatrixAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_element_info.db"),
				new ValueTuple<string, object>("文件", "y.元素属性.xlsx"),
				new ValueTuple<string, object>("表名", "ElementReactionMatrix"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementReactionMatrix`")
			});
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x000AAA5F File Offset: 0x000A8C5F
		public static void ResetStaticDefaultValue()
		{
			ConfigElementReactionMatrixAll.LogPair = null;
			ConfigElementReactionMatrixAll.HandleId = 0;
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000AAA6D File Offset: 0x000A8C6D
		public static void Init()
		{
			ConfigElementReactionMatrixAll.HandleId = ConfigCommon.InitDataStatement(ConfigElementReactionMatrixAll.HandleId, "db_element_info.db", "select BinData from `ElementReactionMatrix`");
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000AAA88 File Offset: 0x000A8C88
		[NullableContext(2)]
		public static IReadOnlyList<ElementReactionMatrix> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementReactionMatrixAll.HandleId, ConfigElementReactionMatrixAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ElementReactionMatrix> readOnlyList = (IReadOnlyList<ElementReactionMatrix>)ConfigCommon.GetConfig("ElementReactionMatrixAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ElementReactionMatrix> list = new List<ElementReactionMatrix>();
			while (ConfigCommon.Step(ConfigElementReactionMatrixAll.HandleId, false, ConfigElementReactionMatrixAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementReactionMatrixAll.HandleId, 0, ConfigElementReactionMatrixAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigElementReactionMatrixAll.HandleId, ConfigElementReactionMatrixAll.LogPair);
					return null;
				}
				ElementReactionMatrix rootAsElementReactionMatrix = ElementReactionMatrix.GetRootAsElementReactionMatrix(new ByteBuffer(item2));
				list.Add(rootAsElementReactionMatrix);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ElementReactionMatrixAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigElementReactionMatrixAll.HandleId, ConfigElementReactionMatrixAll.LogPair);
			return list;
		}

		// Token: 0x040010A0 RID: 4256
		private const string DB = "db_element_info.db";

		// Token: 0x040010A1 RID: 4257
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x040010A2 RID: 4258
		private const string TABLE = "ElementReactionMatrix";

		// Token: 0x040010A3 RID: 4259
		private const string COMMAND = "select BinData from `ElementReactionMatrix`";

		// Token: 0x040010A4 RID: 4260
		private const string KEY_PREFIX = "ElementReactionMatrixAll";

		// Token: 0x040010A5 RID: 4261
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010A6 RID: 4262
		private static int HandleId;
	}
}
