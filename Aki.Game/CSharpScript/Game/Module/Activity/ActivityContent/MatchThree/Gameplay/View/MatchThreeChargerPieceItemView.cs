using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005453 RID: 21587
	public class MatchThreeChargerPieceItemView : MatchThreePieceItemView
	{
		// Token: 0x06035912 RID: 219410 RVA: 0x00EF6374 File Offset: 0x00EF4574
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

		// Token: 0x06035913 RID: 219411 RVA: 0x00EF63DD File Offset: 0x00EF45DD
		protected override void RefreshAppearance()
		{
			if (this.Piece == null)
			{
				return;
			}
			this.RefreshLives(MatchThreeChargerPieceItemView.GetLives(this.Piece));
		}

		// Token: 0x06035914 RID: 219412 RVA: 0x00EF63FC File Offset: 0x00EF45FC
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

		// Token: 0x06035915 RID: 219413 RVA: 0x00EF6438 File Offset: 0x00EF4638
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

		// Token: 0x0401C513 RID: 115987
		[Nullable(2)]
		private SimpleGenericLayout LivesLayout;

		// Token: 0x0200B0BD RID: 45245
		private enum EComponent
		{
			// Token: 0x04036A09 RID: 223753
			Layout,
			// Token: 0x04036A0A RID: 223754
			LayoutItem
		}
	}
}
