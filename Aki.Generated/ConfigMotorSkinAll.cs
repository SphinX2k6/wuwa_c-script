using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DA RID: 1498
	public class ConfigMotorSkinAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002329 RID: 9001 RVA: 0x00123D60 File Offset: 0x00121F60
		static ConfigMotorSkinAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSkinAll.CreateStaticDefaultValue), new Action(ConfigMotorSkinAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00123D80 File Offset: 0x00121F80
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

		// Token: 0x0600232B RID: 9003 RVA: 0x00123DFF File Offset: 0x00121FFF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSkinAll.LogPair = null;
			ConfigMotorSkinAll.HandleId = 0;
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00123E0D File Offset: 0x0012200D
		public static void Init()
		{
			ConfigMotorSkinAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSkinAll.HandleId, "db_motordiy.db", "select BinData from `MotorSkin`");
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00123E28 File Offset: 0x00122028
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

		// Token: 0x040028DA RID: 10458
		private const string DB = "db_motordiy.db";

		// Token: 0x040028DB RID: 10459
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040028DC RID: 10460
		private const string TABLE = "MotorSkin";

		// Token: 0x040028DD RID: 10461
		private const string COMMAND = "select BinData from `MotorSkin`";

		// Token: 0x040028DE RID: 10462
		private const string KEY_PREFIX = "MotorSkinAll";

		// Token: 0x040028DF RID: 10463
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028E0 RID: 10464
		private static int HandleId;
	}
}
