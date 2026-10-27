using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8D RID: 2701
	public class ConfigWeaponVisibleConfigByIdWithZero : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F62 RID: 16226 RVA: 0x001C0B90 File Offset: 0x001BED90
		static ConfigWeaponVisibleConfigByIdWithZero()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponVisibleConfigByIdWithZero.CreateStaticDefaultValue), new Action(ConfigWeaponVisibleConfigByIdWithZero.ResetStaticDefaultValue));
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x001C0BB0 File Offset: 0x001BEDB0
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponVisibleConfigByIdWithZero.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponVisibleConfigByIdWithZero.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon_visible.db"),
				new ValueTuple<string, object>("文件", "w.武器显示配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponVisibleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponVisibleConfig` where id=0 AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) >0;")
			});
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x001C0C2F File Offset: 0x001BEE2F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponVisibleConfigByIdWithZero.LogPair = null;
			ConfigWeaponVisibleConfigByIdWithZero.HandleId = 0;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x001C0C3D File Offset: 0x001BEE3D
		public static void Init()
		{
			ConfigWeaponVisibleConfigByIdWithZero.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponVisibleConfigByIdWithZero.HandleId, "db_weapon_visible.db", "select BinData from `WeaponVisibleConfig` where id=0 AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) >0;");
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x001C0C58 File Offset: 0x001BEE58
		public static WeaponVisibleConfig? GetConfig(int p0Id, int p1Id, int p2Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponVisibleConfigByIdWithZero.HandleId, ConfigWeaponVisibleConfigByIdWithZero.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponVisibleConfigByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponVisibleConfig?(WeaponVisibleConfig.GetRootAsWeaponVisibleConfig(configBuffer));
				}
			}
			ConfigWeaponVisibleConfigByIdWithZero.LogPair.Clear();
			ConfigWeaponVisibleConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigWeaponVisibleConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			ConfigWeaponVisibleConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p2Id));
			if (!ConfigCommon.BindInt(ConfigWeaponVisibleConfigByIdWithZero.HandleId, 1, p0Id, ConfigWeaponVisibleConfigByIdWithZero.LogPair) || !ConfigCommon.BindInt(ConfigWeaponVisibleConfigByIdWithZero.HandleId, 2, p1Id, ConfigWeaponVisibleConfigByIdWithZero.LogPair) || !ConfigCommon.BindInt(ConfigWeaponVisibleConfigByIdWithZero.HandleId, 3, p2Id, ConfigWeaponVisibleConfigByIdWithZero.LogPair) || ConfigCommon.Step(ConfigWeaponVisibleConfigByIdWithZero.HandleId, true, ConfigWeaponVisibleConfigByIdWithZero.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponVisibleConfigByIdWithZero.HandleId, ConfigWeaponVisibleConfigByIdWithZero.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponVisibleConfigByIdWithZero.HandleId, 0, ConfigWeaponVisibleConfigByIdWithZero.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponVisibleConfigByIdWithZero.HandleId, ConfigWeaponVisibleConfigByIdWithZero.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponVisibleConfig rootAsWeaponVisibleConfig = WeaponVisibleConfig.GetRootAsWeaponVisibleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponVisibleConfigByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponVisibleConfigByIdWithZero.HandleId, ConfigWeaponVisibleConfigByIdWithZero.LogPair);
			return new WeaponVisibleConfig?(rootAsWeaponVisibleConfig);
		}

		// Token: 0x040049C1 RID: 18881
		private const string DB = "db_weapon_visible.db";

		// Token: 0x040049C2 RID: 18882
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x040049C3 RID: 18883
		private const string TABLE = "WeaponVisibleConfig";

		// Token: 0x040049C4 RID: 18884
		private const string COMMAND = "select BinData from `WeaponVisibleConfig` where id=0 AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) >0;";

		// Token: 0x040049C5 RID: 18885
		private const string KEY_PREFIX = "WeaponVisibleConfigByIdWithZero";

		// Token: 0x040049C6 RID: 18886
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049C7 RID: 18887
		private static int HandleId;
	}
}
