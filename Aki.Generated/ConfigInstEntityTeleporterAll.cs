using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000462 RID: 1122
	public class ConfigInstEntityTeleporterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A56 RID: 6742 RVA: 0x000F1EC0 File Offset: 0x000F00C0
		static ConfigInstEntityTeleporterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInstEntityTeleporterAll.CreateStaticDefaultValue), new Action(ConfigInstEntityTeleporterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000F1EE0 File Offset: 0x000F00E0
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

		// Token: 0x06001A58 RID: 6744 RVA: 0x000F1F5F File Offset: 0x000F015F
		public static void ResetStaticDefaultValue()
		{
			ConfigInstEntityTeleporterAll.LogPair = null;
			ConfigInstEntityTeleporterAll.HandleId = 0;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x000F1F6D File Offset: 0x000F016D
		public static void Init()
		{
			ConfigInstEntityTeleporterAll.HandleId = ConfigCommon.InitDataStatement(ConfigInstEntityTeleporterAll.HandleId, "db_teleporter.db", "select BinData from `InstEntityTeleporter`");
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000F1F88 File Offset: 0x000F0188
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

		// Token: 0x04001E92 RID: 7826
		private const string DB = "db_teleporter.db";

		// Token: 0x04001E93 RID: 7827
		private const string FILE = "c.传送.xlsx";

		// Token: 0x04001E94 RID: 7828
		private const string TABLE = "InstEntityTeleporter";

		// Token: 0x04001E95 RID: 7829
		private const string COMMAND = "select BinData from `InstEntityTeleporter`";

		// Token: 0x04001E96 RID: 7830
		private const string KEY_PREFIX = "InstEntityTeleporterAll";

		// Token: 0x04001E97 RID: 7831
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E98 RID: 7832
		private static int HandleId;
	}
}
