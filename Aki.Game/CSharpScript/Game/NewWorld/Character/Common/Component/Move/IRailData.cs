using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063A5 RID: 25509
	[NullableContext(2)]
	public interface IRailData
	{
		// Token: 0x1700756C RID: 30060
		// (get) Token: 0x0603DD7A RID: 253306
		// (set) Token: 0x0603DD7B RID: 253307
		int RailSplineEntityId { get; set; }

		// Token: 0x1700756D RID: 30061
		// (get) Token: 0x0603DD7C RID: 253308
		// (set) Token: 0x0603DD7D RID: 253309
		float? SlideSpeed { get; set; }

		// Token: 0x1700756E RID: 30062
		// (get) Token: 0x0603DD7E RID: 253310
		// (set) Token: 0x0603DD7F RID: 253311
		float? UpSpeed { get; set; }

		// Token: 0x1700756F RID: 30063
		// (get) Token: 0x0603DD80 RID: 253312
		// (set) Token: 0x0603DD81 RID: 253313
		float? DownSpeed { get; set; }

		// Token: 0x17007570 RID: 30064
		// (get) Token: 0x0603DD82 RID: 253314
		// (set) Token: 0x0603DD83 RID: 253315
		[Nullable(new byte[]
		{
			2,
			1
		})]
		IExchangeSlideRailConfig[] ExchangeRailConfigs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007571 RID: 30065
		// (get) Token: 0x0603DD84 RID: 253316
		// (set) Token: 0x0603DD85 RID: 253317
		ISlopeSlidePerform SlidePerformConfig { get; set; }
	}
}
