using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F55 RID: 8021
[NullableContext(2)]
[Nullable(0)]
public class SlowTimeUnit : HudUnitBase
{
	// Token: 0x0600F850 RID: 63568 RVA: 0x003C18F4 File Offset: 0x003BFAF4
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

	// Token: 0x0600F851 RID: 63569 RVA: 0x003C1A04 File Offset: 0x003BFC04
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

	// Token: 0x0600F852 RID: 63570 RVA: 0x003C1A64 File Offset: 0x003BFC64
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

	// Token: 0x0600F853 RID: 63571 RVA: 0x003C1AB0 File Offset: 0x003BFCB0
	protected override void OnBeforeShow()
	{
		this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600F854 RID: 63572 RVA: 0x003C1ADC File Offset: 0x003BFCDC
	protected override UniTask OnBeforeHideAsync()
	{
		SlowTimeUnit.<OnBeforeHideAsync>d__14 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<SlowTimeUnit.<OnBeforeHideAsync>d__14>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F855 RID: 63573 RVA: 0x003C1B1F File Offset: 0x003BFD1F
	private void DestroyPromise()
	{
		if (this.Promise != null)
		{
			this.Promise.SetResult();
			this.Promise = null;
		}
	}

	// Token: 0x0600F856 RID: 63574 RVA: 0x003C1B3B File Offset: 0x003BFD3B
	private void DestroyTimer()
	{
		if (this.Timer != null)
		{
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x0600F857 RID: 63575 RVA: 0x003C1B5D File Offset: 0x003BFD5D
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

	// Token: 0x0600F858 RID: 63576 RVA: 0x003C1B90 File Offset: 0x003BFD90
	private void RefreshAlpha()
	{
		UUIItem containerItem = this.ContainerItem;
		if (containerItem == null)
		{
			return;
		}
		containerItem.SetAlpha(this.TargetTranslucence ? 0.5f : 1f);
	}

	// Token: 0x0600F859 RID: 63577 RVA: 0x003C1BB8 File Offset: 0x003BFDB8
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

	// Token: 0x0600F85A RID: 63578 RVA: 0x003C1C77 File Offset: 0x003BFE77
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

	// Token: 0x04007353 RID: 29523
	private const int CLOSE_ANIM_TIME = 300;

	// Token: 0x04007354 RID: 29524
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007355 RID: 29525
	private UUISprite BarSprite;

	// Token: 0x04007356 RID: 29526
	private UUIItem EffectItem;

	// Token: 0x04007357 RID: 29527
	private UUIItem ContainerItem;

	// Token: 0x04007358 RID: 29528
	private bool TargetTranslucence;

	// Token: 0x04007359 RID: 29529
	private CustomPromise Promise;

	// Token: 0x0400735A RID: 29530
	private TimerHandle Timer;

	// Token: 0x0400735B RID: 29531
	private bool IsPlayWarnAnim;

	// Token: 0x02008554 RID: 34132
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B680 RID: 177792
		EffectContainerItem,
		// Token: 0x0402B681 RID: 177793
		ContainerItem,
		// Token: 0x0402B682 RID: 177794
		BarSprite,
		// Token: 0x0402B683 RID: 177795
		LeftEffect,
		// Token: 0x0402B684 RID: 177796
		RightEffect,
		// Token: 0x0402B685 RID: 177797
		EffectItem,
		// Token: 0x0402B686 RID: 177798
		AniWarning
	}
}
