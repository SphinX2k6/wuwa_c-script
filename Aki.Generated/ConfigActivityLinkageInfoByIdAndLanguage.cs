using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004B RID: 75
	public class ConfigActivityLinkageInfoByIdAndLanguage : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00067254 File Offset: 0x00065454
		static ConfigActivityLinkageInfoByIdAndLanguage()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityLinkageInfoByIdAndLanguage.CreateStaticDefaultValue), new Action(ConfigActivityLinkageInfoByIdAndLanguage.ResetStaticDefaultValue));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00067274 File Offset: 0x00065474
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityLinkageInfoByIdAndLanguage.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityLinkageInfoByIdAndLanguage.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitylinkage.db"),
				new ValueTuple<string, object>("文件", "h.活动联动页活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityLinkageInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityLinkageInfo` where ActivityLinkageId=? And Language=?")
			});
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000672F3 File Offset: 0x000654F3
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityLinkageInfoByIdAndLanguage.LogPair = null;
			ConfigActivityLinkageInfoByIdAndLanguage.HandleId = 0;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00067301 File Offset: 0x00065501
		public static void Init()
		{
			ConfigActivityLinkageInfoByIdAndLanguage.HandleId = ConfigCommon.InitDataStatement(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, "db_activitylinkage.db", "select BinData from `ActivityLinkageInfo` where ActivityLinkageId=? And Language=?");
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0006731C File Offset: 0x0006551C
		public static ActivityLinkageInfo? GetConfig(int p0ActivityLinkageId, int p1Language, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, ConfigActivityLinkageInfoByIdAndLanguage.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityLinkageInfoByIdAndLanguage");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityLinkageId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Language);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityLinkageInfo?(ActivityLinkageInfo.GetRootAsActivityLinkageInfo(configBuffer));
				}
			}
			ConfigActivityLinkageInfoByIdAndLanguage.LogPair.Clear();
			ConfigActivityLinkageInfoByIdAndLanguage.LogPair.Add(new ValueTuple<string, object>("ActivityLinkageId", p0ActivityLinkageId));
			ConfigActivityLinkageInfoByIdAndLanguage.LogPair.Add(new ValueTuple<string, object>("Language", p1Language));
			if (!ConfigCommon.BindInt(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, 1, p0ActivityLinkageId, ConfigActivityLinkageInfoByIdAndLanguage.LogPair) || !ConfigCommon.BindInt(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, 2, p1Language, ConfigActivityLinkageInfoByIdAndLanguage.LogPair) || ConfigCommon.Step(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, true, ConfigActivityLinkageInfoByIdAndLanguage.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, ConfigActivityLinkageInfoByIdAndLanguage.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, 0, ConfigActivityLinkageInfoByIdAndLanguage.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, ConfigActivityLinkageInfoByIdAndLanguage.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityLinkageInfo rootAsActivityLinkageInfo = ActivityLinkageInfo.GetRootAsActivityLinkageInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityLinkageInfoByIdAndLanguage");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityLinkageId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Language);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, ConfigActivityLinkageInfoByIdAndLanguage.LogPair);
			return new ActivityLinkageInfo?(rootAsActivityLinkageInfo);
		}

		// Token: 0x040001F1 RID: 497
		private const string DB = "db_activitylinkage.db";

		// Token: 0x040001F2 RID: 498
		private const string FILE = "h.活动联动页活动.xlsx";

		// Token: 0x040001F3 RID: 499
		private const string TABLE = "ActivityLinkageInfo";

		// Token: 0x040001F4 RID: 500
		private const string COMMAND = "select BinData from `ActivityLinkageInfo` where ActivityLinkageId=? And Language=?";

		// Token: 0x040001F5 RID: 501
		private const string KEY_PREFIX = "ActivityLinkageInfoByIdAndLanguage";

		// Token: 0x040001F6 RID: 502
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001F7 RID: 503
		private static int HandleId;
	}
}
