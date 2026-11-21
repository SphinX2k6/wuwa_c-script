using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001417 RID: 5143
[NullableContext(2)]
[Nullable(0)]
public class SlowTimeUnit : HudUnitBase
{
	// Token: 0x0600CC6F RID: 52335 RVA: 0x003CD3E0 File Offset: 0x003CB5E0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CC70 RID: 52336 RVA: 0x003CD4F0 File Offset: 0x003CB6F0
	protected override void OnStart()
	{
		base.OnStart();
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.BarSprite = base.GetSprite(2);
		this.EffectItem = base.GetItem(5);
		this.ContainerItem = base.GetItem(1);
		this.SetTranslucence(this.TargetTranslucence);
		base.InitTweenAnim(6);
	}

	// Token: 0x0600CC71 RID: 52337 RVA: 0x003CD550 File Offset: 0x003CB750
	protected override void OnBeforeDestroy()
	{
		base.StopTweenAnim(6);
		base.OnBeforeDestroy();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		this.BarSprite = null;
		this.ContainerItem = null;
		this.DestroyPromise();
		this.DestroyTimer();
	}

	// Token: 0x0600CC72 RID: 52338 RVA: 0x003CD59C File Offset: 0x003CB79C
	protected override void OnBeforeShow()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600CC73 RID: 52339 RVA: 0x003CD5C8 File Offset: 0x003CB7C8
	protected override UniTask OnBeforeHideAsync()
	{
		SlowTimeUnit.<OnBeforeHideAsync>d__14 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<SlowTimeUnit.<OnBeforeHideAsync>d__14>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC74 RID: 52340 RVA: 0x003CD60B File Offset: 0x003CB80B
	private void DestroyPromise()
	{
		if (this.Promise != null)
		{
			this.Promise.SetResult();
			this.Promise = null;
		}
	}

	// Token: 0x0600CC75 RID: 52341 RVA: 0x003CD627 File Offset: 0x003CB827
	private void DestroyTimer()
	{
		if (this.Timer != null)
		{
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x0600CC76 RID: 52342 RVA: 0x003CD649 File Offset: 0x003CB849
	public void SetTranslucence(bool value)
	{
		this.TargetTranslucence = value;
		if (this.ContainerItem == null)
		{
			return;
		}
		if (value)
		{
			this.PlayWarnAnim(false);
		}
		this.RefreshAlpha();
		UUISprite barSprite = this.BarSprite;
		if (barSprite == null)
		{
			return;
		}
		barSprite.SetUIActive(value);
	}

	// Token: 0x0600CC77 RID: 52343 RVA: 0x003CD67C File Offset: 0x003CB87C
	private void RefreshAlpha()
	{
		UUIItem containerItem = this.ContainerItem;
		if (containerItem == null)
		{
			return;
		}
		containerItem.SetAlpha(this.TargetTranslucence ? 0.5f : 1f);
	}

	// Token: 0x0600CC78 RID: 52344 RVA: 0x003CD6A4 File Offset: 0x003CB8A4
	public void UpdateProgress(float curValue, float maxValue)
	{
		if (this.BarSprite == null)
		{
			return;
		}
		float num = (maxValue > 0f) ? (curValue / maxValue) : 0f;
		FVector uiitemScale = new FVector(num, 1f, 1f);
		this.BarSprite.SetUIItemScale(uiitemScale);
		this.EffectItem.SetUIItemScale(uiitemScale);
		base.GetUiNiagara(3).SetNiagaraVarFloat("Dissolve", num);
		base.GetUiNiagara(4).SetNiagaraVarFloat("Dissolve", num);
		bool uiactive = num != 0f && num != 1f && !this.TargetTranslucence;
		this.EffectItem.SetUIActive(uiactive);
		this.PlayWarnAnim((double)num < 0.3 && !this.TargetTranslucence);
	}

	// Token: 0x0600CC79 RID: 52345 RVA: 0x003CD763 File Offset: 0x003CB963
	private void PlayWarnAnim(bool bPlay)
	{
		if (this.IsPlayWarnAnim == bPlay)
		{
			return;
		}
		this.IsPlayWarnAnim = bPlay;
		if (bPlay)
		{
			base.PlayTweenAnim(6);
			return;
		}
		base.StopTweenAnim(6);
		this.RefreshAlpha();
	}

	// Token: 0x04007434 RID: 29748
	private const int CLOSE_ANIM_TIME = 300;

	// Token: 0x04007435 RID: 29749
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007436 RID: 29750
	private UUISprite BarSprite;

	// Token: 0x04007437 RID: 29751
	private UUIItem EffectItem;

	// Token: 0x04007438 RID: 29752
	private UUIItem ContainerItem;

	// Token: 0x04007439 RID: 29753
	private bool TargetTranslucence;

	// Token: 0x0400743A RID: 29754
	private CustomPromise Promise;

	// Token: 0x0400743B RID: 29755
	private TimerHandle Timer;

	// Token: 0x0400743C RID: 29756
	private bool IsPlayWarnAnim;

	// Token: 0x020076D9 RID: 30425
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040269A4 RID: 158116
		EffectContainerItem,
		// Token: 0x040269A5 RID: 158117
		ContainerItem,
		// Token: 0x040269A6 RID: 158118
		BarSprite,
		// Token: 0x040269A7 RID: 158119
		LeftEffect,
		// Token: 0x040269A8 RID: 158120
		RightEffect,
		// Token: 0x040269A9 RID: 158121
		EffectItem,
		// Token: 0x040269AA RID: 158122
		AniWarning
	}
}
