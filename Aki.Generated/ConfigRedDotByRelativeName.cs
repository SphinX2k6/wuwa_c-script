using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DE RID: 2014
	public class ConfigRedDotByRelativeName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F46 RID: 12102 RVA: 0x0016812C File Offset: 0x0016632C
		static ConfigRedDotByRelativeName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRedDotByRelativeName.CreateStaticDefaultValue), new Action(ConfigRedDotByRelativeName.ResetStaticDefaultValue));
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0016814C File Offset: 0x0016634C
		public static void CreateStaticDefaultValue()
		{
			ConfigRedDotByRelativeName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRedDotByRelativeName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_reddot.db"),
				new ValueTuple<string, object>("文件", "h.红点.xlsx"),
				new ValueTuple<string, object>("表名", "RedDot"),
				new ValueTuple<string, object>("语句", "select BinData from `RedDot` where RelativeName IS NOT NULL")
			});
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x001681CB File Offset: 0x001663CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRedDotByRelativeName.LogPair = null;
			ConfigRedDotByRelativeName.HandleId = 0;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x001681D9 File Offset: 0x001663D9
		public static void Init()
		{
			ConfigRedDotByRelativeName.HandleId = ConfigCommon.InitDataStatement(ConfigRedDotByRelativeName.HandleId, "db_reddot.db", "select BinData from `RedDot` where RelativeName IS NOT NULL");
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x001681F4 File Offset: 0x001663F4
		[NullableContext(2)]
		public static IReadOnlyList<RedDot> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRedDotByRelativeName.HandleId, ConfigRedDotByRelativeName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RedDot> readOnlyList = (IReadOnlyList<RedDot>)ConfigCommon.GetConfig("RedDotByRelativeName");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RedDot> list = new List<RedDot>();
			while (ConfigCommon.Step(ConfigRedDotByRelativeName.HandleId, false, ConfigRedDotByRelativeName.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRedDotByRelativeName.HandleId, 0, ConfigRedDotByRelativeName.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRedDotByRelativeName.HandleId, ConfigRedDotByRelativeName.LogPair);
					return null;
				}
				RedDot rootAsRedDot = RedDot.GetRootAsRedDot(new ByteBuffer(item2));
				list.Add(rootAsRedDot);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RedDotByRelativeName", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRedDotByRelativeName.HandleId, ConfigRedDotByRelativeName.LogPair);
			return list;
		}

		// Token: 0x040036F8 RID: 14072
		private const string DB = "db_reddot.db";

		// Token: 0x040036F9 RID: 14073
		private const string FILE = "h.红点.xlsx";

		// Token: 0x040036FA RID: 14074
		private const string TABLE = "RedDot";

		// Token: 0x040036FB RID: 14075
		private const string COMMAND = "select BinData from `RedDot` where RelativeName IS NOT NULL";

		// Token: 0x040036FC RID: 14076
		private const string KEY_PREFIX = "RedDotByRelativeName";

		// Token: 0x040036FD RID: 14077
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036FE RID: 14078
		private static int HandleId;
	}
}
