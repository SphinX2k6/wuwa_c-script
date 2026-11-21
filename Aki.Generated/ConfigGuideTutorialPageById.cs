using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003DC RID: 988
	public class ConfigGuideTutorialPageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600172F RID: 5935 RVA: 0x000E0178 File Offset: 0x000DE378
		static ConfigGuideTutorialPageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideTutorialPageById.CreateStaticDefaultValue), new Action(ConfigGuideTutorialPageById.ResetStaticDefaultValue));
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000E0198 File Offset: 0x000DE398
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

		// Token: 0x06001731 RID: 5937 RVA: 0x000E0217 File Offset: 0x000DE417
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideTutorialPageById.LogPair = null;
			ConfigGuideTutorialPageById.HandleId = 0;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x000E0225 File Offset: 0x000DE425
		public static void Init()
		{
			ConfigGuideTutorialPageById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideTutorialPageById.HandleId, "db_guide_new.db", "select BinData from `GuideTutorialPage` where Id=?");
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000E0240 File Offset: 0x000DE440
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

		// Token: 0x04001AE8 RID: 6888
		private const string DB = "db_guide_new.db";

		// Token: 0x04001AE9 RID: 6889
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AEA RID: 6890
		private const string TABLE = "GuideTutorialPage";

		// Token: 0x04001AEB RID: 6891
		private const string COMMAND = "select BinData from `GuideTutorialPage` where Id=?";

		// Token: 0x04001AEC RID: 6892
		private const string KEY_PREFIX = "GuideTutorialPageById";

		// Token: 0x04001AED RID: 6893
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AEE RID: 6894
		private static int HandleId;
	}
}
