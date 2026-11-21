using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000282 RID: 642
	public class ConfigEncircleChallengeGroupByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x000B20D3 File Offset: 0x000B02D3
		static ConfigEncircleChallengeGroupByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleChallengeGroupByActivityId.CreateStaticDefaultValue), new Action(ConfigEncircleChallengeGroupByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000B20F4 File Offset: 0x000B02F4
		public static void CreateStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEncircleChallengeGroupByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_encircle.db"),
				new ValueTuple<string, object>("文件", "j.界面围剿.xlsx"),
				new ValueTuple<string, object>("表名", "EncircleChallengeGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `EncircleChallengeGroup` where ActivityId=?")
			});
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000B2173 File Offset: 0x000B0373
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupByActivityId.LogPair = null;
			ConfigEncircleChallengeGroupByActivityId.HandleId = 0;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x000B2181 File Offset: 0x000B0381
		public static void Init()
		{
			ConfigEncircleChallengeGroupByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleChallengeGroupByActivityId.HandleId, "db_encircle.db", "select BinData from `EncircleChallengeGroup` where ActivityId=?");
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x000B219C File Offset: 0x000B039C
		[NullableContext(2)]
		public static IReadOnlyList<EncircleChallengeGroup> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEncircleChallengeGroupByActivityId.HandleId, ConfigEncircleChallengeGroupByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeGroupByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<EncircleChallengeGroup> readOnlyList = (IReadOnlyList<EncircleChallengeGroup>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEncircleChallengeGroupByActivityId.LogPair.Clear();
			ConfigEncircleChallengeGroupByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigEncircleChallengeGroupByActivityId.HandleId, 1, p0ActivityId, ConfigEncircleChallengeGroupByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigEncircleChallengeGroupByActivityId.HandleId, ConfigEncircleChallengeGroupByActivityId.LogPair);
				return null;
			}
			List<EncircleChallengeGroup> list = new List<EncircleChallengeGroup>();
			while (ConfigCommon.Step(ConfigEncircleChallengeGroupByActivityId.HandleId, false, ConfigEncircleChallengeGroupByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEncircleChallengeGroupByActivityId.HandleId, 0, ConfigEncircleChallengeGroupByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEncircleChallengeGroupByActivityId.HandleId, ConfigEncircleChallengeGroupByActivityId.LogPair);
					return null;
				}
				EncircleChallengeGroup rootAsEncircleChallengeGroup = EncircleChallengeGroup.GetRootAsEncircleChallengeGroup(new ByteBuffer(item2));
				list.Add(rootAsEncircleChallengeGroup);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeGroupByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEncircleChallengeGroupByActivityId.HandleId, ConfigEncircleChallengeGroupByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001172 RID: 4466
		private const string DB = "db_encircle.db";

		// Token: 0x04001173 RID: 4467
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x04001174 RID: 4468
		private const string TABLE = "EncircleChallengeGroup";

		// Token: 0x04001175 RID: 4469
		private const string COMMAND = "select BinData from `EncircleChallengeGroup` where ActivityId=?";

		// Token: 0x04001176 RID: 4470
		private const string KEY_PREFIX = "EncircleChallengeGroupByActivityId";

		// Token: 0x04001177 RID: 4471
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001178 RID: 4472
		private static int HandleId;
	}
}
