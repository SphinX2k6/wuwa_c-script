using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C7 RID: 16839
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonBaseCardComponentData : ICommonBaseCardComponentData
	{
		// Token: 0x170055A6 RID: 21926
		// (get) Token: 0x0602A9BB RID: 174523 RVA: 0x00C033EF File Offset: 0x00C015EF
		// (set) Token: 0x0602A9BC RID: 174524 RVA: 0x00C033F7 File Offset: 0x00C015F7
		public int CardId { get; set; }

		// Token: 0x170055A7 RID: 21927
		// (get) Token: 0x0602A9BD RID: 174525 RVA: 0x00C03400 File Offset: 0x00C01600
		// (set) Token: 0x0602A9BE RID: 174526 RVA: 0x00C03408 File Offset: 0x00C01608
		public int Cost { get; set; }

		// Token: 0x170055A8 RID: 21928
		// (get) Token: 0x0602A9BF RID: 174527 RVA: 0x00C03411 File Offset: 0x00C01611
		// (set) Token: 0x0602A9C0 RID: 174528 RVA: 0x00C03419 File Offset: 0x00C01619
		public int Attack { get; set; }

		// Token: 0x170055A9 RID: 21929
		// (get) Token: 0x0602A9C1 RID: 174529 RVA: 0x00C03422 File Offset: 0x00C01622
		// (set) Token: 0x0602A9C2 RID: 174530 RVA: 0x00C0342A File Offset: 0x00C0162A
		public int Life { get; set; }

		// Token: 0x170055AA RID: 21930
		// (get) Token: 0x0602A9C3 RID: 174531 RVA: 0x00C03433 File Offset: 0x00C01633
		// (set) Token: 0x0602A9C4 RID: 174532 RVA: 0x00C0343B File Offset: 0x00C0163B
		public int Element { get; set; }

		// Token: 0x170055AB RID: 21931
		// (get) Token: 0x0602A9C5 RID: 174533 RVA: 0x00C03444 File Offset: 0x00C01644
		// (set) Token: 0x0602A9C6 RID: 174534 RVA: 0x00C0344C File Offset: 0x00C0164C
		public bool ShowCardFaceTexture { get; set; }

		// Token: 0x170055AC RID: 21932
		// (get) Token: 0x0602A9C7 RID: 174535 RVA: 0x00C03455 File Offset: 0x00C01655
		// (set) Token: 0x0602A9C8 RID: 174536 RVA: 0x00C0345D File Offset: 0x00C0165D
		public bool OutlookUnlocked { get; set; }

		// Token: 0x170055AD RID: 21933
		// (get) Token: 0x0602A9C9 RID: 174537 RVA: 0x00C03466 File Offset: 0x00C01666
		// (set) Token: 0x0602A9CA RID: 174538 RVA: 0x00C0346E File Offset: 0x00C0166E
		public string CardFaceTexturePath { get; set; }

		// Token: 0x170055AE RID: 21934
		// (get) Token: 0x0602A9CB RID: 174539 RVA: 0x00C03477 File Offset: 0x00C01677
		// (set) Token: 0x0602A9CC RID: 174540 RVA: 0x00C0347F File Offset: 0x00C0167F
		public EToggleState? ToggleState { get; set; }

		// Token: 0x170055AF RID: 21935
		// (get) Token: 0x0602A9CD RID: 174541 RVA: 0x00C03488 File Offset: 0x00C01688
		// (set) Token: 0x0602A9CE RID: 174542 RVA: 0x00C03490 File Offset: 0x00C01690
		public Action OnPointerUp { get; set; }

		// Token: 0x170055B0 RID: 21936
		// (get) Token: 0x0602A9CF RID: 174543 RVA: 0x00C03499 File Offset: 0x00C01699
		// (set) Token: 0x0602A9D0 RID: 174544 RVA: 0x00C034A1 File Offset: 0x00C016A1
		public Action<EToggleState> OnToggleStateChanged { get; set; }

		// Token: 0x170055B1 RID: 21937
		// (get) Token: 0x0602A9D1 RID: 174545 RVA: 0x00C034AA File Offset: 0x00C016AA
		// (set) Token: 0x0602A9D2 RID: 174546 RVA: 0x00C034B2 File Offset: 0x00C016B2
		public Func<bool> CanToggleExecuteChange { get; set; }
	}
}
