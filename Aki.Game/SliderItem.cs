using System;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x0200200B RID: 8203
public class SliderItem : UiPanelBase
{
	// Token: 0x1700138A RID: 5002
	// (get) Token: 0x0601014A RID: 65866 RVA: 0x003EB1F6 File Offset: 0x003E93F6
	// (set) Token: 0x0601014B RID: 65867 RVA: 0x003EB1FE File Offset: 0x003E93FE
	public float AddShowTime
	{
		get
		{
			return this.AddShowTimeInternal;
		}
		set
		{
			this.AddShowTimeInternal = value;
		}
	}

	// Token: 0x1700138B RID: 5003
	// (get) Token: 0x0601014C RID: 65868 RVA: 0x003EB207 File Offset: 0x003E9407
	// (set) Token: 0x0601014D RID: 65869 RVA: 0x003EB20F File Offset: 0x003E940F
	public EStatus Status
	{
		get
		{
			return this.StatusInternal;
		}
		set
		{
			this.StatusInternal = value;
		}
	}

	// Token: 0x0601014E RID: 65870 RVA: 0x003EB218 File Offset: 0x003E9418
	public virtual UniTask AsyncLoadUiResource()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0601014F RID: 65871 RVA: 0x003EB21F File Offset: 0x003E941F
	public virtual void InitData()
	{
	}

	// Token: 0x06010150 RID: 65872 RVA: 0x003EB221 File Offset: 0x003E9421
	public virtual void Play()
	{
		this.StatusInternal = EStatus.Start;
		this.AddShowTime = 0f;
		this.PlayStart();
	}

	// Token: 0x06010151 RID: 65873 RVA: 0x003EB23B File Offset: 0x003E943B
	protected virtual void PlayStart()
	{
	}

	// Token: 0x06010152 RID: 65874 RVA: 0x003EB23D File Offset: 0x003E943D
	protected void FinishPlayStart()
	{
		this.StatusInternal = EStatus.Halfway;
		this.PlayHalfway();
	}

	// Token: 0x06010153 RID: 65875 RVA: 0x003EB24C File Offset: 0x003E944C
	protected virtual void PlayHalfway()
	{
	}

	// Token: 0x06010154 RID: 65876 RVA: 0x003EB24E File Offset: 0x003E944E
	protected void FinishPlayHalfway()
	{
	}

	// Token: 0x06010155 RID: 65877 RVA: 0x003EB250 File Offset: 0x003E9450
	public virtual void PlayEnd()
	{
	}

	// Token: 0x06010156 RID: 65878 RVA: 0x003EB252 File Offset: 0x003E9452
	protected void FinishPlayEnd()
	{
		this.StatusInternal = EStatus.Finish;
	}

	// Token: 0x06010157 RID: 65879 RVA: 0x003EB25B File Offset: 0x003E945B
	public virtual void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x06010158 RID: 65880 RVA: 0x003EB264 File Offset: 0x003E9464
	public virtual void ActiveStatusChange(bool status)
	{
		this.OnActiveStatusChange(status);
	}

	// Token: 0x06010159 RID: 65881 RVA: 0x003EB26D File Offset: 0x003E946D
	protected virtual void OnActiveStatusChange(bool status)
	{
	}

	// Token: 0x0601015A RID: 65882 RVA: 0x003EB26F File Offset: 0x003E946F
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0601015B RID: 65883 RVA: 0x003EB271 File Offset: 0x003E9471
	public virtual bool ShowTimeIsEnough(float time)
	{
		return this.AddShowTime >= time;
	}

	// Token: 0x04007701 RID: 30465
	protected float AddShowTimeInternal;

	// Token: 0x04007702 RID: 30466
	private EStatus StatusInternal;
}
