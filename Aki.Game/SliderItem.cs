using System;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x020014DE RID: 5342
public class SliderItem : UiPanelBase
{
	// Token: 0x170013B7 RID: 5047
	// (get) Token: 0x0600D5B2 RID: 54706 RVA: 0x003F77EE File Offset: 0x003F59EE
	// (set) Token: 0x0600D5B3 RID: 54707 RVA: 0x003F77F6 File Offset: 0x003F59F6
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

	// Token: 0x170013B8 RID: 5048
	// (get) Token: 0x0600D5B4 RID: 54708 RVA: 0x003F77FF File Offset: 0x003F59FF
	// (set) Token: 0x0600D5B5 RID: 54709 RVA: 0x003F7807 File Offset: 0x003F5A07
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

	// Token: 0x0600D5B6 RID: 54710 RVA: 0x003F7810 File Offset: 0x003F5A10
	public virtual UniTask AsyncLoadUiResource()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600D5B7 RID: 54711 RVA: 0x003F7817 File Offset: 0x003F5A17
	public virtual void InitData()
	{
	}

	// Token: 0x0600D5B8 RID: 54712 RVA: 0x003F7819 File Offset: 0x003F5A19
	public virtual void Play()
	{
		this.StatusInternal = EStatus.Start;
		this.AddShowTime = 0f;
		this.PlayStart();
	}

	// Token: 0x0600D5B9 RID: 54713 RVA: 0x003F7833 File Offset: 0x003F5A33
	protected virtual void PlayStart()
	{
	}

	// Token: 0x0600D5BA RID: 54714 RVA: 0x003F7835 File Offset: 0x003F5A35
	protected void FinishPlayStart()
	{
		this.StatusInternal = EStatus.Halfway;
		this.PlayHalfway();
	}

	// Token: 0x0600D5BB RID: 54715 RVA: 0x003F7844 File Offset: 0x003F5A44
	protected virtual void PlayHalfway()
	{
	}

	// Token: 0x0600D5BC RID: 54716 RVA: 0x003F7846 File Offset: 0x003F5A46
	protected void FinishPlayHalfway()
	{
	}

	// Token: 0x0600D5BD RID: 54717 RVA: 0x003F7848 File Offset: 0x003F5A48
	public virtual void PlayEnd()
	{
	}

	// Token: 0x0600D5BE RID: 54718 RVA: 0x003F784A File Offset: 0x003F5A4A
	protected void FinishPlayEnd()
	{
		this.StatusInternal = EStatus.Finish;
	}

	// Token: 0x0600D5BF RID: 54719 RVA: 0x003F7853 File Offset: 0x003F5A53
	public virtual void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x0600D5C0 RID: 54720 RVA: 0x003F785C File Offset: 0x003F5A5C
	public virtual void ActiveStatusChange(bool status)
	{
		this.OnActiveStatusChange(status);
	}

	// Token: 0x0600D5C1 RID: 54721 RVA: 0x003F7865 File Offset: 0x003F5A65
	protected virtual void OnActiveStatusChange(bool status)
	{
	}

	// Token: 0x0600D5C2 RID: 54722 RVA: 0x003F7867 File Offset: 0x003F5A67
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0600D5C3 RID: 54723 RVA: 0x003F7869 File Offset: 0x003F5A69
	public virtual bool ShowTimeIsEnough(float time)
	{
		return this.AddShowTime >= time;
	}

	// Token: 0x040077EA RID: 30698
	protected float AddShowTimeInternal;

	// Token: 0x040077EB RID: 30699
	private EStatus StatusInternal;
}
