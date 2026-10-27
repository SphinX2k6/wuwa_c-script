using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000051 RID: 81
	public class ConfigActivitySignGrandRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x00064758 File Offset: 0x00062958
		static ConfigActivitySignGrandRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivitySignGrandRewardById.CreateStaticDefaultValue), new Action(ConfigActivitySignGrandRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00064778 File Offset: 0x00062978
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

		// Token: 0x060001E8 RID: 488 RVA: 0x000647F7 File Offset: 0x000629F7
		public static void ResetStaticDefaultValue()
		{
			ConfigActivitySignGrandRewardById.LogPair = null;
			ConfigActivitySignGrandRewardById.HandleId = 0;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00064805 File Offset: 0x00062A05
		public static void Init()
		{
			ConfigActivitySignGrandRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigActivitySignGrandRewardById.HandleId, "db_sevendaysign.db", "select BinData from `ActivitySignGrandReward` where Id=?");
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00064820 File Offset: 0x00062A20
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

		// Token: 0x0400021B RID: 539
		private const string DB = "db_sevendaysign.db";

		// Token: 0x0400021C RID: 540
		private const string FILE = "q.七天签到.xlsx";

		// Token: 0x0400021D RID: 541
		private const string TABLE = "ActivitySignGrandReward";

		// Token: 0x0400021E RID: 542
		private const string COMMAND = "select BinData from `ActivitySignGrandReward` where Id=?";

		// Token: 0x0400021F RID: 543
		private const string KEY_PREFIX = "ActivitySignGrandRewardById";

		// Token: 0x04000220 RID: 544
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000221 RID: 545
		private static int HandleId;
	}
}
