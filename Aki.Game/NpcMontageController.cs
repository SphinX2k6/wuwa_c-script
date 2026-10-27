using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003211 RID: 12817
[NullableContext(2)]
[Nullable(0)]
public class NpcMontageController
{
	// Token: 0x0601BA5F RID: 113247 RVA: 0x00799134 File Offset: 0x00797334
	[NullableContext(1)]
	public NpcMontageController(Entity entity)
	{
		this.Entity = entity;
		this.AnimComp = this.Entity.GetComponent<BaseAnimationComponent>();
	}

	// Token: 0x0601BA60 RID: 113248 RVA: 0x00799154 File Offset: 0x00797354
	[NullableContext(1)]
	public int LoadAsync(string path, [Nullable(new byte[]
	{
		1,
		2,
		1
	})] Action<UAnimMontage, string> callback)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0601BA61 RID: 113249 RVA: 0x0079915B File Offset: 0x0079735B
	[NullableContext(1)]
	public void Play(UAnimMontage asset, [Nullable(2)] Action<UAnimMontage, bool> onEnded = null)
	{
		this.AnimComp.MainAnimInstance.Montage_Play(asset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
		if (onEnded != null)
		{
			this.AnimComp.MainAnimInstance.OnMontageEnded.Add(onEnded);
		}
	}

	// Token: 0x0601BA62 RID: 113250 RVA: 0x00799194 File Offset: 0x00797394
	public void PlayOnce(UAnimMontage asset, Action<UAnimMontage, bool> onEnded = null)
	{
		this.AnimComp.MainAnimInstance.Montage_Play(asset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
		this.AnimComp.MainAnimInstance.Montage_SetNextSection(CharacterNameDefines.Instance.LOOP_SECTION, CharacterNameDefines.Instance.END_SECTION, asset);
		if (onEnded != null)
		{
			this.AnimComp.MainAnimInstance.OnMontageEnded.Add(onEnded);
		}
	}

	// Token: 0x0601BA63 RID: 113251 RVA: 0x00799200 File Offset: 0x00797400
	[NullableContext(1)]
	public void PlayFromLoop(UAnimMontage asset, [Nullable(2)] Action<UAnimMontage, bool> onEnded = null)
	{
		this.AnimComp.MainAnimInstance.Montage_Play(asset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
		this.AnimComp.MainAnimInstance.Montage_JumpToSection(CharacterNameDefines.Instance.LOOP_SECTION, asset);
		if (onEnded != null)
		{
			this.AnimComp.MainAnimInstance.OnMontageEnded.Add(onEnded);
		}
	}

	// Token: 0x0601BA64 RID: 113252 RVA: 0x00799260 File Offset: 0x00797460
	[NullableContext(1)]
	public void PlayFromEnd(UAnimMontage asset, [Nullable(2)] Action<UAnimMontage, bool> onEnded = null)
	{
		this.AnimComp.MainAnimInstance.Montage_Play(asset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
		this.AnimComp.MainAnimInstance.Montage_JumpToSection(CharacterNameDefines.Instance.END_SECTION, asset);
		if (onEnded != null)
		{
			this.AnimComp.MainAnimInstance.OnMontageEnded.Add(onEnded);
		}
	}

	// Token: 0x0601BA65 RID: 113253 RVA: 0x007992C0 File Offset: 0x007974C0
	public void Stop(bool immediately = false, UAnimMontage asset = null)
	{
		if (immediately)
		{
			this.AnimComp.MainAnimInstance.Montage_JumpToSection(CharacterNameDefines.Instance.END_SECTION, asset);
			return;
		}
		this.AnimComp.MainAnimInstance.Montage_SetNextSection(CharacterNameDefines.Instance.LOOP_SECTION, CharacterNameDefines.Instance.END_SECTION, asset);
	}

	// Token: 0x0601BA66 RID: 113254 RVA: 0x00799311 File Offset: 0x00797511
	public void ForceStop(float? blendOutTime = null, UAnimMontage asset = null)
	{
		this.AnimComp.MainAnimInstance.Montage_Stop(blendOutTime.GetValueOrDefault(), asset);
	}

	// Token: 0x0601BA67 RID: 113255 RVA: 0x0079932B File Offset: 0x0079752B
	[NullableContext(1)]
	public void ForceStopWithBlendOut(float blendOutTime, UAnimMontage asset)
	{
	}

	// Token: 0x0601BA68 RID: 113256 RVA: 0x0079932D File Offset: 0x0079752D
	public void AddOnMontageEnded(Action<UAnimMontage, bool> onEnded)
	{
		if (onEnded != null)
		{
			UAnimInstance mainAnimInstance = this.AnimComp.MainAnimInstance;
			if (mainAnimInstance == null)
			{
				return;
			}
			mainAnimInstance.OnMontageEnded.Add(onEnded);
		}
	}

	// Token: 0x0601BA69 RID: 113257 RVA: 0x0079934D File Offset: 0x0079754D
	public void RemoveOnMontageEnded(Action<UAnimMontage, bool> onEnded)
	{
		if (onEnded != null)
		{
			UAnimInstance mainAnimInstance = this.AnimComp.MainAnimInstance;
			if (mainAnimInstance == null)
			{
				return;
			}
			mainAnimInstance.OnMontageEnded.Remove(onEnded);
		}
	}

	// Token: 0x0400D971 RID: 55665
	private readonly Entity Entity;

	// Token: 0x0400D972 RID: 55666
	private readonly BaseAnimationComponent AnimComp;
}
