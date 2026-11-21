using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.Swing;
using UnrealEngine;

// Token: 0x0200255E RID: 9566
[NullableContext(1)]
[Nullable(0)]
public class SwingConfig
{
	// Token: 0x06017A14 RID: 96788 RVA: 0x006FB580 File Offset: 0x006F9780
	[NullableContext(2)]
	public bool Init(BP_CharacterSwingConfig_C asset = null)
	{
		this.IsRole = false;
		if (asset != null)
		{
			this.SitOnModelBufferTime = asset.SitOnModelBufferTime;
			this.StandUpModelBufferTime = asset.StandUpModelBufferTime;
			this.StandUpMoveAwayDist = (float)asset.StandUpMoveAwayDist;
			this.ExitImmediately = asset.ExitImmediately;
			this.AttachSocket = asset.AttachSocket;
			this.ReferenceActor = asset.ReferenceActor;
			this.AttachRotator.Set(asset.AttachRotator.Y, asset.AttachRotator.Z, asset.AttachRotator.X);
			this.AttachLocation.Set((double)asset.AttachLocation.X, (double)asset.AttachLocation.Y, (double)asset.AttachLocation.Z);
			this.AnimMontagePath = asset.SwingAnimation.ToAssetPathName();
			return this.AnimMontagePath.Length >= 1;
		}
		return false;
	}

	// Token: 0x06017A15 RID: 96789 RVA: 0x006FB664 File Offset: 0x006F9864
	[NullableContext(2)]
	public bool InitRole(int roleId, BP_RoleSwingConfig_C asset = null)
	{
		this.IsRole = true;
		if (asset == null)
		{
			return false;
		}
		this.SitOnModelBufferTime = asset.SitOnModelBufferTime;
		this.StandUpModelBufferTime = asset.StandUpModelBufferTime;
		this.StandUpMoveAwayDist = (float)asset.StandUpMoveAwayDist;
		this.ExitImmediately = asset.ExitImmediately;
		this.AttachSocket = asset.AttachSocket;
		this.ReferenceActor = asset.ReferenceActor;
		this.AttachRotator.Set(asset.AttachRotator.Y, asset.AttachRotator.Z, asset.AttachRotator.X);
		this.AttachLocation.Set((double)asset.AttachLocation.X, (double)asset.AttachLocation.Y, (double)asset.AttachLocation.Z);
		string text = this.FindRoleMontage(roleId, asset.SwingAnimation);
		if (text == null)
		{
			return false;
		}
		this.AnimMontagePath = text;
		return true;
	}

	// Token: 0x06017A16 RID: 96790 RVA: 0x006FB740 File Offset: 0x006F9940
	[NullableContext(2)]
	private string FindRoleMontage(int roleId, [Nullable(new byte[]
	{
		2,
		1
	})] TArray<SRoleSwingConfig> arr)
	{
		if (arr != null)
		{
			for (int i = 0; i < arr.Num(); i++)
			{
				if (arr.Get(i).RoleId.Contains(roleId))
				{
					return arr.Get(i).SwingMontage.ToAssetPathName();
				}
			}
		}
		return null;
	}

	// Token: 0x0400C92B RID: 51499
	public int SitOnModelBufferTime = 400;

	// Token: 0x0400C92C RID: 51500
	public int StandUpModelBufferTime = 500;

	// Token: 0x0400C92D RID: 51501
	public float StandUpMoveAwayDist = 10f;

	// Token: 0x0400C92E RID: 51502
	public string AttachSocket = "Bone_Root";

	// Token: 0x0400C92F RID: 51503
	public Rotator AttachRotator = Rotator.Create();

	// Token: 0x0400C930 RID: 51504
	public Vector AttachLocation = Vector.Create();

	// Token: 0x0400C931 RID: 51505
	public string ReferenceActor = "SkeletalMesh";

	// Token: 0x0400C932 RID: 51506
	public bool ExitImmediately;

	// Token: 0x0400C933 RID: 51507
	public string AnimMontagePath = "";

	// Token: 0x0400C934 RID: 51508
	public bool IsRole;
}
