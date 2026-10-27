using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076E RID: 1902
	public class ConfigQualityInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CA5 RID: 11429 RVA: 0x00155885 File Offset: 0x00153A85
		static ConfigQualityInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQualityInfoAll.CreateStaticDefaultValue), new Action(ConfigQualityInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x001558A4 File Offset: 0x00153AA4
		public static void CreateStaticDefaultValue()
		{
			ConfigQualityInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQualityInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "QualityInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `QualityInfo`")
			});
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00155923 File Offset: 0x00153B23
		public static void ResetStaticDefaultValue()
		{
			ConfigQualityInfoAll.LogPair = null;
			ConfigQualityInfoAll.HandleId = 0;
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00155931 File Offset: 0x00153B31
		public static void Init()
		{
			ConfigQualityInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigQualityInfoAll.HandleId, "db_item.db", "select BinData from `QualityInfo`");
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x0015594C File Offset: 0x00153B4C
		[NullableContext(2)]
		public static IReadOnlyList<QualityInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQualityInfoAll.HandleId, ConfigQualityInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QualityInfo> readOnlyList = (IReadOnlyList<QualityInfo>)ConfigCommon.GetConfig("QualityInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QualityInfo> list = new List<QualityInfo>();
			while (ConfigCommon.Step(ConfigQualityInfoAll.HandleId, false, ConfigQualityInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQualityInfoAll.HandleId, 0, ConfigQualityInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQualityInfoAll.HandleId, ConfigQualityInfoAll.LogPair);
					return null;
				}
				QualityInfo rootAsQualityInfo = QualityInfo.GetRootAsQualityInfo(new ByteBuffer(item2));
				list.Add(rootAsQualityInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QualityInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQualityInfoAll.HandleId, ConfigQualityInfoAll.LogPair);
			return list;
		}

		// Token: 0x040033E8 RID: 13288
		private const string DB = "db_item.db";

		// Token: 0x040033E9 RID: 13289
		private const string FILE = "d.道具.xlsx";

		// Token: 0x040033EA RID: 13290
		private const string TABLE = "QualityInfo";

		// Token: 0x040033EB RID: 13291
		private const string COMMAND = "select BinData from `QualityInfo`";

		// Token: 0x040033EC RID: 13292
		private const string KEY_PREFIX = "QualityInfoAll";

		// Token: 0x040033ED RID: 13293
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033EE RID: 13294
		private static int HandleId;
	}
}
