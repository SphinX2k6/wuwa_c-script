using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Library
{
	// Token: 0x02003CF5 RID: 15605
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Library/EObjectFlags.EObjectFlags")]
	public enum EObjectFlags : byte
	{
		// Token: 0x0401289A RID: 75930
		RF_Public,
		// Token: 0x0401289B RID: 75931
		RF_Standalone,
		// Token: 0x0401289C RID: 75932
		RF_MarkAsNative,
		// Token: 0x0401289D RID: 75933
		RF_Transactional,
		// Token: 0x0401289E RID: 75934
		RF_ClassDefaultObject,
		// Token: 0x0401289F RID: 75935
		RF_ArchetypeObject,
		// Token: 0x040128A0 RID: 75936
		RF_Transient,
		// Token: 0x040128A1 RID: 75937
		RF_MarkAsRootSet,
		// Token: 0x040128A2 RID: 75938
		RF_TagGarbageTemp,
		// Token: 0x040128A3 RID: 75939
		RF_NeedInitialization,
		// Token: 0x040128A4 RID: 75940
		RF_NeedLoad,
		// Token: 0x040128A5 RID: 75941
		RF_KeepForCooker,
		// Token: 0x040128A6 RID: 75942
		RF_NeedPostLoad,
		// Token: 0x040128A7 RID: 75943
		RF_NeedPostLoadSubobjects,
		// Token: 0x040128A8 RID: 75944
		RF_NewerVersionExists,
		// Token: 0x040128A9 RID: 75945
		RF_BeginDestroyed,
		// Token: 0x040128AA RID: 75946
		RF_FinishDestroyed,
		// Token: 0x040128AB RID: 75947
		RF_BeingRegenerated,
		// Token: 0x040128AC RID: 75948
		RF_DefaultSubObject,
		// Token: 0x040128AD RID: 75949
		RF_WasLoaded,
		// Token: 0x040128AE RID: 75950
		RF_TextExportTransient,
		// Token: 0x040128AF RID: 75951
		RF_LoadCompleted,
		// Token: 0x040128B0 RID: 75952
		RF_InheritableComponentTemplate,
		// Token: 0x040128B1 RID: 75953
		RF_DuplicateTransient,
		// Token: 0x040128B2 RID: 75954
		RF_StrongRefOnFrame,
		// Token: 0x040128B3 RID: 75955
		RF_NonPIEDuplicateTransient,
		// Token: 0x040128B4 RID: 75956
		RF_Dynamic,
		// Token: 0x040128B5 RID: 75957
		RF_WillBeLoaded,
		// Token: 0x040128B6 RID: 75958
		RF_HasExternalPackage,
		// Token: 0x040128B7 RID: 75959
		EObjectFlags_MAX
	}
}
