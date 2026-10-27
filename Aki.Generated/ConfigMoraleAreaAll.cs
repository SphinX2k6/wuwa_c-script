using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000561 RID: 1377
	public class ConfigMoraleAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002053 RID: 8275 RVA: 0x00110274 File Offset: 0x0010E474
		static ConfigMoraleAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleAreaAll.CreateStaticDefaultValue), new Action(ConfigMoraleAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00110294 File Offset: 0x0010E494
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleAreaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleAreaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleArea"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleArea`")
			});
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00110313 File Offset: 0x0010E513
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleAreaAll.LogPair = null;
			ConfigMoraleAreaAll.HandleId = 0;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00110321 File Offset: 0x0010E521
		public static void Init()
		{
			ConfigMoraleAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleAreaAll.HandleId, "db_moraleplay.db", "select BinData from `MoraleArea`");
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0011033C File Offset: 0x0010E53C
		[NullableContext(2)]
		public static IReadOnlyList<MoraleArea> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleAreaAll.HandleId, ConfigMoraleAreaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MoraleArea> readOnlyList = (IReadOnlyList<MoraleArea>)ConfigCommon.GetConfig("MoraleAreaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MoraleArea> list = new List<MoraleArea>();
			while (ConfigCommon.Step(ConfigMoraleAreaAll.HandleId, false, ConfigMoraleAreaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleAreaAll.HandleId, 0, ConfigMoraleAreaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMoraleAreaAll.HandleId, ConfigMoraleAreaAll.LogPair);
					return null;
				}
				MoraleArea rootAsMoraleArea = MoraleArea.GetRootAsMoraleArea(new ByteBuffer(item2));
				list.Add(rootAsMoraleArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MoraleAreaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMoraleAreaAll.HandleId, ConfigMoraleAreaAll.LogPair);
			return list;
		}

		// Token: 0x0400258B RID: 9611
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400258C RID: 9612
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400258D RID: 9613
		private const string TABLE = "MoraleArea";

		// Token: 0x0400258E RID: 9614
		private const string COMMAND = "select BinData from `MoraleArea`";

		// Token: 0x0400258F RID: 9615
		private const string KEY_PREFIX = "MoraleAreaAll";

		// Token: 0x04002590 RID: 9616
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002591 RID: 9617
		private static int HandleId;
	}
}
