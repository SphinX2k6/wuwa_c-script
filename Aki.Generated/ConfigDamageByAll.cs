using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CE RID: 462
	public class ConfigDamageByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AD7 RID: 2775 RVA: 0x0009A888 File Offset: 0x00098A88
		static ConfigDamageByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageByAll.CreateStaticDefaultValue), new Action(ConfigDamageByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0009A8A8 File Offset: 0x00098AA8
		public static void CreateStaticDefaultValue()
		{
			ConfigDamageByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDamageByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_damage.db"),
				new ValueTuple<string, object>("文件", "j.结算.xlsx"),
				new ValueTuple<string, object>("表名", "Damage"),
				new ValueTuple<string, object>("语句", "select BinData from `Damage`")
			});
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0009A927 File Offset: 0x00098B27
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageByAll.LogPair = null;
			ConfigDamageByAll.HandleId = 0;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0009A935 File Offset: 0x00098B35
		public static void Init()
		{
			ConfigDamageByAll.HandleId = ConfigCommon.InitDataStatement(ConfigDamageByAll.HandleId, "db_damage.db", "select BinData from `Damage`");
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0009A950 File Offset: 0x00098B50
		[NullableContext(2)]
		public static IReadOnlyList<Damage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDamageByAll.HandleId, ConfigDamageByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Damage> readOnlyList = (IReadOnlyList<Damage>)ConfigCommon.GetConfig("DamageByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Damage> list = new List<Damage>();
			while (ConfigCommon.Step(ConfigDamageByAll.HandleId, false, ConfigDamageByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDamageByAll.HandleId, 0, ConfigDamageByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDamageByAll.HandleId, ConfigDamageByAll.LogPair);
					return null;
				}
				Damage rootAsDamage = Damage.GetRootAsDamage(new ByteBuffer(item2));
				list.Add(rootAsDamage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DamageByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDamageByAll.HandleId, ConfigDamageByAll.LogPair);
			return list;
		}

		// Token: 0x04000C86 RID: 3206
		private const string DB = "db_damage.db";

		// Token: 0x04000C87 RID: 3207
		private const string FILE = "j.结算.xlsx";

		// Token: 0x04000C88 RID: 3208
		private const string TABLE = "Damage";

		// Token: 0x04000C89 RID: 3209
		private const string COMMAND = "select BinData from `Damage`";

		// Token: 0x04000C8A RID: 3210
		private const string KEY_PREFIX = "DamageByAll";

		// Token: 0x04000C8B RID: 3211
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C8C RID: 3212
		private static int HandleId;
	}
}
