using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000604 RID: 1540
	public class ConfigNewbieMainActTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002427 RID: 9255 RVA: 0x001296F8 File Offset: 0x001278F8
		static ConfigNewbieMainActTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTabByActivityId.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00129718 File Offset: 0x00127918
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

		// Token: 0x06002429 RID: 9257 RVA: 0x00129797 File Offset: 0x00127997
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTabByActivityId.LogPair = null;
			ConfigNewbieMainActTabByActivityId.HandleId = 0;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x001297A5 File Offset: 0x001279A5
		public static void Init()
		{
			ConfigNewbieMainActTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTabByActivityId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTab` where ActivityId=?");
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x001297C0 File Offset: 0x001279C0
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

		// Token: 0x04002A02 RID: 10754
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A03 RID: 10755
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002A04 RID: 10756
		private const string TABLE = "NewbieMainActTab";

		// Token: 0x04002A05 RID: 10757
		private const string COMMAND = "select BinData from `NewbieMainActTab` where ActivityId=?";

		// Token: 0x04002A06 RID: 10758
		private const string KEY_PREFIX = "NewbieMainActTabByActivityId";

		// Token: 0x04002A07 RID: 10759
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A08 RID: 10760
		private static int HandleId;
	}
}
