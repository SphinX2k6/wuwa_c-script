using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000259 RID: 601
	[NullableContext(2)]
	[Nullable(0)]
	public class EntryJson
	{
		// Token: 0x06000F1E RID: 3870 RVA: 0x000588B8 File Offset: 0x00056AB8
		public EntryJson()
		{
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000588C0 File Offset: 0x00056AC0
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
			this.SDKEnvironment = ((overrideObj != null && overrideObj.SDKEnvironment != null) ? overrideObj.SDKEnvironment : ((defaultObject != null) ? defaultObject.SDKEnvironment : null));
			this.UdpDelay = ((overrideObj != null && overrideObj.UdpDelay != null) ? overrideObj.UdpDelay : ((defaultObject != null) ? defaultObject.UdpDelay : null));
			this.CdnEvalCfg = ((overrideObj != null && overrideObj.CdnEvalCfg != null) ? overrideObj.CdnEvalCfg : ((defaultObject != null) ? defaultObject.CdnEvalCfg : null));
			this.CdnScoreCfg = ((overrideObj != null && overrideObj.CdnScoreCfg != null) ? overrideObj.CdnScoreCfg : ((defaultObject != null) ? defaultObject.CdnScoreCfg : null));
		}

		// Token: 0x040009B2 RID: 2482
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ICdnUrlData> CdnUrl;

		// Token: 0x040009B3 RID: 2483
		public float? SpeedRatio;

		// Token: 0x040009B4 RID: 2484
		public float? PriceRatio;

		// Token: 0x040009B5 RID: 2485
		public string NoticeUrl;

		// Token: 0x040009B6 RID: 2486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ILoginServersData> LoginServers;

		// Token: 0x040009B7 RID: 2487
		public IPrivateServersData PrivateServers;

		// Token: 0x040009B8 RID: 2488
		public bool? GmOpen;

		// Token: 0x040009B9 RID: 2489
		public bool? RptOpen;

		// Token: 0x040009BA RID: 2490
		public bool? AsyncCheck;

		// Token: 0x040009BB RID: 2491
		public bool? NewHttpTimer;

		// Token: 0x040009BC RID: 2492
		public bool? NewHttpApi;

		// Token: 0x040009BD RID: 2493
		public string GARUrl;

		// Token: 0x040009BE RID: 2494
		public ITDConfig TDCfg;

		// Token: 0x040009BF RID: 2495
		public ITDConfig KDCfg;

		// Token: 0x040009C0 RID: 2496
		[Nullable(1)]
		public string[] ServerTimeUrl;

		// Token: 0x040009C1 RID: 2497
		public ILogReport LogReport;

		// Token: 0x040009C2 RID: 2498
		public IUpdateUrl PackageUpdateUrl;

		// Token: 0x040009C3 RID: 2499
		public IUpdateUrl PackageUpdateDescUrl;

		// Token: 0x040009C4 RID: 2500
		public IUpdateUrl ParallelPackageDescUrl;

		// Token: 0x040009C5 RID: 2501
		public bool? IosAuditFirstDownloadTip;

		// Token: 0x040009C6 RID: 2502
		public string MixUri;

		// Token: 0x040009C7 RID: 2503
		public string ResUri;

		// Token: 0x040009C8 RID: 2504
		public IGachaUrl GachaUrl;

		// Token: 0x040009C9 RID: 2505
		public IGrayBoxConfig GrayBox;

		// Token: 0x040009CA RID: 2506
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, IUdpRegion> UdpDelay;

		// Token: 0x040009CB RID: 2507
		public IEvalConfig CdnEvalCfg;

		// Token: 0x040009CC RID: 2508
		public ICdnScoreCfg CdnScoreCfg;

		// Token: 0x040009CD RID: 2509
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, string> SDKEnvironment;
	}
}
