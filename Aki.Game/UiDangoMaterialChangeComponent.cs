using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020021F5 RID: 8693
[NullableContext(1)]
[Nullable(0)]
public class UiDangoMaterialChangeComponent : UiModelComponentBase
{
	// Token: 0x06015651 RID: 87633 RVA: 0x006373BA File Offset: 0x006355BA
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

	// Token: 0x06015652 RID: 87634 RVA: 0x006373F0 File Offset: 0x006355F0
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06015653 RID: 87635 RVA: 0x00637414 File Offset: 0x00635614
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06015654 RID: 87636 RVA: 0x00637438 File Offset: 0x00635638
	private void OnModelLoadComplete()
	{
		this.InitOriginalMaterialMap();
	}

	// Token: 0x06015655 RID: 87637 RVA: 0x00637440 File Offset: 0x00635640
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

	// Token: 0x06015656 RID: 87638 RVA: 0x006374AC File Offset: 0x006356AC
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

	// Token: 0x0400B557 RID: 46423
	private const string SELECT_MATERIAL_PATH = "/Game/Aki/Character/NPC/Tuanzi/HYtuanzi_jinxi/Model/MI_Tuanzi_Stroke_90001.MI_Tuanzi_Stroke_90001";

	// Token: 0x0400B558 RID: 46424
	protected UiModelActorComponent UiModelActorComponent;

	// Token: 0x0400B559 RID: 46425
	private UMaterialInstance ReplaceMaterial;

	// Token: 0x0400B55A RID: 46426
	private readonly Dictionary<int, UMaterialInterface> OriginalMaterialMap = new Dictionary<int, UMaterialInterface>();

	// Token: 0x0400B55B RID: 46427
	private readonly FName[] SlotNameList = new FName[]
	{
		new FName("OL_Hair"),
		new FName("OL_Face"),
		new FName("OL_Item")
	};
}
