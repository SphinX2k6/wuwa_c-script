using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000508 RID: 1288
	public class ConfigMainTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E3B RID: 7739 RVA: 0x001040F8 File Offset: 0x001022F8
		static ConfigMainTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainTypeAll.CreateStaticDefaultValue), new Action(ConfigMainTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00104118 File Offset: 0x00102318
		public static void CreateStaticDefaultValue()
		{
			ConfigMainTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "MainType"),
				new ValueTuple<string, object>("语句", "select BinData from `MainType`")
			});
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00104197 File Offset: 0x00102397
		public static void ResetStaticDefaultValue()
		{
			ConfigMainTypeAll.LogPair = null;
			ConfigMainTypeAll.HandleId = 0;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x001041A5 File Offset: 0x001023A5
		public static void Init()
		{
			ConfigMainTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMainTypeAll.HandleId, "db_menu.db", "select BinData from `MainType`");
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x001041C0 File Offset: 0x001023C0
		[NullableContext(2)]
		public static IReadOnlyList<MainType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainTypeAll.HandleId, ConfigMainTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MainType> readOnlyList = (IReadOnlyList<MainType>)ConfigCommon.GetConfig("MainTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MainType> list = new List<MainType>();
			while (ConfigCommon.Step(ConfigMainTypeAll.HandleId, false, ConfigMainTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainTypeAll.HandleId, 0, ConfigMainTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMainTypeAll.HandleId, ConfigMainTypeAll.LogPair);
					return null;
				}
				MainType rootAsMainType = MainType.GetRootAsMainType(new ByteBuffer(item2));
				list.Add(rootAsMainType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MainTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMainTypeAll.HandleId, ConfigMainTypeAll.LogPair);
			return list;
		}

		// Token: 0x0400231C RID: 8988
		private const string DB = "db_menu.db";

		// Token: 0x0400231D RID: 8989
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x0400231E RID: 8990
		private const string TABLE = "MainType";

		// Token: 0x0400231F RID: 8991
		private const string COMMAND = "select BinData from `MainType`";

		// Token: 0x04002320 RID: 8992
		private const string KEY_PREFIX = "MainTypeAll";

		// Token: 0x04002321 RID: 8993
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002322 RID: 8994
		private static int HandleId;
	}
}
