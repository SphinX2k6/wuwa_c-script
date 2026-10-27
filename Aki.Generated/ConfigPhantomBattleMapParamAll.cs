using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067A RID: 1658
	public class ConfigPhantomBattleMapParamAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026EC RID: 9964 RVA: 0x00135CF3 File Offset: 0x00133EF3
		static ConfigPhantomBattleMapParamAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMapParamAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMapParamAll.ResetStaticDefaultValue));
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00135D14 File Offset: 0x00133F14
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMapParamAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMapParam"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMapParam`")
			});
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00135D93 File Offset: 0x00133F93
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamAll.LogPair = null;
			ConfigPhantomBattleMapParamAll.HandleId = 0;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00135DA1 File Offset: 0x00133FA1
		public static void Init()
		{
			ConfigPhantomBattleMapParamAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMapParamAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMapParam`");
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00135DBC File Offset: 0x00133FBC
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleMapParam> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMapParamAll.HandleId, ConfigPhantomBattleMapParamAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleMapParam> readOnlyList = (IReadOnlyList<PhantomBattleMapParam>)ConfigCommon.GetConfig("PhantomBattleMapParamAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleMapParam> list = new List<PhantomBattleMapParam>();
			while (ConfigCommon.Step(ConfigPhantomBattleMapParamAll.HandleId, false, ConfigPhantomBattleMapParamAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMapParamAll.HandleId, 0, ConfigPhantomBattleMapParamAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleMapParamAll.HandleId, ConfigPhantomBattleMapParamAll.LogPair);
					return null;
				}
				PhantomBattleMapParam rootAsPhantomBattleMapParam = PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleMapParam);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleMapParamAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMapParamAll.HandleId, ConfigPhantomBattleMapParamAll.LogPair);
			return list;
		}

		// Token: 0x04002D3C RID: 11580
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D3D RID: 11581
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D3E RID: 11582
		private const string TABLE = "PhantomBattleMapParam";

		// Token: 0x04002D3F RID: 11583
		private const string COMMAND = "select BinData from `PhantomBattleMapParam`";

		// Token: 0x04002D40 RID: 11584
		private const string KEY_PREFIX = "PhantomBattleMapParamAll";

		// Token: 0x04002D41 RID: 11585
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D42 RID: 11586
		private static int HandleId;
	}
}
