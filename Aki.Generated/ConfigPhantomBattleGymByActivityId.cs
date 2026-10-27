using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000679 RID: 1657
	public class ConfigPhantomBattleGymByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026E6 RID: 9958 RVA: 0x00135ABC File Offset: 0x00133CBC
		static ConfigPhantomBattleGymByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleGymByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleGymByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00135ADC File Offset: 0x00133CDC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleGymByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleGymByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleGym"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleGym` where ActivityId=?")
			});
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00135B5B File Offset: 0x00133D5B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleGymByActivityId.LogPair = null;
			ConfigPhantomBattleGymByActivityId.HandleId = 0;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00135B69 File Offset: 0x00133D69
		public static void Init()
		{
			ConfigPhantomBattleGymByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleGymByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleGym` where ActivityId=?");
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00135B84 File Offset: 0x00133D84
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleGym> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleGymByActivityId.HandleId, ConfigPhantomBattleGymByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleGymByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleGym> readOnlyList = (IReadOnlyList<PhantomBattleGym>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleGymByActivityId.LogPair.Clear();
			ConfigPhantomBattleGymByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleGymByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleGymByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleGymByActivityId.HandleId, ConfigPhantomBattleGymByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleGym> list = new List<PhantomBattleGym>();
			while (ConfigCommon.Step(ConfigPhantomBattleGymByActivityId.HandleId, false, ConfigPhantomBattleGymByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleGymByActivityId.HandleId, 0, ConfigPhantomBattleGymByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleGymByActivityId.HandleId, ConfigPhantomBattleGymByActivityId.LogPair);
					return null;
				}
				PhantomBattleGym rootAsPhantomBattleGym = PhantomBattleGym.GetRootAsPhantomBattleGym(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleGym);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleGymByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleGymByActivityId.HandleId, ConfigPhantomBattleGymByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002D35 RID: 11573
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D36 RID: 11574
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D37 RID: 11575
		private const string TABLE = "PhantomBattleGym";

		// Token: 0x04002D38 RID: 11576
		private const string COMMAND = "select BinData from `PhantomBattleGym` where ActivityId=?";

		// Token: 0x04002D39 RID: 11577
		private const string KEY_PREFIX = "PhantomBattleGymByActivityId";

		// Token: 0x04002D3A RID: 11578
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D3B RID: 11579
		private static int HandleId;
	}
}
