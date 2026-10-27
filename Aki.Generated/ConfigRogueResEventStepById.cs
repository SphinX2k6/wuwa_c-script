using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084A RID: 2122
	public class ConfigRogueResEventStepById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031CE RID: 12750 RVA: 0x00173120 File Offset: 0x00171320
		static ConfigRogueResEventStepById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventStepById.CreateStaticDefaultValue), new Action(ConfigRogueResEventStepById.ResetStaticDefaultValue));
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x00173140 File Offset: 0x00171340
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventStepById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventStepById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEventStep"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEventStep` where Id=?")
			});
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x001731BF File Offset: 0x001713BF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventStepById.LogPair = null;
			ConfigRogueResEventStepById.HandleId = 0;
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x001731CD File Offset: 0x001713CD
		public static void Init()
		{
			ConfigRogueResEventStepById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventStepById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventStep` where Id=?");
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x001731E8 File Offset: 0x001713E8
		public static RogueResEventStep? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventStepById.HandleId, ConfigRogueResEventStepById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventStepById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEventStep?(RogueResEventStep.GetRootAsRogueResEventStep(configBuffer));
				}
			}
			ConfigRogueResEventStepById.LogPair.Clear();
			ConfigRogueResEventStepById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEventStepById.HandleId, 1, p0Id, ConfigRogueResEventStepById.LogPair) || ConfigCommon.Step(ConfigRogueResEventStepById.HandleId, true, ConfigRogueResEventStepById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventStepById.HandleId, ConfigRogueResEventStepById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventStepById.HandleId, 0, ConfigRogueResEventStepById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventStepById.HandleId, ConfigRogueResEventStepById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEventStep rootAsRogueResEventStep = RogueResEventStep.GetRootAsRogueResEventStep(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventStepById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventStepById.HandleId, ConfigRogueResEventStepById.LogPair);
			return new RogueResEventStep?(rootAsRogueResEventStep);
		}

		// Token: 0x040039EC RID: 14828
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039ED RID: 14829
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039EE RID: 14830
		private const string TABLE = "RogueResEventStep";

		// Token: 0x040039EF RID: 14831
		private const string COMMAND = "select BinData from `RogueResEventStep` where Id=?";

		// Token: 0x040039F0 RID: 14832
		private const string KEY_PREFIX = "RogueResEventStepById";

		// Token: 0x040039F1 RID: 14833
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039F2 RID: 14834
		private static int HandleId;
	}
}
