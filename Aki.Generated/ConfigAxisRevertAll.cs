using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D7 RID: 215
	public class ConfigAxisRevertAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x00079D8F File Offset: 0x00077F8F
		static ConfigAxisRevertAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAxisRevertAll.CreateStaticDefaultValue), new Action(ConfigAxisRevertAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00079DB0 File Offset: 0x00077FB0
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

		// Token: 0x0600050D RID: 1293 RVA: 0x00079E2F File Offset: 0x0007802F
		public static void ResetStaticDefaultValue()
		{
			ConfigAxisRevertAll.LogPair = null;
			ConfigAxisRevertAll.HandleId = 0;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00079E3D File Offset: 0x0007803D
		public static void Init()
		{
			ConfigAxisRevertAll.HandleId = ConfigCommon.InitDataStatement(ConfigAxisRevertAll.HandleId, "db_menu.db", "select BinData from `AxisRevert`");
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00079E58 File Offset: 0x00078058
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

		// Token: 0x040005C5 RID: 1477
		private const string DB = "db_menu.db";

		// Token: 0x040005C6 RID: 1478
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040005C7 RID: 1479
		private const string TABLE = "AxisRevert";

		// Token: 0x040005C8 RID: 1480
		private const string COMMAND = "select BinData from `AxisRevert`";

		// Token: 0x040005C9 RID: 1481
		private const string KEY_PREFIX = "AxisRevertAll";

		// Token: 0x040005CA RID: 1482
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005CB RID: 1483
		private static int HandleId;
	}
}
