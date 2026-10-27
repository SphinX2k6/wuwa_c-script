using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;

// Token: 0x020025A8 RID: 9640
[NullableContext(2)]
[Nullable(0)]
public class PhotoCameraSnapshot
{
	// Token: 0x0601384B RID: 79947 RVA: 0x004E0794 File Offset: 0x004DE994
	[NullableContext(1)]
	public static PhotoCameraSnapshot Create(int modeId, EPhotoSnapshotParts parts)
	{
		return new PhotoCameraSnapshot
		{
			ModeId = modeId,
			Lens = (parts.HasFlag(EPhotoSnapshotParts.Lens) ? new PhotoLensPart() : null),
			Options = (parts.HasFlag(EPhotoSnapshotParts.Options) ? new PhotoOptionPart() : null),
			Template = (parts.HasFlag(EPhotoSnapshotParts.Template) ? new PhotoTemplatePart() : null)
		};
	}

	// Token: 0x0601384C RID: 79948 RVA: 0x004E0810 File Offset: 0x004DEA10
	public void Capture()
	{
		PhotoLensPart lens = this.Lens;
		if (lens != null)
		{
			lens.Capture();
		}
		PhotoOptionPart options = this.Options;
		if (options != null)
		{
			options.Capture();
		}
		PhotoTemplatePart template = this.Template;
		if (template == null)
		{
			return;
		}
		template.Capture();
	}

	// Token: 0x0601384D RID: 79949 RVA: 0x004E0844 File Offset: 0x004DEA44
	public void Apply()
	{
		PhotoTemplatePart template = this.Template;
		if (template == null)
		{
			return;
		}
		template.Apply();
	}

	// Token: 0x0601384E RID: 79950 RVA: 0x004E0856 File Offset: 0x004DEA56
	public PhotoCameraLensState GetPendingLens()
	{
		PhotoLensPart lens = this.Lens;
		if (lens == null)
		{
			return null;
		}
		return lens.ToLensState();
	}

	// Token: 0x0400935B RID: 37723
	public int ModeId;

	// Token: 0x0400935C RID: 37724
	public PhotoLensPart Lens;

	// Token: 0x0400935D RID: 37725
	public PhotoOptionPart Options;

	// Token: 0x0400935E RID: 37726
	public PhotoTemplatePart Template;
}
