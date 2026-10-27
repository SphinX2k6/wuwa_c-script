using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FE7 RID: 28647
	public class ISetEntityTagT
	{
		// Token: 0x1700D4B4 RID: 54452
		// (get) Token: 0x06032A68 RID: 207464 RVA: 0x006D55EB File Offset: 0x006D37EB
		// (set) Token: 0x06032A69 RID: 207465 RVA: 0x006D55F3 File Offset: 0x006D37F3
		public int EntityId { get; set; }

		// Token: 0x1700D4B5 RID: 54453
		// (get) Token: 0x06032A6A RID: 207466 RVA: 0x006D55FC File Offset: 0x006D37FC
		// (set) Token: 0x06032A6B RID: 207467 RVA: 0x006D5604 File Offset: 0x006D3804
		public string GameplayTag { get; set; }

		// Token: 0x1700D4B6 RID: 54454
		// (get) Token: 0x06032A6C RID: 207468 RVA: 0x006D560D File Offset: 0x006D380D
		// (set) Token: 0x06032A6D RID: 207469 RVA: 0x006D5615 File Offset: 0x006D3815
		public ESetEntityTagType SetType { get; set; }

		// Token: 0x1700D4B7 RID: 54455
		// (get) Token: 0x06032A6E RID: 207470 RVA: 0x006D561E File Offset: 0x006D381E
		// (set) Token: 0x06032A6F RID: 207471 RVA: 0x006D5626 File Offset: 0x006D3826
		public float DelayTime { get; set; }

		// Token: 0x1700D4B8 RID: 54456
		// (get) Token: 0x06032A70 RID: 207472 RVA: 0x006D562F File Offset: 0x006D382F
		// (set) Token: 0x06032A71 RID: 207473 RVA: 0x006D5637 File Offset: 0x006D3837
		public bool BeforeHide { get; set; }

		// Token: 0x1700D4B9 RID: 54457
		// (get) Token: 0x06032A72 RID: 207474 RVA: 0x006D5640 File Offset: 0x006D3840
		// (set) Token: 0x06032A73 RID: 207475 RVA: 0x006D5648 File Offset: 0x006D3848
		public byte NullMask { get; set; }

		// Token: 0x06032A74 RID: 207476 RVA: 0x006D5651 File Offset: 0x006D3851
		public ISetEntityTagT()
		{
			this.EntityId = 0;
			this.GameplayTag = null;
			this.SetType = ESetEntityTagType.Add;
			this.DelayTime = 0f;
			this.BeforeHide = false;
			this.NullMask = 0;
		}
	}
}
