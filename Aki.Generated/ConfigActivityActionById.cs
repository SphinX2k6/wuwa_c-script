using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200003F RID: 63
	public class ConfigActivityActionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600017A RID: 378 RVA: 0x0006591F File Offset: 0x00063B1F
		static ConfigActivityActionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityActionById.CreateStaticDefaultValue), new Action(ConfigActivityActionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00065940 File Offset: 0x00063B40
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityActionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityActionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityaction.db"),
				new ValueTuple<string, object>("文件", "h.活动Action.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityAction"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityAction` where Id=?")
			});
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000659BF File Offset: 0x00063BBF
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityActionById.LogPair = null;
			ConfigActivityActionById.HandleId = 0;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000659CD File Offset: 0x00063BCD
		public static void Init()
		{
			ConfigActivityActionById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityActionById.HandleId, "db_activityaction.db", "select BinData from `ActivityAction` where Id=?");
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000659E8 File Offset: 0x00063BE8
		public static ActivityAction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityActionById.HandleId, ConfigActivityActionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityAction?(ActivityAction.GetRootAsActivityAction(configBuffer));
				}
			}
			ConfigActivityActionById.LogPair.Clear();
			ConfigActivityActionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityActionById.HandleId, 1, p0Id, ConfigActivityActionById.LogPair) || ConfigCommon.Step(ConfigActivityActionById.HandleId, true, ConfigActivityActionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityActionById.HandleId, ConfigActivityActionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityActionById.HandleId, 0, ConfigActivityActionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityActionById.HandleId, ConfigActivityActionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityAction rootAsActivityAction = ActivityAction.GetRootAsActivityAction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityActionById.HandleId, ConfigActivityActionById.LogPair);
			return new ActivityAction?(rootAsActivityAction);
		}

		// Token: 0x0400019D RID: 413
		private const string DB = "db_activityaction.db";

		// Token: 0x0400019E RID: 414
		private const string FILE = "h.活动Action.xlsx";

		// Token: 0x0400019F RID: 415
		private const string TABLE = "ActivityAction";

		// Token: 0x040001A0 RID: 416
		private const string COMMAND = "select BinData from `ActivityAction` where Id=?";

		// Token: 0x040001A1 RID: 417
		private const string KEY_PREFIX = "ActivityActionById";

		// Token: 0x040001A2 RID: 418
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001A3 RID: 419
		private static int HandleId;
	}
}
