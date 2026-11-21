using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D3 RID: 979
	public class ConfigGuideFocusNewByGuideId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016F9 RID: 5881 RVA: 0x000DEF0C File Offset: 0x000DD10C
		static ConfigGuideFocusNewByGuideId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideFocusNewByGuideId.CreateStaticDefaultValue), new Action(ConfigGuideFocusNewByGuideId.ResetStaticDefaultValue));
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000DEF2C File Offset: 0x000DD12C
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideFocusNewByGuideId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideFocusNewByGuideId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideFocusNew"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideFocusNew` where GuideId=?")
			});
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000DEFAB File Offset: 0x000DD1AB
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideFocusNewByGuideId.LogPair = null;
			ConfigGuideFocusNewByGuideId.HandleId = 0;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x000DEFB9 File Offset: 0x000DD1B9
		public static void Init()
		{
			ConfigGuideFocusNewByGuideId.HandleId = ConfigCommon.InitDataStatement(ConfigGuideFocusNewByGuideId.HandleId, "db_guide_new.db", "select BinData from `GuideFocusNew` where GuideId=?");
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x000DEFD4 File Offset: 0x000DD1D4
		public static GuideFocusNew? GetConfig(int p0GuideId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideFocusNewByGuideId.HandleId, ConfigGuideFocusNewByGuideId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideFocusNewByGuideId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GuideId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideFocusNew?(GuideFocusNew.GetRootAsGuideFocusNew(configBuffer));
				}
			}
			ConfigGuideFocusNewByGuideId.LogPair.Clear();
			ConfigGuideFocusNewByGuideId.LogPair.Add(new ValueTuple<string, object>("GuideId", p0GuideId));
			if (!ConfigCommon.BindInt(ConfigGuideFocusNewByGuideId.HandleId, 1, p0GuideId, ConfigGuideFocusNewByGuideId.LogPair) || ConfigCommon.Step(ConfigGuideFocusNewByGuideId.HandleId, true, ConfigGuideFocusNewByGuideId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideFocusNewByGuideId.HandleId, ConfigGuideFocusNewByGuideId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideFocusNewByGuideId.HandleId, 0, ConfigGuideFocusNewByGuideId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideFocusNewByGuideId.HandleId, ConfigGuideFocusNewByGuideId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideFocusNew rootAsGuideFocusNew = GuideFocusNew.GetRootAsGuideFocusNew(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideFocusNewByGuideId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GuideId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideFocusNewByGuideId.HandleId, ConfigGuideFocusNewByGuideId.LogPair);
			return new GuideFocusNew?(rootAsGuideFocusNew);
		}

		// Token: 0x04001AA9 RID: 6825
		private const string DB = "db_guide_new.db";

		// Token: 0x04001AAA RID: 6826
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AAB RID: 6827
		private const string TABLE = "GuideFocusNew";

		// Token: 0x04001AAC RID: 6828
		private const string COMMAND = "select BinData from `GuideFocusNew` where GuideId=?";

		// Token: 0x04001AAD RID: 6829
		private const string KEY_PREFIX = "GuideFocusNewByGuideId";

		// Token: 0x04001AAE RID: 6830
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AAF RID: 6831
		private static int HandleId;
	}
}
