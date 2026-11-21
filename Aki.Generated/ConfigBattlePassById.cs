using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F4 RID: 244
	public class ConfigBattlePassById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x0007D918 File Offset: 0x0007BB18
		static ConfigBattlePassById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattlePassById.CreateStaticDefaultValue), new Action(ConfigBattlePassById.ResetStaticDefaultValue));
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0007D938 File Offset: 0x0007BB38
		public static void CreateStaticDefaultValue()
		{
			ConfigBattlePassById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattlePassById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battle_pass.db"),
				new ValueTuple<string, object>("文件", "z.战令.xlsx"),
				new ValueTuple<string, object>("表名", "BattlePass"),
				new ValueTuple<string, object>("语句", "select BinData from `BattlePass` where Id=?")
			});
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0007D9B7 File Offset: 0x0007BBB7
		public static void ResetStaticDefaultValue()
		{
			ConfigBattlePassById.LogPair = null;
			ConfigBattlePassById.HandleId = 0;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0007D9C5 File Offset: 0x0007BBC5
		public static void Init()
		{
			ConfigBattlePassById.HandleId = ConfigCommon.InitDataStatement(ConfigBattlePassById.HandleId, "db_battle_pass.db", "select BinData from `BattlePass` where Id=?");
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0007D9E0 File Offset: 0x0007BBE0
		public static BattlePass? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattlePassById.HandleId, ConfigBattlePassById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BattlePass?(BattlePass.GetRootAsBattlePass(configBuffer));
				}
			}
			ConfigBattlePassById.LogPair.Clear();
			ConfigBattlePassById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBattlePassById.HandleId, 1, p0Id, ConfigBattlePassById.LogPair) || ConfigCommon.Step(ConfigBattlePassById.HandleId, true, ConfigBattlePassById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBattlePassById.HandleId, ConfigBattlePassById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattlePassById.HandleId, 0, ConfigBattlePassById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBattlePassById.HandleId, ConfigBattlePassById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BattlePass rootAsBattlePass = BattlePass.GetRootAsBattlePass(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBattlePassById.HandleId, ConfigBattlePassById.LogPair);
			return new BattlePass?(rootAsBattlePass);
		}

		// Token: 0x04000690 RID: 1680
		private const string DB = "db_battle_pass.db";

		// Token: 0x04000691 RID: 1681
		private const string FILE = "z.战令.xlsx";

		// Token: 0x04000692 RID: 1682
		private const string TABLE = "BattlePass";

		// Token: 0x04000693 RID: 1683
		private const string COMMAND = "select BinData from `BattlePass` where Id=?";

		// Token: 0x04000694 RID: 1684
		private const string KEY_PREFIX = "BattlePassById";

		// Token: 0x04000695 RID: 1685
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000696 RID: 1686
		private static int HandleId;
	}
}
