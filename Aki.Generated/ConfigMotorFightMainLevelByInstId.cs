using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000592 RID: 1426
	public class ConfigMotorFightMainLevelByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002179 RID: 8569 RVA: 0x00116C18 File Offset: 0x00114E18
		static ConfigMotorFightMainLevelByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightMainLevelByInstId.CreateStaticDefaultValue), new Action(ConfigMotorFightMainLevelByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00116C38 File Offset: 0x00114E38
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

		// Token: 0x0600217B RID: 8571 RVA: 0x00116CB7 File Offset: 0x00114EB7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightMainLevelByInstId.LogPair = null;
			ConfigMotorFightMainLevelByInstId.HandleId = 0;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00116CC5 File Offset: 0x00114EC5
		public static void Init()
		{
			ConfigMotorFightMainLevelByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightMainLevelByInstId.HandleId, "db_motorfight.db", "select BinData from `MotorFightMainLevel` where InstId=?");
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00116CE0 File Offset: 0x00114EE0
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

		// Token: 0x040026E2 RID: 9954
		private const string DB = "db_motorfight.db";

		// Token: 0x040026E3 RID: 9955
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040026E4 RID: 9956
		private const string TABLE = "MotorFightMainLevel";

		// Token: 0x040026E5 RID: 9957
		private const string COMMAND = "select BinData from `MotorFightMainLevel` where InstId=?";

		// Token: 0x040026E6 RID: 9958
		private const string KEY_PREFIX = "MotorFightMainLevelByInstId";

		// Token: 0x040026E7 RID: 9959
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026E8 RID: 9960
		private static int HandleId;
	}
}
