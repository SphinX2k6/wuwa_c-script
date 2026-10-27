using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BC RID: 444
	public class ConfigDamageByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A6B RID: 2667 RVA: 0x00094950 File Offset: 0x00092B50
		static ConfigDamageByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageByAll.CreateStaticDefaultValue), new Action(ConfigDamageByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00094970 File Offset: 0x00092B70
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

		// Token: 0x06000A6D RID: 2669 RVA: 0x000949EF File Offset: 0x00092BEF
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageByAll.LogPair = null;
			ConfigDamageByAll.HandleId = 0;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000949FD File Offset: 0x00092BFD
		public static void Init()
		{
			ConfigDamageByAll.HandleId = ConfigCommon.InitDataStatement(ConfigDamageByAll.HandleId, "db_damage.db", "select BinData from `Damage`");
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00094A18 File Offset: 0x00092C18
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

		// Token: 0x04000C08 RID: 3080
		private const string DB = "db_damage.db";

		// Token: 0x04000C09 RID: 3081
		private const string FILE = "j.结算.xlsx";

		// Token: 0x04000C0A RID: 3082
		private const string TABLE = "Damage";

		// Token: 0x04000C0B RID: 3083
		private const string COMMAND = "select BinData from `Damage`";

		// Token: 0x04000C0C RID: 3084
		private const string KEY_PREFIX = "DamageByAll";

		// Token: 0x04000C0D RID: 3085
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C0E RID: 3086
		private static int HandleId;
	}
}
