using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000945 RID: 2373
	public class ConfigSkillLevelBySkillLevelGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037B1 RID: 14257 RVA: 0x0019447C File Offset: 0x0019267C
		static ConfigSkillLevelBySkillLevelGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillLevelBySkillLevelGroupId.CreateStaticDefaultValue), new Action(ConfigSkillLevelBySkillLevelGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x0019449C File Offset: 0x0019269C
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillLevelBySkillLevelGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillLevelBySkillLevelGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "SkillLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillLevel` where SkillLevelGroupId = ?")
			});
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x0019451B File Offset: 0x0019271B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillLevelBySkillLevelGroupId.LogPair = null;
			ConfigSkillLevelBySkillLevelGroupId.HandleId = 0;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x00194529 File Offset: 0x00192729
		public static void Init()
		{
			ConfigSkillLevelBySkillLevelGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillLevelBySkillLevelGroupId.HandleId, "db_skill.db", "select BinData from `SkillLevel` where SkillLevelGroupId = ?");
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00194544 File Offset: 0x00192744
		[NullableContext(2)]
		public static IReadOnlyList<SkillLevel> GetConfigList(int p0SkillLevelGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillLevelBySkillLevelGroupId.HandleId, ConfigSkillLevelBySkillLevelGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillLevelBySkillLevelGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkillLevelGroupId);
				IReadOnlyList<SkillLevel> readOnlyList = (IReadOnlyList<SkillLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSkillLevelBySkillLevelGroupId.LogPair.Clear();
			ConfigSkillLevelBySkillLevelGroupId.LogPair.Add(new ValueTuple<string, object>("SkillLevelGroupId", p0SkillLevelGroupId));
			if (!ConfigCommon.BindInt(ConfigSkillLevelBySkillLevelGroupId.HandleId, 1, p0SkillLevelGroupId, ConfigSkillLevelBySkillLevelGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigSkillLevelBySkillLevelGroupId.HandleId, ConfigSkillLevelBySkillLevelGroupId.LogPair);
				return null;
			}
			List<SkillLevel> list = new List<SkillLevel>();
			while (ConfigCommon.Step(ConfigSkillLevelBySkillLevelGroupId.HandleId, false, ConfigSkillLevelBySkillLevelGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillLevelBySkillLevelGroupId.HandleId, 0, ConfigSkillLevelBySkillLevelGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSkillLevelBySkillLevelGroupId.HandleId, ConfigSkillLevelBySkillLevelGroupId.LogPair);
					return null;
				}
				SkillLevel rootAsSkillLevel = SkillLevel.GetRootAsSkillLevel(new ByteBuffer(item2));
				list.Add(rootAsSkillLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillLevelBySkillLevelGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkillLevelGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSkillLevelBySkillLevelGroupId.HandleId, ConfigSkillLevelBySkillLevelGroupId.LogPair);
			return list;
		}

		// Token: 0x040040C9 RID: 16585
		private const string DB = "db_skill.db";

		// Token: 0x040040CA RID: 16586
		private const string FILE = "j.技能.xlsx";

		// Token: 0x040040CB RID: 16587
		private const string TABLE = "SkillLevel";

		// Token: 0x040040CC RID: 16588
		private const string COMMAND = "select BinData from `SkillLevel` where SkillLevelGroupId = ?";

		// Token: 0x040040CD RID: 16589
		private const string KEY_PREFIX = "SkillLevelBySkillLevelGroupId";

		// Token: 0x040040CE RID: 16590
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040CF RID: 16591
		private static int HandleId;
	}
}
