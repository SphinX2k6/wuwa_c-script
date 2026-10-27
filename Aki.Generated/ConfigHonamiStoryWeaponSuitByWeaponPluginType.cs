using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040F RID: 1039
	public class ConfigHonamiStoryWeaponSuitByWeaponPluginType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001861 RID: 6241 RVA: 0x000E3AA4 File Offset: 0x000E1CA4
		static ConfigHonamiStoryWeaponSuitByWeaponPluginType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryWeaponSuitByWeaponPluginType.CreateStaticDefaultValue), new Action(ConfigHonamiStoryWeaponSuitByWeaponPluginType.ResetStaticDefaultValue));
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000E3AC4 File Offset: 0x000E1CC4
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

		// Token: 0x06001863 RID: 6243 RVA: 0x000E3B43 File Offset: 0x000E1D43
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.LogPair = null;
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId = 0;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x000E3B51 File Offset: 0x000E1D51
		public static void Init()
		{
			ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryWeaponSuitByWeaponPluginType.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryWeaponSuit` where WeaponPluginType=?");
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000E3B6C File Offset: 0x000E1D6C
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

		// Token: 0x04001C4D RID: 7245
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C4E RID: 7246
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001C4F RID: 7247
		private const string TABLE = "HonamiStoryWeaponSuit";

		// Token: 0x04001C50 RID: 7248
		private const string COMMAND = "select BinData from `HonamiStoryWeaponSuit` where WeaponPluginType=?";

		// Token: 0x04001C51 RID: 7249
		private const string KEY_PREFIX = "HonamiStoryWeaponSuitByWeaponPluginType";

		// Token: 0x04001C52 RID: 7250
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C53 RID: 7251
		private static int HandleId;
	}
}
