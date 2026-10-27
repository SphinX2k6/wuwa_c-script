using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using UnrealEngine;

// Token: 0x0200258E RID: 9614
[NullableContext(2)]
[Nullable(0)]
[RequiredMember]
public class PhotoSaveViewParam
{
	// Token: 0x060137E6 RID: 79846 RVA: 0x004DE8D3 File Offset: 0x004DCAD3
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public PhotoSaveViewParam()
	{
	}

	// Token: 0x040092DA RID: 37594
	public bool ScreenShot;

	// Token: 0x040092DB RID: 37595
	public bool PrepareFullScreenShot;

	// Token: 0x040092DC RID: 37596
	public bool IsHiddenBattleView;

	// Token: 0x040092DD RID: 37597
	public HandBookPhotoData HandBookPhotoData;

	// Token: 0x040092DE RID: 37598
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<GachaResult> GachaData;

	// Token: 0x040092DF RID: 37599
	public FragmentMemoryCollectData FragmentMemory;

	// Token: 0x040092E0 RID: 37600
	public RoleSkinData RoleSkinData;

	// Token: 0x040092E1 RID: 37601
	public VersionPreheatShareData VersionPreheat;

	// Token: 0x040092E2 RID: 37602
	public Spring25ShareData Spring25Data;

	// Token: 0x040092E3 RID: 37603
	public IBabelTowerSettlementViewData BabelTowerSettlementViewData;

	// Token: 0x040092E4 RID: 37604
	public IWheelTowerSettlementViewData WheelTowerSettlementViewData;

	// Token: 0x040092E5 RID: 37605
	public ShipTowerRecordShareData ShipTowerRecordShareData;

	// Token: 0x040092E6 RID: 37606
	public UTexture2D ExternalTexture;

	// Token: 0x040092E7 RID: 37607
	public string DateText;

	// Token: 0x040092E8 RID: 37608
	[RequiredMember]
	public int ShareId;

	// Token: 0x040092E9 RID: 37609
	public string LogoConfigName;

	// Token: 0x040092EA RID: 37610
	public bool? LogoLeft;

	// Token: 0x040092EB RID: 37611
	public bool? CaptureFullScene;

	// Token: 0x040092EC RID: 37612
	public EShareReportExtraType? ReportExtraType;
}
