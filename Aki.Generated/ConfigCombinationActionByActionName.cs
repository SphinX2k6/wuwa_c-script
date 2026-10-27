using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000179 RID: 377
	public class ConfigCombinationActionByActionName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x0008B683 File Offset: 0x00089883
		static ConfigCombinationActionByActionName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationActionByActionName.CreateStaticDefaultValue), new Action(ConfigCombinationActionByActionName.ResetStaticDefaultValue));
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0008B6A4 File Offset: 0x000898A4
		public static void CreateStaticDefaultValue()
		{
			ConfigCombinationActionByActionName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCombinationActionByActionName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "CombinationAction"),
				new ValueTuple<string, object>("语句", "select BinData from `CombinationAction` where ActionName=?")
			});
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0008B723 File Offset: 0x00089923
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationActionByActionName.LogPair = null;
			ConfigCombinationActionByActionName.HandleId = 0;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0008B731 File Offset: 0x00089931
		public static void Init()
		{
			ConfigCombinationActionByActionName.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationActionByActionName.HandleId, "db_input_settings.db", "select BinData from `CombinationAction` where ActionName=?");
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0008B74C File Offset: 0x0008994C
		public static CombinationAction? GetConfig(string p0ActionName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCombinationActionByActionName.HandleId, ConfigCombinationActionByActionName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("CombinationActionByActionName#" + p0ActionName);
				if (configBuffer != null)
				{
					return new CombinationAction?(CombinationAction.GetRootAsCombinationAction(configBuffer));
				}
			}
			ConfigCombinationActionByActionName.LogPair.Clear();
			ConfigCombinationActionByActionName.LogPair.Add(new ValueTuple<string, object>("ActionName", p0ActionName));
			if (!ConfigCommon.BindString(ConfigCombinationActionByActionName.HandleId, 1, p0ActionName, ConfigCombinationActionByActionName.LogPair) || ConfigCommon.Step(ConfigCombinationActionByActionName.HandleId, true, ConfigCombinationActionByActionName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCombinationActionByActionName.HandleId, ConfigCombinationActionByActionName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCombinationActionByActionName.HandleId, 0, ConfigCombinationActionByActionName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCombinationActionByActionName.HandleId, ConfigCombinationActionByActionName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CombinationAction rootAsCombinationAction = CombinationAction.GetRootAsCombinationAction(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("CombinationActionByActionName#" + p0ActionName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCombinationActionByActionName.HandleId, ConfigCombinationActionByActionName.LogPair);
			return new CombinationAction?(rootAsCombinationAction);
		}

		// Token: 0x04000A33 RID: 2611
		private const string DB = "db_input_settings.db";

		// Token: 0x04000A34 RID: 2612
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000A35 RID: 2613
		private const string TABLE = "CombinationAction";

		// Token: 0x04000A36 RID: 2614
		private const string COMMAND = "select BinData from `CombinationAction` where ActionName=?";

		// Token: 0x04000A37 RID: 2615
		private const string KEY_PREFIX = "CombinationActionByActionName";

		// Token: 0x04000A38 RID: 2616
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A39 RID: 2617
		private static int HandleId;
	}
}
