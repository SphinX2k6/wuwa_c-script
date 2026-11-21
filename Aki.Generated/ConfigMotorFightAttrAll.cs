using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059B RID: 1435
	public class ConfigMotorFightAttrAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021AF RID: 8623 RVA: 0x0011B74C File Offset: 0x0011994C
		static ConfigMotorFightAttrAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightAttrAll.CreateStaticDefaultValue), new Action(ConfigMotorFightAttrAll.ResetStaticDefaultValue));
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0011B76C File Offset: 0x0011996C
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

		// Token: 0x060021B1 RID: 8625 RVA: 0x0011B7EB File Offset: 0x001199EB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightAttrAll.LogPair = null;
			ConfigMotorFightAttrAll.HandleId = 0;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0011B7F9 File Offset: 0x001199F9
		public static void Init()
		{
			ConfigMotorFightAttrAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightAttrAll.HandleId, "db_motorfight.db", "select BinData from `MotorFightAttr`");
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0011B814 File Offset: 0x00119A14
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

		// Token: 0x04002721 RID: 10017
		private const string DB = "db_motorfight.db";

		// Token: 0x04002722 RID: 10018
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002723 RID: 10019
		private const string TABLE = "MotorFightAttr";

		// Token: 0x04002724 RID: 10020
		private const string COMMAND = "select BinData from `MotorFightAttr`";

		// Token: 0x04002725 RID: 10021
		private const string KEY_PREFIX = "MotorFightAttrAll";

		// Token: 0x04002726 RID: 10022
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002727 RID: 10023
		private static int HandleId;
	}
}
