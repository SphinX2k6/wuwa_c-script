using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000255 RID: 597
	public class ConfigEdgeRunnerUnlockById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E02 RID: 3586 RVA: 0x000A8AA3 File Offset: 0x000A6CA3
		static ConfigEdgeRunnerUnlockById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerUnlockById.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerUnlockById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000A8AC4 File Offset: 0x000A6CC4
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerUnlockById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerUnlockById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerUnlock"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerUnlock` where Id=?")
			});
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000A8B43 File Offset: 0x000A6D43
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerUnlockById.LogPair = null;
			ConfigEdgeRunnerUnlockById.HandleId = 0;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000A8B51 File Offset: 0x000A6D51
		public static void Init()
		{
			ConfigEdgeRunnerUnlockById.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerUnlockById.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerUnlock` where Id=?");
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000A8B6C File Offset: 0x000A6D6C
		public static EdgeRunnerUnlock? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerUnlockById.HandleId, ConfigEdgeRunnerUnlockById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerUnlockById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EdgeRunnerUnlock?(EdgeRunnerUnlock.GetRootAsEdgeRunnerUnlock(configBuffer));
				}
			}
			ConfigEdgeRunnerUnlockById.LogPair.Clear();
			ConfigEdgeRunnerUnlockById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerUnlockById.HandleId, 1, p0Id, ConfigEdgeRunnerUnlockById.LogPair) || ConfigCommon.Step(ConfigEdgeRunnerUnlockById.HandleId, true, ConfigEdgeRunnerUnlockById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerUnlockById.HandleId, ConfigEdgeRunnerUnlockById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerUnlockById.HandleId, 0, ConfigEdgeRunnerUnlockById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEdgeRunnerUnlockById.HandleId, ConfigEdgeRunnerUnlockById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EdgeRunnerUnlock rootAsEdgeRunnerUnlock = EdgeRunnerUnlock.GetRootAsEdgeRunnerUnlock(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerUnlockById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerUnlockById.HandleId, ConfigEdgeRunnerUnlockById.LogPair);
			return new EdgeRunnerUnlock?(rootAsEdgeRunnerUnlock);
		}

		// Token: 0x04001037 RID: 4151
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001038 RID: 4152
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001039 RID: 4153
		private const string TABLE = "EdgeRunnerUnlock";

		// Token: 0x0400103A RID: 4154
		private const string COMMAND = "select BinData from `EdgeRunnerUnlock` where Id=?";

		// Token: 0x0400103B RID: 4155
		private const string KEY_PREFIX = "EdgeRunnerUnlockById";

		// Token: 0x0400103C RID: 4156
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400103D RID: 4157
		private static int HandleId;
	}
}
