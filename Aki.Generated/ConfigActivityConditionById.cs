using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000043 RID: 67
	public class ConfigActivityConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000192 RID: 402 RVA: 0x0006618B File Offset: 0x0006438B
		static ConfigActivityConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityConditionById.CreateStaticDefaultValue), new Action(ConfigActivityConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000661AC File Offset: 0x000643AC
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityConditionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityConditionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitycondition.db"),
				new ValueTuple<string, object>("文件", "h.活动条件.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityCondition` where Id=?")
			});
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0006622B File Offset: 0x0006442B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityConditionById.LogPair = null;
			ConfigActivityConditionById.HandleId = 0;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00066239 File Offset: 0x00064439
		public static void Init()
		{
			ConfigActivityConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityConditionById.HandleId, "db_activitycondition.db", "select BinData from `ActivityCondition` where Id=?");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00066254 File Offset: 0x00064454
		public static ActivityCondition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityConditionById.HandleId, ConfigActivityConditionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityCondition?(ActivityCondition.GetRootAsActivityCondition(configBuffer));
				}
			}
			ConfigActivityConditionById.LogPair.Clear();
			ConfigActivityConditionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityConditionById.HandleId, 1, p0Id, ConfigActivityConditionById.LogPair) || ConfigCommon.Step(ConfigActivityConditionById.HandleId, true, ConfigActivityConditionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityConditionById.HandleId, ConfigActivityConditionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityConditionById.HandleId, 0, ConfigActivityConditionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityConditionById.HandleId, ConfigActivityConditionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityCondition rootAsActivityCondition = ActivityCondition.GetRootAsActivityCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityConditionById.HandleId, ConfigActivityConditionById.LogPair);
			return new ActivityCondition?(rootAsActivityCondition);
		}

		// Token: 0x040001B9 RID: 441
		private const string DB = "db_activitycondition.db";

		// Token: 0x040001BA RID: 442
		private const string FILE = "h.活动条件.xlsx";

		// Token: 0x040001BB RID: 443
		private const string TABLE = "ActivityCondition";

		// Token: 0x040001BC RID: 444
		private const string COMMAND = "select BinData from `ActivityCondition` where Id=?";

		// Token: 0x040001BD RID: 445
		private const string KEY_PREFIX = "ActivityConditionById";

		// Token: 0x040001BE RID: 446
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001BF RID: 447
		private static int HandleId;
	}
}
