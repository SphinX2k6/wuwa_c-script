using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8C RID: 2700
	public class ConfigWeaponVisibleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F5C RID: 16220 RVA: 0x001C0947 File Offset: 0x001BEB47
		static ConfigWeaponVisibleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponVisibleConfigById.CreateStaticDefaultValue), new Action(ConfigWeaponVisibleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x001C0968 File Offset: 0x001BEB68
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponVisibleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponVisibleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon_visible.db"),
				new ValueTuple<string, object>("文件", "w.武器显示配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponVisibleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponVisibleConfig` where Id=?")
			});
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x001C09E7 File Offset: 0x001BEBE7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponVisibleConfigById.LogPair = null;
			ConfigWeaponVisibleConfigById.HandleId = 0;
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x001C09F5 File Offset: 0x001BEBF5
		public static void Init()
		{
			ConfigWeaponVisibleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponVisibleConfigById.HandleId, "db_weapon_visible.db", "select BinData from `WeaponVisibleConfig` where Id=?");
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x001C0A10 File Offset: 0x001BEC10
		public static WeaponVisibleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponVisibleConfigById.HandleId, ConfigWeaponVisibleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponVisibleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponVisibleConfig?(WeaponVisibleConfig.GetRootAsWeaponVisibleConfig(configBuffer));
				}
			}
			ConfigWeaponVisibleConfigById.LogPair.Clear();
			ConfigWeaponVisibleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponVisibleConfigById.HandleId, 1, p0Id, ConfigWeaponVisibleConfigById.LogPair) || ConfigCommon.Step(ConfigWeaponVisibleConfigById.HandleId, true, ConfigWeaponVisibleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponVisibleConfigById.HandleId, ConfigWeaponVisibleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponVisibleConfigById.HandleId, 0, ConfigWeaponVisibleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponVisibleConfigById.HandleId, ConfigWeaponVisibleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponVisibleConfig rootAsWeaponVisibleConfig = WeaponVisibleConfig.GetRootAsWeaponVisibleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponVisibleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponVisibleConfigById.HandleId, ConfigWeaponVisibleConfigById.LogPair);
			return new WeaponVisibleConfig?(rootAsWeaponVisibleConfig);
		}

		// Token: 0x040049BA RID: 18874
		private const string DB = "db_weapon_visible.db";

		// Token: 0x040049BB RID: 18875
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x040049BC RID: 18876
		private const string TABLE = "WeaponVisibleConfig";

		// Token: 0x040049BD RID: 18877
		private const string COMMAND = "select BinData from `WeaponVisibleConfig` where Id=?";

		// Token: 0x040049BE RID: 18878
		private const string KEY_PREFIX = "WeaponVisibleConfigById";

		// Token: 0x040049BF RID: 18879
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049C0 RID: 18880
		private static int HandleId;
	}
}
