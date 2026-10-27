using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D4 RID: 1236
	public class ConfigLifePointChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D03 RID: 7427 RVA: 0x000FD1E0 File Offset: 0x000FB3E0
		static ConfigLifePointChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifePointChallengeById.CreateStaticDefaultValue), new Action(ConfigLifePointChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x000FD200 File Offset: 0x000FB400
		public static void CreateStaticDefaultValue()
		{
			ConfigLifePointChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLifePointChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lifepoint.db"),
				new ValueTuple<string, object>("文件", "y.溢彩画.xlsx"),
				new ValueTuple<string, object>("表名", "LifePointChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `LifePointChallenge` where Id=?")
			});
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x000FD27F File Offset: 0x000FB47F
		public static void ResetStaticDefaultValue()
		{
			ConfigLifePointChallengeById.LogPair = null;
			ConfigLifePointChallengeById.HandleId = 0;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x000FD28D File Offset: 0x000FB48D
		public static void Init()
		{
			ConfigLifePointChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigLifePointChallengeById.HandleId, "db_lifepoint.db", "select BinData from `LifePointChallenge` where Id=?");
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x000FD2A8 File Offset: 0x000FB4A8
		public static LifePointChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLifePointChallengeById.HandleId, ConfigLifePointChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LifePointChallenge?(LifePointChallenge.GetRootAsLifePointChallenge(configBuffer));
				}
			}
			ConfigLifePointChallengeById.LogPair.Clear();
			ConfigLifePointChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLifePointChallengeById.HandleId, 1, p0Id, ConfigLifePointChallengeById.LogPair) || ConfigCommon.Step(ConfigLifePointChallengeById.HandleId, true, ConfigLifePointChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLifePointChallengeById.HandleId, ConfigLifePointChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLifePointChallengeById.HandleId, 0, ConfigLifePointChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLifePointChallengeById.HandleId, ConfigLifePointChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LifePointChallenge rootAsLifePointChallenge = LifePointChallenge.GetRootAsLifePointChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLifePointChallengeById.HandleId, ConfigLifePointChallengeById.LogPair);
			return new LifePointChallenge?(rootAsLifePointChallenge);
		}

		// Token: 0x040021B0 RID: 8624
		private const string DB = "db_lifepoint.db";

		// Token: 0x040021B1 RID: 8625
		private const string FILE = "y.溢彩画.xlsx";

		// Token: 0x040021B2 RID: 8626
		private const string TABLE = "LifePointChallenge";

		// Token: 0x040021B3 RID: 8627
		private const string COMMAND = "select BinData from `LifePointChallenge` where Id=?";

		// Token: 0x040021B4 RID: 8628
		private const string KEY_PREFIX = "LifePointChallengeById";

		// Token: 0x040021B5 RID: 8629
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021B6 RID: 8630
		private static int HandleId;
	}
}
