using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EB RID: 2539
	public class ConfigTotalTopUpRotationByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B96 RID: 15254 RVA: 0x001AAB83 File Offset: 0x001A8D83
		static ConfigTotalTopUpRotationByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRotationByActivityId.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRotationByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x001AABA4 File Offset: 0x001A8DA4
		public static void CreateStaticDefaultValue()
		{
			ConfigTotalTopUpRotationByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTotalTopUpRotationByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_totaltopup.db"),
				new ValueTuple<string, object>("文件", "l.累充活动.xlsx"),
				new ValueTuple<string, object>("表名", "TotalTopUpRotation"),
				new ValueTuple<string, object>("语句", "select BinData from `TotalTopUpRotation` where ActivityId=?")
			});
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x001AAC23 File Offset: 0x001A8E23
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRotationByActivityId.LogPair = null;
			ConfigTotalTopUpRotationByActivityId.HandleId = 0;
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x001AAC31 File Offset: 0x001A8E31
		public static void Init()
		{
			ConfigTotalTopUpRotationByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRotationByActivityId.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpRotation` where ActivityId=?");
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x001AAC4C File Offset: 0x001A8E4C
		[NullableContext(2)]
		public static IReadOnlyList<TotalTopUpRotation> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTotalTopUpRotationByActivityId.HandleId, ConfigTotalTopUpRotationByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpRotationByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TotalTopUpRotation> readOnlyList = (IReadOnlyList<TotalTopUpRotation>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTotalTopUpRotationByActivityId.LogPair.Clear();
			ConfigTotalTopUpRotationByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTotalTopUpRotationByActivityId.HandleId, 1, p0ActivityId, ConfigTotalTopUpRotationByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTotalTopUpRotationByActivityId.HandleId, ConfigTotalTopUpRotationByActivityId.LogPair);
				return null;
			}
			List<TotalTopUpRotation> list = new List<TotalTopUpRotation>();
			while (ConfigCommon.Step(ConfigTotalTopUpRotationByActivityId.HandleId, false, ConfigTotalTopUpRotationByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTotalTopUpRotationByActivityId.HandleId, 0, ConfigTotalTopUpRotationByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTotalTopUpRotationByActivityId.HandleId, ConfigTotalTopUpRotationByActivityId.LogPair);
					return null;
				}
				TotalTopUpRotation rootAsTotalTopUpRotation = TotalTopUpRotation.GetRootAsTotalTopUpRotation(new ByteBuffer(item2));
				list.Add(rootAsTotalTopUpRotation);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpRotationByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTotalTopUpRotationByActivityId.HandleId, ConfigTotalTopUpRotationByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004553 RID: 17747
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004554 RID: 17748
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004555 RID: 17749
		private const string TABLE = "TotalTopUpRotation";

		// Token: 0x04004556 RID: 17750
		private const string COMMAND = "select BinData from `TotalTopUpRotation` where ActivityId=?";

		// Token: 0x04004557 RID: 17751
		private const string KEY_PREFIX = "TotalTopUpRotationByActivityId";

		// Token: 0x04004558 RID: 17752
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004559 RID: 17753
		private static int HandleId;
	}
}
