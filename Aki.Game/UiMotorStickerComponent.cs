using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002200 RID: 8704
[NullableContext(2)]
[Nullable(0)]
public class UiMotorStickerComponent : UiModelComponentBase
{
	// Token: 0x060156B1 RID: 87729 RVA: 0x00638709 File Offset: 0x00636909
	protected override void OnInit()
	{
		this.LoadComponent = base.Owner.CheckGetComponent<UiModelLoadComponent>();
		this.RenderingMaterialComponent = base.Owner.CheckGetComponent<UiModelRenderingMaterialComponent>();
	}

	// Token: 0x060156B2 RID: 87730 RVA: 0x00638730 File Offset: 0x00636930
	public void RemoveStickerMaterial(int stickerPart)
	{
		int materialId;
		if (!this.MotorStickerMaterialIdMap.TryGetValue(stickerPart, out materialId))
		{
			return;
		}
		if (this.RenderingMaterialComponent == null)
		{
			return;
		}
		this.RenderingMaterialComponent.RemoveRenderingMaterial(materialId);
		this.MotorStickerMaterialIdMap.Remove(stickerPart);
	}

	// Token: 0x060156B3 RID: 87731 RVA: 0x00638770 File Offset: 0x00636970
	public void AddStickerMaterial(int stickerId)
	{
		MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(stickerId);
		if (motorStickerConfig == null)
		{
			return;
		}
		PD_CharacterControllerData_C pd_CharacterControllerData_C = this.LoadComponent.GetLoadedResource(motorStickerConfig.Value.MaterialDA) as PD_CharacterControllerData_C;
		if (pd_CharacterControllerData_C == null)
		{
			this.AddStickerMaterialAsync(stickerId);
			return;
		}
		this.RemoveStickerMaterial(motorStickerConfig.Value.PartId);
		int value = this.RenderingMaterialComponent.AddRenderingMaterialByData(pd_CharacterControllerData_C);
		this.MotorStickerMaterialIdMap[motorStickerConfig.Value.PartId] = value;
	}

	// Token: 0x060156B4 RID: 87732 RVA: 0x006387FC File Offset: 0x006369FC
	public UniTask AddStickerMaterialAsync(int stickerId)
	{
		UiMotorStickerComponent.<AddStickerMaterialAsync>d__6 <AddStickerMaterialAsync>d__;
		<AddStickerMaterialAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddStickerMaterialAsync>d__.<>4__this = this;
		<AddStickerMaterialAsync>d__.stickerId = stickerId;
		<AddStickerMaterialAsync>d__.<>1__state = -1;
		<AddStickerMaterialAsync>d__.<>t__builder.Start<UiMotorStickerComponent.<AddStickerMaterialAsync>d__6>(ref <AddStickerMaterialAsync>d__);
		return <AddStickerMaterialAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400B58A RID: 46474
	[Nullable(1)]
	private readonly Dictionary<int, int> MotorStickerMaterialIdMap = new Dictionary<int, int>();

	// Token: 0x0400B58B RID: 46475
	private UiModelLoadComponent LoadComponent;

	// Token: 0x0400B58C RID: 46476
	private UiModelRenderingMaterialComponent RenderingMaterialComponent;
}
