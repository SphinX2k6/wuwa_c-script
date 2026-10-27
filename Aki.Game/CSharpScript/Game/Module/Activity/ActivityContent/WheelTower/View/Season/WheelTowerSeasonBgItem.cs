using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02005F68 RID: 24424
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonBgItem : UiPanelBase
	{
		// Token: 0x0603E03D RID: 254013 RVA: 0x00EF87C0 File Offset: 0x00EF69C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603E03E RID: 254014 RVA: 0x00EF882C File Offset: 0x00EF6A2C
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.TweenComponent = (ULGUIPlayTweenComponent)base.GetItem(0).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass());
			this.TweenComponent.Play();
		}

		// Token: 0x0603E03F RID: 254015 RVA: 0x00EF887B File Offset: 0x00EF6A7B
		public UiSequencePlayer GetSequencePlayer()
		{
			return this.SequencePlayer;
		}

		// Token: 0x0603E040 RID: 254016 RVA: 0x00EF8883 File Offset: 0x00EF6A83
		public ULGUIPlayTweenComponent GetTweenComponent()
		{
			return this.TweenComponent;
		}

		// Token: 0x0603E041 RID: 254017 RVA: 0x00EF888B File Offset: 0x00EF6A8B
		public void StopAllTweenAndSpine()
		{
			this.TweenComponent.Stop();
			base.GetSpine(1).SetTimeScale(0f);
		}

		// Token: 0x04020604 RID: 132612
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04020605 RID: 132613
		[Nullable(2)]
		private ULGUIPlayTweenComponent TweenComponent;

		// Token: 0x0200C269 RID: 49769
		[NullableContext(0)]
		private enum ESeasonBgItemComponent
		{
			// Token: 0x0403ABB9 RID: 240569
			TweenRoot,
			// Token: 0x0403ABBA RID: 240570
			SpineActor
		}
	}
}
