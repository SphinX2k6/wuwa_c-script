using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B77 RID: 2935
	public class ConfigWuWuLogisticsDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044DF RID: 17631 RVA: 0x001E2C87 File Offset: 0x001E0E87
		static ConfigWuWuLogisticsDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWuWuLogisticsDescById.CreateStaticDefaultValue), new Action(ConfigWuWuLogisticsDescById.ResetStaticDefaultValue));
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x001E2CA8 File Offset: 0x001E0EA8
		public static void CreateStaticDefaultValue()
		{
			ConfigWuWuLogisticsDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWuWuLogisticsDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwutask.db"),
				new ValueTuple<string, object>("文件", "w.呜呜签到.xlsx"),
				new ValueTuple<string, object>("表名", "WuWuLogisticsDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `WuWuLogisticsDesc` where Id=?")
			});
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x001E2D27 File Offset: 0x001E0F27
		public static void ResetStaticDefaultValue()
		{
			ConfigWuWuLogisticsDescById.LogPair = null;
			ConfigWuWuLogisticsDescById.HandleId = 0;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x001E2D35 File Offset: 0x001E0F35
		public static void Init()
		{
			ConfigWuWuLogisticsDescById.HandleId = ConfigCommon.InitDataStatement(ConfigWuWuLogisticsDescById.HandleId, "db_wuwutask.db", "select BinData from `WuWuLogisticsDesc` where Id=?");
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x001E2D50 File Offset: 0x001E0F50
		public static WuWuLogisticsDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWuWuLogisticsDescById.HandleId, ConfigWuWuLogisticsDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuLogisticsDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WuWuLogisticsDesc?(WuWuLogisticsDesc.GetRootAsWuWuLogisticsDesc(configBuffer));
				}
			}
			ConfigWuWuLogisticsDescById.LogPair.Clear();
			ConfigWuWuLogisticsDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWuWuLogisticsDescById.HandleId, 1, p0Id, ConfigWuWuLogisticsDescById.LogPair) || ConfigCommon.Step(ConfigWuWuLogisticsDescById.HandleId, true, ConfigWuWuLogisticsDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWuWuLogisticsDescById.HandleId, ConfigWuWuLogisticsDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWuWuLogisticsDescById.HandleId, 0, ConfigWuWuLogisticsDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWuWuLogisticsDescById.HandleId, ConfigWuWuLogisticsDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WuWuLogisticsDesc rootAsWuWuLogisticsDesc = WuWuLogisticsDesc.GetRootAsWuWuLogisticsDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WuWuLogisticsDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWuWuLogisticsDescById.HandleId, ConfigWuWuLogisticsDescById.LogPair);
			return new WuWuLogisticsDesc?(rootAsWuWuLogisticsDesc);
		}

		// Token: 0x04005027 RID: 20519
		private const string DB = "db_wuwutask.db";

		// Token: 0x04005028 RID: 20520
		private const string FILE = "w.呜呜签到.xlsx";

		// Token: 0x04005029 RID: 20521
		private const string TABLE = "WuWuLogisticsDesc";

		// Token: 0x0400502A RID: 20522
		private const string COMMAND = "select BinData from `WuWuLogisticsDesc` where Id=?";

		// Token: 0x0400502B RID: 20523
		private const string KEY_PREFIX = "WuWuLogisticsDescById";

		// Token: 0x0400502C RID: 20524
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400502D RID: 20525
		private static int HandleId;
	}
}
