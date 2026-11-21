using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023CD RID: 9165
[NullableContext(2)]
[Nullable(0)]
internal class MontageTask
{
	// Token: 0x1700237D RID: 9085
	// (get) Token: 0x06016FBC RID: 94140 RVA: 0x006B7741 File Offset: 0x006B5941
	public bool Invalid
	{
		get
		{
			return this.InvalidInternal;
		}
	}

	// Token: 0x06016FBD RID: 94141 RVA: 0x006B7749 File Offset: 0x006B5949
	public MontageTask(BaseMontageComponent montageComponent, int handle, Action playCallback = null, Action<bool> endCallback = null)
	{
		this.MontageComponent = montageComponent;
		this.Handle = handle;
		this.PlayCallback = playCallback;
		this.EndCallback = endCallback;
		this.ReadyToPlay = false;
	}

	// Token: 0x06016FBE RID: 94142 RVA: 0x006B7780 File Offset: 0x006B5980
	[NullableContext(1)]
	public void InitWithPath(string montageName, float blendInTime = -1f)
	{
		this.BlendInTime = blendInTime;
		this.MontageName = montageName;
		BaseMontageComponent montageComponent = this.MontageComponent;
		UAnimMontage uanimMontage = (montageComponent != null) ? montageComponent.GetMontageByName(montageName, true, false) : null;
		BaseMontageComponent montageComponent2 = this.MontageComponent;
		string text = (montageComponent2 != null) ? montageComponent2.GetMontagePathByName(montageName, true, false) : null;
		if (this.MontageComponent == null || uanimMontage == null || string.IsNullOrEmpty(text))
		{
			this.InvalidInternal = true;
			return;
		}
		this.InitInternal(uanimMontage, montageName, text, blendInTime);
	}

