using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EC RID: 1516
	public class ConfigNewbieMainActTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002397 RID: 9111 RVA: 0x00122C7C File Offset: 0x00120E7C
		static ConfigNewbieMainActTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTabByActivityId.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00122C9C File Offset: 0x00120E9C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActTabByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActTabByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActTab"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActTab` where ActivityId=?")
			});
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00122D1B File Offset: 0x00120F1B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTabByActivityId.LogPair = null;
			ConfigNewbieMainActTabByActivityId.HandleId = 0;
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00122D29 File Offset: 0x00120F29
		public static void Init()
		{
			ConfigNewbieMainActTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTabByActivityId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTab` where ActivityId=?");
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00122D44 File Offset: 0x00120F44
		[NullableContext(2)]
		public static IReadOnlyList<NewbieMainActTab> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActTabByActivityId.HandleId, ConfigNewbieMainActTabByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<NewbieMainActTab> readOnlyList = (IReadOnlyList<NewbieMainActTab>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewbieMainActTabByActivityId.LogPair.Clear();
			ConfigNewbieMainActTabByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigNewbieMainActTabByActivityId.HandleId, 1, p0ActivityId, ConfigNewbieMainActTabByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewbieMainActTabByActivityId.HandleId, ConfigNewbieMainActTabByActivityId.LogPair);
				return null;
			}
			List<NewbieMainActTab> list = new List<NewbieMainActTab>();
			while (ConfigCommon.Step(ConfigNewbieMainActTabByActivityId.HandleId, false, ConfigNewbieMainActTabByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActTabByActivityId.HandleId, 0, ConfigNewbieMainActTabByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieMainActTabByActivityId.HandleId, ConfigNewbieMainActTabByActivityId.LogPair);
					return null;
				}
				NewbieMainActTab rootAsNewbieMainActTab = NewbieMainActTab.GetRootAsNewbieMainActTab(new ByteBuffer(item2));
				list.Add(rootAsNewbieMainActTab);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieMainActTabByActivityId.HandleId, ConfigNewbieMainActTabByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400295A RID: 10586
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x0400295B RID: 10587
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x0400295C RID: 10588
		private const string TABLE = "NewbieMainActTab";

		// Token: 0x0400295D RID: 10589
		private const string COMMAND = "select BinData from `NewbieMainActTab` where ActivityId=?";

		// Token: 0x0400295E RID: 10590
		private const string KEY_PREFIX = "NewbieMainActTabByActivityId";

		// Token: 0x0400295F RID: 10591
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002960 RID: 10592
		private static int HandleId;
	}
}
