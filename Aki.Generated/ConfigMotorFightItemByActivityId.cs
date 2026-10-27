using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058B RID: 1419
	public class ConfigMotorFightItemByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600214F RID: 8527 RVA: 0x00115CF4 File Offset: 0x00113EF4
		static ConfigMotorFightItemByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightItemByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightItemByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x00115D14 File Offset: 0x00113F14
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightItemByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightItemByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightItem"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightItem` where ActivityId=?")
			});
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x00115D93 File Offset: 0x00113F93
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightItemByActivityId.LogPair = null;
			ConfigMotorFightItemByActivityId.HandleId = 0;
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00115DA1 File Offset: 0x00113FA1
		public static void Init()
		{
			ConfigMotorFightItemByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightItemByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightItem` where ActivityId=?");
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00115DBC File Offset: 0x00113FBC
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightItem> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightItemByActivityId.HandleId, ConfigMotorFightItemByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorFightItem> readOnlyList = (IReadOnlyList<MotorFightItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorFightItemByActivityId.LogPair.Clear();
			ConfigMotorFightItemByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightItemByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightItemByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorFightItemByActivityId.HandleId, ConfigMotorFightItemByActivityId.LogPair);
				return null;
			}
			List<MotorFightItem> list = new List<MotorFightItem>();
			while (ConfigCommon.Step(ConfigMotorFightItemByActivityId.HandleId, false, ConfigMotorFightItemByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightItemByActivityId.HandleId, 0, ConfigMotorFightItemByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightItemByActivityId.HandleId, ConfigMotorFightItemByActivityId.LogPair);
					return null;
				}
				MotorFightItem rootAsMotorFightItem = MotorFightItem.GetRootAsMotorFightItem(new ByteBuffer(item2));
				list.Add(rootAsMotorFightItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightItemByActivityId.HandleId, ConfigMotorFightItemByActivityId.LogPair);
			return list;
		}

		// Token: 0x040026B1 RID: 9905
		private const string DB = "db_motorfight.db";

		// Token: 0x040026B2 RID: 9906
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040026B3 RID: 9907
		private const string TABLE = "MotorFightItem";

		// Token: 0x040026B4 RID: 9908
		private const string COMMAND = "select BinData from `MotorFightItem` where ActivityId=?";

		// Token: 0x040026B5 RID: 9909
		private const string KEY_PREFIX = "MotorFightItemByActivityId";

		// Token: 0x040026B6 RID: 9910
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026B7 RID: 9911
		private static int HandleId;
	}
}
