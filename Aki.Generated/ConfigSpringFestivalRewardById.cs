using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097E RID: 2430
	public class ConfigSpringFestivalRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003908 RID: 14600 RVA: 0x0019C033 File Offset: 0x0019A233
		static ConfigSpringFestivalRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalRewardById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x0019C054 File Offset: 0x0019A254
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalReward` where Id=?")
			});
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x0019C0D3 File Offset: 0x0019A2D3
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalRewardById.LogPair = null;
			ConfigSpringFestivalRewardById.HandleId = 0;
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0019C0E1 File Offset: 0x0019A2E1
		public static void Init()
		{
			ConfigSpringFestivalRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalRewardById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalReward` where Id=?");
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x0019C0FC File Offset: 0x0019A2FC
		public static SpringFestivalReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalRewardById.HandleId, ConfigSpringFestivalRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalReward?(SpringFestivalReward.GetRootAsSpringFestivalReward(configBuffer));
				}
			}
			ConfigSpringFestivalRewardById.LogPair.Clear();
			ConfigSpringFestivalRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalRewardById.HandleId, 1, p0Id, ConfigSpringFestivalRewardById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalRewardById.HandleId, true, ConfigSpringFestivalRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalRewardById.HandleId, ConfigSpringFestivalRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalRewardById.HandleId, 0, ConfigSpringFestivalRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalRewardById.HandleId, ConfigSpringFestivalRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalReward rootAsSpringFestivalReward = SpringFestivalReward.GetRootAsSpringFestivalReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalRewardById.HandleId, ConfigSpringFestivalRewardById.LogPair);
			return new SpringFestivalReward?(rootAsSpringFestivalReward);
		}

		// Token: 0x04004258 RID: 16984
		private const string DB = "db_spring26.db";

		// Token: 0x04004259 RID: 16985
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400425A RID: 16986
		private const string TABLE = "SpringFestivalReward";

		// Token: 0x0400425B RID: 16987
		private const string COMMAND = "select BinData from `SpringFestivalReward` where Id=?";

		// Token: 0x0400425C RID: 16988
		private const string KEY_PREFIX = "SpringFestivalRewardById";

		// Token: 0x0400425D RID: 16989
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400425E RID: 16990
		private static int HandleId;
	}
}
