using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B6A RID: 2922
	public class ConfigWeekCardContentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004491 RID: 17553 RVA: 0x001E120F File Offset: 0x001DF40F
		static ConfigWeekCardContentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeekCardContentById.CreateStaticDefaultValue), new Action(ConfigWeekCardContentById.ResetStaticDefaultValue));
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x001E1230 File Offset: 0x001DF430
		public static void CreateStaticDefaultValue()
		{
			ConfigWeekCardContentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeekCardContentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weekcard.db"),
				new ValueTuple<string, object>("文件", "z.周卡.xlsx"),
				new ValueTuple<string, object>("表名", "WeekCardContent"),
				new ValueTuple<string, object>("语句", "select BinData from `WeekCardContent` where Id=?")
			});
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x001E12AF File Offset: 0x001DF4AF
		public static void ResetStaticDefaultValue()
		{
			ConfigWeekCardContentById.LogPair = null;
			ConfigWeekCardContentById.HandleId = 0;
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x001E12BD File Offset: 0x001DF4BD
		public static void Init()
		{
			ConfigWeekCardContentById.HandleId = ConfigCommon.InitDataStatement(ConfigWeekCardContentById.HandleId, "db_weekcard.db", "select BinData from `WeekCardContent` where Id=?");
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x001E12D8 File Offset: 0x001DF4D8
		public static WeekCardContent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeekCardContentById.HandleId, ConfigWeekCardContentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeekCardContent?(WeekCardContent.GetRootAsWeekCardContent(configBuffer));
				}
			}
			ConfigWeekCardContentById.LogPair.Clear();
			ConfigWeekCardContentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeekCardContentById.HandleId, 1, p0Id, ConfigWeekCardContentById.LogPair) || ConfigCommon.Step(ConfigWeekCardContentById.HandleId, true, ConfigWeekCardContentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeekCardContentById.HandleId, ConfigWeekCardContentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeekCardContentById.HandleId, 0, ConfigWeekCardContentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeekCardContentById.HandleId, ConfigWeekCardContentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeekCardContent rootAsWeekCardContent = WeekCardContent.GetRootAsWeekCardContent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeekCardContentById.HandleId, ConfigWeekCardContentById.LogPair);
			return new WeekCardContent?(rootAsWeekCardContent);
		}

		// Token: 0x04004FCC RID: 20428
		private const string DB = "db_weekcard.db";

		// Token: 0x04004FCD RID: 20429
		private const string FILE = "z.周卡.xlsx";

		// Token: 0x04004FCE RID: 20430
		private const string TABLE = "WeekCardContent";

		// Token: 0x04004FCF RID: 20431
		private const string COMMAND = "select BinData from `WeekCardContent` where Id=?";

		// Token: 0x04004FD0 RID: 20432
		private const string KEY_PREFIX = "WeekCardContentById";

		// Token: 0x04004FD1 RID: 20433
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FD2 RID: 20434
		private static int HandleId;
	}
}
