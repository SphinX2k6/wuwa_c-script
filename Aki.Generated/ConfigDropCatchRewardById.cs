using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023A RID: 570
	public class ConfigDropCatchRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D60 RID: 3424 RVA: 0x000A52EC File Offset: 0x000A34EC
		static ConfigDropCatchRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRewardById.CreateStaticDefaultValue), new Action(ConfigDropCatchRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x000A530C File Offset: 0x000A350C
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

		// Token: 0x06000D62 RID: 3426 RVA: 0x000A538B File Offset: 0x000A358B
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRewardById.LogPair = null;
			ConfigDropCatchRewardById.HandleId = 0;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000A5399 File Offset: 0x000A3599
		public static void Init()
		{
			ConfigDropCatchRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRewardById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchReward` where Id=?");
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000A53B4 File Offset: 0x000A35B4
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

		// Token: 0x04000F7A RID: 3962
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F7B RID: 3963
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F7C RID: 3964
		private const string TABLE = "DropCatchReward";

		// Token: 0x04000F7D RID: 3965
		private const string COMMAND = "select BinData from `DropCatchReward` where Id=?";

		// Token: 0x04000F7E RID: 3966
		private const string KEY_PREFIX = "DropCatchRewardById";

		// Token: 0x04000F7F RID: 3967
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F80 RID: 3968
		private static int HandleId;
	}
}
