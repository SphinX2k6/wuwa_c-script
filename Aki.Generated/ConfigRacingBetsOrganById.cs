using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C0 RID: 1984
	public class ConfigRacingBetsOrganById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E92 RID: 11922 RVA: 0x00163FB7 File Offset: 0x001621B7
		static ConfigRacingBetsOrganById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsOrganById.CreateStaticDefaultValue), new Action(ConfigRacingBetsOrganById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00163FD8 File Offset: 0x001621D8
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsOrganById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsOrganById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsOrgan"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsOrgan` where Id=?")
			});
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00164057 File Offset: 0x00162257
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsOrganById.LogPair = null;
			ConfigRacingBetsOrganById.HandleId = 0;
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00164065 File Offset: 0x00162265
		public static void Init()
		{
			ConfigRacingBetsOrganById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsOrganById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsOrgan` where Id=?");
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00164080 File Offset: 0x00162280
		public static RacingBetsOrgan? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsOrganById.HandleId, ConfigRacingBetsOrganById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsOrganById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsOrgan?(RacingBetsOrgan.GetRootAsRacingBetsOrgan(configBuffer));
				}
			}
			ConfigRacingBetsOrganById.LogPair.Clear();
			ConfigRacingBetsOrganById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsOrganById.HandleId, 1, p0Id, ConfigRacingBetsOrganById.LogPair) || ConfigCommon.Step(ConfigRacingBetsOrganById.HandleId, true, ConfigRacingBetsOrganById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsOrganById.HandleId, ConfigRacingBetsOrganById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsOrganById.HandleId, 0, ConfigRacingBetsOrganById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsOrganById.HandleId, ConfigRacingBetsOrganById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsOrgan rootAsRacingBetsOrgan = RacingBetsOrgan.GetRootAsRacingBetsOrgan(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsOrganById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsOrganById.HandleId, ConfigRacingBetsOrganById.LogPair);
			return new RacingBetsOrgan?(rootAsRacingBetsOrgan);
		}

		// Token: 0x04003626 RID: 13862
		private const string DB = "db_racingbets.db";

		// Token: 0x04003627 RID: 13863
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003628 RID: 13864
		private const string TABLE = "RacingBetsOrgan";

		// Token: 0x04003629 RID: 13865
		private const string COMMAND = "select BinData from `RacingBetsOrgan` where Id=?";

		// Token: 0x0400362A RID: 13866
		private const string KEY_PREFIX = "RacingBetsOrganById";

		// Token: 0x0400362B RID: 13867
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400362C RID: 13868
		private static int HandleId;
	}
}
