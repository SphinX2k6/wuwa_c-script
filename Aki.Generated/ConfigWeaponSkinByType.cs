using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B60 RID: 2912
	public class ConfigWeaponSkinByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004454 RID: 17492 RVA: 0x001DFAA3 File Offset: 0x001DDCA3
		static ConfigWeaponSkinByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponSkinByType.CreateStaticDefaultValue), new Action(ConfigWeaponSkinByType.ResetStaticDefaultValue));
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x001DFAC4 File Offset: 0x001DDCC4
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponSkinByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponSkinByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponSkin` where WeaponSkinType = ?")
			});
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x001DFB43 File Offset: 0x001DDD43
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponSkinByType.LogPair = null;
			ConfigWeaponSkinByType.HandleId = 0;
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x001DFB51 File Offset: 0x001DDD51
		public static void Init()
		{
			ConfigWeaponSkinByType.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponSkinByType.HandleId, "db_weapon.db", "select BinData from `WeaponSkin` where WeaponSkinType = ?");
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x001DFB6C File Offset: 0x001DDD6C
		[NullableContext(2)]
		public static IReadOnlyList<WeaponSkin> GetConfigList(int p0WeaponSkinType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponSkinByType.HandleId, ConfigWeaponSkinByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponSkinByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponSkinType);
				IReadOnlyList<WeaponSkin> readOnlyList = (IReadOnlyList<WeaponSkin>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWeaponSkinByType.LogPair.Clear();
			ConfigWeaponSkinByType.LogPair.Add(new ValueTuple<string, object>("WeaponSkinType", p0WeaponSkinType));
			if (!ConfigCommon.BindInt(ConfigWeaponSkinByType.HandleId, 1, p0WeaponSkinType, ConfigWeaponSkinByType.LogPair))
			{
				ConfigCommon.Reset(ConfigWeaponSkinByType.HandleId, ConfigWeaponSkinByType.LogPair);
				return null;
			}
			List<WeaponSkin> list = new List<WeaponSkin>();
			while (ConfigCommon.Step(ConfigWeaponSkinByType.HandleId, false, ConfigWeaponSkinByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponSkinByType.HandleId, 0, ConfigWeaponSkinByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeaponSkinByType.HandleId, ConfigWeaponSkinByType.LogPair);
					return null;
				}
				WeaponSkin rootAsWeaponSkin = WeaponSkin.GetRootAsWeaponSkin(new ByteBuffer(item2));
				list.Add(rootAsWeaponSkin);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponSkinByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponSkinType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeaponSkinByType.HandleId, ConfigWeaponSkinByType.LogPair);
			return list;
		}

		// Token: 0x04004F86 RID: 20358
		private const string DB = "db_weapon.db";

		// Token: 0x04004F87 RID: 20359
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F88 RID: 20360
		private const string TABLE = "WeaponSkin";

		// Token: 0x04004F89 RID: 20361
		private const string COMMAND = "select BinData from `WeaponSkin` where WeaponSkinType = ?";

		// Token: 0x04004F8A RID: 20362
		private const string KEY_PREFIX = "WeaponSkinByType";

		// Token: 0x04004F8B RID: 20363
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F8C RID: 20364
		private static int HandleId;
	}
}
