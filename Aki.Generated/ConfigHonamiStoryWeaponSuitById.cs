using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000424 RID: 1060
	public class ConfigHonamiStoryWeaponSuitById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018DF RID: 6367 RVA: 0x000E9FB0 File Offset: 0x000E81B0
		static ConfigHonamiStoryWeaponSuitById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryWeaponSuitById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryWeaponSuitById.ResetStaticDefaultValue));
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000E9FD0 File Offset: 0x000E81D0
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponSuitById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryWeaponSuitById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryWeaponSuit"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryWeaponSuit` where Id=?")
			});
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000EA04F File Offset: 0x000E824F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponSuitById.LogPair = null;
			ConfigHonamiStoryWeaponSuitById.HandleId = 0;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000EA05D File Offset: 0x000E825D
		public static void Init()
		{
			ConfigHonamiStoryWeaponSuitById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryWeaponSuitById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryWeaponSuit` where Id=?");
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x000EA078 File Offset: 0x000E8278
		public static HonamiStoryWeaponSuit? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryWeaponSuitById.HandleId, ConfigHonamiStoryWeaponSuitById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryWeaponSuitById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryWeaponSuit?(HonamiStoryWeaponSuit.GetRootAsHonamiStoryWeaponSuit(configBuffer));
				}
			}
			ConfigHonamiStoryWeaponSuitById.LogPair.Clear();
			ConfigHonamiStoryWeaponSuitById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryWeaponSuitById.HandleId, 1, p0Id, ConfigHonamiStoryWeaponSuitById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryWeaponSuitById.HandleId, true, ConfigHonamiStoryWeaponSuitById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryWeaponSuitById.HandleId, ConfigHonamiStoryWeaponSuitById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryWeaponSuitById.HandleId, 0, ConfigHonamiStoryWeaponSuitById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryWeaponSuitById.HandleId, ConfigHonamiStoryWeaponSuitById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryWeaponSuit rootAsHonamiStoryWeaponSuit = HonamiStoryWeaponSuit.GetRootAsHonamiStoryWeaponSuit(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryWeaponSuitById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryWeaponSuitById.HandleId, ConfigHonamiStoryWeaponSuitById.LogPair);
			return new HonamiStoryWeaponSuit?(rootAsHonamiStoryWeaponSuit);
		}

		// Token: 0x04001CE0 RID: 7392
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CE1 RID: 7393
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001CE2 RID: 7394
		private const string TABLE = "HonamiStoryWeaponSuit";

		// Token: 0x04001CE3 RID: 7395
		private const string COMMAND = "select BinData from `HonamiStoryWeaponSuit` where Id=?";

		// Token: 0x04001CE4 RID: 7396
		private const string KEY_PREFIX = "HonamiStoryWeaponSuitById";

		// Token: 0x04001CE5 RID: 7397
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CE6 RID: 7398
		private static int HandleId;
	}
}
