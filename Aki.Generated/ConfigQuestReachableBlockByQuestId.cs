using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077A RID: 1914
	public class ConfigQuestReachableBlockByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CED RID: 11501 RVA: 0x0015722B File Offset: 0x0015542B
		static ConfigQuestReachableBlockByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReachableBlockByQuestId.CreateStaticDefaultValue), new Action(ConfigQuestReachableBlockByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x0015724C File Offset: 0x0015544C
		public static void CreateStaticDefaultValue()
		{
			ConfigQuestReachableBlockByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuestReachableBlockByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_questreachableblock.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefMapBlockConfig/QuestReachableBlock.csv"),
				new ValueTuple<string, object>("表名", "QuestReachableBlock"),
				new ValueTuple<string, object>("语句", "select BinData from `QuestReachableBlock` where QuestId=?")
			});
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x001572CB File Offset: 0x001554CB
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReachableBlockByQuestId.LogPair = null;
			ConfigQuestReachableBlockByQuestId.HandleId = 0;
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x001572D9 File Offset: 0x001554D9
		public static void Init()
		{
			ConfigQuestReachableBlockByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReachableBlockByQuestId.HandleId, "db_questreachableblock.db", "select BinData from `QuestReachableBlock` where QuestId=?");
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x001572F4 File Offset: 0x001554F4
		public static QuestReachableBlock? GetConfig(int p0QuestId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuestReachableBlockByQuestId.HandleId, ConfigQuestReachableBlockByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReachableBlockByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuestReachableBlock?(QuestReachableBlock.GetRootAsQuestReachableBlock(configBuffer));
				}
			}
			ConfigQuestReachableBlockByQuestId.LogPair.Clear();
			ConfigQuestReachableBlockByQuestId.LogPair.Add(new ValueTuple<string, object>("QuestId", p0QuestId));
			if (!ConfigCommon.BindInt(ConfigQuestReachableBlockByQuestId.HandleId, 1, p0QuestId, ConfigQuestReachableBlockByQuestId.LogPair) || ConfigCommon.Step(ConfigQuestReachableBlockByQuestId.HandleId, true, ConfigQuestReachableBlockByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuestReachableBlockByQuestId.HandleId, ConfigQuestReachableBlockByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuestReachableBlockByQuestId.HandleId, 0, ConfigQuestReachableBlockByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuestReachableBlockByQuestId.HandleId, ConfigQuestReachableBlockByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuestReachableBlock rootAsQuestReachableBlock = QuestReachableBlock.GetRootAsQuestReachableBlock(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuestReachableBlockByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0QuestId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuestReachableBlockByQuestId.HandleId, ConfigQuestReachableBlockByQuestId.LogPair);
			return new QuestReachableBlock?(rootAsQuestReachableBlock);
		}

		// Token: 0x0400343C RID: 13372
		private const string DB = "db_questreachableblock.db";

		// Token: 0x0400343D RID: 13373
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/QuestReachableBlock.csv";

		// Token: 0x0400343E RID: 13374
		private const string TABLE = "QuestReachableBlock";

		// Token: 0x0400343F RID: 13375
		private const string COMMAND = "select BinData from `QuestReachableBlock` where QuestId=?";

		// Token: 0x04003440 RID: 13376
		private const string KEY_PREFIX = "QuestReachableBlockByQuestId";

		// Token: 0x04003441 RID: 13377
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003442 RID: 13378
		private static int HandleId;
	}
}
