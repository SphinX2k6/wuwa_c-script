using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025D RID: 605
	public class ConfigElementalReactionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E32 RID: 3634 RVA: 0x000A9B90 File Offset: 0x000A7D90
		static ConfigElementalReactionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementalReactionAll.CreateStaticDefaultValue), new Action(ConfigElementalReactionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x000A9BB0 File Offset: 0x000A7DB0
		public static void CreateStaticDefaultValue()
		{
			ConfigElementalReactionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementalReactionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_element_info.db"),
				new ValueTuple<string, object>("文件", "y.元素属性.xlsx"),
				new ValueTuple<string, object>("表名", "ElementalReaction"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementalReaction`")
			});
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000A9C2F File Offset: 0x000A7E2F
		public static void ResetStaticDefaultValue()
		{
			ConfigElementalReactionAll.LogPair = null;
			ConfigElementalReactionAll.HandleId = 0;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000A9C3D File Offset: 0x000A7E3D
		public static void Init()
		{
			ConfigElementalReactionAll.HandleId = ConfigCommon.InitDataStatement(ConfigElementalReactionAll.HandleId, "db_element_info.db", "select BinData from `ElementalReaction`");
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000A9C58 File Offset: 0x000A7E58
		[NullableContext(2)]
		public static IReadOnlyList<ElementalReaction> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementalReactionAll.HandleId, ConfigElementalReactionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ElementalReaction> readOnlyList = (IReadOnlyList<ElementalReaction>)ConfigCommon.GetConfig("ElementalReactionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ElementalReaction> list = new List<ElementalReaction>();
			while (ConfigCommon.Step(ConfigElementalReactionAll.HandleId, false, ConfigElementalReactionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementalReactionAll.HandleId, 0, ConfigElementalReactionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigElementalReactionAll.HandleId, ConfigElementalReactionAll.LogPair);
					return null;
				}
				ElementalReaction rootAsElementalReaction = ElementalReaction.GetRootAsElementalReaction(new ByteBuffer(item2));
				list.Add(rootAsElementalReaction);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ElementalReactionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigElementalReactionAll.HandleId, ConfigElementalReactionAll.LogPair);
			return list;
		}

		// Token: 0x0400106F RID: 4207
		private const string DB = "db_element_info.db";

		// Token: 0x04001070 RID: 4208
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x04001071 RID: 4209
		private const string TABLE = "ElementalReaction";

		// Token: 0x04001072 RID: 4210
		private const string COMMAND = "select BinData from `ElementalReaction`";

		// Token: 0x04001073 RID: 4211
		private const string KEY_PREFIX = "ElementalReactionAll";

		// Token: 0x04001074 RID: 4212
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001075 RID: 4213
		private static int HandleId;
	}
}
