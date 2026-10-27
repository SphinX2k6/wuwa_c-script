using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000940 RID: 2368
	public class ConfigSkillDescriptionBySkillLevelGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003793 RID: 14227 RVA: 0x00193944 File Offset: 0x00191B44
		static ConfigSkillDescriptionBySkillLevelGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillDescriptionBySkillLevelGroupId.CreateStaticDefaultValue), new Action(ConfigSkillDescriptionBySkillLevelGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x00193964 File Offset: 0x00191B64
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillDescriptionBySkillLevelGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillDescriptionBySkillLevelGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "SkillDescription"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillDescription` where SkillLevelGroupId = ?")
			});
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x001939E3 File Offset: 0x00191BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillDescriptionBySkillLevelGroupId.LogPair = null;
			ConfigSkillDescriptionBySkillLevelGroupId.HandleId = 0;
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x001939F1 File Offset: 0x00191BF1
		public static void Init()
		{
			ConfigSkillDescriptionBySkillLevelGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, "db_skill.db", "select BinData from `SkillDescription` where SkillLevelGroupId = ?");
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x00193A0C File Offset: 0x00191C0C
		[NullableContext(2)]
		public static IReadOnlyList<SkillDescription> GetConfigList(int p0SkillLevelGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, ConfigSkillDescriptionBySkillLevelGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillDescriptionBySkillLevelGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkillLevelGroupId);
				IReadOnlyList<SkillDescription> readOnlyList = (IReadOnlyList<SkillDescription>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillDescriptionBySkillLevelGroupId.LogPair.Clear();
			ConfigSkillDescriptionBySkillLevelGroupId.LogPair.Add(new ValueTuple<string, object>("SkillLevelGroupId", p0SkillLevelGroupId));
			if (!ConfigCommon.BindInt(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, 1, p0SkillLevelGroupId, ConfigSkillDescriptionBySkillLevelGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, ConfigSkillDescriptionBySkillLevelGroupId.LogPair);
				return null;
			}
			List<SkillDescription> list = new List<SkillDescription>();
			while (ConfigCommon.Step(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, false, ConfigSkillDescriptionBySkillLevelGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, 0, ConfigSkillDescriptionBySkillLevelGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, ConfigSkillDescriptionBySkillLevelGroupId.LogPair);
					return null;
				}
				SkillDescription rootAsSkillDescription = SkillDescription.GetRootAsSkillDescription(new ByteBuffer(item2));
				list.Add(rootAsSkillDescription);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillDescriptionBySkillLevelGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkillLevelGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, ConfigSkillDescriptionBySkillLevelGroupId.LogPair);
			return list;
		}

		// Token: 0x040040A6 RID: 16550
		private const string DB = "db_skill.db";

		// Token: 0x040040A7 RID: 16551
		private const string FILE = "j.技能.xlsx";

		// Token: 0x040040A8 RID: 16552
		private const string TABLE = "SkillDescription";

		// Token: 0x040040A9 RID: 16553
		private const string COMMAND = "select BinData from `SkillDescription` where SkillLevelGroupId = ?";

		// Token: 0x040040AA RID: 16554
		private const string KEY_PREFIX = "SkillDescriptionBySkillLevelGroupId";

		// Token: 0x040040AB RID: 16555
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040AC RID: 16556
		private static int HandleId;
	}
}
