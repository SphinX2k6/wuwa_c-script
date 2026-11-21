using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000575 RID: 1397
	public class ConfigMoonPhaseRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020CB RID: 8395 RVA: 0x00116538 File Offset: 0x00114738
		static ConfigMoonPhaseRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoonPhaseRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigMoonPhaseRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00116558 File Offset: 0x00114758
		public static void CreateStaticDefaultValue()
		{
			ConfigMoonPhaseRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoonPhaseRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonsignin.db"),
				new ValueTuple<string, object>("文件", "y.月相活动.xlsx"),
				new ValueTuple<string, object>("表名", "MoonPhaseReward"),
				new ValueTuple<string, object>("语句", "select BinData from `MoonPhaseReward` where ActivityId=?")
			});
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x001165D7 File Offset: 0x001147D7
		public static void ResetStaticDefaultValue()
		{
			ConfigMoonPhaseRewardByActivityId.LogPair = null;
			ConfigMoonPhaseRewardByActivityId.HandleId = 0;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x001165E5 File Offset: 0x001147E5
		public static void Init()
		{
			ConfigMoonPhaseRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMoonPhaseRewardByActivityId.HandleId, "db_moonsignin.db", "select BinData from `MoonPhaseReward` where ActivityId=?");
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00116600 File Offset: 0x00114800
		public static MoonPhaseReward? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoonPhaseRewardByActivityId.HandleId, ConfigMoonPhaseRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonPhaseRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoonPhaseReward?(MoonPhaseReward.GetRootAsMoonPhaseReward(configBuffer));
				}
			}
			ConfigMoonPhaseRewardByActivityId.LogPair.Clear();
			ConfigMoonPhaseRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMoonPhaseRewardByActivityId.HandleId, 1, p0ActivityId, ConfigMoonPhaseRewardByActivityId.LogPair) || ConfigCommon.Step(ConfigMoonPhaseRewardByActivityId.HandleId, true, ConfigMoonPhaseRewardByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoonPhaseRewardByActivityId.HandleId, ConfigMoonPhaseRewardByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoonPhaseRewardByActivityId.HandleId, 0, ConfigMoonPhaseRewardByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoonPhaseRewardByActivityId.HandleId, ConfigMoonPhaseRewardByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoonPhaseReward rootAsMoonPhaseReward = MoonPhaseReward.GetRootAsMoonPhaseReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonPhaseRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoonPhaseRewardByActivityId.HandleId, ConfigMoonPhaseRewardByActivityId.LogPair);
			return new MoonPhaseReward?(rootAsMoonPhaseReward);
		}

		// Token: 0x04002617 RID: 9751
		private const string DB = "db_moonsignin.db";

		// Token: 0x04002618 RID: 9752
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002619 RID: 9753
		private const string TABLE = "MoonPhaseReward";

		// Token: 0x0400261A RID: 9754
		private const string COMMAND = "select BinData from `MoonPhaseReward` where ActivityId=?";

		// Token: 0x0400261B RID: 9755
		private const string KEY_PREFIX = "MoonPhaseRewardByActivityId";

		// Token: 0x0400261C RID: 9756
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400261D RID: 9757
		private static int HandleId;
	}
}
