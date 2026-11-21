using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009D RID: 157
	public class ConfigAlertAreaConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003AE RID: 942 RVA: 0x00071E14 File Offset: 0x00070014
		static ConfigAlertAreaConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAlertAreaConfigById.CreateStaticDefaultValue), new Action(ConfigAlertAreaConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00071E34 File Offset: 0x00070034
		public static void CreateStaticDefaultValue()
		{
			ConfigAlertAreaConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAlertAreaConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_alertareaconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/j.警戒区域配置/*.csv*"),
				new ValueTuple<string, object>("表名", "AlertAreaConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `AlertAreaConfig` where Id=?")
			});
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00071EB3 File Offset: 0x000700B3
		public static void ResetStaticDefaultValue()
		{
			ConfigAlertAreaConfigById.LogPair = null;
			ConfigAlertAreaConfigById.HandleId = 0;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00071EC1 File Offset: 0x000700C1
		public static void Init()
		{
			ConfigAlertAreaConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAlertAreaConfigById.HandleId, "db_alertareaconfig.db", "select BinData from `AlertAreaConfig` where Id=?");
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00071EDC File Offset: 0x000700DC
		public static AlertAreaConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAlertAreaConfigById.HandleId, ConfigAlertAreaConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AlertAreaConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AlertAreaConfig?(AlertAreaConfig.GetRootAsAlertAreaConfig(configBuffer));
				}
			}
			ConfigAlertAreaConfigById.LogPair.Clear();
			ConfigAlertAreaConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAlertAreaConfigById.HandleId, 1, p0Id, ConfigAlertAreaConfigById.LogPair) || ConfigCommon.Step(ConfigAlertAreaConfigById.HandleId, true, ConfigAlertAreaConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAlertAreaConfigById.HandleId, ConfigAlertAreaConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAlertAreaConfigById.HandleId, 0, ConfigAlertAreaConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAlertAreaConfigById.HandleId, ConfigAlertAreaConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AlertAreaConfig rootAsAlertAreaConfig = AlertAreaConfig.GetRootAsAlertAreaConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AlertAreaConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAlertAreaConfigById.HandleId, ConfigAlertAreaConfigById.LogPair);
			return new AlertAreaConfig?(rootAsAlertAreaConfig);
		}

		// Token: 0x0400042F RID: 1071
		private const string DB = "db_alertareaconfig.db";

		// Token: 0x04000430 RID: 1072
		private const string FILE = "k.可视化编辑/c.Csv/j.警戒区域配置/*.csv*";

		// Token: 0x04000431 RID: 1073
		private const string TABLE = "AlertAreaConfig";

		// Token: 0x04000432 RID: 1074
		private const string COMMAND = "select BinData from `AlertAreaConfig` where Id=?";

		// Token: 0x04000433 RID: 1075
		private const string KEY_PREFIX = "AlertAreaConfigById";

		// Token: 0x04000434 RID: 1076
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000435 RID: 1077
		private static int HandleId;
	}
}
