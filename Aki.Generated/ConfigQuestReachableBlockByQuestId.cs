using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000794 RID: 1940
	public class ConfigQuestReachableBlockByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D89 RID: 11657 RVA: 0x0015E137 File Offset: 0x0015C337
		static ConfigQuestReachableBlockByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuestReachableBlockByQuestId.CreateStaticDefaultValue), new Action(ConfigQuestReachableBlockByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x0015E158 File Offset: 0x0015C358
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

		// Token: 0x06002D8B RID: 11659 RVA: 0x0015E1D7 File Offset: 0x0015C3D7
		public static void ResetStaticDefaultValue()
		{
			ConfigQuestReachableBlockByQuestId.LogPair = null;
			ConfigQuestReachableBlockByQuestId.HandleId = 0;
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x0015E1E5 File Offset: 0x0015C3E5
		public static void Init()
		{
			ConfigQuestReachableBlockByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigQuestReachableBlockByQuestId.HandleId, "db_questreachableblock.db", "select BinData from `QuestReachableBlock` where QuestId=?");
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x0015E200 File Offset: 0x0015C400
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

		// Token: 0x040034F2 RID: 13554
		private const string DB = "db_questreachableblock.db";

		// Token: 0x040034F3 RID: 13555
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/QuestReachableBlock.csv";

		// Token: 0x040034F4 RID: 13556
		private const string TABLE = "QuestReachableBlock";

		// Token: 0x040034F5 RID: 13557
		private const string COMMAND = "select BinData from `QuestReachableBlock` where QuestId=?";

		// Token: 0x040034F6 RID: 13558
		private const string KEY_PREFIX = "QuestReachableBlockByQuestId";

		// Token: 0x040034F7 RID: 13559
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034F8 RID: 13560
		private static int HandleId;
	}
}
