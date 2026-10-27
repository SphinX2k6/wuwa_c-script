using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D7 RID: 1751
	public class ConfigPhotoFightRewardTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600291A RID: 10522 RVA: 0x00141BAB File Offset: 0x0013FDAB
		static ConfigPhotoFightRewardTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightRewardTabByActivityId.CreateStaticDefaultValue), new Action(ConfigPhotoFightRewardTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00141BCC File Offset: 0x0013FDCC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightRewardTabByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightRewardTabByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightRewardTab` where ActivityId=?")
			});
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00141C4B File Offset: 0x0013FE4B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightRewardTabByActivityId.LogPair = null;
			ConfigPhotoFightRewardTabByActivityId.HandleId = 0;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00141C59 File Offset: 0x0013FE59
		public static void Init()
		{
			ConfigPhotoFightRewardTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightRewardTabByActivityId.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightRewardTab` where ActivityId=?");
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00141C74 File Offset: 0x0013FE74
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFightRewardTab> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightRewardTabByActivityId.HandleId, ConfigPhotoFightRewardTabByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightRewardTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhotoFightRewardTab> readOnlyList = (IReadOnlyList<PhotoFightRewardTab>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoFightRewardTabByActivityId.LogPair.Clear();
			ConfigPhotoFightRewardTabByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhotoFightRewardTabByActivityId.HandleId, 1, p0ActivityId, ConfigPhotoFightRewardTabByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoFightRewardTabByActivityId.HandleId, ConfigPhotoFightRewardTabByActivityId.LogPair);
				return null;
			}
			List<PhotoFightRewardTab> list = new List<PhotoFightRewardTab>();
			while (ConfigCommon.Step(ConfigPhotoFightRewardTabByActivityId.HandleId, false, ConfigPhotoFightRewardTabByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightRewardTabByActivityId.HandleId, 0, ConfigPhotoFightRewardTabByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFightRewardTabByActivityId.HandleId, ConfigPhotoFightRewardTabByActivityId.LogPair);
					return null;
				}
				PhotoFightRewardTab rootAsPhotoFightRewardTab = PhotoFightRewardTab.GetRootAsPhotoFightRewardTab(new ByteBuffer(item2));
				list.Add(rootAsPhotoFightRewardTab);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightRewardTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFightRewardTabByActivityId.HandleId, ConfigPhotoFightRewardTabByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002FC7 RID: 12231
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002FC8 RID: 12232
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002FC9 RID: 12233
		private const string TABLE = "PhotoFightRewardTab";

		// Token: 0x04002FCA RID: 12234
		private const string COMMAND = "select BinData from `PhotoFightRewardTab` where ActivityId=?";

		// Token: 0x04002FCB RID: 12235
		private const string KEY_PREFIX = "PhotoFightRewardTabByActivityId";

		// Token: 0x04002FCC RID: 12236
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FCD RID: 12237
		private static int HandleId;
	}
}
