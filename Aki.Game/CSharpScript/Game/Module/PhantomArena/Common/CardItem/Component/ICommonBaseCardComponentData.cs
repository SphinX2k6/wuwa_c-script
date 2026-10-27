using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051F6 RID: 20982
	[NullableContext(1)]
	public interface ICommonBaseCardComponentData
	{
		// Token: 0x170081DA RID: 33242
		// (get) Token: 0x06035AA8 RID: 219816
		// (set) Token: 0x06035AA9 RID: 219817
		int CardId { get; set; }

		// Token: 0x170081DB RID: 33243
		// (get) Token: 0x06035AAA RID: 219818
		// (set) Token: 0x06035AAB RID: 219819
		int Cost { get; set; }

		// Token: 0x170081DC RID: 33244
		// (get) Token: 0x06035AAC RID: 219820
		// (set) Token: 0x06035AAD RID: 219821
		int Attack { get; set; }

		// Token: 0x170081DD RID: 33245
		// (get) Token: 0x06035AAE RID: 219822
		// (set) Token: 0x06035AAF RID: 219823
		int Life { get; set; }

		// Token: 0x170081DE RID: 33246
		// (get) Token: 0x06035AB0 RID: 219824
		// (set) Token: 0x06035AB1 RID: 219825
		int Element { get; set; }

		// Token: 0x170081DF RID: 33247
		// (get) Token: 0x06035AB2 RID: 219826
		// (set) Token: 0x06035AB3 RID: 219827
		bool ShowCardFaceTexture { get; set; }

		// Token: 0x170081E0 RID: 33248
		// (get) Token: 0x06035AB4 RID: 219828
		// (set) Token: 0x06035AB5 RID: 219829
		bool OutlookUnlocked { get; set; }

		// Token: 0x170081E1 RID: 33249
		// (get) Token: 0x06035AB6 RID: 219830
		// (set) Token: 0x06035AB7 RID: 219831
		string CardFaceTexturePath { get; set; }

		// Token: 0x170081E2 RID: 33250
		// (get) Token: 0x06035AB8 RID: 219832
		// (set) Token: 0x06035AB9 RID: 219833
		EToggleState? ToggleState { get; set; }

		// Token: 0x170081E3 RID: 33251
		// (get) Token: 0x06035ABA RID: 219834
		// (set) Token: 0x06035ABB RID: 219835
		Action OnPointerUp { get; set; }

		// Token: 0x170081E4 RID: 33252
		// (get) Token: 0x06035ABC RID: 219836
		// (set) Token: 0x06035ABD RID: 219837
		Action<EToggleState> OnToggleStateChanged { get; set; }

		// Token: 0x170081E5 RID: 33253
		// (get) Token: 0x06035ABE RID: 219838
		// (set) Token: 0x06035ABF RID: 219839
		Func<bool> CanToggleExecuteChange { get; set; }
	}
}
