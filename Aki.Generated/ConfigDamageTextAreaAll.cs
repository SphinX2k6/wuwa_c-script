using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C0 RID: 448
	public class ConfigDamageTextAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A83 RID: 2691 RVA: 0x00095107 File Offset: 0x00093307
		static ConfigDamageTextAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageTextAreaAll.CreateStaticDefaultValue), new Action(ConfigDamageTextAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00095128 File Offset: 0x00093328
		public static void CreateStaticDefaultValue()
		{
			ConfigDamageTextAreaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDamageTextAreaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_damage_text.db"),
				new ValueTuple<string, object>("文件", "s.伤害飘字.xlsx"),
				new ValueTuple<string, object>("表名", "DamageTextArea"),
				new ValueTuple<string, object>("语句", "select BinData from `DamageTextArea`")
			});
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000951A7 File Offset: 0x000933A7
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageTextAreaAll.LogPair = null;
			ConfigDamageTextAreaAll.HandleId = 0;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000951B5 File Offset: 0x000933B5
		public static void Init()
		{
			ConfigDamageTextAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigDamageTextAreaAll.HandleId, "db_damage_text.db", "select BinData from `DamageTextArea`");
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000951D0 File Offset: 0x000933D0
		[NullableContext(2)]
		public static IReadOnlyList<DamageTextArea> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDamageTextAreaAll.HandleId, ConfigDamageTextAreaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DamageTextArea> readOnlyList = (IReadOnlyList<DamageTextArea>)ConfigCommon.GetConfig("DamageTextAreaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DamageTextArea> list = new List<DamageTextArea>();
			while (ConfigCommon.Step(ConfigDamageTextAreaAll.HandleId, false, ConfigDamageTextAreaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDamageTextAreaAll.HandleId, 0, ConfigDamageTextAreaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDamageTextAreaAll.HandleId, ConfigDamageTextAreaAll.LogPair);
					return null;
				}
				DamageTextArea rootAsDamageTextArea = DamageTextArea.GetRootAsDamageTextArea(new ByteBuffer(item2));
				list.Add(rootAsDamageTextArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DamageTextAreaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDamageTextAreaAll.HandleId, ConfigDamageTextAreaAll.LogPair);
			return list;
		}

		// Token: 0x04000C24 RID: 3108
		private const string DB = "db_damage_text.db";

		// Token: 0x04000C25 RID: 3109
		private const string FILE = "s.伤害飘字.xlsx";

		// Token: 0x04000C26 RID: 3110
		private const string TABLE = "DamageTextArea";

		// Token: 0x04000C27 RID: 3111
		private const string COMMAND = "select BinData from `DamageTextArea`";

		// Token: 0x04000C28 RID: 3112
		private const string KEY_PREFIX = "DamageTextAreaAll";

		// Token: 0x04000C29 RID: 3113
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C2A RID: 3114
		private static int HandleId;
	}
}
