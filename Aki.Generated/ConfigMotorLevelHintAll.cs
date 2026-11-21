using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BE RID: 1470
	public class ConfigMotorLevelHintAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002281 RID: 8833 RVA: 0x001203F4 File Offset: 0x0011E5F4
		static ConfigMotorLevelHintAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLevelHintAll.CreateStaticDefaultValue), new Action(ConfigMotorLevelHintAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00120414 File Offset: 0x0011E614
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

		// Token: 0x06002283 RID: 8835 RVA: 0x00120493 File Offset: 0x0011E693
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLevelHintAll.LogPair = null;
			ConfigMotorLevelHintAll.HandleId = 0;
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x001204A1 File Offset: 0x0011E6A1
		public static void Init()
		{
			ConfigMotorLevelHintAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLevelHintAll.HandleId, "db_motor.db", "select BinData from `MotorLevelHint`");
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x001204BC File Offset: 0x0011E6BC
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

		// Token: 0x04002816 RID: 10262
		private const string DB = "db_motor.db";

		// Token: 0x04002817 RID: 10263
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002818 RID: 10264
		private const string TABLE = "MotorLevelHint";

		// Token: 0x04002819 RID: 10265
		private const string COMMAND = "select BinData from `MotorLevelHint`";

		// Token: 0x0400281A RID: 10266
		private const string KEY_PREFIX = "MotorLevelHintAll";

		// Token: 0x0400281B RID: 10267
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400281C RID: 10268
		private static int HandleId;
	}
}
