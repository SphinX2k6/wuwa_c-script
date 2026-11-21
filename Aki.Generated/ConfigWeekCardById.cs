using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B68 RID: 2920
	public class ConfigWeekCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004484 RID: 17540 RVA: 0x001E0C17 File Offset: 0x001DEE17
		static ConfigWeekCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeekCardById.CreateStaticDefaultValue), new Action(ConfigWeekCardById.ResetStaticDefaultValue));
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x001E0C38 File Offset: 0x001DEE38
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

		// Token: 0x06004486 RID: 17542 RVA: 0x001E0CB7 File Offset: 0x001DEEB7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeekCardById.LogPair = null;
			ConfigWeekCardById.HandleId = 0;
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x001E0CC5 File Offset: 0x001DEEC5
		public static void Init()
		{
			ConfigWeekCardById.HandleId = ConfigCommon.InitDataStatement(ConfigWeekCardById.HandleId, "db_weekcard.db", "select BinData from `WeekCard` where Id=?");
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x001E0CE0 File Offset: 0x001DEEE0
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

		// Token: 0x04004FBE RID: 20414
		private const string DB = "db_weekcard.db";

		// Token: 0x04004FBF RID: 20415
		private const string FILE = "z.周卡.xlsx";

		// Token: 0x04004FC0 RID: 20416
		private const string TABLE = "WeekCard";

		// Token: 0x04004FC1 RID: 20417
		private const string COMMAND = "select BinData from `WeekCard` where Id=?";

		// Token: 0x04004FC2 RID: 20418
		private const string KEY_PREFIX = "WeekCardById";

		// Token: 0x04004FC3 RID: 20419
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FC4 RID: 20420
		private static int HandleId;
	}
}
