using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064C RID: 1612
	public class ConfigPackageCapacityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025D8 RID: 9688 RVA: 0x001331E8 File Offset: 0x001313E8
		static ConfigPackageCapacityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPackageCapacityAll.CreateStaticDefaultValue), new Action(ConfigPackageCapacityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00133208 File Offset: 0x00131408
		public static void CreateStaticDefaultValue()
		{
			ConfigPackageCapacityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPackageCapacityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bag.db"),
				new ValueTuple<string, object>("文件", "b.背包.xlsx"),
				new ValueTuple<string, object>("表名", "PackageCapacity"),
				new ValueTuple<string, object>("语句", "select BinData from `PackageCapacity`")
			});
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00133287 File Offset: 0x00131487
		public static void ResetStaticDefaultValue()
		{
			ConfigPackageCapacityAll.LogPair = null;
			ConfigPackageCapacityAll.HandleId = 0;
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00133295 File Offset: 0x00131495
		public static void Init()
		{
			ConfigPackageCapacityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPackageCapacityAll.HandleId, "db_bag.db", "select BinData from `PackageCapacity`");
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x001332B0 File Offset: 0x001314B0
		[NullableContext(2)]
		public static IReadOnlyList<PackageCapacity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPackageCapacityAll.HandleId, ConfigPackageCapacityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PackageCapacity> readOnlyList = (IReadOnlyList<PackageCapacity>)ConfigCommon.GetConfig("PackageCapacityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PackageCapacity> list = new List<PackageCapacity>();
			while (ConfigCommon.Step(ConfigPackageCapacityAll.HandleId, false, ConfigPackageCapacityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPackageCapacityAll.HandleId, 0, ConfigPackageCapacityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPackageCapacityAll.HandleId, ConfigPackageCapacityAll.LogPair);
					return null;
				}
				PackageCapacity rootAsPackageCapacity = PackageCapacity.GetRootAsPackageCapacity(new ByteBuffer(item2));
				list.Add(rootAsPackageCapacity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PackageCapacityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPackageCapacityAll.HandleId, ConfigPackageCapacityAll.LogPair);
			return list;
		}

		// Token: 0x04002BFA RID: 11258
		private const string DB = "db_bag.db";

		// Token: 0x04002BFB RID: 11259
		private const string FILE = "b.背包.xlsx";

		// Token: 0x04002BFC RID: 11260
		private const string TABLE = "PackageCapacity";

		// Token: 0x04002BFD RID: 11261
		private const string COMMAND = "select BinData from `PackageCapacity`";

		// Token: 0x04002BFE RID: 11262
		private const string KEY_PREFIX = "PackageCapacityAll";

		// Token: 0x04002BFF RID: 11263
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C00 RID: 11264
		private static int HandleId;
	}
}
