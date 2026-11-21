using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020E RID: 526
	public class ConfigDebugEntranceConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x000A2F8B File Offset: 0x000A118B
		static ConfigDebugEntranceConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugEntranceConfigById.CreateStaticDefaultValue), new Action(ConfigDebugEntranceConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000A2FAC File Offset: 0x000A11AC
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

		// Token: 0x06000C59 RID: 3161 RVA: 0x000A302B File Offset: 0x000A122B
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugEntranceConfigById.LogPair = null;
			ConfigDebugEntranceConfigById.HandleId = 0;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000A3039 File Offset: 0x000A1239
		public static void Init()
		{
			ConfigDebugEntranceConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDebugEntranceConfigById.HandleId, "db_debugview.db", "select BinData from `DebugEntranceConfig` where Id=?");
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000A3054 File Offset: 0x000A1254
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

		// Token: 0x04000E46 RID: 3654
		private const string DB = "db_debugview.db";

		// Token: 0x04000E47 RID: 3655
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000E48 RID: 3656
		private const string TABLE = "DebugEntranceConfig";

		// Token: 0x04000E49 RID: 3657
		private const string COMMAND = "select BinData from `DebugEntranceConfig` where Id=?";

		// Token: 0x04000E4A RID: 3658
		private const string KEY_PREFIX = "DebugEntranceConfigById";

		// Token: 0x04000E4B RID: 3659
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E4C RID: 3660
		private static int HandleId;
	}
}
