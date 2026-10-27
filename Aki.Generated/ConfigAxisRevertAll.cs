using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C8 RID: 200
	public class ConfigAxisRevertAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x0007442B File Offset: 0x0007262B
		static ConfigAxisRevertAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisRevertAll.CreateStaticDefaultValue), new Action(ConfigAxisRevertAll.ResetStaticDefaultValue));
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0007444C File Offset: 0x0007264C
		public static void CreateStaticDefaultValue()
		{
			ConfigAxisRevertAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAxisRevertAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "AxisRevert"),
				new ValueTuple<string, object>("语句", "select BinData from `AxisRevert`")
			});
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000744CB File Offset: 0x000726CB
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisRevertAll.LogPair = null;
			ConfigAxisRevertAll.HandleId = 0;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000744D9 File Offset: 0x000726D9
		public static void Init()
		{
			ConfigAxisRevertAll.HandleId = ConfigCommon.InitDataStatement(ConfigAxisRevertAll.HandleId, "db_menu.db", "select BinData from `AxisRevert`");
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000744F4 File Offset: 0x000726F4
		[NullableContext(2)]
		public static IReadOnlyList<AxisRevert> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAxisRevertAll.HandleId, ConfigAxisRevertAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AxisRevert> readOnlyList = (IReadOnlyList<AxisRevert>)ConfigCommon.GetConfig("AxisRevertAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AxisRevert> list = new List<AxisRevert>();
			while (ConfigCommon.Step(ConfigAxisRevertAll.HandleId, false, ConfigAxisRevertAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAxisRevertAll.HandleId, 0, ConfigAxisRevertAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAxisRevertAll.HandleId, ConfigAxisRevertAll.LogPair);
					return null;
				}
				AxisRevert rootAsAxisRevert = AxisRevert.GetRootAsAxisRevert(new ByteBuffer(item2));
				list.Add(rootAsAxisRevert);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AxisRevertAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAxisRevertAll.HandleId, ConfigAxisRevertAll.LogPair);
			return list;
		}

		// Token: 0x0400055C RID: 1372
		private const string DB = "db_menu.db";

		// Token: 0x0400055D RID: 1373
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x0400055E RID: 1374
		private const string TABLE = "AxisRevert";

		// Token: 0x0400055F RID: 1375
		private const string COMMAND = "select BinData from `AxisRevert`";

		// Token: 0x04000560 RID: 1376
		private const string KEY_PREFIX = "AxisRevertAll";

		// Token: 0x04000561 RID: 1377
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000562 RID: 1378
		private static int HandleId;
	}
}
