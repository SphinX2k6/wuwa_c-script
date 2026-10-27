using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002C78 RID: 11384
[NullableContext(2)]
[Nullable(0)]
public class UiModelAnimationComponent : UiModelComponentBase
{
	// Token: 0x06017C87 RID: 97415 RVA: 0x0060D042 File Offset: 0x0060B242
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x06017C88 RID: 97416 RVA: 0x0060D066 File Offset: 0x0060B266
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017C89 RID: 97417 RVA: 0x0060D08A File Offset: 0x0060B28A
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017C8A RID: 97418 RVA: 0x0060D0B0 File Offset: 0x0060B2B0
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

	// Token: 0x06017C8B RID: 97419 RVA: 0x0060D12C File Offset: 0x0060B32C
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

	// Token: 0x06017C8C RID: 97420 RVA: 0x0060D1DC File Offset: 0x0060B3DC
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

	// Token: 0x06017C8D RID: 97421 RVA: 0x0060D230 File Offset: 0x0060B430
	public bool IsMontagePlaying()
	{
		UAnimInstance mainAnimInstanceInternal = this.MainAnimInstanceInternal;
		return mainAnimInstanceInternal != null && mainAnimInstanceInternal.IsAnyMontagePlaying();
	}

	// Token: 0x06017C8E RID: 97422 RVA: 0x0060D243 File Offset: 0x0060B443
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

	// Token: 0x06017C8F RID: 97423 RVA: 0x0060D280 File Offset: 0x0060B480
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

	// Token: 0x06017C90 RID: 97424 RVA: 0x0060D2B1 File Offset: 0x0060B4B1
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

	// Token: 0x06017C91 RID: 97425 RVA: 0x0060D2C8 File Offset: 0x0060B4C8
	public FName? GetCurrentSection()
	{
		UAnimInstance mainAnimInstanceInternal = this.MainAnimInstanceInternal;
		if (mainAnimInstanceInternal == null)
		{
			return null;
		}
		return new FName?(mainAnimInstanceInternal.Montage_GetCurrentSection(null));
	}

	// Token: 0x06017C92 RID: 97426 RVA: 0x0060D2F4 File Offset: 0x0060B4F4
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

	// Token: 0x06017C93 RID: 97427 RVA: 0x0060D33C File Offset: 0x0060B53C
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

	// Token: 0x06017C94 RID: 97428 RVA: 0x0060D379 File Offset: 0x0060B579
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

	// Token: 0x06017C95 RID: 97429 RVA: 0x0060D3AD File Offset: 0x0060B5AD
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

	// Token: 0x0400B138 RID: 45368
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B139 RID: 45369
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B13A RID: 45370
	private UAnimInstance MainAnimInstanceInternal;

	// Token: 0x0400B13B RID: 45371
	private UAnimMontage MontageWaitToPlay;

	// Token: 0x0400B13C RID: 45372
	private UAnimationAsset AnimationWaitToPlay;

	// Token: 0x0400B13D RID: 45373
	private bool IsAnimationLoop = true;

	// Token: 0x0400B13E RID: 45374
	private EAnimationMode? AnimationMode;
}
