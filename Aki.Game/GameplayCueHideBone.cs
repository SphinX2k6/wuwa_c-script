using System;
using UnrealEngine;

// Token: 0x02002FC2 RID: 12226
public class GameplayCueHideBone : GameplayCueBase
{
	// Token: 0x06019EBC RID: 106172 RVA: 0x006C7DBB File Offset: 0x006C5FBB
	protected override void OnCreate()
	{
		this.HideBone(true);
	}

	// Token: 0x06019EBD RID: 106173 RVA: 0x006C7DC4 File Offset: 0x006C5FC4
	protected override void OnDestroy()
	{
		this.HideBone(false);
	}

	// Token: 0x06019EBE RID: 106174 RVA: 0x006C7DD0 File Offset: 0x006C5FD0
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
