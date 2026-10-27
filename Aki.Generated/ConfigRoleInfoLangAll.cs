using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B3 RID: 2227
	public class ConfigRoleInfoLangAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003445 RID: 13381 RVA: 0x00180AC3 File Offset: 0x0017ECC3
		static ConfigRoleInfoLangAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoLangAll.CreateStaticDefaultValue), new Action(ConfigRoleInfoLangAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00180AE4 File Offset: 0x0017ECE4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoLangAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoLangAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfoLang"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfoLang`")
			});
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00180B63 File Offset: 0x0017ED63
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoLangAll.LogPair = null;
			ConfigRoleInfoLangAll.HandleId = 0;
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00180B71 File Offset: 0x0017ED71
		public static void Init()
		{
			ConfigRoleInfoLangAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoLangAll.HandleId, "db_audio.db", "select BinData from `RoleInfoLang`");
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00180B8C File Offset: 0x0017ED8C
		[NullableContext(2)]
		public static IReadOnlyList<RoleInfoLang> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoLangAll.HandleId, ConfigRoleInfoLangAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleInfoLang> readOnlyList = (IReadOnlyList<RoleInfoLang>)ConfigCommon.GetConfig("RoleInfoLangAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleInfoLang> list = new List<RoleInfoLang>();
			while (ConfigCommon.Step(ConfigRoleInfoLangAll.HandleId, false, ConfigRoleInfoLangAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoLangAll.HandleId, 0, ConfigRoleInfoLangAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleInfoLangAll.HandleId, ConfigRoleInfoLangAll.LogPair);
					return null;
				}
				RoleInfoLang rootAsRoleInfoLang = RoleInfoLang.GetRootAsRoleInfoLang(new ByteBuffer(item2));
				list.Add(rootAsRoleInfoLang);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleInfoLangAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleInfoLangAll.HandleId, ConfigRoleInfoLangAll.LogPair);
			return list;
		}

		// Token: 0x04003CCB RID: 15563
		private const string DB = "db_audio.db";

		// Token: 0x04003CCC RID: 15564
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003CCD RID: 15565
		private const string TABLE = "RoleInfoLang";

		// Token: 0x04003CCE RID: 15566
		private const string COMMAND = "select BinData from `RoleInfoLang`";

		// Token: 0x04003CCF RID: 15567
		private const string KEY_PREFIX = "RoleInfoLangAll";

		// Token: 0x04003CD0 RID: 15568
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CD1 RID: 15569
		private static int HandleId;
	}
}
