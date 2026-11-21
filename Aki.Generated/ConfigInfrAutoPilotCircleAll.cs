using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043D RID: 1085
	public class ConfigInfrAutoPilotCircleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x000ED2D8 File Offset: 0x000EB4D8
		static ConfigInfrAutoPilotCircleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrAutoPilotCircleAll.CreateStaticDefaultValue), new Action(ConfigInfrAutoPilotCircleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000ED2F8 File Offset: 0x000EB4F8
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

		// Token: 0x06001979 RID: 6521 RVA: 0x000ED377 File Offset: 0x000EB577
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleAll.LogPair = null;
			ConfigInfrAutoPilotCircleAll.HandleId = 0;
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000ED385 File Offset: 0x000EB585
		public static void Init()
		{
			ConfigInfrAutoPilotCircleAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrAutoPilotCircleAll.HandleId, "db_infrastructure.db", "select BinData from `InfrAutoPilotCircle`");
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x000ED3A0 File Offset: 0x000EB5A0
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

		// Token: 0x04001D8F RID: 7567
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D90 RID: 7568
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D91 RID: 7569
		private const string TABLE = "InfrAutoPilotCircle";

		// Token: 0x04001D92 RID: 7570
		private const string COMMAND = "select BinData from `InfrAutoPilotCircle`";

		// Token: 0x04001D93 RID: 7571
		private const string KEY_PREFIX = "InfrAutoPilotCircleAll";

		// Token: 0x04001D94 RID: 7572
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D95 RID: 7573
		private static int HandleId;
	}
}
