using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000987 RID: 2439
	public class ConfigSkillBySkillGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600393D RID: 14653 RVA: 0x001A0308 File Offset: 0x0019E508
		static ConfigSkillBySkillGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillBySkillGroupId.CreateStaticDefaultValue), new Action(ConfigSkillBySkillGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x001A0328 File Offset: 0x0019E528
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillBySkillGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillBySkillGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "Skill"),
				new ValueTuple<string, object>("语句", "select BinData from `Skill` where SkillGroupId = ?")
			});
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x001A03A7 File Offset: 0x0019E5A7
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillBySkillGroupId.LogPair = null;
			ConfigSkillBySkillGroupId.HandleId = 0;
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x001A03B5 File Offset: 0x0019E5B5
		public static void Init()
		{
			ConfigSkillBySkillGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillBySkillGroupId.HandleId, "db_skill.db", "select BinData from `Skill` where SkillGroupId = ?");
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x001A03D0 File Offset: 0x0019E5D0
		[NullableContext(2)]
		public static IReadOnlyList<Skill> GetConfigList(int p0SkillGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillBySkillGroupId.HandleId, ConfigSkillBySkillGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillBySkillGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkillGroupId);
				IReadOnlyList<Skill> readOnlyList = (IReadOnlyList<Skill>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillBySkillGroupId.LogPair.Clear();
			ConfigSkillBySkillGroupId.LogPair.Add(new ValueTuple<string, object>("SkillGroupId", p0SkillGroupId));
			if (!ConfigCommon.BindInt(ConfigSkillBySkillGroupId.HandleId, 1, p0SkillGroupId, ConfigSkillBySkillGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillBySkillGroupId.HandleId, ConfigSkillBySkillGroupId.LogPair);
				return null;
			}
			List<Skill> list = new List<Skill>();
			while (ConfigCommon.Step(ConfigSkillBySkillGroupId.HandleId, false, ConfigSkillBySkillGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillBySkillGroupId.HandleId, 0, ConfigSkillBySkillGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillBySkillGroupId.HandleId, ConfigSkillBySkillGroupId.LogPair);
					return null;
				}
				Skill rootAsSkill = Skill.GetRootAsSkill(new ByteBuffer(item2));
				list.Add(rootAsSkill);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillBySkillGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkillGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillBySkillGroupId.HandleId, ConfigSkillBySkillGroupId.LogPair);
			return list;
		}

		// Token: 0x04004297 RID: 17047
		private const string DB = "db_skill.db";

		// Token: 0x04004298 RID: 17048
		private const string FILE = "j.技能.xlsx";

		// Token: 0x04004299 RID: 17049
		private const string TABLE = "Skill";

		// Token: 0x0400429A RID: 17050
		private const string COMMAND = "select BinData from `Skill` where SkillGroupId = ?";

		// Token: 0x0400429B RID: 17051
		private const string KEY_PREFIX = "SkillBySkillGroupId";

		// Token: 0x0400429C RID: 17052
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400429D RID: 17053
		private static int HandleId;
	}
}
