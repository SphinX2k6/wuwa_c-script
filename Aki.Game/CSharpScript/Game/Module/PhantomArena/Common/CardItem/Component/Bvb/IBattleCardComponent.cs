using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020041D0 RID: 16848
	[NullableContext(1)]
	public interface IBattleCardComponent
	{
		// Token: 0x170055B5 RID: 21941
		// (get) Token: 0x0602AA34 RID: 174644
		// (set) Token: 0x0602AA35 RID: 174645
		Action<EToggleState> CardClickCallback { get; set; }

		// Token: 0x0602AA36 RID: 174646
		void SetCardData(PhantomCardData data);

		// Token: 0x0602AA37 RID: 174647
		UniTask InitEffect();

		// Token: 0x0602AA38 RID: 174648
		UniTask InitSpine();

		// Token: 0x0602AA39 RID: 174649
		void Refresh(PhantomCardData data);

		// Token: 0x0602AA3A RID: 174650
		UniTask RefreshAsync(PhantomCardData data);

		// Token: 0x0602AA3B RID: 174651
		UUIExtendToggle GetCardToggle();

		// Token: 0x0602AA3C RID: 174652
		void SetDebugText();

		// Token: 0x0602AA3D RID: 174653
		void PlaySequence(string name);

		// Token: 0x0602AA3E RID: 174654
		void PlaySpineAnim(string animName, bool isLoop);

		// Token: 0x0602AA3F RID: 174655
		void PlayEffect();

		// Token: 0x170055B6 RID: 21942
		// (get) Token: 0x0602AA40 RID: 174656
		// (set) Token: 0x0602AA41 RID: 174657
		Func<UUIItem, UniTask> PlayHitEffect { get; set; }

		// Token: 0x0602AA42 RID: 174658
		UUIItem GetRootItem();

		// Token: 0x170055B7 RID: 21943
		// (get) Token: 0x0602AA43 RID: 174659
		// (set) Token: 0x0602AA44 RID: 174660
		UiSequencePlayer RootUiSequencePlayer { get; set; }
	}
}
