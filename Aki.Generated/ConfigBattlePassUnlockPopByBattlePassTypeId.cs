using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F7 RID: 247
	public class ConfigBattlePassUnlockPopByBattlePassTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x0007DFE0 File Offset: 0x0007C1E0
		static ConfigBattlePassUnlockPopByBattlePassTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattlePassUnlockPopByBattlePassTypeId.CreateStaticDefaultValue), new Action(ConfigBattlePassUnlockPopByBattlePassTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0007E000 File Offset: 0x0007C200
		public static void CreateStaticDefaultValue()
		{
			ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battle_pass.db"),
				new ValueTuple<string, object>("文件", "z.战令.xlsx"),
				new ValueTuple<string, object>("表名", "BattlePassUnlockPop"),
				new ValueTuple<string, object>("语句", "select BinData from `BattlePassUnlockPop` where TpyeID=?")
			});
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0007E07F File Offset: 0x0007C27F
		public static void ResetStaticDefaultValue()
		{
			ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair = null;
			ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId = 0;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0007E08D File Offset: 0x0007C28D
		public static void Init()
		{
			ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, "db_battle_pass.db", "select BinData from `BattlePassUnlockPop` where TpyeID=?");
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0007E0A8 File Offset: 0x0007C2A8
		public static BattlePassUnlockPop? GetConfig(int p0TpyeID, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassUnlockPopByBattlePassTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TpyeID);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BattlePassUnlockPop?(BattlePassUnlockPop.GetRootAsBattlePassUnlockPop(configBuffer));
				}
			}
			ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair.Clear();
			ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair.Add(new ValueTuple<string, object>("TpyeID", p0TpyeID));
			if (!ConfigCommon.BindInt(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, 1, p0TpyeID, ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair) || ConfigCommon.Step(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, true, ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, 0, ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BattlePassUnlockPop rootAsBattlePassUnlockPop = BattlePassUnlockPop.GetRootAsBattlePassUnlockPop(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassUnlockPopByBattlePassTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TpyeID);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair);
			return new BattlePassUnlockPop?(rootAsBattlePassUnlockPop);
		}

		// Token: 0x040006A5 RID: 1701
		private const string DB = "db_battle_pass.db";

		// Token: 0x040006A6 RID: 1702
		private const string FILE = "z.战令.xlsx";

		// Token: 0x040006A7 RID: 1703
		private const string TABLE = "BattlePassUnlockPop";

		// Token: 0x040006A8 RID: 1704
		private const string COMMAND = "select BinData from `BattlePassUnlockPop` where TpyeID=?";

		// Token: 0x040006A9 RID: 1705
		private const string KEY_PREFIX = "BattlePassUnlockPopByBattlePassTypeId";

		// Token: 0x040006AA RID: 1706
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006AB RID: 1707
		private static int HandleId;
	}
}
