using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063A6 RID: 25510
	[NullableContext(2)]
	[Nullable(0)]
	public class RailDataImpl : IRailData
	{
		// Token: 0x17007572 RID: 30066
		// (get) Token: 0x0603DD86 RID: 253318 RVA: 0x011F1C53 File Offset: 0x011EFE53
		// (set) Token: 0x0603DD87 RID: 253319 RVA: 0x011F1C5B File Offset: 0x011EFE5B
		public int RailSplineEntityId { get; set; }

		// Token: 0x17007573 RID: 30067
		// (get) Token: 0x0603DD88 RID: 253320 RVA: 0x011F1C64 File Offset: 0x011EFE64
		// (set) Token: 0x0603DD89 RID: 253321 RVA: 0x011F1C6C File Offset: 0x011EFE6C
		public float? SlideSpeed { get; set; }

		// Token: 0x17007574 RID: 30068
		// (get) Token: 0x0603DD8A RID: 253322 RVA: 0x011F1C75 File Offset: 0x011EFE75
		// (set) Token: 0x0603DD8B RID: 253323 RVA: 0x011F1C7D File Offset: 0x011EFE7D
		public float? UpSpeed { get; set; }

		// Token: 0x17007575 RID: 30069
		// (get) Token: 0x0603DD8C RID: 253324 RVA: 0x011F1C86 File Offset: 0x011EFE86
		// (set) Token: 0x0603DD8D RID: 253325 RVA: 0x011F1C8E File Offset: 0x011EFE8E
		public float? DownSpeed { get; set; }

		// Token: 0x17007576 RID: 30070
		// (get) Token: 0x0603DD8E RID: 253326 RVA: 0x011F1C97 File Offset: 0x011EFE97
		// (set) Token: 0x0603DD8F RID: 253327 RVA: 0x011F1C9F File Offset: 0x011EFE9F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IExchangeSlideRailConfig[] ExchangeRailConfigs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007577 RID: 30071
		// (get) Token: 0x0603DD90 RID: 253328 RVA: 0x011F1CA8 File Offset: 0x011EFEA8
		// (set) Token: 0x0603DD91 RID: 253329 RVA: 0x011F1CB0 File Offset: 0x011EFEB0
		public ISlopeSlidePerform SlidePerformConfig { get; set; }

		// Token: 0x0603DD92 RID: 253330 RVA: 0x011F1CBC File Offset: 0x011EFEBC
		[NullableContext(1)]
		public static RailDataImpl FromSlideRailComponent(SlideRailComponent comp)
		{
			RailDataImpl railDataImpl = new RailDataImpl();
			railDataImpl.RailSplineEntityId = comp.RailSplineEntityId;
			int? num = comp.SlideSpeed;
			railDataImpl.SlideSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			num = comp.UpSpeed;
			railDataImpl.UpSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			num = comp.DownSpeed;
			railDataImpl.DownSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			List<IExchangeSlideRailConfig> exchangeRailConfigs = comp.ExchangeRailConfigs;
			railDataImpl.ExchangeRailConfigs = ((exchangeRailConfigs != null) ? exchangeRailConfigs.ToArray() : null);
			railDataImpl.SlidePerformConfig = null;
			return railDataImpl;
		}

		// Token: 0x0603DD93 RID: 253331 RVA: 0x011F1D84 File Offset: 0x011EFF84
		[NullableContext(1)]
		public static RailDataImpl FromSlidePerformComponent(SlidePerformComponent comp)
		{
			RailDataImpl railDataImpl = new RailDataImpl();
			railDataImpl.RailSplineEntityId = comp.RailSplineEntityId;
			int? num = comp.SlideSpeed;
			railDataImpl.SlideSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			num = comp.UpSpeed;
			railDataImpl.UpSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			num = comp.DownSpeed;
			railDataImpl.DownSpeed = ((num != null) ? new float?((float)num.GetValueOrDefault()) : null);
			List<IExchangeSlideRailConfig> exchangeRailConfigs = comp.ExchangeRailConfigs;
			railDataImpl.ExchangeRailConfigs = ((exchangeRailConfigs != null) ? exchangeRailConfigs.ToArray() : null);
			railDataImpl.SlidePerformConfig = comp.SlidePerformConfig;
			return railDataImpl;
		}
	}
}
