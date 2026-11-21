using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200025E RID: 606
	[NullableContext(2)]
	[Nullable(0)]
	public class EntryJson
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x0005B6E4 File Offset: 0x000598E4
		public EntryJson()
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0005B6EC File Offset: 0x000598EC
		[NullableContext(1)]
		public EntryJson(EntryJson defaultObject, [Nullable(2)] EntryJson overrideObj)
		{
			this.CdnUrl = ((overrideObj != null && overrideObj.CdnUrl != null) ? overrideObj.CdnUrl : ((defaultObject != null) ? defaultObject.CdnUrl : null));
			this.SpeedRatio = ((overrideObj != null && overrideObj.SpeedRatio != null) ? overrideObj.SpeedRatio : new float?(((defaultObject != null) ? defaultObject.SpeedRatio : null).GetValueOrDefault()));
			this.PriceRatio = ((overrideObj != null && overrideObj.PriceRatio != null) ? overrideObj.PriceRatio : new float?(((defaultObject != null) ? defaultObject.PriceRatio : null).GetValueOrDefault()));
			this.NoticeUrl = ((overrideObj != null && overrideObj.NoticeUrl != null) ? overrideObj.NoticeUrl : ((defaultObject != null) ? defaultObject.NoticeUrl : null));
			this.LoginServers = ((overrideObj != null && overrideObj.LoginServers != null) ? overrideObj.LoginServers : ((defaultObject != null) ? defaultObject.LoginServers : null));
			this.PrivateServers = ((overrideObj != null && overrideObj.PrivateServers != null) ? overrideObj.PrivateServers : ((defaultObject != null) ? defaultObject.PrivateServers : null));
			this.GmOpen = ((overrideObj != null && overrideObj.GmOpen != null) ? overrideObj.GmOpen : new bool?(((defaultObject != null) ? defaultObject.GmOpen : null).GetValueOrDefault()));
			this.RptOpen = ((overrideObj != null && overrideObj.RptOpen != null) ? overrideObj.RptOpen : new bool?(((defaultObject != null) ? defaultObject.RptOpen : null).GetValueOrDefault(true)));
			this.AsyncCheck = ((overrideObj != null && overrideObj.AsyncCheck != null) ? overrideObj.AsyncCheck : new bool?(((defaultObject != null) ? defaultObject.AsyncCheck : null).GetValueOrDefault()));
			this.NewHttpTimer = ((overrideObj != null && overrideObj.NewHttpTimer != null) ? overrideObj.NewHttpTimer : new bool?(((defaultObject != null) ? defaultObject.NewHttpTimer : null).GetValueOrDefault(true)));
			this.NewHttpApi = ((overrideObj != null && overrideObj.NewHttpApi != null) ? overrideObj.NewHttpApi : new bool?(((defaultObject != null) ? defaultObject.NewHttpApi : null).GetValueOrDefault(true)));
			this.GARUrl = ((overrideObj != null && overrideObj.GARUrl != null) ? overrideObj.GARUrl : (((defaultObject != null) ? defaultObject.GARUrl : null) ?? ""));
			this.GARUrls = ((overrideObj != null && overrideObj.GARUrls != null) ? overrideObj.GARUrls : (((defaultObject != null) ? defaultObject.GARUrls : null) ?? Array.Empty<string>()));
			this.TDCfg = ((overrideObj != null && overrideObj.TDCfg != null) ? overrideObj.TDCfg : ((defaultObject != null) ? defaultObject.TDCfg : null));
			this.KDCfg = ((overrideObj != null && overrideObj.KDCfg != null) ? overrideObj.KDCfg : ((defaultObject != null) ? defaultObject.KDCfg : null));
			this.ServerTimeUrl = ((overrideObj != null && overrideObj.ServerTimeUrl != null) ? overrideObj.ServerTimeUrl : (((defaultObject != null) ? defaultObject.ServerTimeUrl : null) ?? Array.Empty<string>()));
			this.LogReport = ((overrideObj != null && overrideObj.LogReport != null) ? overrideObj.LogReport : ((defaultObject != null) ? defaultObject.LogReport : null));
			this.IosAuditFirstDownloadTip = ((overrideObj != null && overrideObj.IosAuditFirstDownloadTip != null) ? overrideObj.IosAuditFirstDownloadTip : new bool?(((defaultObject != null) ? defaultObject.IosAuditFirstDownloadTip : null).GetValueOrDefault()));
			this.MixUri = ((overrideObj != null && overrideObj.MixUri != null) ? overrideObj.MixUri : (((defaultObject != null) ? defaultObject.MixUri : null) ?? ""));
			this.ResUri = ((overrideObj != null && overrideObj.ResUri != null) ? overrideObj.ResUri : (((defaultObject != null) ? defaultObject.ResUri : null) ?? ""));
			this.GachaUrl = ((overrideObj != null && overrideObj.GachaUrl != null) ? overrideObj.GachaUrl : ((defaultObject != null) ? defaultObject.GachaUrl : null));
			this.PackageUpdateUrl = ((overrideObj != null && overrideObj.PackageUpdateUrl != null) ? overrideObj.PackageUpdateUrl : ((defaultObject != null) ? defaultObject.PackageUpdateUrl : null));
			this.PackageUpdateDescUrl = ((overrideObj != null && overrideObj.PackageUpdateDescUrl != null) ? overrideObj.PackageUpdateDescUrl : ((defaultObject != null) ? defaultObject.PackageUpdateDescUrl : null));
			this.ParallelPackageDescUrl = ((overrideObj != null && overrideObj.ParallelPackageDescUrl != null) ? overrideObj.ParallelPackageDescUrl : ((defaultObject != null) ? defaultObject.ParallelPackageDescUrl : null));
			this.GrayBox = ((overrideObj != null && overrideObj.GrayBox != null) ? overrideObj.GrayBox : ((defaultObject != null) ? defaultObject.GrayBox : null));
			this.VulkanSettings = ((overrideObj != null && overrideObj.VulkanSettings != null) ? overrideObj.VulkanSettings : ((defaultObject != null) ? defaultObject.VulkanSettings : null));
			this.SDKEnvironment = ((overrideObj != null && overrideObj.SDKEnvironment != null) ? overrideObj.SDKEnvironment : ((defaultObject != null) ? defaultObject.SDKEnvironment : null));
			this.UdpDelay = ((overrideObj != null && overrideObj.UdpDelay != null) ? overrideObj.UdpDelay : ((defaultObject != null) ? defaultObject.UdpDelay : null));
			this.CdnEvalCfg = ((overrideObj != null && overrideObj.CdnEvalCfg != null) ? overrideObj.CdnEvalCfg : ((defaultObject != null) ? defaultObject.CdnEvalCfg : null));
			this.CdnScoreCfg = ((overrideObj != null && overrideObj.CdnScoreCfg != null) ? overrideObj.CdnScoreCfg : ((defaultObject != null) ? defaultObject.CdnScoreCfg : null));
		}

		// Token: 0x040009FC RID: 2556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICdnUrlData> CdnUrl;

		// Token: 0x040009FD RID: 2557
		public float? SpeedRatio;

		// Token: 0x040009FE RID: 2558
		public float? PriceRatio;

		// Token: 0x040009FF RID: 2559
		public string NoticeUrl;

		// Token: 0x04000A00 RID: 2560
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ILoginServersData> LoginServers;

		// Token: 0x04000A01 RID: 2561
		public IPrivateServersData PrivateServers;

		// Token: 0x04000A02 RID: 2562
		public bool? GmOpen;

		// Token: 0x04000A03 RID: 2563
		public bool? RptOpen;

		// Token: 0x04000A04 RID: 2564
		public bool? AsyncCheck;

		// Token: 0x04000A05 RID: 2565
		public bool? NewHttpTimer;

		// Token: 0x04000A06 RID: 2566
		public bool? NewHttpApi;

		// Token: 0x04000A07 RID: 2567
		public string GARUrl;

		// Token: 0x04000A08 RID: 2568
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GARUrls;

		// Token: 0x04000A09 RID: 2569
		public ITDConfig TDCfg;

		// Token: 0x04000A0A RID: 2570
		public ITDConfig KDCfg;

		// Token: 0x04000A0B RID: 2571
		[Nullable(1)]
		public string[] ServerTimeUrl;

		// Token: 0x04000A0C RID: 2572
		public ILogReport LogReport;

		// Token: 0x04000A0D RID: 2573
		public IUpdateUrl PackageUpdateUrl;

		// Token: 0x04000A0E RID: 2574
		public IUpdateUrl PackageUpdateDescUrl;

		// Token: 0x04000A0F RID: 2575
		public IUpdateUrl ParallelPackageDescUrl;

		// Token: 0x04000A10 RID: 2576
		public bool? IosAuditFirstDownloadTip;

		// Token: 0x04000A11 RID: 2577
		public string MixUri;

		// Token: 0x04000A12 RID: 2578
		public string ResUri;

		// Token: 0x04000A13 RID: 2579
		public IGachaUrl GachaUrl;

		// Token: 0x04000A14 RID: 2580
		public IGrayBoxConfig GrayBox;

		// Token: 0x04000A15 RID: 2581
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, VulkanSettingConfig> VulkanSettings;

		// Token: 0x04000A16 RID: 2582
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, IUdpRegion> UdpDelay;

		// Token: 0x04000A17 RID: 2583
		public IEvalConfig CdnEvalCfg;

		// Token: 0x04000A18 RID: 2584
		public ICdnScoreCfg CdnScoreCfg;

		// Token: 0x04000A19 RID: 2585
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> SDKEnvironment;
	}
}
