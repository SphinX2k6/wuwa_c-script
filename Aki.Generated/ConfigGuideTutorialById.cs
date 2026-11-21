using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DB RID: 987
	public class ConfigGuideTutorialById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x000DFF2F File Offset: 0x000DE12F
		static ConfigGuideTutorialById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideTutorialById.CreateStaticDefaultValue), new Action(ConfigGuideTutorialById.ResetStaticDefaultValue));
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000DFF50 File Offset: 0x000DE150
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

		// Token: 0x0600172B RID: 5931 RVA: 0x000DFFCF File Offset: 0x000DE1CF
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideTutorialById.LogPair = null;
			ConfigGuideTutorialById.HandleId = 0;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x000DFFDD File Offset: 0x000DE1DD
		public static void Init()
		{
			ConfigGuideTutorialById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideTutorialById.HandleId, "db_guide_new.db", "select BinData from `GuideTutorial` where Id=?");
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000DFFF8 File Offset: 0x000DE1F8
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

		// Token: 0x04001AE1 RID: 6881
		private const string DB = "db_guide_new.db";

		// Token: 0x04001AE2 RID: 6882
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AE3 RID: 6883
		private const string TABLE = "GuideTutorial";

		// Token: 0x04001AE4 RID: 6884
		private const string COMMAND = "select BinData from `GuideTutorial` where Id=?";

		// Token: 0x04001AE5 RID: 6885
		private const string KEY_PREFIX = "GuideTutorialById";

		// Token: 0x04001AE6 RID: 6886
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AE7 RID: 6887
		private static int HandleId;
	}
}
