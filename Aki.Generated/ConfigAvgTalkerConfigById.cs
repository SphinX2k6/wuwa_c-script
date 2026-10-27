using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BD RID: 189
	public class ConfigAvgTalkerConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x00072CFC File Offset: 0x00070EFC
		static ConfigAvgTalkerConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgTalkerConfigById.CreateStaticDefaultValue), new Action(ConfigAvgTalkerConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00072D1C File Offset: 0x00070F1C
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

		// Token: 0x06000471 RID: 1137 RVA: 0x00072D9B File Offset: 0x00070F9B
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgTalkerConfigById.LogPair = null;
			ConfigAvgTalkerConfigById.HandleId = 0;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00072DA9 File Offset: 0x00070FA9
		public static void Init()
		{
			ConfigAvgTalkerConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAvgTalkerConfigById.HandleId, "db_avgtalkerconfig.db", "select BinData from `AvgTalkerConfig` where Id=?");
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00072DC4 File Offset: 0x00070FC4
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

		// Token: 0x0400050F RID: 1295
		private const string DB = "db_avgtalkerconfig.db";

		// Token: 0x04000510 RID: 1296
		private const string FILE = "k.可视化编辑/c.Csv/a.AVG对话人配置/*.csv*";

		// Token: 0x04000511 RID: 1297
		private const string TABLE = "AvgTalkerConfig";

		// Token: 0x04000512 RID: 1298
		private const string COMMAND = "select BinData from `AvgTalkerConfig` where Id=?";

		// Token: 0x04000513 RID: 1299
		private const string KEY_PREFIX = "AvgTalkerConfigById";

		// Token: 0x04000514 RID: 1300
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000515 RID: 1301
		private static int HandleId;
	}
}
