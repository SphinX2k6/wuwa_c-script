using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FC RID: 508
	public class ConfigDebugEntranceConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BEB RID: 3051 RVA: 0x0009D053 File Offset: 0x0009B253
		static ConfigDebugEntranceConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugEntranceConfigById.CreateStaticDefaultValue), new Action(ConfigDebugEntranceConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0009D074 File Offset: 0x0009B274
		public static void CreateStaticDefaultValue()
		{
			ConfigDebugEntranceConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDebugEntranceConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_debugview.db"),
				new ValueTuple<string, object>("文件", "t.调试界面.xlsx"),
				new ValueTuple<string, object>("表名", "DebugEntranceConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `DebugEntranceConfig` where Id=?")
			});
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0009D0F3 File Offset: 0x0009B2F3
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugEntranceConfigById.LogPair = null;
			ConfigDebugEntranceConfigById.HandleId = 0;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0009D101 File Offset: 0x0009B301
		public static void Init()
		{
			ConfigDebugEntranceConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDebugEntranceConfigById.HandleId, "db_debugview.db", "select BinData from `DebugEntranceConfig` where Id=?");
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0009D11C File Offset: 0x0009B31C
		public static DebugEntranceConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDebugEntranceConfigById.HandleId, ConfigDebugEntranceConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DebugEntranceConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DebugEntranceConfig?(DebugEntranceConfig.GetRootAsDebugEntranceConfig(configBuffer));
				}
			}
			ConfigDebugEntranceConfigById.LogPair.Clear();
			ConfigDebugEntranceConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDebugEntranceConfigById.HandleId, 1, p0Id, ConfigDebugEntranceConfigById.LogPair) || ConfigCommon.Step(ConfigDebugEntranceConfigById.HandleId, true, ConfigDebugEntranceConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDebugEntranceConfigById.HandleId, ConfigDebugEntranceConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDebugEntranceConfigById.HandleId, 0, ConfigDebugEntranceConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDebugEntranceConfigById.HandleId, ConfigDebugEntranceConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DebugEntranceConfig rootAsDebugEntranceConfig = DebugEntranceConfig.GetRootAsDebugEntranceConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DebugEntranceConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDebugEntranceConfigById.HandleId, ConfigDebugEntranceConfigById.LogPair);
			return new DebugEntranceConfig?(rootAsDebugEntranceConfig);
		}

		// Token: 0x04000DC8 RID: 3528
		private const string DB = "db_debugview.db";

		// Token: 0x04000DC9 RID: 3529
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000DCA RID: 3530
		private const string TABLE = "DebugEntranceConfig";

		// Token: 0x04000DCB RID: 3531
		private const string COMMAND = "select BinData from `DebugEntranceConfig` where Id=?";

		// Token: 0x04000DCC RID: 3532
		private const string KEY_PREFIX = "DebugEntranceConfigById";

		// Token: 0x04000DCD RID: 3533
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DCE RID: 3534
		private static int HandleId;
	}
}
