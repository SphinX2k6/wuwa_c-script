using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A36 RID: 2614
	public class ConfigTrapDefenseMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D58 RID: 15704 RVA: 0x001B4A1C File Offset: 0x001B2C1C
		static ConfigTrapDefenseMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x001B4A3C File Offset: 0x001B2C3C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonster` where Id=?")
			});
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x001B4ABB File Offset: 0x001B2CBB
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterById.LogPair = null;
			ConfigTrapDefenseMonsterById.HandleId = 0;
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x001B4AC9 File Offset: 0x001B2CC9
		public static void Init()
		{
			ConfigTrapDefenseMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonster` where Id=?");
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x001B4AE4 File Offset: 0x001B2CE4
		public static TrapDefenseMonster? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterById.HandleId, ConfigTrapDefenseMonsterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonster?(TrapDefenseMonster.GetRootAsTrapDefenseMonster(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterById.LogPair.Clear();
			ConfigTrapDefenseMonsterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterById.HandleId, true, ConfigTrapDefenseMonsterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterById.HandleId, ConfigTrapDefenseMonsterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterById.HandleId, 0, ConfigTrapDefenseMonsterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterById.HandleId, ConfigTrapDefenseMonsterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonster rootAsTrapDefenseMonster = TrapDefenseMonster.GetRootAsTrapDefenseMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterById.HandleId, ConfigTrapDefenseMonsterById.LogPair);
			return new TrapDefenseMonster?(rootAsTrapDefenseMonster);
		}

		// Token: 0x04004760 RID: 18272
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004761 RID: 18273
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x04004762 RID: 18274
		private const string TABLE = "TrapDefenseMonster";

		// Token: 0x04004763 RID: 18275
		private const string COMMAND = "select BinData from `TrapDefenseMonster` where Id=?";

		// Token: 0x04004764 RID: 18276
		private const string KEY_PREFIX = "TrapDefenseMonsterById";

		// Token: 0x04004765 RID: 18277
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004766 RID: 18278
		private static int HandleId;
	}
}
