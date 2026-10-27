using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026E RID: 622
	public class ConfigEncircleChallengeGroupByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E99 RID: 3737 RVA: 0x000ABE0F File Offset: 0x000AA00F
		static ConfigEncircleChallengeGroupByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleChallengeGroupByActivityId.CreateStaticDefaultValue), new Action(ConfigEncircleChallengeGroupByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x000ABE30 File Offset: 0x000AA030
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

		// Token: 0x06000E9B RID: 3739 RVA: 0x000ABEAF File Offset: 0x000AA0AF
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupByActivityId.LogPair = null;
			ConfigEncircleChallengeGroupByActivityId.HandleId = 0;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000ABEBD File Offset: 0x000AA0BD
		public static void Init()
		{
			ConfigEncircleChallengeGroupByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleChallengeGroupByActivityId.HandleId, "db_encircle.db", "select BinData from `EncircleChallengeGroup` where ActivityId=?");
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x000ABED8 File Offset: 0x000AA0D8
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

		// Token: 0x040010E6 RID: 4326
		private const string DB = "db_encircle.db";

		// Token: 0x040010E7 RID: 4327
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x040010E8 RID: 4328
		private const string TABLE = "EncircleChallengeGroup";

		// Token: 0x040010E9 RID: 4329
		private const string COMMAND = "select BinData from `EncircleChallengeGroup` where ActivityId=?";

		// Token: 0x040010EA RID: 4330
		private const string KEY_PREFIX = "EncircleChallengeGroupByActivityId";

		// Token: 0x040010EB RID: 4331
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010EC RID: 4332
		private static int HandleId;
	}
}
