using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D1 RID: 465
	public class ConfigDamageTextAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x0009AEAD File Offset: 0x000990AD
		static ConfigDamageTextAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageTextAll.CreateStaticDefaultValue), new Action(ConfigDamageTextAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0009AECC File Offset: 0x000990CC
		public static void CreateStaticDefaultValue()
		{
			ConfigDamageTextAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDamageTextAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_damage_text.db"),
				new ValueTuple<string, object>("文件", "s.伤害飘字.xlsx"),
				new ValueTuple<string, object>("表名", "DamageText"),
				new ValueTuple<string, object>("语句", "select BinData from `DamageText`")
			});
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0009AF4B File Offset: 0x0009914B
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageTextAll.LogPair = null;
			ConfigDamageTextAll.HandleId = 0;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0009AF59 File Offset: 0x00099159
		public static void Init()
		{
			ConfigDamageTextAll.HandleId = ConfigCommon.InitDataStatement(ConfigDamageTextAll.HandleId, "db_damage_text.db", "select BinData from `DamageText`");
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0009AF74 File Offset: 0x00099174
		[NullableContext(2)]
		public static IReadOnlyList<DamageText> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDamageTextAll.HandleId, ConfigDamageTextAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DamageText> readOnlyList = (IReadOnlyList<DamageText>)ConfigCommon.GetConfig("DamageTextAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DamageText> list = new List<DamageText>();
			while (ConfigCommon.Step(ConfigDamageTextAll.HandleId, false, ConfigDamageTextAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDamageTextAll.HandleId, 0, ConfigDamageTextAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDamageTextAll.HandleId, ConfigDamageTextAll.LogPair);
					return null;
				}
				DamageText rootAsDamageText = DamageText.GetRootAsDamageText(new ByteBuffer(item2));
				list.Add(rootAsDamageText);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DamageTextAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDamageTextAll.HandleId, ConfigDamageTextAll.LogPair);
			return list;
		}

		// Token: 0x04000C9B RID: 3227
		private const string DB = "db_damage_text.db";

		// Token: 0x04000C9C RID: 3228
		private const string FILE = "s.伤害飘字.xlsx";

		// Token: 0x04000C9D RID: 3229
		private const string TABLE = "DamageText";

		// Token: 0x04000C9E RID: 3230
		private const string COMMAND = "select BinData from `DamageText`";

		// Token: 0x04000C9F RID: 3231
		private const string KEY_PREFIX = "DamageTextAll";

		// Token: 0x04000CA0 RID: 3232
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CA1 RID: 3233
		private static int HandleId;
	}
}
