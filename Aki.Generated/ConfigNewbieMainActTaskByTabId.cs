using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F0 RID: 1520
	public class ConfigNewbieMainActTaskByTabId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023AF RID: 9135 RVA: 0x001234D8 File Offset: 0x001216D8
		static ConfigNewbieMainActTaskByTabId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTaskByTabId.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTaskByTabId.ResetStaticDefaultValue));
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x001234F8 File Offset: 0x001216F8
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

		// Token: 0x060023B1 RID: 9137 RVA: 0x00123577 File Offset: 0x00121777
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTaskByTabId.LogPair = null;
			ConfigNewbieMainActTaskByTabId.HandleId = 0;
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00123585 File Offset: 0x00121785
		public static void Init()
		{
			ConfigNewbieMainActTaskByTabId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTaskByTabId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTask` where TabId=?");
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x001235A0 File Offset: 0x001217A0
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

		// Token: 0x04002976 RID: 10614
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002977 RID: 10615
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002978 RID: 10616
		private const string TABLE = "NewbieMainActTask";

		// Token: 0x04002979 RID: 10617
		private const string COMMAND = "select BinData from `NewbieMainActTask` where TabId=?";

		// Token: 0x0400297A RID: 10618
		private const string KEY_PREFIX = "NewbieMainActTaskByTabId";

		// Token: 0x0400297B RID: 10619
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400297C RID: 10620
		private static int HandleId;
	}
}
