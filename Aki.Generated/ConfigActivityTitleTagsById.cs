using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005F RID: 95
	public class ConfigActivityTitleTagsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00069C54 File Offset: 0x00067E54
		static ConfigActivityTitleTagsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityTitleTagsById.CreateStaticDefaultValue), new Action(ConfigActivityTitleTagsById.ResetStaticDefaultValue));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00069C74 File Offset: 0x00067E74
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityTitleTagsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityTitleTagsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityTitleTags"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityTitleTags` where Id=?")
			});
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00069CF3 File Offset: 0x00067EF3
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityTitleTagsById.LogPair = null;
			ConfigActivityTitleTagsById.HandleId = 0;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00069D01 File Offset: 0x00067F01
		public static void Init()
		{
			ConfigActivityTitleTagsById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityTitleTagsById.HandleId, "db_activity.db", "select BinData from `ActivityTitleTags` where Id=?");
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00069D1C File Offset: 0x00067F1C
		public static ActivityTitleTags? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityTitleTagsById.HandleId, ConfigActivityTitleTagsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityTitleTagsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityTitleTags?(ActivityTitleTags.GetRootAsActivityTitleTags(configBuffer));
				}
			}
			ConfigActivityTitleTagsById.LogPair.Clear();
			ConfigActivityTitleTagsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityTitleTagsById.HandleId, 1, p0Id, ConfigActivityTitleTagsById.LogPair) || ConfigCommon.Step(ConfigActivityTitleTagsById.HandleId, true, ConfigActivityTitleTagsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityTitleTagsById.HandleId, ConfigActivityTitleTagsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityTitleTagsById.HandleId, 0, ConfigActivityTitleTagsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityTitleTagsById.HandleId, ConfigActivityTitleTagsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityTitleTags rootAsActivityTitleTags = ActivityTitleTags.GetRootAsActivityTitleTags(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityTitleTagsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityTitleTagsById.HandleId, ConfigActivityTitleTagsById.LogPair);
			return new ActivityTitleTags?(rootAsActivityTitleTags);
		}

		// Token: 0x0400027D RID: 637
		private const string DB = "db_activity.db";

		// Token: 0x0400027E RID: 638
		private const string FILE = "h.活动.xlsx";

		// Token: 0x0400027F RID: 639
		private const string TABLE = "ActivityTitleTags";

		// Token: 0x04000280 RID: 640
		private const string COMMAND = "select BinData from `ActivityTitleTags` where Id=?";

		// Token: 0x04000281 RID: 641
		private const string KEY_PREFIX = "ActivityTitleTagsById";

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
