using System;

// Token: 0x0200122E RID: 4654
public abstract class ControllerAssistantBase
{
	// Token: 0x0600B945 RID: 47429 RVA: 0x0036BB7D File Offset: 0x00369D7D
	public void Init()
	{
		this.OnInit();
	}

	// Token: 0x0600B946 RID: 47430 RVA: 0x0036BB85 File Offset: 0x00369D85
	protected virtual void OnInit()
	{
	}

	// Token: 0x0600B947 RID: 47431 RVA: 0x0036BB87 File Offset: 0x00369D87
	public virtual void OnRegisterNetEvent()
	{
	}

	// Token: 0x0600B948 RID: 47432 RVA: 0x0036BB89 File Offset: 0x00369D89
	public virtual void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x0600B949 RID: 47433 RVA: 0x0036BB8B File Offset: 0x00369D8B
	public virtual void OnAddEvents()
	{
	}

	// Token: 0x0600B94A RID: 47434 RVA: 0x0036BB8D File Offset: 0x00369D8D
	public virtual void OnRemoveEvents()
	{
	}

	// Token: 0x0600B94B RID: 47435 RVA: 0x0036BB8F File Offset: 0x00369D8F
	public void Destroy()
	{
		this.OnDestroy();
	}

	// Token: 0x0600B94C RID: 47436
	protected abstract void OnDestroy();
}
