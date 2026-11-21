using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F2 RID: 1522
	public class ConfigMultiPlatformGuideStepById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023B9 RID: 9145 RVA: 0x00126E50 File Offset: 0x00125050
		static ConfigMultiPlatformGuideStepById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiPlatformGuideStepById.CreateStaticDefaultValue), new Action(ConfigMultiPlatformGuideStepById.ResetStaticDefaultValue));
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00126E70 File Offset: 0x00125070
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

		// Token: 0x060023BB RID: 9147 RVA: 0x00126EEF File Offset: 0x001250EF
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiPlatformGuideStepById.LogPair = null;
			ConfigMultiPlatformGuideStepById.HandleId = 0;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00126EFD File Offset: 0x001250FD
		public static void Init()
		{
			ConfigMultiPlatformGuideStepById.HandleId = ConfigCommon.InitDataStatement(ConfigMultiPlatformGuideStepById.HandleId, "db_guide_new.db", "select BinData from `MultiPlatformGuideStep` where Id=?");
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00126F18 File Offset: 0x00125118
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

		// Token: 0x04002982 RID: 10626
		private const string DB = "db_guide_new.db";

		// Token: 0x04002983 RID: 10627
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04002984 RID: 10628
		private const string TABLE = "MultiPlatformGuideStep";

		// Token: 0x04002985 RID: 10629
		private const string COMMAND = "select BinData from `MultiPlatformGuideStep` where Id=?";

		// Token: 0x04002986 RID: 10630
		private const string KEY_PREFIX = "MultiPlatformGuideStepById";

		// Token: 0x04002987 RID: 10631
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002988 RID: 10632
		private static int HandleId;
	}
}
