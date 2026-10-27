using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000883 RID: 2179
	public class ConfigRogueWhiteCatRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003324 RID: 13092 RVA: 0x0017A85C File Offset: 0x00178A5C
		static ConfigRogueWhiteCatRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWhiteCatRewardById.CreateStaticDefaultValue), new Action(ConfigRogueWhiteCatRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x0017A87C File Offset: 0x00178A7C
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

		// Token: 0x06003326 RID: 13094 RVA: 0x0017A8FB File Offset: 0x00178AFB
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWhiteCatRewardById.LogPair = null;
			ConfigRogueWhiteCatRewardById.HandleId = 0;
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x0017A909 File Offset: 0x00178B09
		public static void Init()
		{
			ConfigRogueWhiteCatRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWhiteCatRewardById.HandleId, "db_dreamlink.db", "select BinData from `RogueWhiteCatReward` where Id=?");
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x0017A924 File Offset: 0x00178B24
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

		// Token: 0x04003B7B RID: 15227
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003B7C RID: 15228
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003B7D RID: 15229
		private const string TABLE = "RogueWhiteCatReward";

		// Token: 0x04003B7E RID: 15230
		private const string COMMAND = "select BinData from `RogueWhiteCatReward` where Id=?";

		// Token: 0x04003B7F RID: 15231
		private const string KEY_PREFIX = "RogueWhiteCatRewardById";

		// Token: 0x04003B80 RID: 15232
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B81 RID: 15233
		private static int HandleId;
	}
}
