using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C6 RID: 966
	public class ConfigGuideTutorialPageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016AB RID: 5803 RVA: 0x000D9A24 File Offset: 0x000D7C24
		static ConfigGuideTutorialPageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideTutorialPageById.CreateStaticDefaultValue), new Action(ConfigGuideTutorialPageById.ResetStaticDefaultValue));
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x000D9A44 File Offset: 0x000D7C44
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideTutorialPageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideTutorialPageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideTutorialPage"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideTutorialPage` where Id=?")
			});
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x000D9AC3 File Offset: 0x000D7CC3
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideTutorialPageById.LogPair = null;
			ConfigGuideTutorialPageById.HandleId = 0;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x000D9AD1 File Offset: 0x000D7CD1
		public static void Init()
		{
			ConfigGuideTutorialPageById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideTutorialPageById.HandleId, "db_guide_new.db", "select BinData from `GuideTutorialPage` where Id=?");
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x000D9AEC File Offset: 0x000D7CEC
		public static GuideTutorialPage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideTutorialPageById.HandleId, ConfigGuideTutorialPageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideTutorialPageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideTutorialPage?(GuideTutorialPage.GetRootAsGuideTutorialPage(configBuffer));
				}
			}
			ConfigGuideTutorialPageById.LogPair.Clear();
			ConfigGuideTutorialPageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuideTutorialPageById.HandleId, 1, p0Id, ConfigGuideTutorialPageById.LogPair) || ConfigCommon.Step(ConfigGuideTutorialPageById.HandleId, true, ConfigGuideTutorialPageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideTutorialPageById.HandleId, ConfigGuideTutorialPageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideTutorialPageById.HandleId, 0, ConfigGuideTutorialPageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideTutorialPageById.HandleId, ConfigGuideTutorialPageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideTutorialPage rootAsGuideTutorialPage = GuideTutorialPage.GetRootAsGuideTutorialPage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideTutorialPageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideTutorialPageById.HandleId, ConfigGuideTutorialPageById.LogPair);
			return new GuideTutorialPage?(rootAsGuideTutorialPage);
		}

		// Token: 0x04001A4E RID: 6734
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A4F RID: 6735
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A50 RID: 6736
		private const string TABLE = "GuideTutorialPage";

		// Token: 0x04001A51 RID: 6737
		private const string COMMAND = "select BinData from `GuideTutorialPage` where Id=?";

		// Token: 0x04001A52 RID: 6738
		private const string KEY_PREFIX = "GuideTutorialPageById";

		// Token: 0x04001A53 RID: 6739
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A54 RID: 6740
		private static int HandleId;
	}
}
