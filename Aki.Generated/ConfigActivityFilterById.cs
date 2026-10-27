using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000040 RID: 64
	public class ConfigActivityFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000180 RID: 384 RVA: 0x000622C7 File Offset: 0x000604C7
		static ConfigActivityFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityFilterById.CreateStaticDefaultValue), new Action(ConfigActivityFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000622E8 File Offset: 0x000604E8
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityFilterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityFilterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityFilter` where Id=?")
			});
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00062367 File Offset: 0x00060567
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityFilterById.LogPair = null;
			ConfigActivityFilterById.HandleId = 0;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00062375 File Offset: 0x00060575
		public static void Init()
		{
			ConfigActivityFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityFilterById.HandleId, "db_activity.db", "select BinData from `ActivityFilter` where Id=?");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00062390 File Offset: 0x00060590
		public static ActivityFilter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityFilterById.HandleId, ConfigActivityFilterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityFilter?(ActivityFilter.GetRootAsActivityFilter(configBuffer));
				}
			}
			ConfigActivityFilterById.LogPair.Clear();
			ConfigActivityFilterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityFilterById.HandleId, 1, p0Id, ConfigActivityFilterById.LogPair) || ConfigCommon.Step(ConfigActivityFilterById.HandleId, true, ConfigActivityFilterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityFilterById.HandleId, ConfigActivityFilterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityFilterById.HandleId, 0, ConfigActivityFilterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityFilterById.HandleId, ConfigActivityFilterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityFilter rootAsActivityFilter = ActivityFilter.GetRootAsActivityFilter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityFilterById.HandleId, ConfigActivityFilterById.LogPair);
			return new ActivityFilter?(rootAsActivityFilter);
		}

		// Token: 0x040001A4 RID: 420
		private const string DB = "db_activity.db";

		// Token: 0x040001A5 RID: 421
		private const string FILE = "h.活动.xlsx";

		// Token: 0x040001A6 RID: 422
		private const string TABLE = "ActivityFilter";

		// Token: 0x040001A7 RID: 423
		private const string COMMAND = "select BinData from `ActivityFilter` where Id=?";

		// Token: 0x040001A8 RID: 424
		private const string KEY_PREFIX = "ActivityFilterById";

		// Token: 0x040001A9 RID: 425
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001AA RID: 426
		private static int HandleId;
	}
}
