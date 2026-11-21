using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024C RID: 588
	public class ConfigDropCatchRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DCC RID: 3532 RVA: 0x000AB224 File Offset: 0x000A9424
		static ConfigDropCatchRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRewardById.CreateStaticDefaultValue), new Action(ConfigDropCatchRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000AB244 File Offset: 0x000A9444
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchReward"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchReward` where Id=?")
			});
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000AB2C3 File Offset: 0x000A94C3
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRewardById.LogPair = null;
			ConfigDropCatchRewardById.HandleId = 0;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x000AB2D1 File Offset: 0x000A94D1
		public static void Init()
		{
			ConfigDropCatchRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRewardById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchReward` where Id=?");
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000AB2EC File Offset: 0x000A94EC
		public static DropCatchReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchRewardById.HandleId, ConfigDropCatchRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropCatchReward?(DropCatchReward.GetRootAsDropCatchReward(configBuffer));
				}
			}
			ConfigDropCatchRewardById.LogPair.Clear();
			ConfigDropCatchRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropCatchRewardById.HandleId, 1, p0Id, ConfigDropCatchRewardById.LogPair) || ConfigCommon.Step(ConfigDropCatchRewardById.HandleId, true, ConfigDropCatchRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropCatchRewardById.HandleId, ConfigDropCatchRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchRewardById.HandleId, 0, ConfigDropCatchRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropCatchRewardById.HandleId, ConfigDropCatchRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropCatchReward rootAsDropCatchReward = DropCatchReward.GetRootAsDropCatchReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropCatchRewardById.HandleId, ConfigDropCatchRewardById.LogPair);
			return new DropCatchReward?(rootAsDropCatchReward);
		}

		// Token: 0x04000FF8 RID: 4088
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000FF9 RID: 4089
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000FFA RID: 4090
		private const string TABLE = "DropCatchReward";

		// Token: 0x04000FFB RID: 4091
		private const string COMMAND = "select BinData from `DropCatchReward` where Id=?";

		// Token: 0x04000FFC RID: 4092
		private const string KEY_PREFIX = "DropCatchRewardById";

		// Token: 0x04000FFD RID: 4093
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FFE RID: 4094
		private static int HandleId;
	}
}
