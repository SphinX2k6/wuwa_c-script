using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000178 RID: 376
	public class ConfigCiacconaGalEndingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x0008EE14 File Offset: 0x0008D014
		static ConfigCiacconaGalEndingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalEndingAll.CreateStaticDefaultValue), new Action(ConfigCiacconaGalEndingAll.ResetStaticDefaultValue));
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0008EE34 File Offset: 0x0008D034
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalEndingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalEndingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalEnding`")
			});
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0008EEB3 File Offset: 0x0008D0B3
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalEndingAll.LogPair = null;
			ConfigCiacconaGalEndingAll.HandleId = 0;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0008EEC1 File Offset: 0x0008D0C1
		public static void Init()
		{
			ConfigCiacconaGalEndingAll.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalEndingAll.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalEnding`");
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0008EEDC File Offset: 0x0008D0DC
		[NullableContext(2)]
		public static IReadOnlyList<CiacconaGalEnding> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalEndingAll.HandleId, ConfigCiacconaGalEndingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CiacconaGalEnding> readOnlyList = (IReadOnlyList<CiacconaGalEnding>)ConfigCommon.GetConfig("CiacconaGalEndingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CiacconaGalEnding> list = new List<CiacconaGalEnding>();
			while (ConfigCommon.Step(ConfigCiacconaGalEndingAll.HandleId, false, ConfigCiacconaGalEndingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalEndingAll.HandleId, 0, ConfigCiacconaGalEndingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCiacconaGalEndingAll.HandleId, ConfigCiacconaGalEndingAll.LogPair);
					return null;
				}
				CiacconaGalEnding rootAsCiacconaGalEnding = CiacconaGalEnding.GetRootAsCiacconaGalEnding(new ByteBuffer(item2));
				list.Add(rootAsCiacconaGalEnding);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CiacconaGalEndingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCiacconaGalEndingAll.HandleId, ConfigCiacconaGalEndingAll.LogPair);
			return list;
		}

		// Token: 0x04000A2C RID: 2604
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A2D RID: 2605
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A2E RID: 2606
		private const string TABLE = "CiacconaGalEnding";

		// Token: 0x04000A2F RID: 2607
		private const string COMMAND = "select BinData from `CiacconaGalEnding`";

		// Token: 0x04000A30 RID: 2608
		private const string KEY_PREFIX = "CiacconaGalEndingAll";

		// Token: 0x04000A31 RID: 2609
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A32 RID: 2610
		private static int HandleId;
	}
}
