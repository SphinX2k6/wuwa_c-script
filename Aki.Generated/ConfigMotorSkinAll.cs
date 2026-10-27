using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C3 RID: 1475
	public class ConfigMotorSkinAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600229F RID: 8863 RVA: 0x0011D478 File Offset: 0x0011B678
		static ConfigMotorSkinAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSkinAll.CreateStaticDefaultValue), new Action(ConfigMotorSkinAll.ResetStaticDefaultValue));
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x0011D498 File Offset: 0x0011B698
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorSkinAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorSkinAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorSkin`")
			});
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x0011D517 File Offset: 0x0011B717
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSkinAll.LogPair = null;
			ConfigMotorSkinAll.HandleId = 0;
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x0011D525 File Offset: 0x0011B725
		public static void Init()
		{
			ConfigMotorSkinAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSkinAll.HandleId, "db_motordiy.db", "select BinData from `MotorSkin`");
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0011D540 File Offset: 0x0011B740
		[NullableContext(2)]
		public static IReadOnlyList<MotorSkin> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorSkinAll.HandleId, ConfigMotorSkinAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorSkin> readOnlyList = (IReadOnlyList<MotorSkin>)ConfigCommon.GetConfig("MotorSkinAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorSkin> list = new List<MotorSkin>();
			while (ConfigCommon.Step(ConfigMotorSkinAll.HandleId, false, ConfigMotorSkinAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorSkinAll.HandleId, 0, ConfigMotorSkinAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorSkinAll.HandleId, ConfigMotorSkinAll.LogPair);
					return null;
				}
				MotorSkin rootAsMotorSkin = MotorSkin.GetRootAsMotorSkin(new ByteBuffer(item2));
				list.Add(rootAsMotorSkin);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorSkinAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorSkinAll.HandleId, ConfigMotorSkinAll.LogPair);
			return list;
		}

		// Token: 0x04002839 RID: 10297
		private const string DB = "db_motordiy.db";

		// Token: 0x0400283A RID: 10298
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x0400283B RID: 10299
		private const string TABLE = "MotorSkin";

		// Token: 0x0400283C RID: 10300
		private const string COMMAND = "select BinData from `MotorSkin`";

		// Token: 0x0400283D RID: 10301
		private const string KEY_PREFIX = "MotorSkinAll";

		// Token: 0x0400283E RID: 10302
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400283F RID: 10303
		private static int HandleId;
	}
}
