using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000056 RID: 86
	public class ConfigActivityTimeShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000204 RID: 516 RVA: 0x00065158 File Offset: 0x00063358
		static ConfigActivityTimeShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityTimeShowById.CreateStaticDefaultValue), new Action(ConfigActivityTimeShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00065178 File Offset: 0x00063378
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

		// Token: 0x06000206 RID: 518 RVA: 0x000651F7 File Offset: 0x000633F7
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityTimeShowById.LogPair = null;
			ConfigActivityTimeShowById.HandleId = 0;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00065205 File Offset: 0x00063405
		public static void Init()
		{
			ConfigActivityTimeShowById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityTimeShowById.HandleId, "db_activity.db", "select BinData from `ActivityTimeShow` where Id=?");
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00065220 File Offset: 0x00063420
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

		// Token: 0x0400023E RID: 574
		private const string DB = "db_activity.db";

		// Token: 0x0400023F RID: 575
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000240 RID: 576
		private const string TABLE = "ActivityTimeShow";

		// Token: 0x04000241 RID: 577
		private const string COMMAND = "select BinData from `ActivityTimeShow` where Id=?";

		// Token: 0x04000242 RID: 578
		private const string KEY_PREFIX = "ActivityTimeShowById";

		// Token: 0x04000243 RID: 579
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000244 RID: 580
		private static int HandleId;
	}
}
