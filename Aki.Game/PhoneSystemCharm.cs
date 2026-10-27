using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhoneMessage;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200252F RID: 9519
public class PhoneSystemCharm : UiPanelBase
{
	// Token: 0x0601323C RID: 78396 RVA: 0x004C035C File Offset: 0x004BE55C
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

	// Token: 0x0601323D RID: 78397 RVA: 0x004C03C4 File Offset: 0x004BE5C4
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

	// Token: 0x0601323E RID: 78398 RVA: 0x004C0414 File Offset: 0x004BE614
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

	// Token: 0x0601323F RID: 78399 RVA: 0x004C0480 File Offset: 0x004BE680
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

	// Token: 0x06013240 RID: 78400 RVA: 0x004C0533 File Offset: 0x004BE733
	public void TriggerInteract()
	{
		this.OnClickedBtn();
	}

	// Token: 0x06013241 RID: 78401 RVA: 0x004C053C File Offset: 0x004BE73C
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

	// Token: 0x06013242 RID: 78402 RVA: 0x004C05E4 File Offset: 0x004BE7E4
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

	// Token: 0x06013243 RID: 78403 RVA: 0x004C0656 File Offset: 0x004BE856
	protected override void OnBeforeDestroy()
	{
		USpineSkeletonAnimationComponent spine = base.GetSpine(0);
		if (spine == null)
		{
			return;
		}
		spine.AnimationComplete.Clear();
	}

	// Token: 0x04009089 RID: 37001
	private int CurCharmId;

	// Token: 0x0400908A RID: 37002
	private PhoneSystemCharm.EAnimState CurState;

	// Token: 0x02008AB8 RID: 35512
	private enum EComponent
	{
		// Token: 0x0402D0CA RID: 184522
		SkinSpine,
		// Token: 0x0402D0CB RID: 184523
		BtnSpineClick
	}

	// Token: 0x02008AB9 RID: 35513
	private enum EAnimState
	{
		// Token: 0x0402D0CD RID: 184525
		Idle,
		// Token: 0x0402D0CE RID: 184526
		Standby,
		// Token: 0x0402D0CF RID: 184527
		Touch
	}
}
