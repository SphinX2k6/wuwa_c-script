using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CF RID: 1743
	public class ConfigPhantomVicePolishConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028EA RID: 10474 RVA: 0x0014473F File Offset: 0x0014293F
		static ConfigPhantomVicePolishConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomVicePolishConfigAll.CreateStaticDefaultValue), new Action(ConfigPhantomVicePolishConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00144760 File Offset: 0x00142960
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

		// Token: 0x060028EC RID: 10476 RVA: 0x001447DF File Offset: 0x001429DF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomVicePolishConfigAll.LogPair = null;
			ConfigPhantomVicePolishConfigAll.HandleId = 0;
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x001447ED File Offset: 0x001429ED
		public static void Init()
		{
			ConfigPhantomVicePolishConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomVicePolishConfigAll.HandleId, "db_phantom.db", "select BinData from `PhantomVicePolishConfig`");
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00144808 File Offset: 0x00142A08
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

		// Token: 0x04002F8F RID: 12175
		private const string DB = "db_phantom.db";

		// Token: 0x04002F90 RID: 12176
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F91 RID: 12177
		private const string TABLE = "PhantomVicePolishConfig";

		// Token: 0x04002F92 RID: 12178
		private const string COMMAND = "select BinData from `PhantomVicePolishConfig`";

		// Token: 0x04002F93 RID: 12179
		private const string KEY_PREFIX = "PhantomVicePolishConfigAll";

		// Token: 0x04002F94 RID: 12180
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F95 RID: 12181
		private static int HandleId;
	}
}
