using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006EB RID: 1771
	public class ConfigPhotoFightActivityGroupByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002992 RID: 10642 RVA: 0x00147E8F File Offset: 0x0014608F
		static ConfigPhotoFightActivityGroupByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityGroupByActivityId.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityGroupByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x00147EB0 File Offset: 0x001460B0
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

		// Token: 0x06002994 RID: 10644 RVA: 0x00147F2F File Offset: 0x0014612F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityGroupByActivityId.LogPair = null;
			ConfigPhotoFightActivityGroupByActivityId.HandleId = 0;
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00147F3D File Offset: 0x0014613D
		public static void Init()
		{
			ConfigPhotoFightActivityGroupByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityGroupByActivityId.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivityGroup` where ActivityId=?");
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x00147F58 File Offset: 0x00146158
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

		// Token: 0x04003053 RID: 12371
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04003054 RID: 12372
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04003055 RID: 12373
		private const string TABLE = "PhotoFightActivityGroup";

		// Token: 0x04003056 RID: 12374
		private const string COMMAND = "select BinData from `PhotoFightActivityGroup` where ActivityId=?";

		// Token: 0x04003057 RID: 12375
		private const string KEY_PREFIX = "PhotoFightActivityGroupByActivityId";

		// Token: 0x04003058 RID: 12376
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003059 RID: 12377
		private static int HandleId;
	}
}
