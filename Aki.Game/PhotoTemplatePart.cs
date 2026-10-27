using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;

// Token: 0x020025AC RID: 9644
public class PhotoTemplatePart : IPhotoSnapshotPart
{
	// Token: 0x1700191A RID: 6426
	// (get) Token: 0x06013865 RID: 79973 RVA: 0x004E0B4A File Offset: 0x004DED4A
	public bool HasDefaultState
	{
		get
		{
			return this.DefaultLens != null;
		}
	}

	// Token: 0x06013866 RID: 79974 RVA: 0x004E0B58 File Offset: 0x004DED58
	public void CaptureDefaultState()
	{
		PhotoCameraLogicComponent photoCameraComponent = PhotographController.Instance.GetPhotoCameraComponent<PhotoCameraLogicComponent>(EPhotoCameraComponent.Logic);
		if (photoCameraComponent == null)
		{
			return;
		}
		this.DefaultLens = photoCameraComponent.GetLensState();
		PhotographController.Instance.CaptureDepthOfField(this.DefaultDofMap);
	}

	// Token: 0x06013867 RID: 79975 RVA: 0x004E0B91 File Offset: 0x004DED91
	public void ClearDefaultState()
	{
		this.DefaultLens = null;
		this.DefaultDofMap.Clear();
	}

	// Token: 0x06013868 RID: 79976 RVA: 0x004E0BA5 File Offset: 0x004DEDA5
	public void Capture()
	{
	}

	// Token: 0x06013869 RID: 79977 RVA: 0x004E0BA7 File Offset: 0x004DEDA7
	public void Apply()
	{
	}

	// Token: 0x04009369 RID: 37737
	public int TemplateId;

	// Token: 0x0400936A RID: 37738
	[Nullable(1)]
	public string TemplateDaPath = "";

	// Token: 0x0400936B RID: 37739
	[Nullable(2)]
	public PhotoCameraLensState DefaultLens;

	// Token: 0x0400936C RID: 37740
	[Nullable(1)]
	public readonly Dictionary<EPhotoSetupValueType, float> DefaultDofMap = new Dictionary<EPhotoSetupValueType, float>();
}
