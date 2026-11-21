using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051E RID: 1310
	public class ConfigMainTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EBF RID: 7871 RVA: 0x0010A84C File Offset: 0x00108A4C
		static ConfigMainTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainTypeAll.CreateStaticDefaultValue), new Action(ConfigMainTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0010A86C File Offset: 0x00108A6C
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

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0010A8EB File Offset: 0x00108AEB
		public static void ResetStaticDefaultValue()
		{
			ConfigMainTypeAll.LogPair = null;
			ConfigMainTypeAll.HandleId = 0;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x0010A8F9 File Offset: 0x00108AF9
		public static void Init()
		{
			ConfigMainTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigMainTypeAll.HandleId, "db_menu.db", "select BinData from `MainType`");
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0010A914 File Offset: 0x00108B14
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

		// Token: 0x040023B6 RID: 9142
		private const string DB = "db_menu.db";

		// Token: 0x040023B7 RID: 9143
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040023B8 RID: 9144
		private const string TABLE = "MainType";

		// Token: 0x040023B9 RID: 9145
		private const string COMMAND = "select BinData from `MainType`";

		// Token: 0x040023BA RID: 9146
		private const string KEY_PREFIX = "MainTypeAll";

		// Token: 0x040023BB RID: 9147
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023BC RID: 9148
		private static int HandleId;
	}
}
