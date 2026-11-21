using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000048 RID: 72
	public class ConfigActivityFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00066B7B File Offset: 0x00064D7B
		static ConfigActivityFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityFilterById.CreateStaticDefaultValue), new Action(ConfigActivityFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00066B9C File Offset: 0x00064D9C
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

		// Token: 0x060001B2 RID: 434 RVA: 0x00066C1B File Offset: 0x00064E1B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityFilterById.LogPair = null;
			ConfigActivityFilterById.HandleId = 0;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00066C29 File Offset: 0x00064E29
		public static void Init()
		{
			ConfigActivityFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityFilterById.HandleId, "db_activity.db", "select BinData from `ActivityFilter` where Id=?");
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00066C44 File Offset: 0x00064E44
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

		// Token: 0x040001DC RID: 476
		private const string DB = "db_activity.db";

		// Token: 0x040001DD RID: 477
		private const string FILE = "h.活动.xlsx";

		// Token: 0x040001DE RID: 478
		private const string TABLE = "ActivityFilter";

		// Token: 0x040001DF RID: 479
		private const string COMMAND = "select BinData from `ActivityFilter` where Id=?";

		// Token: 0x040001E0 RID: 480
		private const string KEY_PREFIX = "ActivityFilterById";

		// Token: 0x040001E1 RID: 481
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001E2 RID: 482
		private static int HandleId;
	}
}
