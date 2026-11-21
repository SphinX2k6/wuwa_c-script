using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B57 RID: 2903
	public class ConfigWeaponLevelByLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600441E RID: 17438 RVA: 0x001DE4E6 File Offset: 0x001DC6E6
		static ConfigWeaponLevelByLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponLevelByLevelId.CreateStaticDefaultValue), new Action(ConfigWeaponLevelByLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x001DE508 File Offset: 0x001DC708
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

		// Token: 0x06004420 RID: 17440 RVA: 0x001DE587 File Offset: 0x001DC787
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponLevelByLevelId.LogPair = null;
			ConfigWeaponLevelByLevelId.HandleId = 0;
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x001DE595 File Offset: 0x001DC795
		public static void Init()
		{
			ConfigWeaponLevelByLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponLevelByLevelId.HandleId, "db_weapon.db", "select BinData from `WeaponLevel` where LevelId = ?");
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x001DE5B0 File Offset: 0x001DC7B0
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

		// Token: 0x04004F47 RID: 20295
		private const string DB = "db_weapon.db";

		// Token: 0x04004F48 RID: 20296
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F49 RID: 20297
		private const string TABLE = "WeaponLevel";

		// Token: 0x04004F4A RID: 20298
		private const string COMMAND = "select BinData from `WeaponLevel` where LevelId = ?";

		// Token: 0x04004F4B RID: 20299
		private const string KEY_PREFIX = "WeaponLevelByLevelId";

		// Token: 0x04004F4C RID: 20300
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F4D RID: 20301
		private static int HandleId;
	}
}
