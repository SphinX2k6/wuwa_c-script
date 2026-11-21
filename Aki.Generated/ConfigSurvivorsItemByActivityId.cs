using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6F RID: 2671
	public class ConfigSurvivorsItemByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EAE RID: 16046 RVA: 0x001BF09C File Offset: 0x001BD29C
		static ConfigSurvivorsItemByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsItemByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsItemByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x001BF0BC File Offset: 0x001BD2BC
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

		// Token: 0x06003EB0 RID: 16048 RVA: 0x001BF13B File Offset: 0x001BD33B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsItemByActivityId.LogPair = null;
			ConfigSurvivorsItemByActivityId.HandleId = 0;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x001BF149 File Offset: 0x001BD349
		public static void Init()
		{
			ConfigSurvivorsItemByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsItemByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsItem` where ActivityId=?");
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x001BF164 File Offset: 0x001BD364
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

		// Token: 0x040048EF RID: 18671
		private const string DB = "db_survivors.db";

		// Token: 0x040048F0 RID: 18672
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x040048F1 RID: 18673
		private const string TABLE = "SurvivorsItem";

		// Token: 0x040048F2 RID: 18674
		private const string COMMAND = "select BinData from `SurvivorsItem` where ActivityId=?";

		// Token: 0x040048F3 RID: 18675
		private const string KEY_PREFIX = "SurvivorsItemByActivityId";

		// Token: 0x040048F4 RID: 18676
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048F5 RID: 18677
		private static int HandleId;
	}
}
