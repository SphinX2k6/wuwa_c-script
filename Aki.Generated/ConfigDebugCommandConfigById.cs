using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020C RID: 524
	public class ConfigDebugCommandConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C4B RID: 3147 RVA: 0x000A2BB0 File Offset: 0x000A0DB0
		static ConfigDebugCommandConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugCommandConfigById.CreateStaticDefaultValue), new Action(ConfigDebugCommandConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000A2BD0 File Offset: 0x000A0DD0
		public static void CreateStaticDefaultValue()
		{
			ConfigDebugCommandConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDebugCommandConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_debugview.db"),
				new ValueTuple<string, object>("文件", "t.调试界面.xlsx"),
				new ValueTuple<string, object>("表名", "DebugCommandConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `DebugCommandConfig` where Id=?")
			});
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000A2C4F File Offset: 0x000A0E4F
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugCommandConfigById.LogPair = null;
			ConfigDebugCommandConfigById.HandleId = 0;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000A2C5D File Offset: 0x000A0E5D
		public static void Init()
		{
			ConfigDebugCommandConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDebugCommandConfigById.HandleId, "db_debugview.db", "select BinData from `DebugCommandConfig` where Id=?");
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000A2C78 File Offset: 0x000A0E78
		public static DebugCommandConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDebugCommandConfigById.HandleId, ConfigDebugCommandConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DebugCommandConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DebugCommandConfig?(DebugCommandConfig.GetRootAsDebugCommandConfig(configBuffer));
				}
			}
			ConfigDebugCommandConfigById.LogPair.Clear();
			ConfigDebugCommandConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDebugCommandConfigById.HandleId, 1, p0Id, ConfigDebugCommandConfigById.LogPair) || ConfigCommon.Step(ConfigDebugCommandConfigById.HandleId, true, ConfigDebugCommandConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDebugCommandConfigById.HandleId, ConfigDebugCommandConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDebugCommandConfigById.HandleId, 0, ConfigDebugCommandConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDebugCommandConfigById.HandleId, ConfigDebugCommandConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DebugCommandConfig rootAsDebugCommandConfig = DebugCommandConfig.GetRootAsDebugCommandConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DebugCommandConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDebugCommandConfigById.HandleId, ConfigDebugCommandConfigById.LogPair);
			return new DebugCommandConfig?(rootAsDebugCommandConfig);
		}

		// Token: 0x04000E38 RID: 3640
		private const string DB = "db_debugview.db";

		// Token: 0x04000E39 RID: 3641
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000E3A RID: 3642
		private const string TABLE = "DebugCommandConfig";

		// Token: 0x04000E3B RID: 3643
		private const string COMMAND = "select BinData from `DebugCommandConfig` where Id=?";

		// Token: 0x04000E3C RID: 3644
		private const string KEY_PREFIX = "DebugCommandConfigById";

		// Token: 0x04000E3D RID: 3645
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E3E RID: 3646
		private static int HandleId;
	}
}
