using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8A RID: 2698
	public class ConfigWeaponSkinByIsShow : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F50 RID: 16208 RVA: 0x001C04D8 File Offset: 0x001BE6D8
		static ConfigWeaponSkinByIsShow()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponSkinByIsShow.CreateStaticDefaultValue), new Action(ConfigWeaponSkinByIsShow.ResetStaticDefaultValue));
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x001C04F8 File Offset: 0x001BE6F8
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponSkinByIsShow.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponSkinByIsShow.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponSkin` where IsShow = ?")
			});
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x001C0577 File Offset: 0x001BE777
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponSkinByIsShow.LogPair = null;
			ConfigWeaponSkinByIsShow.HandleId = 0;
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x001C0585 File Offset: 0x001BE785
		public static void Init()
		{
			ConfigWeaponSkinByIsShow.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponSkinByIsShow.HandleId, "db_weapon.db", "select BinData from `WeaponSkin` where IsShow = ?");
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x001C05A0 File Offset: 0x001BE7A0
		[NullableContext(2)]
		public static IReadOnlyList<WeaponSkin> GetConfigList(bool p0IsShow, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponSkinByIsShow.HandleId, ConfigWeaponSkinByIsShow.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponSkinByIsShow");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(p0IsShow);
				IReadOnlyList<WeaponSkin> readOnlyList = (IReadOnlyList<WeaponSkin>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWeaponSkinByIsShow.LogPair.Clear();
			ConfigWeaponSkinByIsShow.LogPair.Add(new ValueTuple<string, object>("IsShow", p0IsShow));
			if (!ConfigCommon.BindBool(ConfigWeaponSkinByIsShow.HandleId, 1, p0IsShow, ConfigWeaponSkinByIsShow.LogPair))
			{
				ConfigCommon.Reset(ConfigWeaponSkinByIsShow.HandleId, ConfigWeaponSkinByIsShow.LogPair);
				return null;
			}
			List<WeaponSkin> list = new List<WeaponSkin>();
			while (ConfigCommon.Step(ConfigWeaponSkinByIsShow.HandleId, false, ConfigWeaponSkinByIsShow.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponSkinByIsShow.HandleId, 0, ConfigWeaponSkinByIsShow.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeaponSkinByIsShow.HandleId, ConfigWeaponSkinByIsShow.LogPair);
					return null;
				}
				WeaponSkin rootAsWeaponSkin = WeaponSkin.GetRootAsWeaponSkin(new ByteBuffer(item2));
				list.Add(rootAsWeaponSkin);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponSkinByIsShow");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(p0IsShow);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeaponSkinByIsShow.HandleId, ConfigWeaponSkinByIsShow.LogPair);
			return list;
		}

		// Token: 0x040049AC RID: 18860
		private const string DB = "db_weapon.db";

		// Token: 0x040049AD RID: 18861
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x040049AE RID: 18862
		private const string TABLE = "WeaponSkin";

		// Token: 0x040049AF RID: 18863
		private const string COMMAND = "select BinData from `WeaponSkin` where IsShow = ?";

		// Token: 0x040049B0 RID: 18864
		private const string KEY_PREFIX = "WeaponSkinByIsShow";

		// Token: 0x040049B1 RID: 18865
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049B2 RID: 18866
		private static int HandleId;
	}
}
