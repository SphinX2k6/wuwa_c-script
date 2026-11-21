using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018B RID: 395
	public class ConfigCombinationActionByActionName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000943 RID: 2371 RVA: 0x000915BB File Offset: 0x0008F7BB
		static ConfigCombinationActionByActionName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCombinationActionByActionName.CreateStaticDefaultValue), new Action(ConfigCombinationActionByActionName.ResetStaticDefaultValue));
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000915DC File Offset: 0x0008F7DC
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

		// Token: 0x06000945 RID: 2373 RVA: 0x0009165B File Offset: 0x0008F85B
		public static void ResetStaticDefaultValue()
		{
			ConfigCombinationActionByActionName.LogPair = null;
			ConfigCombinationActionByActionName.HandleId = 0;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00091669 File Offset: 0x0008F869
		public static void Init()
		{
			ConfigCombinationActionByActionName.HandleId = ConfigCommon.InitDataStatement(ConfigCombinationActionByActionName.HandleId, "db_input_settings.db", "select BinData from `CombinationAction` where ActionName=?");
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00091684 File Offset: 0x0008F884
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

		// Token: 0x04000AB1 RID: 2737
		private const string DB = "db_input_settings.db";

		// Token: 0x04000AB2 RID: 2738
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04000AB3 RID: 2739
		private const string TABLE = "CombinationAction";

		// Token: 0x04000AB4 RID: 2740
		private const string COMMAND = "select BinData from `CombinationAction` where ActionName=?";

		// Token: 0x04000AB5 RID: 2741
		private const string KEY_PREFIX = "CombinationActionByActionName";

		// Token: 0x04000AB6 RID: 2742
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AB7 RID: 2743
		private static int HandleId;
	}
}
