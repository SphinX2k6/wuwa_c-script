using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F0 RID: 2032
	public class ConfigRhythmRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FB2 RID: 12210 RVA: 0x00166E68 File Offset: 0x00165068
		static ConfigRhythmRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmRoleAll.CreateStaticDefaultValue), new Action(ConfigRhythmRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00166E88 File Offset: 0x00165088
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmRole`")
			});
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x00166F07 File Offset: 0x00165107
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmRoleAll.LogPair = null;
			ConfigRhythmRoleAll.HandleId = 0;
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00166F15 File Offset: 0x00165115
		public static void Init()
		{
			ConfigRhythmRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmRoleAll.HandleId, "db_rhythmship.db", "select BinData from `RhythmRole`");
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x00166F30 File Offset: 0x00165130
		[NullableContext(2)]
		public static IReadOnlyList<RhythmRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmRoleAll.HandleId, ConfigRhythmRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RhythmRole> readOnlyList = (IReadOnlyList<RhythmRole>)ConfigCommon.GetConfig("RhythmRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RhythmRole> list = new List<RhythmRole>();
			while (ConfigCommon.Step(ConfigRhythmRoleAll.HandleId, false, ConfigRhythmRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmRoleAll.HandleId, 0, ConfigRhythmRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmRoleAll.HandleId, ConfigRhythmRoleAll.LogPair);
					return null;
				}
				RhythmRole rootAsRhythmRole = RhythmRole.GetRootAsRhythmRole(new ByteBuffer(item2));
				list.Add(rootAsRhythmRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RhythmRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmRoleAll.HandleId, ConfigRhythmRoleAll.LogPair);
			return list;
		}

		// Token: 0x04003776 RID: 14198
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003777 RID: 14199
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003778 RID: 14200
		private const string TABLE = "RhythmRole";

		// Token: 0x04003779 RID: 14201
		private const string COMMAND = "select BinData from `RhythmRole`";

		// Token: 0x0400377A RID: 14202
		private const string KEY_PREFIX = "RhythmRoleAll";

		// Token: 0x0400377B RID: 14203
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400377C RID: 14204
		private static int HandleId;
	}
}
