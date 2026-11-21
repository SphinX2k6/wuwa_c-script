using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;

// Token: 0x02001A97 RID: 6807
public class PhotoTemplatePart : IPhotoSnapshotPart
{
	// Token: 0x17001954 RID: 6484
	// (get) Token: 0x06010D47 RID: 68935 RVA: 0x004EF67E File Offset: 0x004ED87E
	public bool HasDefaultState
	{
		get
		{
			return this.DefaultLens != null;
		}
	}

	// Token: 0x06010D48 RID: 68936 RVA: 0x004EF68C File Offset: 0x004ED88C
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

	// Token: 0x06010D49 RID: 68937 RVA: 0x004EF6C5 File Offset: 0x004ED8C5
	public void ClearDefaultState()
	{
		this.DefaultLens = null;
		this.DefaultDofMap.Clear();
	}

	// Token: 0x06010D4A RID: 68938 RVA: 0x004EF6D9 File Offset: 0x004ED8D9
	public void Capture()
	{
	}

	// Token: 0x06010D4B RID: 68939 RVA: 0x004EF6DB File Offset: 0x004ED8DB
	public void Apply()
	{
	}

	// Token: 0x040094C1 RID: 38081
	public int TemplateId;

	// Token: 0x040094C2 RID: 38082
	[Nullable(1)]
	public string TemplateDaPath = "";

	// Token: 0x040094C3 RID: 38083
	[Nullable(2)]
	public PhotoCameraLensState DefaultLens;

	// Token: 0x040094C4 RID: 38084
	[Nullable(1)]
	public readonly Dictionary<EPhotoSetupValueType, float> DefaultDofMap = new Dictionary<EPhotoSetupValueType, float>();
}
