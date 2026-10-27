using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094A RID: 2378
	public class ConfigSkillTreeByNodeGroupAndNodeIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037CF RID: 14287 RVA: 0x00194F63 File Offset: 0x00193163
		static ConfigSkillTreeByNodeGroupAndNodeIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTreeByNodeGroupAndNodeIndex.CreateStaticDefaultValue), new Action(ConfigSkillTreeByNodeGroupAndNodeIndex.ResetStaticDefaultValue));
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00194F84 File Offset: 0x00193184
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "SkillTree"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillTree` where NodeGroup = ? AND NodeIndex = ?")
			});
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00195003 File Offset: 0x00193203
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair = null;
			ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId = 0;
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00195011 File Offset: 0x00193211
		public static void Init()
		{
			ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, "db_skilltree.db", "select BinData from `SkillTree` where NodeGroup = ? AND NodeIndex = ?");
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x0019502C File Offset: 0x0019322C
		public static SkillTree? GetConfig(int p0NodeGroup, int p1NodeIndex, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTreeByNodeGroupAndNodeIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NodeGroup);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1NodeIndex);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillTree?(SkillTree.GetRootAsSkillTree(configBuffer));
				}
			}
			ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair.Clear();
			ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair.Add(new ValueTuple<string, object>("NodeGroup", p0NodeGroup));
			ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair.Add(new ValueTuple<string, object>("NodeIndex", p1NodeIndex));
			if (!ConfigCommon.BindInt(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, 1, p0NodeGroup, ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair) || !ConfigCommon.BindInt(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, 2, p1NodeIndex, ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair) || ConfigCommon.Step(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, true, ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, 0, ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillTree rootAsSkillTree = SkillTree.GetRootAsSkillTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTreeByNodeGroupAndNodeIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NodeGroup);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1NodeIndex);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair);
			return new SkillTree?(rootAsSkillTree);
		}

		// Token: 0x040040EC RID: 16620
		private const string DB = "db_skilltree.db";

		// Token: 0x040040ED RID: 16621
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040040EE RID: 16622
		private const string TABLE = "SkillTree";

		// Token: 0x040040EF RID: 16623
		private const string COMMAND = "select BinData from `SkillTree` where NodeGroup = ? AND NodeIndex = ?";

		// Token: 0x040040F0 RID: 16624
		private const string KEY_PREFIX = "SkillTreeByNodeGroupAndNodeIndex";

		// Token: 0x040040F1 RID: 16625
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040F2 RID: 16626
		private static int HandleId;
	}
}
