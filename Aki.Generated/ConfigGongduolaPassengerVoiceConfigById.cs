using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AA RID: 938
	public class ConfigGongduolaPassengerVoiceConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001603 RID: 5635 RVA: 0x000D5EF0 File Offset: 0x000D40F0
		static ConfigGongduolaPassengerVoiceConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGongduolaPassengerVoiceConfigById.CreateStaticDefaultValue), new Action(ConfigGongduolaPassengerVoiceConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000D5F10 File Offset: 0x000D4110
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

		// Token: 0x06001605 RID: 5637 RVA: 0x000D5F8F File Offset: 0x000D418F
		public static void ResetStaticDefaultValue()
		{
			ConfigGongduolaPassengerVoiceConfigById.LogPair = null;
			ConfigGongduolaPassengerVoiceConfigById.HandleId = 0;
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x000D5F9D File Offset: 0x000D419D
		public static void Init()
		{
			ConfigGongduolaPassengerVoiceConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGongduolaPassengerVoiceConfigById.HandleId, "db_gongduolapassengervoiceconfig.db", "select BinData from `GongduolaPassengerVoiceConfig` where Id=?");
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000D5FB8 File Offset: 0x000D41B8
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

		// Token: 0x0400198A RID: 6538
		private const string DB = "db_gongduolapassengervoiceconfig.db";

		// Token: 0x0400198B RID: 6539
		private const string FILE = "k.可视化编辑/c.Csv/g.贡多拉共乘角色语音配置/*.csv*";

		// Token: 0x0400198C RID: 6540
		private const string TABLE = "GongduolaPassengerVoiceConfig";

		// Token: 0x0400198D RID: 6541
		private const string COMMAND = "select BinData from `GongduolaPassengerVoiceConfig` where Id=?";

		// Token: 0x0400198E RID: 6542
		private const string KEY_PREFIX = "GongduolaPassengerVoiceConfigById";

		// Token: 0x0400198F RID: 6543
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001990 RID: 6544
		private static int HandleId;
	}
}
