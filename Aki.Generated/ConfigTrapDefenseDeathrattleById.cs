using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B01 RID: 2817
	public class ConfigTrapDefenseDeathrattleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600421A RID: 16922 RVA: 0x001D29B0 File Offset: 0x001D0BB0
		static ConfigTrapDefenseDeathrattleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseDeathrattleById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseDeathrattleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x001D29D0 File Offset: 0x001D0BD0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseDeathrattleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseDeathrattleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseDeathrattle"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseDeathrattle` where Id=?")
			});
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x001D2A4F File Offset: 0x001D0C4F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseDeathrattleById.LogPair = null;
			ConfigTrapDefenseDeathrattleById.HandleId = 0;
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x001D2A5D File Offset: 0x001D0C5D
		public static void Init()
		{
			ConfigTrapDefenseDeathrattleById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseDeathrattleById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseDeathrattle` where Id=?");
		}

		// Token: 0x0600421E RID: 16926 RVA: 0x001D2A78 File Offset: 0x001D0C78
		public static TrapDefenseDeathrattle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseDeathrattleById.HandleId, ConfigTrapDefenseDeathrattleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseDeathrattleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseDeathrattle?(TrapDefenseDeathrattle.GetRootAsTrapDefenseDeathrattle(configBuffer));
				}
			}
			ConfigTrapDefenseDeathrattleById.LogPair.Clear();
			ConfigTrapDefenseDeathrattleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseDeathrattleById.HandleId, 1, p0Id, ConfigTrapDefenseDeathrattleById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseDeathrattleById.HandleId, true, ConfigTrapDefenseDeathrattleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseDeathrattleById.HandleId, ConfigTrapDefenseDeathrattleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseDeathrattleById.HandleId, 0, ConfigTrapDefenseDeathrattleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseDeathrattleById.HandleId, ConfigTrapDefenseDeathrattleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseDeathrattle rootAsTrapDefenseDeathrattle = TrapDefenseDeathrattle.GetRootAsTrapDefenseDeathrattle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseDeathrattleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseDeathrattleById.HandleId, ConfigTrapDefenseDeathrattleById.LogPair);
			return new TrapDefenseDeathrattle?(rootAsTrapDefenseDeathrattle);
		}

		// Token: 0x04004CED RID: 19693
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CEE RID: 19694
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004CEF RID: 19695
		private const string TABLE = "TrapDefenseDeathrattle";

		// Token: 0x04004CF0 RID: 19696
		private const string COMMAND = "select BinData from `TrapDefenseDeathrattle` where Id=?";

		// Token: 0x04004CF1 RID: 19697
		private const string KEY_PREFIX = "TrapDefenseDeathrattleById";

		// Token: 0x04004CF2 RID: 19698
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CF3 RID: 19699
		private static int HandleId;
	}
}
