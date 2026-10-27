using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2C RID: 2604
	public class ConfigTrapDefenseDeathrattleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D1C RID: 15644 RVA: 0x001B361C File Offset: 0x001B181C
		static ConfigTrapDefenseDeathrattleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseDeathrattleById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseDeathrattleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x001B363C File Offset: 0x001B183C
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

		// Token: 0x06003D1E RID: 15646 RVA: 0x001B36BB File Offset: 0x001B18BB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseDeathrattleById.LogPair = null;
			ConfigTrapDefenseDeathrattleById.HandleId = 0;
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x001B36C9 File Offset: 0x001B18C9
		public static void Init()
		{
			ConfigTrapDefenseDeathrattleById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseDeathrattleById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseDeathrattle` where Id=?");
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x001B36E4 File Offset: 0x001B18E4
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

		// Token: 0x0400471A RID: 18202
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400471B RID: 18203
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x0400471C RID: 18204
		private const string TABLE = "TrapDefenseDeathrattle";

		// Token: 0x0400471D RID: 18205
		private const string COMMAND = "select BinData from `TrapDefenseDeathrattle` where Id=?";

		// Token: 0x0400471E RID: 18206
		private const string KEY_PREFIX = "TrapDefenseDeathrattleById";

		// Token: 0x0400471F RID: 18207
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004720 RID: 18208
		private static int HandleId;
	}
}
