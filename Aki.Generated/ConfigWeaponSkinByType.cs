using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8B RID: 2699
	public class ConfigWeaponSkinByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F56 RID: 16214 RVA: 0x001C070F File Offset: 0x001BE90F
		static ConfigWeaponSkinByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponSkinByType.CreateStaticDefaultValue), new Action(ConfigWeaponSkinByType.ResetStaticDefaultValue));
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x001C0730 File Offset: 0x001BE930
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

		// Token: 0x06003F58 RID: 16216 RVA: 0x001C07AF File Offset: 0x001BE9AF
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponSkinByType.LogPair = null;
			ConfigWeaponSkinByType.HandleId = 0;
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x001C07BD File Offset: 0x001BE9BD
		public static void Init()
		{
			ConfigWeaponSkinByType.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponSkinByType.HandleId, "db_weapon.db", "select BinData from `WeaponSkin` where WeaponSkinType = ?");
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x001C07D8 File Offset: 0x001BE9D8
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

		// Token: 0x040049B3 RID: 18867
		private const string DB = "db_weapon.db";

		// Token: 0x040049B4 RID: 18868
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x040049B5 RID: 18869
		private const string TABLE = "WeaponSkin";

		// Token: 0x040049B6 RID: 18870
		private const string COMMAND = "select BinData from `WeaponSkin` where WeaponSkinType = ?";

		// Token: 0x040049B7 RID: 18871
		private const string KEY_PREFIX = "WeaponSkinByType";

		// Token: 0x040049B8 RID: 18872
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049B9 RID: 18873
		private static int HandleId;
	}
}
