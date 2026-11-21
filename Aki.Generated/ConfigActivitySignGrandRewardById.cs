using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000059 RID: 89
	public class ConfigActivitySignGrandRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000216 RID: 534 RVA: 0x0006900C File Offset: 0x0006720C
		static ConfigActivitySignGrandRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivitySignGrandRewardById.CreateStaticDefaultValue), new Action(ConfigActivitySignGrandRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0006902C File Offset: 0x0006722C
		public static void CreateStaticDefaultValue()
		{
			ConfigActivitySignGrandRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivitySignGrandRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sevendaysign.db"),
				new ValueTuple<string, object>("文件", "q.七天签到.xlsx"),
				new ValueTuple<string, object>("表名", "ActivitySignGrandReward"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivitySignGrandReward` where Id=?")
			});
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000690AB File Offset: 0x000672AB
		public static void ResetStaticDefaultValue()
		{
			ConfigActivitySignGrandRewardById.LogPair = null;
			ConfigActivitySignGrandRewardById.HandleId = 0;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000690B9 File Offset: 0x000672B9
		public static void Init()
		{
			ConfigActivitySignGrandRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigActivitySignGrandRewardById.HandleId, "db_sevendaysign.db", "select BinData from `ActivitySignGrandReward` where Id=?");
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000690D4 File Offset: 0x000672D4
		public static ActivitySignGrandReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivitySignGrandRewardById.HandleId, ConfigActivitySignGrandRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivitySignGrandRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivitySignGrandReward?(ActivitySignGrandReward.GetRootAsActivitySignGrandReward(configBuffer));
				}
			}
			ConfigActivitySignGrandRewardById.LogPair.Clear();
			ConfigActivitySignGrandRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivitySignGrandRewardById.HandleId, 1, p0Id, ConfigActivitySignGrandRewardById.LogPair) || ConfigCommon.Step(ConfigActivitySignGrandRewardById.HandleId, true, ConfigActivitySignGrandRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivitySignGrandRewardById.HandleId, ConfigActivitySignGrandRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivitySignGrandRewardById.HandleId, 0, ConfigActivitySignGrandRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivitySignGrandRewardById.HandleId, ConfigActivitySignGrandRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivitySignGrandReward rootAsActivitySignGrandReward = ActivitySignGrandReward.GetRootAsActivitySignGrandReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivitySignGrandRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivitySignGrandRewardById.HandleId, ConfigActivitySignGrandRewardById.LogPair);
			return new ActivitySignGrandReward?(rootAsActivitySignGrandReward);
		}

		// Token: 0x04000253 RID: 595
		private const string DB = "db_sevendaysign.db";

		// Token: 0x04000254 RID: 596
		private const string FILE = "q.七天签到.xlsx";

		// Token: 0x04000255 RID: 597
		private const string TABLE = "ActivitySignGrandReward";

		// Token: 0x04000256 RID: 598
		private const string COMMAND = "select BinData from `ActivitySignGrandReward` where Id=?";

		// Token: 0x04000257 RID: 599
		private const string KEY_PREFIX = "ActivitySignGrandRewardById";

		// Token: 0x04000258 RID: 600
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000259 RID: 601
		private static int HandleId;
	}
}
