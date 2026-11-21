using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D8 RID: 984
	public class ConfigGuideStepById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001717 RID: 5911 RVA: 0x000DF90B File Offset: 0x000DDB0B
		static ConfigGuideStepById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideStepById.CreateStaticDefaultValue), new Action(ConfigGuideStepById.ResetStaticDefaultValue));
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000DF92C File Offset: 0x000DDB2C
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

		// Token: 0x06001719 RID: 5913 RVA: 0x000DF9AB File Offset: 0x000DDBAB
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideStepById.LogPair = null;
			ConfigGuideStepById.HandleId = 0;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000DF9B9 File Offset: 0x000DDBB9
		public static void Init()
		{
			ConfigGuideStepById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideStepById.HandleId, "db_guide_new.db", "select BinData from `GuideStep` where Id=?");
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000DF9D4 File Offset: 0x000DDBD4
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

		// Token: 0x04001ACC RID: 6860
		private const string DB = "db_guide_new.db";

		// Token: 0x04001ACD RID: 6861
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001ACE RID: 6862
		private const string TABLE = "GuideStep";

		// Token: 0x04001ACF RID: 6863
		private const string COMMAND = "select BinData from `GuideStep` where Id=?";

		// Token: 0x04001AD0 RID: 6864
		private const string KEY_PREFIX = "GuideStepById";

		// Token: 0x04001AD1 RID: 6865
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AD2 RID: 6866
		private static int HandleId;
	}
}
