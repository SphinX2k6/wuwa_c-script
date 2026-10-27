using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029C RID: 668
	public class ConfigExploreRewardDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FAD RID: 4013 RVA: 0x000B226C File Offset: 0x000B046C
		static ConfigExploreRewardDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRewardDisplayById.CreateStaticDefaultValue), new Action(ConfigExploreRewardDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000B228C File Offset: 0x000B048C
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreRewardDisplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreRewardDisplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rewardui.db"),
				new ValueTuple<string, object>("文件", "j.奖励界面表现.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreRewardDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreRewardDisplay` where Id=?")
			});
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000B230B File Offset: 0x000B050B
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRewardDisplayById.LogPair = null;
			ConfigExploreRewardDisplayById.HandleId = 0;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000B2319 File Offset: 0x000B0519
		public static void Init()
		{
			ConfigExploreRewardDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRewardDisplayById.HandleId, "db_rewardui.db", "select BinData from `ExploreRewardDisplay` where Id=?");
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000B2334 File Offset: 0x000B0534
		public static ExploreRewardDisplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreRewardDisplayById.HandleId, ConfigExploreRewardDisplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRewardDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreRewardDisplay?(ExploreRewardDisplay.GetRootAsExploreRewardDisplay(configBuffer));
				}
			}
			ConfigExploreRewardDisplayById.LogPair.Clear();
			ConfigExploreRewardDisplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExploreRewardDisplayById.HandleId, 1, p0Id, ConfigExploreRewardDisplayById.LogPair) || ConfigCommon.Step(ConfigExploreRewardDisplayById.HandleId, true, ConfigExploreRewardDisplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreRewardDisplayById.HandleId, ConfigExploreRewardDisplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreRewardDisplayById.HandleId, 0, ConfigExploreRewardDisplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreRewardDisplayById.HandleId, ConfigExploreRewardDisplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreRewardDisplay rootAsExploreRewardDisplay = ExploreRewardDisplay.GetRootAsExploreRewardDisplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRewardDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreRewardDisplayById.HandleId, ConfigExploreRewardDisplayById.LogPair);
			return new ExploreRewardDisplay?(rootAsExploreRewardDisplay);
		}

		// Token: 0x04001228 RID: 4648
		private const string DB = "db_rewardui.db";

		// Token: 0x04001229 RID: 4649
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x0400122A RID: 4650
		private const string TABLE = "ExploreRewardDisplay";

		// Token: 0x0400122B RID: 4651
		private const string COMMAND = "select BinData from `ExploreRewardDisplay` where Id=?";

		// Token: 0x0400122C RID: 4652
		private const string KEY_PREFIX = "ExploreRewardDisplayById";

		// Token: 0x0400122D RID: 4653
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400122E RID: 4654
		private static int HandleId;
	}
}
