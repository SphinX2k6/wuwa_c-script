using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002CB8 RID: 11448
[NullableContext(2)]
[Nullable(0)]
public class UiRoleStateMachineComponent : UiModelComponentBase
{
	// Token: 0x06017ED6 RID: 98006 RVA: 0x00615B18 File Offset: 0x00613D18
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x06017ED7 RID: 98007 RVA: 0x00615B3C File Offset: 0x00613D3C
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
	}

	// Token: 0x06017ED8 RID: 98008 RVA: 0x00615B60 File Offset: 0x00613D60
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
	}

	// Token: 0x06017ED9 RID: 98009 RVA: 0x00615B84 File Offset: 0x00613D84
	public void SetState(EPerformanceRoleState roleState, bool reLoop = false, bool reLoopFromLoopToStart = false, bool waitLaseStateEnd = false)
	{
		this.RoleState = roleState;
		this.ReLoop = reLoop;
		this.ReLoopFromLoopToStart = reLoopFromLoopToStart;
		this.WaitLaseStateEnd = waitLaseStateEnd;
		this.Execute();
	}

	// Token: 0x06017EDA RID: 98010 RVA: 0x00615BA9 File Offset: 0x00613DA9
	public void SetInstantAttributeBlend(bool instantAttributeBlend)
	{
		this.InstantAttributeBlend = instantAttributeBlend;
		this.ApplyInstantAttributeBlend();
	}

	// Token: 0x06017EDB RID: 98011 RVA: 0x00615BB8 File Offset: 0x00613DB8
	private void Execute()
	{
		if (this.ModelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			return;
		}
		USkeletalMeshComponent mainMeshComponent = this.ActorComponent.MainMeshComponent;
		ABP_PerformanceRole_C animInstanceFromSkeletalMesh = this.ActorComponent.GetAnimInstanceFromSkeletalMesh(mainMeshComponent);
		if (animInstanceFromSkeletalMesh == null)
		{
			return;
		}
		animInstanceFromSkeletalMesh.SetState(this.RoleState, this.ReLoop, this.ReLoopFromLoopToStart, this.WaitLaseStateEnd);
	}

	// Token: 0x06017EDC RID: 98012 RVA: 0x00615C0E File Offset: 0x00613E0E
	public void OnRoleMeshLoadComplete()
	{
		this.SetDefaultPerformDelay();
		this.ApplyInstantAttributeBlend();
		this.Execute();
	}

	// Token: 0x06017EDD RID: 98013 RVA: 0x00615C24 File Offset: 0x00613E24
	private void ApplyInstantAttributeBlend()
	{
		if (this.ModelDataComponent.GetModelLoadState() != EUiModelLoadState.LoadComplete)
		{
			return;
		}
		USkeletalMeshComponent mainMeshComponent = this.ActorComponent.MainMeshComponent;
		ABP_PerformanceRole_C animInstanceFromSkeletalMesh = this.ActorComponent.GetAnimInstanceFromSkeletalMesh(mainMeshComponent);
		if (animInstanceFromSkeletalMesh == null)
		{
			return;
		}
		animInstanceFromSkeletalMesh.SetInstantAttributeBlend(this.InstantAttributeBlend);
	}

	// Token: 0x06017EDE RID: 98014 RVA: 0x00615C68 File Offset: 0x00613E68
	private void SetDefaultPerformDelay()
	{
		USkeletalMeshComponent mainMeshComponent = this.ActorComponent.MainMeshComponent;
		ABP_PerformanceRole_C animInstanceFromSkeletalMesh = this.ActorComponent.GetAnimInstanceFromSkeletalMesh(mainMeshComponent);
		float? rolePerformanceDelayTime = RoleConfig.Instance.GetRolePerformanceDelayTime();
		if (animInstanceFromSkeletalMesh == null)
		{
			return;
		}
		animInstanceFromSkeletalMesh.SetPerformDelay(rolePerformanceDelayTime.Value);
	}

	// Token: 0x0400B25B RID: 45659
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B25C RID: 45660
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B25D RID: 45661
	private EPerformanceRoleState RoleState;

	// Token: 0x0400B25E RID: 45662
	private bool ReLoop;

	// Token: 0x0400B25F RID: 45663
	private bool WaitLaseStateEnd;

	// Token: 0x0400B260 RID: 45664
	private bool ReLoopFromLoopToStart;

	// Token: 0x0400B261 RID: 45665
	private bool InstantAttributeBlend;
}
