using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A9 RID: 1961
	public class ConfigQuestTreeCustomJumpConfigByQuestIdAndType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E08 RID: 11784 RVA: 0x00160CD7 File Offset: 0x0015EED7
		static ConfigQuestTreeCustomJumpConfigByQuestIdAndType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.CreateStaticDefaultValue), new Action(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.ResetStaticDefaultValue));
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x00160CF8 File Offset: 0x0015EEF8
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questtreecustomjumpconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/r.任务树定制跳转/*.csv*"),
				new ValueTuple<string, object>("表名", "QuestTreeCustomJumpConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestTreeCustomJumpConfig` where QuestId=? AND PreConditionType=?")
			});
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00160D77 File Offset: 0x0015EF77
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair = null;
			ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId = 0;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00160D85 File Offset: 0x0015EF85
		public static void Init()
		{
			ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId = ConfigCommon.InitDataStatement(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, "db_questtreecustomjumpconfig.db", "select BinData from `QuestTreeCustomJumpConfig` where QuestId=? AND PreConditionType=?");
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00160DA0 File Offset: 0x0015EFA0
		public static QuestTreeCustomJumpConfig? GetConfig(int p0QuestId, string p1PreConditionType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeCustomJumpConfigByQuestIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1PreConditionType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestTreeCustomJumpConfig?(QuestTreeCustomJumpConfig.GetRootAsQuestTreeCustomJumpConfig(configBuffer));
				}
			}
			ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair.Clear();
			ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair.Add(new ValueTuple<string, object>("PreConditionType", p1PreConditionType));
			if (!ConfigCommon.BindInt(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, 1, p0QuestId, ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair) || !ConfigCommon.BindString(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, 2, p1PreConditionType, ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair) || ConfigCommon.Step(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, true, ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, 0, ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestTreeCustomJumpConfig rootAsQuestTreeCustomJumpConfig = QuestTreeCustomJumpConfig.GetRootAsQuestTreeCustomJumpConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("QuestTreeCustomJumpConfigByQuestIdAndType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1PreConditionType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestTreeCustomJumpConfigByQuestIdAndType.HandleId, ConfigQuestTreeCustomJumpConfigByQuestIdAndType.LogPair);
			return new QuestTreeCustomJumpConfig?(rootAsQuestTreeCustomJumpConfig);
		}

		// Token: 0x04003585 RID: 13701
		private const string DB = "db_questtreecustomjumpconfig.db";

		// Token: 0x04003586 RID: 13702
		private const string FILE = "k.可视化编辑/c.Csv/r.任务树定制跳转/*.csv*";

		// Token: 0x04003587 RID: 13703
		private const string TABLE = "QuestTreeCustomJumpConfig";

		// Token: 0x04003588 RID: 13704
		private const string COMMAND = "select BinData from `QuestTreeCustomJumpConfig` where QuestId=? AND PreConditionType=?";

		// Token: 0x04003589 RID: 13705
		private const string KEY_PREFIX = "QuestTreeCustomJumpConfigByQuestIdAndType";

		// Token: 0x0400358A RID: 13706
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400358B RID: 13707
		private static int HandleId;
	}
}
