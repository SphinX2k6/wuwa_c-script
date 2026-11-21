using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.Piano
{
	// Token: 0x020030CB RID: 12491
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoKey.BP_PianoKey_C")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1269)]
	public class BP_PianoKey_C : AActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601E0C9 RID: 123081 RVA: 0x009095DF File Offset: 0x009077DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PianoKey_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoKey.BP_PianoKey_C");
			}
			return BP_PianoKey_C._ClassPtr;
		}

		// Token: 0x0601E0CA RID: 123082 RVA: 0x00909603 File Offset: 0x00907803
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return BP_PianoKey_C.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x0601E0CB RID: 123083 RVA: 0x0090960C File Offset: 0x0090780C
		public BP_PianoKey_C() : this(BuiltinUtils.AllocNativeUObject(BP_PianoKey_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E0CC RID: 123084 RVA: 0x00909634 File Offset: 0x00907834
		[NullableContext(1)]
		public BP_PianoKey_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PianoKey_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0601E0CD RID: 123085 RVA: 0x00909667 File Offset: 0x00907867
		// (set) Token: 0x0601E0CE RID: 123086 RVA: 0x0090967B File Offset: 0x0090787B
		public unsafe USceneComponent Effect_Slot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_Effect_Slot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_Effect_Slot, value);
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0601E0CF RID: 123087 RVA: 0x00909690 File Offset: 0x00907890
		// (set) Token: 0x0601E0D0 RID: 123088 RVA: 0x009096A4 File Offset: 0x009078A4
		public unsafe UBoxComponent BoxCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_BoxCollision);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_BoxCollision, value);
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0601E0D1 RID: 123089 RVA: 0x009096B9 File Offset: 0x009078B9
		// (set) Token: 0x0601E0D2 RID: 123090 RVA: 0x009096CD File Offset: 0x009078CD
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0601E0D3 RID: 123091 RVA: 0x009096E2 File Offset: 0x009078E2
		// (set) Token: 0x0601E0D4 RID: 123092 RVA: 0x009096F6 File Offset: 0x009078F6
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0601E0D5 RID: 123093 RVA: 0x0090970B File Offset: 0x0090790B
		// (set) Token: 0x0601E0D6 RID: 123094 RVA: 0x0090971F File Offset: 0x0090791F
		public unsafe UTimelineComponent PressKey_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_PressKey_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_PressKey_Material, value);
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0601E0D7 RID: 123095 RVA: 0x00909734 File Offset: 0x00907934
		// (set) Token: 0x0601E0D8 RID: 123096 RVA: 0x00909748 File Offset: 0x00907948
		public unsafe UTimelineComponent PressKey_Animation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_PressKey_Animation);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_PressKey_Animation, value);
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0601E0D9 RID: 123097 RVA: 0x0090975D File Offset: 0x0090795D
		// (set) Token: 0x0601E0DA RID: 123098 RVA: 0x0090976D File Offset: 0x0090796D
		public unsafe bool IsPressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_IsPressed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_IsPressed) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0601E0DB RID: 123099 RVA: 0x0090977E File Offset: 0x0090797E
		// (set) Token: 0x0601E0DC RID: 123100 RVA: 0x00909792 File Offset: 0x00907992
		public unsafe UStaticMesh KeyMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_KeyMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_KeyMesh, value);
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0601E0DD RID: 123101 RVA: 0x009097A7 File Offset: 0x009079A7
		// (set) Token: 0x0601E0DE RID: 123102 RVA: 0x009097BB File Offset: 0x009079BB
		public unsafe FVector CollisionExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_CollisionExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_CollisionExtent) = value;
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0601E0DF RID: 123103 RVA: 0x009097D0 File Offset: 0x009079D0
		// (set) Token: 0x0601E0E0 RID: 123104 RVA: 0x009097E4 File Offset: 0x009079E4
		public unsafe FVector CollisionLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_CollisionLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_CollisionLocation) = value;
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0601E0E1 RID: 123105 RVA: 0x009097F9 File Offset: 0x009079F9
		// (set) Token: 0x0601E0E2 RID: 123106 RVA: 0x0090980D File Offset: 0x00907A0D
		public unsafe FRotator CollisionRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_CollisionRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_CollisionRotator) = value;
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0601E0E3 RID: 123107 RVA: 0x00909822 File Offset: 0x00907A22
		// (set) Token: 0x0601E0E4 RID: 123108 RVA: 0x00909832 File Offset: 0x00907A32
		public unsafe bool IsPressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_IsPressing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_IsPressing) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0601E0E5 RID: 123109 RVA: 0x00909843 File Offset: 0x00907A43
		// (set) Token: 0x0601E0E6 RID: 123110 RVA: 0x00909857 File Offset: 0x00907A57
		public unsafe FRotator CurrentRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_CurrentRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_CurrentRotator) = value;
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0601E0E7 RID: 123111 RVA: 0x0090986C File Offset: 0x00907A6C
		// (set) Token: 0x0601E0E8 RID: 123112 RVA: 0x00909880 File Offset: 0x00907A80
		public unsafe UObject PressedEffectDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_PressedEffectDA);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PianoKey_C.__PropertyOffset_PressedEffectDA, value);
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0601E0E9 RID: 123113 RVA: 0x00909898 File Offset: 0x00907A98
		// (set) Token: 0x0601E0EA RID: 123114 RVA: 0x009098D1 File Offset: 0x00907AD1
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> MaterialInstanceArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MaterialInstanceArray) == null)
				{
					result = (this._MaterialInstanceArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_MaterialInstanceArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MaterialInstanceArray.CopyAssign(value);
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0601E0EB RID: 123115 RVA: 0x009098DF File Offset: 0x00907ADF
		// (set) Token: 0x0601E0EC RID: 123116 RVA: 0x009098F3 File Offset: 0x00907AF3
		public unsafe FVector EffectSlotLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_EffectSlotLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_EffectSlotLocation) = value;
			}
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0601E0ED RID: 123117 RVA: 0x00909908 File Offset: 0x00907B08
		// (set) Token: 0x0601E0EE RID: 123118 RVA: 0x00909918 File Offset: 0x00907B18
		public unsafe bool PressByBullet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_PressByBullet) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PianoKey_C.__PropertyOffset_PressByBullet) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E0EF RID: 123119 RVA: 0x00909929 File Offset: 0x00907B29
		[SkipLocalsInit]
		public virtual void Tick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__Tick_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F0 RID: 123120 RVA: 0x0090993D File Offset: 0x00907B3D
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F1 RID: 123121 RVA: 0x00909951 File Offset: 0x00907B51
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PianoKey_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F2 RID: 123122 RVA: 0x00909965 File Offset: 0x00907B65
		[SkipLocalsInit]
		public virtual void PressKey_Animation__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__PressKey_Animation__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F3 RID: 123123 RVA: 0x00909979 File Offset: 0x00907B79
		[SkipLocalsInit]
		public virtual void PressKey_Animation__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__PressKey_Animation__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F4 RID: 123124 RVA: 0x0090998D File Offset: 0x00907B8D
		[SkipLocalsInit]
		public virtual void PressKey_Material__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__PressKey_Material__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F5 RID: 123125 RVA: 0x009099A1 File Offset: 0x00907BA1
		[SkipLocalsInit]
		public virtual void PressKey_Material__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__PressKey_Material__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F6 RID: 123126 RVA: 0x009099B5 File Offset: 0x00907BB5
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F7 RID: 123127 RVA: 0x009099C9 File Offset: 0x00907BC9
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PianoKey_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0F8 RID: 123128 RVA: 0x009099E0 File Offset: 0x00907BE0
		[SkipLocalsInit]
		public unsafe virtual void BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E0F9 RID: 123129 RVA: 0x00909A9C File Offset: 0x00907C9C
		[SkipLocalsInit]
		public unsafe virtual void BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E0FA RID: 123130 RVA: 0x00909B25 File Offset: 0x00907D25
		[SkipLocalsInit]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x0601E0FB RID: 123131 RVA: 0x00909B3C File Offset: 0x00907D3C
		[SkipLocalsInit]
		public unsafe virtual void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_PianoKey_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_PianoKey_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_PianoKey_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PianoKey_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PianoKey_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E0FC RID: 123132 RVA: 0x00909B90 File Offset: 0x00907D90
		[SkipLocalsInit]
		protected unsafe virtual void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_PianoKey_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_PianoKey_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_PianoKey_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PianoKey_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PianoKey_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E0FD RID: 123133 RVA: 0x00909BE2 File Offset: 0x00907DE2
		protected BP_PianoKey_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE1A RID: 65050
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x0400FE1B RID: 65051
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoKey.BP_PianoKey_C";

		// Token: 0x0400FE1C RID: 65052
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE1D RID: 65053
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE1E RID: 65054
		public static IntPtr __EventDispatcher__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FE1F RID: 65055
		internal static int __PropertyOffset_Effect_Slot;

		// Token: 0x0400FE20 RID: 65056
		internal static int __PropertyOffset_BoxCollision;

		// Token: 0x0400FE21 RID: 65057
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400FE22 RID: 65058
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FE23 RID: 65059
		internal static int __PropertyOffset_PressKey_Material;

		// Token: 0x0400FE24 RID: 65060
		internal static int __PropertyOffset_PressKey_Animation;

		// Token: 0x0400FE25 RID: 65061
		internal static int __PropertyOffset_IsPressed;

		// Token: 0x0400FE26 RID: 65062
		internal static int __PropertyOffset_KeyMesh;

		// Token: 0x0400FE27 RID: 65063
		internal static int __PropertyOffset_CollisionExtent;

		// Token: 0x0400FE28 RID: 65064
		internal static int __PropertyOffset_CollisionLocation;

		// Token: 0x0400FE29 RID: 65065
		internal static int __PropertyOffset_CollisionRotator;

		// Token: 0x0400FE2A RID: 65066
		internal static int __PropertyOffset_IsPressing;

		// Token: 0x0400FE2B RID: 65067
		internal static int __PropertyOffset_CurrentRotator;

		// Token: 0x0400FE2C RID: 65068
		internal static int __PropertyOffset_PressedEffectDA;

		// Token: 0x0400FE2D RID: 65069
		internal static int __PropertyOffset_MaterialInstanceArray;

		// Token: 0x0400FE2E RID: 65070
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MaterialInstanceArray;

		// Token: 0x0400FE2F RID: 65071
		internal static int __PropertyOffset_EffectSlotLocation;

		// Token: 0x0400FE30 RID: 65072
		internal static int __PropertyOffset_PressByBullet;

		// Token: 0x0400FE31 RID: 65073
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0400FE32 RID: 65074
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FE33 RID: 65075
		private static IntPtr __PressKey_Animation__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0400FE34 RID: 65076
		private static IntPtr __PressKey_Animation__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0400FE35 RID: 65077
		private static IntPtr __PressKey_Material__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0400FE36 RID: 65078
		private static IntPtr __PressKey_Material__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0400FE37 RID: 65079
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE38 RID: 65080
		private static IntPtr __BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FE39 RID: 65081
		private static IntPtr __BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400FE3A RID: 65082
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x0400FE3B RID: 65083
		private static IntPtr __OnBulletHit_NativeFunctionPtr;

		// Token: 0x02008E01 RID: 36353
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0402CA29 RID: 182825
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402CA2A RID: 182826
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402CA2B RID: 182827
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402CA2C RID: 182828
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0402CA2D RID: 182829
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0402CA2E RID: 182830
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02008E02 RID: 36354
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_PianoKeyBase_BoxCollision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0402CA2F RID: 182831
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0402CA30 RID: 182832
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0402CA31 RID: 182833
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0402CA32 RID: 182834
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02008E03 RID: 36355
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x0402CA33 RID: 182835
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x0402CA34 RID: 182836
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}
	}
}
