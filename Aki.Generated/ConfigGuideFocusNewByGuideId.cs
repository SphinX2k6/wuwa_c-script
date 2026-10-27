using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BD RID: 957
	public class ConfigGuideFocusNewByGuideId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001675 RID: 5749 RVA: 0x000D87B8 File Offset: 0x000D69B8
		static ConfigGuideFocusNewByGuideId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideFocusNewByGuideId.CreateStaticDefaultValue), new Action(ConfigGuideFocusNewByGuideId.ResetStaticDefaultValue));
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000D87D8 File Offset: 0x000D69D8
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

		// Token: 0x06001677 RID: 5751 RVA: 0x000D8857 File Offset: 0x000D6A57
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideFocusNewByGuideId.LogPair = null;
			ConfigGuideFocusNewByGuideId.HandleId = 0;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000D8865 File Offset: 0x000D6A65
		public static void Init()
		{
			ConfigGuideFocusNewByGuideId.HandleId = ConfigCommon.InitDataStatement(ConfigGuideFocusNewByGuideId.HandleId, "db_guide_new.db", "select BinData from `GuideFocusNew` where GuideId=?");
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000D8880 File Offset: 0x000D6A80
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

		// Token: 0x04001A0F RID: 6671
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A10 RID: 6672
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A11 RID: 6673
		private const string TABLE = "GuideFocusNew";

		// Token: 0x04001A12 RID: 6674
		private const string COMMAND = "select BinData from `GuideFocusNew` where GuideId=?";

		// Token: 0x04001A13 RID: 6675
		private const string KEY_PREFIX = "GuideFocusNewByGuideId";

		// Token: 0x04001A14 RID: 6676
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A15 RID: 6677
		private static int HandleId;
	}
}
