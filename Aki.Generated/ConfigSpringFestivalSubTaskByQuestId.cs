using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000987 RID: 2439
	public class ConfigSpringFestivalSubTaskByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600393E RID: 14654 RVA: 0x0019D3D8 File Offset: 0x0019B5D8
		static ConfigSpringFestivalSubTaskByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSubTaskByQuestId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSubTaskByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x0019D3F8 File Offset: 0x0019B5F8
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalSubTaskByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalSubTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalSubTask` where QuestId=?")
			});
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x0019D477 File Offset: 0x0019B677
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskByQuestId.LogPair = null;
			ConfigSpringFestivalSubTaskByQuestId.HandleId = 0;
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x0019D485 File Offset: 0x0019B685
		public static void Init()
		{
			ConfigSpringFestivalSubTaskByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSubTaskByQuestId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSubTask` where QuestId=?");
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0019D4A0 File Offset: 0x0019B6A0
		public static SpringFestivalSubTask? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalSubTaskByQuestId.HandleId, ConfigSpringFestivalSubTaskByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSubTaskByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalSubTask?(SpringFestivalSubTask.GetRootAsSpringFestivalSubTask(configBuffer));
				}
			}
			ConfigSpringFestivalSubTaskByQuestId.LogPair.Clear();
			ConfigSpringFestivalSubTaskByQuestId.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalSubTaskByQuestId.HandleId, 1, p0QuestId, ConfigSpringFestivalSubTaskByQuestId.LogPair) || ConfigCommon.Step(ConfigSpringFestivalSubTaskByQuestId.HandleId, true, ConfigSpringFestivalSubTaskByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalSubTaskByQuestId.HandleId, ConfigSpringFestivalSubTaskByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalSubTaskByQuestId.HandleId, 0, ConfigSpringFestivalSubTaskByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalSubTaskByQuestId.HandleId, ConfigSpringFestivalSubTaskByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalSubTask rootAsSpringFestivalSubTask = SpringFestivalSubTask.GetRootAsSpringFestivalSubTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalSubTaskByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalSubTaskByQuestId.HandleId, ConfigSpringFestivalSubTaskByQuestId.LogPair);
			return new SpringFestivalSubTask?(rootAsSpringFestivalSubTask);
		}

		// Token: 0x04004297 RID: 17047
		private const string DB = "db_spring26.db";

		// Token: 0x04004298 RID: 17048
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004299 RID: 17049
		private const string TABLE = "SpringFestivalSubTask";

		// Token: 0x0400429A RID: 17050
		private const string COMMAND = "select BinData from `SpringFestivalSubTask` where QuestId=?";

		// Token: 0x0400429B RID: 17051
		private const string KEY_PREFIX = "SpringFestivalSubTaskByQuestId";

		// Token: 0x0400429C RID: 17052
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400429D RID: 17053
		private static int HandleId;
	}
}
