using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200122F RID: 4655
public abstract class ControllerWithAssistantBase : ControllerBase
{
	// Token: 0x0600B94E RID: 47438 RVA: 0x0036BB9F File Offset: 0x00369D9F
	public override bool Init()
	{
		bool result = base.Init();
		this.OnRegisterNetEvent();
		this.OnAddEvents();
		return result;
	}

	// Token: 0x0600B94F RID: 47439 RVA: 0x0036BBB3 File Offset: 0x00369DB3
	public override bool Clear()
	{
		this.OnUnRegisterNetEvent();
		this.OnRemoveEvents();
		return base.Clear();
	}

	// Token: 0x0600B950 RID: 47440 RVA: 0x0036BBC7 File Offset: 0x00369DC7
	protected override bool OnInit()
	{
		this.InitAssistants();
		return true;
	}

	// Token: 0x0600B951 RID: 47441 RVA: 0x0036BBD0 File Offset: 0x00369DD0
	protected override bool OnClear()
	{
		this.ClearAssistant();
		return base.OnClear();
	}

	// Token: 0x0600B952 RID: 47442 RVA: 0x0036BBDE File Offset: 0x00369DDE
	protected virtual void OnRegisterNetEvent()
	{
		this.AssistantRegisterNetEvent();
	}

	// Token: 0x0600B953 RID: 47443 RVA: 0x0036BBE6 File Offset: 0x00369DE6
	protected virtual void OnUnRegisterNetEvent()
	{
		this.AssistantUnRegisterNetEvent();
	}

	// Token: 0x0600B954 RID: 47444 RVA: 0x0036BBEE File Offset: 0x00369DEE
	protected virtual void OnAddEvents()
	{
		this.AssistantAddEvents();
	}

	// Token: 0x0600B955 RID: 47445 RVA: 0x0036BBF6 File Offset: 0x00369DF6
	protected virtual void OnRemoveEvents()
	{
		this.AssistantRemoveEvents();
	}

	// Token: 0x0600B956 RID: 47446 RVA: 0x0036BBFE File Offset: 0x00369DFE
	private void InitAssistants()
	{
		this.Assistants = new Dictionary<int, ControllerAssistantBase>();
		this.RegisterAssistant();
	}

	// Token: 0x0600B957 RID: 47447 RVA: 0x0036BC11 File Offset: 0x00369E11
	protected virtual void RegisterAssistant()
	{
	}

	// Token: 0x0600B958 RID: 47448 RVA: 0x0036BC14 File Offset: 0x00369E14
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

	// Token: 0x0600B959 RID: 47449 RVA: 0x0036BC84 File Offset: 0x00369E84
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

	// Token: 0x0600B95A RID: 47450 RVA: 0x0036BCE4 File Offset: 0x00369EE4
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

	// Token: 0x0600B95B RID: 47451 RVA: 0x0036BD44 File Offset: 0x00369F44
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

	// Token: 0x0600B95C RID: 47452 RVA: 0x0036BDA4 File Offset: 0x00369FA4
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

	// Token: 0x0600B95D RID: 47453 RVA: 0x0036BE04 File Offset: 0x0036A004
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

	// Token: 0x04006A88 RID: 27272
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<int, ControllerAssistantBase> Assistants;
}
