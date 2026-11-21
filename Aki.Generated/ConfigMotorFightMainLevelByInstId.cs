using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A9 RID: 1449
	public class ConfigMotorFightMainLevelByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002203 RID: 8707 RVA: 0x0011D500 File Offset: 0x0011B700
		static ConfigMotorFightMainLevelByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightMainLevelByInstId.CreateStaticDefaultValue), new Action(ConfigMotorFightMainLevelByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x0011D520 File Offset: 0x0011B720
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightMainLevelByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightMainLevelByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightMainLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightMainLevel` where InstId=?")
			});
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0011D59F File Offset: 0x0011B79F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightMainLevelByInstId.LogPair = null;
			ConfigMotorFightMainLevelByInstId.HandleId = 0;
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0011D5AD File Offset: 0x0011B7AD
		public static void Init()
		{
			ConfigMotorFightMainLevelByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightMainLevelByInstId.HandleId, "db_motorfight.db", "select BinData from `MotorFightMainLevel` where InstId=?");
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0011D5C8 File Offset: 0x0011B7C8
		public static MotorFightMainLevel? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightMainLevelByInstId.HandleId, ConfigMotorFightMainLevelByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightMainLevelByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightMainLevel?(MotorFightMainLevel.GetRootAsMotorFightMainLevel(configBuffer));
				}
			}
			ConfigMotorFightMainLevelByInstId.LogPair.Clear();
			ConfigMotorFightMainLevelByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigMotorFightMainLevelByInstId.HandleId, 1, p0InstId, ConfigMotorFightMainLevelByInstId.LogPair) || ConfigCommon.Step(ConfigMotorFightMainLevelByInstId.HandleId, true, ConfigMotorFightMainLevelByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightMainLevelByInstId.HandleId, ConfigMotorFightMainLevelByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightMainLevelByInstId.HandleId, 0, ConfigMotorFightMainLevelByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightMainLevelByInstId.HandleId, ConfigMotorFightMainLevelByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightMainLevel rootAsMotorFightMainLevel = MotorFightMainLevel.GetRootAsMotorFightMainLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightMainLevelByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightMainLevelByInstId.HandleId, ConfigMotorFightMainLevelByInstId.LogPair);
			return new MotorFightMainLevel?(rootAsMotorFightMainLevel);
		}

		// Token: 0x04002783 RID: 10115
		private const string DB = "db_motorfight.db";

		// Token: 0x04002784 RID: 10116
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002785 RID: 10117
		private const string TABLE = "MotorFightMainLevel";

		// Token: 0x04002786 RID: 10118
		private const string COMMAND = "select BinData from `MotorFightMainLevel` where InstId=?";

		// Token: 0x04002787 RID: 10119
		private const string KEY_PREFIX = "MotorFightMainLevelByInstId";

		// Token: 0x04002788 RID: 10120
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002789 RID: 10121
		private static int HandleId;
	}
}
