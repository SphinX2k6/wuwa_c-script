using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using UnrealEngine;

// Token: 0x02001A79 RID: 6777
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class PhotoSaveViewParam
{
	// Token: 0x06010CC8 RID: 68808 RVA: 0x004ED3F7 File Offset: 0x004EB5F7
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public PhotoSaveViewParam()
	{
	}

	// Token: 0x04009432 RID: 37938
	public bool ScreenShot;

	// Token: 0x04009433 RID: 37939
	public bool PrepareFullScreenShot;

	// Token: 0x04009434 RID: 37940
	public bool IsHiddenBattleView;

	// Token: 0x04009435 RID: 37941
	public HandBookPhotoData HandBookPhotoData;

	// Token: 0x04009436 RID: 37942
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<GachaResult> GachaData;

	// Token: 0x04009437 RID: 37943
	public FragmentMemoryCollectData FragmentMemory;

	// Token: 0x04009438 RID: 37944
	public RoleSkinData RoleSkinData;

	// Token: 0x04009439 RID: 37945
	public VersionPreheatShareData VersionPreheat;

	// Token: 0x0400943A RID: 37946
	public Spring25ShareData Spring25Data;

	// Token: 0x0400943B RID: 37947
	public IBabelTowerSettlementViewData BabelTowerSettlementViewData;

	// Token: 0x0400943C RID: 37948
	public IWheelTowerSettlementViewData WheelTowerSettlementViewData;

	// Token: 0x0400943D RID: 37949
	public ShipTowerRecordShareData ShipTowerRecordShareData;

	// Token: 0x0400943E RID: 37950
	public UTexture2D ExternalTexture;

	// Token: 0x0400943F RID: 37951
	public string DateText;

	// Token: 0x04009440 RID: 37952
	[RequiredMember]
	public int ShareId;

	// Token: 0x04009441 RID: 37953
	public string LogoConfigName;

	// Token: 0x04009442 RID: 37954
	public bool? LogoLeft;

	// Token: 0x04009443 RID: 37955
	public bool? CaptureFullScene;

	// Token: 0x04009444 RID: 37956
	public EShareReportExtraType? ReportExtraType;
}
