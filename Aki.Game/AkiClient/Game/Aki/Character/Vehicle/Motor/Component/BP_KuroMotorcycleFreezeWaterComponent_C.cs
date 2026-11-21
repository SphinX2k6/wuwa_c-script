using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Component
{
	// Token: 0x02003293 RID: 12947
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Component/BP_KuroMotorcycleFreezeWaterComponent.BP_KuroMotorcycleFreezeWaterComponent_C")]
	[UnrealStructLayout(2224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2216)]
	public class BP_KuroMotorcycleFreezeWaterComponent_C : UKuroWaterInteractionComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060206D9 RID: 132825 RVA: 0x009464E2 File Offset: 0x009446E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroMotorcycleFreezeWaterComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Component/BP_KuroMotorcycleFreezeWaterComponent.BP_KuroMotorcycleFreezeWaterComponent_C");
			}
			return BP_KuroMotorcycleFreezeWaterComponent_C._ClassPtr;
		}

		// Token: 0x060206DA RID: 132826 RVA: 0x00946508 File Offset: 0x00944708
		public BP_KuroMotorcycleFreezeWaterComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroMotorcycleFreezeWaterComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060206DB RID: 132827 RVA: 0x00946530 File Offset: 0x00944730
		[NullableContext(1)]
		public BP_KuroMotorcycleFreezeWaterComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroMotorcycleFreezeWaterComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x060206DC RID: 132828 RVA: 0x00946563 File Offset: 0x00944763
		// (set) Token: 0x060206DD RID: 132829 RVA: 0x00946577 File Offset: 0x00944777
		public unsafe UTextureRenderTarget2D RT_PosA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_RT_PosA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_RT_PosA, value);
			}
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x060206DE RID: 132830 RVA: 0x0094658C File Offset: 0x0094478C
		// (set) Token: 0x060206DF RID: 132831 RVA: 0x009465A0 File Offset: 0x009447A0
		public unsafe UTextureRenderTarget2D RT_PosB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_RT_PosB);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_RT_PosB, value);
			}
		}

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x060206E0 RID: 132832 RVA: 0x009465B5 File Offset: 0x009447B5
		// (set) Token: 0x060206E1 RID: 132833 RVA: 0x009465C9 File Offset: 0x009447C9
		public unsafe UMaterialInterface M_DrawRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_M_DrawRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_M_DrawRT, value);
			}
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x060206E2 RID: 132834 RVA: 0x009465DE File Offset: 0x009447DE
		// (set) Token: 0x060206E3 RID: 132835 RVA: 0x009465F2 File Offset: 0x009447F2
		public unsafe UMaterialInstanceDynamic MID_StampPos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_MID_StampPos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_MID_StampPos, value);
			}
		}

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x060206E4 RID: 132836 RVA: 0x00946607 File Offset: 0x00944807
		// (set) Token: 0x060206E5 RID: 132837 RVA: 0x0094661B File Offset: 0x0094481B
		public unsafe UMaterialInstanceDynamic MID_UpdatePos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_MID_UpdatePos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_MID_UpdatePos, value);
			}
		}

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x060206E6 RID: 132838 RVA: 0x00946630 File Offset: 0x00944830
		// (set) Token: 0x060206E7 RID: 132839 RVA: 0x00946644 File Offset: 0x00944844
		public unsafe UMaterialInstanceDynamic MID_Ice
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_MID_Ice);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_MID_Ice, value);
			}
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x060206E8 RID: 132840 RVA: 0x00946659 File Offset: 0x00944859
		// (set) Token: 0x060206E9 RID: 132841 RVA: 0x0094666D File Offset: 0x0094486D
		public unsafe FLinearColor Clear_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_Clear_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_Clear_Color) = value;
			}
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x060206EA RID: 132842 RVA: 0x00946682 File Offset: 0x00944882
		// (set) Token: 0x060206EB RID: 132843 RVA: 0x00946692 File Offset: 0x00944892
		public unsafe float InteractionSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_InteractionSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_InteractionSize) = value;
			}
		}

		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x060206EC RID: 132844 RVA: 0x009466A3 File Offset: 0x009448A3
		// (set) Token: 0x060206ED RID: 132845 RVA: 0x009466B3 File Offset: 0x009448B3
		public unsafe float Attenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_Attenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_Attenuation) = value;
			}
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x060206EE RID: 132846 RVA: 0x009466C4 File Offset: 0x009448C4
		// (set) Token: 0x060206EF RID: 132847 RVA: 0x009466D8 File Offset: 0x009448D8
		public unsafe FVectorDouble PixelPos_Curr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_PixelPos_Curr);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_PixelPos_Curr) = value;
			}
		}

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x060206F0 RID: 132848 RVA: 0x009466ED File Offset: 0x009448ED
		// (set) Token: 0x060206F1 RID: 132849 RVA: 0x00946701 File Offset: 0x00944901
		public unsafe FVectorDouble PixelPos_Prev
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_PixelPos_Prev);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_PixelPos_Prev) = value;
			}
		}

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x060206F2 RID: 132850 RVA: 0x00946716 File Offset: 0x00944916
		// (set) Token: 0x060206F3 RID: 132851 RVA: 0x00946726 File Offset: 0x00944926
		public unsafe bool DetectingWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_DetectingWater) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_DetectingWater) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x060206F4 RID: 132852 RVA: 0x00946737 File Offset: 0x00944937
		// (set) Token: 0x060206F5 RID: 132853 RVA: 0x0094674B File Offset: 0x0094494B
		public unsafe UKuroTrailCollisionAsset Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTrailCollisionAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_Config);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_Config, value);
			}
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x060206F6 RID: 132854 RVA: 0x00946760 File Offset: 0x00944960
		// (set) Token: 0x060206F7 RID: 132855 RVA: 0x00946774 File Offset: 0x00944974
		public unsafe UMaterialInterface M_Ice
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_M_Ice);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_M_Ice, value);
			}
		}

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x060206F8 RID: 132856 RVA: 0x00946789 File Offset: 0x00944989
		// (set) Token: 0x060206F9 RID: 132857 RVA: 0x0094679D File Offset: 0x0094499D
		public unsafe FVectorDouble PixelPos_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_PixelPos_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMotorcycleFreezeWaterComponent_C.__PropertyOffset_PixelPos_Offset) = value;
			}
		}

		// Token: 0x060206FA RID: 132858 RVA: 0x009467B2 File Offset: 0x009449B2
		[SkipLocalsInit]
		public virtual void ClearRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ClearRT_NativeFunctionPtr, null);
		}

		// Token: 0x060206FB RID: 132859 RVA: 0x009467C6 File Offset: 0x009449C6
		[SkipLocalsInit]
		public virtual void CreateMID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__CreateMID_NativeFunctionPtr, null);
		}

		// Token: 0x060206FC RID: 132860 RVA: 0x009467DA File Offset: 0x009449DA
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060206FD RID: 132861 RVA: 0x009467EE File Offset: 0x009449EE
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060206FE RID: 132862 RVA: 0x00946802 File Offset: 0x00944A02
		[SkipLocalsInit]
		public override void HandleWaterDetectedStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedStart_NativeFunctionPtr, null);
		}

		// Token: 0x060206FF RID: 132863 RVA: 0x00946816 File Offset: 0x00944A16
		[SkipLocalsInit]
		protected virtual void HandleWaterDetectedStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020700 RID: 132864 RVA: 0x0094682A File Offset: 0x00944A2A
		[SkipLocalsInit]
		public override void HandleWaterDetectedEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020701 RID: 132865 RVA: 0x0094683E File Offset: 0x00944A3E
		[SkipLocalsInit]
		protected virtual void HandleWaterDetectedEnd_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020702 RID: 132866 RVA: 0x00946854 File Offset: 0x00944A54
		[SkipLocalsInit]
		public unsafe override void HandleWaterDetectedTick(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->WaterSurface = WaterSurface;
			ptr->Location = Location;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020703 RID: 132867 RVA: 0x009468B0 File Offset: 0x00944AB0
		[SkipLocalsInit]
		protected unsafe virtual void HandleWaterDetectedTick_Implementation(float DeltaTime, float WaterSurface, in FVectorDouble Location)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->WaterSurface = WaterSurface;
			ptr->Location = Location;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__HandleWaterDetectedTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020704 RID: 132868 RVA: 0x0094690C File Offset: 0x00944B0C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020705 RID: 132869 RVA: 0x00946954 File Offset: 0x00944B54
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020706 RID: 132870 RVA: 0x0094699C File Offset: 0x00944B9C
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020707 RID: 132871 RVA: 0x009469E8 File Offset: 0x00944BE8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMotorcycleFreezeWaterComponent_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020708 RID: 132872 RVA: 0x00946A33 File Offset: 0x00944C33
		protected BP_KuroMotorcycleFreezeWaterComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011851 RID: 71761
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Component/BP_KuroMotorcycleFreezeWaterComponent.BP_KuroMotorcycleFreezeWaterComponent_C";

		// Token: 0x04011852 RID: 71762
		private static IntPtr _ClassPtr;

		// Token: 0x04011853 RID: 71763
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011854 RID: 71764
		internal static int __PropertyOffset_RT_PosA;

		// Token: 0x04011855 RID: 71765
		internal static int __PropertyOffset_RT_PosB;

		// Token: 0x04011856 RID: 71766
		internal static int __PropertyOffset_M_DrawRT;

		// Token: 0x04011857 RID: 71767
		internal static int __PropertyOffset_MID_StampPos;

		// Token: 0x04011858 RID: 71768
		internal static int __PropertyOffset_MID_UpdatePos;

		// Token: 0x04011859 RID: 71769
		internal static int __PropertyOffset_MID_Ice;

		// Token: 0x0401185A RID: 71770
		internal static int __PropertyOffset_Clear_Color;

		// Token: 0x0401185B RID: 71771
		internal static int __PropertyOffset_InteractionSize;

		// Token: 0x0401185C RID: 71772
		internal static int __PropertyOffset_Attenuation;

		// Token: 0x0401185D RID: 71773
		internal static int __PropertyOffset_PixelPos_Curr;

		// Token: 0x0401185E RID: 71774
		internal static int __PropertyOffset_PixelPos_Prev;

		// Token: 0x0401185F RID: 71775
		internal static int __PropertyOffset_DetectingWater;

		// Token: 0x04011860 RID: 71776
		internal static int __PropertyOffset_Config;

		// Token: 0x04011861 RID: 71777
		internal static int __PropertyOffset_M_Ice;

		// Token: 0x04011862 RID: 71778
		internal static int __PropertyOffset_PixelPos_Offset;

		// Token: 0x04011863 RID: 71779
		private static IntPtr __ClearRT_NativeFunctionPtr;

		// Token: 0x04011864 RID: 71780
		private static IntPtr __CreateMID_NativeFunctionPtr;

		// Token: 0x04011865 RID: 71781
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011866 RID: 71782
		private static IntPtr __HandleWaterDetectedStart_NativeFunctionPtr;

		// Token: 0x04011867 RID: 71783
		private static IntPtr __HandleWaterDetectedEnd_NativeFunctionPtr;

		// Token: 0x04011868 RID: 71784
		private static IntPtr __HandleWaterDetectedTick_NativeFunctionPtr;

		// Token: 0x04011869 RID: 71785
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401186A RID: 71786
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008F67 RID: 36711
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected new ref struct __HandleWaterDetectedTick_FunctionParams
		{
			// Token: 0x0402CCE5 RID: 183525
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x0402CCE6 RID: 183526
			[FieldOffset(4)]
			public float WaterSurface;

			// Token: 0x0402CCE7 RID: 183527
			[FieldOffset(8)]
			public FVectorDouble Location;
		}

		// Token: 0x02008F68 RID: 36712
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CCE8 RID: 183528
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008F69 RID: 36713
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CCE9 RID: 183529
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
