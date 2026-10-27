using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000144 RID: 324
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformSdkReportBaseData : IStaticVariableResetter
	{
		// Token: 0x06000A3A RID: 2618 RVA: 0x000444F4 File Offset: 0x000426F4
		static PlatformSdkReportBaseData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlatformSdkReportBaseData.CreateStaticDefaultValue), new Action(PlatformSdkReportBaseData.ResetStaticDefaultValue));
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000445D9 File Offset: 0x000427D9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000445DC File Offset: 0x000427DC
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

		// Token: 0x06000A3D RID: 2621 RVA: 0x000446A4 File Offset: 0x000428A4
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

		// Token: 0x06000A3E RID: 2622 RVA: 0x00044923 File Offset: 0x00042B23
		public virtual string GetReportEventName()
		{
			return this.event_name;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0004492B File Offset: 0x00042B2B
		public virtual string GetCpReportEventName()
		{
			return "cp_" + this.event_name;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0004493D File Offset: 0x00042B3D
		public virtual string GetReportData()
		{
			return LauncherJson.Stringify<PlatformSdkReportBaseData>(this, new JsonSerializerOptions
			{
				IncludeFields = true
			});
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00044954 File Offset: 0x00042B54
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

		// Token: 0x06000A42 RID: 2626 RVA: 0x000449B8 File Offset: 0x00042BB8
		public static void SetCuid(string cuid)
		{
			PlatformSdkReportBaseData.BaseUserId = cuid;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000449C0 File Offset: 0x00042BC0
		public static void SetPuid(long puid)
		{
			PlatformSdkReportBaseData.BasePuid = puid;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000449C8 File Offset: 0x00042BC8
		public static long GetPuid()
		{
			return PlatformSdkReportBaseData.BasePuid;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000449CF File Offset: 0x00042BCF
		public static void ChangeLanguage(string language)
		{
			PlatformSdkReportBaseData.BaseLanguage = language;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000449D7 File Offset: 0x00042BD7
		public static void InitSdkRoleValue(string role_id, string role_name, string server_id, string server_name)
		{
			PlatformSdkReportBaseData.BaseRoleId = role_id;
			PlatformSdkReportBaseData.BaseRoleName = role_name;
			PlatformSdkReportBaseData.BaseServerId = server_id;
			PlatformSdkReportBaseData.BaseServerName = server_name;
		}

		// Token: 0x04000604 RID: 1540
		private const string PROJECT_ID = "Aki";

		// Token: 0x04000605 RID: 1541
		private const int GLOBALSDKTYPEVALUE = 2;

		// Token: 0x04000606 RID: 1542
		private static string BasePkgId = "";

		// Token: 0x04000607 RID: 1543
		private static string BasePkgName = "";

		// Token: 0x04000608 RID: 1544
		private static string BaseChannelId = "";

		// Token: 0x04000609 RID: 1545
		private static string BaseChannelName = "";

		// Token: 0x0400060A RID: 1546
		private static string BaseChannelOp = "";

		// Token: 0x0400060B RID: 1547
		private static string BaseLanguage = "";

		// Token: 0x0400060C RID: 1548
		private static string BaseRoleName = "";

		// Token: 0x0400060D RID: 1549
		private static string BaseServerName = "";

		// Token: 0x0400060E RID: 1550
		private static string BaseServerId = "";

		// Token: 0x0400060F RID: 1551
		private static string BaseRoleId = "";

		// Token: 0x04000610 RID: 1552
		private static string LoginId = "";

		// Token: 0x04000611 RID: 1553
		private static string BaseGameVersion = "";

		// Token: 0x04000612 RID: 1554
		private static string BaseSdkVersion = "";

		// Token: 0x04000613 RID: 1555
		private static string BaseDid = "";

		// Token: 0x04000614 RID: 1556
		private static string BaseUserId = "";

		// Token: 0x04000615 RID: 1557
		private static string BaseInitTime = "";

		// Token: 0x04000616 RID: 1558
		private static string BaseGameId = "";

		// Token: 0x04000617 RID: 1559
		private static string BaseAccessId = "";

		// Token: 0x04000618 RID: 1560
		private static long BasePuid = 0L;

		// Token: 0x04000619 RID: 1561
		public long event_time_ms;

		// Token: 0x0400061A RID: 1562
		public int event_id;

		// Token: 0x0400061B RID: 1563
		public string event_name = "";

		// Token: 0x0400061C RID: 1564
		public string event_uuid = "";

		// Token: 0x0400061D RID: 1565
		public string did = "";

		// Token: 0x0400061E RID: 1566
		public string language = "";

		// Token: 0x0400061F RID: 1567
		public string timezone = "";

		// Token: 0x04000620 RID: 1568
		public string user_id = "";

		// Token: 0x04000621 RID: 1569
		public string game_id = "";

		// Token: 0x04000622 RID: 1570
		public string game_name = "Aki";

		// Token: 0x04000623 RID: 1571
		public string pkg_id = "";

		// Token: 0x04000624 RID: 1572
		public string pkg_name = "";

		// Token: 0x04000625 RID: 1573
		public string channel_id = "";

		// Token: 0x04000626 RID: 1574
		public string channel_name = "";

		// Token: 0x04000627 RID: 1575
		public string channel_op = "";

		// Token: 0x04000628 RID: 1576
		public string role_id = "";

		// Token: 0x04000629 RID: 1577
		public string role_name = "";

		// Token: 0x0400062A RID: 1578
		public string server_id = "";

		// Token: 0x0400062B RID: 1579
		public string server_name = "";

		// Token: 0x0400062C RID: 1580
		public string sdk_version = "";

		// Token: 0x0400062D RID: 1581
		public string game_version = "";

		// Token: 0x0400062E RID: 1582
		public string login_id = "";

		// Token: 0x0400062F RID: 1583
		public string os = "PS5";

		// Token: 0x04000630 RID: 1584
		public string last_phone_open_ts = "";

		// Token: 0x04000631 RID: 1585
		public int sdk_type = 2;

		// Token: 0x04000632 RID: 1586
		public string psn_access_id = "";

		// Token: 0x04000633 RID: 1587
		public long puid;
	}
}
