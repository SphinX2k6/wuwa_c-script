using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B0 RID: 688
	public class ConfigExploreRewardDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x000B8530 File Offset: 0x000B6730
		static ConfigExploreRewardDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRewardDisplayById.CreateStaticDefaultValue), new Action(ConfigExploreRewardDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000B8550 File Offset: 0x000B6750
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

		// Token: 0x06001027 RID: 4135 RVA: 0x000B85CF File Offset: 0x000B67CF
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRewardDisplayById.LogPair = null;
			ConfigExploreRewardDisplayById.HandleId = 0;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000B85DD File Offset: 0x000B67DD
		public static void Init()
		{
			ConfigExploreRewardDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRewardDisplayById.HandleId, "db_rewardui.db", "select BinData from `ExploreRewardDisplay` where Id=?");
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000B85F8 File Offset: 0x000B67F8
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

		// Token: 0x040012B4 RID: 4788
		private const string DB = "db_rewardui.db";

		// Token: 0x040012B5 RID: 4789
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x040012B6 RID: 4790
		private const string TABLE = "ExploreRewardDisplay";

		// Token: 0x040012B7 RID: 4791
		private const string COMMAND = "select BinData from `ExploreRewardDisplay` where Id=?";

		// Token: 0x040012B8 RID: 4792
		private const string KEY_PREFIX = "ExploreRewardDisplayById";

		// Token: 0x040012B9 RID: 4793
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012BA RID: 4794
		private static int HandleId;
	}
}
