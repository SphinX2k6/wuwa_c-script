using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5E RID: 2910
	public class ConfigWeaponSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004448 RID: 17480 RVA: 0x001DF624 File Offset: 0x001DD824
		static ConfigWeaponSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponSkinById.CreateStaticDefaultValue), new Action(ConfigWeaponSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x001DF644 File Offset: 0x001DD844
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

		// Token: 0x0600444A RID: 17482 RVA: 0x001DF6C3 File Offset: 0x001DD8C3
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponSkinById.LogPair = null;
			ConfigWeaponSkinById.HandleId = 0;
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x001DF6D1 File Offset: 0x001DD8D1
		public static void Init()
		{
			ConfigWeaponSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponSkinById.HandleId, "db_weapon.db", "select BinData from `WeaponSkin` where Id = ?");
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x001DF6EC File Offset: 0x001DD8EC
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

		// Token: 0x04004F78 RID: 20344
		private const string DB = "db_weapon.db";

		// Token: 0x04004F79 RID: 20345
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F7A RID: 20346
		private const string TABLE = "WeaponSkin";

		// Token: 0x04004F7B RID: 20347
		private const string COMMAND = "select BinData from `WeaponSkin` where Id = ?";

		// Token: 0x04004F7C RID: 20348
		private const string KEY_PREFIX = "WeaponSkinById";

		// Token: 0x04004F7D RID: 20349
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F7E RID: 20350
		private static int HandleId;
	}
}
