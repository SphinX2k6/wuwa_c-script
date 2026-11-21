using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02002211 RID: 8721
[NullableContext(2)]
[Nullable(0)]
public class UiRoleStateMachineComponent : UiModelComponentBase
{
	// Token: 0x0601574E RID: 87886 RVA: 0x0063B794 File Offset: 0x00639994
	protected override void OnInit()
	{
		this.ModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x0601574F RID: 87887 RVA: 0x0063B7B8 File Offset: 0x006399B8
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
	}

	// Token: 0x06015750 RID: 87888 RVA: 0x0063B7DC File Offset: 0x006399DC
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
	}

	// Token: 0x06015751 RID: 87889 RVA: 0x0063B800 File Offset: 0x00639A00
	public void SetState(EPerformanceRoleState roleState, bool reLoop = false, bool reLoopFromLoopToStart = false, bool waitLaseStateEnd = false)
	{
		this.RoleState = roleState;
		this.ReLoop = reLoop;
		this.ReLoopFromLoopToStart = reLoopFromLoopToStart;
		this.WaitLaseStateEnd = waitLaseStateEnd;
		this.Execute();
	}

	// Token: 0x06015752 RID: 87890 RVA: 0x0063B825 File Offset: 0x00639A25
	public void SetInstantAttributeBlend(bool instantAttributeBlend)
	{
		this.InstantAttributeBlend = instantAttributeBlend;
		this.ApplyInstantAttributeBlend();
	}

	// Token: 0x06015753 RID: 87891 RVA: 0x0063B834 File Offset: 0x00639A34
	public void SetTriggerElementEnd(bool triggerElementEnd)
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
		animInstanceFromSkeletalMesh.TriggerElementEnd(triggerElementEnd);
	}

	// Token: 0x06015754 RID: 87892 RVA: 0x0063B874 File Offset: 0x00639A74
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

	// Token: 0x06015755 RID: 87893 RVA: 0x0063B8CA File Offset: 0x00639ACA
	public void OnRoleMeshLoadComplete()
	{
		this.SetDefaultPerformDelay();
		this.ApplyInstantAttributeBlend();
		this.Execute();
	}

	// Token: 0x06015756 RID: 87894 RVA: 0x0063B8E0 File Offset: 0x00639AE0
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

	// Token: 0x06015757 RID: 87895 RVA: 0x0063B924 File Offset: 0x00639B24
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

	// Token: 0x0400B5C6 RID: 46534
	private UiModelDataComponent ModelDataComponent;

	// Token: 0x0400B5C7 RID: 46535
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B5C8 RID: 46536
	private EPerformanceRoleState RoleState;

	// Token: 0x0400B5C9 RID: 46537
	private bool ReLoop;

	// Token: 0x0400B5CA RID: 46538
	private bool WaitLaseStateEnd;

	// Token: 0x0400B5CB RID: 46539
	private bool ReLoopFromLoopToStart;

	// Token: 0x0400B5CC RID: 46540
	private bool InstantAttributeBlend;
}
