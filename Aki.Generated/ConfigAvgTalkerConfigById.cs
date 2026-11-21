using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CC RID: 204
	public class ConfigAvgTalkerConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x00078660 File Offset: 0x00076860
		static ConfigAvgTalkerConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgTalkerConfigById.CreateStaticDefaultValue), new Action(ConfigAvgTalkerConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00078680 File Offset: 0x00076880
		public static void CreateStaticDefaultValue()
		{
			ConfigAvgTalkerConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvgTalkerConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avgtalkerconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.AVG对话人配置/*.csv*"),
				new ValueTuple<string, object>("表名", "AvgTalkerConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `AvgTalkerConfig` where Id=?")
			});
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000786FF File Offset: 0x000768FF
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgTalkerConfigById.LogPair = null;
			ConfigAvgTalkerConfigById.HandleId = 0;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0007870D File Offset: 0x0007690D
		public static void Init()
		{
			ConfigAvgTalkerConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAvgTalkerConfigById.HandleId, "db_avgtalkerconfig.db", "select BinData from `AvgTalkerConfig` where Id=?");
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00078728 File Offset: 0x00076928
		public static AvgTalkerConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvgTalkerConfigById.HandleId, ConfigAvgTalkerConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgTalkerConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvgTalkerConfig?(AvgTalkerConfig.GetRootAsAvgTalkerConfig(configBuffer));
				}
			}
			ConfigAvgTalkerConfigById.LogPair.Clear();
			ConfigAvgTalkerConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvgTalkerConfigById.HandleId, 1, p0Id, ConfigAvgTalkerConfigById.LogPair) || ConfigCommon.Step(ConfigAvgTalkerConfigById.HandleId, true, ConfigAvgTalkerConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvgTalkerConfigById.HandleId, ConfigAvgTalkerConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvgTalkerConfigById.HandleId, 0, ConfigAvgTalkerConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvgTalkerConfigById.HandleId, ConfigAvgTalkerConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvgTalkerConfig rootAsAvgTalkerConfig = AvgTalkerConfig.GetRootAsAvgTalkerConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgTalkerConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvgTalkerConfigById.HandleId, ConfigAvgTalkerConfigById.LogPair);
			return new AvgTalkerConfig?(rootAsAvgTalkerConfig);
		}

		// Token: 0x04000578 RID: 1400
		private const string DB = "db_avgtalkerconfig.db";

		// Token: 0x04000579 RID: 1401
		private const string FILE = "k.可视化编辑/c.Csv/a.AVG对话人配置/*.csv*";

		// Token: 0x0400057A RID: 1402
		private const string TABLE = "AvgTalkerConfig";

		// Token: 0x0400057B RID: 1403
		private const string COMMAND = "select BinData from `AvgTalkerConfig` where Id=?";

		// Token: 0x0400057C RID: 1404
		private const string KEY_PREFIX = "AvgTalkerConfigById";

		// Token: 0x0400057D RID: 1405
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400057E RID: 1406
		private static int HandleId;
	}
}
