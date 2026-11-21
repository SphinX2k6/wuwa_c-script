using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004E RID: 78
	public class ConfigActivityPermanentFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0006791F File Offset: 0x00065B1F
		static ConfigActivityPermanentFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityPermanentFilterById.CreateStaticDefaultValue), new Action(ConfigActivityPermanentFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00067940 File Offset: 0x00065B40
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityPermanentFilterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityPermanentFilterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityPermanentFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityPermanentFilter` where Id=?")
			});
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000679BF File Offset: 0x00065BBF
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityPermanentFilterById.LogPair = null;
			ConfigActivityPermanentFilterById.HandleId = 0;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000679CD File Offset: 0x00065BCD
		public static void Init()
		{
			ConfigActivityPermanentFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityPermanentFilterById.HandleId, "db_activity.db", "select BinData from `ActivityPermanentFilter` where Id=?");
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000679E8 File Offset: 0x00065BE8
		public static ActivityPermanentFilter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityPermanentFilterById.HandleId, ConfigActivityPermanentFilterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityPermanentFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityPermanentFilter?(ActivityPermanentFilter.GetRootAsActivityPermanentFilter(configBuffer));
				}
			}
			ConfigActivityPermanentFilterById.LogPair.Clear();
			ConfigActivityPermanentFilterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityPermanentFilterById.HandleId, 1, p0Id, ConfigActivityPermanentFilterById.LogPair) || ConfigCommon.Step(ConfigActivityPermanentFilterById.HandleId, true, ConfigActivityPermanentFilterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityPermanentFilterById.HandleId, ConfigActivityPermanentFilterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityPermanentFilterById.HandleId, 0, ConfigActivityPermanentFilterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityPermanentFilterById.HandleId, ConfigActivityPermanentFilterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityPermanentFilter rootAsActivityPermanentFilter = ActivityPermanentFilter.GetRootAsActivityPermanentFilter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityPermanentFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityPermanentFilterById.HandleId, ConfigActivityPermanentFilterById.LogPair);
			return new ActivityPermanentFilter?(rootAsActivityPermanentFilter);
		}

		// Token: 0x04000206 RID: 518
		private const string DB = "db_activity.db";

		// Token: 0x04000207 RID: 519
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000208 RID: 520
		private const string TABLE = "ActivityPermanentFilter";

		// Token: 0x04000209 RID: 521
		private const string COMMAND = "select BinData from `ActivityPermanentFilter` where Id=?";

		// Token: 0x0400020A RID: 522
		private const string KEY_PREFIX = "ActivityPermanentFilterById";

		// Token: 0x0400020B RID: 523
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400020C RID: 524
		private static int HandleId;
	}
}
