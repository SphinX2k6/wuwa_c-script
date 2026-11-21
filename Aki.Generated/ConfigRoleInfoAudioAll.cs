using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CB RID: 2251
	public class ConfigRoleInfoAudioAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034D5 RID: 13525 RVA: 0x0018754F File Offset: 0x0018574F
		static ConfigRoleInfoAudioAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoAudioAll.CreateStaticDefaultValue), new Action(ConfigRoleInfoAudioAll.ResetStaticDefaultValue));
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00187570 File Offset: 0x00185770
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

		// Token: 0x060034D7 RID: 13527 RVA: 0x001875EF File Offset: 0x001857EF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoAudioAll.LogPair = null;
			ConfigRoleInfoAudioAll.HandleId = 0;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x001875FD File Offset: 0x001857FD
		public static void Init()
		{
			ConfigRoleInfoAudioAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoAudioAll.HandleId, "db_audio.db", "select BinData from `RoleInfoAudio`");
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x00187618 File Offset: 0x00185818
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

		// Token: 0x04003D73 RID: 15731
		private const string DB = "db_audio.db";

		// Token: 0x04003D74 RID: 15732
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003D75 RID: 15733
		private const string TABLE = "RoleInfoAudio";

		// Token: 0x04003D76 RID: 15734
		private const string COMMAND = "select BinData from `RoleInfoAudio`";

		// Token: 0x04003D77 RID: 15735
		private const string KEY_PREFIX = "RoleInfoAudioAll";

		// Token: 0x04003D78 RID: 15736
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D79 RID: 15737
		private static int HandleId;
	}
}
