using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B8 RID: 952
	public class ConfigGuideDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001657 RID: 5719 RVA: 0x000D7D54 File Offset: 0x000D5F54
		static ConfigGuideDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDataById.CreateStaticDefaultValue), new Action(ConfigGuideDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000D7D74 File Offset: 0x000D5F74
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "GuideData"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideData` where Id=?")
			});
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000D7DF3 File Offset: 0x000D5FF3
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDataById.LogPair = null;
			ConfigGuideDataById.HandleId = 0;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000D7E01 File Offset: 0x000D6001
		public static void Init()
		{
			ConfigGuideDataById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDataById.HandleId, "db_adventure_detect.db", "select BinData from `GuideData` where Id=?");
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x000D7E1C File Offset: 0x000D601C
		public static GuideData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideDataById.HandleId, ConfigGuideDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideData?(GuideData.GetRootAsGuideData(configBuffer));
				}
			}
			ConfigGuideDataById.LogPair.Clear();
			ConfigGuideDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuideDataById.HandleId, 1, p0Id, ConfigGuideDataById.LogPair) || ConfigCommon.Step(ConfigGuideDataById.HandleId, true, ConfigGuideDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideDataById.HandleId, ConfigGuideDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideDataById.HandleId, 0, ConfigGuideDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideDataById.HandleId, ConfigGuideDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideData rootAsGuideData = GuideData.GetRootAsGuideData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideDataById.HandleId, ConfigGuideDataById.LogPair);
			return new GuideData?(rootAsGuideData);
		}

		// Token: 0x040019EC RID: 6636
		private const string DB = "db_adventure_detect.db";

		// Token: 0x040019ED RID: 6637
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x040019EE RID: 6638
		private const string TABLE = "GuideData";

		// Token: 0x040019EF RID: 6639
		private const string COMMAND = "select BinData from `GuideData` where Id=?";

		// Token: 0x040019F0 RID: 6640
		private const string KEY_PREFIX = "GuideDataById";

		// Token: 0x040019F1 RID: 6641
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019F2 RID: 6642
		private static int HandleId;
	}
}
