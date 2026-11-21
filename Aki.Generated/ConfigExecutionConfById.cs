using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A2 RID: 674
	public class ConfigExecutionConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FD1 RID: 4049 RVA: 0x000B66F8 File Offset: 0x000B48F8
		static ConfigExecutionConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExecutionConfById.CreateStaticDefaultValue), new Action(ConfigExecutionConfById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000B6718 File Offset: 0x000B4918
		public static void CreateStaticDefaultValue()
		{
			ConfigExecutionConfById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExecutionConfById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物战斗配置.xlsx"),
				new ValueTuple<string, object>("表名", "ExecutionConf"),
				new ValueTuple<string, object>("语句", "select BinData from `ExecutionConf` where Id=?")
			});
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000B6797 File Offset: 0x000B4997
		public static void ResetStaticDefaultValue()
		{
			ConfigExecutionConfById.LogPair = null;
			ConfigExecutionConfById.HandleId = 0;
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x000B67A5 File Offset: 0x000B49A5
		public static void Init()
		{
			ConfigExecutionConfById.HandleId = ConfigCommon.InitDataStatement(ConfigExecutionConfById.HandleId, "db_monster_info.db", "select BinData from `ExecutionConf` where Id=?");
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000B67C0 File Offset: 0x000B49C0
		public static ExecutionConf? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExecutionConfById.HandleId, ConfigExecutionConfById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExecutionConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExecutionConf?(ExecutionConf.GetRootAsExecutionConf(configBuffer));
				}
			}
			ConfigExecutionConfById.LogPair.Clear();
			ConfigExecutionConfById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExecutionConfById.HandleId, 1, p0Id, ConfigExecutionConfById.LogPair) || ConfigCommon.Step(ConfigExecutionConfById.HandleId, true, ConfigExecutionConfById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExecutionConfById.HandleId, ConfigExecutionConfById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExecutionConfById.HandleId, 0, ConfigExecutionConfById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExecutionConfById.HandleId, ConfigExecutionConfById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExecutionConf rootAsExecutionConf = ExecutionConf.GetRootAsExecutionConf(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExecutionConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExecutionConfById.HandleId, ConfigExecutionConfById.LogPair);
			return new ExecutionConf?(rootAsExecutionConf);
		}

		// Token: 0x04001252 RID: 4690
		private const string DB = "db_monster_info.db";

		// Token: 0x04001253 RID: 4691
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x04001254 RID: 4692
		private const string TABLE = "ExecutionConf";

		// Token: 0x04001255 RID: 4693
		private const string COMMAND = "select BinData from `ExecutionConf` where Id=?";

		// Token: 0x04001256 RID: 4694
		private const string KEY_PREFIX = "ExecutionConfById";

		// Token: 0x04001257 RID: 4695
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001258 RID: 4696
		private static int HandleId;
	}
}
