using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F7 RID: 759
	public class ConfigFlagChallengeAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011CF RID: 4559 RVA: 0x000BE263 File Offset: 0x000BC463
		static ConfigFlagChallengeAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeAreaById.CreateStaticDefaultValue), new Action(ConfigFlagChallengeAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000BE284 File Offset: 0x000BC484
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

		// Token: 0x060011D1 RID: 4561 RVA: 0x000BE303 File Offset: 0x000BC503
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeAreaById.LogPair = null;
			ConfigFlagChallengeAreaById.HandleId = 0;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x000BE311 File Offset: 0x000BC511
		public static void Init()
		{
			ConfigFlagChallengeAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeAreaById.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeArea` where Id=?");
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x000BE32C File Offset: 0x000BC52C
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

		// Token: 0x040014A5 RID: 5285
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014A6 RID: 5286
		private const string FILE = "c.插旗活动局外.xlsx";

		// Token: 0x040014A7 RID: 5287
		private const string TABLE = "FlagChallengeArea";

		// Token: 0x040014A8 RID: 5288
		private const string COMMAND = "select BinData from `FlagChallengeArea` where Id=?";

		// Token: 0x040014A9 RID: 5289
		private const string KEY_PREFIX = "FlagChallengeAreaById";

		// Token: 0x040014AA RID: 5290
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014AB RID: 5291
		private static int HandleId;
	}
}
