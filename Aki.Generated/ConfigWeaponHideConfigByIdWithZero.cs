using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B56 RID: 2902
	public class ConfigWeaponHideConfigByIdWithZero : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004418 RID: 17432 RVA: 0x001DE1F4 File Offset: 0x001DC3F4
		static ConfigWeaponHideConfigByIdWithZero()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponHideConfigByIdWithZero.CreateStaticDefaultValue), new Action(ConfigWeaponHideConfigByIdWithZero.ResetStaticDefaultValue));
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x001DE214 File Offset: 0x001DC414
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponHideConfigByIdWithZero.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponHideConfigByIdWithZero.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon_visible.db"),
				new ValueTuple<string, object>("文件", "w.武器显示配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponHideConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponHideConfig` where id=0 AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) >0;")
			});
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x001DE293 File Offset: 0x001DC493
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponHideConfigByIdWithZero.LogPair = null;
			ConfigWeaponHideConfigByIdWithZero.HandleId = 0;
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x001DE2A1 File Offset: 0x001DC4A1
		public static void Init()
		{
			ConfigWeaponHideConfigByIdWithZero.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponHideConfigByIdWithZero.HandleId, "db_weapon_visible.db", "select BinData from `WeaponHideConfig` where id=0 AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) >0;");
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x001DE2BC File Offset: 0x001DC4BC
		public static WeaponHideConfig? GetConfig(int p0Id, int p1Id, int p2Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponHideConfigByIdWithZero.HandleId, ConfigWeaponHideConfigByIdWithZero.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHideConfigByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponHideConfig?(WeaponHideConfig.GetRootAsWeaponHideConfig(configBuffer));
				}
			}
			ConfigWeaponHideConfigByIdWithZero.LogPair.Clear();
			ConfigWeaponHideConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigWeaponHideConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			ConfigWeaponHideConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p2Id));
			if (!ConfigCommon.BindInt(ConfigWeaponHideConfigByIdWithZero.HandleId, 1, p0Id, ConfigWeaponHideConfigByIdWithZero.LogPair) || !ConfigCommon.BindInt(ConfigWeaponHideConfigByIdWithZero.HandleId, 2, p1Id, ConfigWeaponHideConfigByIdWithZero.LogPair) || !ConfigCommon.BindInt(ConfigWeaponHideConfigByIdWithZero.HandleId, 3, p2Id, ConfigWeaponHideConfigByIdWithZero.LogPair) || ConfigCommon.Step(ConfigWeaponHideConfigByIdWithZero.HandleId, true, ConfigWeaponHideConfigByIdWithZero.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponHideConfigByIdWithZero.HandleId, ConfigWeaponHideConfigByIdWithZero.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponHideConfigByIdWithZero.HandleId, 0, ConfigWeaponHideConfigByIdWithZero.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponHideConfigByIdWithZero.HandleId, ConfigWeaponHideConfigByIdWithZero.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponHideConfig rootAsWeaponHideConfig = WeaponHideConfig.GetRootAsWeaponHideConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHideConfigByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponHideConfigByIdWithZero.HandleId, ConfigWeaponHideConfigByIdWithZero.LogPair);
			return new WeaponHideConfig?(rootAsWeaponHideConfig);
		}

		// Token: 0x04004F40 RID: 20288
		private const string DB = "db_weapon_visible.db";

		// Token: 0x04004F41 RID: 20289
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x04004F42 RID: 20290
		private const string TABLE = "WeaponHideConfig";

		// Token: 0x04004F43 RID: 20291
		private const string COMMAND = "select BinData from `WeaponHideConfig` where id=0 AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponHideConfig` WHERE id = ?) >0;";

		// Token: 0x04004F44 RID: 20292
		private const string KEY_PREFIX = "WeaponHideConfigByIdWithZero";

		// Token: 0x04004F45 RID: 20293
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F46 RID: 20294
		private static int HandleId;
	}
}
