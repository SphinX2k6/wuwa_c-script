using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080C RID: 2060
	public class ConfigRhythmRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600305A RID: 12378 RVA: 0x0016E150 File Offset: 0x0016C350
		static ConfigRhythmRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmRoleAll.CreateStaticDefaultValue), new Action(ConfigRhythmRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x0016E170 File Offset: 0x0016C370
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

		// Token: 0x0600305C RID: 12380 RVA: 0x0016E1EF File Offset: 0x0016C3EF
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmRoleAll.LogPair = null;
			ConfigRhythmRoleAll.HandleId = 0;
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x0016E1FD File Offset: 0x0016C3FD
		public static void Init()
		{
			ConfigRhythmRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmRoleAll.HandleId, "db_rhythmship.db", "select BinData from `RhythmRole`");
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x0016E218 File Offset: 0x0016C418
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

		// Token: 0x0400383A RID: 14394
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400383B RID: 14395
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400383C RID: 14396
		private const string TABLE = "RhythmRole";

		// Token: 0x0400383D RID: 14397
		private const string COMMAND = "select BinData from `RhythmRole`";

		// Token: 0x0400383E RID: 14398
		private const string KEY_PREFIX = "RhythmRoleAll";

		// Token: 0x0400383F RID: 14399
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003840 RID: 14400
		private static int HandleId;
	}
}
