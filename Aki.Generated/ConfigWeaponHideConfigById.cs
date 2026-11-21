using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B55 RID: 2901
	public class ConfigWeaponHideConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004412 RID: 17426 RVA: 0x001DDFAC File Offset: 0x001DC1AC
		static ConfigWeaponHideConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponHideConfigById.CreateStaticDefaultValue), new Action(ConfigWeaponHideConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x001DDFCC File Offset: 0x001DC1CC
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponHideConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponHideConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon_visible.db"),
				new ValueTuple<string, object>("文件", "w.武器显示配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponHideConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponHideConfig` where Id=?")
			});
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x001DE04B File Offset: 0x001DC24B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponHideConfigById.LogPair = null;
			ConfigWeaponHideConfigById.HandleId = 0;
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x001DE059 File Offset: 0x001DC259
		public static void Init()
		{
			ConfigWeaponHideConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponHideConfigById.HandleId, "db_weapon_visible.db", "select BinData from `WeaponHideConfig` where Id=?");
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x001DE074 File Offset: 0x001DC274
		public static WeaponHideConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponHideConfigById.HandleId, ConfigWeaponHideConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHideConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponHideConfig?(WeaponHideConfig.GetRootAsWeaponHideConfig(configBuffer));
				}
			}
			ConfigWeaponHideConfigById.LogPair.Clear();
			ConfigWeaponHideConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponHideConfigById.HandleId, 1, p0Id, ConfigWeaponHideConfigById.LogPair) || ConfigCommon.Step(ConfigWeaponHideConfigById.HandleId, true, ConfigWeaponHideConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponHideConfigById.HandleId, ConfigWeaponHideConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponHideConfigById.HandleId, 0, ConfigWeaponHideConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponHideConfigById.HandleId, ConfigWeaponHideConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponHideConfig rootAsWeaponHideConfig = WeaponHideConfig.GetRootAsWeaponHideConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponHideConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponHideConfigById.HandleId, ConfigWeaponHideConfigById.LogPair);
			return new WeaponHideConfig?(rootAsWeaponHideConfig);
		}

		// Token: 0x04004F39 RID: 20281
		private const string DB = "db_weapon_visible.db";

		// Token: 0x04004F3A RID: 20282
		private const string FILE = "w.武器显示配置.xlsx";

		// Token: 0x04004F3B RID: 20283
		private const string TABLE = "WeaponHideConfig";

		// Token: 0x04004F3C RID: 20284
		private const string COMMAND = "select BinData from `WeaponHideConfig` where Id=?";

		// Token: 0x04004F3D RID: 20285
		private const string KEY_PREFIX = "WeaponHideConfigById";

		// Token: 0x04004F3E RID: 20286
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F3F RID: 20287
		private static int HandleId;
	}
}
