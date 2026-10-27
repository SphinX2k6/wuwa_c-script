using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D3 RID: 1747
	public class ConfigPhotoFightActivityGroupByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002902 RID: 10498 RVA: 0x00141413 File Offset: 0x0013F613
		static ConfigPhotoFightActivityGroupByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityGroupByActivityId.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityGroupByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00141434 File Offset: 0x0013F634
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightActivityGroupByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightActivityGroupByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightActivityGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightActivityGroup` where ActivityId=?")
			});
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x001414B3 File Offset: 0x0013F6B3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityGroupByActivityId.LogPair = null;
			ConfigPhotoFightActivityGroupByActivityId.HandleId = 0;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x001414C1 File Offset: 0x0013F6C1
		public static void Init()
		{
			ConfigPhotoFightActivityGroupByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityGroupByActivityId.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivityGroup` where ActivityId=?");
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x001414DC File Offset: 0x0013F6DC
		[NullableContext(2)]
		public static IReadOnlyList<PhotoFightActivityGroup> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightActivityGroupByActivityId.HandleId, ConfigPhotoFightActivityGroupByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightActivityGroupByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhotoFightActivityGroup> readOnlyList = (IReadOnlyList<PhotoFightActivityGroup>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhotoFightActivityGroupByActivityId.LogPair.Clear();
			ConfigPhotoFightActivityGroupByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhotoFightActivityGroupByActivityId.HandleId, 1, p0ActivityId, ConfigPhotoFightActivityGroupByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhotoFightActivityGroupByActivityId.HandleId, ConfigPhotoFightActivityGroupByActivityId.LogPair);
				return null;
			}
			List<PhotoFightActivityGroup> list = new List<PhotoFightActivityGroup>();
			while (ConfigCommon.Step(ConfigPhotoFightActivityGroupByActivityId.HandleId, false, ConfigPhotoFightActivityGroupByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightActivityGroupByActivityId.HandleId, 0, ConfigPhotoFightActivityGroupByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotoFightActivityGroupByActivityId.HandleId, ConfigPhotoFightActivityGroupByActivityId.LogPair);
					return null;
				}
				PhotoFightActivityGroup rootAsPhotoFightActivityGroup = PhotoFightActivityGroup.GetRootAsPhotoFightActivityGroup(new ByteBuffer(item2));
				list.Add(rootAsPhotoFightActivityGroup);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightActivityGroupByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotoFightActivityGroupByActivityId.HandleId, ConfigPhotoFightActivityGroupByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002FAB RID: 12203
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002FAC RID: 12204
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002FAD RID: 12205
		private const string TABLE = "PhotoFightActivityGroup";

		// Token: 0x04002FAE RID: 12206
		private const string COMMAND = "select BinData from `PhotoFightActivityGroup` where ActivityId=?";

		// Token: 0x04002FAF RID: 12207
		private const string KEY_PREFIX = "PhotoFightActivityGroupByActivityId";

		// Token: 0x04002FB0 RID: 12208
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FB1 RID: 12209
		private static int HandleId;
	}
}
