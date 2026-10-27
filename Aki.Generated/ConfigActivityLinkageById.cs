using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000042 RID: 66
	public class ConfigActivityLinkageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00062758 File Offset: 0x00060958
		static ConfigActivityLinkageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityLinkageById.CreateStaticDefaultValue), new Action(ConfigActivityLinkageById.ResetStaticDefaultValue));
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00062778 File Offset: 0x00060978
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityLinkageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityLinkageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitylinkage.db"),
				new ValueTuple<string, object>("文件", "h.活动联动页活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityLinkage"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityLinkage` where Id=?")
			});
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000627F7 File Offset: 0x000609F7
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityLinkageById.LogPair = null;
			ConfigActivityLinkageById.HandleId = 0;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00062805 File Offset: 0x00060A05
		public static void Init()
		{
			ConfigActivityLinkageById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityLinkageById.HandleId, "db_activitylinkage.db", "select BinData from `ActivityLinkage` where Id=?");
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00062820 File Offset: 0x00060A20
		public static ActivityLinkage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityLinkageById.HandleId, ConfigActivityLinkageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityLinkageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityLinkage?(ActivityLinkage.GetRootAsActivityLinkage(configBuffer));
				}
			}
			ConfigActivityLinkageById.LogPair.Clear();
			ConfigActivityLinkageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityLinkageById.HandleId, 1, p0Id, ConfigActivityLinkageById.LogPair) || ConfigCommon.Step(ConfigActivityLinkageById.HandleId, true, ConfigActivityLinkageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityLinkageById.HandleId, ConfigActivityLinkageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityLinkageById.HandleId, 0, ConfigActivityLinkageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityLinkageById.HandleId, ConfigActivityLinkageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityLinkage rootAsActivityLinkage = ActivityLinkage.GetRootAsActivityLinkage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityLinkageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityLinkageById.HandleId, ConfigActivityLinkageById.LogPair);
			return new ActivityLinkage?(rootAsActivityLinkage);
		}

		// Token: 0x040001B2 RID: 434
		private const string DB = "db_activitylinkage.db";

		// Token: 0x040001B3 RID: 435
		private const string FILE = "h.活动联动页活动.xlsx";

		// Token: 0x040001B4 RID: 436
		private const string TABLE = "ActivityLinkage";

		// Token: 0x040001B5 RID: 437
		private const string COMMAND = "select BinData from `ActivityLinkage` where Id=?";

		// Token: 0x040001B6 RID: 438
		private const string KEY_PREFIX = "ActivityLinkageById";

		// Token: 0x040001B7 RID: 439
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001B8 RID: 440
		private static int HandleId;
	}
}
