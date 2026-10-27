using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000622 RID: 1570
	public class ConfigOccupationConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024DC RID: 9436 RVA: 0x0012A148 File Offset: 0x00128348
		static ConfigOccupationConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOccupationConfigById.CreateStaticDefaultValue), new Action(ConfigOccupationConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0012A168 File Offset: 0x00128368
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

		// Token: 0x060024DE RID: 9438 RVA: 0x0012A1E7 File Offset: 0x001283E7
		public static void ResetStaticDefaultValue()
		{
			ConfigOccupationConfigById.LogPair = null;
			ConfigOccupationConfigById.HandleId = 0;
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x0012A1F5 File Offset: 0x001283F5
		public static void Init()
		{
			ConfigOccupationConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigOccupationConfigById.HandleId, "db_occupation.db", "select BinData from `OccupationConfig` where Id=?");
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x0012A210 File Offset: 0x00128410
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

		// Token: 0x04002AD4 RID: 10964
		private const string DB = "db_occupation.db";

		// Token: 0x04002AD5 RID: 10965
		private const string FILE = "k.可视化编辑/c.Csv/z.占用组配置/*.csv*";

		// Token: 0x04002AD6 RID: 10966
		private const string TABLE = "OccupationConfig";

		// Token: 0x04002AD7 RID: 10967
		private const string COMMAND = "select BinData from `OccupationConfig` where Id=?";

		// Token: 0x04002AD8 RID: 10968
		private const string KEY_PREFIX = "OccupationConfigById";

		// Token: 0x04002AD9 RID: 10969
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ADA RID: 10970
		private static int HandleId;
	}
}
