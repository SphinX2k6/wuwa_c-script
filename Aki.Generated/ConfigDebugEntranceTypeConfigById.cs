using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000210 RID: 528
	public class ConfigDebugEntranceTypeConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C63 RID: 3171 RVA: 0x000A3367 File Offset: 0x000A1567
		static ConfigDebugEntranceTypeConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugEntranceTypeConfigById.CreateStaticDefaultValue), new Action(ConfigDebugEntranceTypeConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000A3388 File Offset: 0x000A1588
		public static void CreateStaticDefaultValue()
		{
			ConfigDebugEntranceTypeConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDebugEntranceTypeConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_debugview.db"),
				new ValueTuple<string, object>("文件", "t.调试界面.xlsx"),
				new ValueTuple<string, object>("表名", "DebugEntranceTypeConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `DebugEntranceTypeConfig` where Id=?")
			});
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000A3407 File Offset: 0x000A1607
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugEntranceTypeConfigById.LogPair = null;
			ConfigDebugEntranceTypeConfigById.HandleId = 0;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000A3415 File Offset: 0x000A1615
		public static void Init()
		{
			ConfigDebugEntranceTypeConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDebugEntranceTypeConfigById.HandleId, "db_debugview.db", "select BinData from `DebugEntranceTypeConfig` where Id=?");
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x000A3430 File Offset: 0x000A1630
		public static DebugEntranceTypeConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDebugEntranceTypeConfigById.HandleId, ConfigDebugEntranceTypeConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DebugEntranceTypeConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DebugEntranceTypeConfig?(DebugEntranceTypeConfig.GetRootAsDebugEntranceTypeConfig(configBuffer));
				}
			}
			ConfigDebugEntranceTypeConfigById.LogPair.Clear();
			ConfigDebugEntranceTypeConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDebugEntranceTypeConfigById.HandleId, 1, p0Id, ConfigDebugEntranceTypeConfigById.LogPair) || ConfigCommon.Step(ConfigDebugEntranceTypeConfigById.HandleId, true, ConfigDebugEntranceTypeConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDebugEntranceTypeConfigById.HandleId, ConfigDebugEntranceTypeConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDebugEntranceTypeConfigById.HandleId, 0, ConfigDebugEntranceTypeConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDebugEntranceTypeConfigById.HandleId, ConfigDebugEntranceTypeConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DebugEntranceTypeConfig rootAsDebugEntranceTypeConfig = DebugEntranceTypeConfig.GetRootAsDebugEntranceTypeConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DebugEntranceTypeConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDebugEntranceTypeConfigById.HandleId, ConfigDebugEntranceTypeConfigById.LogPair);
			return new DebugEntranceTypeConfig?(rootAsDebugEntranceTypeConfig);
		}

		// Token: 0x04000E54 RID: 3668
		private const string DB = "db_debugview.db";

		// Token: 0x04000E55 RID: 3669
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000E56 RID: 3670
		private const string TABLE = "DebugEntranceTypeConfig";

		// Token: 0x04000E57 RID: 3671
		private const string COMMAND = "select BinData from `DebugEntranceTypeConfig` where Id=?";

		// Token: 0x04000E58 RID: 3672
		private const string KEY_PREFIX = "DebugEntranceTypeConfigById";

		// Token: 0x04000E59 RID: 3673
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E5A RID: 3674
		private static int HandleId;
	}
}
