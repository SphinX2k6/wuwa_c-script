using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5C RID: 2652
	public class ConfigSpringFestivalSubTaskByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E3C RID: 15932 RVA: 0x001BC76C File Offset: 0x001BA96C
		static ConfigSpringFestivalSubTaskByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalSubTaskByQuestId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalSubTaskByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x001BC78C File Offset: 0x001BA98C
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

		// Token: 0x06003E3E RID: 15934 RVA: 0x001BC80B File Offset: 0x001BAA0B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalSubTaskByQuestId.LogPair = null;
			ConfigSpringFestivalSubTaskByQuestId.HandleId = 0;
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x001BC819 File Offset: 0x001BAA19
		public static void Init()
		{
			ConfigSpringFestivalSubTaskByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalSubTaskByQuestId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalSubTask` where QuestId=?");
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x001BC834 File Offset: 0x001BAA34
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

		// Token: 0x0400486A RID: 18538
		private const string DB = "db_spring26.db";

		// Token: 0x0400486B RID: 18539
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400486C RID: 18540
		private const string TABLE = "SpringFestivalSubTask";

		// Token: 0x0400486D RID: 18541
		private const string COMMAND = "select BinData from `SpringFestivalSubTask` where QuestId=?";

		// Token: 0x0400486E RID: 18542
		private const string KEY_PREFIX = "SpringFestivalSubTaskByQuestId";

		// Token: 0x0400486F RID: 18543
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004870 RID: 18544
		private static int HandleId;
	}
}
