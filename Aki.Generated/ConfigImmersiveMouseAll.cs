using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041A RID: 1050
	public class ConfigImmersiveMouseAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018A5 RID: 6309 RVA: 0x000E51B1 File Offset: 0x000E33B1
		static ConfigImmersiveMouseAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigImmersiveMouseAll.CreateStaticDefaultValue), new Action(ConfigImmersiveMouseAll.ResetStaticDefaultValue));
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x000E51D0 File Offset: 0x000E33D0
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

		// Token: 0x060018A7 RID: 6311 RVA: 0x000E524F File Offset: 0x000E344F
		public static void ResetStaticDefaultValue()
		{
			ConfigImmersiveMouseAll.LogPair = null;
			ConfigImmersiveMouseAll.HandleId = 0;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000E525D File Offset: 0x000E345D
		public static void Init()
		{
			ConfigImmersiveMouseAll.HandleId = ConfigCommon.InitDataStatement(ConfigImmersiveMouseAll.HandleId, "db_input_settings.db", "select BinData from `ImmersiveMouse`");
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000E5278 File Offset: 0x000E3478
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

		// Token: 0x04001C9A RID: 7322
		private const string DB = "db_input_settings.db";

		// Token: 0x04001C9B RID: 7323
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04001C9C RID: 7324
		private const string TABLE = "ImmersiveMouse";

		// Token: 0x04001C9D RID: 7325
		private const string COMMAND = "select BinData from `ImmersiveMouse`";

		// Token: 0x04001C9E RID: 7326
		private const string KEY_PREFIX = "ImmersiveMouseAll";

		// Token: 0x04001C9F RID: 7327
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CA0 RID: 7328
		private static int HandleId;
	}
}
