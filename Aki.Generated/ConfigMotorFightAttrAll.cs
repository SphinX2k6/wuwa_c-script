using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000584 RID: 1412
	public class ConfigMotorFightAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002125 RID: 8485 RVA: 0x00114E64 File Offset: 0x00113064
		static ConfigMotorFightAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightAttrAll.CreateStaticDefaultValue), new Action(ConfigMotorFightAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00114E84 File Offset: 0x00113084
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightAttrAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightAttrAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightAttr`")
			});
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00114F03 File Offset: 0x00113103
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightAttrAll.LogPair = null;
			ConfigMotorFightAttrAll.HandleId = 0;
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00114F11 File Offset: 0x00113111
		public static void Init()
		{
			ConfigMotorFightAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightAttrAll.HandleId, "db_motorfight.db", "select BinData from `MotorFightAttr`");
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00114F2C File Offset: 0x0011312C
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightAttr> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightAttrAll.HandleId, ConfigMotorFightAttrAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorFightAttr> readOnlyList = (IReadOnlyList<MotorFightAttr>)ConfigCommon.GetConfig("MotorFightAttrAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorFightAttr> list = new List<MotorFightAttr>();
			while (ConfigCommon.Step(ConfigMotorFightAttrAll.HandleId, false, ConfigMotorFightAttrAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightAttrAll.HandleId, 0, ConfigMotorFightAttrAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightAttrAll.HandleId, ConfigMotorFightAttrAll.LogPair);
					return null;
				}
				MotorFightAttr rootAsMotorFightAttr = MotorFightAttr.GetRootAsMotorFightAttr(new ByteBuffer(item2));
				list.Add(rootAsMotorFightAttr);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorFightAttrAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightAttrAll.HandleId, ConfigMotorFightAttrAll.LogPair);
			return list;
		}

		// Token: 0x04002680 RID: 9856
		private const string DB = "db_motorfight.db";

		// Token: 0x04002681 RID: 9857
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002682 RID: 9858
		private const string TABLE = "MotorFightAttr";

		// Token: 0x04002683 RID: 9859
		private const string COMMAND = "select BinData from `MotorFightAttr`";

		// Token: 0x04002684 RID: 9860
		private const string KEY_PREFIX = "MotorFightAttrAll";

		// Token: 0x04002685 RID: 9861
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002686 RID: 9862
		private static int HandleId;
	}
}
