using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000378 RID: 888
	public class ConfigGachaWeaponSeqConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014D6 RID: 5334 RVA: 0x000CF668 File Offset: 0x000CD868
		static ConfigGachaWeaponSeqConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaWeaponSeqConfigById.CreateStaticDefaultValue), new Action(ConfigGachaWeaponSeqConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x000CF688 File Offset: 0x000CD888
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

		// Token: 0x060014D8 RID: 5336 RVA: 0x000CF707 File Offset: 0x000CD907
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaWeaponSeqConfigById.LogPair = null;
			ConfigGachaWeaponSeqConfigById.HandleId = 0;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000CF715 File Offset: 0x000CD915
		public static void Init()
		{
			ConfigGachaWeaponSeqConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaWeaponSeqConfigById.HandleId, "db_gacha.db", "select BinData from `GachaWeaponSeqConfig` where Id=?");
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000CF730 File Offset: 0x000CD930
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

		// Token: 0x0400182C RID: 6188
		private const string DB = "db_gacha.db";

		// Token: 0x0400182D RID: 6189
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x0400182E RID: 6190
		private const string TABLE = "GachaWeaponSeqConfig";

		// Token: 0x0400182F RID: 6191
		private const string COMMAND = "select BinData from `GachaWeaponSeqConfig` where Id=?";

		// Token: 0x04001830 RID: 6192
		private const string KEY_PREFIX = "GachaWeaponSeqConfigById";

		// Token: 0x04001831 RID: 6193
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001832 RID: 6194
		private static int HandleId;
	}
}
