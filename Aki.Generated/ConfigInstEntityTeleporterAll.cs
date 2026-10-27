using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044C RID: 1100
	public class ConfigInstEntityTeleporterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x000EB76C File Offset: 0x000E996C
		static ConfigInstEntityTeleporterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstEntityTeleporterAll.CreateStaticDefaultValue), new Action(ConfigInstEntityTeleporterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x000EB78C File Offset: 0x000E998C
		public static void CreateStaticDefaultValue()
		{
			ConfigInstEntityTeleporterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInstEntityTeleporterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teleporter.db"),
				new ValueTuple<string, object>("文件", "c.传送.xlsx"),
				new ValueTuple<string, object>("表名", "InstEntityTeleporter"),
				new ValueTuple<string, object>("语句", "select BinData from `InstEntityTeleporter`")
			});
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000EB80B File Offset: 0x000E9A0B
		public static void ResetStaticDefaultValue()
		{
			ConfigInstEntityTeleporterAll.LogPair = null;
			ConfigInstEntityTeleporterAll.HandleId = 0;
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x000EB819 File Offset: 0x000E9A19
		public static void Init()
		{
			ConfigInstEntityTeleporterAll.HandleId = ConfigCommon.InitDataStatement(ConfigInstEntityTeleporterAll.HandleId, "db_teleporter.db", "select BinData from `InstEntityTeleporter`");
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000EB834 File Offset: 0x000E9A34
		[NullableContext(2)]
		public static IReadOnlyList<InstEntityTeleporter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInstEntityTeleporterAll.HandleId, ConfigInstEntityTeleporterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InstEntityTeleporter> readOnlyList = (IReadOnlyList<InstEntityTeleporter>)ConfigCommon.GetConfig("InstEntityTeleporterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InstEntityTeleporter> list = new List<InstEntityTeleporter>();
			while (ConfigCommon.Step(ConfigInstEntityTeleporterAll.HandleId, false, ConfigInstEntityTeleporterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInstEntityTeleporterAll.HandleId, 0, ConfigInstEntityTeleporterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInstEntityTeleporterAll.HandleId, ConfigInstEntityTeleporterAll.LogPair);
					return null;
				}
				InstEntityTeleporter rootAsInstEntityTeleporter = InstEntityTeleporter.GetRootAsInstEntityTeleporter(new ByteBuffer(item2));
				list.Add(rootAsInstEntityTeleporter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InstEntityTeleporterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInstEntityTeleporterAll.HandleId, ConfigInstEntityTeleporterAll.LogPair);
			return list;
		}

		// Token: 0x04001DF8 RID: 7672
		private const string DB = "db_teleporter.db";

		// Token: 0x04001DF9 RID: 7673
		private const string FILE = "c.传送.xlsx";

		// Token: 0x04001DFA RID: 7674
		private const string TABLE = "InstEntityTeleporter";

		// Token: 0x04001DFB RID: 7675
		private const string COMMAND = "select BinData from `InstEntityTeleporter`";

		// Token: 0x04001DFC RID: 7676
		private const string KEY_PREFIX = "InstEntityTeleporterAll";

		// Token: 0x04001DFD RID: 7677
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DFE RID: 7678
		private static int HandleId;
	}
}
