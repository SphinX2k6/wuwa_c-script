using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B7 RID: 1719
	public class ConfigPhantomVicePolishConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600285A RID: 10330 RVA: 0x0013DCC3 File Offset: 0x0013BEC3
		static ConfigPhantomVicePolishConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomVicePolishConfigAll.CreateStaticDefaultValue), new Action(ConfigPhantomVicePolishConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0013DCE4 File Offset: 0x0013BEE4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomVicePolishConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomVicePolishConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomVicePolishConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomVicePolishConfig`")
			});
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x0013DD63 File Offset: 0x0013BF63
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomVicePolishConfigAll.LogPair = null;
			ConfigPhantomVicePolishConfigAll.HandleId = 0;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0013DD71 File Offset: 0x0013BF71
		public static void Init()
		{
			ConfigPhantomVicePolishConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomVicePolishConfigAll.HandleId, "db_phantom.db", "select BinData from `PhantomVicePolishConfig`");
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0013DD8C File Offset: 0x0013BF8C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomVicePolishConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomVicePolishConfigAll.HandleId, ConfigPhantomVicePolishConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomVicePolishConfig> readOnlyList = (IReadOnlyList<PhantomVicePolishConfig>)ConfigCommon.GetConfig("PhantomVicePolishConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomVicePolishConfig> list = new List<PhantomVicePolishConfig>();
			while (ConfigCommon.Step(ConfigPhantomVicePolishConfigAll.HandleId, false, ConfigPhantomVicePolishConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomVicePolishConfigAll.HandleId, 0, ConfigPhantomVicePolishConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomVicePolishConfigAll.HandleId, ConfigPhantomVicePolishConfigAll.LogPair);
					return null;
				}
				PhantomVicePolishConfig rootAsPhantomVicePolishConfig = PhantomVicePolishConfig.GetRootAsPhantomVicePolishConfig(new ByteBuffer(item2));
				list.Add(rootAsPhantomVicePolishConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomVicePolishConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomVicePolishConfigAll.HandleId, ConfigPhantomVicePolishConfigAll.LogPair);
			return list;
		}

		// Token: 0x04002EE7 RID: 12007
		private const string DB = "db_phantom.db";

		// Token: 0x04002EE8 RID: 12008
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EE9 RID: 12009
		private const string TABLE = "PhantomVicePolishConfig";

		// Token: 0x04002EEA RID: 12010
		private const string COMMAND = "select BinData from `PhantomVicePolishConfig`";

		// Token: 0x04002EEB RID: 12011
		private const string KEY_PREFIX = "PhantomVicePolishConfigAll";

		// Token: 0x04002EEC RID: 12012
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EED RID: 12013
		private static int HandleId;
	}
}
