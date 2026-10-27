using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200003E RID: 62
	public class ConfigActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000174 RID: 372 RVA: 0x00061EEB File Offset: 0x000600EB
		static ConfigActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityById.CreateStaticDefaultValue), new Action(ConfigActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00061F0C File Offset: 0x0006010C
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

		// Token: 0x06000176 RID: 374 RVA: 0x00061F8B File Offset: 0x0006018B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityById.LogPair = null;
			ConfigActivityById.HandleId = 0;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00061F99 File Offset: 0x00060199
		public static void Init()
		{
			ConfigActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityById.HandleId, "db_activity.db", "select BinData from `Activity` where Id=?");
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00061FB4 File Offset: 0x000601B4
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

		// Token: 0x04000196 RID: 406
		private const string DB = "db_activity.db";

		// Token: 0x04000197 RID: 407
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000198 RID: 408
		private const string TABLE = "Activity";

		// Token: 0x04000199 RID: 409
		private const string COMMAND = "select BinData from `Activity` where Id=?";

		// Token: 0x0400019A RID: 410
		private const string KEY_PREFIX = "ActivityById";

		// Token: 0x0400019B RID: 411
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400019C RID: 412
		private static int HandleId;
	}
}
