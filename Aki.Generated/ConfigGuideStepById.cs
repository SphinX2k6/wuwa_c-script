using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C2 RID: 962
	public class ConfigGuideStepById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001693 RID: 5779 RVA: 0x000D91B7 File Offset: 0x000D73B7
		static ConfigGuideStepById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideStepById.CreateStaticDefaultValue), new Action(ConfigGuideStepById.ResetStaticDefaultValue));
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x000D91D8 File Offset: 0x000D73D8
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideStepById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideStepById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideStep"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideStep` where Id=?")
			});
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000D9257 File Offset: 0x000D7457
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideStepById.LogPair = null;
			ConfigGuideStepById.HandleId = 0;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000D9265 File Offset: 0x000D7465
		public static void Init()
		{
			ConfigGuideStepById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideStepById.HandleId, "db_guide_new.db", "select BinData from `GuideStep` where Id=?");
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000D9280 File Offset: 0x000D7480
		public static GuideStep? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideStepById.HandleId, ConfigGuideStepById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideStepById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideStep?(GuideStep.GetRootAsGuideStep(configBuffer));
				}
			}
			ConfigGuideStepById.LogPair.Clear();
			ConfigGuideStepById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuideStepById.HandleId, 1, p0Id, ConfigGuideStepById.LogPair) || ConfigCommon.Step(ConfigGuideStepById.HandleId, true, ConfigGuideStepById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideStepById.HandleId, ConfigGuideStepById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideStepById.HandleId, 0, ConfigGuideStepById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideStepById.HandleId, ConfigGuideStepById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideStep rootAsGuideStep = GuideStep.GetRootAsGuideStep(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideStepById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideStepById.HandleId, ConfigGuideStepById.LogPair);
			return new GuideStep?(rootAsGuideStep);
		}

		// Token: 0x04001A32 RID: 6706
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A33 RID: 6707
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A34 RID: 6708
		private const string TABLE = "GuideStep";

		// Token: 0x04001A35 RID: 6709
		private const string COMMAND = "select BinData from `GuideStep` where Id=?";

		// Token: 0x04001A36 RID: 6710
		private const string KEY_PREFIX = "GuideStepById";

		// Token: 0x04001A37 RID: 6711
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A38 RID: 6712
		private static int HandleId;
	}
}
