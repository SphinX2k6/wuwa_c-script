using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093C RID: 2364
	public class ConfigSkillBySkillGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600377B RID: 14203 RVA: 0x001930E8 File Offset: 0x001912E8
		static ConfigSkillBySkillGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillBySkillGroupId.CreateStaticDefaultValue), new Action(ConfigSkillBySkillGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00193108 File Offset: 0x00191308
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

		// Token: 0x0600377D RID: 14205 RVA: 0x00193187 File Offset: 0x00191387
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillBySkillGroupId.LogPair = null;
			ConfigSkillBySkillGroupId.HandleId = 0;
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x00193195 File Offset: 0x00191395
		public static void Init()
		{
			ConfigSkillBySkillGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillBySkillGroupId.HandleId, "db_skill.db", "select BinData from `Skill` where SkillGroupId = ?");
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x001931B0 File Offset: 0x001913B0
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

		// Token: 0x0400408A RID: 16522
		private const string DB = "db_skill.db";

		// Token: 0x0400408B RID: 16523
		private const string FILE = "j.技能.xlsx";

		// Token: 0x0400408C RID: 16524
		private const string TABLE = "Skill";

		// Token: 0x0400408D RID: 16525
		private const string COMMAND = "select BinData from `Skill` where SkillGroupId = ?";

		// Token: 0x0400408E RID: 16526
		private const string KEY_PREFIX = "SkillBySkillGroupId";

		// Token: 0x0400408F RID: 16527
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004090 RID: 16528
		private static int HandleId;
	}
}
