using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000503 RID: 1283
	public class ConfigMainLineAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E1D RID: 7709 RVA: 0x00103708 File Offset: 0x00101908
		static ConfigMainLineAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainLineAll.CreateStaticDefaultValue), new Action(ConfigMainLineAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00103728 File Offset: 0x00101928
		public static void CreateStaticDefaultValue()
		{
			ConfigMainLineAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainLineAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "MainLine"),
				new ValueTuple<string, object>("语句", "select BinData from `MainLine`")
			});
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x001037A7 File Offset: 0x001019A7
		public static void ResetStaticDefaultValue()
		{
			ConfigMainLineAll.LogPair = null;
			ConfigMainLineAll.HandleId = 0;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x001037B5 File Offset: 0x001019B5
		public static void Init()
		{
			ConfigMainLineAll.HandleId = ConfigCommon.InitDataStatement(ConfigMainLineAll.HandleId, "db_moonchasing.db", "select BinData from `MainLine`");
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x001037D0 File Offset: 0x001019D0
		[NullableContext(2)]
		public static IReadOnlyList<MainLine> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainLineAll.HandleId, ConfigMainLineAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MainLine> readOnlyList = (IReadOnlyList<MainLine>)ConfigCommon.GetConfig("MainLineAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MainLine> list = new List<MainLine>();
			while (ConfigCommon.Step(ConfigMainLineAll.HandleId, false, ConfigMainLineAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainLineAll.HandleId, 0, ConfigMainLineAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMainLineAll.HandleId, ConfigMainLineAll.LogPair);
					return null;
				}
				MainLine rootAsMainLine = MainLine.GetRootAsMainLine(new ByteBuffer(item2));
				list.Add(rootAsMainLine);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MainLineAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMainLineAll.HandleId, ConfigMainLineAll.LogPair);
			return list;
		}

		// Token: 0x040022F9 RID: 8953
		private const string DB = "db_moonchasing.db";

		// Token: 0x040022FA RID: 8954
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x040022FB RID: 8955
		private const string TABLE = "MainLine";

		// Token: 0x040022FC RID: 8956
		private const string COMMAND = "select BinData from `MainLine`";

		// Token: 0x040022FD RID: 8957
		private const string KEY_PREFIX = "MainLineAll";

		// Token: 0x040022FE RID: 8958
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022FF RID: 8959
		private static int HandleId;
	}
}
