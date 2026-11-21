using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EF RID: 1775
	public class ConfigPhotoFightRewardTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029AA RID: 10666 RVA: 0x00148627 File Offset: 0x00146827
		static ConfigPhotoFightRewardTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightRewardTabByActivityId.CreateStaticDefaultValue), new Action(ConfigPhotoFightRewardTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00148648 File Offset: 0x00146848
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

		// Token: 0x060029AC RID: 10668 RVA: 0x001486C7 File Offset: 0x001468C7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightRewardTabByActivityId.LogPair = null;
			ConfigPhotoFightRewardTabByActivityId.HandleId = 0;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x001486D5 File Offset: 0x001468D5
		public static void Init()
		{
			ConfigPhotoFightRewardTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightRewardTabByActivityId.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightRewardTab` where ActivityId=?");
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x001486F0 File Offset: 0x001468F0
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

		// Token: 0x0400306F RID: 12399
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04003070 RID: 12400
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04003071 RID: 12401
		private const string TABLE = "PhotoFightRewardTab";

		// Token: 0x04003072 RID: 12402
		private const string COMMAND = "select BinData from `PhotoFightRewardTab` where ActivityId=?";

		// Token: 0x04003073 RID: 12403
		private const string KEY_PREFIX = "PhotoFightRewardTabByActivityId";

		// Token: 0x04003074 RID: 12404
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003075 RID: 12405
		private static int HandleId;
	}
}
