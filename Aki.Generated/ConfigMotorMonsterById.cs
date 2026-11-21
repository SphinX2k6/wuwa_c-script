using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C9 RID: 1481
	public class ConfigMotorMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022C3 RID: 8899 RVA: 0x00121978 File Offset: 0x0011FB78
		static ConfigMotorMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorMonsterById.CreateStaticDefaultValue), new Action(ConfigMotorMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00121998 File Offset: 0x0011FB98
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

		// Token: 0x060022C5 RID: 8901 RVA: 0x00121A17 File Offset: 0x0011FC17
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorMonsterById.LogPair = null;
			ConfigMotorMonsterById.HandleId = 0;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00121A25 File Offset: 0x0011FC25
		public static void Init()
		{
			ConfigMotorMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorMonsterById.HandleId, "db_motorfight.db", "select BinData from `MotorMonster` where Id=?");
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00121A40 File Offset: 0x0011FC40
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

		// Token: 0x04002863 RID: 10339
		private const string DB = "db_motorfight.db";

		// Token: 0x04002864 RID: 10340
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002865 RID: 10341
		private const string TABLE = "MotorMonster";

		// Token: 0x04002866 RID: 10342
		private const string COMMAND = "select BinData from `MotorMonster` where Id=?";

		// Token: 0x04002867 RID: 10343
		private const string KEY_PREFIX = "MotorMonsterById";

		// Token: 0x04002868 RID: 10344
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002869 RID: 10345
		private static int HandleId;
	}
}
