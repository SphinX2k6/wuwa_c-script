using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000949 RID: 2377
	public class ConfigSkillTreeByNodeGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037C9 RID: 14281 RVA: 0x00194D2C File Offset: 0x00192F2C
		static ConfigSkillTreeByNodeGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTreeByNodeGroup.CreateStaticDefaultValue), new Action(ConfigSkillTreeByNodeGroup.ResetStaticDefaultValue));
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00194D4C File Offset: 0x00192F4C
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

		// Token: 0x060037CB RID: 14283 RVA: 0x00194DCB File Offset: 0x00192FCB
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTreeByNodeGroup.LogPair = null;
			ConfigSkillTreeByNodeGroup.HandleId = 0;
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00194DD9 File Offset: 0x00192FD9
		public static void Init()
		{
			ConfigSkillTreeByNodeGroup.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTreeByNodeGroup.HandleId, "db_skilltree.db", "select BinData from `SkillTree` where NodeGroup=?");
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x00194DF4 File Offset: 0x00192FF4
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

		// Token: 0x040040E5 RID: 16613
		private const string DB = "db_skilltree.db";

		// Token: 0x040040E6 RID: 16614
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040040E7 RID: 16615
		private const string TABLE = "SkillTree";

		// Token: 0x040040E8 RID: 16616
		private const string COMMAND = "select BinData from `SkillTree` where NodeGroup=?";

		// Token: 0x040040E9 RID: 16617
		private const string KEY_PREFIX = "SkillTreeByNodeGroup";

		// Token: 0x040040EA RID: 16618
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040EB RID: 16619
		private static int HandleId;
	}
}
