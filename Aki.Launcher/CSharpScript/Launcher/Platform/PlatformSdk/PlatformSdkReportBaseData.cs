using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000148 RID: 328
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkReportBaseData : IStaticVariableResetter
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x00046908 File Offset: 0x00044B08
		static PlatformSdkReportBaseData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlatformSdkReportBaseData.CreateStaticDefaultValue), new Action(PlatformSdkReportBaseData.ResetStaticDefaultValue));
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000469ED File Offset: 0x00044BED
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000469F0 File Offset: 0x00044BF0
		public static void ResetStaticDefaultValue()
		{
			PlatformSdkReportBaseData.BasePkgId = "";
			PlatformSdkReportBaseData.BasePkgName = "";
			PlatformSdkReportBaseData.BaseChannelId = "";
			PlatformSdkReportBaseData.BaseChannelName = "";
			PlatformSdkReportBaseData.BaseChannelOp = "";
			PlatformSdkReportBaseData.BaseLanguage = "";
			PlatformSdkReportBaseData.BaseRoleName = "";
			PlatformSdkReportBaseData.BaseServerName = "";
			PlatformSdkReportBaseData.BaseServerId = "";
			PlatformSdkReportBaseData.BaseRoleId = "";
			PlatformSdkReportBaseData.LoginId = "";
			PlatformSdkReportBaseData.BaseGameVersion = "";
			PlatformSdkReportBaseData.BaseSdkVersion = "";
			PlatformSdkReportBaseData.BaseDid = "";
			PlatformSdkReportBaseData.BaseUserId = "";
			PlatformSdkReportBaseData.BaseInitTime = "";
			PlatformSdkReportBaseData.BaseGameId = "";
			PlatformSdkReportBaseData.BaseAccessId = "";
			PlatformSdkReportBaseData.BasePuid = 0L;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00046AB8 File Offset: 0x00044CB8
		public PlatformSdkReportBaseData()
		{
			this.event_uuid = UKismetGuidLibrary.NewGuid().ToString();
			this.language = PlatformSdkReportBaseData.BaseLanguage;
			DateTimeOffset utcNow = DateTimeOffset.UtcNow;
			double totalHours = TimeZoneInfo.Local.GetUtcOffset(utcNow).TotalHours;
			string text;
			if (totalHours < 0.0)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<double>(totalHours);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<double>(totalHours);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			this.timezone = text;
			this.pkg_id = PlatformSdkReportBaseData.BasePkgId;
			this.pkg_name = PlatformSdkReportBaseData.BasePkgName;
			this.channel_id = PlatformSdkReportBaseData.BaseChannelId;
			this.channel_name = PlatformSdkReportBaseData.BaseChannelName;
			this.channel_op = PlatformSdkReportBaseData.BaseChannelOp;
			this.role_id = PlatformSdkReportBaseData.BaseRoleId;
			this.role_name = PlatformSdkReportBaseData.BaseRoleName;
			this.server_id = PlatformSdkReportBaseData.BaseServerId;
			this.server_name = PlatformSdkReportBaseData.BaseServerName;
			this.login_id = PlatformSdkReportBaseData.LoginId;
			this.game_version = PlatformSdkReportBaseData.BaseGameVersion;
			this.sdk_version = PlatformSdkReportBaseData.BaseSdkVersion;
			this.did = PlatformSdkReportBaseData.BaseDid;
			this.event_time_ms = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			this.last_phone_open_ts = PlatformSdkReportBaseData.BaseInitTime;
			this.user_id = PlatformSdkReportBaseData.BaseUserId;
			this.game_id = PlatformSdkReportBaseData.BaseGameId;
			this.psn_access_id = PlatformSdkReportBaseData.BaseAccessId;
			this.puid = PlatformSdkReportBaseData.BasePuid;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00046D37 File Offset: 0x00044F37
		public virtual string GetReportEventName()
		{
			return this.event_name;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00046D3F File Offset: 0x00044F3F
		public virtual string GetCpReportEventName()
		{
			return "cp_" + this.event_name;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00046D51 File Offset: 0x00044F51
		public virtual string GetReportData()
		{
			return LauncherJson.Stringify(this, new JsonSerializerOptions
			{
				IncludeFields = true
			});
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00046D68 File Offset: 0x00044F68
		public static void InitSdkBaseValue(string pkg_id, string pkg_name, string channel_id, string channel_name, string channel_op, string language, string loginId, string gameVersion, string sdkVersion, string did, string initTime, string gameId, string accessId)
		{
			PlatformSdkReportBaseData.BasePkgId = pkg_id;
			PlatformSdkReportBaseData.BasePkgName = pkg_name;
			PlatformSdkReportBaseData.BaseChannelId = channel_id;
			PlatformSdkReportBaseData.BaseChannelName = channel_name;
			PlatformSdkReportBaseData.BaseChannelOp = channel_op;
			PlatformSdkReportBaseData.LoginId = loginId;
			PlatformSdkReportBaseData.BaseGameVersion = gameVersion;
			PlatformSdkReportBaseData.BaseSdkVersion = sdkVersion;
			PlatformSdkReportBaseData.BaseDid = did;
			PlatformSdkReportBaseData.BaseInitTime = initTime;
			PlatformSdkReportBaseData.BaseGameId = gameId;
			PlatformSdkReportBaseData.BaseAccessId = accessId;
			PlatformSdkReportBaseData.ChangeLanguage(language);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00046DCC File Offset: 0x00044FCC
		public static void SetCuid(string cuid)
		{
			PlatformSdkReportBaseData.BaseUserId = cuid;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00046DD4 File Offset: 0x00044FD4
		public static void SetPuid(long puid)
		{
			PlatformSdkReportBaseData.BasePuid = puid;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00046DDC File Offset: 0x00044FDC
		public static long GetPuid()
		{
			return PlatformSdkReportBaseData.BasePuid;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00046DE3 File Offset: 0x00044FE3
		public static void ChangeLanguage(string language)
		{
			PlatformSdkReportBaseData.BaseLanguage = language;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00046DEB File Offset: 0x00044FEB
		public static void InitSdkRoleValue(string role_id, string role_name, string server_id, string server_name)
		{
			PlatformSdkReportBaseData.BaseRoleId = role_id;
			PlatformSdkReportBaseData.BaseRoleName = role_name;
			PlatformSdkReportBaseData.BaseServerId = server_id;
			PlatformSdkReportBaseData.BaseServerName = server_name;
		}

		// Token: 0x0400063F RID: 1599
		private const string PROJECT_ID = "Aki";

		// Token: 0x04000640 RID: 1600
		private const int GLOBALSDKTYPEVALUE = 2;

		// Token: 0x04000641 RID: 1601
		private static string BasePkgId = "";

		// Token: 0x04000642 RID: 1602
		private static string BasePkgName = "";

		// Token: 0x04000643 RID: 1603
		private static string BaseChannelId = "";

		// Token: 0x04000644 RID: 1604
		private static string BaseChannelName = "";

		// Token: 0x04000645 RID: 1605
		private static string BaseChannelOp = "";

		// Token: 0x04000646 RID: 1606
		private static string BaseLanguage = "";

		// Token: 0x04000647 RID: 1607
		private static string BaseRoleName = "";

		// Token: 0x04000648 RID: 1608
		private static string BaseServerName = "";

		// Token: 0x04000649 RID: 1609
		private static string BaseServerId = "";

		// Token: 0x0400064A RID: 1610
		private static string BaseRoleId = "";

		// Token: 0x0400064B RID: 1611
		private static string LoginId = "";

		// Token: 0x0400064C RID: 1612
		private static string BaseGameVersion = "";

		// Token: 0x0400064D RID: 1613
		private static string BaseSdkVersion = "";

		// Token: 0x0400064E RID: 1614
		private static string BaseDid = "";

		// Token: 0x0400064F RID: 1615
		private static string BaseUserId = "";

		// Token: 0x04000650 RID: 1616
		private static string BaseInitTime = "";

		// Token: 0x04000651 RID: 1617
		private static string BaseGameId = "";

		// Token: 0x04000652 RID: 1618
		private static string BaseAccessId = "";

		// Token: 0x04000653 RID: 1619
		private static long BasePuid = 0L;

		// Token: 0x04000654 RID: 1620
		public long event_time_ms;

		// Token: 0x04000655 RID: 1621
		public int event_id;

		// Token: 0x04000656 RID: 1622
		public string event_name = "";

		// Token: 0x04000657 RID: 1623
		public string event_uuid = "";

		// Token: 0x04000658 RID: 1624
		public string did = "";

		// Token: 0x04000659 RID: 1625
		public string language = "";

		// Token: 0x0400065A RID: 1626
		public string timezone = "";

		// Token: 0x0400065B RID: 1627
		public string user_id = "";

		// Token: 0x0400065C RID: 1628
		public string game_id = "";

		// Token: 0x0400065D RID: 1629
		public string game_name = "Aki";

		// Token: 0x0400065E RID: 1630
		public string pkg_id = "";

		// Token: 0x0400065F RID: 1631
		public string pkg_name = "";

		// Token: 0x04000660 RID: 1632
		public string channel_id = "";

		// Token: 0x04000661 RID: 1633
		public string channel_name = "";

		// Token: 0x04000662 RID: 1634
		public string channel_op = "";

		// Token: 0x04000663 RID: 1635
		public string role_id = "";

		// Token: 0x04000664 RID: 1636
		public string role_name = "";

		// Token: 0x04000665 RID: 1637
		public string server_id = "";

		// Token: 0x04000666 RID: 1638
		public string server_name = "";

		// Token: 0x04000667 RID: 1639
		public string sdk_version = "";

		// Token: 0x04000668 RID: 1640
		public string game_version = "";

		// Token: 0x04000669 RID: 1641
		public string login_id = "";

		// Token: 0x0400066A RID: 1642
		public string os = "PS5";

		// Token: 0x0400066B RID: 1643
		public string last_phone_open_ts = "";

		// Token: 0x0400066C RID: 1644
		public int sdk_type = 2;

		// Token: 0x0400066D RID: 1645
		public string psn_access_id = "";

		// Token: 0x0400066E RID: 1646
		public long puid;
	}
}
