using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BF RID: 447
	public class ConfigDamageTextAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A7D RID: 2685 RVA: 0x00094F75 File Offset: 0x00093175
		static ConfigDamageTextAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageTextAll.CreateStaticDefaultValue), new Action(ConfigDamageTextAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00094F94 File Offset: 0x00093194
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

		// Token: 0x06000A7F RID: 2687 RVA: 0x00095013 File Offset: 0x00093213
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageTextAll.LogPair = null;
			ConfigDamageTextAll.HandleId = 0;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00095021 File Offset: 0x00093221
		public static void Init()
		{
			ConfigDamageTextAll.HandleId = ConfigCommon.InitDataStatement(ConfigDamageTextAll.HandleId, "db_damage_text.db", "select BinData from `DamageText`");
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0009503C File Offset: 0x0009323C
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

		// Token: 0x04000C1D RID: 3101
		private const string DB = "db_damage_text.db";

		// Token: 0x04000C1E RID: 3102
		private const string FILE = "s.伤害飘字.xlsx";

		// Token: 0x04000C1F RID: 3103
		private const string TABLE = "DamageText";

		// Token: 0x04000C20 RID: 3104
		private const string COMMAND = "select BinData from `DamageText`";

		// Token: 0x04000C21 RID: 3105
		private const string KEY_PREFIX = "DamageTextAll";

		// Token: 0x04000C22 RID: 3106
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C23 RID: 3107
		private static int HandleId;
	}
}
