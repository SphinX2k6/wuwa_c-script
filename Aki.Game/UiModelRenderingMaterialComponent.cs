using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020021ED RID: 8685
[NullableContext(1)]
[Nullable(0)]
public class UiModelRenderingMaterialComponent : UiModelComponentBase
{
	// Token: 0x17002083 RID: 8323
	// (get) Token: 0x0601561D RID: 87581 RVA: 0x006367BC File Offset: 0x006349BC
	private int MaterialId
	{
		get
		{
			int num = this.StartIndex + 1;
			this.StartIndex = num;
			return num;
		}
	}

	// Token: 0x0601561E RID: 87582 RVA: 0x006367DA File Offset: 0x006349DA
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x0601561F RID: 87583 RVA: 0x006367FE File Offset: 0x006349FE
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06015620 RID: 87584 RVA: 0x00636824 File Offset: 0x00634A24
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
		foreach (IMaterialHandle materialHandle in this.MaterialMap.Values)
		{
			int handleId = materialHandle.HandleId;
			if (handleId != 0 && handleId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(handleId);
			}
		}
		this.MaterialMap.Clear();
		CharRenderingComponent charRenderingComponent = this.ActorComponent.CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return;
		}
		charRenderingComponent.ResetAllRenderingState();
	}

	// Token: 0x06015621 RID: 87585 RVA: 0x006368D0 File Offset: 0x00634AD0
	public int SetRenderingMaterial(string effectId)
	{
		int materialId = this.MaterialId;
		MaterialHandle value = new MaterialHandle
		{
			EffectId = effectId,
			HandleId = -1,
			RenderingId = -1
		};
		this.MaterialMap[materialId] = value;
		this.MaterialToAdd.Add(materialId);
		this.Execute();
		return materialId;
	}

	// Token: 0x06015622 RID: 87586 RVA: 0x00636920 File Offset: 0x00634B20
	public int AddRenderingMaterialByPath(string path)
	{
		int materialId = this.MaterialId;
		MaterialHandle value = new MaterialHandle
		{
			EffectPath = path,
			HandleId = -1,
			RenderingId = -1
		};
		this.MaterialMap[materialId] = value;
		this.MaterialToAdd.Add(materialId);
		this.Execute();
		return materialId;
	}

	// Token: 0x06015623 RID: 87587 RVA: 0x00636970 File Offset: 0x00634B70
	public int AddRenderingMaterialByData(PD_CharacterControllerData_C data)
	{
		int materialId = this.MaterialId;
		MaterialHandle value = new MaterialHandle
		{
			MaterialAssetData = data,
			HandleId = -1,
			RenderingId = -1
		};
		this.MaterialMap[materialId] = value;
		this.MaterialToAdd.Add(materialId);
		this.Execute();
		return materialId;
	}

	// Token: 0x06015624 RID: 87588 RVA: 0x006369C0 File Offset: 0x00634BC0
	public int AddRenderingMaterialWithAnimObject(PD_CharacterControllerData_C data, USkeletalMeshComponent meshComp)
	{
		int materialId = this.MaterialId;
		MaterialHandle value = new MaterialHandle
		{
			MaterialAssetData = data,
			HandleId = -1,
			RenderingId = -1,
			WithAnimObject = new bool?(true),
			AnimMeshComp = meshComp
		};
		this.MaterialMap[materialId] = value;
		this.MaterialToAdd.Add(materialId);
		this.Execute();
		return materialId;
	}

	// Token: 0x06015625 RID: 87589 RVA: 0x00636A24 File Offset: 0x00634C24
	public int AddRenderingMaterialGroup(PD_CharacterControllerDataGroup_C data)
	{
		int materialId = this.MaterialId;
		MaterialHandle value = new MaterialHandle
		{
			MaterialAssetData = data,
			HandleId = -1,
			RenderingId = -1,
			IsGroup = new bool?(true)
		};
		this.MaterialMap[materialId] = value;
		this.MaterialToAdd.Add(materialId);
		this.Execute();
		return materialId;
	}

	// Token: 0x06015626 RID: 87590 RVA: 0x00636A80 File Offset: 0x00634C80
	private void Execute()
	{
		UiModelDataComponent uiModelDataComponent = this.UiModelDataComponent;
		if (uiModelDataComponent != null && uiModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete)
		{
			foreach (int materialId in this.MaterialToAdd)
			{
				this.AddRenderingMaterialById(materialId);
			}
			this.MaterialToAdd.Clear();
		}
	}

	// Token: 0x06015627 RID: 87591 RVA: 0x00636AF8 File Offset: 0x00634CF8
	private void AddRenderingMaterialById(int materialId)
	{
		UiModelRenderingMaterialComponent.<>c__DisplayClass16_0 CS$<>8__locals1 = new UiModelRenderingMaterialComponent.<>c__DisplayClass16_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.materialId = materialId;
		CS$<>8__locals1.materialHandle = this.MaterialMap[CS$<>8__locals1.materialId];
		CS$<>8__locals1.charRenderingComp = this.ActorComponent.CharRenderingComponent;
		if (!string.IsNullOrEmpty(CS$<>8__locals1.materialHandle.EffectId) || !string.IsNullOrEmpty(CS$<>8__locals1.materialHandle.EffectPath))
		{
			string text = (!string.IsNullOrEmpty(CS$<>8__locals1.materialHandle.EffectId)) ? EffectUtil.GetEffectPath(CS$<>8__locals1.materialHandle.EffectId) : CS$<>8__locals1.materialHandle.EffectPath;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			CS$<>8__locals1.materialHandle.HandleId = ResourceSystem.Instance.LoadAsync<UObject>(text, new Action<UObject, string>(CS$<>8__locals1.<AddRenderingMaterialById>g__CallBack|0), 100, "Ui.UiSceneModel");
		}
		if (CS$<>8__locals1.materialHandle.MaterialAssetData != null)
		{
			if (CS$<>8__locals1.materialHandle.WithAnimObject.GetValueOrDefault())
			{
				CS$<>8__locals1.materialHandle.RenderingId = (int)CS$<>8__locals1.charRenderingComp.AddMaterialControllerDataWithAnimObject(CS$<>8__locals1.materialHandle.MaterialAssetData, CS$<>8__locals1.materialHandle.AnimMeshComp, null);
				base.Owner.OnRenderingMaterialAdd(CS$<>8__locals1.materialId, CS$<>8__locals1.materialHandle.MaterialAssetData, false, true);
				return;
			}
			if (CS$<>8__locals1.materialHandle.IsGroup.GetValueOrDefault())
			{
				CS$<>8__locals1.materialHandle.RenderingId = CS$<>8__locals1.charRenderingComp.AddMaterialControllerDataGroup(CS$<>8__locals1.materialHandle.MaterialAssetData);
				base.Owner.OnRenderingMaterialAdd(CS$<>8__locals1.materialId, CS$<>8__locals1.materialHandle.MaterialAssetData, true, false);
				return;
			}
			CS$<>8__locals1.materialHandle.RenderingId = CS$<>8__locals1.charRenderingComp.AddMaterialControllerData(CS$<>8__locals1.materialHandle.MaterialAssetData);
			base.Owner.OnRenderingMaterialAdd(CS$<>8__locals1.materialId, CS$<>8__locals1.materialHandle.MaterialAssetData, false, false);
		}
	}

	// Token: 0x06015628 RID: 87592 RVA: 0x00636CD0 File Offset: 0x00634ED0
	public void RemoveRenderingMaterial(int materialId)
	{
		IMaterialHandle materialHandle;
		if (this.MaterialMap.TryGetValue(materialId, out materialHandle))
		{
			bool? isGroup = materialHandle.IsGroup;
			int handleId = materialHandle.HandleId;
			if (handleId != 0 && handleId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(handleId);
			}
			int renderingId = materialHandle.RenderingId;
			if (renderingId != 0 && renderingId != -1)
			{
				if (isGroup.GetValueOrDefault())
				{
					this.ActorComponent.CharRenderingComponent.RemoveMaterialControllerDataGroup(renderingId);
				}
				else
				{
					this.ActorComponent.CharRenderingComponent.RemoveMaterialControllerData(renderingId);
				}
				base.Owner.OnRenderingMaterialRemove(materialId, isGroup.GetValueOrDefault(), false);
			}
			else
			{
				this.MaterialToAdd.Remove(materialId);
			}
			this.MaterialMap.Remove(materialId);
		}
	}

	// Token: 0x06015629 RID: 87593 RVA: 0x00636D7C File Offset: 0x00634F7C
	public void RemoveRenderingMaterialWithEnding(int materialId)
	{
		IMaterialHandle materialHandle;
		if (this.MaterialMap.TryGetValue(materialId, out materialHandle))
		{
			bool? isGroup = materialHandle.IsGroup;
			int handleId = materialHandle.HandleId;
			if (handleId != 0 && handleId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(handleId);
			}
			int renderingId = materialHandle.RenderingId;
			CharRenderingComponent charRenderingComponent = this.ActorComponent.CharRenderingComponent;
			if (renderingId != 0 && renderingId != -1)
			{
				if (isGroup.GetValueOrDefault())
				{
					charRenderingComponent.RemoveMaterialControllerDataGroupWithEnding(renderingId);
				}
				else
				{
					charRenderingComponent.RemoveMaterialControllerDataWithEnding(renderingId);
				}
				base.Owner.OnRenderingMaterialRemove(materialId, isGroup.GetValueOrDefault(), true);
			}
			this.MaterialMap.Remove(materialId);
		}
	}

	// Token: 0x0601562A RID: 87594 RVA: 0x00636E10 File Offset: 0x00635010
	public void OnModelLoadComplete()
	{
		this.Execute();
	}

	// Token: 0x0400B540 RID: 46400
	[Nullable(2)]
	public UiModelActorComponent ActorComponent;

	// Token: 0x0400B541 RID: 46401
	[Nullable(2)]
	public UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B542 RID: 46402
	private readonly Dictionary<int, IMaterialHandle> MaterialMap = new Dictionary<int, IMaterialHandle>();

	// Token: 0x0400B543 RID: 46403
	private int StartIndex;

	// Token: 0x0400B544 RID: 46404
	private readonly HashSet<int> MaterialToAdd = new HashSet<int>();
}
