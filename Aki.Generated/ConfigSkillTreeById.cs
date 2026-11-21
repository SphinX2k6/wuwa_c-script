using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000993 RID: 2451
	public class ConfigSkillTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003985 RID: 14725 RVA: 0x001A1D03 File Offset: 0x0019FF03
		static ConfigSkillTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTreeById.CreateStaticDefaultValue), new Action(ConfigSkillTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x001A1D24 File Offset: 0x0019FF24
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

		// Token: 0x06003987 RID: 14727 RVA: 0x001A1DA3 File Offset: 0x0019FFA3
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTreeById.LogPair = null;
			ConfigSkillTreeById.HandleId = 0;
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x001A1DB1 File Offset: 0x0019FFB1
		public static void Init()
		{
			ConfigSkillTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTreeById.HandleId, "db_skilltree.db", "select BinData from `SkillTree` where Id = ?");
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x001A1DCC File Offset: 0x0019FFCC
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

		// Token: 0x040042EB RID: 17131
		private const string DB = "db_skilltree.db";

		// Token: 0x040042EC RID: 17132
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040042ED RID: 17133
		private const string TABLE = "SkillTree";

		// Token: 0x040042EE RID: 17134
		private const string COMMAND = "select BinData from `SkillTree` where Id = ?";

		// Token: 0x040042EF RID: 17135
		private const string KEY_PREFIX = "SkillTreeById";

		// Token: 0x040042F0 RID: 17136
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042F1 RID: 17137
		private static int HandleId;
	}
}
