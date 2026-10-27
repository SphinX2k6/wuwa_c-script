using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009ED RID: 2541
	public class ConfigTotalTopUpViewConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003BA2 RID: 15266 RVA: 0x001AB004 File Offset: 0x001A9204
		static ConfigTotalTopUpViewConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpViewConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigTotalTopUpViewConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x001AB024 File Offset: 0x001A9224
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

		// Token: 0x06003BA4 RID: 15268 RVA: 0x001AB0A3 File Offset: 0x001A92A3
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpViewConfigByActivityId.LogPair = null;
			ConfigTotalTopUpViewConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x001AB0B1 File Offset: 0x001A92B1
		public static void Init()
		{
			ConfigTotalTopUpViewConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpViewConfigByActivityId.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpViewConfig` where ActivityId=?");
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x001AB0CC File Offset: 0x001A92CC
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

		// Token: 0x04004561 RID: 17761
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004562 RID: 17762
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004563 RID: 17763
		private const string TABLE = "TotalTopUpViewConfig";

		// Token: 0x04004564 RID: 17764
		private const string COMMAND = "select BinData from `TotalTopUpViewConfig` where ActivityId=?";

		// Token: 0x04004565 RID: 17765
		private const string KEY_PREFIX = "TotalTopUpViewConfigByActivityId";

		// Token: 0x04004566 RID: 17766
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004567 RID: 17767
		private static int HandleId;
	}
}
