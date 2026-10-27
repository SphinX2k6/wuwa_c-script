using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059F RID: 1439
	public class ConfigMotorFightTaskTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021C7 RID: 8647 RVA: 0x001188DC File Offset: 0x00116ADC
		static ConfigMotorFightTaskTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTaskTabByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightTaskTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x001188FC File Offset: 0x00116AFC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTaskTabByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTaskTabByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTaskTab` where ActivityId=?")
			});
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0011897B File Offset: 0x00116B7B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTaskTabByActivityId.LogPair = null;
			ConfigMotorFightTaskTabByActivityId.HandleId = 0;
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00118989 File Offset: 0x00116B89
		public static void Init()
		{
			ConfigMotorFightTaskTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTaskTabByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightTaskTab` where ActivityId=?");
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x001189A4 File Offset: 0x00116BA4
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightTaskTab> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTaskTabByActivityId.HandleId, ConfigMotorFightTaskTabByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<MotorFightTaskTab> readOnlyList = (IReadOnlyList<MotorFightTaskTab>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorFightTaskTabByActivityId.LogPair.Clear();
			ConfigMotorFightTaskTabByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightTaskTabByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightTaskTabByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorFightTaskTabByActivityId.HandleId, ConfigMotorFightTaskTabByActivityId.LogPair);
				return null;
			}
			List<MotorFightTaskTab> list = new List<MotorFightTaskTab>();
			while (ConfigCommon.Step(ConfigMotorFightTaskTabByActivityId.HandleId, false, ConfigMotorFightTaskTabByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTaskTabByActivityId.HandleId, 0, ConfigMotorFightTaskTabByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightTaskTabByActivityId.HandleId, ConfigMotorFightTaskTabByActivityId.LogPair);
					return null;
				}
				MotorFightTaskTab rootAsMotorFightTaskTab = MotorFightTaskTab.GetRootAsMotorFightTaskTab(new ByteBuffer(item2));
				list.Add(rootAsMotorFightTaskTab);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightTaskTabByActivityId.HandleId, ConfigMotorFightTaskTabByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400273D RID: 10045
		private const string DB = "db_motorfight.db";

		// Token: 0x0400273E RID: 10046
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400273F RID: 10047
		private const string TABLE = "MotorFightTaskTab";

		// Token: 0x04002740 RID: 10048
		private const string COMMAND = "select BinData from `MotorFightTaskTab` where ActivityId=?";

		// Token: 0x04002741 RID: 10049
		private const string KEY_PREFIX = "MotorFightTaskTabByActivityId";

		// Token: 0x04002742 RID: 10050
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002743 RID: 10051
		private static int HandleId;
	}
}
