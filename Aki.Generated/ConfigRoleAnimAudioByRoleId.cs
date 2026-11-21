using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A0 RID: 2208
	public class ConfigRoleAnimAudioByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033D2 RID: 13266 RVA: 0x00181D8C File Offset: 0x0017FF8C
		static ConfigRoleAnimAudioByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleAnimAudioByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleAnimAudioByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00181DAC File Offset: 0x0017FFAC
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

		// Token: 0x060033D4 RID: 13268 RVA: 0x00181E2B File Offset: 0x0018002B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleAnimAudioByRoleId.LogPair = null;
			ConfigRoleAnimAudioByRoleId.HandleId = 0;
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x00181E39 File Offset: 0x00180039
		public static void Init()
		{
			ConfigRoleAnimAudioByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleAnimAudioByRoleId.HandleId, "db_role.db", "select BinData from `RoleAnimAudio` where RoleId=?");
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00181E54 File Offset: 0x00180054
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

		// Token: 0x04003C46 RID: 15430
		private const string DB = "db_role.db";

		// Token: 0x04003C47 RID: 15431
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003C48 RID: 15432
		private const string TABLE = "RoleAnimAudio";

		// Token: 0x04003C49 RID: 15433
		private const string COMMAND = "select BinData from `RoleAnimAudio` where RoleId=?";

		// Token: 0x04003C4A RID: 15434
		private const string KEY_PREFIX = "RoleAnimAudioByRoleId";

		// Token: 0x04003C4B RID: 15435
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C4C RID: 15436
		private static int HandleId;
	}
}
