using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000427 RID: 1063
	public class ConfigInfrAutoPilotCircleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018F3 RID: 6387 RVA: 0x000E6B84 File Offset: 0x000E4D84
		static ConfigInfrAutoPilotCircleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrAutoPilotCircleAll.CreateStaticDefaultValue), new Action(ConfigInfrAutoPilotCircleAll.ResetStaticDefaultValue));
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000E6BA4 File Offset: 0x000E4DA4
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrAutoPilotCircleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrAutoPilotCircle"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrAutoPilotCircle`")
			});
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x000E6C23 File Offset: 0x000E4E23
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleAll.LogPair = null;
			ConfigInfrAutoPilotCircleAll.HandleId = 0;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x000E6C31 File Offset: 0x000E4E31
		public static void Init()
		{
			ConfigInfrAutoPilotCircleAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrAutoPilotCircleAll.HandleId, "db_infrastructure.db", "select BinData from `InfrAutoPilotCircle`");
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x000E6C4C File Offset: 0x000E4E4C
		[NullableContext(2)]
		public static IReadOnlyList<InfrAutoPilotCircle> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrAutoPilotCircleAll.HandleId, ConfigInfrAutoPilotCircleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrAutoPilotCircle> readOnlyList = (IReadOnlyList<InfrAutoPilotCircle>)ConfigCommon.GetConfig("InfrAutoPilotCircleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrAutoPilotCircle> list = new List<InfrAutoPilotCircle>();
			while (ConfigCommon.Step(ConfigInfrAutoPilotCircleAll.HandleId, false, ConfigInfrAutoPilotCircleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrAutoPilotCircleAll.HandleId, 0, ConfigInfrAutoPilotCircleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrAutoPilotCircleAll.HandleId, ConfigInfrAutoPilotCircleAll.LogPair);
					return null;
				}
				InfrAutoPilotCircle rootAsInfrAutoPilotCircle = InfrAutoPilotCircle.GetRootAsInfrAutoPilotCircle(new ByteBuffer(item2));
				list.Add(rootAsInfrAutoPilotCircle);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrAutoPilotCircleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrAutoPilotCircleAll.HandleId, ConfigInfrAutoPilotCircleAll.LogPair);
			return list;
		}

		// Token: 0x04001CF5 RID: 7413
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CF6 RID: 7414
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001CF7 RID: 7415
		private const string TABLE = "InfrAutoPilotCircle";

		// Token: 0x04001CF8 RID: 7416
		private const string COMMAND = "select BinData from `InfrAutoPilotCircle`";

		// Token: 0x04001CF9 RID: 7417
		private const string KEY_PREFIX = "InfrAutoPilotCircleAll";

		// Token: 0x04001CFA RID: 7418
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CFB RID: 7419
		private static int HandleId;
	}
}
