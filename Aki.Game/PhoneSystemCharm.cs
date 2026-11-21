using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A16 RID: 6678
public class PhoneSystemCharm : UiPanelBase
{
	// Token: 0x060106FC RID: 67324 RVA: 0x004CE068 File Offset: 0x004CC268
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickedBtn))
		};
	}

	// Token: 0x060106FD RID: 67325 RVA: 0x004CE0D0 File Offset: 0x004CC2D0
	public void Play(int charmId)
	{
		this.CurCharmId = charmId;
		USpineSkeletonAnimationComponent spine = base.GetSpine(0);
		if (spine == null || !spine.IsValid())
		{
			return;
		}
		spine.AnimationComplete.Clear();
		spine.AnimationComplete.Add(new Action<UTrackEntry>(this.OnSpineAnimComplete));
		this.PlayIdle();
	}

	// Token: 0x060106FE RID: 67326 RVA: 0x004CE120 File Offset: 0x004CC320
	private void PlayIdle()
	{
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(this.CurCharmId);
		if (chatCharmConfig == null)
		{
			return;
		}
		USpineSkeletonAnimationComponent spine = base.GetSpine(0);
		if (spine == null || !spine.IsValid())
		{
			return;
		}
		string spineAnimIdle = chatCharmConfig.Value.SpineAnimIdle;
		if (spineAnimIdle == "")
		{
			return;
		}
		this.CurState = PhoneSystemCharm.EAnimState.Idle;
		spine.SetAnimation(0, spineAnimIdle, false);
	}

	// Token: 0x060106FF RID: 67327 RVA: 0x004CE18C File Offset: 0x004CC38C
	private void PlayStandby()
	{
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(this.CurCharmId);
		if (chatCharmConfig == null)
		{
			return;
		}
		USpineSkeletonAnimationComponent spine = base.GetSpine(0);
		if (spine == null || !spine.IsValid())
		{
			return;
		}
		if (chatCharmConfig.Value.SpineAnimStandbyLength <= 0)
		{
			this.PlayIdle();
			return;
		}
		int j = (int)MathUtils.Instance.GetRandomRange(0.0, (double)chatCharmConfig.Value.SpineAnimStandbyLength);
		string text = chatCharmConfig.Value.SpineAnimStandby(j);
		if (text == "")
		{
			this.PlayIdle();
			return;
		}
		this.CurState = PhoneSystemCharm.EAnimState.Standby;
		spine.SetAnimation(0, text, false);
	}

	// Token: 0x06010700 RID: 67328 RVA: 0x004CE23F File Offset: 0x004CC43F
	public void TriggerInteract()
	{
		this.OnClickedBtn();
	}

	// Token: 0x06010701 RID: 67329 RVA: 0x004CE248 File Offset: 0x004CC448
	private void OnClickedBtn()
	{
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(this.CurCharmId);
		if (chatCharmConfig == null)
		{
			return;
		}
		USpineSkeletonAnimationComponent spine = base.GetSpine(0);
		if (spine == null || !spine.IsValid())
		{
			return;
		}
		if (chatCharmConfig.Value.SpineAnimTouchLength <= 0)
		{
			return;
		}
		int j = (int)MathUtils.Instance.GetRandomRange(0.0, (double)chatCharmConfig.Value.SpineAnimTouchLength);
		string text = chatCharmConfig.Value.SpineAnimTouch(j);
		if (text == "")
		{
			return;
		}
		this.CurState = PhoneSystemCharm.EAnimState.Touch;
		spine.SetAnimation(0, text, false);
	}

	// Token: 0x06010702 RID: 67330 RVA: 0x004CE2F0 File Offset: 0x004CC4F0
	[NullableContext(2)]
	private void OnSpineAnimComplete(UTrackEntry entry)
	{
		ChatCharm? chatCharmConfig = PhoneMsgConfig.Instance.GetChatCharmConfig(this.CurCharmId);
		if (chatCharmConfig == null)
		{
			return;
		}
		if (this.CurState != PhoneSystemCharm.EAnimState.Idle)
		{
			this.PlayIdle();
			return;
		}
		if ((float)MathUtils.Instance.GetRandomRange(0.0, 1.0) < chatCharmConfig.Value.SpineProbability)
		{
			this.PlayStandby();
			return;
		}
		this.PlayIdle();
	}

	// Token: 0x06010703 RID: 67331 RVA: 0x004CE362 File Offset: 0x004CC562
	protected override void OnBeforeDestroy()
	{
		USpineSkeletonAnimationComponent spine = base.GetSpine(0);
		if (spine == null)
		{
			return;
		}
		spine.AnimationComplete.Clear();
	}

	// Token: 0x040091DE RID: 37342
	private int CurCharmId;

	// Token: 0x040091DF RID: 37343
	private PhoneSystemCharm.EAnimState CurState;

	// Token: 0x02007C3F RID: 31807
	private enum EComponent
	{
		// Token: 0x040283DE RID: 164830
		SkinSpine,
		// Token: 0x040283DF RID: 164831
		BtnSpineClick
	}

	// Token: 0x02007C40 RID: 31808
	private enum EAnimState
	{
		// Token: 0x040283E1 RID: 164833
		Idle,
		// Token: 0x040283E2 RID: 164834
		Standby,
		// Token: 0x040283E3 RID: 164835
		Touch
	}
}
