using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000918 RID: 2328
	public class ConfigRoleTowerWaveAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036A3 RID: 13987 RVA: 0x00191620 File Offset: 0x0018F820
		static ConfigRoleTowerWaveAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerWaveAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerWaveAll.ResetStaticDefaultValue));
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00191640 File Offset: 0x0018F840
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerWaveAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerWaveAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerWave"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerWave`")
			});
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x001916BF File Offset: 0x0018F8BF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerWaveAll.LogPair = null;
			ConfigRoleTowerWaveAll.HandleId = 0;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x001916CD File Offset: 0x0018F8CD
		public static void Init()
		{
			ConfigRoleTowerWaveAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerWaveAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerWave`");
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x001916E8 File Offset: 0x0018F8E8
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerWave> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerWaveAll.HandleId, ConfigRoleTowerWaveAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerWave> readOnlyList = (IReadOnlyList<RoleTowerWave>)ConfigCommon.GetConfig("RoleTowerWaveAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerWave> list = new List<RoleTowerWave>();
			while (ConfigCommon.Step(ConfigRoleTowerWaveAll.HandleId, false, ConfigRoleTowerWaveAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerWaveAll.HandleId, 0, ConfigRoleTowerWaveAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerWaveAll.HandleId, ConfigRoleTowerWaveAll.LogPair);
					return null;
				}
				RoleTowerWave rootAsRoleTowerWave = RoleTowerWave.GetRootAsRoleTowerWave(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerWave);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerWaveAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerWaveAll.HandleId, ConfigRoleTowerWaveAll.LogPair);
			return list;
		}

		// Token: 0x04003F8E RID: 16270
		private const string DB = "db_roletower.db";

		// Token: 0x04003F8F RID: 16271
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003F90 RID: 16272
		private const string TABLE = "RoleTowerWave";

		// Token: 0x04003F91 RID: 16273
		private const string COMMAND = "select BinData from `RoleTowerWave`";

		// Token: 0x04003F92 RID: 16274
		private const string KEY_PREFIX = "RoleTowerWaveAll";

		// Token: 0x04003F93 RID: 16275
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F94 RID: 16276
		private static int HandleId;
	}
}
