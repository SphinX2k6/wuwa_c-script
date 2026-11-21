using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000041 RID: 65
	public class ConfigActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00065DB0 File Offset: 0x00063FB0
		static ConfigActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityById.CreateStaticDefaultValue), new Action(ConfigActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00065DD0 File Offset: 0x00063FD0
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "Activity"),
				new ValueTuple<string, object>("语句", "select BinData from `Activity` where Id=?")
			});
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00065E4F File Offset: 0x0006404F
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityById.LogPair = null;
			ConfigActivityById.HandleId = 0;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00065E5D File Offset: 0x0006405D
		public static void Init()
		{
			ConfigActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityById.HandleId, "db_activity.db", "select BinData from `Activity` where Id=?");
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00065E78 File Offset: 0x00064078
		public static Activity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityById.HandleId, ConfigActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Activity?(Activity.GetRootAsActivity(configBuffer));
				}
			}
			ConfigActivityById.LogPair.Clear();
			ConfigActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityById.HandleId, 1, p0Id, ConfigActivityById.LogPair) || ConfigCommon.Step(ConfigActivityById.HandleId, true, ConfigActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityById.HandleId, ConfigActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityById.HandleId, 0, ConfigActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityById.HandleId, ConfigActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Activity rootAsActivity = Activity.GetRootAsActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityById.HandleId, ConfigActivityById.LogPair);
			return new Activity?(rootAsActivity);
		}

		// Token: 0x040001AB RID: 427
		private const string DB = "db_activity.db";

		// Token: 0x040001AC RID: 428
		private const string FILE = "h.活动.xlsx";

		// Token: 0x040001AD RID: 429
		private const string TABLE = "Activity";

		// Token: 0x040001AE RID: 430
		private const string COMMAND = "select BinData from `Activity` where Id=?";

		// Token: 0x040001AF RID: 431
		private const string KEY_PREFIX = "ActivityById";

		// Token: 0x040001B0 RID: 432
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001B1 RID: 433
		private static int HandleId;
	}
}
