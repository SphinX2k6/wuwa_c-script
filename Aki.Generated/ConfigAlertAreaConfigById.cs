using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000095 RID: 149
	public class ConfigAlertAreaConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600037E RID: 894 RVA: 0x0006D560 File Offset: 0x0006B760
		static ConfigAlertAreaConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAlertAreaConfigById.CreateStaticDefaultValue), new Action(ConfigAlertAreaConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0006D580 File Offset: 0x0006B780
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

		// Token: 0x06000380 RID: 896 RVA: 0x0006D5FF File Offset: 0x0006B7FF
		public static void ResetStaticDefaultValue()
		{
			ConfigAlertAreaConfigById.LogPair = null;
			ConfigAlertAreaConfigById.HandleId = 0;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0006D60D File Offset: 0x0006B80D
		public static void Init()
		{
			ConfigAlertAreaConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAlertAreaConfigById.HandleId, "db_alertareaconfig.db", "select BinData from `AlertAreaConfig` where Id=?");
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0006D628 File Offset: 0x0006B828
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

		// Token: 0x040003F7 RID: 1015
		private const string DB = "db_alertareaconfig.db";

		// Token: 0x040003F8 RID: 1016
		private const string FILE = "k.可视化编辑/c.Csv/j.警戒区域配置/*.csv*";

		// Token: 0x040003F9 RID: 1017
		private const string TABLE = "AlertAreaConfig";

		// Token: 0x040003FA RID: 1018
		private const string COMMAND = "select BinData from `AlertAreaConfig` where Id=?";

		// Token: 0x040003FB RID: 1019
		private const string KEY_PREFIX = "AlertAreaConfigById";

		// Token: 0x040003FC RID: 1020
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003FD RID: 1021
		private static int HandleId;
	}
}
