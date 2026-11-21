using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A6 RID: 1702
	public class ConfigPhantomDirectRefiningAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027F4 RID: 10228 RVA: 0x0013F210 File Offset: 0x0013D410
		static ConfigPhantomDirectRefiningAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomDirectRefiningAll.CreateStaticDefaultValue), new Action(ConfigPhantomDirectRefiningAll.ResetStaticDefaultValue));
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0013F230 File Offset: 0x0013D430
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

		// Token: 0x060027F6 RID: 10230 RVA: 0x0013F2AF File Offset: 0x0013D4AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomDirectRefiningAll.LogPair = null;
			ConfigPhantomDirectRefiningAll.HandleId = 0;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x0013F2BD File Offset: 0x0013D4BD
		public static void Init()
		{
			ConfigPhantomDirectRefiningAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomDirectRefiningAll.HandleId, "db_calabash.db", "select BinData from `PhantomDirectRefining`");
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0013F2D8 File Offset: 0x0013D4D8
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

		// Token: 0x04002E70 RID: 11888
		private const string DB = "db_calabash.db";

		// Token: 0x04002E71 RID: 11889
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04002E72 RID: 11890
		private const string TABLE = "PhantomDirectRefining";

		// Token: 0x04002E73 RID: 11891
		private const string COMMAND = "select BinData from `PhantomDirectRefining`";

		// Token: 0x04002E74 RID: 11892
		private const string KEY_PREFIX = "PhantomDirectRefiningAll";

		// Token: 0x04002E75 RID: 11893
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E76 RID: 11894
		private static int HandleId;
	}
}
