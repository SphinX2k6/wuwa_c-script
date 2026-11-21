using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002639 RID: 9785
[NullableContext(1)]
[Nullable(0)]
public class MeshComponentUtils
{
	// Token: 0x060186DD RID: 100061 RVA: 0x007608B8 File Offset: 0x0075EAB8
	public static void RelativeAttachComponent(USceneComponent child, USceneComponent parent, string socketName = "")
	{
		child.K2_AttachToComponent(parent, new FName(socketName), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, true, true);
	}

	// Token: 0x060186DE RID: 100062 RVA: 0x007608CD File Offset: 0x0075EACD
	public static bool RelativeAttachComponentOnSafe(USceneComponent child, USceneComponent parent, string socketName = "")
	{
		if (parent == child.GetAttachParent())
		{
			return false;
		}
		MeshComponentUtils.RelativeAttachComponent(child, parent, socketName);
		return true;
	}

	// Token: 0x060186DF RID: 100063 RVA: 0x007608E4 File Offset: 0x0075EAE4
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
