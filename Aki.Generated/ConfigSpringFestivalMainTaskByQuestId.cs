using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A51 RID: 2641
	public class ConfigSpringFestivalMainTaskByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DFA RID: 15866 RVA: 0x001BAF48 File Offset: 0x001B9148
		static ConfigSpringFestivalMainTaskByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalMainTaskByQuestId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalMainTaskByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x001BAF68 File Offset: 0x001B9168
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalMainTaskByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalMainTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalMainTask` where QuestId=?")
			});
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x001BAFE7 File Offset: 0x001B91E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskByQuestId.LogPair = null;
			ConfigSpringFestivalMainTaskByQuestId.HandleId = 0;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x001BAFF5 File Offset: 0x001B91F5
		public static void Init()
		{
			ConfigSpringFestivalMainTaskByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalMainTaskByQuestId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalMainTask` where QuestId=?");
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x001BB010 File Offset: 0x001B9210
		public static SpringFestivalMainTask? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalMainTaskByQuestId.HandleId, ConfigSpringFestivalMainTaskByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalMainTaskByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalMainTask?(SpringFestivalMainTask.GetRootAsSpringFestivalMainTask(configBuffer));
				}
			}
			ConfigSpringFestivalMainTaskByQuestId.LogPair.Clear();
			ConfigSpringFestivalMainTaskByQuestId.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalMainTaskByQuestId.HandleId, 1, p0QuestId, ConfigSpringFestivalMainTaskByQuestId.LogPair) || ConfigCommon.Step(ConfigSpringFestivalMainTaskByQuestId.HandleId, true, ConfigSpringFestivalMainTaskByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalMainTaskByQuestId.HandleId, ConfigSpringFestivalMainTaskByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalMainTaskByQuestId.HandleId, 0, ConfigSpringFestivalMainTaskByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalMainTaskByQuestId.HandleId, ConfigSpringFestivalMainTaskByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalMainTask rootAsSpringFestivalMainTask = SpringFestivalMainTask.GetRootAsSpringFestivalMainTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalMainTaskByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalMainTaskByQuestId.HandleId, ConfigSpringFestivalMainTaskByQuestId.LogPair);
			return new SpringFestivalMainTask?(rootAsSpringFestivalMainTask);
		}

		// Token: 0x0400481D RID: 18461
		private const string DB = "db_spring26.db";

		// Token: 0x0400481E RID: 18462
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400481F RID: 18463
		private const string TABLE = "SpringFestivalMainTask";

		// Token: 0x04004820 RID: 18464
		private const string COMMAND = "select BinData from `SpringFestivalMainTask` where QuestId=?";

		// Token: 0x04004821 RID: 18465
		private const string KEY_PREFIX = "SpringFestivalMainTaskByQuestId";

		// Token: 0x04004822 RID: 18466
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004823 RID: 18467
		private static int HandleId;
	}
}
