using System;
using System.Runtime.CompilerServices;

// Token: 0x02002407 RID: 9223
[NullableContext(2)]
[Nullable(0)]
public abstract class CustomActionBase
{
	// Token: 0x06017167 RID: 94567 RVA: 0x006BFB49 File Offset: 0x006BDD49
	public bool CheckStart()
	{
		return this.IsStart;
	}

	// Token: 0x06017168 RID: 94568 RVA: 0x006BFB51 File Offset: 0x006BDD51
	public bool CheckFinish(float delta)
	{
		this.OnCheckFinish(delta);
		return this.IsFinish;
	}

	// Token: 0x06017169 RID: 94569 RVA: 0x006BFB60 File Offset: 0x006BDD60
	public bool CheckSuccessful()
	{
		return this.IsSuccessful;
	}

	// Token: 0x0601716A RID: 94570 RVA: 0x006BFB68 File Offset: 0x006BDD68
	public void RunAction()
	{
		if (this.IsStart || this.IsFinish)
		{
			return;
		}
		this.IsStart = true;
		Action onStart = this.OnStart;
		if (onStart != null)
		{
			onStart();
		}
		this.OnRunAction();
	}

	// Token: 0x0601716B RID: 94571 RVA: 0x006BFB99 File Offset: 0x006BDD99
	public void Abort(bool success)
	{
		this.OnAbort();
		this.Finish(success);
	}

	// Token: 0x0601716C RID: 94572
	protected abstract void OnRunAction();

	// Token: 0x0601716D RID: 94573 RVA: 0x006BFBA8 File Offset: 0x006BDDA8
	protected virtual void OnFinish(bool success)
	{
	}

	// Token: 0x0601716E RID: 94574 RVA: 0x006BFBAA File Offset: 0x006BDDAA
	protected virtual void OnCheckFinish(float delta)
	{
	}

	// Token: 0x0601716F RID: 94575 RVA: 0x006BFBAC File Offset: 0x006BDDAC
	protected virtual void OnAbort()
	{
	}

	// Token: 0x06017170 RID: 94576 RVA: 0x006BFBAE File Offset: 0x006BDDAE
	protected void Finish(bool success)
	{
		if (this.IsFinish)
		{
			return;
		}
		this.IsSuccessful = success;
		this.IsFinish = true;
		Action callback = this.Callback;
		if (callback != null)
		{
			callback();
		}
		this.OnFinish(success);
	}

	// Token: 0x0400C240 RID: 49728
	protected const int MODEL_BUFFER_TIME = 200;

	// Token: 0x0400C241 RID: 49729
	protected const float MAX_ROTATION_TIME = 1000f;

	// Token: 0x0400C242 RID: 49730
	protected const float ROTATION_ANGLE_TOLERANCE = 10f;

	// Token: 0x0400C243 RID: 49731
	protected bool IsStart;

	// Token: 0x0400C244 RID: 49732
	protected bool IsFinish;

	// Token: 0x0400C245 RID: 49733
	protected bool IsSuccessful;

	// Token: 0x0400C246 RID: 49734
	protected Action OnStart;

	// Token: 0x0400C247 RID: 49735
	protected Action Callback;
}
