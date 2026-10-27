using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.UI.Module.Common.View.Widget;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PSOSwitchSettingDebug
{
	// Token: 0x02003BCD RID: 15309
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/WBP_PSOSwitchQuality.WBP_PSOSwitchQuality_C")]
	[UnrealStructLayout(1352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1349)]
	public class WBP_PSOSwitchQuality_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022549 RID: 140617 RVA: 0x0090602C File Offset: 0x0090422C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (WBP_PSOSwitchQuality_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/WBP_PSOSwitchQuality.WBP_PSOSwitchQuality_C");
			}
			return WBP_PSOSwitchQuality_C._ClassPtr;
		}

		// Token: 0x0602254A RID: 140618 RVA: 0x00906050 File Offset: 0x00904250
		public WBP_PSOSwitchQuality_C() : this(BuiltinUtils.AllocNativeUObject(WBP_PSOSwitchQuality_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602254B RID: 140619 RVA: 0x00906078 File Offset: 0x00904278
		[NullableContext(1)]
		public WBP_PSOSwitchQuality_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WBP_PSOSwitchQuality_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x0602254C RID: 140620 RVA: 0x009060AB File Offset: 0x009042AB
		// (set) Token: 0x0602254D RID: 140621 RVA: 0x009060BF File Offset: 0x009042BF
		public unsafe UButton BtnClose
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x0602254E RID: 140622 RVA: 0x009060D4 File Offset: 0x009042D4
		// (set) Token: 0x0602254F RID: 140623 RVA: 0x009060E8 File Offset: 0x009042E8
		public unsafe UButton Button
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x06022550 RID: 140624 RVA: 0x009060FD File Offset: 0x009042FD
		// (set) Token: 0x06022551 RID: 140625 RVA: 0x00906111 File Offset: 0x00904311
		public unsafe UButton Button_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x06022552 RID: 140626 RVA: 0x00906126 File Offset: 0x00904326
		// (set) Token: 0x06022553 RID: 140627 RVA: 0x0090613A File Offset: 0x0090433A
		public unsafe UButton Button_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x06022554 RID: 140628 RVA: 0x0090614F File Offset: 0x0090434F
		// (set) Token: 0x06022555 RID: 140629 RVA: 0x00906163 File Offset: 0x00904363
		public unsafe UButton Button_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x06022556 RID: 140630 RVA: 0x00906178 File Offset: 0x00904378
		// (set) Token: 0x06022557 RID: 140631 RVA: 0x0090618C File Offset: 0x0090438C
		public unsafe UButton Button_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x06022558 RID: 140632 RVA: 0x009061A1 File Offset: 0x009043A1
		// (set) Token: 0x06022559 RID: 140633 RVA: 0x009061B5 File Offset: 0x009043B5
		public unsafe UButton Button_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0602255A RID: 140634 RVA: 0x009061CA File Offset: 0x009043CA
		// (set) Token: 0x0602255B RID: 140635 RVA: 0x009061DE File Offset: 0x009043DE
		public unsafe UButton Button_6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0602255C RID: 140636 RVA: 0x009061F3 File Offset: 0x009043F3
		// (set) Token: 0x0602255D RID: 140637 RVA: 0x00906207 File Offset: 0x00904407
		public unsafe UButton Button_7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0602255E RID: 140638 RVA: 0x0090621C File Offset: 0x0090441C
		// (set) Token: 0x0602255F RID: 140639 RVA: 0x00906230 File Offset: 0x00904430
		public unsafe UButton Button_8
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x06022560 RID: 140640 RVA: 0x00906245 File Offset: 0x00904445
		// (set) Token: 0x06022561 RID: 140641 RVA: 0x00906259 File Offset: 0x00904459
		public unsafe UButton Button_9
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x06022562 RID: 140642 RVA: 0x0090626E File Offset: 0x0090446E
		// (set) Token: 0x06022563 RID: 140643 RVA: 0x00906282 File Offset: 0x00904482
		public unsafe UButton Button_10
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x06022564 RID: 140644 RVA: 0x00906297 File Offset: 0x00904497
		// (set) Token: 0x06022565 RID: 140645 RVA: 0x009062AB File Offset: 0x009044AB
		public unsafe UButton Button_11
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x06022566 RID: 140646 RVA: 0x009062C0 File Offset: 0x009044C0
		// (set) Token: 0x06022567 RID: 140647 RVA: 0x009062D4 File Offset: 0x009044D4
		public unsafe UButton Button_12
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UButton>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x06022568 RID: 140648 RVA: 0x009062E9 File Offset: 0x009044E9
		// (set) Token: 0x06022569 RID: 140649 RVA: 0x009062FD File Offset: 0x009044FD
		public unsafe KuroImage_C KuroImage_C_76
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KuroImage_C>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0602256A RID: 140650 RVA: 0x00906312 File Offset: 0x00904512
		// (set) Token: 0x0602256B RID: 140651 RVA: 0x00906326 File Offset: 0x00904526
		public unsafe UEditableTextBox TextQuality
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEditableTextBox>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0602256C RID: 140652 RVA: 0x0090633B File Offset: 0x0090453B
		// (set) Token: 0x0602256D RID: 140653 RVA: 0x0090634F File Offset: 0x0090454F
		public unsafe UEditableTextBox TextRenderPass
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEditableTextBox>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0602256E RID: 140654 RVA: 0x00906364 File Offset: 0x00904564
		// (set) Token: 0x0602256F RID: 140655 RVA: 0x00906374 File Offset: 0x00904574
		public unsafe bool SceneLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x06022570 RID: 140656 RVA: 0x00906385 File Offset: 0x00904585
		// (set) Token: 0x06022571 RID: 140657 RVA: 0x00906399 File Offset: 0x00904599
		public unsafe ULevelSequence PSOSeq
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x06022572 RID: 140658 RVA: 0x009063AE File Offset: 0x009045AE
		// (set) Token: 0x06022573 RID: 140659 RVA: 0x009063C2 File Offset: 0x009045C2
		public unsafe ULevelSequencePlayer SequencePlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WBP_PSOSwitchQuality_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x06022574 RID: 140660 RVA: 0x009063D7 File Offset: 0x009045D7
		// (set) Token: 0x06022575 RID: 140661 RVA: 0x009063E7 File Offset: 0x009045E7
		public unsafe bool SequenceFinish
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x06022576 RID: 140662 RVA: 0x009063F8 File Offset: 0x009045F8
		// (set) Token: 0x06022577 RID: 140663 RVA: 0x00906408 File Offset: 0x00904608
		public unsafe bool StartCollect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x06022578 RID: 140664 RVA: 0x00906419 File Offset: 0x00904619
		// (set) Token: 0x06022579 RID: 140665 RVA: 0x00906429 File Offset: 0x00904629
		public unsafe int IOSCollectionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0602257A RID: 140666 RVA: 0x0090643A File Offset: 0x0090463A
		// (set) Token: 0x0602257B RID: 140667 RVA: 0x0090644A File Offset: 0x0090464A
		public unsafe int AndroidCollectionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0602257C RID: 140668 RVA: 0x0090645B File Offset: 0x0090465B
		// (set) Token: 0x0602257D RID: 140669 RVA: 0x0090646B File Offset: 0x0090466B
		public unsafe bool IsIOS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)WBP_PSOSwitchQuality_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602257E RID: 140670 RVA: 0x0090647C File Offset: 0x0090467C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FinishOneTimeCollection()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__FinishOneTimeCollection_NativeFunctionPtr, null);
		}

		// Token: 0x0602257F RID: 140671 RVA: 0x00906490 File Offset: 0x00904690
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetHighQaulity(string MaterialQuality)
		{
			WBP_PSOSwitchQuality_C.__SetHighQaulity_FunctionParams* ptr = stackalloc WBP_PSOSwitchQuality_C.__SetHighQaulity_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(WBP_PSOSwitchQuality_C.__SetHighQaulity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_PSOSwitchQuality_C.__SetHighQaulity_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MaterialQuality), MaterialQuality);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__SetHighQaulity_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_PSOSwitchQuality_C.__SetHighQaulity_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022580 RID: 140672 RVA: 0x009064F0 File Offset: 0x009046F0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMiddleQuality(string MaterialQuality)
		{
			WBP_PSOSwitchQuality_C.__SetMiddleQuality_FunctionParams* ptr = stackalloc WBP_PSOSwitchQuality_C.__SetMiddleQuality_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(WBP_PSOSwitchQuality_C.__SetMiddleQuality_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_PSOSwitchQuality_C.__SetMiddleQuality_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MaterialQuality), MaterialQuality);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__SetMiddleQuality_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_PSOSwitchQuality_C.__SetMiddleQuality_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022581 RID: 140673 RVA: 0x00906550 File Offset: 0x00904750
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLowQuality(string MaterialQuality)
		{
			WBP_PSOSwitchQuality_C.__SetLowQuality_FunctionParams* ptr = stackalloc WBP_PSOSwitchQuality_C.__SetLowQuality_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(WBP_PSOSwitchQuality_C.__SetLowQuality_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_PSOSwitchQuality_C.__SetLowQuality_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MaterialQuality), MaterialQuality);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__SetLowQuality_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_PSOSwitchQuality_C.__SetLowQuality_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022582 RID: 140674 RVA: 0x009065B0 File Offset: 0x009047B0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetlowestQuality(string MaterialQuality)
		{
			WBP_PSOSwitchQuality_C.__SetlowestQuality_FunctionParams* ptr = stackalloc WBP_PSOSwitchQuality_C.__SetlowestQuality_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(WBP_PSOSwitchQuality_C.__SetlowestQuality_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_PSOSwitchQuality_C.__SetlowestQuality_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MaterialQuality), MaterialQuality);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__SetlowestQuality_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(WBP_PSOSwitchQuality_C.__SetlowestQuality_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06022583 RID: 140675 RVA: 0x0090660D File Offset: 0x0090480D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayerSequence()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__PlayerSequence_NativeFunctionPtr, null);
		}

		// Token: 0x06022584 RID: 140676 RVA: 0x00906621 File Offset: 0x00904821
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__PSOSwitchQuality_Button_5_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__PSOSwitchQuality_Button_5_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06022585 RID: 140677 RVA: 0x00906635 File Offset: 0x00904835
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__PSOSwitchQuality_Button_6_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__PSOSwitchQuality_Button_6_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06022586 RID: 140678 RVA: 0x00906649 File Offset: 0x00904849
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__PSOSwitchQuality_Button_7_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__PSOSwitchQuality_Button_7_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06022587 RID: 140679 RVA: 0x0090665D File Offset: 0x0090485D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__PSOSwitchQuality_Button_4_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__PSOSwitchQuality_Button_4_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06022588 RID: 140680 RVA: 0x00906671 File Offset: 0x00904871
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__PSOSwitchQuality_Button_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__PSOSwitchQuality_Button_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06022589 RID: 140681 RVA: 0x00906685 File Offset: 0x00904885
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__PSOSwitchQuality_Button_1_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__PSOSwitchQuality_Button_1_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602258A RID: 140682 RVA: 0x00906699 File Offset: 0x00904899
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__PSOSwitchQuality_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__PSOSwitchQuality_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602258B RID: 140683 RVA: 0x009066B0 File Offset: 0x009048B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_PSOSwitchQuality_C.__Tick_FunctionParams* ptr = stackalloc WBP_PSOSwitchQuality_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_PSOSwitchQuality_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_PSOSwitchQuality_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602258C RID: 140684 RVA: 0x00906718 File Offset: 0x00904918
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			WBP_PSOSwitchQuality_C.__Tick_FunctionParams* ptr = stackalloc WBP_PSOSwitchQuality_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(WBP_PSOSwitchQuality_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WBP_PSOSwitchQuality_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602258D RID: 140685 RVA: 0x00906781 File Offset: 0x00904981
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__PSOSwitchQuality_Button_2_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__PSOSwitchQuality_Button_2_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602258E RID: 140686 RVA: 0x00906795 File Offset: 0x00904995
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_PSOSwitchQuality_Button_3_K2Node_ComponentBoundEvent_9_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__WBP_PSOSwitchQuality_Button_3_K2Node_ComponentBoundEvent_9_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x0602258F RID: 140687 RVA: 0x009067A9 File Offset: 0x009049A9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_PSOSwitchQuality_Button_8_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__WBP_PSOSwitchQuality_Button_8_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06022590 RID: 140688 RVA: 0x009067BD File Offset: 0x009049BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void BndEvt__WBP_PSOSwitchQuality_Button_12_K2Node_ComponentBoundEvent_10_OnButtonClickedEvent__DelegateSignature()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__BndEvt__WBP_PSOSwitchQuality_Button_12_K2Node_ComponentBoundEvent_10_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr, null);
		}

		// Token: 0x06022591 RID: 140689 RVA: 0x009067D1 File Offset: 0x009049D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void Construct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__Construct_NativeFunctionPtr, null);
		}

		// Token: 0x06022592 RID: 140690 RVA: 0x009067E5 File Offset: 0x009049E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void Construct_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, WBP_PSOSwitchQuality_C.__Construct_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022593 RID: 140691 RVA: 0x009067FA File Offset: 0x009049FA
		protected WBP_PSOSwitchQuality_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D76 RID: 68982
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/WBP_PSOSwitchQuality.WBP_PSOSwitchQuality_C";

		// Token: 0x04010D77 RID: 68983
		private static IntPtr _ClassPtr;

		// Token: 0x04010D78 RID: 68984
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D79 RID: 68985
		internal static int __PropertyOffset_1;

		// Token: 0x04010D7A RID: 68986
		internal static int __PropertyOffset_2;

		// Token: 0x04010D7B RID: 68987
		internal static int __PropertyOffset_3;

		// Token: 0x04010D7C RID: 68988
		internal static int __PropertyOffset_4;

		// Token: 0x04010D7D RID: 68989
		internal static int __PropertyOffset_5;

		// Token: 0x04010D7E RID: 68990
		internal static int __PropertyOffset_6;

		// Token: 0x04010D7F RID: 68991
		internal static int __PropertyOffset_7;

		// Token: 0x04010D80 RID: 68992
		internal static int __PropertyOffset_8;

		// Token: 0x04010D81 RID: 68993
		internal static int __PropertyOffset_9;

		// Token: 0x04010D82 RID: 68994
		internal static int __PropertyOffset_10;

		// Token: 0x04010D83 RID: 68995
		internal static int __PropertyOffset_11;

		// Token: 0x04010D84 RID: 68996
		internal static int __PropertyOffset_12;

		// Token: 0x04010D85 RID: 68997
		internal static int __PropertyOffset_13;

		// Token: 0x04010D86 RID: 68998
		internal static int __PropertyOffset_14;

		// Token: 0x04010D87 RID: 68999
		internal static int __PropertyOffset_15;

		// Token: 0x04010D88 RID: 69000
		internal static int __PropertyOffset_16;

		// Token: 0x04010D89 RID: 69001
		internal static int __PropertyOffset_17;

		// Token: 0x04010D8A RID: 69002
		internal static int __PropertyOffset_18;

		// Token: 0x04010D8B RID: 69003
		internal static int __PropertyOffset_19;

		// Token: 0x04010D8C RID: 69004
		internal static int __PropertyOffset_20;

		// Token: 0x04010D8D RID: 69005
		internal static int __PropertyOffset_21;

		// Token: 0x04010D8E RID: 69006
		internal static int __PropertyOffset_22;

		// Token: 0x04010D8F RID: 69007
		internal static int __PropertyOffset_23;

		// Token: 0x04010D90 RID: 69008
		internal static int __PropertyOffset_24;

		// Token: 0x04010D91 RID: 69009
		internal static int __PropertyOffset_25;

		// Token: 0x04010D92 RID: 69010
		private static IntPtr __FinishOneTimeCollection_NativeFunctionPtr;

		// Token: 0x04010D93 RID: 69011
		private static IntPtr __SetHighQaulity_NativeFunctionPtr;

		// Token: 0x04010D94 RID: 69012
		private static IntPtr __SetMiddleQuality_NativeFunctionPtr;

		// Token: 0x04010D95 RID: 69013
		private static IntPtr __SetLowQuality_NativeFunctionPtr;

		// Token: 0x04010D96 RID: 69014
		private static IntPtr __SetlowestQuality_NativeFunctionPtr;

		// Token: 0x04010D97 RID: 69015
		private static IntPtr __PlayerSequence_NativeFunctionPtr;

		// Token: 0x04010D98 RID: 69016
		private static IntPtr __BndEvt__PSOSwitchQuality_Button_5_K2Node_ComponentBoundEvent_2_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010D99 RID: 69017
		private static IntPtr __BndEvt__PSOSwitchQuality_Button_6_K2Node_ComponentBoundEvent_3_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010D9A RID: 69018
		private static IntPtr __BndEvt__PSOSwitchQuality_Button_7_K2Node_ComponentBoundEvent_4_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010D9B RID: 69019
		private static IntPtr __BndEvt__PSOSwitchQuality_Button_4_K2Node_ComponentBoundEvent_1_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010D9C RID: 69020
		private static IntPtr __BndEvt__PSOSwitchQuality_Button_K2Node_ComponentBoundEvent_6_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010D9D RID: 69021
		private static IntPtr __BndEvt__PSOSwitchQuality_Button_1_K2Node_ComponentBoundEvent_7_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010D9E RID: 69022
		private static IntPtr __BndEvt__PSOSwitchQuality_BtnClose_K2Node_ComponentBoundEvent_0_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010D9F RID: 69023
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04010DA0 RID: 69024
		private static IntPtr __BndEvt__PSOSwitchQuality_Button_2_K2Node_ComponentBoundEvent_8_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010DA1 RID: 69025
		private static IntPtr __BndEvt__WBP_PSOSwitchQuality_Button_3_K2Node_ComponentBoundEvent_9_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010DA2 RID: 69026
		private static IntPtr __BndEvt__WBP_PSOSwitchQuality_Button_8_K2Node_ComponentBoundEvent_5_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010DA3 RID: 69027
		private static IntPtr __BndEvt__WBP_PSOSwitchQuality_Button_12_K2Node_ComponentBoundEvent_10_OnButtonClickedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010DA4 RID: 69028
		private static IntPtr __Construct_NativeFunctionPtr;

		// Token: 0x02009D67 RID: 40295
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetHighQaulity_FunctionParams
		{
			// Token: 0x040314E4 RID: 201956
			[FieldOffset(0)]
			public FString MaterialQuality;
		}

		// Token: 0x02009D68 RID: 40296
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetMiddleQuality_FunctionParams
		{
			// Token: 0x040314E5 RID: 201957
			[FieldOffset(0)]
			public FString MaterialQuality;
		}

		// Token: 0x02009D69 RID: 40297
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetLowQuality_FunctionParams
		{
			// Token: 0x040314E6 RID: 201958
			[FieldOffset(0)]
			public FString MaterialQuality;
		}

		// Token: 0x02009D6A RID: 40298
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __SetlowestQuality_FunctionParams
		{
			// Token: 0x040314E7 RID: 201959
			[FieldOffset(0)]
			public FString MaterialQuality;
		}

		// Token: 0x02009D6B RID: 40299
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x040314E8 RID: 201960
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x040314E9 RID: 201961
			[FieldOffset(56)]
			public float InDeltaTime;
		}
	}
}
