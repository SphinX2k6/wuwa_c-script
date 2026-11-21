using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season
{
	// Token: 0x02004F4F RID: 20303
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSeasonBgItem : UiPanelBase
	{
		// Token: 0x06032FD7 RID: 208855 RVA: 0x00E4A4A8 File Offset: 0x00E486A8
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

		// Token: 0x06032FD8 RID: 208856 RVA: 0x00E4A514 File Offset: 0x00E48714
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.TweenComponent = (ULGUIPlayTweenComponent)base.GetItem(0).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass());
			this.TweenComponent.Play();
		}

		// Token: 0x06032FD9 RID: 208857 RVA: 0x00E4A563 File Offset: 0x00E48763
		public UiSequencePlayer GetSequencePlayer()
		{
			return this.SequencePlayer;
		}

		// Token: 0x06032FDA RID: 208858 RVA: 0x00E4A56B File Offset: 0x00E4876B
		public ULGUIPlayTweenComponent GetTweenComponent()
		{
			return this.TweenComponent;
		}

		// Token: 0x06032FDB RID: 208859 RVA: 0x00E4A573 File Offset: 0x00E48773
		public void StopAllTweenAndSpine()
		{
			this.TweenComponent.Stop();
			base.GetSpine(1).SetTimeScale(0f);
		}

		// Token: 0x0401B0D6 RID: 110806
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401B0D7 RID: 110807
		[Nullable(2)]
		private ULGUIPlayTweenComponent TweenComponent;

		// Token: 0x0200AC74 RID: 44148
		[NullableContext(0)]
		private enum ESeasonBgItemComponent
		{
			// Token: 0x04035595 RID: 218517
			TweenRoot,
			// Token: 0x04035596 RID: 218518
			SpineActor
		}
	}
}
