using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A39 RID: 2617
	public class ConfigTrapDefenseMonsterRiskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D6A RID: 15722 RVA: 0x001B503F File Offset: 0x001B323F
		static ConfigTrapDefenseMonsterRiskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterRiskById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterRiskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x001B5060 File Offset: 0x001B3260
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterRiskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterRiskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterRisk"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterRisk` where Id=?")
			});
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x001B50DF File Offset: 0x001B32DF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterRiskById.LogPair = null;
			ConfigTrapDefenseMonsterRiskById.HandleId = 0;
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x001B50ED File Offset: 0x001B32ED
		public static void Init()
		{
			ConfigTrapDefenseMonsterRiskById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterRiskById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterRisk` where Id=?");
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x001B5108 File Offset: 0x001B3308
		public static TrapDefenseMonsterRisk? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterRiskById.HandleId, ConfigTrapDefenseMonsterRiskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterRiskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonsterRisk?(TrapDefenseMonsterRisk.GetRootAsTrapDefenseMonsterRisk(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterRiskById.LogPair.Clear();
			ConfigTrapDefenseMonsterRiskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterRiskById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterRiskById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterRiskById.HandleId, true, ConfigTrapDefenseMonsterRiskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterRiskById.HandleId, ConfigTrapDefenseMonsterRiskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterRiskById.HandleId, 0, ConfigTrapDefenseMonsterRiskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterRiskById.HandleId, ConfigTrapDefenseMonsterRiskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonsterRisk rootAsTrapDefenseMonsterRisk = TrapDefenseMonsterRisk.GetRootAsTrapDefenseMonsterRisk(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterRiskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterRiskById.HandleId, ConfigTrapDefenseMonsterRiskById.LogPair);
			return new TrapDefenseMonsterRisk?(rootAsTrapDefenseMonsterRisk);
		}

		// Token: 0x04004775 RID: 18293
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004776 RID: 18294
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004777 RID: 18295
		private const string TABLE = "TrapDefenseMonsterRisk";

		// Token: 0x04004778 RID: 18296
		private const string COMMAND = "select BinData from `TrapDefenseMonsterRisk` where Id=?";

		// Token: 0x04004779 RID: 18297
		private const string KEY_PREFIX = "TrapDefenseMonsterRiskById";

		// Token: 0x0400477A RID: 18298
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400477B RID: 18299
		private static int HandleId;
	}
}
