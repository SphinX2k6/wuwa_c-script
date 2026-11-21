using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002780 RID: 10112
[NullableContext(2)]
[Nullable(0)]
public class NpcMontageController
{
	// Token: 0x060195E4 RID: 103908 RVA: 0x007C18D0 File Offset: 0x007BFAD0
	[NullableContext(1)]
	public NpcMontageController(Entity entity)
	{
		this.Entity = entity;
		this.AnimComp = this.Entity.GetComponent<BaseAnimationComponent>();
	}

	// Token: 0x060195E5 RID: 103909 RVA: 0x007C18F0 File Offset: 0x007BFAF0
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

	// Token: 0x060195E6 RID: 103910 RVA: 0x007C18F7 File Offset: 0x007BFAF7
	[NullableContext(1)]
	public void Play(UAnimMontage asset, [Nullable(2)] Action<UAnimMontage, bool> onEnded = null)
	{
		this.AnimComp.MainAnimInstance.Montage_Play(asset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
		if (onEnded != null)
		{
			this.AnimComp.MainAnimInstance.OnMontageEnded.Add(onEnded);
		}
	}

	// Token: 0x060195E7 RID: 103911 RVA: 0x007C1930 File Offset: 0x007BFB30
	public void PlayOnce(UAnimMontage asset, Action<UAnimMontage, bool> onEnded = null)
	{
		this.AnimComp.MainAnimInstance.Montage_Play(asset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
		this.AnimComp.MainAnimInstance.Montage_SetNextSection(CharacterNameDefines.Instance.LOOP_SECTION, CharacterNameDefines.Instance.END_SECTION, asset);
		if (onEnded != null)
		{
			this.AnimComp.MainAnimInstance.OnMontageEnded.Add(onEnded);
		}
	}

	// Token: 0x060195E8 RID: 103912 RVA: 0x007C199C File Offset: 0x007BFB9C
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

	// Token: 0x060195E9 RID: 103913 RVA: 0x007C19FC File Offset: 0x007BFBFC
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

	// Token: 0x060195EA RID: 103914 RVA: 0x007C1A5C File Offset: 0x007BFC5C
	public void Stop(bool immediately = false, UAnimMontage asset = null)
	{
		if (immediately)
		{
			this.AnimComp.MainAnimInstance.Montage_JumpToSection(CharacterNameDefines.Instance.END_SECTION, asset);
			return;
		}
		this.AnimComp.MainAnimInstance.Montage_SetNextSection(CharacterNameDefines.Instance.LOOP_SECTION, CharacterNameDefines.Instance.END_SECTION, asset);
	}

	// Token: 0x060195EB RID: 103915 RVA: 0x007C1AAD File Offset: 0x007BFCAD
	public void ForceStop(float? blendOutTime = null, UAnimMontage asset = null)
	{
		this.AnimComp.MainAnimInstance.Montage_Stop(blendOutTime.GetValueOrDefault(), asset);
	}

	// Token: 0x060195EC RID: 103916 RVA: 0x007C1AC7 File Offset: 0x007BFCC7
	[NullableContext(1)]
	public void ForceStopWithBlendOut(float blendOutTime, UAnimMontage asset)
	{
	}

	// Token: 0x060195ED RID: 103917 RVA: 0x007C1AC9 File Offset: 0x007BFCC9
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

	// Token: 0x060195EE RID: 103918 RVA: 0x007C1AE9 File Offset: 0x007BFCE9
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

	// Token: 0x0400DE10 RID: 56848
	private readonly Entity Entity;

	// Token: 0x0400DE11 RID: 56849
	private readonly BaseAnimationComponent AnimComp;
}
