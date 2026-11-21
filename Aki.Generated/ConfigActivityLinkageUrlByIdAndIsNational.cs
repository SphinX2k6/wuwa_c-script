using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004C RID: 76
	public class ConfigActivityLinkageUrlByIdAndIsNational : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x000674F1 File Offset: 0x000656F1
		static ConfigActivityLinkageUrlByIdAndIsNational()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityLinkageUrlByIdAndIsNational.CreateStaticDefaultValue), new Action(ConfigActivityLinkageUrlByIdAndIsNational.ResetStaticDefaultValue));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00067510 File Offset: 0x00065710
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

		// Token: 0x060001CA RID: 458 RVA: 0x0006758F File Offset: 0x0006578F
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityLinkageUrlByIdAndIsNational.LogPair = null;
			ConfigActivityLinkageUrlByIdAndIsNational.HandleId = 0;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0006759D File Offset: 0x0006579D
		public static void Init()
		{
			ConfigActivityLinkageUrlByIdAndIsNational.HandleId = ConfigCommon.InitDataStatement(ConfigActivityLinkageUrlByIdAndIsNational.HandleId, "db_activitylinkage.db", "select BinData from `ActivityLinkageUrl` where ActivityLinkageId=? And IsNational=?");
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000675B8 File Offset: 0x000657B8
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

		// Token: 0x040001F8 RID: 504
		private const string DB = "db_activitylinkage.db";

		// Token: 0x040001F9 RID: 505
		private const string FILE = "h.活动联动页活动.xlsx";

		// Token: 0x040001FA RID: 506
		private const string TABLE = "ActivityLinkageUrl";

		// Token: 0x040001FB RID: 507
		private const string COMMAND = "select BinData from `ActivityLinkageUrl` where ActivityLinkageId=? And IsNational=?";

		// Token: 0x040001FC RID: 508
		private const string KEY_PREFIX = "ActivityLinkageUrlByIdAndIsNational";

		// Token: 0x040001FD RID: 509
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001FE RID: 510
		private static int HandleId;
	}
}
