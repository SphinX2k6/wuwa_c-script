using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000057 RID: 87
	public class ConfigActivityTitleTagsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600020A RID: 522 RVA: 0x000653A0 File Offset: 0x000635A0
		static ConfigActivityTitleTagsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityTitleTagsById.CreateStaticDefaultValue), new Action(ConfigActivityTitleTagsById.ResetStaticDefaultValue));
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000653C0 File Offset: 0x000635C0
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

		// Token: 0x0600020C RID: 524 RVA: 0x0006543F File Offset: 0x0006363F
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityTitleTagsById.LogPair = null;
			ConfigActivityTitleTagsById.HandleId = 0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0006544D File Offset: 0x0006364D
		public static void Init()
		{
			ConfigActivityTitleTagsById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityTitleTagsById.HandleId, "db_activity.db", "select BinData from `ActivityTitleTags` where Id=?");
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00065468 File Offset: 0x00063668
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

		// Token: 0x04000245 RID: 581
		private const string DB = "db_activity.db";

		// Token: 0x04000246 RID: 582
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000247 RID: 583
		private const string TABLE = "ActivityTitleTags";

		// Token: 0x04000248 RID: 584
		private const string COMMAND = "select BinData from `ActivityTitleTags` where Id=?";

		// Token: 0x04000249 RID: 585
		private const string KEY_PREFIX = "ActivityTitleTagsById";

		// Token: 0x0400024A RID: 586
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400024B RID: 587
		private static int HandleId;
	}
}
