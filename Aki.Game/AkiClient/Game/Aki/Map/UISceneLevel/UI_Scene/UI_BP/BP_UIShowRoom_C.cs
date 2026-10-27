using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Map.UISceneLevel.UI_Scene.UI_BP
{
	// Token: 0x02003E4B RID: 15947
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Map/UISceneLevel/UI_Scene/UI_BP/BP_UIShowRoom.BP_UIShowRoom_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class BP_UIShowRoom_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028157 RID: 164183 RVA: 0x009A37DC File Offset: 0x009A19DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UIShowRoom_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Map/UISceneLevel/UI_Scene/UI_BP/BP_UIShowRoom.BP_UIShowRoom_C");
			}
			return BP_UIShowRoom_C._ClassPtr;
		}

		// Token: 0x06028158 RID: 164184 RVA: 0x009A3800 File Offset: 0x009A1A00
		public BP_UIShowRoom_C() : this(BuiltinUtils.AllocNativeUObject(BP_UIShowRoom_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028159 RID: 164185 RVA: 0x009A3828 File Offset: 0x009A1A28
		[NullableContext(1)]
		public BP_UIShowRoom_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UIShowRoom_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BAD RID: 23469
		// (get) Token: 0x0602815A RID: 164186 RVA: 0x009A385B File Offset: 0x009A1A5B
		// (set) Token: 0x0602815B RID: 164187 RVA: 0x009A386F File Offset: 0x009A1A6F
		public unsafe UStaticMeshComponent SM_MilkyWay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005BAE RID: 23470
		// (get) Token: 0x0602815C RID: 164188 RVA: 0x009A3884 File Offset: 0x009A1A84
		// (set) Token: 0x0602815D RID: 164189 RVA: 0x009A3898 File Offset: 0x009A1A98
		public unsafe UStaticMeshComponent SkyMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005BAF RID: 23471
		// (get) Token: 0x0602815E RID: 164190 RVA: 0x009A38AD File Offset: 0x009A1AAD
		// (set) Token: 0x0602815F RID: 164191 RVA: 0x009A38C1 File Offset: 0x009A1AC1
		public unsafe UPlanarReflectionComponent PlanarReflection
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPlanarReflectionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005BB0 RID: 23472
		// (get) Token: 0x06028160 RID: 164192 RVA: 0x009A38D6 File Offset: 0x009A1AD6
		// (set) Token: 0x06028161 RID: 164193 RVA: 0x009A38EA File Offset: 0x009A1AEA
		public unsafe UStaticMeshComponent FloorMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005BB1 RID: 23473
		// (get) Token: 0x06028162 RID: 164194 RVA: 0x009A38FF File Offset: 0x009A1AFF
		// (set) Token: 0x06028163 RID: 164195 RVA: 0x009A3913 File Offset: 0x009A1B13
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005BB2 RID: 23474
		// (get) Token: 0x06028164 RID: 164196 RVA: 0x009A3928 File Offset: 0x009A1B28
		// (set) Token: 0x06028165 RID: 164197 RVA: 0x009A393C File Offset: 0x009A1B3C
		public unsafe UMaterialInterface MilkyWayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17005BB3 RID: 23475
		// (get) Token: 0x06028166 RID: 164198 RVA: 0x009A3951 File Offset: 0x009A1B51
		// (set) Token: 0x06028167 RID: 164199 RVA: 0x009A3965 File Offset: 0x009A1B65
		public unsafe FRotator MilkyWayRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005BB4 RID: 23476
		// (get) Token: 0x06028168 RID: 164200 RVA: 0x009A397A File Offset: 0x009A1B7A
		// (set) Token: 0x06028169 RID: 164201 RVA: 0x009A398E File Offset: 0x009A1B8E
		public unsafe UMaterialInterface SkyMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005BB5 RID: 23477
		// (get) Token: 0x0602816A RID: 164202 RVA: 0x009A39A3 File Offset: 0x009A1BA3
		// (set) Token: 0x0602816B RID: 164203 RVA: 0x009A39B7 File Offset: 0x009A1BB7
		public unsafe UMaterialInterface FloorMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17005BB6 RID: 23478
		// (get) Token: 0x0602816C RID: 164204 RVA: 0x009A39CC File Offset: 0x009A1BCC
		// (set) Token: 0x0602816D RID: 164205 RVA: 0x009A39E0 File Offset: 0x009A1BE0
		public unsafe UMaterialInstanceDynamic SkyMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17005BB7 RID: 23479
		// (get) Token: 0x0602816E RID: 164206 RVA: 0x009A39F5 File Offset: 0x009A1BF5
		// (set) Token: 0x0602816F RID: 164207 RVA: 0x009A3A05 File Offset: 0x009A1C05
		public unsafe bool bShowMilkyWay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BB8 RID: 23480
		// (get) Token: 0x06028170 RID: 164208 RVA: 0x009A3A16 File Offset: 0x009A1C16
		// (set) Token: 0x06028171 RID: 164209 RVA: 0x009A3A26 File Offset: 0x009A1C26
		public unsafe bool bShowSky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BB9 RID: 23481
		// (get) Token: 0x06028172 RID: 164210 RVA: 0x009A3A37 File Offset: 0x009A1C37
		// (set) Token: 0x06028173 RID: 164211 RVA: 0x009A3A47 File Offset: 0x009A1C47
		public unsafe bool bShowFloor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005BBA RID: 23482
		// (get) Token: 0x06028174 RID: 164212 RVA: 0x009A3A58 File Offset: 0x009A1C58
		// (set) Token: 0x06028175 RID: 164213 RVA: 0x009A3A91 File Offset: 0x009A1C91
		[Nullable(1)]
		public TArray<AActor> ShowActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ShowActors) == null)
				{
					result = (this._ShowActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ShowActors.CopyAssign(value);
			}
		}

		// Token: 0x06028176 RID: 164214 RVA: 0x009A3AA0 File Offset: 0x009A1CA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RemoveShowActor(ref AActor Actor, bool IncludefromChildActors)
		{
			BP_UIShowRoom_C.__RemoveShowActor_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__RemoveShowActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_UIShowRoom_C.__RemoveShowActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__RemoveShowActor_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_UIShowRoom_C.__RemoveShowActor_FunctionParams ptr2 = ref *ptr;
			AActor aactor = Actor;
			ptr2.Actor = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			ptr->IncludefromChildActors = IncludefromChildActors;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIShowRoom_C.__RemoveShowActor_NativeFunctionPtr, (void*)ptr);
			Actor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->Actor);
		}

		// Token: 0x06028177 RID: 164215 RVA: 0x009A3B0C File Offset: 0x009A1D0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddShowActor(ref AActor Actor, bool IncludefromChildActors)
		{
			BP_UIShowRoom_C.__AddShowActor_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__AddShowActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_UIShowRoom_C.__AddShowActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__AddShowActor_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_UIShowRoom_C.__AddShowActor_FunctionParams ptr2 = ref *ptr;
			AActor aactor = Actor;
			ptr2.Actor = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			ptr->IncludefromChildActors = IncludefromChildActors;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIShowRoom_C.__AddShowActor_NativeFunctionPtr, (void*)ptr);
			Actor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->Actor);
		}

		// Token: 0x06028178 RID: 164216 RVA: 0x009A3B77 File Offset: 0x009A1D77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIShowRoom_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06028179 RID: 164217 RVA: 0x009A3B8B File Offset: 0x009A1D8B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIShowRoom_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602817A RID: 164218 RVA: 0x009A3BA0 File Offset: 0x009A1DA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_UIShowRoom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIShowRoom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIShowRoom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602817B RID: 164219 RVA: 0x009A3BE8 File Offset: 0x009A1DE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_UIShowRoom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIShowRoom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIShowRoom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602817C RID: 164220 RVA: 0x009A3C30 File Offset: 0x009A1E30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_UIShowRoom_C.__EditorTick_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIShowRoom_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIShowRoom_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602817D RID: 164221 RVA: 0x009A3C78 File Offset: 0x009A1E78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_UIShowRoom_C.__EditorTick_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIShowRoom_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIShowRoom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602817E RID: 164222 RVA: 0x009A3CBF File Offset: 0x009A1EBF
		protected BP_UIShowRoom_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014640 RID: 83520
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Map/UISceneLevel/UI_Scene/UI_BP/BP_UIShowRoom.BP_UIShowRoom_C";

		// Token: 0x04014641 RID: 83521
		private static IntPtr _ClassPtr;

		// Token: 0x04014642 RID: 83522
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014643 RID: 83523
		internal static int __PropertyOffset_1;

		// Token: 0x04014644 RID: 83524
		internal static int __PropertyOffset_2;

		// Token: 0x04014645 RID: 83525
		internal static int __PropertyOffset_3;

		// Token: 0x04014646 RID: 83526
		internal static int __PropertyOffset_4;

		// Token: 0x04014647 RID: 83527
		internal static int __PropertyOffset_5;

		// Token: 0x04014648 RID: 83528
		internal static int __PropertyOffset_6;

		// Token: 0x04014649 RID: 83529
		internal static int __PropertyOffset_7;

		// Token: 0x0401464A RID: 83530
		internal static int __PropertyOffset_8;

		// Token: 0x0401464B RID: 83531
		internal static int __PropertyOffset_9;

		// Token: 0x0401464C RID: 83532
		internal static int __PropertyOffset_10;

		// Token: 0x0401464D RID: 83533
		internal static int __PropertyOffset_11;

		// Token: 0x0401464E RID: 83534
		internal static int __PropertyOffset_12;

		// Token: 0x0401464F RID: 83535
		internal static int __PropertyOffset_13;

		// Token: 0x04014650 RID: 83536
		internal static int __PropertyOffset_14;

		// Token: 0x04014651 RID: 83537
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ShowActors;

		// Token: 0x04014652 RID: 83538
		private static IntPtr __RemoveShowActor_NativeFunctionPtr;

		// Token: 0x04014653 RID: 83539
		private static IntPtr __AddShowActor_NativeFunctionPtr;

		// Token: 0x04014654 RID: 83540
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04014655 RID: 83541
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04014656 RID: 83542
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A2BE RID: 41662
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveShowActor_FunctionParams
		{
			// Token: 0x04031FFB RID: 204795
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04031FFC RID: 204796
			[FieldOffset(8)]
			public bool IncludefromChildActors;
		}

		// Token: 0x0200A2BF RID: 41663
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AddShowActor_FunctionParams
		{
			// Token: 0x04031FFD RID: 204797
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x04031FFE RID: 204798
			[FieldOffset(8)]
			public bool IncludefromChildActors;
		}

		// Token: 0x0200A2C0 RID: 41664
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FFF RID: 204799
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2C1 RID: 41665
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04032000 RID: 204800
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
