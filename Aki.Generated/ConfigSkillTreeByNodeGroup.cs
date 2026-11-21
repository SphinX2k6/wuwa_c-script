using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000994 RID: 2452
	public class ConfigSkillTreeByNodeGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600398B RID: 14731 RVA: 0x001A1F4C File Offset: 0x001A014C
		static ConfigSkillTreeByNodeGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTreeByNodeGroup.CreateStaticDefaultValue), new Action(ConfigSkillTreeByNodeGroup.ResetStaticDefaultValue));
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x001A1F6C File Offset: 0x001A016C
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillTreeByNodeGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillTreeByNodeGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "SkillTree"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillTree` where NodeGroup=?")
			});
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x001A1FEB File Offset: 0x001A01EB
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTreeByNodeGroup.LogPair = null;
			ConfigSkillTreeByNodeGroup.HandleId = 0;
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x001A1FF9 File Offset: 0x001A01F9
		public static void Init()
		{
			ConfigSkillTreeByNodeGroup.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTreeByNodeGroup.HandleId, "db_skilltree.db", "select BinData from `SkillTree` where NodeGroup=?");
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x001A2014 File Offset: 0x001A0214
		[NullableContext(2)]
		public static IReadOnlyList<SkillTree> GetConfigList(int p0NodeGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillTreeByNodeGroup.HandleId, ConfigSkillTreeByNodeGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTreeByNodeGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NodeGroup);
				IReadOnlyList<SkillTree> readOnlyList = (IReadOnlyList<SkillTree>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillTreeByNodeGroup.LogPair.Clear();
			ConfigSkillTreeByNodeGroup.LogPair.Add(new ValueTuple<string, object>("NodeGroup", p0NodeGroup));
			if (!ConfigCommon.BindInt(ConfigSkillTreeByNodeGroup.HandleId, 1, p0NodeGroup, ConfigSkillTreeByNodeGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillTreeByNodeGroup.HandleId, ConfigSkillTreeByNodeGroup.LogPair);
				return null;
			}
			List<SkillTree> list = new List<SkillTree>();
			while (ConfigCommon.Step(ConfigSkillTreeByNodeGroup.HandleId, false, ConfigSkillTreeByNodeGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillTreeByNodeGroup.HandleId, 0, ConfigSkillTreeByNodeGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillTreeByNodeGroup.HandleId, ConfigSkillTreeByNodeGroup.LogPair);
					return null;
				}
				SkillTree rootAsSkillTree = SkillTree.GetRootAsSkillTree(new ByteBuffer(item2));
				list.Add(rootAsSkillTree);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTreeByNodeGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NodeGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillTreeByNodeGroup.HandleId, ConfigSkillTreeByNodeGroup.LogPair);
			return list;
		}

		// Token: 0x040042F2 RID: 17138
		private const string DB = "db_skilltree.db";

		// Token: 0x040042F3 RID: 17139
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040042F4 RID: 17140
		private const string TABLE = "SkillTree";

		// Token: 0x040042F5 RID: 17141
		private const string COMMAND = "select BinData from `SkillTree` where NodeGroup=?";

		// Token: 0x040042F6 RID: 17142
		private const string KEY_PREFIX = "SkillTreeByNodeGroup";

		// Token: 0x040042F7 RID: 17143
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042F8 RID: 17144
		private static int HandleId;
	}
}
