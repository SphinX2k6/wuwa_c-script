using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040E RID: 1038
	public class ConfigHonamiStoryWeaponSuitById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600185B RID: 6235 RVA: 0x000E385C File Offset: 0x000E1A5C
		static ConfigHonamiStoryWeaponSuitById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryWeaponSuitById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryWeaponSuitById.ResetStaticDefaultValue));
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000E387C File Offset: 0x000E1A7C
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

		// Token: 0x0600185D RID: 6237 RVA: 0x000E38FB File Offset: 0x000E1AFB
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponSuitById.LogPair = null;
			ConfigHonamiStoryWeaponSuitById.HandleId = 0;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000E3909 File Offset: 0x000E1B09
		public static void Init()
		{
			ConfigHonamiStoryWeaponSuitById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryWeaponSuitById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryWeaponSuit` where Id=?");
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000E3924 File Offset: 0x000E1B24
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

		// Token: 0x04001C46 RID: 7238
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C47 RID: 7239
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001C48 RID: 7240
		private const string TABLE = "HonamiStoryWeaponSuit";

		// Token: 0x04001C49 RID: 7241
		private const string COMMAND = "select BinData from `HonamiStoryWeaponSuit` where Id=?";

		// Token: 0x04001C4A RID: 7242
		private const string KEY_PREFIX = "HonamiStoryWeaponSuitById";

		// Token: 0x04001C4B RID: 7243
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C4C RID: 7244
		private static int HandleId;
	}
}
