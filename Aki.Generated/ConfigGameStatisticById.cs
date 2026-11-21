using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000396 RID: 918
	public class ConfigGameStatisticById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x000D6FAC File Offset: 0x000D51AC
		static ConfigGameStatisticById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGameStatisticById.CreateStaticDefaultValue), new Action(ConfigGameStatisticById.ResetStaticDefaultValue));
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x000D6FCC File Offset: 0x000D51CC
		public static void CreateStaticDefaultValue()
		{
			ConfigGameStatisticById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGameStatisticById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "GameStatistic"),
				new ValueTuple<string, object>("语句", "select BinData from `GameStatistic` where Id=?")
			});
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x000D704B File Offset: 0x000D524B
		public static void ResetStaticDefaultValue()
		{
			ConfigGameStatisticById.LogPair = null;
			ConfigGameStatisticById.HandleId = 0;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x000D7059 File Offset: 0x000D5259
		public static void Init()
		{
			ConfigGameStatisticById.HandleId = ConfigCommon.InitDataStatement(ConfigGameStatisticById.HandleId, "db_platformchannel.db", "select BinData from `GameStatistic` where Id=?");
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000D7074 File Offset: 0x000D5274
		public static GameStatistic? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGameStatisticById.HandleId, ConfigGameStatisticById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GameStatisticById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GameStatistic?(GameStatistic.GetRootAsGameStatistic(configBuffer));
				}
			}
			ConfigGameStatisticById.LogPair.Clear();
			ConfigGameStatisticById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGameStatisticById.HandleId, 1, p0Id, ConfigGameStatisticById.LogPair) || ConfigCommon.Step(ConfigGameStatisticById.HandleId, true, ConfigGameStatisticById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGameStatisticById.HandleId, ConfigGameStatisticById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGameStatisticById.HandleId, 0, ConfigGameStatisticById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGameStatisticById.HandleId, ConfigGameStatisticById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GameStatistic rootAsGameStatistic = GameStatistic.GetRootAsGameStatistic(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GameStatisticById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGameStatisticById.HandleId, ConfigGameStatisticById.LogPair);
			return new GameStatistic?(rootAsGameStatistic);
		}

		// Token: 0x040018FE RID: 6398
		private const string DB = "db_platformchannel.db";

		// Token: 0x040018FF RID: 6399
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04001900 RID: 6400
		private const string TABLE = "GameStatistic";

		// Token: 0x04001901 RID: 6401
		private const string COMMAND = "select BinData from `GameStatistic` where Id=?";

		// Token: 0x04001902 RID: 6402
		private const string KEY_PREFIX = "GameStatisticById";

		// Token: 0x04001903 RID: 6403
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001904 RID: 6404
		private static int HandleId;
	}
}
