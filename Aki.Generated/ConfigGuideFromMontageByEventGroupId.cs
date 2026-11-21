using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D4 RID: 980
	public class ConfigGuideFromMontageByEventGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016FF RID: 5887 RVA: 0x000DF154 File Offset: 0x000DD354
		static ConfigGuideFromMontageByEventGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideFromMontageByEventGroupId.CreateStaticDefaultValue), new Action(ConfigGuideFromMontageByEventGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000DF174 File Offset: 0x000DD374
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

		// Token: 0x06001701 RID: 5889 RVA: 0x000DF1F3 File Offset: 0x000DD3F3
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideFromMontageByEventGroupId.LogPair = null;
			ConfigGuideFromMontageByEventGroupId.HandleId = 0;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x000DF201 File Offset: 0x000DD401
		public static void Init()
		{
			ConfigGuideFromMontageByEventGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigGuideFromMontageByEventGroupId.HandleId, "db_guide_new.db", "select BinData from `GuideFromMontage` where EventGroupId=?");
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x000DF21C File Offset: 0x000DD41C
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

		// Token: 0x04001AB0 RID: 6832
		private const string DB = "db_guide_new.db";

		// Token: 0x04001AB1 RID: 6833
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AB2 RID: 6834
		private const string TABLE = "GuideFromMontage";

		// Token: 0x04001AB3 RID: 6835
		private const string COMMAND = "select BinData from `GuideFromMontage` where EventGroupId=?";

		// Token: 0x04001AB4 RID: 6836
		private const string KEY_PREFIX = "GuideFromMontageByEventGroupId";

		// Token: 0x04001AB5 RID: 6837
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AB6 RID: 6838
		private static int HandleId;
	}
}
