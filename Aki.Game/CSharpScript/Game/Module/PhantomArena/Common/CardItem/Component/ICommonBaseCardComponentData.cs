using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C6 RID: 16838
	[NullableContext(1)]
	public interface ICommonBaseCardComponentData
	{
		// Token: 0x1700559A RID: 21914
		// (get) Token: 0x0602A9A3 RID: 174499
		// (set) Token: 0x0602A9A4 RID: 174500
		int CardId { get; set; }

		// Token: 0x1700559B RID: 21915
		// (get) Token: 0x0602A9A5 RID: 174501
		// (set) Token: 0x0602A9A6 RID: 174502
		int Cost { get; set; }

		// Token: 0x1700559C RID: 21916
		// (get) Token: 0x0602A9A7 RID: 174503
		// (set) Token: 0x0602A9A8 RID: 174504
		int Attack { get; set; }

		// Token: 0x1700559D RID: 21917
		// (get) Token: 0x0602A9A9 RID: 174505
		// (set) Token: 0x0602A9AA RID: 174506
		int Life { get; set; }

		// Token: 0x1700559E RID: 21918
		// (get) Token: 0x0602A9AB RID: 174507
		// (set) Token: 0x0602A9AC RID: 174508
		int Element { get; set; }

		// Token: 0x1700559F RID: 21919
		// (get) Token: 0x0602A9AD RID: 174509
		// (set) Token: 0x0602A9AE RID: 174510
		bool ShowCardFaceTexture { get; set; }

		// Token: 0x170055A0 RID: 21920
		// (get) Token: 0x0602A9AF RID: 174511
		// (set) Token: 0x0602A9B0 RID: 174512
		bool OutlookUnlocked { get; set; }

		// Token: 0x170055A1 RID: 21921
		// (get) Token: 0x0602A9B1 RID: 174513
		// (set) Token: 0x0602A9B2 RID: 174514
		string CardFaceTexturePath { get; set; }

		// Token: 0x170055A2 RID: 21922
		// (get) Token: 0x0602A9B3 RID: 174515
		// (set) Token: 0x0602A9B4 RID: 174516
		EToggleState? ToggleState { get; set; }

		// Token: 0x170055A3 RID: 21923
		// (get) Token: 0x0602A9B5 RID: 174517
		// (set) Token: 0x0602A9B6 RID: 174518
		Action OnPointerUp { get; set; }

		// Token: 0x170055A4 RID: 21924
		// (get) Token: 0x0602A9B7 RID: 174519
		// (set) Token: 0x0602A9B8 RID: 174520
		Action<EToggleState> OnToggleStateChanged { get; set; }

		// Token: 0x170055A5 RID: 21925
		// (get) Token: 0x0602A9B9 RID: 174521
		// (set) Token: 0x0602A9BA RID: 174522
		Func<bool> CanToggleExecuteChange { get; set; }
	}
}
