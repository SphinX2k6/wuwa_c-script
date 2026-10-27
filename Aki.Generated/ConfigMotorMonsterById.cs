using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B2 RID: 1458
	public class ConfigMotorMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002239 RID: 8761 RVA: 0x0011B090 File Offset: 0x00119290
		static ConfigMotorMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorMonsterById.CreateStaticDefaultValue), new Action(ConfigMotorMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x0011B0B0 File Offset: 0x001192B0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorMonsterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorMonsterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorMonster` where Id=?")
			});
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0011B12F File Offset: 0x0011932F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorMonsterById.LogPair = null;
			ConfigMotorMonsterById.HandleId = 0;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x0011B13D File Offset: 0x0011933D
		public static void Init()
		{
			ConfigMotorMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorMonsterById.HandleId, "db_motorfight.db", "select BinData from `MotorMonster` where Id=?");
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0011B158 File Offset: 0x00119358
		public static MotorMonster? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorMonsterById.HandleId, ConfigMotorMonsterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorMonster?(MotorMonster.GetRootAsMotorMonster(configBuffer));
				}
			}
			ConfigMotorMonsterById.LogPair.Clear();
			ConfigMotorMonsterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorMonsterById.HandleId, 1, p0Id, ConfigMotorMonsterById.LogPair) || ConfigCommon.Step(ConfigMotorMonsterById.HandleId, true, ConfigMotorMonsterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorMonsterById.HandleId, ConfigMotorMonsterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorMonsterById.HandleId, 0, ConfigMotorMonsterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorMonsterById.HandleId, ConfigMotorMonsterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorMonster rootAsMotorMonster = MotorMonster.GetRootAsMotorMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorMonsterById.HandleId, ConfigMotorMonsterById.LogPair);
			return new MotorMonster?(rootAsMotorMonster);
		}

		// Token: 0x040027C2 RID: 10178
		private const string DB = "db_motorfight.db";

		// Token: 0x040027C3 RID: 10179
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040027C4 RID: 10180
		private const string TABLE = "MotorMonster";

		// Token: 0x040027C5 RID: 10181
		private const string COMMAND = "select BinData from `MotorMonster` where Id=?";

		// Token: 0x040027C6 RID: 10182
		private const string KEY_PREFIX = "MotorMonsterById";

		// Token: 0x040027C7 RID: 10183
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027C8 RID: 10184
		private static int HandleId;
	}
}
