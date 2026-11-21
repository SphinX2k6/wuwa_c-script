using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063A RID: 1594
	public class ConfigOccupationConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x00130BC4 File Offset: 0x0012EDC4
		static ConfigOccupationConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOccupationConfigById.CreateStaticDefaultValue), new Action(ConfigOccupationConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00130BE4 File Offset: 0x0012EDE4
		public static void CreateStaticDefaultValue()
		{
			ConfigOccupationConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOccupationConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_occupation.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/z.占用组配置/*.csv*"),
				new ValueTuple<string, object>("表名", "OccupationConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `OccupationConfig` where Id=?")
			});
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00130C63 File Offset: 0x0012EE63
		public static void ResetStaticDefaultValue()
		{
			ConfigOccupationConfigById.LogPair = null;
			ConfigOccupationConfigById.HandleId = 0;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00130C71 File Offset: 0x0012EE71
		public static void Init()
		{
			ConfigOccupationConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigOccupationConfigById.HandleId, "db_occupation.db", "select BinData from `OccupationConfig` where Id=?");
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00130C8C File Offset: 0x0012EE8C
		public static OccupationConfig? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOccupationConfigById.HandleId, ConfigOccupationConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("OccupationConfigById#" + p0Id);
				if (configBuffer != null)
				{
					return new OccupationConfig?(OccupationConfig.GetRootAsOccupationConfig(configBuffer));
				}
			}
			ConfigOccupationConfigById.LogPair.Clear();
			ConfigOccupationConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigOccupationConfigById.HandleId, 1, p0Id, ConfigOccupationConfigById.LogPair) || ConfigCommon.Step(ConfigOccupationConfigById.HandleId, true, ConfigOccupationConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOccupationConfigById.HandleId, ConfigOccupationConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOccupationConfigById.HandleId, 0, ConfigOccupationConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOccupationConfigById.HandleId, ConfigOccupationConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OccupationConfig rootAsOccupationConfig = OccupationConfig.GetRootAsOccupationConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("OccupationConfigById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOccupationConfigById.HandleId, ConfigOccupationConfigById.LogPair);
			return new OccupationConfig?(rootAsOccupationConfig);
		}

		// Token: 0x04002B7C RID: 11132
		private const string DB = "db_occupation.db";

		// Token: 0x04002B7D RID: 11133
		private const string FILE = "k.可视化编辑/c.Csv/z.占用组配置/*.csv*";

		// Token: 0x04002B7E RID: 11134
		private const string TABLE = "OccupationConfig";

		// Token: 0x04002B7F RID: 11135
		private const string COMMAND = "select BinData from `OccupationConfig` where Id=?";

		// Token: 0x04002B80 RID: 11136
		private const string KEY_PREFIX = "OccupationConfigById";

		// Token: 0x04002B81 RID: 11137
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B82 RID: 11138
		private static int HandleId;
	}
}
