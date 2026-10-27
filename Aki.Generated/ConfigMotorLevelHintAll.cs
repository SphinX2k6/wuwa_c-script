using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A7 RID: 1447
	public class ConfigMotorLevelHintAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021F7 RID: 8695 RVA: 0x00119B0C File Offset: 0x00117D0C
		static ConfigMotorLevelHintAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLevelHintAll.CreateStaticDefaultValue), new Action(ConfigMotorLevelHintAll.ResetStaticDefaultValue));
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00119B2C File Offset: 0x00117D2C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLevelHintAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLevelHintAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLevelHint"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLevelHint`")
			});
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00119BAB File Offset: 0x00117DAB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLevelHintAll.LogPair = null;
			ConfigMotorLevelHintAll.HandleId = 0;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00119BB9 File Offset: 0x00117DB9
		public static void Init()
		{
			ConfigMotorLevelHintAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLevelHintAll.HandleId, "db_motor.db", "select BinData from `MotorLevelHint`");
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00119BD4 File Offset: 0x00117DD4
		[NullableContext(2)]
		public static IReadOnlyList<MotorLevelHint> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLevelHintAll.HandleId, ConfigMotorLevelHintAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorLevelHint> readOnlyList = (IReadOnlyList<MotorLevelHint>)ConfigCommon.GetConfig("MotorLevelHintAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorLevelHint> list = new List<MotorLevelHint>();
			while (ConfigCommon.Step(ConfigMotorLevelHintAll.HandleId, false, ConfigMotorLevelHintAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLevelHintAll.HandleId, 0, ConfigMotorLevelHintAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorLevelHintAll.HandleId, ConfigMotorLevelHintAll.LogPair);
					return null;
				}
				MotorLevelHint rootAsMotorLevelHint = MotorLevelHint.GetRootAsMotorLevelHint(new ByteBuffer(item2));
				list.Add(rootAsMotorLevelHint);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorLevelHintAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorLevelHintAll.HandleId, ConfigMotorLevelHintAll.LogPair);
			return list;
		}

		// Token: 0x04002775 RID: 10101
		private const string DB = "db_motor.db";

		// Token: 0x04002776 RID: 10102
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002777 RID: 10103
		private const string TABLE = "MotorLevelHint";

		// Token: 0x04002778 RID: 10104
		private const string COMMAND = "select BinData from `MotorLevelHint`";

		// Token: 0x04002779 RID: 10105
		private const string KEY_PREFIX = "MotorLevelHintAll";

		// Token: 0x0400277A RID: 10106
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400277B RID: 10107
		private static int HandleId;
	}
}
