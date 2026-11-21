using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FDC RID: 24540
	public class IStreamingRenderConfigT
	{
		// Token: 0x1700B5F4 RID: 46580
		// (get) Token: 0x0602957E RID: 169342 RVA: 0x005A5118 File Offset: 0x005A3318
		// (set) Token: 0x0602957F RID: 169343 RVA: 0x005A5120 File Offset: 0x005A3320
		public TPortalViewDistanceConfigUnion ViewDistance { get; set; }

		// Token: 0x1700B5F5 RID: 46581
		// (get) Token: 0x06029580 RID: 169344 RVA: 0x005A5129 File Offset: 0x005A3329
		// (set) Token: 0x06029581 RID: 169345 RVA: 0x005A5131 File Offset: 0x005A3331
		public List<IActorRefT> ForceRenderActors { get; set; }

		// Token: 0x1700B5F6 RID: 46582
		// (get) Token: 0x06029582 RID: 169346 RVA: 0x005A513A File Offset: 0x005A333A
		// (set) Token: 0x06029583 RID: 169347 RVA: 0x005A5142 File Offset: 0x005A3342
		public List<IRenderFlagT> SetRenderFlags { get; set; }

		// Token: 0x1700B5F7 RID: 46583
		// (get) Token: 0x06029584 RID: 169348 RVA: 0x005A514B File Offset: 0x005A334B
		// (set) Token: 0x06029585 RID: 169349 RVA: 0x005A5153 File Offset: 0x005A3353
		public IStreamingRtEffectRefT RtEffectRef { get; set; }

		// Token: 0x1700B5F8 RID: 46584
		// (get) Token: 0x06029586 RID: 169350 RVA: 0x005A515C File Offset: 0x005A335C
		// (set) Token: 0x06029587 RID: 169351 RVA: 0x005A5164 File Offset: 0x005A3364
		public IRtSizeT RtData { get; set; }

		// Token: 0x1700B5F9 RID: 46585
		// (get) Token: 0x06029588 RID: 169352 RVA: 0x005A516D File Offset: 0x005A336D
		// (set) Token: 0x06029589 RID: 169353 RVA: 0x005A5175 File Offset: 0x005A3375
		public string FallbackCubeMapTexturePath { get; set; }

		// Token: 0x1700B5FA RID: 46586
		// (get) Token: 0x0602958A RID: 169354 RVA: 0x005A517E File Offset: 0x005A337E
		// (set) Token: 0x0602958B RID: 169355 RVA: 0x005A5186 File Offset: 0x005A3386
		public string FallbackCubeMapKey { get; set; }

		// Token: 0x1700B5FB RID: 46587
		// (get) Token: 0x0602958C RID: 169356 RVA: 0x005A518F File Offset: 0x005A338F
		// (set) Token: 0x0602958D RID: 169357 RVA: 0x005A5197 File Offset: 0x005A3397
		public byte NullMask { get; set; }

		// Token: 0x0602958E RID: 169358 RVA: 0x005A51A0 File Offset: 0x005A33A0
		public IStreamingRenderConfigT()
		{
			this.ViewDistance = null;
			this.ForceRenderActors = null;
			this.SetRenderFlags = null;
			this.RtEffectRef = null;
			this.RtData = null;
			this.FallbackCubeMapTexturePath = null;
			this.FallbackCubeMapKey = null;
			this.NullMask = 0;
		}
	}
}
