using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D6D RID: 7533
public abstract class ControllerWithAssistantBase : ControllerBase
{
	// Token: 0x0600E530 RID: 58672 RVA: 0x0035FF4B File Offset: 0x0035E14B
	public override bool Init()
	{
		bool result = base.Init();
		this.OnRegisterNetEvent();
		this.OnAddEvents();
		return result;
	}

	// Token: 0x0600E531 RID: 58673 RVA: 0x0035FF5F File Offset: 0x0035E15F
	public override bool Clear()
	{
		this.OnUnRegisterNetEvent();
		this.OnRemoveEvents();
		return base.Clear();
	}

	// Token: 0x0600E532 RID: 58674 RVA: 0x0035FF73 File Offset: 0x0035E173
	protected override bool OnInit()
	{
		this.InitAssistants();
		return true;
	}

	// Token: 0x0600E533 RID: 58675 RVA: 0x0035FF7C File Offset: 0x0035E17C
	protected override bool OnClear()
	{
		this.ClearAssistant();
		return base.OnClear();
	}

	// Token: 0x0600E534 RID: 58676 RVA: 0x0035FF8A File Offset: 0x0035E18A
	protected virtual void OnRegisterNetEvent()
	{
		this.AssistantRegisterNetEvent();
	}

	// Token: 0x0600E535 RID: 58677 RVA: 0x0035FF92 File Offset: 0x0035E192
	protected virtual void OnUnRegisterNetEvent()
	{
		this.AssistantUnRegisterNetEvent();
	}

	// Token: 0x0600E536 RID: 58678 RVA: 0x0035FF9A File Offset: 0x0035E19A
	protected virtual void OnAddEvents()
	{
		this.AssistantAddEvents();
	}

	// Token: 0x0600E537 RID: 58679 RVA: 0x0035FFA2 File Offset: 0x0035E1A2
	protected virtual void OnRemoveEvents()
	{
		this.AssistantRemoveEvents();
	}

	// Token: 0x0600E538 RID: 58680 RVA: 0x0035FFAA File Offset: 0x0035E1AA
	private void InitAssistants()
	{
		this.Assistants = new Dictionary<int, ControllerAssistantBase>();
		this.RegisterAssistant();
	}

	// Token: 0x0600E539 RID: 58681 RVA: 0x0035FFBD File Offset: 0x0035E1BD
	protected virtual void RegisterAssistant()
	{
	}

	// Token: 0x0600E53A RID: 58682 RVA: 0x0035FFC0 File Offset: 0x0035E1C0
	private void ClearAssistant()
	{
		if (this.Assistants != null)
		{
			foreach (ControllerAssistantBase controllerAssistantBase in this.Assistants.Values)
			{
				controllerAssistantBase.Destroy();
			}
			this.Assistants.Clear();
			this.Assistants = null;
		}
	}

	// Token: 0x0600E53B RID: 58683 RVA: 0x00360030 File Offset: 0x0035E230
	private void AssistantRegisterNetEvent()
	{
		if (this.Assistants == null)
		{
			return;
		}
		foreach (ControllerAssistantBase controllerAssistantBase in this.Assistants.Values)
		{
			controllerAssistantBase.OnRegisterNetEvent();
		}
	}

	// Token: 0x0600E53C RID: 58684 RVA: 0x00360090 File Offset: 0x0035E290
	private void AssistantUnRegisterNetEvent()
	{
		if (this.Assistants == null)
		{
			return;
		}
		foreach (ControllerAssistantBase controllerAssistantBase in this.Assistants.Values)
		{
			controllerAssistantBase.OnUnRegisterNetEvent();
		}
	}

	// Token: 0x0600E53D RID: 58685 RVA: 0x003600F0 File Offset: 0x0035E2F0
	private void AssistantAddEvents()
	{
		if (this.Assistants == null)
		{
			return;
		}
		foreach (ControllerAssistantBase controllerAssistantBase in this.Assistants.Values)
		{
			controllerAssistantBase.OnAddEvents();
		}
	}

	// Token: 0x0600E53E RID: 58686 RVA: 0x00360150 File Offset: 0x0035E350
	private void AssistantRemoveEvents()
	{
		if (this.Assistants == null)
		{
			return;
		}
		foreach (ControllerAssistantBase controllerAssistantBase in this.Assistants.Values)
		{
			controllerAssistantBase.OnRemoveEvents();
		}
	}

	// Token: 0x0600E53F RID: 58687 RVA: 0x003601B0 File Offset: 0x0035E3B0
	[NullableContext(2)]
	public void AddAssistant(int assistantType, ControllerAssistantBase assistantObj)
	{
		if (assistantObj == null)
		{
			return;
		}
		assistantObj.Init();
		this.Assistants[assistantType] = assistantObj;
	}

	// Token: 0x040069A8 RID: 27048
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, ControllerAssistantBase> Assistants;
}
