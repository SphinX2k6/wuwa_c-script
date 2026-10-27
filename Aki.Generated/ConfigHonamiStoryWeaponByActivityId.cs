using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200040C RID: 1036
	public class ConfigHonamiStoryWeaponByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600184F RID: 6223 RVA: 0x000E33DC File Offset: 0x000E15DC
		static ConfigHonamiStoryWeaponByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryWeaponByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryWeaponByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x000E33FC File Offset: 0x000E15FC
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

		// Token: 0x06001851 RID: 6225 RVA: 0x000E347B File Offset: 0x000E167B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryWeaponByActivityId.LogPair = null;
			ConfigHonamiStoryWeaponByActivityId.HandleId = 0;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000E3489 File Offset: 0x000E1689
		public static void Init()
		{
			ConfigHonamiStoryWeaponByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryWeaponByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryWeapon` where ActivityId=?");
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x000E34A4 File Offset: 0x000E16A4
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

		// Token: 0x04001C38 RID: 7224
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C39 RID: 7225
		private const string FILE = "s.穗波奇妙物语装备栏.xlsx";

		// Token: 0x04001C3A RID: 7226
		private const string TABLE = "HonamiStoryWeapon";

		// Token: 0x04001C3B RID: 7227
		private const string COMMAND = "select BinData from `HonamiStoryWeapon` where ActivityId=?";

		// Token: 0x04001C3C RID: 7228
		private const string KEY_PREFIX = "HonamiStoryWeaponByActivityId";

		// Token: 0x04001C3D RID: 7229
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C3E RID: 7230
		private static int HandleId;
	}
}
