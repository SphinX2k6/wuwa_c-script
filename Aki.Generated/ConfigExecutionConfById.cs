using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028E RID: 654
	public class ConfigExecutionConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F59 RID: 3929 RVA: 0x000B0434 File Offset: 0x000AE634
		static ConfigExecutionConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExecutionConfById.CreateStaticDefaultValue), new Action(ConfigExecutionConfById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000B0454 File Offset: 0x000AE654
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

		// Token: 0x06000F5B RID: 3931 RVA: 0x000B04D3 File Offset: 0x000AE6D3
		public static void ResetStaticDefaultValue()
		{
			ConfigExecutionConfById.LogPair = null;
			ConfigExecutionConfById.HandleId = 0;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000B04E1 File Offset: 0x000AE6E1
		public static void Init()
		{
			ConfigExecutionConfById.HandleId = ConfigCommon.InitDataStatement(ConfigExecutionConfById.HandleId, "db_monster_info.db", "select BinData from `ExecutionConf` where Id=?");
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000B04FC File Offset: 0x000AE6FC
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

		// Token: 0x040011C6 RID: 4550
		private const string DB = "db_monster_info.db";

		// Token: 0x040011C7 RID: 4551
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x040011C8 RID: 4552
		private const string TABLE = "ExecutionConf";

		// Token: 0x040011C9 RID: 4553
		private const string COMMAND = "select BinData from `ExecutionConf` where Id=?";

		// Token: 0x040011CA RID: 4554
		private const string KEY_PREFIX = "ExecutionConfById";

		// Token: 0x040011CB RID: 4555
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011CC RID: 4556
		private static int HandleId;
	}
}
