using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BE RID: 958
	public class ConfigGuideFromMontageByEventGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600167B RID: 5755 RVA: 0x000D8A00 File Offset: 0x000D6C00
		static ConfigGuideFromMontageByEventGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideFromMontageByEventGroupId.CreateStaticDefaultValue), new Action(ConfigGuideFromMontageByEventGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000D8A20 File Offset: 0x000D6C20
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideFromMontageByEventGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideFromMontageByEventGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideFromMontage"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideFromMontage` where EventGroupId=?")
			});
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000D8A9F File Offset: 0x000D6C9F
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideFromMontageByEventGroupId.LogPair = null;
			ConfigGuideFromMontageByEventGroupId.HandleId = 0;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000D8AAD File Offset: 0x000D6CAD
		public static void Init()
		{
			ConfigGuideFromMontageByEventGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigGuideFromMontageByEventGroupId.HandleId, "db_guide_new.db", "select BinData from `GuideFromMontage` where EventGroupId=?");
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x000D8AC8 File Offset: 0x000D6CC8
		public static GuideFromMontage? GetConfig(int p0EventGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideFromMontageByEventGroupId.HandleId, ConfigGuideFromMontageByEventGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideFromMontageByEventGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EventGroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideFromMontage?(GuideFromMontage.GetRootAsGuideFromMontage(configBuffer));
				}
			}
			ConfigGuideFromMontageByEventGroupId.LogPair.Clear();
			ConfigGuideFromMontageByEventGroupId.LogPair.Add(new ValueTuple<string, object>("EventGroupId", p0EventGroupId));
			if (!ConfigCommon.BindInt(ConfigGuideFromMontageByEventGroupId.HandleId, 1, p0EventGroupId, ConfigGuideFromMontageByEventGroupId.LogPair) || ConfigCommon.Step(ConfigGuideFromMontageByEventGroupId.HandleId, true, ConfigGuideFromMontageByEventGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideFromMontageByEventGroupId.HandleId, ConfigGuideFromMontageByEventGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideFromMontageByEventGroupId.HandleId, 0, ConfigGuideFromMontageByEventGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideFromMontageByEventGroupId.HandleId, ConfigGuideFromMontageByEventGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideFromMontage rootAsGuideFromMontage = GuideFromMontage.GetRootAsGuideFromMontage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideFromMontageByEventGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EventGroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideFromMontageByEventGroupId.HandleId, ConfigGuideFromMontageByEventGroupId.LogPair);
			return new GuideFromMontage?(rootAsGuideFromMontage);
		}

		// Token: 0x04001A16 RID: 6678
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A17 RID: 6679
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A18 RID: 6680
		private const string TABLE = "GuideFromMontage";

		// Token: 0x04001A19 RID: 6681
		private const string COMMAND = "select BinData from `GuideFromMontage` where EventGroupId=?";

		// Token: 0x04001A1A RID: 6682
		private const string KEY_PREFIX = "GuideFromMontageByEventGroupId";

		// Token: 0x04001A1B RID: 6683
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A1C RID: 6684
		private static int HandleId;
	}
}
