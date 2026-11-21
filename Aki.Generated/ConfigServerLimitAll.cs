using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094E RID: 2382
	public class ConfigServerLimitAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037E7 RID: 14311 RVA: 0x00198944 File Offset: 0x00196B44
		static ConfigServerLimitAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigServerLimitAll.CreateStaticDefaultValue), new Action(ConfigServerLimitAll.ResetStaticDefaultValue));
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x00198964 File Offset: 0x00196B64
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

		// Token: 0x060037E9 RID: 14313 RVA: 0x001989E3 File Offset: 0x00196BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigServerLimitAll.LogPair = null;
			ConfigServerLimitAll.HandleId = 0;
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x001989F1 File Offset: 0x00196BF1
		public static void Init()
		{
			ConfigServerLimitAll.HandleId = ConfigCommon.InitDataStatement(ConfigServerLimitAll.HandleId, "db_serverlimit.db", "select BinData from `ServerLimit`");
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00198A0C File Offset: 0x00196C0C
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

		// Token: 0x04004108 RID: 16648
		private const string DB = "db_serverlimit.db";

		// Token: 0x04004109 RID: 16649
		private const string FILE = "f.服务器限制.xlsx";

		// Token: 0x0400410A RID: 16650
		private const string TABLE = "ServerLimit";

		// Token: 0x0400410B RID: 16651
		private const string COMMAND = "select BinData from `ServerLimit`";

		// Token: 0x0400410C RID: 16652
		private const string KEY_PREFIX = "ServerLimitAll";

		// Token: 0x0400410D RID: 16653
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400410E RID: 16654
		private static int HandleId;
	}
}
