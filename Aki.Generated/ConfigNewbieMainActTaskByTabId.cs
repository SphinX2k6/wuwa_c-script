using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000608 RID: 1544
	public class ConfigNewbieMainActTaskByTabId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600243F RID: 9279 RVA: 0x00129F54 File Offset: 0x00128154
		static ConfigNewbieMainActTaskByTabId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTaskByTabId.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTaskByTabId.ResetStaticDefaultValue));
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00129F74 File Offset: 0x00128174
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActTaskByTabId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActTaskByTabId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActTask` where TabId=?")
			});
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00129FF3 File Offset: 0x001281F3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTaskByTabId.LogPair = null;
			ConfigNewbieMainActTaskByTabId.HandleId = 0;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0012A001 File Offset: 0x00128201
		public static void Init()
		{
			ConfigNewbieMainActTaskByTabId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTaskByTabId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTask` where TabId=?");
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x0012A01C File Offset: 0x0012821C
		[NullableContext(2)]
		public static IReadOnlyList<NewbieMainActTask> GetConfigList(int p0TabId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActTaskByTabId.HandleId, ConfigNewbieMainActTaskByTabId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTaskByTabId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TabId);
				IReadOnlyList<NewbieMainActTask> readOnlyList = (IReadOnlyList<NewbieMainActTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewbieMainActTaskByTabId.LogPair.Clear();
			ConfigNewbieMainActTaskByTabId.LogPair.Add(new ValueTuple<string, object>("TabId", p0TabId));
			if (!ConfigCommon.BindInt(ConfigNewbieMainActTaskByTabId.HandleId, 1, p0TabId, ConfigNewbieMainActTaskByTabId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewbieMainActTaskByTabId.HandleId, ConfigNewbieMainActTaskByTabId.LogPair);
				return null;
			}
			List<NewbieMainActTask> list = new List<NewbieMainActTask>();
			while (ConfigCommon.Step(ConfigNewbieMainActTaskByTabId.HandleId, false, ConfigNewbieMainActTaskByTabId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActTaskByTabId.HandleId, 0, ConfigNewbieMainActTaskByTabId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieMainActTaskByTabId.HandleId, ConfigNewbieMainActTaskByTabId.LogPair);
					return null;
				}
				NewbieMainActTask rootAsNewbieMainActTask = NewbieMainActTask.GetRootAsNewbieMainActTask(new ByteBuffer(item2));
				list.Add(rootAsNewbieMainActTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTaskByTabId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TabId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieMainActTaskByTabId.HandleId, ConfigNewbieMainActTaskByTabId.LogPair);
			return list;
		}

		// Token: 0x04002A1E RID: 10782
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A1F RID: 10783
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002A20 RID: 10784
		private const string TABLE = "NewbieMainActTask";

		// Token: 0x04002A21 RID: 10785
		private const string COMMAND = "select BinData from `NewbieMainActTask` where TabId=?";

		// Token: 0x04002A22 RID: 10786
		private const string KEY_PREFIX = "NewbieMainActTaskByTabId";

		// Token: 0x04002A23 RID: 10787
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A24 RID: 10788
		private static int HandleId;
	}
}
