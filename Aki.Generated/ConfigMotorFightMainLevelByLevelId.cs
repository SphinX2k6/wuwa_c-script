using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000593 RID: 1427
	public class ConfigMotorFightMainLevelByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600217F RID: 8575 RVA: 0x00116E60 File Offset: 0x00115060
		static ConfigMotorFightMainLevelByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightMainLevelByLevelId.CreateStaticDefaultValue), new Action(ConfigMotorFightMainLevelByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00116E80 File Offset: 0x00115080
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

		// Token: 0x06002181 RID: 8577 RVA: 0x00116EFF File Offset: 0x001150FF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightMainLevelByLevelId.LogPair = null;
			ConfigMotorFightMainLevelByLevelId.HandleId = 0;
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00116F0D File Offset: 0x0011510D
		public static void Init()
		{
			ConfigMotorFightMainLevelByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightMainLevelByLevelId.HandleId, "db_motorfight.db", "select BinData from `MotorFightMainLevel` where LevelId=?");
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00116F28 File Offset: 0x00115128
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

		// Token: 0x040026E9 RID: 9961
		private const string DB = "db_motorfight.db";

		// Token: 0x040026EA RID: 9962
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040026EB RID: 9963
		private const string TABLE = "MotorFightMainLevel";

		// Token: 0x040026EC RID: 9964
		private const string COMMAND = "select BinData from `MotorFightMainLevel` where LevelId=?";

		// Token: 0x040026ED RID: 9965
		private const string KEY_PREFIX = "MotorFightMainLevelByLevelId";

		// Token: 0x040026EE RID: 9966
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026EF RID: 9967
		private static int HandleId;
	}
}
