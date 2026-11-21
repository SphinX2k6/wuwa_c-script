using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D9 RID: 985
	public class ConfigGuideTipsByGuideId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600171D RID: 5917 RVA: 0x000DFB54 File Offset: 0x000DDD54
		static ConfigGuideTipsByGuideId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideTipsByGuideId.CreateStaticDefaultValue), new Action(ConfigGuideTipsByGuideId.ResetStaticDefaultValue));
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x000DFB74 File Offset: 0x000DDD74
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideTipsByGuideId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideTipsByGuideId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideTips"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideTips` where GuideId=?")
			});
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000DFBF3 File Offset: 0x000DDDF3
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideTipsByGuideId.LogPair = null;
			ConfigGuideTipsByGuideId.HandleId = 0;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000DFC01 File Offset: 0x000DDE01
		public static void Init()
		{
			ConfigGuideTipsByGuideId.HandleId = ConfigCommon.InitDataStatement(ConfigGuideTipsByGuideId.HandleId, "db_guide_new.db", "select BinData from `GuideTips` where GuideId=?");
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000DFC1C File Offset: 0x000DDE1C
		public static GuideTips? GetConfig(int p0GuideId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideTipsByGuideId.HandleId, ConfigGuideTipsByGuideId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideTipsByGuideId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GuideId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideTips?(GuideTips.GetRootAsGuideTips(configBuffer));
				}
			}
			ConfigGuideTipsByGuideId.LogPair.Clear();
			ConfigGuideTipsByGuideId.LogPair.Add(new ValueTuple<string, object>("GuideId", p0GuideId));
			if (!ConfigCommon.BindInt(ConfigGuideTipsByGuideId.HandleId, 1, p0GuideId, ConfigGuideTipsByGuideId.LogPair) || ConfigCommon.Step(ConfigGuideTipsByGuideId.HandleId, true, ConfigGuideTipsByGuideId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideTipsByGuideId.HandleId, ConfigGuideTipsByGuideId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideTipsByGuideId.HandleId, 0, ConfigGuideTipsByGuideId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideTipsByGuideId.HandleId, ConfigGuideTipsByGuideId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideTips rootAsGuideTips = GuideTips.GetRootAsGuideTips(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideTipsByGuideId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GuideId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideTipsByGuideId.HandleId, ConfigGuideTipsByGuideId.LogPair);
			return new GuideTips?(rootAsGuideTips);
		}

		// Token: 0x04001AD3 RID: 6867
		private const string DB = "db_guide_new.db";

		// Token: 0x04001AD4 RID: 6868
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AD5 RID: 6869
		private const string TABLE = "GuideTips";

		// Token: 0x04001AD6 RID: 6870
		private const string COMMAND = "select BinData from `GuideTips` where GuideId=?";

		// Token: 0x04001AD7 RID: 6871
		private const string KEY_PREFIX = "GuideTipsByGuideId";

		// Token: 0x04001AD8 RID: 6872
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AD9 RID: 6873
		private static int HandleId;
	}
}
