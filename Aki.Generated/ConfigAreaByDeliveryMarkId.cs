using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A2 RID: 162
	public class ConfigAreaByDeliveryMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003CD RID: 973 RVA: 0x0006F237 File Offset: 0x0006D437
		static ConfigAreaByDeliveryMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaByDeliveryMarkId.CreateStaticDefaultValue), new Action(ConfigAreaByDeliveryMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0006F258 File Offset: 0x0006D458
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaByDeliveryMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaByDeliveryMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "Area"),
				new ValueTuple<string, object>("语句", "select BinData from `Area` where DeliveryMarkId=?")
			});
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0006F2D7 File Offset: 0x0006D4D7
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaByDeliveryMarkId.LogPair = null;
			ConfigAreaByDeliveryMarkId.HandleId = 0;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0006F2E5 File Offset: 0x0006D4E5
		public static void Init()
		{
			ConfigAreaByDeliveryMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigAreaByDeliveryMarkId.HandleId, "db_area.db", "select BinData from `Area` where DeliveryMarkId=?");
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0006F300 File Offset: 0x0006D500
		public static Area? GetConfig(int p0DeliveryMarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaByDeliveryMarkId.HandleId, ConfigAreaByDeliveryMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByDeliveryMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DeliveryMarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Area?(Area.GetRootAsArea(configBuffer));
				}
			}
			ConfigAreaByDeliveryMarkId.LogPair.Clear();
			ConfigAreaByDeliveryMarkId.LogPair.Add(new ValueTuple<string, object>("DeliveryMarkId", p0DeliveryMarkId));
			if (!ConfigCommon.BindInt(ConfigAreaByDeliveryMarkId.HandleId, 1, p0DeliveryMarkId, ConfigAreaByDeliveryMarkId.LogPair) || ConfigCommon.Step(ConfigAreaByDeliveryMarkId.HandleId, true, ConfigAreaByDeliveryMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaByDeliveryMarkId.HandleId, ConfigAreaByDeliveryMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaByDeliveryMarkId.HandleId, 0, ConfigAreaByDeliveryMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaByDeliveryMarkId.HandleId, ConfigAreaByDeliveryMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Area rootAsArea = Area.GetRootAsArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaByDeliveryMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DeliveryMarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaByDeliveryMarkId.HandleId, ConfigAreaByDeliveryMarkId.LogPair);
			return new Area?(rootAsArea);
		}

		// Token: 0x04000452 RID: 1106
		private const string DB = "db_area.db";

		// Token: 0x04000453 RID: 1107
		private const string FILE = "q.区域.xlsx";

		// Token: 0x04000454 RID: 1108
		private const string TABLE = "Area";

		// Token: 0x04000455 RID: 1109
		private const string COMMAND = "select BinData from `Area` where DeliveryMarkId=?";

		// Token: 0x04000456 RID: 1110
		private const string KEY_PREFIX = "AreaByDeliveryMarkId";

		// Token: 0x04000457 RID: 1111
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000458 RID: 1112
		private static int HandleId;
	}
}
