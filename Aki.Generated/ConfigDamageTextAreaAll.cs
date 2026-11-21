using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D2 RID: 466
	public class ConfigDamageTextAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x0009B03F File Offset: 0x0009923F
		static ConfigDamageTextAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageTextAreaAll.CreateStaticDefaultValue), new Action(ConfigDamageTextAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0009B060 File Offset: 0x00099260
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

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0009B0DF File Offset: 0x000992DF
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageTextAreaAll.LogPair = null;
			ConfigDamageTextAreaAll.HandleId = 0;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0009B0ED File Offset: 0x000992ED
		public static void Init()
		{
			ConfigDamageTextAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigDamageTextAreaAll.HandleId, "db_damage_text.db", "select BinData from `DamageTextArea`");
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0009B108 File Offset: 0x00099308
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

		// Token: 0x04000CA2 RID: 3234
		private const string DB = "db_damage_text.db";

		// Token: 0x04000CA3 RID: 3235
		private const string FILE = "s.伤害飘字.xlsx";

		// Token: 0x04000CA4 RID: 3236
		private const string TABLE = "DamageTextArea";

		// Token: 0x04000CA5 RID: 3237
		private const string COMMAND = "select BinData from `DamageTextArea`";

		// Token: 0x04000CA6 RID: 3238
		private const string KEY_PREFIX = "DamageTextAreaAll";

		// Token: 0x04000CA7 RID: 3239
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CA8 RID: 3240
		private static int HandleId;
	}
}
