using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000995 RID: 2453
	public class ConfigSkillTreeByNodeGroupAndNodeIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003991 RID: 14737 RVA: 0x001A2183 File Offset: 0x001A0383
		static ConfigSkillTreeByNodeGroupAndNodeIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTreeByNodeGroupAndNodeIndex.CreateStaticDefaultValue), new Action(ConfigSkillTreeByNodeGroupAndNodeIndex.ResetStaticDefaultValue));
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x001A21A4 File Offset: 0x001A03A4
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

		// Token: 0x06003993 RID: 14739 RVA: 0x001A2223 File Offset: 0x001A0423
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTreeByNodeGroupAndNodeIndex.LogPair = null;
			ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId = 0;
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x001A2231 File Offset: 0x001A0431
		public static void Init()
		{
			ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTreeByNodeGroupAndNodeIndex.HandleId, "db_skilltree.db", "select BinData from `SkillTree` where NodeGroup = ? AND NodeIndex = ?");
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x001A224C File Offset: 0x001A044C
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

		// Token: 0x040042F9 RID: 17145
		private const string DB = "db_skilltree.db";

		// Token: 0x040042FA RID: 17146
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040042FB RID: 17147
		private const string TABLE = "SkillTree";

		// Token: 0x040042FC RID: 17148
		private const string COMMAND = "select BinData from `SkillTree` where NodeGroup = ? AND NodeIndex = ?";

		// Token: 0x040042FD RID: 17149
		private const string KEY_PREFIX = "SkillTreeByNodeGroupAndNodeIndex";

		// Token: 0x040042FE RID: 17150
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042FF RID: 17151
		private static int HandleId;
	}
}
