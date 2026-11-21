using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000425 RID: 1061
	public class ConfigHonamiStoryWeaponSuitByWeaponPluginType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x000EA1F8 File Offset: 0x000E83F8
		static ConfigHonamiStoryWeaponSuitByWeaponPluginType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryWeaponSuitByWeaponPluginType.CreateStaticDefaultValue), new Action(ConfigHonamiStoryWeaponSuitByWeaponPluginType.ResetStaticDefaultValue));
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x000EA218 File Offset: 0x000E8418
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryWeaponSuit"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryWeaponSuit` where WeaponPluginType=?")
			});
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x000EA297 File Offset: 0x000E8497
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair = null;
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId = 0;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x000EA2A5 File Offset: 0x000E84A5
		public static void Init()
		{
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryWeaponSuit` where WeaponPluginType=?");
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000EA2C0 File Offset: 0x000E84C0
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryWeaponSuit> GetConfigList(int p0WeaponPluginType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryWeaponSuitByWeaponPluginType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponPluginType);
				IReadOnlyList<HonamiStoryWeaponSuit> readOnlyList = (IReadOnlyList<HonamiStoryWeaponSuit>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair.Clear();
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair.Add(new ValueTuple<string, object>("WeaponPluginType", p0WeaponPluginType));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, 1, p0WeaponPluginType, ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair);
				return null;
			}
			List<HonamiStoryWeaponSuit> list = new List<HonamiStoryWeaponSuit>();
			while (ConfigCommon.Step(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, false, ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, 0, ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair);
					return null;
				}
				HonamiStoryWeaponSuit rootAsHonamiStoryWeaponSuit = HonamiStoryWeaponSuit.GetRootAsHonamiStoryWeaponSuit(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryWeaponSuit);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryWeaponSuitByWeaponPluginType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponPluginType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair);
			return list;
		}

		// Token: 0x04001CE7 RID: 7399
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CE8 RID: 7400
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001CE9 RID: 7401
		private const string TABLE = "HonamiStoryWeaponSuit";

		// Token: 0x04001CEA RID: 7402
		private const string COMMAND = "select BinData from `HonamiStoryWeaponSuit` where WeaponPluginType=?";

		// Token: 0x04001CEB RID: 7403
		private const string KEY_PREFIX = "HonamiStoryWeaponSuitByWeaponPluginType";

		// Token: 0x04001CEC RID: 7404
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CED RID: 7405
		private static int HandleId;
	}
}
