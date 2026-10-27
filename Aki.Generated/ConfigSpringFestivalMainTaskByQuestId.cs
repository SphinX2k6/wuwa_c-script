using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097C RID: 2428
	public class ConfigSpringFestivalMainTaskByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038FC RID: 14588 RVA: 0x0019BBB4 File Offset: 0x00199DB4
		static ConfigSpringFestivalMainTaskByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalMainTaskByQuestId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalMainTaskByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x0019BBD4 File Offset: 0x00199DD4
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

		// Token: 0x060038FE RID: 14590 RVA: 0x0019BC53 File Offset: 0x00199E53
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalMainTaskByQuestId.LogPair = null;
			ConfigSpringFestivalMainTaskByQuestId.HandleId = 0;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0019BC61 File Offset: 0x00199E61
		public static void Init()
		{
			ConfigSpringFestivalMainTaskByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalMainTaskByQuestId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalMainTask` where QuestId=?");
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x0019BC7C File Offset: 0x00199E7C
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

		// Token: 0x0400424A RID: 16970
		private const string DB = "db_spring26.db";

		// Token: 0x0400424B RID: 16971
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400424C RID: 16972
		private const string TABLE = "SpringFestivalMainTask";

		// Token: 0x0400424D RID: 16973
		private const string COMMAND = "select BinData from `SpringFestivalMainTask` where QuestId=?";

		// Token: 0x0400424E RID: 16974
		private const string KEY_PREFIX = "SpringFestivalMainTaskByQuestId";

		// Token: 0x0400424F RID: 16975
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004250 RID: 16976
		private static int HandleId;
	}
}
