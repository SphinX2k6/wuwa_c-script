using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AA RID: 170
	public class ConfigAreaByDeliveryMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00073AEB File Offset: 0x00071CEB
		static ConfigAreaByDeliveryMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaByDeliveryMarkId.CreateStaticDefaultValue), new Action(ConfigAreaByDeliveryMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00073B0C File Offset: 0x00071D0C
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

		// Token: 0x060003FF RID: 1023 RVA: 0x00073B8B File Offset: 0x00071D8B
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaByDeliveryMarkId.LogPair = null;
			ConfigAreaByDeliveryMarkId.HandleId = 0;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00073B99 File Offset: 0x00071D99
		public static void Init()
		{
			ConfigAreaByDeliveryMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigAreaByDeliveryMarkId.HandleId, "db_area.db", "select BinData from `Area` where DeliveryMarkId=?");
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00073BB4 File Offset: 0x00071DB4
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

		// Token: 0x0400048A RID: 1162
		private const string DB = "db_area.db";

		// Token: 0x0400048B RID: 1163
		private const string FILE = "q.区域.xlsx";

		// Token: 0x0400048C RID: 1164
		private const string TABLE = "Area";

		// Token: 0x0400048D RID: 1165
		private const string COMMAND = "select BinData from `Area` where DeliveryMarkId=?";

		// Token: 0x0400048E RID: 1166
		private const string KEY_PREFIX = "AreaByDeliveryMarkId";

		// Token: 0x0400048F RID: 1167
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000490 RID: 1168
		private static int HandleId;
	}
}
