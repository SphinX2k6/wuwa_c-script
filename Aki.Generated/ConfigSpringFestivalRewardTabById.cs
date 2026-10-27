using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000980 RID: 2432
	public class ConfigSpringFestivalRewardTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003914 RID: 14612 RVA: 0x0019C4B3 File Offset: 0x0019A6B3
		static ConfigSpringFestivalRewardTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalRewardTabById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalRewardTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0019C4D4 File Offset: 0x0019A6D4
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalRewardTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalRewardTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalRewardTab` where Id=?")
			});
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x0019C553 File Offset: 0x0019A753
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalRewardTabById.LogPair = null;
			ConfigSpringFestivalRewardTabById.HandleId = 0;
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0019C561 File Offset: 0x0019A761
		public static void Init()
		{
			ConfigSpringFestivalRewardTabById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalRewardTabById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalRewardTab` where Id=?");
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0019C57C File Offset: 0x0019A77C
		public static SpringFestivalRewardTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalRewardTabById.HandleId, ConfigSpringFestivalRewardTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalRewardTab?(SpringFestivalRewardTab.GetRootAsSpringFestivalRewardTab(configBuffer));
				}
			}
			ConfigSpringFestivalRewardTabById.LogPair.Clear();
			ConfigSpringFestivalRewardTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalRewardTabById.HandleId, 1, p0Id, ConfigSpringFestivalRewardTabById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalRewardTabById.HandleId, true, ConfigSpringFestivalRewardTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalRewardTabById.HandleId, ConfigSpringFestivalRewardTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalRewardTabById.HandleId, 0, ConfigSpringFestivalRewardTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalRewardTabById.HandleId, ConfigSpringFestivalRewardTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalRewardTab rootAsSpringFestivalRewardTab = SpringFestivalRewardTab.GetRootAsSpringFestivalRewardTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalRewardTabById.HandleId, ConfigSpringFestivalRewardTabById.LogPair);
			return new SpringFestivalRewardTab?(rootAsSpringFestivalRewardTab);
		}

		// Token: 0x04004266 RID: 16998
		private const string DB = "db_spring26.db";

		// Token: 0x04004267 RID: 16999
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004268 RID: 17000
		private const string TABLE = "SpringFestivalRewardTab";

		// Token: 0x04004269 RID: 17001
		private const string COMMAND = "select BinData from `SpringFestivalRewardTab` where Id=?";

		// Token: 0x0400426A RID: 17002
		private const string KEY_PREFIX = "SpringFestivalRewardTabById";

		// Token: 0x0400426B RID: 17003
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400426C RID: 17004
		private static int HandleId;
	}
}
