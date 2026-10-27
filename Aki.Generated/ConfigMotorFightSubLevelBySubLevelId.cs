using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059A RID: 1434
	public class ConfigMotorFightSubLevelBySubLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021A9 RID: 8617 RVA: 0x00117D94 File Offset: 0x00115F94
		static ConfigMotorFightSubLevelBySubLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightSubLevelBySubLevelId.CreateStaticDefaultValue), new Action(ConfigMotorFightSubLevelBySubLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00117DB4 File Offset: 0x00115FB4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightSubLevelBySubLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightSubLevelBySubLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightSubLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightSubLevel` where SubLevelId=?")
			});
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00117E33 File Offset: 0x00116033
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightSubLevelBySubLevelId.LogPair = null;
			ConfigMotorFightSubLevelBySubLevelId.HandleId = 0;
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00117E41 File Offset: 0x00116041
		public static void Init()
		{
			ConfigMotorFightSubLevelBySubLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightSubLevelBySubLevelId.HandleId, "db_motorfight.db", "select BinData from `MotorFightSubLevel` where SubLevelId=?");
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00117E5C File Offset: 0x0011605C
		public static MotorFightSubLevel? GetConfig(int p0SubLevelId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightSubLevelBySubLevelId.HandleId, ConfigMotorFightSubLevelBySubLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightSubLevelBySubLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SubLevelId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightSubLevel?(MotorFightSubLevel.GetRootAsMotorFightSubLevel(configBuffer));
				}
			}
			ConfigMotorFightSubLevelBySubLevelId.LogPair.Clear();
			ConfigMotorFightSubLevelBySubLevelId.LogPair.Add(new ValueTuple<string, object>("SubLevelId", p0SubLevelId));
			if (!ConfigCommon.BindInt(ConfigMotorFightSubLevelBySubLevelId.HandleId, 1, p0SubLevelId, ConfigMotorFightSubLevelBySubLevelId.LogPair) || ConfigCommon.Step(ConfigMotorFightSubLevelBySubLevelId.HandleId, true, ConfigMotorFightSubLevelBySubLevelId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightSubLevelBySubLevelId.HandleId, ConfigMotorFightSubLevelBySubLevelId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightSubLevelBySubLevelId.HandleId, 0, ConfigMotorFightSubLevelBySubLevelId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightSubLevelBySubLevelId.HandleId, ConfigMotorFightSubLevelBySubLevelId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightSubLevel rootAsMotorFightSubLevel = MotorFightSubLevel.GetRootAsMotorFightSubLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightSubLevelBySubLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SubLevelId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightSubLevelBySubLevelId.HandleId, ConfigMotorFightSubLevelBySubLevelId.LogPair);
			return new MotorFightSubLevel?(rootAsMotorFightSubLevel);
		}

		// Token: 0x0400271A RID: 10010
		private const string DB = "db_motorfight.db";

		// Token: 0x0400271B RID: 10011
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x0400271C RID: 10012
		private const string TABLE = "MotorFightSubLevel";

		// Token: 0x0400271D RID: 10013
		private const string COMMAND = "select BinData from `MotorFightSubLevel` where SubLevelId=?";

		// Token: 0x0400271E RID: 10014
		private const string KEY_PREFIX = "MotorFightSubLevelBySubLevelId";

		// Token: 0x0400271F RID: 10015
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002720 RID: 10016
		private static int HandleId;
	}
}
