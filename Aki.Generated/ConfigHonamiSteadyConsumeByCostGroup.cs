using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D8 RID: 984
	public class ConfigHonamiSteadyConsumeByCostGroup : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001717 RID: 5911 RVA: 0x000DC108 File Offset: 0x000DA308
		static ConfigHonamiSteadyConsumeByCostGroup()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiSteadyConsumeByCostGroup.CreateStaticDefaultValue), new Action(ConfigHonamiSteadyConsumeByCostGroup.ResetStaticDefaultValue));
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000DC128 File Offset: 0x000DA328
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiSteadyConsumeByCostGroup.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiSteadyConsumeByCostGroup.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局内.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiSteadyConsume"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiSteadyConsume` where CostGroup = ?")
			});
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x000DC1A7 File Offset: 0x000DA3A7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiSteadyConsumeByCostGroup.LogPair = null;
			ConfigHonamiSteadyConsumeByCostGroup.HandleId = 0;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000DC1B5 File Offset: 0x000DA3B5
		public static void Init()
		{
			ConfigHonamiSteadyConsumeByCostGroup.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiSteadyConsumeByCostGroup.HandleId, "db_honamistory.db", "select BinData from `HonamiSteadyConsume` where CostGroup = ?");
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000DC1D0 File Offset: 0x000DA3D0
		[NullableContext(2)]
		public static IReadOnlyList<HonamiSteadyConsume> GetConfigList(int p0CostGroup, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiSteadyConsumeByCostGroup.HandleId, ConfigHonamiSteadyConsumeByCostGroup.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiSteadyConsumeByCostGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CostGroup);
				IReadOnlyList<HonamiSteadyConsume> readOnlyList = (IReadOnlyList<HonamiSteadyConsume>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiSteadyConsumeByCostGroup.LogPair.Clear();
			ConfigHonamiSteadyConsumeByCostGroup.LogPair.Add(new ValueTuple<string, object>("CostGroup", p0CostGroup));
			if (!ConfigCommon.BindInt(ConfigHonamiSteadyConsumeByCostGroup.HandleId, 1, p0CostGroup, ConfigHonamiSteadyConsumeByCostGroup.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiSteadyConsumeByCostGroup.HandleId, ConfigHonamiSteadyConsumeByCostGroup.LogPair);
				return null;
			}
			List<HonamiSteadyConsume> list = new List<HonamiSteadyConsume>();
			while (ConfigCommon.Step(ConfigHonamiSteadyConsumeByCostGroup.HandleId, false, ConfigHonamiSteadyConsumeByCostGroup.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiSteadyConsumeByCostGroup.HandleId, 0, ConfigHonamiSteadyConsumeByCostGroup.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiSteadyConsumeByCostGroup.HandleId, ConfigHonamiSteadyConsumeByCostGroup.LogPair);
					return null;
				}
				HonamiSteadyConsume rootAsHonamiSteadyConsume = HonamiSteadyConsume.GetRootAsHonamiSteadyConsume(new ByteBuffer(item2));
				list.Add(rootAsHonamiSteadyConsume);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiSteadyConsumeByCostGroup");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CostGroup);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiSteadyConsumeByCostGroup.HandleId, ConfigHonamiSteadyConsumeByCostGroup.LogPair);
			return list;
		}

		// Token: 0x04001ACC RID: 6860
		private const string DB = "db_honamistory.db";

		// Token: 0x04001ACD RID: 6861
		private const string FILE = "s.穗波奇妙物语局内.xlsx";

		// Token: 0x04001ACE RID: 6862
		private const string TABLE = "HonamiSteadyConsume";

		// Token: 0x04001ACF RID: 6863
		private const string COMMAND = "select BinData from `HonamiSteadyConsume` where CostGroup = ?";

		// Token: 0x04001AD0 RID: 6864
		private const string KEY_PREFIX = "HonamiSteadyConsumeByCostGroup";

		// Token: 0x04001AD1 RID: 6865
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AD2 RID: 6866
		private static int HandleId;
	}
}
