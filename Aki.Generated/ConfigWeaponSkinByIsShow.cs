using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5F RID: 2911
	public class ConfigWeaponSkinByIsShow : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600444E RID: 17486 RVA: 0x001DF86C File Offset: 0x001DDA6C
		static ConfigWeaponSkinByIsShow()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponSkinByIsShow.CreateStaticDefaultValue), new Action(ConfigWeaponSkinByIsShow.ResetStaticDefaultValue));
		}

		// Token: 0x0600444F RID: 17487 RVA: 0x001DF88C File Offset: 0x001DDA8C
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

		// Token: 0x06004450 RID: 17488 RVA: 0x001DF90B File Offset: 0x001DDB0B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponSkinByIsShow.LogPair = null;
			ConfigWeaponSkinByIsShow.HandleId = 0;
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x001DF919 File Offset: 0x001DDB19
		public static void Init()
		{
			ConfigWeaponSkinByIsShow.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponSkinByIsShow.HandleId, "db_weapon.db", "select BinData from `WeaponSkin` where IsShow = ?");
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x001DF934 File Offset: 0x001DDB34
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

		// Token: 0x04004F7F RID: 20351
		private const string DB = "db_weapon.db";

		// Token: 0x04004F80 RID: 20352
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F81 RID: 20353
		private const string TABLE = "WeaponSkin";

		// Token: 0x04004F82 RID: 20354
		private const string COMMAND = "select BinData from `WeaponSkin` where IsShow = ?";

		// Token: 0x04004F83 RID: 20355
		private const string KEY_PREFIX = "WeaponSkinByIsShow";

		// Token: 0x04004F84 RID: 20356
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F85 RID: 20357
		private static int HandleId;
	}
}
