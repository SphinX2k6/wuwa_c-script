using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E8 RID: 232
	public class ConfigBattlePassUnlockPopByBattlePassTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000571 RID: 1393 RVA: 0x0007867C File Offset: 0x0007687C
		static ConfigBattlePassUnlockPopByBattlePassTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattlePassUnlockPopByBattlePassTypeId.CreateStaticDefaultValue), new Action(ConfigBattlePassUnlockPopByBattlePassTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0007869C File Offset: 0x0007689C
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

		// Token: 0x06000573 RID: 1395 RVA: 0x0007871B File Offset: 0x0007691B
		public static void ResetStaticDefaultValue()
		{
			ConfigBattlePassUnlockPopByBattlePassTypeId.LogPair = null;
			ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId = 0;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00078729 File Offset: 0x00076929
		public static void Init()
		{
			ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigBattlePassUnlockPopByBattlePassTypeId.HandleId, "db_battle_pass.db", "select BinData from `BattlePassUnlockPop` where TpyeID=?");
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00078744 File Offset: 0x00076944
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

		// Token: 0x0400063C RID: 1596
		private const string DB = "db_battle_pass.db";

		// Token: 0x0400063D RID: 1597
		private const string FILE = "z.战令.xlsx";

		// Token: 0x0400063E RID: 1598
		private const string TABLE = "BattlePassUnlockPop";

		// Token: 0x0400063F RID: 1599
		private const string COMMAND = "select BinData from `BattlePassUnlockPop` where TpyeID=?";

		// Token: 0x04000640 RID: 1600
		private const string KEY_PREFIX = "BattlePassUnlockPopByBattlePassTypeId";

		// Token: 0x04000641 RID: 1601
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000642 RID: 1602
		private static int HandleId;
	}
}
