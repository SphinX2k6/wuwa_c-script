using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002CAD RID: 11437
public class UiRoleEyeHighLightComponent : UiModelComponentBase
{
	// Token: 0x06017E5E RID: 97886 RVA: 0x00613323 File Offset: 0x00611523
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x06017E5F RID: 97887 RVA: 0x00613336 File Offset: 0x00611536
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
	}

	// Token: 0x06017E60 RID: 97888 RVA: 0x0061335A File Offset: 0x0061155A
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
	}

	// Token: 0x06017E61 RID: 97889 RVA: 0x0061337E File Offset: 0x0061157E
	public void OnRoleMeshLoadComplete()
	{
		this.DisableEyeHighLight();
	}

	// Token: 0x06017E62 RID: 97890 RVA: 0x00613388 File Offset: 0x00611588
	public void DisableEyeHighLight()
	{
		FName[] slotNameList = new FName[]
		{
			new FName("MI_Eyes"),
			new FName("MI_Eye")
		};
		FName lightDisableSwitch = new FName("LightDisableSwitch");
		USkeletalMeshComponent mainMeshComponent = this.ActorComponent.MainMeshComponent;
		this.DisableEyeHighLightByMeshComp(mainMeshComponent, slotNameList, lightDisableSwitch);
	}

	// Token: 0x06017E63 RID: 97891 RVA: 0x006133E0 File Offset: 0x006115E0
	[NullableContext(1)]
	private void DisableEyeHighLightByMeshComp(USkeletalMeshComponent skeletalMeshComp, FName[] slotNameList, FName lightDisableSwitch)
	{
		foreach (FName materialSlotName in slotNameList)
		{
			int materialIndex = skeletalMeshComp.GetMaterialIndex(materialSlotName);
			if (materialIndex >= 0)
			{
				UMaterialInterface material = skeletalMeshComp.GetMaterial(materialIndex);
				UMaterialInstanceDynamic umaterialInstanceDynamic = skeletalMeshComp.CreateDynamicMaterialInstance(materialIndex, material, default(FName));
				if (umaterialInstanceDynamic != null)
				{
					umaterialInstanceDynamic.SetScalarParameterValue(lightDisableSwitch, 0f);
				}
			}
		}
	}

	// Token: 0x0400B22A RID: 45610
	[Nullable(2)]
	private UiModelActorComponent ActorComponent;
}
