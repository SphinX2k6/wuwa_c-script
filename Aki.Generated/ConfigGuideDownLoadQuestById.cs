using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D0 RID: 976
	public class ConfigGuideDownLoadQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016E7 RID: 5863 RVA: 0x000DE883 File Offset: 0x000DCA83
		static ConfigGuideDownLoadQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDownLoadQuestById.CreateStaticDefaultValue), new Action(ConfigGuideDownLoadQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x000DE8A4 File Offset: 0x000DCAA4
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideDownLoadQuestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideDownLoadQuestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "GuideDownLoadQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideDownLoadQuest` where Id=?")
			});
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x000DE923 File Offset: 0x000DCB23
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDownLoadQuestById.LogPair = null;
			ConfigGuideDownLoadQuestById.HandleId = 0;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x000DE931 File Offset: 0x000DCB31
		public static void Init()
		{
			ConfigGuideDownLoadQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDownLoadQuestById.HandleId, "db_download.db", "select BinData from `GuideDownLoadQuest` where Id=?");
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x000DE94C File Offset: 0x000DCB4C
		public static GuideDownLoadQuest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideDownLoadQuestById.HandleId, ConfigGuideDownLoadQuestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideDownLoadQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideDownLoadQuest?(GuideDownLoadQuest.GetRootAsGuideDownLoadQuest(configBuffer));
				}
			}
			ConfigGuideDownLoadQuestById.LogPair.Clear();
			ConfigGuideDownLoadQuestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuideDownLoadQuestById.HandleId, 1, p0Id, ConfigGuideDownLoadQuestById.LogPair) || ConfigCommon.Step(ConfigGuideDownLoadQuestById.HandleId, true, ConfigGuideDownLoadQuestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideDownLoadQuestById.HandleId, ConfigGuideDownLoadQuestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideDownLoadQuestById.HandleId, 0, ConfigGuideDownLoadQuestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideDownLoadQuestById.HandleId, ConfigGuideDownLoadQuestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideDownLoadQuest rootAsGuideDownLoadQuest = GuideDownLoadQuest.GetRootAsGuideDownLoadQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideDownLoadQuestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideDownLoadQuestById.HandleId, ConfigGuideDownLoadQuestById.LogPair);
			return new GuideDownLoadQuest?(rootAsGuideDownLoadQuest);
		}

		// Token: 0x04001A94 RID: 6804
		private const string DB = "db_download.db";

		// Token: 0x04001A95 RID: 6805
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04001A96 RID: 6806
		private const string TABLE = "GuideDownLoadQuest";

		// Token: 0x04001A97 RID: 6807
		private const string COMMAND = "select BinData from `GuideDownLoadQuest` where Id=?";

		// Token: 0x04001A98 RID: 6808
		private const string KEY_PREFIX = "GuideDownLoadQuestById";

		// Token: 0x04001A99 RID: 6809
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A9A RID: 6810
		private static int HandleId;
	}
}
