using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E9 RID: 2537
	public class ConfigTotalTopUpRoleViewConfigByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B8A RID: 15242 RVA: 0x001AA7A8 File Offset: 0x001A89A8
		static ConfigTotalTopUpRoleViewConfigByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRoleViewConfigByItemId.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRoleViewConfigByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x001AA7C8 File Offset: 0x001A89C8
		public static void CreateStaticDefaultValue()
		{
			ConfigTotalTopUpRoleViewConfigByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTotalTopUpRoleViewConfigByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_totaltopup.db"),
				new ValueTuple<string, object>("文件", "l.累充活动.xlsx"),
				new ValueTuple<string, object>("表名", "TotalTopUpRoleViewConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TotalTopUpRoleViewConfig` where ItemId=?")
			});
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x001AA847 File Offset: 0x001A8A47
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRoleViewConfigByItemId.LogPair = null;
			ConfigTotalTopUpRoleViewConfigByItemId.HandleId = 0;
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x001AA855 File Offset: 0x001A8A55
		public static void Init()
		{
			ConfigTotalTopUpRoleViewConfigByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpRoleViewConfig` where ItemId=?");
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x001AA870 File Offset: 0x001A8A70
		public static TotalTopUpRoleViewConfig? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, ConfigTotalTopUpRoleViewConfigByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpRoleViewConfigByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TotalTopUpRoleViewConfig?(TotalTopUpRoleViewConfig.GetRootAsTotalTopUpRoleViewConfig(configBuffer));
				}
			}
			ConfigTotalTopUpRoleViewConfigByItemId.LogPair.Clear();
			ConfigTotalTopUpRoleViewConfigByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, 1, p0ItemId, ConfigTotalTopUpRoleViewConfigByItemId.LogPair) || ConfigCommon.Step(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, true, ConfigTotalTopUpRoleViewConfigByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, ConfigTotalTopUpRoleViewConfigByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, 0, ConfigTotalTopUpRoleViewConfigByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, ConfigTotalTopUpRoleViewConfigByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TotalTopUpRoleViewConfig rootAsTotalTopUpRoleViewConfig = TotalTopUpRoleViewConfig.GetRootAsTotalTopUpRoleViewConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpRoleViewConfigByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, ConfigTotalTopUpRoleViewConfigByItemId.LogPair);
			return new TotalTopUpRoleViewConfig?(rootAsTotalTopUpRoleViewConfig);
		}

		// Token: 0x04004545 RID: 17733
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004546 RID: 17734
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004547 RID: 17735
		private const string TABLE = "TotalTopUpRoleViewConfig";

		// Token: 0x04004548 RID: 17736
		private const string COMMAND = "select BinData from `TotalTopUpRoleViewConfig` where ItemId=?";

		// Token: 0x04004549 RID: 17737
		private const string KEY_PREFIX = "TotalTopUpRoleViewConfigByItemId";

		// Token: 0x0400454A RID: 17738
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400454B RID: 17739
		private static int HandleId;
	}
}
