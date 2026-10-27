using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D5 RID: 1749
	public class ConfigPhotoFightRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600290E RID: 10510 RVA: 0x001417DF File Offset: 0x0013F9DF
		static ConfigPhotoFightRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigPhotoFightRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00141800 File Offset: 0x0013FA00
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

		// Token: 0x06002910 RID: 10512 RVA: 0x0014187F File Offset: 0x0013FA7F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightRewardByActivityId.LogPair = null;
			ConfigPhotoFightRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0014188D File Offset: 0x0013FA8D
		public static void Init()
		{
			ConfigPhotoFightRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightRewardByActivityId.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightReward` where ActivityId=?");
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x001418A8 File Offset: 0x0013FAA8
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

		// Token: 0x04002FB9 RID: 12217
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002FBA RID: 12218
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002FBB RID: 12219
		private const string TABLE = "PhotoFightReward";

		// Token: 0x04002FBC RID: 12220
		private const string COMMAND = "select BinData from `PhotoFightReward` where ActivityId=?";

		// Token: 0x04002FBD RID: 12221
		private const string KEY_PREFIX = "PhotoFightRewardByActivityId";

		// Token: 0x04002FBE RID: 12222
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FBF RID: 12223
		private static int HandleId;
	}
}
