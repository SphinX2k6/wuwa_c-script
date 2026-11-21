using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005E RID: 94
	public class ConfigActivityTimeShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00069A0C File Offset: 0x00067C0C
		static ConfigActivityTimeShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityTimeShowById.CreateStaticDefaultValue), new Action(ConfigActivityTimeShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00069A2C File Offset: 0x00067C2C
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityTimeShowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityTimeShowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityTimeShow"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityTimeShow` where Id=?")
			});
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00069AAB File Offset: 0x00067CAB
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityTimeShowById.LogPair = null;
			ConfigActivityTimeShowById.HandleId = 0;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00069AB9 File Offset: 0x00067CB9
		public static void Init()
		{
			ConfigActivityTimeShowById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityTimeShowById.HandleId, "db_activity.db", "select BinData from `ActivityTimeShow` where Id=?");
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00069AD4 File Offset: 0x00067CD4
		public static ActivityTimeShow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityTimeShowById.HandleId, ConfigActivityTimeShowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityTimeShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityTimeShow?(ActivityTimeShow.GetRootAsActivityTimeShow(configBuffer));
				}
			}
			ConfigActivityTimeShowById.LogPair.Clear();
			ConfigActivityTimeShowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityTimeShowById.HandleId, 1, p0Id, ConfigActivityTimeShowById.LogPair) || ConfigCommon.Step(ConfigActivityTimeShowById.HandleId, true, ConfigActivityTimeShowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityTimeShowById.HandleId, ConfigActivityTimeShowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityTimeShowById.HandleId, 0, ConfigActivityTimeShowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityTimeShowById.HandleId, ConfigActivityTimeShowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityTimeShow rootAsActivityTimeShow = ActivityTimeShow.GetRootAsActivityTimeShow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityTimeShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityTimeShowById.HandleId, ConfigActivityTimeShowById.LogPair);
			return new ActivityTimeShow?(rootAsActivityTimeShow);
		}

		// Token: 0x04000276 RID: 630
		private const string DB = "db_activity.db";

		// Token: 0x04000277 RID: 631
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000278 RID: 632
		private const string TABLE = "ActivityTimeShow";

		// Token: 0x04000279 RID: 633
		private const string COMMAND = "select BinData from `ActivityTimeShow` where Id=?";

		// Token: 0x0400027A RID: 634
		private const string KEY_PREFIX = "ActivityTimeShowById";

		// Token: 0x0400027B RID: 635
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400027C RID: 636
		private static int HandleId;
	}
}
