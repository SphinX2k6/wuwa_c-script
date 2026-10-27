using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030E1 RID: 12513
[NullableContext(1)]
[Nullable(0)]
public class MeshComponentUtils
{
	// Token: 0x0601ACC1 RID: 109761 RVA: 0x0073AE7C File Offset: 0x0073907C
	public static void RelativeAttachComponent(USceneComponent child, USceneComponent parent, string socketName = "")
	{
		child.K2_AttachToComponent(parent, new FName(socketName), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, true, true);
	}

	// Token: 0x0601ACC2 RID: 109762 RVA: 0x0073AE91 File Offset: 0x00739091
	public static bool RelativeAttachComponentOnSafe(USceneComponent child, USceneComponent parent, string socketName = "")
	{
		if (parent == child.GetAttachParent())
		{
			return false;
		}
		MeshComponentUtils.RelativeAttachComponent(child, parent, socketName);
		return true;
	}

	// Token: 0x0601ACC3 RID: 109763 RVA: 0x0073AEA8 File Offset: 0x007390A8
	public static void HideBone(USkeletalMeshComponent meshComp, string boneName, bool hide)
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName(boneName);
		if (FNameUtil.IsEmpty(new FName?(meshComp.GetParentBone(dynamicFName ?? FName.NAME_None))))
		{
			meshComp.SetHiddenInGame(hide, false);
			return;
		}
		if (meshComp.IsBoneHiddenByName(dynamicFName ?? FName.NAME_None) == hide)
		{
			return;
		}
		if (hide)
		{
			meshComp.HideBoneByName(dynamicFName ?? FName.NAME_None, EPhysBodyOp.PBO_None);
			return;
		}
		meshComp.UnHideBoneByName(dynamicFName ?? FName.NAME_None);
	}
}
