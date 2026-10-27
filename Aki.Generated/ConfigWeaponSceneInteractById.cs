using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A88 RID: 2696
	public class ConfigWeaponSceneInteractById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F44 RID: 16196 RVA: 0x001C0049 File Offset: 0x001BE249
		static ConfigWeaponSceneInteractById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponSceneInteractById.CreateStaticDefaultValue), new Action(ConfigWeaponSceneInteractById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x001C0068 File Offset: 0x001BE268
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

		// Token: 0x06003F46 RID: 16198 RVA: 0x001C00E7 File Offset: 0x001BE2E7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponSceneInteractById.LogPair = null;
			ConfigWeaponSceneInteractById.HandleId = 0;
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x001C00F5 File Offset: 0x001BE2F5
		public static void Init()
		{
			ConfigWeaponSceneInteractById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponSceneInteractById.HandleId, "db_weapon.db", "select BinData from `WeaponSceneInteract` where Id = ?");
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x001C0110 File Offset: 0x001BE310
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

		// Token: 0x0400499E RID: 18846
		private const string DB = "db_weapon.db";

		// Token: 0x0400499F RID: 18847
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x040049A0 RID: 18848
		private const string TABLE = "WeaponSceneInteract";

		// Token: 0x040049A1 RID: 18849
		private const string COMMAND = "select BinData from `WeaponSceneInteract` where Id = ?";

		// Token: 0x040049A2 RID: 18850
		private const string KEY_PREFIX = "WeaponSceneInteractById";

		// Token: 0x040049A3 RID: 18851
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049A4 RID: 18852
		private static int HandleId;
	}
}
