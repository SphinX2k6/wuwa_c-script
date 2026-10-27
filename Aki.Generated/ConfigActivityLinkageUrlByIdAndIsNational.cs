using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000044 RID: 68
	public class ConfigActivityLinkageUrlByIdAndIsNational : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00062C3D File Offset: 0x00060E3D
		static ConfigActivityLinkageUrlByIdAndIsNational()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityLinkageUrlByIdAndIsNational.CreateStaticDefaultValue), new Action(ConfigActivityLinkageUrlByIdAndIsNational.ResetStaticDefaultValue));
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00062C5C File Offset: 0x00060E5C
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityLinkageUrlByIdAndIsNational.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityLinkageUrlByIdAndIsNational.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitylinkage.db"),
				new ValueTuple<string, object>("文件", "h.活动联动页活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityLinkageUrl"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityLinkageUrl` where ActivityLinkageId=? And IsNational=?")
			});
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00062CDB File Offset: 0x00060EDB
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityLinkageUrlByIdAndIsNational.LogPair = null;
			ConfigActivityLinkageUrlByIdAndIsNational.HandleId = 0;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00062CE9 File Offset: 0x00060EE9
		public static void Init()
		{
			ConfigActivityLinkageUrlByIdAndIsNational.HandleId = ConfigCommon.InitDataStatement(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, "db_activitylinkage.db", "select BinData from `ActivityLinkageUrl` where ActivityLinkageId=? And IsNational=?");
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00062D04 File Offset: 0x00060F04
		public static ActivityLinkageUrl? GetConfig(int p0ActivityLinkageId, bool p1IsNational, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, ConfigActivityLinkageUrlByIdAndIsNational.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityLinkageUrlByIdAndIsNational");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityLinkageId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(p1IsNational);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityLinkageUrl?(ActivityLinkageUrl.GetRootAsActivityLinkageUrl(configBuffer));
				}
			}
			ConfigActivityLinkageUrlByIdAndIsNational.LogPair.Clear();
			ConfigActivityLinkageUrlByIdAndIsNational.LogPair.Add(new ValueTuple<string, object>("ActivityLinkageId", p0ActivityLinkageId));
			ConfigActivityLinkageUrlByIdAndIsNational.LogPair.Add(new ValueTuple<string, object>("IsNational", p1IsNational));
			if (!ConfigCommon.BindInt(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, 1, p0ActivityLinkageId, ConfigActivityLinkageUrlByIdAndIsNational.LogPair) || !ConfigCommon.BindBool(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, 2, p1IsNational, ConfigActivityLinkageUrlByIdAndIsNational.LogPair) || ConfigCommon.Step(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, true, ConfigActivityLinkageUrlByIdAndIsNational.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, ConfigActivityLinkageUrlByIdAndIsNational.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, 0, ConfigActivityLinkageUrlByIdAndIsNational.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, ConfigActivityLinkageUrlByIdAndIsNational.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityLinkageUrl rootAsActivityLinkageUrl = ActivityLinkageUrl.GetRootAsActivityLinkageUrl(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityLinkageUrlByIdAndIsNational");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityLinkageId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(p1IsNational);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, ConfigActivityLinkageUrlByIdAndIsNational.LogPair);
			return new ActivityLinkageUrl?(rootAsActivityLinkageUrl);
		}

		// Token: 0x040001C0 RID: 448
		private const string DB = "db_activitylinkage.db";

		// Token: 0x040001C1 RID: 449
		private const string FILE = "h.活动联动页活动.xlsx";

		// Token: 0x040001C2 RID: 450
		private const string TABLE = "ActivityLinkageUrl";

		// Token: 0x040001C3 RID: 451
		private const string COMMAND = "select BinData from `ActivityLinkageUrl` where ActivityLinkageId=? And IsNational=?";

		// Token: 0x040001C4 RID: 452
		private const string KEY_PREFIX = "ActivityLinkageUrlByIdAndIsNational";

		// Token: 0x040001C5 RID: 453
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001C6 RID: 454
		private static int HandleId;
	}
}
