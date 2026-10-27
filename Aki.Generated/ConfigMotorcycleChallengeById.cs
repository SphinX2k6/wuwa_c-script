using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000577 RID: 1399
	public class ConfigMotorcycleChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020D7 RID: 8407 RVA: 0x001130DB File Offset: 0x001112DB
		static ConfigMotorcycleChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorcycleChallengeById.CreateStaticDefaultValue), new Action(ConfigMotorcycleChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x001130FC File Offset: 0x001112FC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorcycleChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorcycleChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "MotorcycleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorcycleChallenge` where Id=?")
			});
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x0011317B File Offset: 0x0011137B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorcycleChallengeById.LogPair = null;
			ConfigMotorcycleChallengeById.HandleId = 0;
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00113189 File Offset: 0x00111389
		public static void Init()
		{
			ConfigMotorcycleChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorcycleChallengeById.HandleId, "db_roadbook.db", "select BinData from `MotorcycleChallenge` where Id=?");
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x001131A4 File Offset: 0x001113A4
		public static MotorcycleChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorcycleChallengeById.HandleId, ConfigMotorcycleChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorcycleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorcycleChallenge?(MotorcycleChallenge.GetRootAsMotorcycleChallenge(configBuffer));
				}
			}
			ConfigMotorcycleChallengeById.LogPair.Clear();
			ConfigMotorcycleChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorcycleChallengeById.HandleId, 1, p0Id, ConfigMotorcycleChallengeById.LogPair) || ConfigCommon.Step(ConfigMotorcycleChallengeById.HandleId, true, ConfigMotorcycleChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorcycleChallengeById.HandleId, ConfigMotorcycleChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorcycleChallengeById.HandleId, 0, ConfigMotorcycleChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorcycleChallengeById.HandleId, ConfigMotorcycleChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorcycleChallenge rootAsMotorcycleChallenge = MotorcycleChallenge.GetRootAsMotorcycleChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorcycleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorcycleChallengeById.HandleId, ConfigMotorcycleChallengeById.LogPair);
			return new MotorcycleChallenge?(rootAsMotorcycleChallenge);
		}

		// Token: 0x04002625 RID: 9765
		private const string DB = "db_roadbook.db";

		// Token: 0x04002626 RID: 9766
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04002627 RID: 9767
		private const string TABLE = "MotorcycleChallenge";

		// Token: 0x04002628 RID: 9768
		private const string COMMAND = "select BinData from `MotorcycleChallenge` where Id=?";

		// Token: 0x04002629 RID: 9769
		private const string KEY_PREFIX = "MotorcycleChallengeById";

		// Token: 0x0400262A RID: 9770
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400262B RID: 9771
		private static int HandleId;
	}
}
