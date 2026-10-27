using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040D RID: 1037
	public class ConfigHonamiStoryWeaponById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001855 RID: 6229 RVA: 0x000E3613 File Offset: 0x000E1813
		static ConfigHonamiStoryWeaponById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryWeaponById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryWeaponById.ResetStaticDefaultValue));
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x000E3634 File Offset: 0x000E1834
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

		// Token: 0x06001857 RID: 6231 RVA: 0x000E36B3 File Offset: 0x000E18B3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponById.LogPair = null;
			ConfigHonamiStoryWeaponById.HandleId = 0;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000E36C1 File Offset: 0x000E18C1
		public static void Init()
		{
			ConfigHonamiStoryWeaponById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryWeaponById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryWeapon` where Id=?");
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000E36DC File Offset: 0x000E18DC
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

		// Token: 0x04001C3F RID: 7231
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C40 RID: 7232
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001C41 RID: 7233
		private const string TABLE = "HonamiStoryWeapon";

		// Token: 0x04001C42 RID: 7234
		private const string COMMAND = "select BinData from `HonamiStoryWeapon` where Id=?";

		// Token: 0x04001C43 RID: 7235
		private const string KEY_PREFIX = "HonamiStoryWeaponById";

		// Token: 0x04001C44 RID: 7236
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C45 RID: 7237
		private static int HandleId;
	}
}
