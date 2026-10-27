using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000334 RID: 820
	public class ConfigFloroRanchWeeklyChoiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x000C60FB File Offset: 0x000C42FB
		static ConfigFloroRanchWeeklyChoiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchWeeklyChoiceById.CreateStaticDefaultValue), new Action(ConfigFloroRanchWeeklyChoiceById.ResetStaticDefaultValue));
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000C611C File Offset: 0x000C431C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyChoiceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchWeeklyChoiceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchevent.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_事件.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchWeeklyChoice"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchWeeklyChoice` where Id=?")
			});
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000C619B File Offset: 0x000C439B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyChoiceById.LogPair = null;
			ConfigFloroRanchWeeklyChoiceById.HandleId = 0;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000C61A9 File Offset: 0x000C43A9
		public static void Init()
		{
			ConfigFloroRanchWeeklyChoiceById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchWeeklyChoiceById.HandleId, "db_flororanchevent.db", "select BinData from `FloroRanchWeeklyChoice` where Id=?");
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000C61C4 File Offset: 0x000C43C4
		public static FloroRanchWeeklyChoice? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchWeeklyChoiceById.HandleId, ConfigFloroRanchWeeklyChoiceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchWeeklyChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchWeeklyChoice?(FloroRanchWeeklyChoice.GetRootAsFloroRanchWeeklyChoice(configBuffer));
				}
			}
			ConfigFloroRanchWeeklyChoiceById.LogPair.Clear();
			ConfigFloroRanchWeeklyChoiceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchWeeklyChoiceById.HandleId, 1, p0Id, ConfigFloroRanchWeeklyChoiceById.LogPair) || ConfigCommon.Step(ConfigFloroRanchWeeklyChoiceById.HandleId, true, ConfigFloroRanchWeeklyChoiceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchWeeklyChoiceById.HandleId, ConfigFloroRanchWeeklyChoiceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchWeeklyChoiceById.HandleId, 0, ConfigFloroRanchWeeklyChoiceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchWeeklyChoiceById.HandleId, ConfigFloroRanchWeeklyChoiceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchWeeklyChoice rootAsFloroRanchWeeklyChoice = FloroRanchWeeklyChoice.GetRootAsFloroRanchWeeklyChoice(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchWeeklyChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchWeeklyChoiceById.HandleId, ConfigFloroRanchWeeklyChoiceById.LogPair);
			return new FloroRanchWeeklyChoice?(rootAsFloroRanchWeeklyChoice);
		}

		// Token: 0x04001650 RID: 5712
		private const string DB = "db_flororanchevent.db";

		// Token: 0x04001651 RID: 5713
		private const string FILE = "f.弗洛洛牧场_事件.xlsx";

		// Token: 0x04001652 RID: 5714
		private const string TABLE = "FloroRanchWeeklyChoice";

		// Token: 0x04001653 RID: 5715
		private const string COMMAND = "select BinData from `FloroRanchWeeklyChoice` where Id=?";

		// Token: 0x04001654 RID: 5716
		private const string KEY_PREFIX = "FloroRanchWeeklyChoiceById";

		// Token: 0x04001655 RID: 5717
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001656 RID: 5718
		private static int HandleId;
	}
}
