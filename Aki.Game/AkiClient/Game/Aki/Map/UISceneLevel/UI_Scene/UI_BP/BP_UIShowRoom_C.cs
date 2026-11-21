using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Map.UISceneLevel.UI_Scene.UI_BP
{
	// Token: 0x02003147 RID: 12615
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Map/UISceneLevel/UI_Scene/UI_BP/BP_UIShowRoom.BP_UIShowRoom_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class BP_UIShowRoom_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F046 RID: 127046 RVA: 0x00924248 File Offset: 0x00922448
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UIShowRoom_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Map/UISceneLevel/UI_Scene/UI_BP/BP_UIShowRoom.BP_UIShowRoom_C");
			}
			return BP_UIShowRoom_C._ClassPtr;
		}

		// Token: 0x0601F047 RID: 127047 RVA: 0x0092426C File Offset: 0x0092246C
		public BP_UIShowRoom_C() : this(BuiltinUtils.AllocNativeUObject(BP_UIShowRoom_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F048 RID: 127048 RVA: 0x00924294 File Offset: 0x00922494
		[NullableContext(1)]
		public BP_UIShowRoom_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UIShowRoom_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0601F049 RID: 127049 RVA: 0x009242C7 File Offset: 0x009224C7
		// (set) Token: 0x0601F04A RID: 127050 RVA: 0x009242DB File Offset: 0x009224DB
		public unsafe UStaticMeshComponent SM_MilkyWay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_SM_MilkyWay);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_SM_MilkyWay, value);
			}
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0601F04B RID: 127051 RVA: 0x009242F0 File Offset: 0x009224F0
		// (set) Token: 0x0601F04C RID: 127052 RVA: 0x00924304 File Offset: 0x00922504
		public unsafe UStaticMeshComponent SkyMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_SkyMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_SkyMesh, value);
			}
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0601F04D RID: 127053 RVA: 0x00924319 File Offset: 0x00922519
		// (set) Token: 0x0601F04E RID: 127054 RVA: 0x0092432D File Offset: 0x0092252D
		public unsafe UPlanarReflectionComponent PlanarReflection
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPlanarReflectionComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_PlanarReflection);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_PlanarReflection, value);
			}
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0601F04F RID: 127055 RVA: 0x00924342 File Offset: 0x00922542
		// (set) Token: 0x0601F050 RID: 127056 RVA: 0x00924356 File Offset: 0x00922556
		public unsafe UStaticMeshComponent FloorMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_FloorMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_FloorMesh, value);
			}
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0601F051 RID: 127057 RVA: 0x0092436B File Offset: 0x0092256B
		// (set) Token: 0x0601F052 RID: 127058 RVA: 0x0092437F File Offset: 0x0092257F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0601F053 RID: 127059 RVA: 0x00924394 File Offset: 0x00922594
		// (set) Token: 0x0601F054 RID: 127060 RVA: 0x009243A8 File Offset: 0x009225A8
		public unsafe UMaterialInterface MilkyWayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_MilkyWayMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_MilkyWayMaterial, value);
			}
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0601F055 RID: 127061 RVA: 0x009243BD File Offset: 0x009225BD
		// (set) Token: 0x0601F056 RID: 127062 RVA: 0x009243D1 File Offset: 0x009225D1
		public unsafe FRotator MilkyWayRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_MilkyWayRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_MilkyWayRotation) = value;
			}
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0601F057 RID: 127063 RVA: 0x009243E6 File Offset: 0x009225E6
		// (set) Token: 0x0601F058 RID: 127064 RVA: 0x009243FA File Offset: 0x009225FA
		public unsafe UMaterialInterface SkyMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_SkyMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_SkyMaterial, value);
			}
		}

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0601F059 RID: 127065 RVA: 0x0092440F File Offset: 0x0092260F
		// (set) Token: 0x0601F05A RID: 127066 RVA: 0x00924423 File Offset: 0x00922623
		public unsafe UMaterialInterface FloorMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_FloorMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_FloorMaterial, value);
			}
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0601F05B RID: 127067 RVA: 0x00924438 File Offset: 0x00922638
		// (set) Token: 0x0601F05C RID: 127068 RVA: 0x0092444C File Offset: 0x0092264C
		public unsafe UMaterialInstanceDynamic SkyMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_SkyMID);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIShowRoom_C.__PropertyOffset_SkyMID, value);
			}
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0601F05D RID: 127069 RVA: 0x00924461 File Offset: 0x00922661
		// (set) Token: 0x0601F05E RID: 127070 RVA: 0x00924471 File Offset: 0x00922671
		public unsafe bool bShowMilkyWay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_bShowMilkyWay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_bShowMilkyWay) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0601F05F RID: 127071 RVA: 0x00924482 File Offset: 0x00922682
		// (set) Token: 0x0601F060 RID: 127072 RVA: 0x00924492 File Offset: 0x00922692
		public unsafe bool bShowSky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_bShowSky) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_bShowSky) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0601F061 RID: 127073 RVA: 0x009244A3 File Offset: 0x009226A3
		// (set) Token: 0x0601F062 RID: 127074 RVA: 0x009244B3 File Offset: 0x009226B3
		public unsafe bool bShowFloor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_bShowFloor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_bShowFloor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0601F063 RID: 127075 RVA: 0x009244C4 File Offset: 0x009226C4
		// (set) Token: 0x0601F064 RID: 127076 RVA: 0x009244FD File Offset: 0x009226FD
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
					result = (this._ShowActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_UIShowRoom_C.__PropertyOffset_ShowActors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ShowActors.CopyAssign(value);
			}
		}

		// Token: 0x0601F065 RID: 127077 RVA: 0x0092450C File Offset: 0x0092270C
		[SkipLocalsInit]
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

		// Token: 0x0601F066 RID: 127078 RVA: 0x00924578 File Offset: 0x00922778
		[SkipLocalsInit]
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

		// Token: 0x0601F067 RID: 127079 RVA: 0x009245E3 File Offset: 0x009227E3
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIShowRoom_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F068 RID: 127080 RVA: 0x009245F7 File Offset: 0x009227F7
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIShowRoom_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F069 RID: 127081 RVA: 0x0092460C File Offset: 0x0092280C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_UIShowRoom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIShowRoom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIShowRoom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F06A RID: 127082 RVA: 0x00924654 File Offset: 0x00922854
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_UIShowRoom_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIShowRoom_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIShowRoom_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F06B RID: 127083 RVA: 0x0092469C File Offset: 0x0092289C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_UIShowRoom_C.__EditorTick_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIShowRoom_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIShowRoom_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F06C RID: 127084 RVA: 0x009246E4 File Offset: 0x009228E4
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_UIShowRoom_C.__EditorTick_FunctionParams* ptr = stackalloc BP_UIShowRoom_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_UIShowRoom_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_UIShowRoom_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIShowRoom_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F06D RID: 127085 RVA: 0x0092472A File Offset: 0x0092292A
		protected BP_UIShowRoom_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010912 RID: 67858
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Map/UISceneLevel/UI_Scene/UI_BP/BP_UIShowRoom.BP_UIShowRoom_C";

		// Token: 0x04010913 RID: 67859
		private static IntPtr _ClassPtr;

		// Token: 0x04010914 RID: 67860
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010915 RID: 67861
		internal static int __PropertyOffset_SM_MilkyWay;

		// Token: 0x04010916 RID: 67862
		internal static int __PropertyOffset_SkyMesh;

		// Token: 0x04010917 RID: 67863
		internal static int __PropertyOffset_PlanarReflection;

		// Token: 0x04010918 RID: 67864
		internal static int __PropertyOffset_FloorMesh;

		// Token: 0x04010919 RID: 67865
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401091A RID: 67866
		internal static int __PropertyOffset_MilkyWayMaterial;

		// Token: 0x0401091B RID: 67867
		internal static int __PropertyOffset_MilkyWayRotation;

		// Token: 0x0401091C RID: 67868
		internal static int __PropertyOffset_SkyMaterial;

		// Token: 0x0401091D RID: 67869
		internal static int __PropertyOffset_FloorMaterial;

		// Token: 0x0401091E RID: 67870
		internal static int __PropertyOffset_SkyMID;

		// Token: 0x0401091F RID: 67871
		internal static int __PropertyOffset_bShowMilkyWay;

		// Token: 0x04010920 RID: 67872
		internal static int __PropertyOffset_bShowSky;

		// Token: 0x04010921 RID: 67873
		internal static int __PropertyOffset_bShowFloor;

		// Token: 0x04010922 RID: 67874
		internal static int __PropertyOffset_ShowActors;

		// Token: 0x04010923 RID: 67875
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ShowActors;

		// Token: 0x04010924 RID: 67876
		private static IntPtr __RemoveShowActor_NativeFunctionPtr;

		// Token: 0x04010925 RID: 67877
		private static IntPtr __AddShowActor_NativeFunctionPtr;

		// Token: 0x04010926 RID: 67878
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010927 RID: 67879
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010928 RID: 67880
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008F12 RID: 36626
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveShowActor_FunctionParams
		{
			// Token: 0x0402CC3F RID: 183359
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0402CC40 RID: 183360
			[FieldOffset(8)]
			public bool IncludefromChildActors;
		}

		// Token: 0x02008F13 RID: 36627
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AddShowActor_FunctionParams
		{
			// Token: 0x0402CC41 RID: 183361
			[FieldOffset(0)]
			public IntPtr Actor;

			// Token: 0x0402CC42 RID: 183362
			[FieldOffset(8)]
			public bool IncludefromChildActors;
		}

		// Token: 0x02008F14 RID: 36628
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CC43 RID: 183363
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008F15 RID: 36629
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CC44 RID: 183364
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
