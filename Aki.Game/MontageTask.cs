using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E7B RID: 11899
[NullableContext(2)]
[Nullable(0)]
internal class MontageTask
{
	// Token: 0x170022F4 RID: 8948
	// (get) Token: 0x060196E8 RID: 104168 RVA: 0x00691313 File Offset: 0x0068F513
	public bool Invalid
	{
		get
		{
			return this.InvalidInternal;
		}
	}

	// Token: 0x060196E9 RID: 104169 RVA: 0x0069131B File Offset: 0x0068F51B
	public MontageTask(BaseMontageComponent montageComponent, int handle, Action playCallback = null, Action<bool> endCallback = null)
	{
		this.MontageComponent = montageComponent;
		this.Handle = handle;
		this.PlayCallback = playCallback;
		this.EndCallback = endCallback;
		this.ReadyToPlay = false;
	}

	// Token: 0x060196EA RID: 104170 RVA: 0x00691354 File Offset: 0x0068F554
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

	// Token: 0x060196EB RID: 104171 RVA: 0x006913C0 File Offset: 0x0068F5C0
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

	// Token: 0x060196EC RID: 104172 RVA: 0x00691424 File Offset: 0x0068F624
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

	// Token: 0x060196ED RID: 104173 RVA: 0x006914A0 File Offset: 0x0068F6A0
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

	// Token: 0x060196EE RID: 104174 RVA: 0x00691618 File Offset: 0x0068F818
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

	// Token: 0x0400BD2D RID: 48429
	public UAnimMontage Montage;

	// Token: 0x0400BD2E RID: 48430
	public float BlendInTime;

	// Token: 0x0400BD2F RID: 48431
	public int MontagePathHash;

	// Token: 0x0400BD30 RID: 48432
	[Nullable(1)]
	public string MontageName = "";

	// Token: 0x0400BD31 RID: 48433
	public bool MontageNeedPush2Server;

	// Token: 0x0400BD32 RID: 48434
	public Action<float> RemainCallback;

	// Token: 0x0400BD33 RID: 48435
	private UAsyncTaskPlayMontageAndWait UeMontageTask;

	// Token: 0x0400BD34 RID: 48436
	private bool ReadyToPlay;

	// Token: 0x0400BD35 RID: 48437
	private bool Playing;

	// Token: 0x0400BD36 RID: 48438
	private bool InvalidInternal;

	// Token: 0x0400BD37 RID: 48439
	public BaseMontageComponent MontageComponent;

	// Token: 0x0400BD38 RID: 48440
	public int Handle;

	// Token: 0x0400BD39 RID: 48441
	public Action PlayCallback;

	// Token: 0x0400BD3A RID: 48442
	public Action<bool> EndCallback;
}
