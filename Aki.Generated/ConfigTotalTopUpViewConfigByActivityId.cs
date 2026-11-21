using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC2 RID: 2754
	public class ConfigTotalTopUpViewConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060040A0 RID: 16544 RVA: 0x001CA398 File Offset: 0x001C8598
		static ConfigTotalTopUpViewConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpViewConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigTotalTopUpViewConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x001CA3B8 File Offset: 0x001C85B8
		public static void CreateStaticDefaultValue()
		{
			ConfigTotalTopUpViewConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTotalTopUpViewConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_totaltopup.db"),
				new ValueTuple<string, object>("文件", "l.累充活动.xlsx"),
				new ValueTuple<string, object>("表名", "TotalTopUpViewConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TotalTopUpViewConfig` where ActivityId=?")
			});
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x001CA437 File Offset: 0x001C8637
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpViewConfigByActivityId.LogPair = null;
			ConfigTotalTopUpViewConfigByActivityId.HandleId = 0;
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x001CA445 File Offset: 0x001C8645
		public static void Init()
		{
			ConfigTotalTopUpViewConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpViewConfigByActivityId.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpViewConfig` where ActivityId=?");
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x001CA460 File Offset: 0x001C8660
		public static TotalTopUpViewConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTotalTopUpViewConfigByActivityId.HandleId, ConfigTotalTopUpViewConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpViewConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TotalTopUpViewConfig?(TotalTopUpViewConfig.GetRootAsTotalTopUpViewConfig(configBuffer));
				}
			}
			ConfigTotalTopUpViewConfigByActivityId.LogPair.Clear();
			ConfigTotalTopUpViewConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTotalTopUpViewConfigByActivityId.HandleId, 1, p0ActivityId, ConfigTotalTopUpViewConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigTotalTopUpViewConfigByActivityId.HandleId, true, ConfigTotalTopUpViewConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTotalTopUpViewConfigByActivityId.HandleId, ConfigTotalTopUpViewConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTotalTopUpViewConfigByActivityId.HandleId, 0, ConfigTotalTopUpViewConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTotalTopUpViewConfigByActivityId.HandleId, ConfigTotalTopUpViewConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TotalTopUpViewConfig rootAsTotalTopUpViewConfig = TotalTopUpViewConfig.GetRootAsTotalTopUpViewConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpViewConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTotalTopUpViewConfigByActivityId.HandleId, ConfigTotalTopUpViewConfigByActivityId.LogPair);
			return new TotalTopUpViewConfig?(rootAsTotalTopUpViewConfig);
		}

		// Token: 0x04004B34 RID: 19252
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004B35 RID: 19253
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004B36 RID: 19254
		private const string TABLE = "TotalTopUpViewConfig";

		// Token: 0x04004B37 RID: 19255
		private const string COMMAND = "select BinData from `TotalTopUpViewConfig` where ActivityId=?";

		// Token: 0x04004B38 RID: 19256
		private const string KEY_PREFIX = "TotalTopUpViewConfigByActivityId";

		// Token: 0x04004B39 RID: 19257
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B3A RID: 19258
		private static int HandleId;
	}
}
