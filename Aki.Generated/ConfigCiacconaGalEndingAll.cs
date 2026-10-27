using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000168 RID: 360
	public class ConfigCiacconaGalEndingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x000892B8 File Offset: 0x000874B8
		static ConfigCiacconaGalEndingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalEndingAll.CreateStaticDefaultValue), new Action(ConfigCiacconaGalEndingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000892D8 File Offset: 0x000874D8
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

		// Token: 0x06000873 RID: 2163 RVA: 0x00089357 File Offset: 0x00087557
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalEndingAll.LogPair = null;
			ConfigCiacconaGalEndingAll.HandleId = 0;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00089365 File Offset: 0x00087565
		public static void Init()
		{
			ConfigCiacconaGalEndingAll.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalEndingAll.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalEnding`");
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00089380 File Offset: 0x00087580
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

		// Token: 0x040009BC RID: 2492
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009BD RID: 2493
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009BE RID: 2494
		private const string TABLE = "CiacconaGalEnding";

		// Token: 0x040009BF RID: 2495
		private const string COMMAND = "select BinData from `CiacconaGalEnding`";

		// Token: 0x040009C0 RID: 2496
		private const string KEY_PREFIX = "CiacconaGalEndingAll";

		// Token: 0x040009C1 RID: 2497
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009C2 RID: 2498
		private static int HandleId;
	}
}
