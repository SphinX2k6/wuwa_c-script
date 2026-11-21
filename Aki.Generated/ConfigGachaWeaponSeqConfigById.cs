using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038D RID: 909
	public class ConfigGachaWeaponSeqConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001554 RID: 5460 RVA: 0x000D5B74 File Offset: 0x000D3D74
		static ConfigGachaWeaponSeqConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaWeaponSeqConfigById.CreateStaticDefaultValue), new Action(ConfigGachaWeaponSeqConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x000D5B94 File Offset: 0x000D3D94
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaWeaponSeqConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaWeaponSeqConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaWeaponSeqConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaWeaponSeqConfig` where Id=?")
			});
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000D5C13 File Offset: 0x000D3E13
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaWeaponSeqConfigById.LogPair = null;
			ConfigGachaWeaponSeqConfigById.HandleId = 0;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000D5C21 File Offset: 0x000D3E21
		public static void Init()
		{
			ConfigGachaWeaponSeqConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaWeaponSeqConfigById.HandleId, "db_gacha.db", "select BinData from `GachaWeaponSeqConfig` where Id=?");
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000D5C3C File Offset: 0x000D3E3C
		public static GachaWeaponSeqConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaWeaponSeqConfigById.HandleId, ConfigGachaWeaponSeqConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaWeaponSeqConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaWeaponSeqConfig?(GachaWeaponSeqConfig.GetRootAsGachaWeaponSeqConfig(configBuffer));
				}
			}
			ConfigGachaWeaponSeqConfigById.LogPair.Clear();
			ConfigGachaWeaponSeqConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaWeaponSeqConfigById.HandleId, 1, p0Id, ConfigGachaWeaponSeqConfigById.LogPair) || ConfigCommon.Step(ConfigGachaWeaponSeqConfigById.HandleId, true, ConfigGachaWeaponSeqConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaWeaponSeqConfigById.HandleId, ConfigGachaWeaponSeqConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaWeaponSeqConfigById.HandleId, 0, ConfigGachaWeaponSeqConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaWeaponSeqConfigById.HandleId, ConfigGachaWeaponSeqConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaWeaponSeqConfig rootAsGachaWeaponSeqConfig = GachaWeaponSeqConfig.GetRootAsGachaWeaponSeqConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaWeaponSeqConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaWeaponSeqConfigById.HandleId, ConfigGachaWeaponSeqConfigById.LogPair);
			return new GachaWeaponSeqConfig?(rootAsGachaWeaponSeqConfig);
		}

		// Token: 0x040018BF RID: 6335
		private const string DB = "db_gacha.db";

		// Token: 0x040018C0 RID: 6336
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040018C1 RID: 6337
		private const string TABLE = "GachaWeaponSeqConfig";

		// Token: 0x040018C2 RID: 6338
		private const string COMMAND = "select BinData from `GachaWeaponSeqConfig` where Id=?";

		// Token: 0x040018C3 RID: 6339
		private const string KEY_PREFIX = "GachaWeaponSeqConfigById";

		// Token: 0x040018C4 RID: 6340
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018C5 RID: 6341
		private static int HandleId;
	}
}
