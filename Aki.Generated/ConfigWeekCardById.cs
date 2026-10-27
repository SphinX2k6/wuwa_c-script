using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A93 RID: 2707
	public class ConfigWeekCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F86 RID: 16262 RVA: 0x001C1883 File Offset: 0x001BFA83
		static ConfigWeekCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeekCardById.CreateStaticDefaultValue), new Action(ConfigWeekCardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x001C18A4 File Offset: 0x001BFAA4
		public static void CreateStaticDefaultValue()
		{
			ConfigWeekCardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeekCardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weekcard.db"),
				new ValueTuple<string, object>("文件", "z.周卡.xlsx"),
				new ValueTuple<string, object>("表名", "WeekCard"),
				new ValueTuple<string, object>("语句", "select BinData from `WeekCard` where Id=?")
			});
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x001C1923 File Offset: 0x001BFB23
		public static void ResetStaticDefaultValue()
		{
			ConfigWeekCardById.LogPair = null;
			ConfigWeekCardById.HandleId = 0;
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x001C1931 File Offset: 0x001BFB31
		public static void Init()
		{
			ConfigWeekCardById.HandleId = ConfigCommon.InitDataStatement(ConfigWeekCardById.HandleId, "db_weekcard.db", "select BinData from `WeekCard` where Id=?");
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x001C194C File Offset: 0x001BFB4C
		public static WeekCard? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeekCardById.HandleId, ConfigWeekCardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeekCard?(WeekCard.GetRootAsWeekCard(configBuffer));
				}
			}
			ConfigWeekCardById.LogPair.Clear();
			ConfigWeekCardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeekCardById.HandleId, 1, p0Id, ConfigWeekCardById.LogPair) || ConfigCommon.Step(ConfigWeekCardById.HandleId, true, ConfigWeekCardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeekCardById.HandleId, ConfigWeekCardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeekCardById.HandleId, 0, ConfigWeekCardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeekCardById.HandleId, ConfigWeekCardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeekCard rootAsWeekCard = WeekCard.GetRootAsWeekCard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeekCardById.HandleId, ConfigWeekCardById.LogPair);
			return new WeekCard?(rootAsWeekCard);
		}

		// Token: 0x040049EB RID: 18923
		private const string DB = "db_weekcard.db";

		// Token: 0x040049EC RID: 18924
		private const string FILE = "z.周卡.xlsx";

		// Token: 0x040049ED RID: 18925
		private const string TABLE = "WeekCard";

		// Token: 0x040049EE RID: 18926
		private const string COMMAND = "select BinData from `WeekCard` where Id=?";

		// Token: 0x040049EF RID: 18927
		private const string KEY_PREFIX = "WeekCardById";

		// Token: 0x040049F0 RID: 18928
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049F1 RID: 18929
		private static int HandleId;
	}
}
