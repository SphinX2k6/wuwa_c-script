using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A78 RID: 2680
	public class ConfigWeaponBreachByBreachId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EE4 RID: 16100 RVA: 0x001BDB0A File Offset: 0x001BBD0A
		static ConfigWeaponBreachByBreachId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponBreachByBreachId.CreateStaticDefaultValue), new Action(ConfigWeaponBreachByBreachId.ResetStaticDefaultValue));
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x001BDB2C File Offset: 0x001BBD2C
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponBreachByBreachId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponBreachByBreachId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponBreach"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponBreach` where BreachId = ?")
			});
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x001BDBAB File Offset: 0x001BBDAB
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponBreachByBreachId.LogPair = null;
			ConfigWeaponBreachByBreachId.HandleId = 0;
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x001BDBB9 File Offset: 0x001BBDB9
		public static void Init()
		{
			ConfigWeaponBreachByBreachId.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponBreachByBreachId.HandleId, "db_weapon.db", "select BinData from `WeaponBreach` where BreachId = ?");
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x001BDBD4 File Offset: 0x001BBDD4
		[NullableContext(2)]
		public static IReadOnlyList<WeaponBreach> GetConfigList(int p0BreachId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponBreachByBreachId.HandleId, ConfigWeaponBreachByBreachId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponBreachByBreachId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachId);
				IReadOnlyList<WeaponBreach> readOnlyList = (IReadOnlyList<WeaponBreach>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWeaponBreachByBreachId.LogPair.Clear();
			ConfigWeaponBreachByBreachId.LogPair.Add(new ValueTuple<string, object>("BreachId", p0BreachId));
			if (!ConfigCommon.BindInt(ConfigWeaponBreachByBreachId.HandleId, 1, p0BreachId, ConfigWeaponBreachByBreachId.LogPair))
			{
				ConfigCommon.Reset(ConfigWeaponBreachByBreachId.HandleId, ConfigWeaponBreachByBreachId.LogPair);
				return null;
			}
			List<WeaponBreach> list = new List<WeaponBreach>();
			while (ConfigCommon.Step(ConfigWeaponBreachByBreachId.HandleId, false, ConfigWeaponBreachByBreachId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponBreachByBreachId.HandleId, 0, ConfigWeaponBreachByBreachId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeaponBreachByBreachId.HandleId, ConfigWeaponBreachByBreachId.LogPair);
					return null;
				}
				WeaponBreach rootAsWeaponBreach = WeaponBreach.GetRootAsWeaponBreach(new ByteBuffer(item2));
				list.Add(rootAsWeaponBreach);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponBreachByBreachId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BreachId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeaponBreachByBreachId.HandleId, ConfigWeaponBreachByBreachId.LogPair);
			return list;
		}

		// Token: 0x0400492E RID: 18734
		private const string DB = "db_weapon.db";

		// Token: 0x0400492F RID: 18735
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004930 RID: 18736
		private const string TABLE = "WeaponBreach";

		// Token: 0x04004931 RID: 18737
		private const string COMMAND = "select BinData from `WeaponBreach` where BreachId = ?";

		// Token: 0x04004932 RID: 18738
		private const string KEY_PREFIX = "WeaponBreachByBreachId";

		// Token: 0x04004933 RID: 18739
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004934 RID: 18740
		private static int HandleId;
	}
}
