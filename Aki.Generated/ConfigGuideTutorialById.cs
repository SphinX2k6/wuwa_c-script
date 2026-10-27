using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C5 RID: 965
	public class ConfigGuideTutorialById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016A5 RID: 5797 RVA: 0x000D97DB File Offset: 0x000D79DB
		static ConfigGuideTutorialById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideTutorialById.CreateStaticDefaultValue), new Action(ConfigGuideTutorialById.ResetStaticDefaultValue));
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000D97FC File Offset: 0x000D79FC
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideTutorialById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideTutorialById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideTutorial"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideTutorial` where Id=?")
			});
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x000D987B File Offset: 0x000D7A7B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideTutorialById.LogPair = null;
			ConfigGuideTutorialById.HandleId = 0;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000D9889 File Offset: 0x000D7A89
		public static void Init()
		{
			ConfigGuideTutorialById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideTutorialById.HandleId, "db_guide_new.db", "select BinData from `GuideTutorial` where Id=?");
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000D98A4 File Offset: 0x000D7AA4
		public static GuideTutorial? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideTutorialById.HandleId, ConfigGuideTutorialById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideTutorialById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideTutorial?(GuideTutorial.GetRootAsGuideTutorial(configBuffer));
				}
			}
			ConfigGuideTutorialById.LogPair.Clear();
			ConfigGuideTutorialById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuideTutorialById.HandleId, 1, p0Id, ConfigGuideTutorialById.LogPair) || ConfigCommon.Step(ConfigGuideTutorialById.HandleId, true, ConfigGuideTutorialById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideTutorialById.HandleId, ConfigGuideTutorialById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideTutorialById.HandleId, 0, ConfigGuideTutorialById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideTutorialById.HandleId, ConfigGuideTutorialById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideTutorial rootAsGuideTutorial = GuideTutorial.GetRootAsGuideTutorial(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideTutorialById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideTutorialById.HandleId, ConfigGuideTutorialById.LogPair);
			return new GuideTutorial?(rootAsGuideTutorial);
		}

		// Token: 0x04001A47 RID: 6727
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A48 RID: 6728
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A49 RID: 6729
		private const string TABLE = "GuideTutorial";

		// Token: 0x04001A4A RID: 6730
		private const string COMMAND = "select BinData from `GuideTutorial` where Id=?";

		// Token: 0x04001A4B RID: 6731
		private const string KEY_PREFIX = "GuideTutorialById";

		// Token: 0x04001A4C RID: 6732
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A4D RID: 6733
		private static int HandleId;
	}
}
