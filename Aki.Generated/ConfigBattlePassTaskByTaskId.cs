using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F6 RID: 246
	public class ConfigBattlePassTaskByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x0007DD97 File Offset: 0x0007BF97
		static ConfigBattlePassTaskByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattlePassTaskByTaskId.CreateStaticDefaultValue), new Action(ConfigBattlePassTaskByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0007DDB8 File Offset: 0x0007BFB8
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

		// Token: 0x060005C7 RID: 1479 RVA: 0x0007DE37 File Offset: 0x0007C037
		public static void ResetStaticDefaultValue()
		{
			ConfigBattlePassTaskByTaskId.LogPair = null;
			ConfigBattlePassTaskByTaskId.HandleId = 0;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0007DE45 File Offset: 0x0007C045
		public static void Init()
		{
			ConfigBattlePassTaskByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigBattlePassTaskByTaskId.HandleId, "db_battle_pass.db", "select BinData from `BattlePassTask` where TaskId=?");
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0007DE60 File Offset: 0x0007C060
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

		// Token: 0x0400069E RID: 1694
		private const string DB = "db_battle_pass.db";

		// Token: 0x0400069F RID: 1695
		private const string FILE = "z.战令.xlsx";

		// Token: 0x040006A0 RID: 1696
		private const string TABLE = "BattlePassTask";

		// Token: 0x040006A1 RID: 1697
		private const string COMMAND = "select BinData from `BattlePassTask` where TaskId=?";

		// Token: 0x040006A2 RID: 1698
		private const string KEY_PREFIX = "BattlePassTaskByTaskId";

		// Token: 0x040006A3 RID: 1699
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006A4 RID: 1700
		private static int HandleId;
	}
}
