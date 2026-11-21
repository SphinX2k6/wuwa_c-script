using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AA RID: 1450
	public class ConfigMotorFightMainLevelByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002209 RID: 8713 RVA: 0x0011D748 File Offset: 0x0011B948
		static ConfigMotorFightMainLevelByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightMainLevelByLevelId.CreateStaticDefaultValue), new Action(ConfigMotorFightMainLevelByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0011D768 File Offset: 0x0011B968
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightMainLevelByLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightMainLevelByLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightMainLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightMainLevel` where LevelId=?")
			});
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0011D7E7 File Offset: 0x0011B9E7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightMainLevelByLevelId.LogPair = null;
			ConfigMotorFightMainLevelByLevelId.HandleId = 0;
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0011D7F5 File Offset: 0x0011B9F5
		public static void Init()
		{
			ConfigMotorFightMainLevelByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightMainLevelByLevelId.HandleId, "db_motorfight.db", "select BinData from `MotorFightMainLevel` where LevelId=?");
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0011D810 File Offset: 0x0011BA10
		public static MotorFightMainLevel? GetConfig(int p0LevelId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightMainLevelByLevelId.HandleId, ConfigMotorFightMainLevelByLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightMainLevelByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightMainLevel?(MotorFightMainLevel.GetRootAsMotorFightMainLevel(configBuffer));
				}
			}
			ConfigMotorFightMainLevelByLevelId.LogPair.Clear();
			ConfigMotorFightMainLevelByLevelId.LogPair.Add(new ValueTuple<string, object>("LevelId", p0LevelId));
			if (!ConfigCommon.BindInt(ConfigMotorFightMainLevelByLevelId.HandleId, 1, p0LevelId, ConfigMotorFightMainLevelByLevelId.LogPair) || ConfigCommon.Step(ConfigMotorFightMainLevelByLevelId.HandleId, true, ConfigMotorFightMainLevelByLevelId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightMainLevelByLevelId.HandleId, ConfigMotorFightMainLevelByLevelId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightMainLevelByLevelId.HandleId, 0, ConfigMotorFightMainLevelByLevelId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightMainLevelByLevelId.HandleId, ConfigMotorFightMainLevelByLevelId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightMainLevel rootAsMotorFightMainLevel = MotorFightMainLevel.GetRootAsMotorFightMainLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightMainLevelByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightMainLevelByLevelId.HandleId, ConfigMotorFightMainLevelByLevelId.LogPair);
			return new MotorFightMainLevel?(rootAsMotorFightMainLevel);
		}

		// Token: 0x0400278A RID: 10122
		private const string DB = "db_motorfight.db";

		// Token: 0x0400278B RID: 10123
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x0400278C RID: 10124
		private const string TABLE = "MotorFightMainLevel";

		// Token: 0x0400278D RID: 10125
		private const string COMMAND = "select BinData from `MotorFightMainLevel` where LevelId=?";

		// Token: 0x0400278E RID: 10126
		private const string KEY_PREFIX = "MotorFightMainLevelByLevelId";

		// Token: 0x0400278F RID: 10127
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002790 RID: 10128
		private static int HandleId;
	}
}
