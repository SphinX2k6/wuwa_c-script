using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C3 RID: 963
	public class ConfigGuideTipsByGuideId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001699 RID: 5785 RVA: 0x000D9400 File Offset: 0x000D7600
		static ConfigGuideTipsByGuideId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideTipsByGuideId.CreateStaticDefaultValue), new Action(ConfigGuideTipsByGuideId.ResetStaticDefaultValue));
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000D9420 File Offset: 0x000D7620
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

		// Token: 0x0600169B RID: 5787 RVA: 0x000D949F File Offset: 0x000D769F
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideTipsByGuideId.LogPair = null;
			ConfigGuideTipsByGuideId.HandleId = 0;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000D94AD File Offset: 0x000D76AD
		public static void Init()
		{
			ConfigGuideTipsByGuideId.HandleId = ConfigCommon.InitDataStatement(ConfigGuideTipsByGuideId.HandleId, "db_guide_new.db", "select BinData from `GuideTips` where GuideId=?");
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000D94C8 File Offset: 0x000D76C8
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

		// Token: 0x04001A39 RID: 6713
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A3A RID: 6714
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A3B RID: 6715
		private const string TABLE = "GuideTips";

		// Token: 0x04001A3C RID: 6716
		private const string COMMAND = "select BinData from `GuideTips` where GuideId=?";

		// Token: 0x04001A3D RID: 6717
		private const string KEY_PREFIX = "GuideTipsByGuideId";

		// Token: 0x04001A3E RID: 6718
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A3F RID: 6719
		private static int HandleId;
	}
}
