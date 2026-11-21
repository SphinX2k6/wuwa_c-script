using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000788 RID: 1928
	public class ConfigQualityInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D41 RID: 11585 RVA: 0x0015C791 File Offset: 0x0015A991
		static ConfigQualityInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQualityInfoAll.CreateStaticDefaultValue), new Action(ConfigQualityInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x0015C7B0 File Offset: 0x0015A9B0
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

		// Token: 0x06002D43 RID: 11587 RVA: 0x0015C82F File Offset: 0x0015AA2F
		public static void ResetStaticDefaultValue()
		{
			ConfigQualityInfoAll.LogPair = null;
			ConfigQualityInfoAll.HandleId = 0;
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x0015C83D File Offset: 0x0015AA3D
		public static void Init()
		{
			ConfigQualityInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigQualityInfoAll.HandleId, "db_item.db", "select BinData from `QualityInfo`");
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x0015C858 File Offset: 0x0015AA58
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

		// Token: 0x0400349E RID: 13470
		private const string DB = "db_item.db";

		// Token: 0x0400349F RID: 13471
		private const string FILE = "d.道具.xlsx";

		// Token: 0x040034A0 RID: 13472
		private const string TABLE = "QualityInfo";

		// Token: 0x040034A1 RID: 13473
		private const string COMMAND = "select BinData from `QualityInfo`";

		// Token: 0x040034A2 RID: 13474
		private const string KEY_PREFIX = "QualityInfoAll";

		// Token: 0x040034A3 RID: 13475
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034A4 RID: 13476
		private static int HandleId;
	}
}
