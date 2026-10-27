using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A82 RID: 2690
	public class ConfigWeaponLevelByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F20 RID: 16160 RVA: 0x001BF152 File Offset: 0x001BD352
		static ConfigWeaponLevelByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponLevelByLevelId.CreateStaticDefaultValue), new Action(ConfigWeaponLevelByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x001BF174 File Offset: 0x001BD374
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponLevelByLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponLevelByLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponLevel` where LevelId = ?")
			});
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x001BF1F3 File Offset: 0x001BD3F3
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponLevelByLevelId.LogPair = null;
			ConfigWeaponLevelByLevelId.HandleId = 0;
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x001BF201 File Offset: 0x001BD401
		public static void Init()
		{
			ConfigWeaponLevelByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponLevelByLevelId.HandleId, "db_weapon.db", "select BinData from `WeaponLevel` where LevelId = ?");
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x001BF21C File Offset: 0x001BD41C
		[NullableContext(2)]
		public static IReadOnlyList<WeaponLevel> GetConfigList(int p0LevelId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponLevelByLevelId.HandleId, ConfigWeaponLevelByLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponLevelByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				IReadOnlyList<WeaponLevel> readOnlyList = (IReadOnlyList<WeaponLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWeaponLevelByLevelId.LogPair.Clear();
			ConfigWeaponLevelByLevelId.LogPair.Add(new ValueTuple<string, object>("LevelId", p0LevelId));
			if (!ConfigCommon.BindInt(ConfigWeaponLevelByLevelId.HandleId, 1, p0LevelId, ConfigWeaponLevelByLevelId.LogPair))
			{
				ConfigCommon.Reset(ConfigWeaponLevelByLevelId.HandleId, ConfigWeaponLevelByLevelId.LogPair);
				return null;
			}
			List<WeaponLevel> list = new List<WeaponLevel>();
			while (ConfigCommon.Step(ConfigWeaponLevelByLevelId.HandleId, false, ConfigWeaponLevelByLevelId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponLevelByLevelId.HandleId, 0, ConfigWeaponLevelByLevelId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeaponLevelByLevelId.HandleId, ConfigWeaponLevelByLevelId.LogPair);
					return null;
				}
				WeaponLevel rootAsWeaponLevel = WeaponLevel.GetRootAsWeaponLevel(new ByteBuffer(item2));
				list.Add(rootAsWeaponLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponLevelByLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LevelId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeaponLevelByLevelId.HandleId, ConfigWeaponLevelByLevelId.LogPair);
			return list;
		}

		// Token: 0x04004974 RID: 18804
		private const string DB = "db_weapon.db";

		// Token: 0x04004975 RID: 18805
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004976 RID: 18806
		private const string TABLE = "WeaponLevel";

		// Token: 0x04004977 RID: 18807
		private const string COMMAND = "select BinData from `WeaponLevel` where LevelId = ?";

		// Token: 0x04004978 RID: 18808
		private const string KEY_PREFIX = "WeaponLevelByLevelId";

		// Token: 0x04004979 RID: 18809
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400497A RID: 18810
		private static int HandleId;
	}
}
