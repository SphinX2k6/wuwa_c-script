using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000990 RID: 2448
	public class ConfigSkillLevelBySkillLevelGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003973 RID: 14707 RVA: 0x001A169C File Offset: 0x0019F89C
		static ConfigSkillLevelBySkillLevelGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillLevelBySkillLevelGroupId.CreateStaticDefaultValue), new Action(ConfigSkillLevelBySkillLevelGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x001A16BC File Offset: 0x0019F8BC
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

		// Token: 0x06003975 RID: 14709 RVA: 0x001A173B File Offset: 0x0019F93B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillLevelBySkillLevelGroupId.LogPair = null;
			ConfigSkillLevelBySkillLevelGroupId.HandleId = 0;
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x001A1749 File Offset: 0x0019F949
		public static void Init()
		{
			ConfigSkillLevelBySkillLevelGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigSkillLevelBySkillLevelGroupId.HandleId, "db_skill.db", "select BinData from `SkillLevel` where SkillLevelGroupId = ?");
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x001A1764 File Offset: 0x0019F964
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

		// Token: 0x040042D6 RID: 17110
		private const string DB = "db_skill.db";

		// Token: 0x040042D7 RID: 17111
		private const string FILE = "j.技能.xlsx";

		// Token: 0x040042D8 RID: 17112
		private const string TABLE = "SkillLevel";

		// Token: 0x040042D9 RID: 17113
		private const string COMMAND = "select BinData from `SkillLevel` where SkillLevelGroupId = ?";

		// Token: 0x040042DA RID: 17114
		private const string KEY_PREFIX = "SkillLevelBySkillLevelGroupId";

		// Token: 0x040042DB RID: 17115
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042DC RID: 17116
		private static int HandleId;
	}
}
