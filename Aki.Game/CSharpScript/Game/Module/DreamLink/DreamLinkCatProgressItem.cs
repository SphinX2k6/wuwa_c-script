using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005ABA RID: 23226
	[NullableContext(2)]
	[Nullable(0)]
	public class DreamLinkCatProgressItem : UiPanelBase
	{
		// Token: 0x0603AD42 RID: 240962 RVA: 0x00E047B0 File Offset: 0x00E029B0
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

		// Token: 0x0603AD43 RID: 240963 RVA: 0x00E048BE File Offset: 0x00E02ABE
		protected override void OnStart()
		{
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnTweenUpdate));
			this.EffectDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.OnEffectTweenUpdate));
		}

		// Token: 0x0603AD44 RID: 240964 RVA: 0x00E048EE File Offset: 0x00E02AEE
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x0603AD45 RID: 240965 RVA: 0x00E048F8 File Offset: 0x00E02AF8
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

		// Token: 0x0603AD46 RID: 240966 RVA: 0x00E04994 File Offset: 0x00E02B94
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

		// Token: 0x0603AD47 RID: 240967 RVA: 0x00E04A48 File Offset: 0x00E02C48
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

		// Token: 0x0603AD48 RID: 240968 RVA: 0x00E04BF4 File Offset: 0x00E02DF4
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

		// Token: 0x0603AD49 RID: 240969 RVA: 0x00E04C88 File Offset: 0x00E02E88
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

		// Token: 0x0401EB2C RID: 125740
		private ULTweener AddTween;

		// Token: 0x0401EB2D RID: 125741
		private ULTweener AddEffectTween;

		// Token: 0x0401EB2E RID: 125742
		private FLTweenFloatSetterDynamic Delegate;

		// Token: 0x0401EB2F RID: 125743
		private FLTweenFloatSetterDynamic EffectDelegate;

		// Token: 0x0401EB30 RID: 125744
		private int MaxValue;

		// Token: 0x0200BD0D RID: 48397
		[NullableContext(0)]
		private class EDreamLinkCatProgressItemDefine
		{
			// Token: 0x0403903F RID: 233535
			public const int SpriteBlueBar = 0;

			// Token: 0x04039040 RID: 233536
			public const int SpriteRedBar = 1;

			// Token: 0x04039041 RID: 233537
			public const int TxtBlueProgress = 2;

			// Token: 0x04039042 RID: 233538
			public const int TxtRedProgress = 3;

			// Token: 0x04039043 RID: 233539
			public const int SpriteWhiteBar = 4;

			// Token: 0x04039044 RID: 233540
			public const int SpriteGlowBar = 5;

			// Token: 0x04039045 RID: 233541
			public const int AnimItem = 6;
		}
	}
}
