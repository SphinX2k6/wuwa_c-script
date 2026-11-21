using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020021D1 RID: 8657
[NullableContext(2)]
[Nullable(0)]
public class UiModelAnimationComponent : UiModelComponentBase
{
	// Token: 0x060154FA RID: 87290 RVA: 0x00632B26 File Offset: 0x00630D26
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x060154FB RID: 87291 RVA: 0x00632B4A File Offset: 0x00630D4A
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x060154FC RID: 87292 RVA: 0x00632B6E File Offset: 0x00630D6E
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x060154FD RID: 87293 RVA: 0x00632B94 File Offset: 0x00630D94
	private void OnModelLoadComplete()
	{
		this.UpdateAnimInstance();
		if (this.MontageWaitToPlay != null)
		{
			this.PlayMontage(this.MontageWaitToPlay);
			this.MontageWaitToPlay = null;
		}
		if (this.AnimationWaitToPlay != null)
		{
			this.PlayAnimation(this.AnimationWaitToPlay, this.IsAnimationLoop);
			this.AnimationWaitToPlay = null;
		}
		if (this.AnimationMode != null)
		{
			this.SetAnimationMode(this.AnimationMode.Value);
			this.AnimationMode = null;
		}
	}

	// Token: 0x060154FE RID: 87294 RVA: 0x00632C10 File Offset: 0x00630E10
	private unsafe void CheckLinkAnimInstance()
	{
		UiModelActorComponent actorComponent = this.ActorComponent;
		USkeletalMeshComponent uskeletalMeshComponent = (actorComponent != null) ? actorComponent.MainMeshComponent : null;
		if (((uskeletalMeshComponent != null) ? uskeletalMeshComponent.GetLinkedAnimGraphInstanceByTag(FNameUtil.NONE) : null) != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "检测出该Actor有空的动画LinkGraph节点,将会影响同步,GAS等功能,请找对应策划修复";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Actor";
			UiModelActorComponent actorComponent2 = this.ActorComponent;
			object item2;
			if (actorComponent2 == null)
			{
				item2 = null;
			}
			else
			{
				AActor actor = actorComponent2.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AnimInstance", (uskeletalMeshComponent != null) ? uskeletalMeshComponent.GetAnimInstance() : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x060154FF RID: 87295 RVA: 0x00632CC0 File Offset: 0x00630EC0
	protected void UpdateAnimInstance()
	{
		UiModelActorComponent actorComponent = this.ActorComponent;
		USkeletalMeshComponent uskeletalMeshComponent = (actorComponent != null) ? actorComponent.MainMeshComponent : null;
		if (uskeletalMeshComponent == null)
		{
			return;
		}
		this.CheckLinkAnimInstance();
		this.MainAnimInstanceInternal = uskeletalMeshComponent.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE);
		if (this.MainAnimInstanceInternal == null)
		{
			this.MainAnimInstanceInternal = uskeletalMeshComponent.GetAnimInstance();
		}
	}

	// Token: 0x06015500 RID: 87296 RVA: 0x00632D14 File Offset: 0x00630F14
	public bool IsMontagePlaying()
	{
		UAnimInstance mainAnimInstanceInternal = this.MainAnimInstanceInternal;
		return mainAnimInstanceInternal != null && mainAnimInstanceInternal.IsAnyMontagePlaying();
	}

	// Token: 0x06015501 RID: 87297 RVA: 0x00632D27 File Offset: 0x00630F27
	[NullableContext(1)]
	public void PlayMontage(UAnimMontage asset)
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		if (modelDataComponent == null || modelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			this.MontageWaitToPlay = asset;
			return;
		}
		this.MainAnimInstanceInternal.Montage_Play(asset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
	}

	// Token: 0x06015502 RID: 87298 RVA: 0x00632D64 File Offset: 0x00630F64
	public void StopMontage(float blendOutTime = 0f)
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		if (modelDataComponent == null || modelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			this.MontageWaitToPlay = null;
			return;
		}
		this.MainAnimInstanceInternal.Montage_Stop(blendOutTime, null);
	}

	// Token: 0x06015503 RID: 87299 RVA: 0x00632D95 File Offset: 0x00630F95
	[NullableContext(1)]
	public void JumpToSection(FName sectionName, UAnimMontage montage)
	{
		UAnimInstance mainAnimInstanceInternal = this.MainAnimInstanceInternal;
		if (mainAnimInstanceInternal == null)
		{
			return;
		}
		mainAnimInstanceInternal.Montage_JumpToSection(sectionName, montage);
	}

	// Token: 0x06015504 RID: 87300 RVA: 0x00632DAC File Offset: 0x00630FAC
	public FName? GetCurrentSection()
	{
		UAnimInstance mainAnimInstanceInternal = this.MainAnimInstanceInternal;
		if (mainAnimInstanceInternal == null)
		{
			return null;
		}
		return new FName?(mainAnimInstanceInternal.Montage_GetCurrentSection(null));
	}

	// Token: 0x06015505 RID: 87301 RVA: 0x00632DD8 File Offset: 0x00630FD8
	public bool IsAnimationPlaying()
	{
		UiModelActorComponent actorComponent = this.ActorComponent;
		bool? flag;
		if (actorComponent == null)
		{
			flag = null;
		}
		else
		{
			USkeletalMeshComponent mainMeshComponent = actorComponent.MainMeshComponent;
			flag = ((mainMeshComponent != null) ? new bool?(mainMeshComponent.IsPlaying()) : null);
		}
		bool? flag2 = flag;
		return flag2.GetValueOrDefault();
	}

	// Token: 0x06015506 RID: 87302 RVA: 0x00632E20 File Offset: 0x00631020
	[NullableContext(1)]
	public void PlayAnimation(UAnimationAsset asset, bool bLoop = true)
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		if (modelDataComponent == null || modelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			this.AnimationWaitToPlay = asset;
			this.IsAnimationLoop = bLoop;
			return;
		}
		this.ActorComponent.MainMeshComponent.PlayAnimation(asset, bLoop);
	}

	// Token: 0x06015507 RID: 87303 RVA: 0x00632E5D File Offset: 0x0063105D
	public void StopAnimation()
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		if (modelDataComponent == null || modelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			this.AnimationWaitToPlay = null;
			return;
		}
		this.ActorComponent.MainMeshComponent.Stop();
	}

	// Token: 0x06015508 RID: 87304 RVA: 0x00632E91 File Offset: 0x00631091
	public void SetAnimationMode(EAnimationMode animationMode)
	{
		UiModelDataComponent modelDataComponent = this.ModelDataComponent;
		if (modelDataComponent == null || modelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			this.AnimationMode = new EAnimationMode?(animationMode);
			return;
		}
		this.ActorComponent.MainMeshComponent.SetAnimationMode(animationMode);
	}

	// Token: 0x0400B4A3 RID: 46243
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B4A4 RID: 46244
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B4A5 RID: 46245
	private UAnimInstance MainAnimInstanceInternal;

	// Token: 0x0400B4A6 RID: 46246
	private UAnimMontage MontageWaitToPlay;

	// Token: 0x0400B4A7 RID: 46247
	private UAnimationAsset AnimationWaitToPlay;

	// Token: 0x0400B4A8 RID: 46248
	private bool IsAnimationLoop = true;

	// Token: 0x0400B4A9 RID: 46249
	private EAnimationMode? AnimationMode;
}
