using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.LifePlay
{
	// Token: 0x02003B35 RID: 15157
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/LifePlay/BP_SceneLifePlay.BP_SceneLifePlay_C")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1609)]
	public class BP_SceneLifePlay_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602182F RID: 137263 RVA: 0x008EE49C File Offset: 0x008EC69C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneLifePlay_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/LifePlay/BP_SceneLifePlay.BP_SceneLifePlay_C");
			}
			return BP_SceneLifePlay_C._ClassPtr;
		}

		// Token: 0x06021830 RID: 137264 RVA: 0x008EE4C0 File Offset: 0x008EC6C0
		public BP_SceneLifePlay_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneLifePlay_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021831 RID: 137265 RVA: 0x008EE4E8 File Offset: 0x008EC6E8
		[NullableContext(1)]
		public BP_SceneLifePlay_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneLifePlay_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x06021832 RID: 137266 RVA: 0x008EE51B File Offset: 0x008EC71B
		// (set) Token: 0x06021833 RID: 137267 RVA: 0x008EE52F File Offset: 0x008EC72F
		public unsafe UTextRenderComponent TextRender
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x06021834 RID: 137268 RVA: 0x008EE544 File Offset: 0x008EC744
		// (set) Token: 0x06021835 RID: 137269 RVA: 0x008EE558 File Offset: 0x008EC758
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x06021836 RID: 137270 RVA: 0x008EE56D File Offset: 0x008EC76D
		// (set) Token: 0x06021837 RID: 137271 RVA: 0x008EE581 File Offset: 0x008EC781
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x06021838 RID: 137272 RVA: 0x008EE596 File Offset: 0x008EC796
		// (set) Token: 0x06021839 RID: 137273 RVA: 0x008EE5AA File Offset: 0x008EC7AA
		public unsafe UMaterialInstanceDynamic ShapeDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0602183A RID: 137274 RVA: 0x008EE5BF File Offset: 0x008EC7BF
		// (set) Token: 0x0602183B RID: 137275 RVA: 0x008EE5CF File Offset: 0x008EC7CF
		public unsafe bool Open_LifePlay_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0602183C RID: 137276 RVA: 0x008EE5E0 File Offset: 0x008EC7E0
		// (set) Token: 0x0602183D RID: 137277 RVA: 0x008EE5F4 File Offset: 0x008EC7F4
		public unsafe UMaterialInstanceDynamic ShapeDMI_ES3_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0602183E RID: 137278 RVA: 0x008EE609 File Offset: 0x008EC809
		// (set) Token: 0x0602183F RID: 137279 RVA: 0x008EE61D File Offset: 0x008EC81D
		public unsafe FLinearColor Set_ParameterCollection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x06021840 RID: 137280 RVA: 0x008EE632 File Offset: 0x008EC832
		// (set) Token: 0x06021841 RID: 137281 RVA: 0x008EE646 File Offset: 0x008EC846
		public unsafe UStaticMesh LifePlay_Sphere_Back
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x06021842 RID: 137282 RVA: 0x008EE65B File Offset: 0x008EC85B
		// (set) Token: 0x06021843 RID: 137283 RVA: 0x008EE66B File Offset: 0x008EC86B
		public unsafe float OuterRing_ShapeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x06021844 RID: 137284 RVA: 0x008EE67C File Offset: 0x008EC87C
		// (set) Token: 0x06021845 RID: 137285 RVA: 0x008EE68C File Offset: 0x008EC88C
		public unsafe float InternalRing_ColorChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x06021846 RID: 137286 RVA: 0x008EE69D File Offset: 0x008EC89D
		// (set) Token: 0x06021847 RID: 137287 RVA: 0x008EE6AD File Offset: 0x008EC8AD
		public unsafe float PlantGrowRing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x06021848 RID: 137288 RVA: 0x008EE6BE File Offset: 0x008EC8BE
		// (set) Token: 0x06021849 RID: 137289 RVA: 0x008EE6CE File Offset: 0x008EC8CE
		public unsafe float Leaf_Grow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0602184A RID: 137290 RVA: 0x008EE6DF File Offset: 0x008EC8DF
		// (set) Token: 0x0602184B RID: 137291 RVA: 0x008EE6F3 File Offset: 0x008EC8F3
		public unsafe FLinearColor SceneColorOverlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0602184C RID: 137292 RVA: 0x008EE708 File Offset: 0x008EC908
		// (set) Token: 0x0602184D RID: 137293 RVA: 0x008EE71C File Offset: 0x008EC91C
		public unsafe UStaticMesh LifePlay_Sphere_Fornt
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0602184E RID: 137294 RVA: 0x008EE731 File Offset: 0x008EC931
		// (set) Token: 0x0602184F RID: 137295 RVA: 0x008EE745 File Offset: 0x008EC945
		public unsafe FVectorDouble WorldCameraLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x06021850 RID: 137296 RVA: 0x008EE75A File Offset: 0x008EC95A
		// (set) Token: 0x06021851 RID: 137297 RVA: 0x008EE76A File Offset: 0x008EC96A
		public unsafe bool Is_ES3_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x06021852 RID: 137298 RVA: 0x008EE77B File Offset: 0x008EC97B
		// (set) Token: 0x06021853 RID: 137299 RVA: 0x008EE78F File Offset: 0x008EC98F
		public unsafe UMaterialInstance MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneLifePlay_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x06021854 RID: 137300 RVA: 0x008EE7A4 File Offset: 0x008EC9A4
		// (set) Token: 0x06021855 RID: 137301 RVA: 0x008EE7B4 File Offset: 0x008EC9B4
		public unsafe bool Unused_Fogging
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneLifePlay_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021856 RID: 137302 RVA: 0x008EE7C5 File Offset: 0x008EC9C5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Is_ES3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLifePlay_C.__Is_ES3_NativeFunctionPtr, null);
		}

		// Token: 0x06021857 RID: 137303 RVA: 0x008EE7D9 File Offset: 0x008EC9D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_MaterialInstance()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLifePlay_C.__Set_MaterialInstance_NativeFunctionPtr, null);
		}

		// Token: 0x06021858 RID: 137304 RVA: 0x008EE7ED File Offset: 0x008EC9ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Life_Play_Parameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLifePlay_C.__Set_Life_Play_Parameter_NativeFunctionPtr, null);
		}

		// Token: 0x06021859 RID: 137305 RVA: 0x008EE801 File Offset: 0x008ECA01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLifePlay_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602185A RID: 137306 RVA: 0x008EE815 File Offset: 0x008ECA15
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLifePlay_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602185B RID: 137307 RVA: 0x008EE82A File Offset: 0x008ECA2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLifePlay_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602185C RID: 137308 RVA: 0x008EE83E File Offset: 0x008ECA3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLifePlay_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602185D RID: 137309 RVA: 0x008EE854 File Offset: 0x008ECA54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SceneLifePlay_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneLifePlay_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneLifePlay_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLifePlay_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLifePlay_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602185E RID: 137310 RVA: 0x008EE89C File Offset: 0x008ECA9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SceneLifePlay_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneLifePlay_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneLifePlay_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLifePlay_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLifePlay_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602185F RID: 137311 RVA: 0x008EE8E4 File Offset: 0x008ECAE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SceneLifePlay_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneLifePlay_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneLifePlay_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLifePlay_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneLifePlay_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021860 RID: 137312 RVA: 0x008EE92C File Offset: 0x008ECB2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SceneLifePlay_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneLifePlay_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneLifePlay_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneLifePlay_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneLifePlay_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021861 RID: 137313 RVA: 0x008EE973 File Offset: 0x008ECB73
		protected BP_SceneLifePlay_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010547 RID: 66887
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/LifePlay/BP_SceneLifePlay.BP_SceneLifePlay_C";

		// Token: 0x04010548 RID: 66888
		private static IntPtr _ClassPtr;

		// Token: 0x04010549 RID: 66889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401054A RID: 66890
		internal static int __PropertyOffset_1;

		// Token: 0x0401054B RID: 66891
		internal static int __PropertyOffset_2;

		// Token: 0x0401054C RID: 66892
		internal static int __PropertyOffset_3;

		// Token: 0x0401054D RID: 66893
		internal static int __PropertyOffset_4;

		// Token: 0x0401054E RID: 66894
		internal static int __PropertyOffset_5;

		// Token: 0x0401054F RID: 66895
		internal static int __PropertyOffset_6;

		// Token: 0x04010550 RID: 66896
		internal static int __PropertyOffset_7;

		// Token: 0x04010551 RID: 66897
		internal static int __PropertyOffset_8;

		// Token: 0x04010552 RID: 66898
		internal static int __PropertyOffset_9;

		// Token: 0x04010553 RID: 66899
		internal static int __PropertyOffset_10;

		// Token: 0x04010554 RID: 66900
		internal static int __PropertyOffset_11;

		// Token: 0x04010555 RID: 66901
		internal static int __PropertyOffset_12;

		// Token: 0x04010556 RID: 66902
		internal static int __PropertyOffset_13;

		// Token: 0x04010557 RID: 66903
		internal static int __PropertyOffset_14;

		// Token: 0x04010558 RID: 66904
		internal static int __PropertyOffset_15;

		// Token: 0x04010559 RID: 66905
		internal static int __PropertyOffset_16;

		// Token: 0x0401055A RID: 66906
		internal static int __PropertyOffset_17;

		// Token: 0x0401055B RID: 66907
		internal static int __PropertyOffset_18;

		// Token: 0x0401055C RID: 66908
		private static IntPtr __Is_ES3_NativeFunctionPtr;

		// Token: 0x0401055D RID: 66909
		private static IntPtr __Set_MaterialInstance_NativeFunctionPtr;

		// Token: 0x0401055E RID: 66910
		private static IntPtr __Set_Life_Play_Parameter_NativeFunctionPtr;

		// Token: 0x0401055F RID: 66911
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010560 RID: 66912
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010561 RID: 66913
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010562 RID: 66914
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C9D RID: 40093
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031362 RID: 201570
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C9E RID: 40094
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031363 RID: 201571
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
