using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3C RID: 2620
	public class ConfigTrapDefenseMonsterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D7C RID: 15740 RVA: 0x001B5664 File Offset: 0x001B3864
		static ConfigTrapDefenseMonsterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMonsterTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMonsterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x001B5684 File Offset: 0x001B3884
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMonsterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMonsterType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMonsterType` where Id=?")
			});
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x001B5703 File Offset: 0x001B3903
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMonsterTypeById.LogPair = null;
			ConfigTrapDefenseMonsterTypeById.HandleId = 0;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x001B5711 File Offset: 0x001B3911
		public static void Init()
		{
			ConfigTrapDefenseMonsterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMonsterTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMonsterType` where Id=?");
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x001B572C File Offset: 0x001B392C
		public static TrapDefenseMonsterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMonsterTypeById.HandleId, ConfigTrapDefenseMonsterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMonsterType?(TrapDefenseMonsterType.GetRootAsTrapDefenseMonsterType(configBuffer));
				}
			}
			ConfigTrapDefenseMonsterTypeById.LogPair.Clear();
			ConfigTrapDefenseMonsterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMonsterTypeById.HandleId, 1, p0Id, ConfigTrapDefenseMonsterTypeById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMonsterTypeById.HandleId, true, ConfigTrapDefenseMonsterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterTypeById.HandleId, ConfigTrapDefenseMonsterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMonsterTypeById.HandleId, 0, ConfigTrapDefenseMonsterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMonsterTypeById.HandleId, ConfigTrapDefenseMonsterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMonsterType rootAsTrapDefenseMonsterType = TrapDefenseMonsterType.GetRootAsTrapDefenseMonsterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMonsterTypeById.HandleId, ConfigTrapDefenseMonsterTypeById.LogPair);
			return new TrapDefenseMonsterType?(rootAsTrapDefenseMonsterType);
		}

		// Token: 0x0400478A RID: 18314
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400478B RID: 18315
		private const string FILE = "x.陷阱塔防活动_怪物.xlsx";

		// Token: 0x0400478C RID: 18316
		private const string TABLE = "TrapDefenseMonsterType";

		// Token: 0x0400478D RID: 18317
		private const string COMMAND = "select BinData from `TrapDefenseMonsterType` where Id=?";

		// Token: 0x0400478E RID: 18318
		private const string KEY_PREFIX = "TrapDefenseMonsterTypeById";

		// Token: 0x0400478F RID: 18319
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004790 RID: 18320
		private static int HandleId;
	}
}
