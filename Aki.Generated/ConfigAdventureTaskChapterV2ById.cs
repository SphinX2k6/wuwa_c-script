using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005F RID: 95
	public class ConfigAdventureTaskChapterV2ById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00066468 File Offset: 0x00064668
		static ConfigAdventureTaskChapterV2ById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskChapterV2ById.CreateStaticDefaultValue), new Action(ConfigAdventureTaskChapterV2ById.ResetStaticDefaultValue));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00066488 File Offset: 0x00064688
		public static void CreateStaticDefaultValue()
		{
			ConfigAdventureTaskChapterV2ById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdventureTaskChapterV2ById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手开拓任务活动.xlsx"),
				new ValueTuple<string, object>("表名", "AdventureTaskChapterV2"),
				new ValueTuple<string, object>("语句", "select BinData from `AdventureTaskChapterV2` where Id=?")
			});
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00066507 File Offset: 0x00064707
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskChapterV2ById.LogPair = null;
			ConfigAdventureTaskChapterV2ById.HandleId = 0;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00066515 File Offset: 0x00064715
		public static void Init()
		{
			ConfigAdventureTaskChapterV2ById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskChapterV2ById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `AdventureTaskChapterV2` where Id=?");
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00066530 File Offset: 0x00064730
		public static AdventureTaskChapterV2? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdventureTaskChapterV2ById.HandleId, ConfigAdventureTaskChapterV2ById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskChapterV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdventureTaskChapterV2?(AdventureTaskChapterV2.GetRootAsAdventureTaskChapterV2(configBuffer));
				}
			}
			ConfigAdventureTaskChapterV2ById.LogPair.Clear();
			ConfigAdventureTaskChapterV2ById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdventureTaskChapterV2ById.HandleId, 1, p0Id, ConfigAdventureTaskChapterV2ById.LogPair) || ConfigCommon.Step(ConfigAdventureTaskChapterV2ById.HandleId, true, ConfigAdventureTaskChapterV2ById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdventureTaskChapterV2ById.HandleId, ConfigAdventureTaskChapterV2ById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdventureTaskChapterV2ById.HandleId, 0, ConfigAdventureTaskChapterV2ById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdventureTaskChapterV2ById.HandleId, ConfigAdventureTaskChapterV2ById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdventureTaskChapterV2 rootAsAdventureTaskChapterV = AdventureTaskChapterV2.GetRootAsAdventureTaskChapterV2(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskChapterV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdventureTaskChapterV2ById.HandleId, ConfigAdventureTaskChapterV2ById.LogPair);
			return new AdventureTaskChapterV2?(rootAsAdventureTaskChapterV);
		}

		// Token: 0x0400027D RID: 637
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x0400027E RID: 638
		private const string FILE = "x.新手开拓任务活动.xlsx";

		// Token: 0x0400027F RID: 639
		private const string TABLE = "AdventureTaskChapterV2";

		// Token: 0x04000280 RID: 640
		private const string COMMAND = "select BinData from `AdventureTaskChapterV2` where Id=?";

		// Token: 0x04000281 RID: 641
		private const string KEY_PREFIX = "AdventureTaskChapterV2ById";

		// Token: 0x04000282 RID: 642
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000283 RID: 643
		private static int HandleId;
	}
}
