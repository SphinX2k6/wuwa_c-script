using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006ED RID: 1773
	public class ConfigPhotoFightRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600299E RID: 10654 RVA: 0x0014825B File Offset: 0x0014645B
		static ConfigPhotoFightRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigPhotoFightRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x0014827C File Offset: 0x0014647C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightReward"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightReward` where ActivityId=?")
			});
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x001482FB File Offset: 0x001464FB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightRewardByActivityId.LogPair = null;
			ConfigPhotoFightRewardByActivityId.HandleId = 0;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00148309 File Offset: 0x00146509
		public static void Init()
		{
			ConfigPhotoFightRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightRewardByActivityId.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightReward` where ActivityId=?");
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00148324 File Offset: 0x00146524
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFightReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightRewardByActivityId.HandleId, ConfigPhotoFightRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhotoFightReward> readOnlyList = (IReadOnlyList<PhotoFightReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoFightRewardByActivityId.LogPair.Clear();
			ConfigPhotoFightRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhotoFightRewardByActivityId.HandleId, 1, p0ActivityId, ConfigPhotoFightRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoFightRewardByActivityId.HandleId, ConfigPhotoFightRewardByActivityId.LogPair);
				return null;
			}
			List<PhotoFightReward> list = new List<PhotoFightReward>();
			while (ConfigCommon.Step(ConfigPhotoFightRewardByActivityId.HandleId, false, ConfigPhotoFightRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightRewardByActivityId.HandleId, 0, ConfigPhotoFightRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFightRewardByActivityId.HandleId, ConfigPhotoFightRewardByActivityId.LogPair);
					return null;
				}
				PhotoFightReward rootAsPhotoFightReward = PhotoFightReward.GetRootAsPhotoFightReward(new ByteBuffer(item2));
				list.Add(rootAsPhotoFightReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFightRewardByActivityId.HandleId, ConfigPhotoFightRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003061 RID: 12385
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04003062 RID: 12386
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04003063 RID: 12387
		private const string TABLE = "PhotoFightReward";

		// Token: 0x04003064 RID: 12388
		private const string COMMAND = "select BinData from `PhotoFightReward` where ActivityId=?";

		// Token: 0x04003065 RID: 12389
		private const string KEY_PREFIX = "PhotoFightRewardByActivityId";

		// Token: 0x04003066 RID: 12390
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003067 RID: 12391
		private static int HandleId;
	}
}
