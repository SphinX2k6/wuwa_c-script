using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A94 RID: 2708
	public class ConfigWeekCardByPayGiftId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F8C RID: 16268 RVA: 0x001C1ACC File Offset: 0x001BFCCC
		static ConfigWeekCardByPayGiftId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeekCardByPayGiftId.CreateStaticDefaultValue), new Action(ConfigWeekCardByPayGiftId.ResetStaticDefaultValue));
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x001C1AEC File Offset: 0x001BFCEC
		public static void CreateStaticDefaultValue()
		{
			ConfigWeekCardByPayGiftId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeekCardByPayGiftId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weekcard.db"),
				new ValueTuple<string, object>("文件", "z.周卡.xlsx"),
				new ValueTuple<string, object>("表名", "WeekCard"),
				new ValueTuple<string, object>("语句", "select BinData from `WeekCard` where PayGiftId=?")
			});
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x001C1B6B File Offset: 0x001BFD6B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeekCardByPayGiftId.LogPair = null;
			ConfigWeekCardByPayGiftId.HandleId = 0;
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x001C1B79 File Offset: 0x001BFD79
		public static void Init()
		{
			ConfigWeekCardByPayGiftId.HandleId = ConfigCommon.InitDataStatement(ConfigWeekCardByPayGiftId.HandleId, "db_weekcard.db", "select BinData from `WeekCard` where PayGiftId=?");
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x001C1B94 File Offset: 0x001BFD94
		public static WeekCard? GetConfig(int p0PayGiftId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeekCardByPayGiftId.HandleId, ConfigWeekCardByPayGiftId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardByPayGiftId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PayGiftId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeekCard?(WeekCard.GetRootAsWeekCard(configBuffer));
				}
			}
			ConfigWeekCardByPayGiftId.LogPair.Clear();
			ConfigWeekCardByPayGiftId.LogPair.Add(new ValueTuple<string, object>("PayGiftId", p0PayGiftId));
			if (!ConfigCommon.BindInt(ConfigWeekCardByPayGiftId.HandleId, 1, p0PayGiftId, ConfigWeekCardByPayGiftId.LogPair) || ConfigCommon.Step(ConfigWeekCardByPayGiftId.HandleId, true, ConfigWeekCardByPayGiftId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeekCardByPayGiftId.HandleId, ConfigWeekCardByPayGiftId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeekCardByPayGiftId.HandleId, 0, ConfigWeekCardByPayGiftId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeekCardByPayGiftId.HandleId, ConfigWeekCardByPayGiftId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeekCard rootAsWeekCard = WeekCard.GetRootAsWeekCard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardByPayGiftId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PayGiftId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeekCardByPayGiftId.HandleId, ConfigWeekCardByPayGiftId.LogPair);
			return new WeekCard?(rootAsWeekCard);
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x001C1D0C File Offset: 0x001BFF0C
		[NullableContext(2)]
		public static IReadOnlyList<WeekCard> GetConfigList(int p0PayGiftId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeekCardByPayGiftId.HandleId, ConfigWeekCardByPayGiftId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardByPayGiftId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PayGiftId);
				IReadOnlyList<WeekCard> readOnlyList = (IReadOnlyList<WeekCard>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWeekCardByPayGiftId.LogPair.Clear();
			ConfigWeekCardByPayGiftId.LogPair.Add(new ValueTuple<string, object>("PayGiftId", p0PayGiftId));
			if (!ConfigCommon.BindInt(ConfigWeekCardByPayGiftId.HandleId, 1, p0PayGiftId, ConfigWeekCardByPayGiftId.LogPair))
			{
				ConfigCommon.Reset(ConfigWeekCardByPayGiftId.HandleId, ConfigWeekCardByPayGiftId.LogPair);
				return null;
			}
			List<WeekCard> list = new List<WeekCard>();
			while (ConfigCommon.Step(ConfigWeekCardByPayGiftId.HandleId, false, ConfigWeekCardByPayGiftId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeekCardByPayGiftId.HandleId, 0, ConfigWeekCardByPayGiftId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeekCardByPayGiftId.HandleId, ConfigWeekCardByPayGiftId.LogPair);
					return null;
				}
				WeekCard rootAsWeekCard = WeekCard.GetRootAsWeekCard(new ByteBuffer(item2));
				list.Add(rootAsWeekCard);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardByPayGiftId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PayGiftId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeekCardByPayGiftId.HandleId, ConfigWeekCardByPayGiftId.LogPair);
			return list;
		}

		// Token: 0x040049F2 RID: 18930
		private const string DB = "db_weekcard.db";

		// Token: 0x040049F3 RID: 18931
		private const string FILE = "z.周卡.xlsx";

		// Token: 0x040049F4 RID: 18932
		private const string TABLE = "WeekCard";

		// Token: 0x040049F5 RID: 18933
		private const string COMMAND = "select BinData from `WeekCard` where PayGiftId=?";

		// Token: 0x040049F6 RID: 18934
		private const string KEY_PREFIX = "WeekCardByPayGiftId";

		// Token: 0x040049F7 RID: 18935
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049F8 RID: 18936
		private static int HandleId;
	}
}
