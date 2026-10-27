using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor.RuntimeData;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor
{
	// Token: 0x02003C35 RID: 15413
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_3_6.BP_PhysicsActor_3_6_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class BP_PhysicsActor_3_6_C : AKuroPhysicActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023738 RID: 145208 RVA: 0x00924314 File Offset: 0x00922514
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsActor_3_6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_3_6.BP_PhysicsActor_3_6_C");
			}
			return BP_PhysicsActor_3_6_C._ClassPtr;
		}

		// Token: 0x06023739 RID: 145209 RVA: 0x00924338 File Offset: 0x00922538
		public BP_PhysicsActor_3_6_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_3_6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602373A RID: 145210 RVA: 0x00924360 File Offset: 0x00922560
		public BP_PhysicsActor_3_6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_3_6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x0602373B RID: 145211 RVA: 0x00924393 File Offset: 0x00922593
		// (set) Token: 0x0602373C RID: 145212 RVA: 0x009243A7 File Offset: 0x009225A7
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_3_6_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_3_6_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x0602373D RID: 145213 RVA: 0x009243BC File Offset: 0x009225BC
		// (set) Token: 0x0602373E RID: 145214 RVA: 0x009243D0 File Offset: 0x009225D0
		[Nullable(2)]
		public unsafe UDataTable DT_PhysicalAudio
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_3_6_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_3_6_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x0602373F RID: 145215 RVA: 0x009243E8 File Offset: 0x009225E8
		// (set) Token: 0x06023740 RID: 145216 RVA: 0x00924421 File Offset: 0x00922621
		public TArray<S_PhysicalAudio> PhysicalAudioArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<S_PhysicalAudio> result;
				if ((result = this._PhysicalAudioArray) == null)
				{
					result = (this._PhysicalAudioArray = new TArray<S_PhysicalAudio>(base.NativePtr + (IntPtr)BP_PhysicsActor_3_6_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.PhysicalAudioArray.CopyAssign(value);
			}
		}

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x06023741 RID: 145217 RVA: 0x00924430 File Offset: 0x00922630
		// (set) Token: 0x06023742 RID: 145218 RVA: 0x00924469 File Offset: 0x00922669
		public S_PhysicalAudio PhysicalAudioDefault
		{
			get
			{
				base.FastCheckIsValid();
				S_PhysicalAudio result;
				if ((result = this._PhysicalAudioDefault) == null)
				{
					result = (this._PhysicalAudioDefault = new S_PhysicalAudio(base.NativePtr + (IntPtr)BP_PhysicsActor_3_6_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(S_PhysicalAudio.StaticStruct(), base.NativePtr + (IntPtr)BP_PhysicsActor_3_6_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x06023743 RID: 145219 RVA: 0x0092448C File Offset: 0x0092268C
		// (set) Token: 0x06023744 RID: 145220 RVA: 0x009244C5 File Offset: 0x009226C5
		public S_PhysicalAudio CurrentPhysicalAudio
		{
			get
			{
				base.FastCheckIsValid();
				S_PhysicalAudio result;
				if ((result = this._CurrentPhysicalAudio) == null)
				{
					result = (this._CurrentPhysicalAudio = new S_PhysicalAudio(base.NativePtr + (IntPtr)BP_PhysicsActor_3_6_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(S_PhysicalAudio.StaticStruct(), base.NativePtr + (IntPtr)BP_PhysicsActor_3_6_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023745 RID: 145221 RVA: 0x009244E6 File Offset: 0x009226E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Physics_Audio_Table()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__Physics_Audio_Table_NativeFunctionPtr, null);
		}

		// Token: 0x06023746 RID: 145222 RVA: 0x009244FC File Offset: 0x009226FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_3AEBD3224C7D32CC3C79A8B855CA6F69(int PlayingID)
		{
			BP_PhysicsActor_3_6_C.__Completed_3AEBD3224C7D32CC3C79A8B855CA6F69_FunctionParams* ptr = stackalloc BP_PhysicsActor_3_6_C.__Completed_3AEBD3224C7D32CC3C79A8B855CA6F69_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicsActor_3_6_C.__Completed_3AEBD3224C7D32CC3C79A8B855CA6F69_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicsActor_3_6_C.__Completed_3AEBD3224C7D32CC3C79A8B855CA6F69_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__Completed_3AEBD3224C7D32CC3C79A8B855CA6F69_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023747 RID: 145223 RVA: 0x00924542 File Offset: 0x00922742
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06023748 RID: 145224 RVA: 0x00924556 File Offset: 0x00922756
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023749 RID: 145225 RVA: 0x0092456B File Offset: 0x0092276B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x0602374A RID: 145226 RVA: 0x0092457F File Offset: 0x0092277F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602374B RID: 145227 RVA: 0x00924594 File Offset: 0x00922794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602374C RID: 145228 RVA: 0x009245A8 File Offset: 0x009227A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602374D RID: 145229 RVA: 0x009245C0 File Offset: 0x009227C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_PhysicsActor_3_6_StaticMesh_0_K2Node_ComponentBoundEvent_0_ComponentHitSignature__DelegateSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			BP_PhysicsActor_3_6_C.__BndEvt__BP_PhysicsActor_3_6_StaticMesh_0_K2Node_ComponentBoundEvent_0_ComponentHitSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_PhysicsActor_3_6_C.__BndEvt__BP_PhysicsActor_3_6_StaticMesh_0_K2Node_ComponentBoundEvent_0_ComponentHitSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_PhysicsActor_3_6_C.__BndEvt__BP_PhysicsActor_3_6_StaticMesh_0_K2Node_ComponentBoundEvent_0_ComponentHitSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicsActor_3_6_C.__BndEvt__BP_PhysicsActor_3_6_StaticMesh_0_K2Node_ComponentBoundEvent_0_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicsActor_3_6_C.__BndEvt__BP_PhysicsActor_3_6_StaticMesh_0_K2Node_ComponentBoundEvent_0_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602374E RID: 145230 RVA: 0x00924672 File Offset: 0x00922872
		protected BP_PhysicsActor_3_6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117FA RID: 71674
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_3_6.BP_PhysicsActor_3_6_C";

		// Token: 0x040117FB RID: 71675
		private static IntPtr _ClassPtr;

		// Token: 0x040117FC RID: 71676
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117FD RID: 71677
		internal static int __PropertyOffset_1;

		// Token: 0x040117FE RID: 71678
		internal static int __PropertyOffset_2;

		// Token: 0x040117FF RID: 71679
		internal static int __PropertyOffset_3;

		// Token: 0x04011800 RID: 71680
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<S_PhysicalAudio> _PhysicalAudioArray;

		// Token: 0x04011801 RID: 71681
		internal static int __PropertyOffset_4;

		// Token: 0x04011802 RID: 71682
		[Nullable(2)]
		private S_PhysicalAudio _PhysicalAudioDefault;

		// Token: 0x04011803 RID: 71683
		internal static int __PropertyOffset_5;

		// Token: 0x04011804 RID: 71684
		[Nullable(2)]
		private S_PhysicalAudio _CurrentPhysicalAudio;

		// Token: 0x04011805 RID: 71685
		private static IntPtr __Physics_Audio_Table_NativeFunctionPtr;

		// Token: 0x04011806 RID: 71686
		private static IntPtr __Completed_3AEBD3224C7D32CC3C79A8B855CA6F69_NativeFunctionPtr;

		// Token: 0x04011807 RID: 71687
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x04011808 RID: 71688
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x04011809 RID: 71689
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401180A RID: 71690
		private static IntPtr __BndEvt__BP_PhysicsActor_3_6_StaticMesh_0_K2Node_ComponentBoundEvent_0_ComponentHitSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E6E RID: 40558
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_3AEBD3224C7D32CC3C79A8B855CA6F69_FunctionParams
		{
			// Token: 0x040316F4 RID: 202484
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009E6F RID: 40559
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_PhysicsActor_3_6_StaticMesh_0_K2Node_ComponentBoundEvent_0_ComponentHitSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040316F5 RID: 202485
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x040316F6 RID: 202486
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040316F7 RID: 202487
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040316F8 RID: 202488
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x040316F9 RID: 202489
			[FieldOffset(36)]
			public byte Hit;
		}
	}
}
