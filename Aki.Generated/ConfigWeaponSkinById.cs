using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A89 RID: 2697
	public class ConfigWeaponSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F4A RID: 16202 RVA: 0x001C0290 File Offset: 0x001BE490
		static ConfigWeaponSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponSkinById.CreateStaticDefaultValue), new Action(ConfigWeaponSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x001C02B0 File Offset: 0x001BE4B0
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponSkinById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponSkinById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponSkin` where Id = ?")
			});
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x001C032F File Offset: 0x001BE52F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponSkinById.LogPair = null;
			ConfigWeaponSkinById.HandleId = 0;
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x001C033D File Offset: 0x001BE53D
		public static void Init()
		{
			ConfigWeaponSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponSkinById.HandleId, "db_weapon.db", "select BinData from `WeaponSkin` where Id = ?");
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x001C0358 File Offset: 0x001BE558
		public static WeaponSkin? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponSkinById.HandleId, ConfigWeaponSkinById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponSkin?(WeaponSkin.GetRootAsWeaponSkin(configBuffer));
				}
			}
			ConfigWeaponSkinById.LogPair.Clear();
			ConfigWeaponSkinById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponSkinById.HandleId, 1, p0Id, ConfigWeaponSkinById.LogPair) || ConfigCommon.Step(ConfigWeaponSkinById.HandleId, true, ConfigWeaponSkinById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponSkinById.HandleId, ConfigWeaponSkinById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponSkinById.HandleId, 0, ConfigWeaponSkinById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponSkinById.HandleId, ConfigWeaponSkinById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponSkin rootAsWeaponSkin = WeaponSkin.GetRootAsWeaponSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponSkinById.HandleId, ConfigWeaponSkinById.LogPair);
			return new WeaponSkin?(rootAsWeaponSkin);
		}

		// Token: 0x040049A5 RID: 18853
		private const string DB = "db_weapon.db";

		// Token: 0x040049A6 RID: 18854
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x040049A7 RID: 18855
		private const string TABLE = "WeaponSkin";

		// Token: 0x040049A8 RID: 18856
		private const string COMMAND = "select BinData from `WeaponSkin` where Id = ?";

		// Token: 0x040049A9 RID: 18857
		private const string KEY_PREFIX = "WeaponSkinById";

		// Token: 0x040049AA RID: 18858
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049AB RID: 18859
		private static int HandleId;
	}
}
