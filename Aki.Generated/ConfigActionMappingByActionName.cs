using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200003C RID: 60
	public class ConfigActionMappingByActionName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00061ABB File Offset: 0x0005FCBB
		static ConfigActionMappingByActionName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActionMappingByActionName.CreateStaticDefaultValue), new Action(ConfigActionMappingByActionName.ResetStaticDefaultValue));
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00061ADC File Offset: 0x0005FCDC
		public static void CreateStaticDefaultValue()
		{
			ConfigActionMappingByActionName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActionMappingByActionName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "ActionMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `ActionMapping` where ActionName=?")
			});
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00061B5B File Offset: 0x0005FD5B
		public static void ResetStaticDefaultValue()
		{
			ConfigActionMappingByActionName.LogPair = null;
			ConfigActionMappingByActionName.HandleId = 0;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00061B69 File Offset: 0x0005FD69
		public static void Init()
		{
			ConfigActionMappingByActionName.HandleId = ConfigCommon.InitDataStatement(ConfigActionMappingByActionName.HandleId, "db_input_settings.db", "select BinData from `ActionMapping` where ActionName=?");
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00061B84 File Offset: 0x0005FD84
		public static ActionMapping? GetConfig(string p0ActionName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActionMappingByActionName.HandleId, ConfigActionMappingByActionName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ActionMappingByActionName#" + p0ActionName);
				if (configBuffer != null)
				{
					return new ActionMapping?(ActionMapping.GetRootAsActionMapping(configBuffer));
				}
			}
			ConfigActionMappingByActionName.LogPair.Clear();
			ConfigActionMappingByActionName.LogPair.Add(new ValueTuple<string, object>("ActionName", p0ActionName));
			if (!ConfigCommon.BindString(ConfigActionMappingByActionName.HandleId, 1, p0ActionName, ConfigActionMappingByActionName.LogPair) || ConfigCommon.Step(ConfigActionMappingByActionName.HandleId, true, ConfigActionMappingByActionName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActionMappingByActionName.HandleId, ConfigActionMappingByActionName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActionMappingByActionName.HandleId, 0, ConfigActionMappingByActionName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActionMappingByActionName.HandleId, ConfigActionMappingByActionName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActionMapping rootAsActionMapping = ActionMapping.GetRootAsActionMapping(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ActionMappingByActionName#" + p0ActionName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActionMappingByActionName.HandleId, ConfigActionMappingByActionName.LogPair);
			return new ActionMapping?(rootAsActionMapping);
		}

		// Token: 0x04000188 RID: 392
		private const string DB = "db_input_settings.db";

		// Token: 0x04000189 RID: 393
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x0400018A RID: 394
		private const string TABLE = "ActionMapping";

		// Token: 0x0400018B RID: 395
		private const string COMMAND = "select BinData from `ActionMapping` where ActionName=?";

		// Token: 0x0400018C RID: 396
		private const string KEY_PREFIX = "ActionMappingByActionName";

		// Token: 0x0400018D RID: 397
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400018E RID: 398
		private static int HandleId;
	}
}
