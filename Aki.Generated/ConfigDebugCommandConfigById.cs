using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FA RID: 506
	public class ConfigDebugCommandConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x0009CC78 File Offset: 0x0009AE78
		static ConfigDebugCommandConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugCommandConfigById.CreateStaticDefaultValue), new Action(ConfigDebugCommandConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0009CC98 File Offset: 0x0009AE98
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

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0009CD17 File Offset: 0x0009AF17
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugCommandConfigById.LogPair = null;
			ConfigDebugCommandConfigById.HandleId = 0;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0009CD25 File Offset: 0x0009AF25
		public static void Init()
		{
			ConfigDebugCommandConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigDebugCommandConfigById.HandleId, "db_debugview.db", "select BinData from `DebugCommandConfig` where Id=?");
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0009CD40 File Offset: 0x0009AF40
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

		// Token: 0x04000DBA RID: 3514
		private const string DB = "db_debugview.db";

		// Token: 0x04000DBB RID: 3515
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000DBC RID: 3516
		private const string TABLE = "DebugCommandConfig";

		// Token: 0x04000DBD RID: 3517
		private const string COMMAND = "select BinData from `DebugCommandConfig` where Id=?";

		// Token: 0x04000DBE RID: 3518
		private const string KEY_PREFIX = "DebugCommandConfigById";

		// Token: 0x04000DBF RID: 3519
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DC0 RID: 3520
		private static int HandleId;
	}
}
