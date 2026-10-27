using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000903 RID: 2307
	public class ConfigServerLimitAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003625 RID: 13861 RVA: 0x0018B724 File Offset: 0x00189924
		static ConfigServerLimitAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigServerLimitAll.CreateStaticDefaultValue), new Action(ConfigServerLimitAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0018B744 File Offset: 0x00189944
		public static void CreateStaticDefaultValue()
		{
			ConfigServerLimitAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigServerLimitAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_serverlimit.db"),
				new ValueTuple<string, object>("文件", "f.服务器限制.xlsx"),
				new ValueTuple<string, object>("表名", "ServerLimit"),
				new ValueTuple<string, object>("语句", "select BinData from `ServerLimit`")
			});
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x0018B7C3 File Offset: 0x001899C3
		public static void ResetStaticDefaultValue()
		{
			ConfigServerLimitAll.LogPair = null;
			ConfigServerLimitAll.HandleId = 0;
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0018B7D1 File Offset: 0x001899D1
		public static void Init()
		{
			ConfigServerLimitAll.HandleId = ConfigCommon.InitDataStatement(ConfigServerLimitAll.HandleId, "db_serverlimit.db", "select BinData from `ServerLimit`");
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x0018B7EC File Offset: 0x001899EC
		[NullableContext(2)]
		public static IReadOnlyList<ServerLimit> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigServerLimitAll.HandleId, ConfigServerLimitAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ServerLimit> readOnlyList = (IReadOnlyList<ServerLimit>)ConfigCommon.GetConfig("ServerLimitAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ServerLimit> list = new List<ServerLimit>();
			while (ConfigCommon.Step(ConfigServerLimitAll.HandleId, false, ConfigServerLimitAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigServerLimitAll.HandleId, 0, ConfigServerLimitAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigServerLimitAll.HandleId, ConfigServerLimitAll.LogPair);
					return null;
				}
				ServerLimit rootAsServerLimit = ServerLimit.GetRootAsServerLimit(new ByteBuffer(item2));
				list.Add(rootAsServerLimit);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ServerLimitAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigServerLimitAll.HandleId, ConfigServerLimitAll.LogPair);
			return list;
		}

		// Token: 0x04003EFB RID: 16123
		private const string DB = "db_serverlimit.db";

		// Token: 0x04003EFC RID: 16124
		private const string FILE = "f.服务器限制.xlsx";

		// Token: 0x04003EFD RID: 16125
		private const string TABLE = "ServerLimit";

		// Token: 0x04003EFE RID: 16126
		private const string COMMAND = "select BinData from `ServerLimit`";

		// Token: 0x04003EFF RID: 16127
		private const string KEY_PREFIX = "ServerLimitAll";

		// Token: 0x04003F00 RID: 16128
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F01 RID: 16129
		private static int HandleId;
	}
}
