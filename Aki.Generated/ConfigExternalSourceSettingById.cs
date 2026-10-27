using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A8 RID: 680
	public class ConfigExternalSourceSettingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FF5 RID: 4085 RVA: 0x000B3A48 File Offset: 0x000B1C48
		static ConfigExternalSourceSettingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExternalSourceSettingById.CreateStaticDefaultValue), new Action(ConfigExternalSourceSettingById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x000B3A68 File Offset: 0x000B1C68
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

		// Token: 0x06000FF7 RID: 4087 RVA: 0x000B3AE7 File Offset: 0x000B1CE7
		public static void ResetStaticDefaultValue()
		{
			ConfigExternalSourceSettingById.LogPair = null;
			ConfigExternalSourceSettingById.HandleId = 0;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000B3AF5 File Offset: 0x000B1CF5
		public static void Init()
		{
			ConfigExternalSourceSettingById.HandleId = ConfigCommon.InitDataStatement(ConfigExternalSourceSettingById.HandleId, "db_plot_audio.db", "select BinData from `ExternalSourceSetting` where Id=?");
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000B3B10 File Offset: 0x000B1D10
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

		// Token: 0x0400127C RID: 4732
		private const string DB = "db_plot_audio.db";

		// Token: 0x0400127D RID: 4733
		private const string FILE = "j.剧情语音.xlsx";

		// Token: 0x0400127E RID: 4734
		private const string TABLE = "ExternalSourceSetting";

		// Token: 0x0400127F RID: 4735
		private const string COMMAND = "select BinData from `ExternalSourceSetting` where Id=?";

		// Token: 0x04001280 RID: 4736
		private const string KEY_PREFIX = "ExternalSourceSettingById";

		// Token: 0x04001281 RID: 4737
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001282 RID: 4738
		private static int HandleId;
	}
}
