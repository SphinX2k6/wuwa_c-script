using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EB4 RID: 11956
[NullableContext(2)]
[Nullable(0)]
public abstract class CustomActionBase
{
	// Token: 0x06019881 RID: 104577 RVA: 0x00699889 File Offset: 0x00697A89
	public bool CheckStart()
	{
		return this.IsStart;
	}

	// Token: 0x06019882 RID: 104578 RVA: 0x00699891 File Offset: 0x00697A91
	public bool CheckFinish(float delta)
	{
		this.OnCheckFinish(delta);
		return this.IsFinish;
	}

	// Token: 0x06019883 RID: 104579 RVA: 0x006998A0 File Offset: 0x00697AA0
	public bool CheckSuccessful()
	{
		return this.IsSuccessful;
	}

	// Token: 0x06019884 RID: 104580 RVA: 0x006998A8 File Offset: 0x00697AA8
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

	// Token: 0x06019885 RID: 104581 RVA: 0x006998D9 File Offset: 0x00697AD9
	public void Abort(bool success)
	{
		this.OnAbort();
		this.Finish(success);
	}

	// Token: 0x06019886 RID: 104582
	protected abstract void OnRunAction();

	// Token: 0x06019887 RID: 104583 RVA: 0x006998E8 File Offset: 0x00697AE8
	protected virtual void OnFinish(bool success)
	{
	}

	// Token: 0x06019888 RID: 104584 RVA: 0x006998EA File Offset: 0x00697AEA
	protected virtual void OnCheckFinish(float delta)
	{
	}

	// Token: 0x06019889 RID: 104585 RVA: 0x006998EC File Offset: 0x00697AEC
	protected virtual void OnAbort()
	{
	}

	// Token: 0x0601988A RID: 104586 RVA: 0x006998EE File Offset: 0x00697AEE
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

	// Token: 0x0400BEA5 RID: 48805
	protected const int MODEL_BUFFER_TIME = 200;

	// Token: 0x0400BEA6 RID: 48806
	protected const float MAX_ROTATION_TIME = 1000f;

	// Token: 0x0400BEA7 RID: 48807
	protected const float ROTATION_ANGLE_TOLERANCE = 10f;

	// Token: 0x0400BEA8 RID: 48808
	protected bool IsStart;

	// Token: 0x0400BEA9 RID: 48809
	protected bool IsFinish;

	// Token: 0x0400BEAA RID: 48810
	protected bool IsSuccessful;

	// Token: 0x0400BEAB RID: 48811
	protected Action OnStart;

	// Token: 0x0400BEAC RID: 48812
	protected Action Callback;
}
