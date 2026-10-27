using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C6 RID: 1990
	public class ConfigRefResourceQuestListByBitId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EB6 RID: 11958 RVA: 0x00161537 File Offset: 0x0015F737
		static ConfigRefResourceQuestListByBitId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRefResourceQuestListByBitId.CreateStaticDefaultValue), new Action(ConfigRefResourceQuestListByBitId.ResetStaticDefaultValue));
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00161558 File Offset: 0x0015F758
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

		// Token: 0x06002EB8 RID: 11960 RVA: 0x001615D7 File Offset: 0x0015F7D7
		public static void ResetStaticDefaultValue()
		{
			ConfigRefResourceQuestListByBitId.LogPair = null;
			ConfigRefResourceQuestListByBitId.HandleId = 0;
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x001615E5 File Offset: 0x0015F7E5
		public static void Init()
		{
			ConfigRefResourceQuestListByBitId.HandleId = ConfigCommon.InitDataStatement(ConfigRefResourceQuestListByBitId.HandleId, "db_refresourcequestlist.db", "select BinData from `RefResourceQuestList` where BitId=?");
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00161600 File Offset: 0x0015F800
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

		// Token: 0x04003650 RID: 13904
		private const string DB = "db_refresourcequestlist.db";

		// Token: 0x04003651 RID: 13905
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/RefResourceQuestList.csv";

		// Token: 0x04003652 RID: 13906
		private const string TABLE = "RefResourceQuestList";

		// Token: 0x04003653 RID: 13907
		private const string COMMAND = "select BinData from `RefResourceQuestList` where BitId=?";

		// Token: 0x04003654 RID: 13908
		private const string KEY_PREFIX = "RefResourceQuestListByBitId";

		// Token: 0x04003655 RID: 13909
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003656 RID: 13910
		private static int HandleId;
	}
}
