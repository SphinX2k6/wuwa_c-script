using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030C RID: 780
	public class ConfigFlagChallengeAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600124D RID: 4685 RVA: 0x000C476F File Offset: 0x000C296F
		static ConfigFlagChallengeAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeAreaById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x000C4790 File Offset: 0x000C2990
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局外.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeArea"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeArea` where Id=?")
			});
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x000C480F File Offset: 0x000C2A0F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeAreaById.LogPair = null;
			ConfigFlagChallengeAreaById.HandleId = 0;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x000C481D File Offset: 0x000C2A1D
		public static void Init()
		{
			ConfigFlagChallengeAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeAreaById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeArea` where Id=?");
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x000C4838 File Offset: 0x000C2A38
		public static FlagChallengeArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeAreaById.HandleId, ConfigFlagChallengeAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagChallengeArea?(FlagChallengeArea.GetRootAsFlagChallengeArea(configBuffer));
				}
			}
			ConfigFlagChallengeAreaById.LogPair.Clear();
			ConfigFlagChallengeAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeAreaById.HandleId, 1, p0Id, ConfigFlagChallengeAreaById.LogPair) || ConfigCommon.Step(ConfigFlagChallengeAreaById.HandleId, true, ConfigFlagChallengeAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagChallengeAreaById.HandleId, ConfigFlagChallengeAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeAreaById.HandleId, 0, ConfigFlagChallengeAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagChallengeAreaById.HandleId, ConfigFlagChallengeAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagChallengeArea rootAsFlagChallengeArea = FlagChallengeArea.GetRootAsFlagChallengeArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagChallengeAreaById.HandleId, ConfigFlagChallengeAreaById.LogPair);
			return new FlagChallengeArea?(rootAsFlagChallengeArea);
		}

		// Token: 0x04001538 RID: 5432
		private const string DB = "db_flagchallenge.db";

		// Token: 0x04001539 RID: 5433
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x0400153A RID: 5434
		private const string TABLE = "FlagChallengeArea";

		// Token: 0x0400153B RID: 5435
		private const string COMMAND = "select BinData from `FlagChallengeArea` where Id=?";

		// Token: 0x0400153C RID: 5436
		private const string KEY_PREFIX = "FlagChallengeAreaById";

		// Token: 0x0400153D RID: 5437
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400153E RID: 5438
		private static int HandleId;
	}
}
