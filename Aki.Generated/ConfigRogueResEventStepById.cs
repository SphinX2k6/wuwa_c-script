using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000866 RID: 2150
	public class ConfigRogueResEventStepById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003276 RID: 12918 RVA: 0x0017A408 File Offset: 0x00178608
		static ConfigRogueResEventStepById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventStepById.CreateStaticDefaultValue), new Action(ConfigRogueResEventStepById.ResetStaticDefaultValue));
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x0017A428 File Offset: 0x00178628
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

		// Token: 0x06003278 RID: 12920 RVA: 0x0017A4A7 File Offset: 0x001786A7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventStepById.LogPair = null;
			ConfigRogueResEventStepById.HandleId = 0;
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x0017A4B5 File Offset: 0x001786B5
		public static void Init()
		{
			ConfigRogueResEventStepById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventStepById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventStep` where Id=?");
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x0017A4D0 File Offset: 0x001786D0
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

		// Token: 0x04003AB0 RID: 15024
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AB1 RID: 15025
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AB2 RID: 15026
		private const string TABLE = "RogueResEventStep";

		// Token: 0x04003AB3 RID: 15027
		private const string COMMAND = "select BinData from `RogueResEventStep` where Id=?";

		// Token: 0x04003AB4 RID: 15028
		private const string KEY_PREFIX = "RogueResEventStepById";

		// Token: 0x04003AB5 RID: 15029
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AB6 RID: 15030
		private static int HandleId;
	}
}
