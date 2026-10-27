using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051F7 RID: 20983
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonBaseCardComponentData : ICommonBaseCardComponentData
	{
		// Token: 0x170081E6 RID: 33254
		// (get) Token: 0x06035AC0 RID: 219840 RVA: 0x00CB5DB3 File Offset: 0x00CB3FB3
		// (set) Token: 0x06035AC1 RID: 219841 RVA: 0x00CB5DBB File Offset: 0x00CB3FBB
		public int CardId { get; set; }

		// Token: 0x170081E7 RID: 33255
		// (get) Token: 0x06035AC2 RID: 219842 RVA: 0x00CB5DC4 File Offset: 0x00CB3FC4
		// (set) Token: 0x06035AC3 RID: 219843 RVA: 0x00CB5DCC File Offset: 0x00CB3FCC
		public int Cost { get; set; }

		// Token: 0x170081E8 RID: 33256
		// (get) Token: 0x06035AC4 RID: 219844 RVA: 0x00CB5DD5 File Offset: 0x00CB3FD5
		// (set) Token: 0x06035AC5 RID: 219845 RVA: 0x00CB5DDD File Offset: 0x00CB3FDD
		public int Attack { get; set; }

		// Token: 0x170081E9 RID: 33257
		// (get) Token: 0x06035AC6 RID: 219846 RVA: 0x00CB5DE6 File Offset: 0x00CB3FE6
		// (set) Token: 0x06035AC7 RID: 219847 RVA: 0x00CB5DEE File Offset: 0x00CB3FEE
		public int Life { get; set; }

		// Token: 0x170081EA RID: 33258
		// (get) Token: 0x06035AC8 RID: 219848 RVA: 0x00CB5DF7 File Offset: 0x00CB3FF7
		// (set) Token: 0x06035AC9 RID: 219849 RVA: 0x00CB5DFF File Offset: 0x00CB3FFF
		public int Element { get; set; }

		// Token: 0x170081EB RID: 33259
		// (get) Token: 0x06035ACA RID: 219850 RVA: 0x00CB5E08 File Offset: 0x00CB4008
		// (set) Token: 0x06035ACB RID: 219851 RVA: 0x00CB5E10 File Offset: 0x00CB4010
		public bool ShowCardFaceTexture { get; set; }

		// Token: 0x170081EC RID: 33260
		// (get) Token: 0x06035ACC RID: 219852 RVA: 0x00CB5E19 File Offset: 0x00CB4019
		// (set) Token: 0x06035ACD RID: 219853 RVA: 0x00CB5E21 File Offset: 0x00CB4021
		public bool OutlookUnlocked { get; set; }

		// Token: 0x170081ED RID: 33261
		// (get) Token: 0x06035ACE RID: 219854 RVA: 0x00CB5E2A File Offset: 0x00CB402A
		// (set) Token: 0x06035ACF RID: 219855 RVA: 0x00CB5E32 File Offset: 0x00CB4032
		public string CardFaceTexturePath { get; set; }

		// Token: 0x170081EE RID: 33262
		// (get) Token: 0x06035AD0 RID: 219856 RVA: 0x00CB5E3B File Offset: 0x00CB403B
		// (set) Token: 0x06035AD1 RID: 219857 RVA: 0x00CB5E43 File Offset: 0x00CB4043
		public EToggleState? ToggleState { get; set; }

		// Token: 0x170081EF RID: 33263
		// (get) Token: 0x06035AD2 RID: 219858 RVA: 0x00CB5E4C File Offset: 0x00CB404C
		// (set) Token: 0x06035AD3 RID: 219859 RVA: 0x00CB5E54 File Offset: 0x00CB4054
		public Action OnPointerUp { get; set; }

		// Token: 0x170081F0 RID: 33264
		// (get) Token: 0x06035AD4 RID: 219860 RVA: 0x00CB5E5D File Offset: 0x00CB405D
		// (set) Token: 0x06035AD5 RID: 219861 RVA: 0x00CB5E65 File Offset: 0x00CB4065
		public Action<EToggleState> OnToggleStateChanged { get; set; }

		// Token: 0x170081F1 RID: 33265
		// (get) Token: 0x06035AD6 RID: 219862 RVA: 0x00CB5E6E File Offset: 0x00CB406E
		// (set) Token: 0x06035AD7 RID: 219863 RVA: 0x00CB5E76 File Offset: 0x00CB4076
		public Func<bool> CanToggleExecuteChange { get; set; }
	}
}
