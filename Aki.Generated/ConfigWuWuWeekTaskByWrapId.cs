using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7B RID: 2939
	public class ConfigWuWuWeekTaskByWrapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044F7 RID: 17655 RVA: 0x001E34F4 File Offset: 0x001E16F4
		static ConfigWuWuWeekTaskByWrapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuWeekTaskByWrapId.CreateStaticDefaultValue), new Action(ConfigWuWuWeekTaskByWrapId.ResetStaticDefaultValue));
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x001E3514 File Offset: 0x001E1714
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWuWeekTaskByWrapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWuWeekTaskByWrapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwutask.db"),
				new ValueTuple<string, object>("文件", "w.呜呜签到.xlsx"),
				new ValueTuple<string, object>("表名", "WuWuWeekTask"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWuWeekTask` where WrapId=?")
			});
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x001E3593 File Offset: 0x001E1793
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuWeekTaskByWrapId.LogPair = null;
			ConfigWuWuWeekTaskByWrapId.HandleId = 0;
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x001E35A1 File Offset: 0x001E17A1
		public static void Init()
		{
			ConfigWuWuWeekTaskByWrapId.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuWeekTaskByWrapId.HandleId, "db_wuwutask.db", "select BinData from `WuWuWeekTask` where WrapId=?");
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x001E35BC File Offset: 0x001E17BC
		[NullableContext(2)]
		public static IReadOnlyList<WuWuWeekTask> GetConfigList(int p0WrapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWuWeekTaskByWrapId.HandleId, ConfigWuWuWeekTaskByWrapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuWeekTaskByWrapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WrapId);
				IReadOnlyList<WuWuWeekTask> readOnlyList = (IReadOnlyList<WuWuWeekTask>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWuWuWeekTaskByWrapId.LogPair.Clear();
			ConfigWuWuWeekTaskByWrapId.LogPair.Add(new ValueTuple<string, object>("WrapId", p0WrapId));
			if (!ConfigCommon.BindInt(ConfigWuWuWeekTaskByWrapId.HandleId, 1, p0WrapId, ConfigWuWuWeekTaskByWrapId.LogPair))
			{
				ConfigCommon.Reset(ConfigWuWuWeekTaskByWrapId.HandleId, ConfigWuWuWeekTaskByWrapId.LogPair);
				return null;
			}
			List<WuWuWeekTask> list = new List<WuWuWeekTask>();
			while (ConfigCommon.Step(ConfigWuWuWeekTaskByWrapId.HandleId, false, ConfigWuWuWeekTaskByWrapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWuWeekTaskByWrapId.HandleId, 0, ConfigWuWuWeekTaskByWrapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWuWuWeekTaskByWrapId.HandleId, ConfigWuWuWeekTaskByWrapId.LogPair);
					return null;
				}
				WuWuWeekTask rootAsWuWuWeekTask = WuWuWeekTask.GetRootAsWuWuWeekTask(new ByteBuffer(item2));
				list.Add(rootAsWuWuWeekTask);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuWeekTaskByWrapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WrapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWuWuWeekTaskByWrapId.HandleId, ConfigWuWuWeekTaskByWrapId.LogPair);
			return list;
		}

		// Token: 0x04005043 RID: 20547
		private const string DB = "db_wuwutask.db";

		// Token: 0x04005044 RID: 20548
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04005045 RID: 20549
		private const string TABLE = "WuWuWeekTask";

		// Token: 0x04005046 RID: 20550
		private const string COMMAND = "select BinData from `WuWuWeekTask` where WrapId=?";

		// Token: 0x04005047 RID: 20551
		private const string KEY_PREFIX = "WuWuWeekTaskByWrapId";

		// Token: 0x04005048 RID: 20552
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04005049 RID: 20553
		private static int HandleId;
	}
}
