using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091A RID: 2330
	public class ConfigRoleTowerWaveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036AF RID: 13999 RVA: 0x001919EB File Offset: 0x0018FBEB
		static ConfigRoleTowerWaveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerWaveById.CreateStaticDefaultValue), new Action(ConfigRoleTowerWaveById.ResetStaticDefaultValue));
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x00191A0C File Offset: 0x0018FC0C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerWaveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerWaveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerWave"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerWave` where Id=?")
			});
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x00191A8B File Offset: 0x0018FC8B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerWaveById.LogPair = null;
			ConfigRoleTowerWaveById.HandleId = 0;
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x00191A99 File Offset: 0x0018FC99
		public static void Init()
		{
			ConfigRoleTowerWaveById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerWaveById.HandleId, "db_roletower.db", "select BinData from `RoleTowerWave` where Id=?");
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x00191AB4 File Offset: 0x0018FCB4
		public static RoleTowerWave? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerWaveById.HandleId, ConfigRoleTowerWaveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerWaveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerWave?(RoleTowerWave.GetRootAsRoleTowerWave(configBuffer));
				}
			}
			ConfigRoleTowerWaveById.LogPair.Clear();
			ConfigRoleTowerWaveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerWaveById.HandleId, 1, p0Id, ConfigRoleTowerWaveById.LogPair) || ConfigCommon.Step(ConfigRoleTowerWaveById.HandleId, true, ConfigRoleTowerWaveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerWaveById.HandleId, ConfigRoleTowerWaveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerWaveById.HandleId, 0, ConfigRoleTowerWaveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerWaveById.HandleId, ConfigRoleTowerWaveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerWave rootAsRoleTowerWave = RoleTowerWave.GetRootAsRoleTowerWave(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerWaveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerWaveById.HandleId, ConfigRoleTowerWaveById.LogPair);
			return new RoleTowerWave?(rootAsRoleTowerWave);
		}

		// Token: 0x04003F9C RID: 16284
		private const string DB = "db_roletower.db";

		// Token: 0x04003F9D RID: 16285
		private const string FILE = "j.角色爬塔_关卡.xlsx";

		// Token: 0x04003F9E RID: 16286
		private const string TABLE = "RoleTowerWave";

		// Token: 0x04003F9F RID: 16287
		private const string COMMAND = "select BinData from `RoleTowerWave` where Id=?";

		// Token: 0x04003FA0 RID: 16288
		private const string KEY_PREFIX = "RoleTowerWaveById";

		// Token: 0x04003FA1 RID: 16289
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FA2 RID: 16290
		private static int HandleId;
	}
}
