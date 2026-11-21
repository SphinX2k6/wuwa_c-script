using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000573 RID: 1395
	public class ConfigMonthCardContentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020BF RID: 8383 RVA: 0x001160A8 File Offset: 0x001142A8
		static ConfigMonthCardContentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonthCardContentById.CreateStaticDefaultValue), new Action(ConfigMonthCardContentById.ResetStaticDefaultValue));
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x001160C8 File Offset: 0x001142C8
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

		// Token: 0x060020C1 RID: 8385 RVA: 0x00116147 File Offset: 0x00114347
		public static void ResetStaticDefaultValue()
		{
			ConfigMonthCardContentById.LogPair = null;
			ConfigMonthCardContentById.HandleId = 0;
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00116155 File Offset: 0x00114355
		public static void Init()
		{
			ConfigMonthCardContentById.HandleId = ConfigCommon.InitDataStatement(ConfigMonthCardContentById.HandleId, "db_monthcardcontent.db", "select BinData from `MonthCardContent` where Id=?");
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00116170 File Offset: 0x00114370
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

		// Token: 0x04002609 RID: 9737
		private const string DB = "db_monthcardcontent.db";

		// Token: 0x0400260A RID: 9738
		private const string FILE = "y.月卡.xlsx";

		// Token: 0x0400260B RID: 9739
		private const string TABLE = "MonthCardContent";

		// Token: 0x0400260C RID: 9740
		private const string COMMAND = "select BinData from `MonthCardContent` where Id=?";

		// Token: 0x0400260D RID: 9741
		private const string KEY_PREFIX = "MonthCardContentById";

		// Token: 0x0400260E RID: 9742
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400260F RID: 9743
		private static int HandleId;
	}
}
