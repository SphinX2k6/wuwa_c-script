using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064D4 RID: 25812
	public class MatchThreeChainAdditionView : MatchThreePieceAdditionView
	{
		// Token: 0x06040C4A RID: 265290 RVA: 0x00FAF264 File Offset: 0x00FAD464
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040C4B RID: 265291 RVA: 0x00FAF2AC File Offset: 0x00FAD4AC
		protected override UniTask OnShowAsyncImplementImplement()
		{
			return base.PlayAnimAsync("Start");
		}

		// Token: 0x06040C4C RID: 265292 RVA: 0x00FAF2BC File Offset: 0x00FAD4BC
		protected override void RefreshAppearance()
		{
			UUIText text = base.GetText(0);
			if (this.Piece == null || this.Component == null)
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			int val = this.Piece.StateOf(this.Component).Val1;
			bool uiactive = val > 0;
			if (text != null)
			{
				text.SetText(val.ToString(), true);
			}
			if (text != null)
			{
				text.SetUIActive(uiactive);
			}
		}

		// Token: 0x0200C6D6 RID: 50902
		private enum EComponent
		{
			// Token: 0x0403C0AC RID: 245932
			TxtCounter
		}
	}
}
