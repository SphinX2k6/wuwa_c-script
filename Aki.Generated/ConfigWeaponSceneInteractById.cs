using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5D RID: 2909
	public class ConfigWeaponSceneInteractById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004442 RID: 17474 RVA: 0x001DF3DD File Offset: 0x001DD5DD
		static ConfigWeaponSceneInteractById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponSceneInteractById.CreateStaticDefaultValue), new Action(ConfigWeaponSceneInteractById.ResetStaticDefaultValue));
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x001DF3FC File Offset: 0x001DD5FC
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponSceneInteractById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponSceneInteractById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponSceneInteract"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponSceneInteract` where Id = ?")
			});
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x001DF47B File Offset: 0x001DD67B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponSceneInteractById.LogPair = null;
			ConfigWeaponSceneInteractById.HandleId = 0;
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x001DF489 File Offset: 0x001DD689
		public static void Init()
		{
			ConfigWeaponSceneInteractById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponSceneInteractById.HandleId, "db_weapon.db", "select BinData from `WeaponSceneInteract` where Id = ?");
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x001DF4A4 File Offset: 0x001DD6A4
		public static WeaponSceneInteract? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponSceneInteractById.HandleId, ConfigWeaponSceneInteractById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponSceneInteractById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponSceneInteract?(WeaponSceneInteract.GetRootAsWeaponSceneInteract(configBuffer));
				}
			}
			ConfigWeaponSceneInteractById.LogPair.Clear();
			ConfigWeaponSceneInteractById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponSceneInteractById.HandleId, 1, p0Id, ConfigWeaponSceneInteractById.LogPair) || ConfigCommon.Step(ConfigWeaponSceneInteractById.HandleId, true, ConfigWeaponSceneInteractById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponSceneInteractById.HandleId, ConfigWeaponSceneInteractById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponSceneInteractById.HandleId, 0, ConfigWeaponSceneInteractById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponSceneInteractById.HandleId, ConfigWeaponSceneInteractById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponSceneInteract rootAsWeaponSceneInteract = WeaponSceneInteract.GetRootAsWeaponSceneInteract(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponSceneInteractById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponSceneInteractById.HandleId, ConfigWeaponSceneInteractById.LogPair);
			return new WeaponSceneInteract?(rootAsWeaponSceneInteract);
		}

		// Token: 0x04004F71 RID: 20337
		private const string DB = "db_weapon.db";

		// Token: 0x04004F72 RID: 20338
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F73 RID: 20339
		private const string TABLE = "WeaponSceneInteract";

		// Token: 0x04004F74 RID: 20340
		private const string COMMAND = "select BinData from `WeaponSceneInteract` where Id = ?";

		// Token: 0x04004F75 RID: 20341
		private const string KEY_PREFIX = "WeaponSceneInteractById";

		// Token: 0x04004F76 RID: 20342
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F77 RID: 20343
		private static int HandleId;
	}
}
