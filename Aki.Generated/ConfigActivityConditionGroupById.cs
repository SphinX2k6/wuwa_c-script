using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000046 RID: 70
	public class ConfigActivityConditionGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x0006679F File Offset: 0x0006499F
		static ConfigActivityConditionGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityConditionGroupById.CreateStaticDefaultValue), new Action(ConfigActivityConditionGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000667C0 File Offset: 0x000649C0
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityConditionGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityConditionGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitycondition.db"),
				new ValueTuple<string, object>("文件", "h.活动条件.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityConditionGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityConditionGroup` where Id=?")
			});
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0006683F File Offset: 0x00064A3F
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityConditionGroupById.LogPair = null;
			ConfigActivityConditionGroupById.HandleId = 0;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0006684D File Offset: 0x00064A4D
		public static void Init()
		{
			ConfigActivityConditionGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityConditionGroupById.HandleId, "db_activitycondition.db", "select BinData from `ActivityConditionGroup` where Id=?");
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00066868 File Offset: 0x00064A68
		public static ActivityConditionGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityConditionGroupById.HandleId, ConfigActivityConditionGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityConditionGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityConditionGroup?(ActivityConditionGroup.GetRootAsActivityConditionGroup(configBuffer));
				}
			}
			ConfigActivityConditionGroupById.LogPair.Clear();
			ConfigActivityConditionGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityConditionGroupById.HandleId, 1, p0Id, ConfigActivityConditionGroupById.LogPair) || ConfigCommon.Step(ConfigActivityConditionGroupById.HandleId, true, ConfigActivityConditionGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityConditionGroupById.HandleId, ConfigActivityConditionGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityConditionGroupById.HandleId, 0, ConfigActivityConditionGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityConditionGroupById.HandleId, ConfigActivityConditionGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityConditionGroup rootAsActivityConditionGroup = ActivityConditionGroup.GetRootAsActivityConditionGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityConditionGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityConditionGroupById.HandleId, ConfigActivityConditionGroupById.LogPair);
			return new ActivityConditionGroup?(rootAsActivityConditionGroup);
		}

		// Token: 0x040001CE RID: 462
		private const string DB = "db_activitycondition.db";

		// Token: 0x040001CF RID: 463
		private const string FILE = "h.活动条件.xlsx";

		// Token: 0x040001D0 RID: 464
		private const string TABLE = "ActivityConditionGroup";

		// Token: 0x040001D1 RID: 465
		private const string COMMAND = "select BinData from `ActivityConditionGroup` where Id=?";

		// Token: 0x040001D2 RID: 466
		private const string KEY_PREFIX = "ActivityConditionGroupById";

		// Token: 0x040001D3 RID: 467
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001D4 RID: 468
		private static int HandleId;
	}
}
