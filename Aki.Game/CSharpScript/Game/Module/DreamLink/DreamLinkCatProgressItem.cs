using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A96 RID: 19094
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkCatProgressItem : UiPanelBase
	{
		// Token: 0x0602FC8E RID: 195726 RVA: 0x00D54D78 File Offset: 0x00D52F78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602FC8F RID: 195727 RVA: 0x00D54E86 File Offset: 0x00D53086
		protected override void OnStart()
		{
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnTweenUpdate));
			this.EffectDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnEffectTweenUpdate));
		}

		// Token: 0x0602FC90 RID: 195728 RVA: 0x00D54EB6 File Offset: 0x00D530B6
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x0602FC91 RID: 195729 RVA: 0x00D54EC0 File Offset: 0x00D530C0
		protected override void OnBeforeDestroy()
		{
			ULTweener addTween = this.AddTween;
			if (addTween != null && addTween.IsValid())
			{
				this.AddTween.Kill(false);
				this.AddTween = null;
			}
			ULTweener addEffectTween = this.AddEffectTween;
			if (addEffectTween != null && addEffectTween.IsValid())
			{
				this.AddEffectTween.Kill(false);
				this.AddEffectTween = null;
			}
			if (this.Delegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnTweenUpdate));
				this.Delegate = null;
			}
			if (this.EffectDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnEffectTweenUpdate));
				this.EffectDelegate = null;
			}
		}

		// Token: 0x0602FC92 RID: 195730 RVA: 0x00D54F5C File Offset: 0x00D5315C
		protected void RefreshView()
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			this.MaxValue = currentActivityData.GetActivityConfig().DungeonMaxProgress;
			int dungeonProgressRecord = currentActivityData.DungeonProgressRecord;
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetFillAmount((float)dungeonProgressRecord / (float)this.MaxValue);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(dungeonProgressRecord.ToString(), true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText((this.MaxValue - dungeonProgressRecord).ToString(), true);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetFillAmount(1f - (float)dungeonProgressRecord / (float)this.MaxValue);
		}

		// Token: 0x0602FC93 RID: 195731 RVA: 0x00D55010 File Offset: 0x00D53210
		public void PlayAddProgressAnim()
		{
			DreamLinkData currentActivityData = DreamLinkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			int dungeonProgressRecord = currentActivityData.DungeonProgressRecord;
			int currentCatProgress = currentActivityData.GetCurrentCatProgress();
			if (dungeonProgressRecord == currentCatProgress)
			{
				return;
			}
			float num = (float)dungeonProgressRecord / (float)this.MaxValue * 360f;
			Rotator rotator = Rotator.Create(0f, -num, 0f);
			UUISprite sprite = base.GetSprite(4);
			AUIBaseActor auibaseActor = ((sprite != null) ? sprite.GetOwner() : null) as AUIBaseActor;
			UUISprite sprite2 = base.GetSprite(5);
			AUIBaseActor auibaseActor2 = ((sprite2 != null) ? sprite2.GetOwner() : null) as AUIBaseActor;
			if (auibaseActor != null)
			{
				UUIItem uiitem = auibaseActor.GetUIItem();
				if (uiitem != null)
				{
					FRotator frotator = rotator.ToUeRotator();
					uiitem.SetUIRelativeRotation(frotator);
				}
			}
			if (auibaseActor2 != null)
			{
				UUIItem uiitem2 = auibaseActor2.GetUIItem();
				if (uiitem2 != null)
				{
					FRotator frotator = rotator.ToUeRotator();
					uiitem2.SetUIRelativeRotation(frotator);
				}
			}
			UUISprite sprite3 = base.GetSprite(5);
			if (sprite3 != null)
			{
				sprite3.SetAlpha(1f);
			}
			UUISprite sprite4 = base.GetSprite(4);
			if (sprite4 != null)
			{
				sprite4.SetAlpha(1f);
			}
			UUIItem item = base.GetItem(6);
			TArray<UActorComponent> tarray;
			if (item == null)
			{
				tarray = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				tarray = ((owner != null) ? owner.K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()) : null);
			}
			TArray<UActorComponent> tarray2 = tarray;
			for (int i = 0; i < tarray2.Count; i++)
			{
				ULGUIPlayTweenComponent ulguiplayTweenComponent = tarray2.Get(i) as ULGUIPlayTweenComponent;
				if (ulguiplayTweenComponent != null)
				{
					ulguiplayTweenComponent.Play();
				}
			}
			DreamLinkController.Instance.RoguelikeSetDungeonProgressRequest(currentCatProgress);
			this.AddTween = ULTweenBPLibrary.FloatTo(this.RootActor, this.Delegate, (float)dungeonProgressRecord, (float)currentCatProgress, 1f, 0f, LTweenEase.Linear);
			this.AddEffectTween = ULTweenBPLibrary.FloatTo(this.RootActor, this.EffectDelegate, 0f, (float)(currentCatProgress - dungeonProgressRecord), 1f, 0f, LTweenEase.Linear);
		}

		// Token: 0x0602FC94 RID: 195732 RVA: 0x00D551BC File Offset: 0x00D533BC
		private void OnTweenUpdate(float value)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetFillAmount(value / (float)this.MaxValue);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 != null)
			{
				sprite2.SetFillAmount(1f - value / (float)this.MaxValue);
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(Math.Floor((double)value).ToString(), true);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(Math.Floor((double)((float)this.MaxValue - value)).ToString(), true);
		}

		// Token: 0x0602FC95 RID: 195733 RVA: 0x00D55250 File Offset: 0x00D53450
		private void OnEffectTweenUpdate(float value)
		{
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetFillAmount(value / (float)this.MaxValue);
			}
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetFillAmount(value / (float)this.MaxValue);
		}

		// Token: 0x040195D3 RID: 103891
		private ULTweener AddTween;

		// Token: 0x040195D4 RID: 103892
		private ULTweener AddEffectTween;

		// Token: 0x040195D5 RID: 103893
		private FLTweenFloatSetterDynamic Delegate;

		// Token: 0x040195D6 RID: 103894
		private FLTweenFloatSetterDynamic EffectDelegate;

		// Token: 0x040195D7 RID: 103895
		private int MaxValue;

		// Token: 0x0200A715 RID: 42773
		[NullableContext(0)]
		private class EDreamLinkCatProgressItemDefine
		{
			// Token: 0x04033A09 RID: 211465
			public const int SpriteBlueBar = 0;

			// Token: 0x04033A0A RID: 211466
			public const int SpriteRedBar = 1;

			// Token: 0x04033A0B RID: 211467
			public const int TxtBlueProgress = 2;

			// Token: 0x04033A0C RID: 211468
			public const int TxtRedProgress = 3;

			// Token: 0x04033A0D RID: 211469
			public const int SpriteWhiteBar = 4;

			// Token: 0x04033A0E RID: 211470
			public const int SpriteGlowBar = 5;

			// Token: 0x04033A0F RID: 211471
			public const int AnimItem = 6;
		}
	}
}
