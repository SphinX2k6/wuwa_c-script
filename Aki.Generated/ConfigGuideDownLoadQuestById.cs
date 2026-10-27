using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BA RID: 954
	public class ConfigGuideDownLoadQuestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001663 RID: 5731 RVA: 0x000D812F File Offset: 0x000D632F
		static ConfigGuideDownLoadQuestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDownLoadQuestById.CreateStaticDefaultValue), new Action(ConfigGuideDownLoadQuestById.ResetStaticDefaultValue));
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000D8150 File Offset: 0x000D6350
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

		// Token: 0x06001665 RID: 5733 RVA: 0x000D81CF File Offset: 0x000D63CF
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDownLoadQuestById.LogPair = null;
			ConfigGuideDownLoadQuestById.HandleId = 0;
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000D81DD File Offset: 0x000D63DD
		public static void Init()
		{
			ConfigGuideDownLoadQuestById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDownLoadQuestById.HandleId, "db_download.db", "select BinData from `GuideDownLoadQuest` where Id=?");
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000D81F8 File Offset: 0x000D63F8
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

		// Token: 0x040019FA RID: 6650
		private const string DB = "db_download.db";

		// Token: 0x040019FB RID: 6651
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x040019FC RID: 6652
		private const string TABLE = "GuideDownLoadQuest";

		// Token: 0x040019FD RID: 6653
		private const string COMMAND = "select BinData from `GuideDownLoadQuest` where Id=?";

		// Token: 0x040019FE RID: 6654
		private const string KEY_PREFIX = "GuideDownLoadQuestById";

		// Token: 0x040019FF RID: 6655
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A00 RID: 6656
		private static int HandleId;
	}
}
