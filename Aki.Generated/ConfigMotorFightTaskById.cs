using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059E RID: 1438
	public class ConfigMotorFightTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021C1 RID: 8641 RVA: 0x00118693 File Offset: 0x00116893
		static ConfigMotorFightTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTaskById.CreateStaticDefaultValue), new Action(ConfigMotorFightTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x001186B4 File Offset: 0x001168B4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTask"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTask` where Id=?")
			});
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00118733 File Offset: 0x00116933
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTaskById.LogPair = null;
			ConfigMotorFightTaskById.HandleId = 0;
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00118741 File Offset: 0x00116941
		public static void Init()
		{
			ConfigMotorFightTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTaskById.HandleId, "db_motorfight.db", "select BinData from `MotorFightTask` where Id=?");
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0011875C File Offset: 0x0011695C
		public static MotorFightTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTaskById.HandleId, ConfigMotorFightTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightTask?(MotorFightTask.GetRootAsMotorFightTask(configBuffer));
				}
			}
			ConfigMotorFightTaskById.LogPair.Clear();
			ConfigMotorFightTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightTaskById.HandleId, 1, p0Id, ConfigMotorFightTaskById.LogPair) || ConfigCommon.Step(ConfigMotorFightTaskById.HandleId, true, ConfigMotorFightTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightTaskById.HandleId, ConfigMotorFightTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTaskById.HandleId, 0, ConfigMotorFightTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightTaskById.HandleId, ConfigMotorFightTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightTask rootAsMotorFightTask = MotorFightTask.GetRootAsMotorFightTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightTaskById.HandleId, ConfigMotorFightTaskById.LogPair);
			return new MotorFightTask?(rootAsMotorFightTask);
		}

		// Token: 0x04002736 RID: 10038
		private const string DB = "db_motorfight.db";

		// Token: 0x04002737 RID: 10039
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002738 RID: 10040
		private const string TABLE = "MotorFightTask";

		// Token: 0x04002739 RID: 10041
		private const string COMMAND = "select BinData from `MotorFightTask` where Id=?";

		// Token: 0x0400273A RID: 10042
		private const string KEY_PREFIX = "MotorFightTaskById";

		// Token: 0x0400273B RID: 10043
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400273C RID: 10044
		private static int HandleId;
	}
}
