using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC0 RID: 2752
	public class ConfigTotalTopUpRotationByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004094 RID: 16532 RVA: 0x001C9F17 File Offset: 0x001C8117
		static ConfigTotalTopUpRotationByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRotationByActivityId.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRotationByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x001C9F38 File Offset: 0x001C8138
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

		// Token: 0x06004096 RID: 16534 RVA: 0x001C9FB7 File Offset: 0x001C81B7
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRotationByActivityId.LogPair = null;
			ConfigTotalTopUpRotationByActivityId.HandleId = 0;
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x001C9FC5 File Offset: 0x001C81C5
		public static void Init()
		{
			ConfigTotalTopUpRotationByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRotationByActivityId.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpRotation` where ActivityId=?");
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x001C9FE0 File Offset: 0x001C81E0
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

		// Token: 0x04004B26 RID: 19238
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004B27 RID: 19239
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004B28 RID: 19240
		private const string TABLE = "TotalTopUpRotation";

		// Token: 0x04004B29 RID: 19241
		private const string COMMAND = "select BinData from `TotalTopUpRotation` where ActivityId=?";

		// Token: 0x04004B2A RID: 19242
		private const string KEY_PREFIX = "TotalTopUpRotationByActivityId";

		// Token: 0x04004B2B RID: 19243
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B2C RID: 19244
		private static int HandleId;
	}
}
