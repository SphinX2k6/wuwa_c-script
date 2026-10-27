using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000634 RID: 1588
	public class ConfigPackageCapacityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002548 RID: 9544 RVA: 0x0012C76C File Offset: 0x0012A96C
		static ConfigPackageCapacityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPackageCapacityAll.CreateStaticDefaultValue), new Action(ConfigPackageCapacityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x0012C78C File Offset: 0x0012A98C
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

		// Token: 0x0600254A RID: 9546 RVA: 0x0012C80B File Offset: 0x0012AA0B
		public static void ResetStaticDefaultValue()
		{
			ConfigPackageCapacityAll.LogPair = null;
			ConfigPackageCapacityAll.HandleId = 0;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x0012C819 File Offset: 0x0012AA19
		public static void Init()
		{
			ConfigPackageCapacityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPackageCapacityAll.HandleId, "db_bag.db", "select BinData from `PackageCapacity`");
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x0012C834 File Offset: 0x0012AA34
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

		// Token: 0x04002B52 RID: 11090
		private const string DB = "db_bag.db";

		// Token: 0x04002B53 RID: 11091
		private const string FILE = "b.背包.xlsx";

		// Token: 0x04002B54 RID: 11092
		private const string TABLE = "PackageCapacity";

		// Token: 0x04002B55 RID: 11093
		private const string COMMAND = "select BinData from `PackageCapacity`";

		// Token: 0x04002B56 RID: 11094
		private const string KEY_PREFIX = "PackageCapacityAll";

		// Token: 0x04002B57 RID: 11095
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B58 RID: 11096
		private static int HandleId;
	}
}
