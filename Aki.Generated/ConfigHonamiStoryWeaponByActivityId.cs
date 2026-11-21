using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000422 RID: 1058
	public class ConfigHonamiStoryWeaponByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018D3 RID: 6355 RVA: 0x000E9B30 File Offset: 0x000E7D30
		static ConfigHonamiStoryWeaponByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryWeaponByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryWeaponByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x000E9B50 File Offset: 0x000E7D50
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryWeaponByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语装备栏.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryWeapon"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryWeapon` where ActivityId=?")
			});
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x000E9BCF File Offset: 0x000E7DCF
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponByActivityId.LogPair = null;
			ConfigHonamiStoryWeaponByActivityId.HandleId = 0;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x000E9BDD File Offset: 0x000E7DDD
		public static void Init()
		{
			ConfigHonamiStoryWeaponByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryWeaponByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryWeapon` where ActivityId=?");
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x000E9BF8 File Offset: 0x000E7DF8
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryWeapon> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryWeaponByActivityId.HandleId, ConfigHonamiStoryWeaponByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryWeaponByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryWeapon> readOnlyList = (IReadOnlyList<HonamiStoryWeapon>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryWeaponByActivityId.LogPair.Clear();
			ConfigHonamiStoryWeaponByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryWeaponByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryWeaponByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryWeaponByActivityId.HandleId, ConfigHonamiStoryWeaponByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryWeapon> list = new List<HonamiStoryWeapon>();
			while (ConfigCommon.Step(ConfigHonamiStoryWeaponByActivityId.HandleId, false, ConfigHonamiStoryWeaponByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryWeaponByActivityId.HandleId, 0, ConfigHonamiStoryWeaponByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryWeaponByActivityId.HandleId, ConfigHonamiStoryWeaponByActivityId.LogPair);
					return null;
				}
				HonamiStoryWeapon rootAsHonamiStoryWeapon = HonamiStoryWeapon.GetRootAsHonamiStoryWeapon(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryWeapon);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryWeaponByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryWeaponByActivityId.HandleId, ConfigHonamiStoryWeaponByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001CD2 RID: 7378
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CD3 RID: 7379
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001CD4 RID: 7380
		private const string TABLE = "HonamiStoryWeapon";

		// Token: 0x04001CD5 RID: 7381
		private const string COMMAND = "select BinData from `HonamiStoryWeapon` where ActivityId=?";

		// Token: 0x04001CD6 RID: 7382
		private const string KEY_PREFIX = "HonamiStoryWeaponByActivityId";

		// Token: 0x04001CD7 RID: 7383
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CD8 RID: 7384
		private static int HandleId;
	}
}
