using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098B RID: 2443
	public class ConfigSkillDescriptionBySkillLevelGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003955 RID: 14677 RVA: 0x001A0B64 File Offset: 0x0019ED64
		static ConfigSkillDescriptionBySkillLevelGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillDescriptionBySkillLevelGroupId.CreateStaticDefaultValue), new Action(ConfigSkillDescriptionBySkillLevelGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x001A0B84 File Offset: 0x0019ED84
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

		// Token: 0x06003957 RID: 14679 RVA: 0x001A0C03 File Offset: 0x0019EE03
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillDescriptionBySkillLevelGroupId.LogPair = null;
			ConfigSkillDescriptionBySkillLevelGroupId.HandleId = 0;
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x001A0C11 File Offset: 0x0019EE11
		public static void Init()
		{
			ConfigSkillDescriptionBySkillLevelGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillDescriptionBySkillLevelGroupId.HandleId, "db_skill.db", "select BinData from `SkillDescription` where SkillLevelGroupId = ?");
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x001A0C2C File Offset: 0x0019EE2C
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

		// Token: 0x040042B3 RID: 17075
		private const string DB = "db_skill.db";

		// Token: 0x040042B4 RID: 17076
		private const string FILE = "j.技能.xlsx";

		// Token: 0x040042B5 RID: 17077
		private const string TABLE = "SkillDescription";

		// Token: 0x040042B6 RID: 17078
		private const string COMMAND = "select BinData from `SkillDescription` where SkillLevelGroupId = ?";

		// Token: 0x040042B7 RID: 17079
		private const string KEY_PREFIX = "SkillDescriptionBySkillLevelGroupId";

		// Token: 0x040042B8 RID: 17080
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042B9 RID: 17081
		private static int HandleId;
	}
}
