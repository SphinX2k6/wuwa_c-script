using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000254 RID: 596
	public class ConfigDualSenseLightBarById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DFC RID: 3580 RVA: 0x000AC247 File Offset: 0x000AA447
		static ConfigDualSenseLightBarById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDualSenseLightBarById.CreateStaticDefaultValue), new Action(ConfigDualSenseLightBarById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000AC268 File Offset: 0x000AA468
		public static void CreateStaticDefaultValue()
		{
			ConfigDualSenseLightBarById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDualSenseLightBarById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "DualSenseLightBar"),
				new ValueTuple<string, object>("语句", "select BinData from `DualSenseLightBar` where Id=?")
			});
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000AC2E7 File Offset: 0x000AA4E7
		public static void ResetStaticDefaultValue()
		{
			ConfigDualSenseLightBarById.LogPair = null;
			ConfigDualSenseLightBarById.HandleId = 0;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x000AC2F5 File Offset: 0x000AA4F5
		public static void Init()
		{
			ConfigDualSenseLightBarById.HandleId = ConfigCommon.InitDataStatement(ConfigDualSenseLightBarById.HandleId, "db_input_settings.db", "select BinData from `DualSenseLightBar` where Id=?");
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x000AC310 File Offset: 0x000AA510
		public static DualSenseLightBar? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDualSenseLightBarById.HandleId, ConfigDualSenseLightBarById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("DualSenseLightBarById#" + p0Id);
				if (configBuffer != null)
				{
					return new DualSenseLightBar?(DualSenseLightBar.GetRootAsDualSenseLightBar(configBuffer));
				}
			}
			ConfigDualSenseLightBarById.LogPair.Clear();
			ConfigDualSenseLightBarById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigDualSenseLightBarById.HandleId, 1, p0Id, ConfigDualSenseLightBarById.LogPair) || ConfigCommon.Step(ConfigDualSenseLightBarById.HandleId, true, ConfigDualSenseLightBarById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDualSenseLightBarById.HandleId, ConfigDualSenseLightBarById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDualSenseLightBarById.HandleId, 0, ConfigDualSenseLightBarById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDualSenseLightBarById.HandleId, ConfigDualSenseLightBarById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DualSenseLightBar rootAsDualSenseLightBar = DualSenseLightBar.GetRootAsDualSenseLightBar(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("DualSenseLightBarById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDualSenseLightBarById.HandleId, ConfigDualSenseLightBarById.LogPair);
			return new DualSenseLightBar?(rootAsDualSenseLightBar);
		}

		// Token: 0x04001030 RID: 4144
		private const string DB = "db_input_settings.db";

		// Token: 0x04001031 RID: 4145
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04001032 RID: 4146
		private const string TABLE = "DualSenseLightBar";

		// Token: 0x04001033 RID: 4147
		private const string COMMAND = "select BinData from `DualSenseLightBar` where Id=?";

		// Token: 0x04001034 RID: 4148
		private const string KEY_PREFIX = "DualSenseLightBarById";

		// Token: 0x04001035 RID: 4149
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001036 RID: 4150
		private static int HandleId;
	}
}
