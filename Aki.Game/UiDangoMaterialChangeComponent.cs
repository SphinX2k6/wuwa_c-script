using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002C9C RID: 11420
[NullableContext(1)]
[Nullable(0)]
public class UiDangoMaterialChangeComponent : UiModelComponentBase
{
	// Token: 0x06017DDD RID: 97757 RVA: 0x00611836 File Offset: 0x0060FA36
	protected override void OnInit()
	{
		this.UiModelActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		ResourceSystem.Instance.LoadAsync<UMaterialInstance>("/Game/Aki/Character/NPC/Tuanzi/HYtuanzi_jinxi/Model/MI_Tuanzi_Stroke_90001.MI_Tuanzi_Stroke_90001", delegate([Nullable(2)] UMaterialInstance materialInstance, string _)
		{
			if (materialInstance != null && materialInstance.IsValid())
			{
				this.ReplaceMaterial = materialInstance;
			}
		}, 100, "Ui.UiSceneModel");
	}

	// Token: 0x06017DDE RID: 97758 RVA: 0x0061186C File Offset: 0x0060FA6C
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017DDF RID: 97759 RVA: 0x00611890 File Offset: 0x0060FA90
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017DE0 RID: 97760 RVA: 0x006118B4 File Offset: 0x0060FAB4
	private void OnModelLoadComplete()
	{
		this.InitOriginalMaterialMap();
	}

	// Token: 0x06017DE1 RID: 97761 RVA: 0x006118BC File Offset: 0x0060FABC
	private void InitOriginalMaterialMap()
	{
		this.OriginalMaterialMap.Clear();
		USkeletalMeshComponent mainMeshComponent = this.UiModelActorComponent.MainMeshComponent;
		foreach (FName materialSlotName in this.SlotNameList)
		{
			int materialIndex = mainMeshComponent.GetMaterialIndex(materialSlotName);
			if (materialIndex >= 0)
			{
				UMaterialInterface material = mainMeshComponent.GetMaterial(materialIndex);
				if (material != null)
				{
					this.OriginalMaterialMap[materialIndex] = material;
				}
			}
		}
	}

	// Token: 0x06017DE2 RID: 97762 RVA: 0x00611928 File Offset: 0x0060FB28
	public void ReplaceSelectMaterial(bool isReplace)
	{
		CharRenderingComponent charRenderingComponent = this.UiModelActorComponent.CharRenderingComponent;
		if (isReplace)
		{
			charRenderingComponent.SetMaterialReplaceV2(this.ReplaceMaterial, EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.Outline, EKuroCharMeshPart.ECharacterMeshPart_Max);
			return;
		}
		charRenderingComponent.RemoveExternalMaterialReplaceV2(EKuroCharBodySpecifiedType.All, EKuroCharSlotSpecifiedType.Outline, EKuroCharMeshPart.ECharacterMeshPart_Max);
	}

	// Token: 0x0400B1EC RID: 45548
	private const string SELECT_MATERIAL_PATH = "/Game/Aki/Character/NPC/Tuanzi/HYtuanzi_jinxi/Model/MI_Tuanzi_Stroke_90001.MI_Tuanzi_Stroke_90001";

	// Token: 0x0400B1ED RID: 45549
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B1EE RID: 45550
	private UMaterialInstance ReplaceMaterial;

	// Token: 0x0400B1EF RID: 45551
	private readonly Dictionary<int, UMaterialInterface> OriginalMaterialMap = new Dictionary<int, UMaterialInterface>();

	// Token: 0x0400B1F0 RID: 45552
	private readonly FName[] SlotNameList = new FName[]
	{
		new FName("OL_Hair"),
		new FName("OL_Face"),
		new FName("OL_Item")
	};
}
