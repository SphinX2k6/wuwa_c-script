using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C0 RID: 960
	public class ConfigGongduolaPassengerVoiceConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001687 RID: 5767 RVA: 0x000DC644 File Offset: 0x000DA844
		static ConfigGongduolaPassengerVoiceConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGongduolaPassengerVoiceConfigById.CreateStaticDefaultValue), new Action(ConfigGongduolaPassengerVoiceConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000DC664 File Offset: 0x000DA864
		public static void CreateStaticDefaultValue()
		{
			ConfigGongduolaPassengerVoiceConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGongduolaPassengerVoiceConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gongduolapassengervoiceconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.贡多拉共乘角色语音配置/*.csv*"),
				new ValueTuple<string, object>("表名", "GongduolaPassengerVoiceConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GongduolaPassengerVoiceConfig` where Id=?")
			});
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x000DC6E3 File Offset: 0x000DA8E3
		public static void ResetStaticDefaultValue()
		{
			ConfigGongduolaPassengerVoiceConfigById.LogPair = null;
			ConfigGongduolaPassengerVoiceConfigById.HandleId = 0;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000DC6F1 File Offset: 0x000DA8F1
		public static void Init()
		{
			ConfigGongduolaPassengerVoiceConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGongduolaPassengerVoiceConfigById.HandleId, "db_gongduolapassengervoiceconfig.db", "select BinData from `GongduolaPassengerVoiceConfig` where Id=?");
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x000DC70C File Offset: 0x000DA90C
		public static GongduolaPassengerVoiceConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGongduolaPassengerVoiceConfigById.HandleId, ConfigGongduolaPassengerVoiceConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GongduolaPassengerVoiceConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GongduolaPassengerVoiceConfig?(GongduolaPassengerVoiceConfig.GetRootAsGongduolaPassengerVoiceConfig(configBuffer));
				}
			}
			ConfigGongduolaPassengerVoiceConfigById.LogPair.Clear();
			ConfigGongduolaPassengerVoiceConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGongduolaPassengerVoiceConfigById.HandleId, 1, p0Id, ConfigGongduolaPassengerVoiceConfigById.LogPair) || ConfigCommon.Step(ConfigGongduolaPassengerVoiceConfigById.HandleId, true, ConfigGongduolaPassengerVoiceConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigById.HandleId, ConfigGongduolaPassengerVoiceConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGongduolaPassengerVoiceConfigById.HandleId, 0, ConfigGongduolaPassengerVoiceConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigById.HandleId, ConfigGongduolaPassengerVoiceConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GongduolaPassengerVoiceConfig rootAsGongduolaPassengerVoiceConfig = GongduolaPassengerVoiceConfig.GetRootAsGongduolaPassengerVoiceConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GongduolaPassengerVoiceConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGongduolaPassengerVoiceConfigById.HandleId, ConfigGongduolaPassengerVoiceConfigById.LogPair);
			return new GongduolaPassengerVoiceConfig?(rootAsGongduolaPassengerVoiceConfig);
		}

		// Token: 0x04001A24 RID: 6692
		private const string DB = "db_gongduolapassengervoiceconfig.db";

		// Token: 0x04001A25 RID: 6693
		private const string FILE = "k.可视化编辑/c.Csv/g.贡多拉共乘角色语音配置/*.csv*";

		// Token: 0x04001A26 RID: 6694
		private const string TABLE = "GongduolaPassengerVoiceConfig";

		// Token: 0x04001A27 RID: 6695
		private const string COMMAND = "select BinData from `GongduolaPassengerVoiceConfig` where Id=?";

		// Token: 0x04001A28 RID: 6696
		private const string KEY_PREFIX = "GongduolaPassengerVoiceConfigById";

		// Token: 0x04001A29 RID: 6697
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A2A RID: 6698
		private static int HandleId;
	}
}
