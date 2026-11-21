using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089F RID: 2207
	public class ConfigRogueWhiteCatRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033CC RID: 13260 RVA: 0x00181B44 File Offset: 0x0017FD44
		static ConfigRogueWhiteCatRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWhiteCatRewardById.CreateStaticDefaultValue), new Action(ConfigRogueWhiteCatRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x00181B64 File Offset: 0x0017FD64
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWhiteCatRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWhiteCatRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWhiteCatReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWhiteCatReward` where Id=?")
			});
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x00181BE3 File Offset: 0x0017FDE3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWhiteCatRewardById.LogPair = null;
			ConfigRogueWhiteCatRewardById.HandleId = 0;
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00181BF1 File Offset: 0x0017FDF1
		public static void Init()
		{
			ConfigRogueWhiteCatRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWhiteCatRewardById.HandleId, "db_dreamlink.db", "select BinData from `RogueWhiteCatReward` where Id=?");
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00181C0C File Offset: 0x0017FE0C
		public static RogueWhiteCatReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWhiteCatRewardById.HandleId, ConfigRogueWhiteCatRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWhiteCatRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWhiteCatReward?(RogueWhiteCatReward.GetRootAsRogueWhiteCatReward(configBuffer));
				}
			}
			ConfigRogueWhiteCatRewardById.LogPair.Clear();
			ConfigRogueWhiteCatRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWhiteCatRewardById.HandleId, 1, p0Id, ConfigRogueWhiteCatRewardById.LogPair) || ConfigCommon.Step(ConfigRogueWhiteCatRewardById.HandleId, true, ConfigRogueWhiteCatRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWhiteCatRewardById.HandleId, ConfigRogueWhiteCatRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWhiteCatRewardById.HandleId, 0, ConfigRogueWhiteCatRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWhiteCatRewardById.HandleId, ConfigRogueWhiteCatRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWhiteCatReward rootAsRogueWhiteCatReward = RogueWhiteCatReward.GetRootAsRogueWhiteCatReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWhiteCatRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWhiteCatRewardById.HandleId, ConfigRogueWhiteCatRewardById.LogPair);
			return new RogueWhiteCatReward?(rootAsRogueWhiteCatReward);
		}

		// Token: 0x04003C3F RID: 15423
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003C40 RID: 15424
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003C41 RID: 15425
		private const string TABLE = "RogueWhiteCatReward";

		// Token: 0x04003C42 RID: 15426
		private const string COMMAND = "select BinData from `RogueWhiteCatReward` where Id=?";

		// Token: 0x04003C43 RID: 15427
		private const string KEY_PREFIX = "RogueWhiteCatRewardById";

		// Token: 0x04003C44 RID: 15428
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C45 RID: 15429
		private static int HandleId;
	}
}
