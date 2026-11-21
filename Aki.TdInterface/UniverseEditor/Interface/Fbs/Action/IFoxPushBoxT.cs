using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF4 RID: 28404
	public class IFoxPushBoxT
	{
		// Token: 0x1700D04C RID: 53324
		// (get) Token: 0x06031261 RID: 201313 RVA: 0x006A98BD File Offset: 0x006A7ABD
		// (set) Token: 0x06031262 RID: 201314 RVA: 0x006A98C5 File Offset: 0x006A7AC5
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D04D RID: 53325
		// (get) Token: 0x06031263 RID: 201315 RVA: 0x006A98CE File Offset: 0x006A7ACE
		// (set) Token: 0x06031264 RID: 201316 RVA: 0x006A98D6 File Offset: 0x006A7AD6
		public int EntityId { get; set; }

		// Token: 0x1700D04E RID: 53326
		// (get) Token: 0x06031265 RID: 201317 RVA: 0x006A98DF File Offset: 0x006A7ADF
		// (set) Token: 0x06031266 RID: 201318 RVA: 0x006A98E7 File Offset: 0x006A7AE7
		public int CollisionRadius { get; set; }

		// Token: 0x1700D04F RID: 53327
		// (get) Token: 0x06031267 RID: 201319 RVA: 0x006A98F0 File Offset: 0x006A7AF0
		// (set) Token: 0x06031268 RID: 201320 RVA: 0x006A98F8 File Offset: 0x006A7AF8
		public int SplineEntityId { get; set; }

		// Token: 0x1700D050 RID: 53328
		// (get) Token: 0x06031269 RID: 201321 RVA: 0x006A9901 File Offset: 0x006A7B01
		// (set) Token: 0x0603126A RID: 201322 RVA: 0x006A9909 File Offset: 0x006A7B09
		public string SendEntityEventOnSplineFinish { get; set; }

		// Token: 0x0603126B RID: 201323 RVA: 0x006A9912 File Offset: 0x006A7B12
		public IFoxPushBoxT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.EntityId = 0;
			this.CollisionRadius = 0;
			this.SplineEntityId = 0;
			this.SendEntityEventOnSplineFinish = null;
		}
	}
}
