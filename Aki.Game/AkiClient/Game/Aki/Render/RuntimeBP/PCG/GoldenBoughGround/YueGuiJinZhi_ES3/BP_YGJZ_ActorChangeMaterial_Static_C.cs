using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GoldenBoughGround.YueGuiJinZhi_ES3
{
	// Token: 0x02003CC0 RID: 15552
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GoldenBoughGround/YueGuiJinZhi_ES3/BP_YGJZ_ActorChangeMaterial_Static.BP_YGJZ_ActorChangeMaterial_Static_C")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class BP_YGJZ_ActorChangeMaterial_Static_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024C08 RID: 150536 RVA: 0x00947590 File Offset: 0x00945790
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_YGJZ_ActorChangeMaterial_Static_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GoldenBoughGround/YueGuiJinZhi_ES3/BP_YGJZ_ActorChangeMaterial_Static.BP_YGJZ_ActorChangeMaterial_Static_C");
			}
			return BP_YGJZ_ActorChangeMaterial_Static_C._ClassPtr;
		}

		// Token: 0x06024C09 RID: 150537 RVA: 0x009475B4 File Offset: 0x009457B4
		public BP_YGJZ_ActorChangeMaterial_Static_C() : this(BuiltinUtils.AllocNativeUObject(BP_YGJZ_ActorChangeMaterial_Static_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024C0A RID: 150538 RVA: 0x009475DC File Offset: 0x009457DC
		[NullableContext(1)]
		public BP_YGJZ_ActorChangeMaterial_Static_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_YGJZ_ActorChangeMaterial_Static_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048E7 RID: 18663
		// (get) Token: 0x06024C0B RID: 150539 RVA: 0x0094760F File Offset: 0x0094580F
		// (set) Token: 0x06024C0C RID: 150540 RVA: 0x0094761F File Offset: 0x0094581F
		public unsafe bool Is_Android
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x06024C0D RID: 150541 RVA: 0x00947630 File Offset: 0x00945830
		// (set) Token: 0x06024C0E RID: 150542 RVA: 0x00947644 File Offset: 0x00945844
		public unsafe UMaterialInstance StaticMesh_ShuGan
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x06024C0F RID: 150543 RVA: 0x00947659 File Offset: 0x00945859
		// (set) Token: 0x06024C10 RID: 150544 RVA: 0x0094766D File Offset: 0x0094586D
		public unsafe UMaterialInstance StaticMesh_ShuZhi
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x06024C11 RID: 150545 RVA: 0x00947682 File Offset: 0x00945882
		// (set) Token: 0x06024C12 RID: 150546 RVA: 0x00947696 File Offset: 0x00945896
		public unsafe UMaterialInstance StaticMesh_ShuZhi_LOD1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x06024C13 RID: 150547 RVA: 0x009476AB File Offset: 0x009458AB
		// (set) Token: 0x06024C14 RID: 150548 RVA: 0x009476BF File Offset: 0x009458BF
		public unsafe UMaterialInstance StaticMesh_ShuGan_LOD1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YGJZ_ActorChangeMaterial_Static_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x06024C15 RID: 150549 RVA: 0x009476D4 File Offset: 0x009458D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Is_ES3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YGJZ_ActorChangeMaterial_Static_C.__Is_ES3_NativeFunctionPtr, null);
		}

		// Token: 0x06024C16 RID: 150550 RVA: 0x009476E8 File Offset: 0x009458E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YGJZ_ActorChangeMaterial_Static_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024C17 RID: 150551 RVA: 0x009476FC File Offset: 0x009458FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_YGJZ_ActorChangeMaterial_Static_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024C18 RID: 150552 RVA: 0x00947711 File Offset: 0x00945911
		protected BP_YGJZ_ActorChangeMaterial_Static_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012425 RID: 74789
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GoldenBoughGround/YueGuiJinZhi_ES3/BP_YGJZ_ActorChangeMaterial_Static.BP_YGJZ_ActorChangeMaterial_Static_C";

		// Token: 0x04012426 RID: 74790
		private static IntPtr _ClassPtr;

		// Token: 0x04012427 RID: 74791
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012428 RID: 74792
		internal static int __PropertyOffset_1;

		// Token: 0x04012429 RID: 74793
		internal static int __PropertyOffset_2;

		// Token: 0x0401242A RID: 74794
		internal static int __PropertyOffset_3;

		// Token: 0x0401242B RID: 74795
		internal static int __PropertyOffset_4;

		// Token: 0x0401242C RID: 74796
		internal static int __PropertyOffset_5;

		// Token: 0x0401242D RID: 74797
		private static IntPtr __Is_ES3_NativeFunctionPtr;

		// Token: 0x0401242E RID: 74798
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
