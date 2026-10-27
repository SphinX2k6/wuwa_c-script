using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AF RID: 2223
	public class ConfigRoleInfoAudioAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600342D RID: 13357 RVA: 0x00180267 File Offset: 0x0017E467
		static ConfigRoleInfoAudioAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoAudioAll.CreateStaticDefaultValue), new Action(ConfigRoleInfoAudioAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00180288 File Offset: 0x0017E488
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoAudioAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoAudioAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfoAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfoAudio`")
			});
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00180307 File Offset: 0x0017E507
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoAudioAll.LogPair = null;
			ConfigRoleInfoAudioAll.HandleId = 0;
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00180315 File Offset: 0x0017E515
		public static void Init()
		{
			ConfigRoleInfoAudioAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoAudioAll.HandleId, "db_audio.db", "select BinData from `RoleInfoAudio`");
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00180330 File Offset: 0x0017E530
		[NullableContext(2)]
		public static IReadOnlyList<RoleInfoAudio> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoAudioAll.HandleId, ConfigRoleInfoAudioAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleInfoAudio> readOnlyList = (IReadOnlyList<RoleInfoAudio>)ConfigCommon.GetConfig("RoleInfoAudioAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleInfoAudio> list = new List<RoleInfoAudio>();
			while (ConfigCommon.Step(ConfigRoleInfoAudioAll.HandleId, false, ConfigRoleInfoAudioAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoAudioAll.HandleId, 0, ConfigRoleInfoAudioAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleInfoAudioAll.HandleId, ConfigRoleInfoAudioAll.LogPair);
					return null;
				}
				RoleInfoAudio rootAsRoleInfoAudio = RoleInfoAudio.GetRootAsRoleInfoAudio(new ByteBuffer(item2));
				list.Add(rootAsRoleInfoAudio);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleInfoAudioAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleInfoAudioAll.HandleId, ConfigRoleInfoAudioAll.LogPair);
			return list;
		}

		// Token: 0x04003CAF RID: 15535
		private const string DB = "db_audio.db";

		// Token: 0x04003CB0 RID: 15536
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003CB1 RID: 15537
		private const string TABLE = "RoleInfoAudio";

		// Token: 0x04003CB2 RID: 15538
		private const string COMMAND = "select BinData from `RoleInfoAudio`";

		// Token: 0x04003CB3 RID: 15539
		private const string KEY_PREFIX = "RoleInfoAudioAll";

		// Token: 0x04003CB4 RID: 15540
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CB5 RID: 15541
		private static int HandleId;
	}
}
