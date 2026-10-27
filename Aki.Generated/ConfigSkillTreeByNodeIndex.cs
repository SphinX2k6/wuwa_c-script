using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094B RID: 2379
	public class ConfigSkillTreeByNodeIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037D5 RID: 14293 RVA: 0x00195201 File Offset: 0x00193401
		static ConfigSkillTreeByNodeIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTreeByNodeIndex.CreateStaticDefaultValue), new Action(ConfigSkillTreeByNodeIndex.ResetStaticDefaultValue));
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x00195220 File Offset: 0x00193420
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillTreeByNodeIndex.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillTreeByNodeIndex.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "SkillTree"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillTree` where NodeGroup = ?")
			});
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0019529F File Offset: 0x0019349F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTreeByNodeIndex.LogPair = null;
			ConfigSkillTreeByNodeIndex.HandleId = 0;
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x001952AD File Offset: 0x001934AD
		public static void Init()
		{
			ConfigSkillTreeByNodeIndex.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTreeByNodeIndex.HandleId, "db_skilltree.db", "select BinData from `SkillTree` where NodeGroup = ?");
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x001952C8 File Offset: 0x001934C8
		[NullableContext(2)]
		public static IReadOnlyList<SkillTree> GetConfigList(int p0NodeGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillTreeByNodeIndex.HandleId, ConfigSkillTreeByNodeIndex.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTreeByNodeIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NodeGroup);
				IReadOnlyList<SkillTree> readOnlyList = (IReadOnlyList<SkillTree>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillTreeByNodeIndex.LogPair.Clear();
			ConfigSkillTreeByNodeIndex.LogPair.Add(new ValueTuple<string, object>("NodeGroup", p0NodeGroup));
			if (!ConfigCommon.BindInt(ConfigSkillTreeByNodeIndex.HandleId, 1, p0NodeGroup, ConfigSkillTreeByNodeIndex.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillTreeByNodeIndex.HandleId, ConfigSkillTreeByNodeIndex.LogPair);
				return null;
			}
			List<SkillTree> list = new List<SkillTree>();
			while (ConfigCommon.Step(ConfigSkillTreeByNodeIndex.HandleId, false, ConfigSkillTreeByNodeIndex.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillTreeByNodeIndex.HandleId, 0, ConfigSkillTreeByNodeIndex.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillTreeByNodeIndex.HandleId, ConfigSkillTreeByNodeIndex.LogPair);
					return null;
				}
				SkillTree rootAsSkillTree = SkillTree.GetRootAsSkillTree(new ByteBuffer(item2));
				list.Add(rootAsSkillTree);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTreeByNodeIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NodeGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillTreeByNodeIndex.HandleId, ConfigSkillTreeByNodeIndex.LogPair);
			return list;
		}

		// Token: 0x040040F3 RID: 16627
		private const string DB = "db_skilltree.db";

		// Token: 0x040040F4 RID: 16628
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040040F5 RID: 16629
		private const string TABLE = "SkillTree";

		// Token: 0x040040F6 RID: 16630
		private const string COMMAND = "select BinData from `SkillTree` where NodeGroup = ?";

		// Token: 0x040040F7 RID: 16631
		private const string KEY_PREFIX = "SkillTreeByNodeIndex";

		// Token: 0x040040F8 RID: 16632
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040F9 RID: 16633
		private static int HandleId;
	}
}
