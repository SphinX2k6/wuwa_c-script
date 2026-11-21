using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000278 RID: 632
	public class ConfigElementReactionMatrixAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ED4 RID: 3796 RVA: 0x000B0C84 File Offset: 0x000AEE84
		static ConfigElementReactionMatrixAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementReactionMatrixAll.CreateStaticDefaultValue), new Action(ConfigElementReactionMatrixAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000B0CA4 File Offset: 0x000AEEA4
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

		// Token: 0x06000ED6 RID: 3798 RVA: 0x000B0D23 File Offset: 0x000AEF23
		public static void ResetStaticDefaultValue()
		{
			ConfigElementReactionMatrixAll.LogPair = null;
			ConfigElementReactionMatrixAll.HandleId = 0;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x000B0D31 File Offset: 0x000AEF31
		public static void Init()
		{
			ConfigElementReactionMatrixAll.HandleId = ConfigCommon.InitDataStatement(ConfigElementReactionMatrixAll.HandleId, "db_element_info.db", "select BinData from `ElementReactionMatrix`");
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000B0D4C File Offset: 0x000AEF4C
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

		// Token: 0x0400112C RID: 4396
		private const string DB = "db_element_info.db";

		// Token: 0x0400112D RID: 4397
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x0400112E RID: 4398
		private const string TABLE = "ElementReactionMatrix";

		// Token: 0x0400112F RID: 4399
		private const string COMMAND = "select BinData from `ElementReactionMatrix`";

		// Token: 0x04001130 RID: 4400
		private const string KEY_PREFIX = "ElementReactionMatrixAll";

		// Token: 0x04001131 RID: 4401
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001132 RID: 4402
		private static int HandleId;
	}
}
