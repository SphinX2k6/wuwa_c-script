using System;
using UnrealEngine;

// Token: 0x02002516 RID: 9494
public class GameplayCueHideBone : GameplayCueBase
{
	// Token: 0x060177CE RID: 96206 RVA: 0x006EE687 File Offset: 0x006EC887
	protected override void OnCreate()
	{
		this.HideBone(true);
	}

	// Token: 0x060177CF RID: 96207 RVA: 0x006EE690 File Offset: 0x006EC890
	protected override void OnDestroy()
	{
		this.HideBone(false);
	}

	// Token: 0x060177D0 RID: 96208 RVA: 0x006EE69C File Offset: 0x006EC89C
	private void HideBone(bool bStart)
	{
		FName value = FNameUtil.GetDynamicFName(this.CueConfig.Parameters(0)).Value;
		bool flag = ((this.CueConfig.ParametersLength > 1) ? this.CueConfig.Parameters(1) : "1") == "1";
		if (!bStart)
		{
			flag = !flag;
		}
		if (this.ActorInternal.Mesh.IsBoneHiddenByName(value) == flag)
		{
			return;
		}
		if (flag)
		{
			int num;
			EPhysBodyOp physBodyOption = (EPhysBodyOp)((this.CueConfig.ParametersLength > 1 && int.TryParse(this.CueConfig.Parameters(1), out num)) ? num : 0);
			this.ActorInternal.Mesh.HideBoneByName(value, physBodyOption);
			return;
		}
		this.ActorInternal.Mesh.UnHideBoneByName(value);
	}
}
