using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DA RID: 1498
	public class ConfigMultiPlatformGuideStepById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002329 RID: 9001 RVA: 0x001203D4 File Offset: 0x0011E5D4
		static ConfigMultiPlatformGuideStepById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiPlatformGuideStepById.CreateStaticDefaultValue), new Action(ConfigMultiPlatformGuideStepById.ResetStaticDefaultValue));
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x001203F4 File Offset: 0x0011E5F4
		public static void CreateStaticDefaultValue()
		{
			ConfigMultiPlatformGuideStepById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMultiPlatformGuideStepById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "MultiPlatformGuideStep"),
				new ValueTuple<string, object>("语句", "select BinData from `MultiPlatformGuideStep` where Id=?")
			});
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00120473 File Offset: 0x0011E673
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiPlatformGuideStepById.LogPair = null;
			ConfigMultiPlatformGuideStepById.HandleId = 0;
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00120481 File Offset: 0x0011E681
		public static void Init()
		{
			ConfigMultiPlatformGuideStepById.HandleId = ConfigCommon.InitDataStatement(ConfigMultiPlatformGuideStepById.HandleId, "db_guide_new.db", "select BinData from `MultiPlatformGuideStep` where Id=?");
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0012049C File Offset: 0x0011E69C
		public static MultiPlatformGuideStep? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMultiPlatformGuideStepById.HandleId, ConfigMultiPlatformGuideStepById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MultiPlatformGuideStepById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MultiPlatformGuideStep?(MultiPlatformGuideStep.GetRootAsMultiPlatformGuideStep(configBuffer));
				}
			}
			ConfigMultiPlatformGuideStepById.LogPair.Clear();
			ConfigMultiPlatformGuideStepById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMultiPlatformGuideStepById.HandleId, 1, p0Id, ConfigMultiPlatformGuideStepById.LogPair) || ConfigCommon.Step(ConfigMultiPlatformGuideStepById.HandleId, true, ConfigMultiPlatformGuideStepById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMultiPlatformGuideStepById.HandleId, ConfigMultiPlatformGuideStepById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMultiPlatformGuideStepById.HandleId, 0, ConfigMultiPlatformGuideStepById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMultiPlatformGuideStepById.HandleId, ConfigMultiPlatformGuideStepById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MultiPlatformGuideStep rootAsMultiPlatformGuideStep = MultiPlatformGuideStep.GetRootAsMultiPlatformGuideStep(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MultiPlatformGuideStepById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMultiPlatformGuideStepById.HandleId, ConfigMultiPlatformGuideStepById.LogPair);
			return new MultiPlatformGuideStep?(rootAsMultiPlatformGuideStep);
		}

		// Token: 0x040028DA RID: 10458
		private const string DB = "db_guide_new.db";

		// Token: 0x040028DB RID: 10459
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x040028DC RID: 10460
		private const string TABLE = "MultiPlatformGuideStep";

		// Token: 0x040028DD RID: 10461
		private const string COMMAND = "select BinData from `MultiPlatformGuideStep` where Id=?";

		// Token: 0x040028DE RID: 10462
		private const string KEY_PREFIX = "MultiPlatformGuideStepById";

		// Token: 0x040028DF RID: 10463
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028E0 RID: 10464
		private static int HandleId;
	}
}
