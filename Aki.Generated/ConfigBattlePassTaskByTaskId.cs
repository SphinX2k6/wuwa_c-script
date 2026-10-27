using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E7 RID: 231
	public class ConfigBattlePassTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600056B RID: 1387 RVA: 0x00078433 File Offset: 0x00076633
		static ConfigBattlePassTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattlePassTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigBattlePassTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00078454 File Offset: 0x00076654
		public static void CreateStaticDefaultValue()
		{
			ConfigBattlePassTaskByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattlePassTaskByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battle_pass.db"),
				new ValueTuple<string, object>("文件", "z.战令.xlsx"),
				new ValueTuple<string, object>("表名", "BattlePassTask"),
				new ValueTuple<string, object>("语句", "select BinData from `BattlePassTask` where TaskId=?")
			});
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000784D3 File Offset: 0x000766D3
		public static void ResetStaticDefaultValue()
		{
			ConfigBattlePassTaskByTaskId.LogPair = null;
			ConfigBattlePassTaskByTaskId.HandleId = 0;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000784E1 File Offset: 0x000766E1
		public static void Init()
		{
			ConfigBattlePassTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBattlePassTaskByTaskId.HandleId, "db_battle_pass.db", "select BinData from `BattlePassTask` where TaskId=?");
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000784FC File Offset: 0x000766FC
		public static BattlePassTask? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattlePassTaskByTaskId.HandleId, ConfigBattlePassTaskByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BattlePassTask?(BattlePassTask.GetRootAsBattlePassTask(configBuffer));
				}
			}
			ConfigBattlePassTaskByTaskId.LogPair.Clear();
			ConfigBattlePassTaskByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigBattlePassTaskByTaskId.HandleId, 1, p0TaskId, ConfigBattlePassTaskByTaskId.LogPair) || ConfigCommon.Step(ConfigBattlePassTaskByTaskId.HandleId, true, ConfigBattlePassTaskByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBattlePassTaskByTaskId.HandleId, ConfigBattlePassTaskByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattlePassTaskByTaskId.HandleId, 0, ConfigBattlePassTaskByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBattlePassTaskByTaskId.HandleId, ConfigBattlePassTaskByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BattlePassTask rootAsBattlePassTask = BattlePassTask.GetRootAsBattlePassTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassTaskByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBattlePassTaskByTaskId.HandleId, ConfigBattlePassTaskByTaskId.LogPair);
			return new BattlePassTask?(rootAsBattlePassTask);
		}

		// Token: 0x04000635 RID: 1589
		private const string DB = "db_battle_pass.db";

		// Token: 0x04000636 RID: 1590
		private const string FILE = "z.战令.xlsx";

		// Token: 0x04000637 RID: 1591
		private const string TABLE = "BattlePassTask";

		// Token: 0x04000638 RID: 1592
		private const string COMMAND = "select BinData from `BattlePassTask` where TaskId=?";

		// Token: 0x04000639 RID: 1593
		private const string KEY_PREFIX = "BattlePassTaskByTaskId";

		// Token: 0x0400063A RID: 1594
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400063B RID: 1595
		private static int HandleId;
	}
}
