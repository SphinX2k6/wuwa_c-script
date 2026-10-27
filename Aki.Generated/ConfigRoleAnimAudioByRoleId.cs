using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000884 RID: 2180
	public class ConfigRoleAnimAudioByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600332A RID: 13098 RVA: 0x0017AAA4 File Offset: 0x00178CA4
		static ConfigRoleAnimAudioByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleAnimAudioByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleAnimAudioByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x0017AAC4 File Offset: 0x00178CC4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleAnimAudioByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleAnimAudioByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleAnimAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleAnimAudio` where RoleId=?")
			});
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x0017AB43 File Offset: 0x00178D43
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleAnimAudioByRoleId.LogPair = null;
			ConfigRoleAnimAudioByRoleId.HandleId = 0;
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x0017AB51 File Offset: 0x00178D51
		public static void Init()
		{
			ConfigRoleAnimAudioByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleAnimAudioByRoleId.HandleId, "db_role.db", "select BinData from `RoleAnimAudio` where RoleId=?");
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x0017AB6C File Offset: 0x00178D6C
		[NullableContext(2)]
		public static IReadOnlyList<RoleAnimAudio> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleAnimAudioByRoleId.HandleId, ConfigRoleAnimAudioByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleAnimAudioByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<RoleAnimAudio> readOnlyList = (IReadOnlyList<RoleAnimAudio>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleAnimAudioByRoleId.LogPair.Clear();
			ConfigRoleAnimAudioByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleAnimAudioByRoleId.HandleId, 1, p0RoleId, ConfigRoleAnimAudioByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleAnimAudioByRoleId.HandleId, ConfigRoleAnimAudioByRoleId.LogPair);
				return null;
			}
			List<RoleAnimAudio> list = new List<RoleAnimAudio>();
			while (ConfigCommon.Step(ConfigRoleAnimAudioByRoleId.HandleId, false, ConfigRoleAnimAudioByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleAnimAudioByRoleId.HandleId, 0, ConfigRoleAnimAudioByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleAnimAudioByRoleId.HandleId, ConfigRoleAnimAudioByRoleId.LogPair);
					return null;
				}
				RoleAnimAudio rootAsRoleAnimAudio = RoleAnimAudio.GetRootAsRoleAnimAudio(new ByteBuffer(item2));
				list.Add(rootAsRoleAnimAudio);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleAnimAudioByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleAnimAudioByRoleId.HandleId, ConfigRoleAnimAudioByRoleId.LogPair);
			return list;
		}

		// Token: 0x04003B82 RID: 15234
		private const string DB = "db_role.db";

		// Token: 0x04003B83 RID: 15235
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003B84 RID: 15236
		private const string TABLE = "RoleAnimAudio";

		// Token: 0x04003B85 RID: 15237
		private const string COMMAND = "select BinData from `RoleAnimAudio` where RoleId=?";

		// Token: 0x04003B86 RID: 15238
		private const string KEY_PREFIX = "RoleAnimAudioByRoleId";

		// Token: 0x04003B87 RID: 15239
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B88 RID: 15240
		private static int HandleId;
	}
}
