using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000349 RID: 841
	public class ConfigFloroRanchWeeklyChoiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013BB RID: 5051 RVA: 0x000CC607 File Offset: 0x000CA807
		static ConfigFloroRanchWeeklyChoiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchWeeklyChoiceById.CreateStaticDefaultValue), new Action(ConfigFloroRanchWeeklyChoiceById.ResetStaticDefaultValue));
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000CC628 File Offset: 0x000CA828
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

		// Token: 0x060013BD RID: 5053 RVA: 0x000CC6A7 File Offset: 0x000CA8A7
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchWeeklyChoiceById.LogPair = null;
			ConfigFloroRanchWeeklyChoiceById.HandleId = 0;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000CC6B5 File Offset: 0x000CA8B5
		public static void Init()
		{
			ConfigFloroRanchWeeklyChoiceById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchWeeklyChoiceById.HandleId, "db_flororanchevent.db", "select BinData from `FloroRanchWeeklyChoice` where Id=?");
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000CC6D0 File Offset: 0x000CA8D0
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

		// Token: 0x040016E3 RID: 5859
		private const string DB = "db_flororanchevent.db";

		// Token: 0x040016E4 RID: 5860
		private const string FILE = "f.弗洛洛牧场_事件.xlsx";

		// Token: 0x040016E5 RID: 5861
		private const string TABLE = "FloroRanchWeeklyChoice";

		// Token: 0x040016E6 RID: 5862
		private const string COMMAND = "select BinData from `FloroRanchWeeklyChoice` where Id=?";

		// Token: 0x040016E7 RID: 5863
		private const string KEY_PREFIX = "FloroRanchWeeklyChoiceById";

		// Token: 0x040016E8 RID: 5864
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016E9 RID: 5865
		private static int HandleId;
	}
}
