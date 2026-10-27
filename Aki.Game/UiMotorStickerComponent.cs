using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002CA7 RID: 11431
[NullableContext(2)]
[Nullable(0)]
public class UiMotorStickerComponent : UiModelComponentBase
{
	// Token: 0x06017E3D RID: 97853 RVA: 0x00612B85 File Offset: 0x00610D85
	protected override void OnInit()
	{
		this.LoadComponent = base.Owner.CheckGetComponent<UiModelLoadComponent>();
		this.RenderingMaterialComponent = base.Owner.CheckGetComponent<UiModelRenderingMaterialComponent>();
	}

	// Token: 0x06017E3E RID: 97854 RVA: 0x00612BAC File Offset: 0x00610DAC
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

	// Token: 0x06017E3F RID: 97855 RVA: 0x00612BEC File Offset: 0x00610DEC
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

	// Token: 0x06017E40 RID: 97856 RVA: 0x00612C78 File Offset: 0x00610E78
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

	// Token: 0x0400B21F RID: 45599
	[Nullable(1)]
	private readonly Dictionary<int, int> MotorStickerMaterialIdMap = new Dictionary<int, int>();

	// Token: 0x0400B220 RID: 45600
	private UiModelLoadComponent LoadComponent;

	// Token: 0x0400B221 RID: 45601
	private UiModelRenderingMaterialComponent RenderingMaterialComponent;
}
