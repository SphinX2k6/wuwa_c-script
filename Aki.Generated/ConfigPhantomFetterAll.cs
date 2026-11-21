using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AA RID: 1706
	public class ConfigPhantomFetterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600280C RID: 10252 RVA: 0x0013F9C8 File Offset: 0x0013DBC8
		static ConfigPhantomFetterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterAll.CreateStaticDefaultValue), new Action(ConfigPhantomFetterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x0013F9E8 File Offset: 0x0013DBE8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomFetterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomFetterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomFetter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomFetter`")
			});
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x0013FA67 File Offset: 0x0013DC67
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterAll.LogPair = null;
			ConfigPhantomFetterAll.HandleId = 0;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0013FA75 File Offset: 0x0013DC75
		public static void Init()
		{
			ConfigPhantomFetterAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterAll.HandleId, "db_phantom.db", "select BinData from `PhantomFetter`");
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0013FA90 File Offset: 0x0013DC90
		[NullableContext(2)]
		public static IReadOnlyList<PhantomFetter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomFetterAll.HandleId, ConfigPhantomFetterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomFetter> readOnlyList = (IReadOnlyList<PhantomFetter>)ConfigCommon.GetConfig("PhantomFetterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomFetter> list = new List<PhantomFetter>();
			while (ConfigCommon.Step(ConfigPhantomFetterAll.HandleId, false, ConfigPhantomFetterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomFetterAll.HandleId, 0, ConfigPhantomFetterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomFetterAll.HandleId, ConfigPhantomFetterAll.LogPair);
					return null;
				}
				PhantomFetter rootAsPhantomFetter = PhantomFetter.GetRootAsPhantomFetter(new ByteBuffer(item2));
				list.Add(rootAsPhantomFetter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomFetterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomFetterAll.HandleId, ConfigPhantomFetterAll.LogPair);
			return list;
		}

		// Token: 0x04002E8C RID: 11916
		private const string DB = "db_phantom.db";

		// Token: 0x04002E8D RID: 11917
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E8E RID: 11918
		private const string TABLE = "PhantomFetter";

		// Token: 0x04002E8F RID: 11919
		private const string COMMAND = "select BinData from `PhantomFetter`";

		// Token: 0x04002E90 RID: 11920
		private const string KEY_PREFIX = "PhantomFetterAll";

		// Token: 0x04002E91 RID: 11921
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E92 RID: 11922
		private static int HandleId;
	}
}
