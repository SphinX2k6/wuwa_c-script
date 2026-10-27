using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094E RID: 2382
	public class ConfigSkinRewardActivityRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037E7 RID: 14311 RVA: 0x001958B7 File Offset: 0x00193AB7
		static ConfigSkinRewardActivityRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkinRewardActivityRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSkinRewardActivityRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x001958D8 File Offset: 0x00193AD8
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

		// Token: 0x060037E9 RID: 14313 RVA: 0x00195957 File Offset: 0x00193B57
		public static void ResetStaticDefaultValue()
		{
			ConfigSkinRewardActivityRewardByActivityId.LogPair = null;
			ConfigSkinRewardActivityRewardByActivityId.HandleId = 0;
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x00195965 File Offset: 0x00193B65
		public static void Init()
		{
			ConfigSkinRewardActivityRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSkinRewardActivityRewardByActivityId.HandleId, "db_skinreward.db", "select BinData from `SkinRewardActivityReward` where ActivityId=?");
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00195980 File Offset: 0x00193B80
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

		// Token: 0x04004108 RID: 16648
		private const string DB = "db_skinreward.db";

		// Token: 0x04004109 RID: 16649
		private const string FILE = "p.皮肤领取活动.xlsx";

		// Token: 0x0400410A RID: 16650
		private const string TABLE = "SkinRewardActivityReward";

		// Token: 0x0400410B RID: 16651
		private const string COMMAND = "select BinData from `SkinRewardActivityReward` where ActivityId=?";

		// Token: 0x0400410C RID: 16652
		private const string KEY_PREFIX = "SkinRewardActivityRewardByActivityId";

		// Token: 0x0400410D RID: 16653
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400410E RID: 16654
		private static int HandleId;
	}
}
