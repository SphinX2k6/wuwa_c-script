using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064D5 RID: 25813
	public class MatchThreeChargerPieceItemView : MatchThreePieceItemView
	{
		// Token: 0x06040C4E RID: 265294 RVA: 0x00FAF32C File Offset: 0x00FAD52C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040C4F RID: 265295 RVA: 0x00FAF395 File Offset: 0x00FAD595
		protected override void RefreshAppearance()
		{
			if (this.Piece == null)
			{
				return;
			}
			this.RefreshLives(MatchThreeChargerPieceItemView.GetLives(this.Piece));
		}

		// Token: 0x06040C50 RID: 265296 RVA: 0x00FAF3B4 File Offset: 0x00FAD5B4
		public override void RefreshLives(int lives)
		{
			UUILayoutBase layoutBase = base.GetLayoutBase(0);
			if (layoutBase == null)
			{
				return;
			}
			if (this.LivesLayout == null)
			{
				this.LivesLayout = new SimpleGenericLayout(layoutBase);
			}
			this.LivesLayout.RebuildLayout(lives);
		}

		// Token: 0x06040C51 RID: 265297 RVA: 0x00FAF3F0 File Offset: 0x00FAD5F0
		[NullableContext(1)]
		private static int GetLives(Piece piece)
		{
			foreach (IPieceComponent pieceComponent in piece.Components)
			{
				HealthComponent healthComponent = pieceComponent as HealthComponent;
				if (healthComponent != null)
				{
					return piece.StateOf(healthComponent).Val1;
				}
			}
			return 0;
		}

		// Token: 0x04021BE2 RID: 138210
		[Nullable(2)]
		private SimpleGenericLayout LivesLayout;

		// Token: 0x0200C6D7 RID: 50903
		private enum EComponent
		{
			// Token: 0x0403C0AE RID: 245934
			Layout,
			// Token: 0x0403C0AF RID: 245935
			LayoutItem
		}
	}
}
