using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000919 RID: 2329
	public class ConfigRoleTowerWaveByFloorId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036A9 RID: 13993 RVA: 0x001917B3 File Offset: 0x0018F9B3
		static ConfigRoleTowerWaveByFloorId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerWaveByFloorId.CreateStaticDefaultValue), new Action(ConfigRoleTowerWaveByFloorId.ResetStaticDefaultValue));
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x001917D4 File Offset: 0x0018F9D4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerWaveByFloorId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerWaveByFloorId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerWave"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerWave` where FloorId=?")
			});
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00191853 File Offset: 0x0018FA53
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerWaveByFloorId.LogPair = null;
			ConfigRoleTowerWaveByFloorId.HandleId = 0;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x00191861 File Offset: 0x0018FA61
		public static void Init()
		{
			ConfigRoleTowerWaveByFloorId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerWaveByFloorId.HandleId, "db_roletower.db", "select BinData from `RoleTowerWave` where FloorId=?");
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x0019187C File Offset: 0x0018FA7C
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerWave> GetConfigList(int p0FloorId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerWaveByFloorId.HandleId, ConfigRoleTowerWaveByFloorId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerWaveByFloorId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FloorId);
				IReadOnlyList<RoleTowerWave> readOnlyList = (IReadOnlyList<RoleTowerWave>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerWaveByFloorId.LogPair.Clear();
			ConfigRoleTowerWaveByFloorId.LogPair.Add(new ValueTuple<string, object>("FloorId", p0FloorId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerWaveByFloorId.HandleId, 1, p0FloorId, ConfigRoleTowerWaveByFloorId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerWaveByFloorId.HandleId, ConfigRoleTowerWaveByFloorId.LogPair);
				return null;
			}
			List<RoleTowerWave> list = new List<RoleTowerWave>();
			while (ConfigCommon.Step(ConfigRoleTowerWaveByFloorId.HandleId, false, ConfigRoleTowerWaveByFloorId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerWaveByFloorId.HandleId, 0, ConfigRoleTowerWaveByFloorId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerWaveByFloorId.HandleId, ConfigRoleTowerWaveByFloorId.LogPair);
					return null;
				}
				RoleTowerWave rootAsRoleTowerWave = RoleTowerWave.GetRootAsRoleTowerWave(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerWave);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerWaveByFloorId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FloorId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerWaveByFloorId.HandleId, ConfigRoleTowerWaveByFloorId.LogPair);
			return list;
		}

		// Token: 0x04003F95 RID: 16277
		private const string DB = "db_roletower.db";

		// Token: 0x04003F96 RID: 16278
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003F97 RID: 16279
		private const string TABLE = "RoleTowerWave";

		// Token: 0x04003F98 RID: 16280
		private const string COMMAND = "select BinData from `RoleTowerWave` where FloorId=?";

		// Token: 0x04003F99 RID: 16281
		private const string KEY_PREFIX = "RoleTowerWaveByFloorId";

		// Token: 0x04003F9A RID: 16282
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F9B RID: 16283
		private static int HandleId;
	}
}
