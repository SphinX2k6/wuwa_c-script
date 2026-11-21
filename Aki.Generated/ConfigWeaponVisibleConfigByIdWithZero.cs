using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B62 RID: 2914
	public class ConfigWeaponVisibleConfigByIdWithZero : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004460 RID: 17504 RVA: 0x001DFF24 File Offset: 0x001DE124
		static ConfigWeaponVisibleConfigByIdWithZero()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponVisibleConfigByIdWithZero.CreateStaticDefaultValue), new Action(ConfigWeaponVisibleConfigByIdWithZero.ResetStaticDefaultValue));
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x001DFF44 File Offset: 0x001DE144
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

		// Token: 0x06004462 RID: 17506 RVA: 0x001DFFC3 File Offset: 0x001DE1C3
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponVisibleConfigByIdWithZero.LogPair = null;
			ConfigWeaponVisibleConfigByIdWithZero.HandleId = 0;
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x001DFFD1 File Offset: 0x001DE1D1
		public static void Init()
		{
			ConfigWeaponVisibleConfigByIdWithZero.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponVisibleConfigByIdWithZero.HandleId, "db_weapon_visible.db", "select BinData from `WeaponVisibleConfig` where id=0 AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) >0;");
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x001DFFEC File Offset: 0x001DE1EC
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

		// Token: 0x04004F94 RID: 20372
		private const string DB = "db_weapon_visible.db";

		// Token: 0x04004F95 RID: 20373
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x04004F96 RID: 20374
		private const string TABLE = "WeaponVisibleConfig";

		// Token: 0x04004F97 RID: 20375
		private const string COMMAND = "select BinData from `WeaponVisibleConfig` where id=0 AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `WeaponVisibleConfig` WHERE id = ?) >0;";

		// Token: 0x04004F98 RID: 20376
		private const string KEY_PREFIX = "WeaponVisibleConfigByIdWithZero";

		// Token: 0x04004F99 RID: 20377
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F9A RID: 20378
		private static int HandleId;
	}
}
