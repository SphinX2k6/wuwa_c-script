using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E2 RID: 2018
	public class ConfigRefResourceQuestListByBitId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F5E RID: 12126 RVA: 0x0016881F File Offset: 0x00166A1F
		static ConfigRefResourceQuestListByBitId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRefResourceQuestListByBitId.CreateStaticDefaultValue), new Action(ConfigRefResourceQuestListByBitId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00168840 File Offset: 0x00166A40
		public static void CreateStaticDefaultValue()
		{
			ConfigRefResourceQuestListByBitId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRefResourceQuestListByBitId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_refresourcequestlist.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefMapBlockConfig/RefResourceQuestList.csv"),
				new ValueTuple<string, object>("表名", "RefResourceQuestList"),
				new ValueTuple<string, object>("语句", "select BinData from `RefResourceQuestList` where BitId=?")
			});
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x001688BF File Offset: 0x00166ABF
		public static void ResetStaticDefaultValue()
		{
			ConfigRefResourceQuestListByBitId.LogPair = null;
			ConfigRefResourceQuestListByBitId.HandleId = 0;
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x001688CD File Offset: 0x00166ACD
		public static void Init()
		{
			ConfigRefResourceQuestListByBitId.HandleId = ConfigCommon.InitDataStatement(ConfigRefResourceQuestListByBitId.HandleId, "db_refresourcequestlist.db", "select BinData from `RefResourceQuestList` where BitId=?");
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x001688E8 File Offset: 0x00166AE8
		public static RefResourceQuestList? GetConfig(int p0BitId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRefResourceQuestListByBitId.HandleId, ConfigRefResourceQuestListByBitId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RefResourceQuestListByBitId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BitId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RefResourceQuestList?(RefResourceQuestList.GetRootAsRefResourceQuestList(configBuffer));
				}
			}
			ConfigRefResourceQuestListByBitId.LogPair.Clear();
			ConfigRefResourceQuestListByBitId.LogPair.Add(new ValueTuple<string, object>("BitId", p0BitId));
			if (!ConfigCommon.BindInt(ConfigRefResourceQuestListByBitId.HandleId, 1, p0BitId, ConfigRefResourceQuestListByBitId.LogPair) || ConfigCommon.Step(ConfigRefResourceQuestListByBitId.HandleId, true, ConfigRefResourceQuestListByBitId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRefResourceQuestListByBitId.HandleId, ConfigRefResourceQuestListByBitId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRefResourceQuestListByBitId.HandleId, 0, ConfigRefResourceQuestListByBitId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRefResourceQuestListByBitId.HandleId, ConfigRefResourceQuestListByBitId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RefResourceQuestList rootAsRefResourceQuestList = RefResourceQuestList.GetRootAsRefResourceQuestList(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RefResourceQuestListByBitId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BitId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRefResourceQuestListByBitId.HandleId, ConfigRefResourceQuestListByBitId.LogPair);
			return new RefResourceQuestList?(rootAsRefResourceQuestList);
		}

		// Token: 0x04003714 RID: 14100
		private const string DB = "db_refresourcequestlist.db";

		// Token: 0x04003715 RID: 14101
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/RefResourceQuestList.csv";

		// Token: 0x04003716 RID: 14102
		private const string TABLE = "RefResourceQuestList";

		// Token: 0x04003717 RID: 14103
		private const string COMMAND = "select BinData from `RefResourceQuestList` where BitId=?";

		// Token: 0x04003718 RID: 14104
		private const string KEY_PREFIX = "RefResourceQuestListByBitId";

		// Token: 0x04003719 RID: 14105
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400371A RID: 14106
		private static int HandleId;
	}
}
