using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABE RID: 2750
	public class ConfigTotalTopUpRoleViewConfigByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004088 RID: 16520 RVA: 0x001C9B3C File Offset: 0x001C7D3C
		static ConfigTotalTopUpRoleViewConfigByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRoleViewConfigByItemId.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRoleViewConfigByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x001C9B5C File Offset: 0x001C7D5C
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

		// Token: 0x0600408A RID: 16522 RVA: 0x001C9BDB File Offset: 0x001C7DDB
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRoleViewConfigByItemId.LogPair = null;
			ConfigTotalTopUpRoleViewConfigByItemId.HandleId = 0;
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x001C9BE9 File Offset: 0x001C7DE9
		public static void Init()
		{
			ConfigTotalTopUpRoleViewConfigByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRoleViewConfigByItemId.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpRoleViewConfig` where ItemId=?");
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x001C9C04 File Offset: 0x001C7E04
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

		// Token: 0x04004B18 RID: 19224
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004B19 RID: 19225
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004B1A RID: 19226
		private const string TABLE = "TotalTopUpRoleViewConfig";

		// Token: 0x04004B1B RID: 19227
		private const string COMMAND = "select BinData from `TotalTopUpRoleViewConfig` where ItemId=?";

		// Token: 0x04004B1C RID: 19228
		private const string KEY_PREFIX = "TotalTopUpRoleViewConfigByItemId";

		// Token: 0x04004B1D RID: 19229
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B1E RID: 19230
		private static int HandleId;
	}
}
