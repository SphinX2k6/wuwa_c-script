using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000948 RID: 2376
	public class ConfigSkillTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037C3 RID: 14275 RVA: 0x00194AE3 File Offset: 0x00192CE3
		static ConfigSkillTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTreeById.CreateStaticDefaultValue), new Action(ConfigSkillTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00194B04 File Offset: 0x00192D04
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "SkillTree"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillTree` where Id = ?")
			});
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00194B83 File Offset: 0x00192D83
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTreeById.LogPair = null;
			ConfigSkillTreeById.HandleId = 0;
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00194B91 File Offset: 0x00192D91
		public static void Init()
		{
			ConfigSkillTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTreeById.HandleId, "db_skilltree.db", "select BinData from `SkillTree` where Id = ?");
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00194BAC File Offset: 0x00192DAC
		public static SkillTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillTreeById.HandleId, ConfigSkillTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillTree?(SkillTree.GetRootAsSkillTree(configBuffer));
				}
			}
			ConfigSkillTreeById.LogPair.Clear();
			ConfigSkillTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillTreeById.HandleId, 1, p0Id, ConfigSkillTreeById.LogPair) || ConfigCommon.Step(ConfigSkillTreeById.HandleId, true, ConfigSkillTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillTreeById.HandleId, ConfigSkillTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillTreeById.HandleId, 0, ConfigSkillTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillTreeById.HandleId, ConfigSkillTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillTree rootAsSkillTree = SkillTree.GetRootAsSkillTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillTreeById.HandleId, ConfigSkillTreeById.LogPair);
			return new SkillTree?(rootAsSkillTree);
		}

		// Token: 0x040040DE RID: 16606
		private const string DB = "db_skilltree.db";

		// Token: 0x040040DF RID: 16607
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040040E0 RID: 16608
		private const string TABLE = "SkillTree";

		// Token: 0x040040E1 RID: 16609
		private const string COMMAND = "select BinData from `SkillTree` where Id = ?";

		// Token: 0x040040E2 RID: 16610
		private const string KEY_PREFIX = "SkillTreeById";

		// Token: 0x040040E3 RID: 16611
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040E4 RID: 16612
		private static int HandleId;
	}
}
