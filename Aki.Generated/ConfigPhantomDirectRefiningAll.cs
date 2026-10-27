using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068E RID: 1678
	public class ConfigPhantomDirectRefiningAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002764 RID: 10084 RVA: 0x00138794 File Offset: 0x00136994
		static ConfigPhantomDirectRefiningAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomDirectRefiningAll.CreateStaticDefaultValue), new Action(ConfigPhantomDirectRefiningAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x001387B4 File Offset: 0x001369B4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomDirectRefiningAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomDirectRefiningAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomDirectRefining"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomDirectRefining`")
			});
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00138833 File Offset: 0x00136A33
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomDirectRefiningAll.LogPair = null;
			ConfigPhantomDirectRefiningAll.HandleId = 0;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00138841 File Offset: 0x00136A41
		public static void Init()
		{
			ConfigPhantomDirectRefiningAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomDirectRefiningAll.HandleId, "db_calabash.db", "select BinData from `PhantomDirectRefining`");
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0013885C File Offset: 0x00136A5C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomDirectRefining> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomDirectRefiningAll.HandleId, ConfigPhantomDirectRefiningAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomDirectRefining> readOnlyList = (IReadOnlyList<PhantomDirectRefining>)ConfigCommon.GetConfig("PhantomDirectRefiningAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomDirectRefining> list = new List<PhantomDirectRefining>();
			while (ConfigCommon.Step(ConfigPhantomDirectRefiningAll.HandleId, false, ConfigPhantomDirectRefiningAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomDirectRefiningAll.HandleId, 0, ConfigPhantomDirectRefiningAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomDirectRefiningAll.HandleId, ConfigPhantomDirectRefiningAll.LogPair);
					return null;
				}
				PhantomDirectRefining rootAsPhantomDirectRefining = PhantomDirectRefining.GetRootAsPhantomDirectRefining(new ByteBuffer(item2));
				list.Add(rootAsPhantomDirectRefining);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomDirectRefiningAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomDirectRefiningAll.HandleId, ConfigPhantomDirectRefiningAll.LogPair);
			return list;
		}

		// Token: 0x04002DC8 RID: 11720
		private const string DB = "db_calabash.db";

		// Token: 0x04002DC9 RID: 11721
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04002DCA RID: 11722
		private const string TABLE = "PhantomDirectRefining";

		// Token: 0x04002DCB RID: 11723
		private const string COMMAND = "select BinData from `PhantomDirectRefining`";

		// Token: 0x04002DCC RID: 11724
		private const string KEY_PREFIX = "PhantomDirectRefiningAll";

		// Token: 0x04002DCD RID: 11725
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DCE RID: 11726
		private static int HandleId;
	}
}
