using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x02005200 RID: 20992
	[NullableContext(1)]
	public interface IBattleCardComponent
	{
		// Token: 0x170081F5 RID: 33269
		// (get) Token: 0x06035B39 RID: 219961
		// (set) Token: 0x06035B3A RID: 219962
		Action<EToggleState> CardClickCallback { get; set; }

		// Token: 0x06035B3B RID: 219963
		void SetCardData(PhantomCardData data);

		// Token: 0x06035B3C RID: 219964
		UniTask InitEffect();

		// Token: 0x06035B3D RID: 219965
		UniTask InitSpine();

		// Token: 0x06035B3E RID: 219966
		void Refresh(PhantomCardData data);

		// Token: 0x06035B3F RID: 219967
		UniTask RefreshAsync(PhantomCardData data);

		// Token: 0x06035B40 RID: 219968
		UUIExtendToggle GetCardToggle();

		// Token: 0x06035B41 RID: 219969
		void SetDebugText();

		// Token: 0x06035B42 RID: 219970
		void PlaySequence(string name);

		// Token: 0x06035B43 RID: 219971
		void PlaySpineAnim(string animName, bool isLoop);

		// Token: 0x06035B44 RID: 219972
		void PlayEffect();

		// Token: 0x170081F6 RID: 33270
		// (get) Token: 0x06035B45 RID: 219973
		// (set) Token: 0x06035B46 RID: 219974
		Func<UUIItem, UniTask> PlayHitEffect { get; set; }

		// Token: 0x06035B47 RID: 219975
		UUIItem GetRootItem();

		// Token: 0x170081F7 RID: 33271
		// (get) Token: 0x06035B48 RID: 219976
		// (set) Token: 0x06035B49 RID: 219977
		UiSequencePlayer RootUiSequencePlayer { get; set; }
	}
}
