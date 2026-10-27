using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099A RID: 2458
	public class ConfigSurvivorsItemByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039B0 RID: 14768 RVA: 0x0019FD08 File Offset: 0x0019DF08
		static ConfigSurvivorsItemByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsItemByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsItemByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0019FD28 File Offset: 0x0019DF28
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsItemByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsItemByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局外.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsItem` where ActivityId=?")
			});
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0019FDA7 File Offset: 0x0019DFA7
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsItemByActivityId.LogPair = null;
			ConfigSurvivorsItemByActivityId.HandleId = 0;
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0019FDB5 File Offset: 0x0019DFB5
		public static void Init()
		{
			ConfigSurvivorsItemByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsItemByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsItem` where ActivityId=?");
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x0019FDD0 File Offset: 0x0019DFD0
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsItem> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsItemByActivityId.HandleId, ConfigSurvivorsItemByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SurvivorsItem> readOnlyList = (IReadOnlyList<SurvivorsItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsItemByActivityId.LogPair.Clear();
			ConfigSurvivorsItemByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsItemByActivityId.HandleId, 1, p0ActivityId, ConfigSurvivorsItemByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsItemByActivityId.HandleId, ConfigSurvivorsItemByActivityId.LogPair);
				return null;
			}
			List<SurvivorsItem> list = new List<SurvivorsItem>();
			while (ConfigCommon.Step(ConfigSurvivorsItemByActivityId.HandleId, false, ConfigSurvivorsItemByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsItemByActivityId.HandleId, 0, ConfigSurvivorsItemByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsItemByActivityId.HandleId, ConfigSurvivorsItemByActivityId.LogPair);
					return null;
				}
				SurvivorsItem rootAsSurvivorsItem = SurvivorsItem.GetRootAsSurvivorsItem(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsItemByActivityId.HandleId, ConfigSurvivorsItemByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400431C RID: 17180
		private const string DB = "db_survivors.db";

		// Token: 0x0400431D RID: 17181
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x0400431E RID: 17182
		private const string TABLE = "SurvivorsItem";

		// Token: 0x0400431F RID: 17183
		private const string COMMAND = "select BinData from `SurvivorsItem` where ActivityId=?";

		// Token: 0x04004320 RID: 17184
		private const string KEY_PREFIX = "SurvivorsItemByActivityId";

		// Token: 0x04004321 RID: 17185
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004322 RID: 17186
		private static int HandleId;
	}
}
