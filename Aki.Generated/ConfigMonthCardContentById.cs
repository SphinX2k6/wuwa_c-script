using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055D RID: 1373
	public class ConfigMonthCardContentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600203B RID: 8251 RVA: 0x0010F954 File Offset: 0x0010DB54
		static ConfigMonthCardContentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonthCardContentById.CreateStaticDefaultValue), new Action(ConfigMonthCardContentById.ResetStaticDefaultValue));
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0010F974 File Offset: 0x0010DB74
		public static void CreateStaticDefaultValue()
		{
			ConfigMonthCardContentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonthCardContentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monthcardcontent.db"),
				new ValueTuple<string, object>("文件", "y.月卡.xlsx"),
				new ValueTuple<string, object>("表名", "MonthCardContent"),
				new ValueTuple<string, object>("语句", "select BinData from `MonthCardContent` where Id=?")
			});
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0010F9F3 File Offset: 0x0010DBF3
		public static void ResetStaticDefaultValue()
		{
			ConfigMonthCardContentById.LogPair = null;
			ConfigMonthCardContentById.HandleId = 0;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0010FA01 File Offset: 0x0010DC01
		public static void Init()
		{
			ConfigMonthCardContentById.HandleId = ConfigCommon.InitDataStatement(ConfigMonthCardContentById.HandleId, "db_monthcardcontent.db", "select BinData from `MonthCardContent` where Id=?");
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0010FA1C File Offset: 0x0010DC1C
		public static MonthCardContent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonthCardContentById.HandleId, ConfigMonthCardContentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonthCardContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonthCardContent?(MonthCardContent.GetRootAsMonthCardContent(configBuffer));
				}
			}
			ConfigMonthCardContentById.LogPair.Clear();
			ConfigMonthCardContentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonthCardContentById.HandleId, 1, p0Id, ConfigMonthCardContentById.LogPair) || ConfigCommon.Step(ConfigMonthCardContentById.HandleId, true, ConfigMonthCardContentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonthCardContentById.HandleId, ConfigMonthCardContentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonthCardContentById.HandleId, 0, ConfigMonthCardContentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonthCardContentById.HandleId, ConfigMonthCardContentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonthCardContent rootAsMonthCardContent = MonthCardContent.GetRootAsMonthCardContent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonthCardContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonthCardContentById.HandleId, ConfigMonthCardContentById.LogPair);
			return new MonthCardContent?(rootAsMonthCardContent);
		}

		// Token: 0x0400256F RID: 9583
		private const string DB = "db_monthcardcontent.db";

		// Token: 0x04002570 RID: 9584
		private const string FILE = "y.月卡.xlsx";

		// Token: 0x04002571 RID: 9585
		private const string TABLE = "MonthCardContent";

		// Token: 0x04002572 RID: 9586
		private const string COMMAND = "select BinData from `MonthCardContent` where Id=?";

		// Token: 0x04002573 RID: 9587
		private const string KEY_PREFIX = "MonthCardContentById";

		// Token: 0x04002574 RID: 9588
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002575 RID: 9589
		private static int HandleId;
	}
}
