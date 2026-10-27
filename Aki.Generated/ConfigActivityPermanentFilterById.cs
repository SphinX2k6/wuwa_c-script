using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000046 RID: 70
	public class ConfigActivityPermanentFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x0006306B File Offset: 0x0006126B
		static ConfigActivityPermanentFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityPermanentFilterById.CreateStaticDefaultValue), new Action(ConfigActivityPermanentFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0006308C File Offset: 0x0006128C
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

		// Token: 0x060001A6 RID: 422 RVA: 0x0006310B File Offset: 0x0006130B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityPermanentFilterById.LogPair = null;
			ConfigActivityPermanentFilterById.HandleId = 0;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00063119 File Offset: 0x00061319
		public static void Init()
		{
			ConfigActivityPermanentFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityPermanentFilterById.HandleId, "db_activity.db", "select BinData from `ActivityPermanentFilter` where Id=?");
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00063134 File Offset: 0x00061334
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

		// Token: 0x040001CE RID: 462
		private const string DB = "db_activity.db";

		// Token: 0x040001CF RID: 463
		private const string FILE = "h.活动.xlsx";

		// Token: 0x040001D0 RID: 464
		private const string TABLE = "ActivityPermanentFilter";

		// Token: 0x040001D1 RID: 465
		private const string COMMAND = "select BinData from `ActivityPermanentFilter` where Id=?";

		// Token: 0x040001D2 RID: 466
		private const string KEY_PREFIX = "ActivityPermanentFilterById";

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
