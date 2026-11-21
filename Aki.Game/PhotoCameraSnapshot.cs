using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;

// Token: 0x02001A93 RID: 6803
[NullableContext(2)]
[Nullable(0)]
public class PhotoCameraSnapshot
{
	// Token: 0x06010D2D RID: 68909 RVA: 0x004EF2C8 File Offset: 0x004ED4C8
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

	// Token: 0x06010D2E RID: 68910 RVA: 0x004EF344 File Offset: 0x004ED544
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

	// Token: 0x06010D2F RID: 68911 RVA: 0x004EF378 File Offset: 0x004ED578
	public void Apply()
	{
		PhotoTemplatePart template = this.Template;
		if (template == null)
		{
			return;
		}
		template.Apply();
	}

	// Token: 0x06010D30 RID: 68912 RVA: 0x004EF38A File Offset: 0x004ED58A
	public PhotoCameraLensState GetPendingLens()
	{
		PhotoLensPart lens = this.Lens;
		if (lens == null)
		{
			return null;
		}
		return lens.ToLensState();
	}

	// Token: 0x040094B3 RID: 38067
	public int ModeId;

	// Token: 0x040094B4 RID: 38068
	public PhotoLensPart Lens;

	// Token: 0x040094B5 RID: 38069
	public PhotoOptionPart Options;

	// Token: 0x040094B6 RID: 38070
	public PhotoTemplatePart Template;
}
