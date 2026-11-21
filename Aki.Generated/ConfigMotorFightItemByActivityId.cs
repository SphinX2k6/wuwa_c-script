using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A2 RID: 1442
	public class ConfigMotorFightItemByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021D9 RID: 8665 RVA: 0x0011C5DC File Offset: 0x0011A7DC
		static ConfigMotorFightItemByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightItemByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightItemByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0011C5FC File Offset: 0x0011A7FC
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

		// Token: 0x060021DB RID: 8667 RVA: 0x0011C67B File Offset: 0x0011A87B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightItemByActivityId.LogPair = null;
			ConfigMotorFightItemByActivityId.HandleId = 0;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0011C689 File Offset: 0x0011A889
		public static void Init()
		{
			ConfigMotorFightItemByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightItemByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightItem` where ActivityId=?");
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0011C6A4 File Offset: 0x0011A8A4
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

		// Token: 0x04002752 RID: 10066
		private const string DB = "db_motorfight.db";

		// Token: 0x04002753 RID: 10067
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002754 RID: 10068
		private const string TABLE = "MotorFightItem";

		// Token: 0x04002755 RID: 10069
		private const string COMMAND = "select BinData from `MotorFightItem` where ActivityId=?";

		// Token: 0x04002756 RID: 10070
		private const string KEY_PREFIX = "MotorFightItemByActivityId";

		// Token: 0x04002757 RID: 10071
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002758 RID: 10072
		private static int HandleId;
	}
}
