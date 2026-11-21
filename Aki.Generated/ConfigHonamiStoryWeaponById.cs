using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000423 RID: 1059
	public class ConfigHonamiStoryWeaponById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018D9 RID: 6361 RVA: 0x000E9D67 File Offset: 0x000E7F67
		static ConfigHonamiStoryWeaponById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryWeaponById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryWeaponById.ResetStaticDefaultValue));
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000E9D88 File Offset: 0x000E7F88
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryWeaponById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryWeapon"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryWeapon` where Id=?")
			});
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000E9E07 File Offset: 0x000E8007
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponById.LogPair = null;
			ConfigHonamiStoryWeaponById.HandleId = 0;
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000E9E15 File Offset: 0x000E8015
		public static void Init()
		{
			ConfigHonamiStoryWeaponById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryWeaponById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryWeapon` where Id=?");
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000E9E30 File Offset: 0x000E8030
		public static HonamiStoryWeapon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryWeaponById.HandleId, ConfigHonamiStoryWeaponById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryWeaponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryWeapon?(HonamiStoryWeapon.GetRootAsHonamiStoryWeapon(configBuffer));
				}
			}
			ConfigHonamiStoryWeaponById.LogPair.Clear();
			ConfigHonamiStoryWeaponById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryWeaponById.HandleId, 1, p0Id, ConfigHonamiStoryWeaponById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryWeaponById.HandleId, true, ConfigHonamiStoryWeaponById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryWeaponById.HandleId, ConfigHonamiStoryWeaponById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryWeaponById.HandleId, 0, ConfigHonamiStoryWeaponById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryWeaponById.HandleId, ConfigHonamiStoryWeaponById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryWeapon rootAsHonamiStoryWeapon = HonamiStoryWeapon.GetRootAsHonamiStoryWeapon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryWeaponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryWeaponById.HandleId, ConfigHonamiStoryWeaponById.LogPair);
			return new HonamiStoryWeapon?(rootAsHonamiStoryWeapon);
		}

		// Token: 0x04001CD9 RID: 7385
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CDA RID: 7386
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001CDB RID: 7387
		private const string TABLE = "HonamiStoryWeapon";

		// Token: 0x04001CDC RID: 7388
		private const string COMMAND = "select BinData from `HonamiStoryWeapon` where Id=?";

		// Token: 0x04001CDD RID: 7389
		private const string KEY_PREFIX = "HonamiStoryWeaponById";

		// Token: 0x04001CDE RID: 7390
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CDF RID: 7391
		private static int HandleId;
	}
}
