using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000043 RID: 67
	public class ConfigActivityLinkageInfoByIdAndLanguage : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000192 RID: 402 RVA: 0x000629A0 File Offset: 0x00060BA0
		static ConfigActivityLinkageInfoByIdAndLanguage()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityLinkageInfoByIdAndLanguage.CreateStaticDefaultValue), new Action(ConfigActivityLinkageInfoByIdAndLanguage.ResetStaticDefaultValue));
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000629C0 File Offset: 0x00060BC0
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

		// Token: 0x06000194 RID: 404 RVA: 0x00062A3F File Offset: 0x00060C3F
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityLinkageInfoByIdAndLanguage.LogPair = null;
			ConfigActivityLinkageInfoByIdAndLanguage.HandleId = 0;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00062A4D File Offset: 0x00060C4D
		public static void Init()
		{
			ConfigActivityLinkageInfoByIdAndLanguage.HandleId = ConfigCommon.InitDataStatement(ConfigActivityLinkageInfoByIdAndLanguage.HandleId, "db_activitylinkage.db", "select BinData from `ActivityLinkageInfo` where ActivityLinkageId=? And Language=?");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00062A68 File Offset: 0x00060C68
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

		// Token: 0x040001B9 RID: 441
		private const string DB = "db_activitylinkage.db";

		// Token: 0x040001BA RID: 442
		private const string FILE = "h.活动联动页活动.xlsx";

		// Token: 0x040001BB RID: 443
		private const string TABLE = "ActivityLinkageInfo";

		// Token: 0x040001BC RID: 444
		private const string COMMAND = "select BinData from `ActivityLinkageInfo` where ActivityLinkageId=? And Language=?";

		// Token: 0x040001BD RID: 445
		private const string KEY_PREFIX = "ActivityLinkageInfoByIdAndLanguage";

		// Token: 0x040001BE RID: 446
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001BF RID: 447
		private static int HandleId;
	}
}
