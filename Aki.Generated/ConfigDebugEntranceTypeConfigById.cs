using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FE RID: 510
	public class ConfigDebugEntranceTypeConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BF7 RID: 3063 RVA: 0x0009D42F File Offset: 0x0009B62F
		static ConfigDebugEntranceTypeConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugEntranceTypeConfigById.CreateStaticDefaultValue), new Action(ConfigDebugEntranceTypeConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0009D450 File Offset: 0x0009B650
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

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0009D4CF File Offset: 0x0009B6CF
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugEntranceTypeConfigById.LogPair = null;
			ConfigDebugEntranceTypeConfigById.HandleId = 0;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0009D4DD File Offset: 0x0009B6DD
		public static void Init()
		{
			ConfigDebugEntranceTypeConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDebugEntranceTypeConfigById.HandleId, "db_debugview.db", "select BinData from `DebugEntranceTypeConfig` where Id=?");
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
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

		// Token: 0x04000DD6 RID: 3542
		private const string DB = "db_debugview.db";

		// Token: 0x04000DD7 RID: 3543
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000DD8 RID: 3544
		private const string TABLE = "DebugEntranceTypeConfig";

		// Token: 0x04000DD9 RID: 3545
		private const string COMMAND = "select BinData from `DebugEntranceTypeConfig` where Id=?";

		// Token: 0x04000DDA RID: 3546
		private const string KEY_PREFIX = "DebugEntranceTypeConfigById";

		// Token: 0x04000DDB RID: 3547
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DDC RID: 3548
		private static int HandleId;
	}
}
