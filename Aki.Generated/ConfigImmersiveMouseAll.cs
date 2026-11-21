using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000430 RID: 1072
	public class ConfigImmersiveMouseAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001929 RID: 6441 RVA: 0x000EB905 File Offset: 0x000E9B05
		static ConfigImmersiveMouseAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigImmersiveMouseAll.CreateStaticDefaultValue), new Action(ConfigImmersiveMouseAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000EB924 File Offset: 0x000E9B24
		public static void CreateStaticDefaultValue()
		{
			ConfigImmersiveMouseAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigImmersiveMouseAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "ImmersiveMouse"),
				new ValueTuple<string, object>("语句", "select BinData from `ImmersiveMouse`")
			});
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x000EB9A3 File Offset: 0x000E9BA3
		public static void ResetStaticDefaultValue()
		{
			ConfigImmersiveMouseAll.LogPair = null;
			ConfigImmersiveMouseAll.HandleId = 0;
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x000EB9B1 File Offset: 0x000E9BB1
		public static void Init()
		{
			ConfigImmersiveMouseAll.HandleId = ConfigCommon.InitDataStatement(ConfigImmersiveMouseAll.HandleId, "db_input_settings.db", "select BinData from `ImmersiveMouse`");
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x000EB9CC File Offset: 0x000E9BCC
		[NullableContext(2)]
		public static IReadOnlyList<ImmersiveMouse> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigImmersiveMouseAll.HandleId, ConfigImmersiveMouseAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ImmersiveMouse> readOnlyList = (IReadOnlyList<ImmersiveMouse>)ConfigCommon.GetConfig("ImmersiveMouseAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ImmersiveMouse> list = new List<ImmersiveMouse>();
			while (ConfigCommon.Step(ConfigImmersiveMouseAll.HandleId, false, ConfigImmersiveMouseAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigImmersiveMouseAll.HandleId, 0, ConfigImmersiveMouseAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigImmersiveMouseAll.HandleId, ConfigImmersiveMouseAll.LogPair);
					return null;
				}
				ImmersiveMouse rootAsImmersiveMouse = ImmersiveMouse.GetRootAsImmersiveMouse(new ByteBuffer(item2));
				list.Add(rootAsImmersiveMouse);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ImmersiveMouseAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigImmersiveMouseAll.HandleId, ConfigImmersiveMouseAll.LogPair);
			return list;
		}

		// Token: 0x04001D34 RID: 7476
		private const string DB = "db_input_settings.db";

		// Token: 0x04001D35 RID: 7477
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04001D36 RID: 7478
		private const string TABLE = "ImmersiveMouse";

		// Token: 0x04001D37 RID: 7479
		private const string COMMAND = "select BinData from `ImmersiveMouse`";

		// Token: 0x04001D38 RID: 7480
		private const string KEY_PREFIX = "ImmersiveMouseAll";

		// Token: 0x04001D39 RID: 7481
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D3A RID: 7482
		private static int HandleId;
	}
}