	// Token: 0x06016FBF RID: 94143 RVA: 0x006B77EC File Offset: 0x006B59EC
	[NullableContext(1)]
	public void InitWithMontage(UAnimMontage montage, float blendInTime = -1f)
	{
		this.BlendInTime = blendInTime;
		string text = (montage != null) ? montage.GetName() : null;
		BaseMontageComponent montageComponent = this.MontageComponent;
		string text2 = (montageComponent != null) ? montageComponent.GetMontagePathByName(text, true, false) : null;
		if (this.MontageComponent == null || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text))
		{
			this.InvalidInternal = true;
			return;
		}
		this.InitInternal(montage, text, text2, blendInTime);
	}

	// Token: 0x06016FC0 RID: 94144 RVA: 0x006B7850 File Offset: 0x006B5A50
	[NullableContext(1)]
	private void InitInternal(UAnimMontage montage, string montageName, string path, float blendInTime)
	{
		if (montage == null)
		{
			this.InvalidInternal = true;
			return;
		}
		this.BlendInTime = blendInTime;
		this.MontageName = montage.GetName();
		this.MontagePathHash = UGASBPLibrary.FnvHash(path);
		BaseMontageComponent montageComponent = this.MontageComponent;
		this.MontageNeedPush2Server = (montageComponent != null && montageComponent.IsMontageNeedPush2Server(montageName));
		if (this.InvalidInternal)
		{
			return;
		}
		this.Montage = montage;
		if (this.ReadyToPlay)
		{
			this.Play(0f, -1f);
		}
	}

	// Token: 0x06016FC1 RID: 94145 RVA: 0x006B78CC File Offset: 0x006B5ACC
	public void Play(float startPosition = 0f, float remainedTrigger = -1f)
	{
		if (this.InvalidInternal)
		{
			return;
		}
		Action playCallback = this.PlayCallback;
		if (playCallback != null)
		{
			playCallback();
		}
		if (this.Montage != null && !this.Playing)
		{
			float blendTime = this.Montage.BlendIn.BlendTime;
			if (this.BlendInTime >= 0f)
			{
				this.Montage.BlendIn.BlendTime = this.BlendInTime;
			}
			float remainedTrigger2 = BaseMontageComponent.RemainedTriggerOn ? remainedTrigger : -1f;
			this.UeMontageTask = UAsyncTaskPlayMontageAndWait.ListenRemainForPlayMontage(this.MontageComponent.GetMainAnimInstance(), this.Montage, 1f, startPosition, FNameUtil.NONE, remainedTrigger2);
			if (this.UeMontageTask.MontageLength <= 0f)
			{
				Action<bool> endCallback = this.EndCallback;
				if (endCallback != null)
				{
					endCallback(true);
				}
				this.MontageComponent.EndMontageTask(this.Handle);
				return;
			}
			if (this.BlendInTime >= 0f)
			{
				this.Montage.BlendIn.BlendTime = blendTime;
			}
			this.UeMontageTask.EndCallback.Add(delegate(bool isInterrupted)
			{
				Action<bool> endCallback2 = this.EndCallback;
				if (endCallback2 != null)
				{
					endCallback2(isInterrupted);
				}
				this.MontageComponent.EndMontageTask(this.Handle);
			});
			this.UeMontageTask.RemainCallback.Add(delegate(float remainTime)
			{
				Action<float> remainCallback = this.RemainCallback;
				if (remainCallback == null)
				{
					return;
				}
				remainCallback(remainTime);
			});
			this.MontageComponent.PushMontageInfo(new MontageInfo
			{
				MontageNames = new List<string>(),
				MontageTaskMessageId = this.MontageComponent.MontageTaskMessageId
			}, this.Montage);
			this.Playing = true;
		}
		this.ReadyToPlay = true;
	}

	// Token: 0x06016FC2 RID: 94146 RVA: 0x006B7A44 File Offset: 0x006B5C44
	public void EndTask()
	{
		UAsyncTaskPlayMontageAndWait ueMontageTask = this.UeMontageTask;
		if (ueMontageTask != null)
		{
			ueMontageTask.EndTask();
		}
		UAsyncTaskPlayMontageAndWait ueMontageTask2 = this.UeMontageTask;
		if (ueMontageTask2 != null)
		{
			ueMontageTask2.EndCallback.Clear();
		}
		UAsyncTaskPlayMontageAndWait ueMontageTask3 = this.UeMontageTask;
		if (ueMontageTask3 != null)
		{
			ueMontageTask3.RemainCallback.Clear();
		}
		this.UeMontageTask = null;
		this.MontageComponent = null;
		this.PlayCallback = null;
		this.EndCallback = null;
		this.RemainCallback = null;
		this.InvalidInternal = true;
	}

	// Token: 0x0400C0C4 RID: 49348
	public UAnimMontage Montage;

	// Token: 0x0400C0C5 RID: 49349
	public float BlendInTime;

	// Token: 0x0400C0C6 RID: 49350
	public int MontagePathHash;

	// Token: 0x0400C0C7 RID: 49351
	[Nullable(1)]
	public string MontageName = "";

	// Token: 0x0400C0C8 RID: 49352
	public bool MontageNeedPush2Server;

	// Token: 0x0400C0C9 RID: 49353
	public Action<float> RemainCallback;

	// Token: 0x0400C0CA RID: 49354
	private UAsyncTaskPlayMontageAndWait UeMontageTask;

	// Token: 0x0400C0CB RID: 49355
	private bool ReadyToPlay;

	// Token: 0x0400C0CC RID: 49356
	private bool Playing;

	// Token: 0x0400C0CD RID: 49357
	private bool InvalidInternal;

	// Token: 0x0400C0CE RID: 49358
	public BaseMontageComponent MontageComponent;

	// Token: 0x0400C0CF RID: 49359
	public int Handle;

	// Token: 0x0400C0D0 RID: 49360
	public Action PlayCallback;

	// Token: 0x0400C0D1 RID: 49361
	public Action<bool> EndCallback;
}
