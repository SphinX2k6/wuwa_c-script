using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4D RID: 2893
	public class ConfigWeaponBreachByBreachId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043E2 RID: 17378 RVA: 0x001DCE9E File Offset: 0x001DB09E
		static ConfigWeaponBreachByBreachId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponBreachByBreachId.CreateStaticDefaultValue), new Action(ConfigWeaponBreachByBreachId.ResetStaticDefaultValue));
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x001DCEC0 File Offset: 0x001DB0C0
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

		// Token: 0x060043E4 RID: 17380 RVA: 0x001DCF3F File Offset: 0x001DB13F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponBreachByBreachId.LogPair = null;
			ConfigWeaponBreachByBreachId.HandleId = 0;
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x001DCF4D File Offset: 0x001DB14D
		public static void Init()
		{
			ConfigWeaponBreachByBreachId.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponBreachByBreachId.HandleId, "db_weapon.db", "select BinData from `WeaponBreach` where BreachId = ?");
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x001DCF68 File Offset: 0x001DB168
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

		// Token: 0x04004F01 RID: 20225
		private const string DB = "db_weapon.db";

		// Token: 0x04004F02 RID: 20226
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F03 RID: 20227
		private const string TABLE = "WeaponBreach";

		// Token: 0x04004F04 RID: 20228
		private const string COMMAND = "select BinData from `WeaponBreach` where BreachId = ?";

		// Token: 0x04004F05 RID: 20229
		private const string KEY_PREFIX = "WeaponBreachByBreachId";

		// Token: 0x04004F06 RID: 20230
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F07 RID: 20231
		private static int HandleId;
	}
}
