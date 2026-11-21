using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.VisualNovel;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A66 RID: 23142
	public sealed class SolarSchoolVisualNovelActionCenter : VisualNovelActionCenter
	{
		// Token: 0x06039025 RID: 233509 RVA: 0x00FF81C0 File Offset: 0x00FF63C0
		public SolarSchoolVisualNovelActionCenter()
		{
			base.InitPerformance(EVisualNovelPerformanceType.ActivityAction, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new SolarSchoolVisualNovelActivityAction(context, performance));
			base.InitPerformance(EVisualNovelPerformanceType.Transition, (VisualNovelContext context, IVisualNovelPerformanceBase performance) => new SolarSchoolVisualNovelTransitionAction(context, performance, this.RootView));
		}

		// Token: 0x06039026 RID: 233510 RVA: 0x00FF820E File Offset: 0x00FF640E
		[NullableContext(1)]
		public void BindRootView(SolarSchoolRootView rootView)
		{
			this.RootView = rootView;
		}

		// Token: 0x06039027 RID: 233511 RVA: 0x00FF8217 File Offset: 0x00FF6417
		public void ClearRootView()
		{
			this.RootView = null;
		}

		// Token: 0x0401E00F RID: 122895
		[Nullable(2)]
		private SolarSchoolRootView RootView;
	}
}
