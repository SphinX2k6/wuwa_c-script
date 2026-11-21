using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000999 RID: 2457
	public class ConfigSkinRewardActivityRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039A9 RID: 14761 RVA: 0x001A2AD7 File Offset: 0x001A0CD7
		static ConfigSkinRewardActivityRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkinRewardActivityRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSkinRewardActivityRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x001A2AF8 File Offset: 0x001A0CF8
		public static void CreateStaticDefaultValue()
		{
			ConfigSkinRewardActivityRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkinRewardActivityRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skinreward.db"),
				new ValueTuple<string, object>("文件", "p.皮肤领取活动.xlsx"),
				new ValueTuple<string, object>("表名", "SkinRewardActivityReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SkinRewardActivityReward` where ActivityId=?")
			});
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x001A2B77 File Offset: 0x001A0D77
		public static void ResetStaticDefaultValue()
		{
			ConfigSkinRewardActivityRewardByActivityId.LogPair = null;
			ConfigSkinRewardActivityRewardByActivityId.HandleId = 0;
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x001A2B85 File Offset: 0x001A0D85
		public static void Init()
		{
			ConfigSkinRewardActivityRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSkinRewardActivityRewardByActivityId.HandleId, "db_skinreward.db", "select BinData from `SkinRewardActivityReward` where ActivityId=?");
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x001A2BA0 File Offset: 0x001A0DA0
		public static SkinRewardActivityReward? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkinRewardActivityRewardByActivityId.HandleId, ConfigSkinRewardActivityRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkinRewardActivityRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkinRewardActivityReward?(SkinRewardActivityReward.GetRootAsSkinRewardActivityReward(configBuffer));
				}
			}
			ConfigSkinRewardActivityRewardByActivityId.LogPair.Clear();
			ConfigSkinRewardActivityRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSkinRewardActivityRewardByActivityId.HandleId, 1, p0ActivityId, ConfigSkinRewardActivityRewardByActivityId.LogPair) || ConfigCommon.Step(ConfigSkinRewardActivityRewardByActivityId.HandleId, true, ConfigSkinRewardActivityRewardByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkinRewardActivityRewardByActivityId.HandleId, ConfigSkinRewardActivityRewardByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkinRewardActivityRewardByActivityId.HandleId, 0, ConfigSkinRewardActivityRewardByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkinRewardActivityRewardByActivityId.HandleId, ConfigSkinRewardActivityRewardByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkinRewardActivityReward rootAsSkinRewardActivityReward = SkinRewardActivityReward.GetRootAsSkinRewardActivityReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkinRewardActivityRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkinRewardActivityRewardByActivityId.HandleId, ConfigSkinRewardActivityRewardByActivityId.LogPair);
			return new SkinRewardActivityReward?(rootAsSkinRewardActivityReward);
		}

		// Token: 0x04004315 RID: 17173
		private const string DB = "db_skinreward.db";

		// Token: 0x04004316 RID: 17174
		private const string FILE = "p.皮肤领取活动.xlsx";

		// Token: 0x04004317 RID: 17175
		private const string TABLE = "SkinRewardActivityReward";

		// Token: 0x04004318 RID: 17176
		private const string COMMAND = "select BinData from `SkinRewardActivityReward` where ActivityId=?";

		// Token: 0x04004319 RID: 17177
		private const string KEY_PREFIX = "SkinRewardActivityRewardByActivityId";

		// Token: 0x0400431A RID: 17178
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400431B RID: 17179
		private static int HandleId;
	}
}
