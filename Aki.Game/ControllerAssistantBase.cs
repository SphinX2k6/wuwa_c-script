using System;

// Token: 0x02001D6C RID: 7532
public abstract class ControllerAssistantBase
{
	// Token: 0x0600E527 RID: 58663 RVA: 0x0035FF29 File Offset: 0x0035E129
	public void Init()
	{
		this.OnInit();
	}

	// Token: 0x0600E528 RID: 58664 RVA: 0x0035FF31 File Offset: 0x0035E131
	protected virtual void OnInit()
	{
	}

	// Token: 0x0600E529 RID: 58665 RVA: 0x0035FF33 File Offset: 0x0035E133
	public virtual void OnRegisterNetEvent()
	{
	}

	// Token: 0x0600E52A RID: 58666 RVA: 0x0035FF35 File Offset: 0x0035E135
	public virtual void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x0600E52B RID: 58667 RVA: 0x0035FF37 File Offset: 0x0035E137
	public virtual void OnAddEvents()
	{
	}

	// Token: 0x0600E52C RID: 58668 RVA: 0x0035FF39 File Offset: 0x0035E139
	public virtual void OnRemoveEvents()
	{
	}

	// Token: 0x0600E52D RID: 58669 RVA: 0x0035FF3B File Offset: 0x0035E13B
	public void Destroy()
	{
		this.OnDestroy();
	}

	// Token: 0x0600E52E RID: 58670
	protected abstract void OnDestroy();
}
