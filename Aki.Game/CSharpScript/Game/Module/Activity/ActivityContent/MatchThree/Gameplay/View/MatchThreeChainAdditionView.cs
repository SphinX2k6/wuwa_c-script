using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005452 RID: 21586
	public class MatchThreeChainAdditionView : MatchThreePieceAdditionView
	{
		// Token: 0x0603590E RID: 219406 RVA: 0x00EF62AC File Offset: 0x00EF44AC
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

		// Token: 0x0603590F RID: 219407 RVA: 0x00EF62F4 File Offset: 0x00EF44F4
		protected override UniTask OnShowAsyncImplementImplement()
		{
			return base.PlayAnimAsync("Start");
		}

		// Token: 0x06035910 RID: 219408 RVA: 0x00EF6304 File Offset: 0x00EF4504
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

		// Token: 0x0200B0BC RID: 45244
		private enum EComponent
		{
			// Token: 0x04036A07 RID: 223751
			TxtCounter
		}
	}
}
