using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000996 RID: 2454
	public class ConfigSkillTreeByNodeIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003997 RID: 14743 RVA: 0x001A2421 File Offset: 0x001A0621
		static ConfigSkillTreeByNodeIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTreeByNodeIndex.CreateStaticDefaultValue), new Action(ConfigSkillTreeByNodeIndex.ResetStaticDefaultValue));
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x001A2440 File Offset: 0x001A0640
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

		// Token: 0x06003999 RID: 14745 RVA: 0x001A24BF File Offset: 0x001A06BF
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTreeByNodeIndex.LogPair = null;
			ConfigSkillTreeByNodeIndex.HandleId = 0;
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x001A24CD File Offset: 0x001A06CD
		public static void Init()
		{
			ConfigSkillTreeByNodeIndex.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTreeByNodeIndex.HandleId, "db_skilltree.db", "select BinData from `SkillTree` where NodeGroup = ?");
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x001A24E8 File Offset: 0x001A06E8
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

		// Token: 0x04004300 RID: 17152
		private const string DB = "db_skilltree.db";

		// Token: 0x04004301 RID: 17153
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x04004302 RID: 17154
		private const string TABLE = "SkillTree";

		// Token: 0x04004303 RID: 17155
		private const string COMMAND = "select BinData from `SkillTree` where NodeGroup = ?";

		// Token: 0x04004304 RID: 17156
		private const string KEY_PREFIX = "SkillTreeByNodeIndex";

		// Token: 0x04004305 RID: 17157
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004306 RID: 17158
		private static int HandleId;
	}
}
