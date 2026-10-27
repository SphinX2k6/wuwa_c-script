using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.Swing;
using UnrealEngine;

// Token: 0x02003008 RID: 12296
[NullableContext(1)]
[Nullable(0)]
public class SwingConfig
{
	// Token: 0x0601A0CE RID: 106702 RVA: 0x006D3588 File Offset: 0x006D1788
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

	// Token: 0x0601A0CF RID: 106703 RVA: 0x006D366C File Offset: 0x006D186C
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

	// Token: 0x0601A0D0 RID: 106704 RVA: 0x006D3748 File Offset: 0x006D1948
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

	// Token: 0x0400C55E RID: 50526
	public int SitOnModelBufferTime = 400;

	// Token: 0x0400C55F RID: 50527
	public int StandUpModelBufferTime = 500;

	// Token: 0x0400C560 RID: 50528
	public float StandUpMoveAwayDist = 10f;

	// Token: 0x0400C561 RID: 50529
	public string AttachSocket = "Bone_Root";

	// Token: 0x0400C562 RID: 50530
	public Rotator AttachRotator = Rotator.Create();

	// Token: 0x0400C563 RID: 50531
	public Vector AttachLocation = Vector.Create();

	// Token: 0x0400C564 RID: 50532
	public string ReferenceActor = "SkeletalMesh";

	// Token: 0x0400C565 RID: 50533
	public bool ExitImmediately;

	// Token: 0x0400C566 RID: 50534
	public string AnimMontagePath = "";

	// Token: 0x0400C567 RID: 50535
	public bool IsRole;
}
