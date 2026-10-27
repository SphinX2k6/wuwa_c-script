using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002C94 RID: 11412
[NullableContext(1)]
[Nullable(0)]
public class UiModelRenderingMaterialComponent : UiModelComponentBase
{
	// Token: 0x17002032 RID: 8242
	// (get) Token: 0x06017DA9 RID: 97705 RVA: 0x00610C1C File Offset: 0x0060EE1C
	private int MaterialId
	{
		get
		{
			int num = this.StartIndex + 1;
			this.StartIndex = num;
			return num;
		}
	}

	// Token: 0x06017DAA RID: 97706 RVA: 0x00610C3A File Offset: 0x0060EE3A
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
	}

	// Token: 0x06017DAB RID: 97707 RVA: 0x00610C5E File Offset: 0x0060EE5E
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelLoadComplete, new Action(this.OnModelLoadComplete));
	}

	// Token: 0x06017DAC RID: 97708 RVA: 0x00610C84 File Offset: 0x0060EE84
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

	// Token: 0x06017DAD RID: 97709 RVA: 0x00610D30 File Offset: 0x0060EF30
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

	// Token: 0x06017DAE RID: 97710 RVA: 0x00610D80 File Offset: 0x0060EF80
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

	// Token: 0x06017DAF RID: 97711 RVA: 0x00610DD0 File Offset: 0x0060EFD0
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

	// Token: 0x06017DB0 RID: 97712 RVA: 0x00610E20 File Offset: 0x0060F020
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

	// Token: 0x06017DB1 RID: 97713 RVA: 0x00610E84 File Offset: 0x0060F084
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

	// Token: 0x06017DB2 RID: 97714 RVA: 0x00610EE0 File Offset: 0x0060F0E0
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

	// Token: 0x06017DB3 RID: 97715 RVA: 0x00610F58 File Offset: 0x0060F158
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

	// Token: 0x06017DB4 RID: 97716 RVA: 0x00611130 File Offset: 0x0060F330
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

	// Token: 0x06017DB5 RID: 97717 RVA: 0x006111DC File Offset: 0x0060F3DC
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

	// Token: 0x06017DB6 RID: 97718 RVA: 0x00611270 File Offset: 0x0060F470
	public void OnModelLoadComplete()
	{
		this.Execute();
	}

	// Token: 0x0400B1D5 RID: 45525
	[Nullable(2)]
	public UiModelActorComponent ActorComponent;

	// Token: 0x0400B1D6 RID: 45526
	[Nullable(2)]
	public UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B1D7 RID: 45527
	private readonly Dictionary<int, IMaterialHandle> MaterialMap = new Dictionary<int, IMaterialHandle>();

	// Token: 0x0400B1D8 RID: 45528
	private int StartIndex;

	// Token: 0x0400B1D9 RID: 45529
	private readonly HashSet<int> MaterialToAdd = new HashSet<int>();
}
