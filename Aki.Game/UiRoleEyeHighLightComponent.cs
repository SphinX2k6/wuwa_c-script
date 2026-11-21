using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002206 RID: 8710
public class UiRoleEyeHighLightComponent : UiModelComponentBase
{
	// Token: 0x060156D2 RID: 87762 RVA: 0x00638EA7 File Offset: 0x006370A7
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x060156D3 RID: 87763 RVA: 0x00638EBA File Offset: 0x006370BA
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
	}

	// Token: 0x060156D4 RID: 87764 RVA: 0x00638EDE File Offset: 0x006370DE
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnRoleMeshLoadComplete));
	}

	// Token: 0x060156D5 RID: 87765 RVA: 0x00638F02 File Offset: 0x00637102
	public void OnRoleMeshLoadComplete()
	{
		this.DisableEyeHighLight();
	}

	// Token: 0x060156D6 RID: 87766 RVA: 0x00638F0C File Offset: 0x0063710C
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

	// Token: 0x060156D7 RID: 87767 RVA: 0x00638F64 File Offset: 0x00637164
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

	// Token: 0x0400B595 RID: 46485
	[Nullable(2)]
	private UiModelActorComponent ActorComponent;
}
