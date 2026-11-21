using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BC RID: 700
	public class ConfigExternalSourceSettingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600106D RID: 4205 RVA: 0x000B9D0C File Offset: 0x000B7F0C
		static ConfigExternalSourceSettingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExternalSourceSettingById.CreateStaticDefaultValue), new Action(ConfigExternalSourceSettingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000B9D2C File Offset: 0x000B7F2C
		public static void CreateStaticDefaultValue()
		{
			ConfigExternalSourceSettingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExternalSourceSettingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_plot_audio.db"),
				new ValueTuple<string, object>("文件", "j.剧情语音.xlsx"),
				new ValueTuple<string, object>("表名", "ExternalSourceSetting"),
				new ValueTuple<string, object>("语句", "select BinData from `ExternalSourceSetting` where Id=?")
			});
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000B9DAB File Offset: 0x000B7FAB
		public static void ResetStaticDefaultValue()
		{
			ConfigExternalSourceSettingById.LogPair = null;
			ConfigExternalSourceSettingById.HandleId = 0;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x000B9DB9 File Offset: 0x000B7FB9
		public static void Init()
		{
			ConfigExternalSourceSettingById.HandleId = ConfigCommon.InitDataStatement(ConfigExternalSourceSettingById.HandleId, "db_plot_audio.db", "select BinData from `ExternalSourceSetting` where Id=?");
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000B9DD4 File Offset: 0x000B7FD4
		public static ExternalSourceSetting? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExternalSourceSettingById.HandleId, ConfigExternalSourceSettingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ExternalSourceSettingById#" + p0Id);
				if (configBuffer != null)
				{
					return new ExternalSourceSetting?(ExternalSourceSetting.GetRootAsExternalSourceSetting(configBuffer));
				}
			}
			ConfigExternalSourceSettingById.LogPair.Clear();
			ConfigExternalSourceSettingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigExternalSourceSettingById.HandleId, 1, p0Id, ConfigExternalSourceSettingById.LogPair) || ConfigCommon.Step(ConfigExternalSourceSettingById.HandleId, true, ConfigExternalSourceSettingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExternalSourceSettingById.HandleId, ConfigExternalSourceSettingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExternalSourceSettingById.HandleId, 0, ConfigExternalSourceSettingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExternalSourceSettingById.HandleId, ConfigExternalSourceSettingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExternalSourceSetting rootAsExternalSourceSetting = ExternalSourceSetting.GetRootAsExternalSourceSetting(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ExternalSourceSettingById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExternalSourceSettingById.HandleId, ConfigExternalSourceSettingById.LogPair);
			return new ExternalSourceSetting?(rootAsExternalSourceSetting);
		}

		// Token: 0x04001308 RID: 4872
		private const string DB = "db_plot_audio.db";

		// Token: 0x04001309 RID: 4873
		private const string FILE = "j.剧情语音.xlsx";

		// Token: 0x0400130A RID: 4874
		private const string TABLE = "ExternalSourceSetting";

		// Token: 0x0400130B RID: 4875
		private const string COMMAND = "select BinData from `ExternalSourceSetting` where Id=?";

		// Token: 0x0400130C RID: 4876
		private const string KEY_PREFIX = "ExternalSourceSettingById";

		// Token: 0x0400130D RID: 4877
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400130E RID: 4878
		private static int HandleId;
	}
}
