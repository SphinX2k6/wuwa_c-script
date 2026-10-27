using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._4_0_WaterBubble
{
	// Token: 0x02003C0B RID: 15371
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/4_0_WaterBubble/BP_WaterBubbleMesh.BP_WaterBubbleMesh_C")]
	[UnrealStructLayout(1472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1472)]
	public class BP_WaterBubbleMesh_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023158 RID: 143704 RVA: 0x0091A144 File Offset: 0x00918344
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterBubbleMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/4_0_WaterBubble/BP_WaterBubbleMesh.BP_WaterBubbleMesh_C");
			}
			return BP_WaterBubbleMesh_C._ClassPtr;
		}

		// Token: 0x06023159 RID: 143705 RVA: 0x0091A168 File Offset: 0x00918368
		public BP_WaterBubbleMesh_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterBubbleMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602315A RID: 143706 RVA: 0x0091A190 File Offset: 0x00918390
		[NullableContext(1)]
		public BP_WaterBubbleMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterBubbleMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x0602315B RID: 143707 RVA: 0x0091A1C3 File Offset: 0x009183C3
		// (set) Token: 0x0602315C RID: 143708 RVA: 0x0091A1D7 File Offset: 0x009183D7
		public unsafe UStaticMeshComponent SM_WaterBubble_Out
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBubbleMesh_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBubbleMesh_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x0602315D RID: 143709 RVA: 0x0091A1EC File Offset: 0x009183EC
		// (set) Token: 0x0602315E RID: 143710 RVA: 0x0091A200 File Offset: 0x00918400
		public unsafe UStaticMeshComponent SM_WaterBubble_Inner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBubbleMesh_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBubbleMesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x0602315F RID: 143711 RVA: 0x0091A215 File Offset: 0x00918415
		// (set) Token: 0x06023160 RID: 143712 RVA: 0x0091A229 File Offset: 0x00918429
		public unsafe UStaticMeshComponent SM_WaterBubble_Effect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBubbleMesh_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBubbleMesh_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x06023161 RID: 143713 RVA: 0x0091A23E File Offset: 0x0091843E
		// (set) Token: 0x06023162 RID: 143714 RVA: 0x0091A252 File Offset: 0x00918452
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBubbleMesh_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBubbleMesh_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x06023163 RID: 143715 RVA: 0x0091A267 File Offset: 0x00918467
		protected BP_WaterBubbleMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401147C RID: 70780
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/4_0_WaterBubble/BP_WaterBubbleMesh.BP_WaterBubbleMesh_C";

		// Token: 0x0401147D RID: 70781
		private static IntPtr _ClassPtr;

		// Token: 0x0401147E RID: 70782
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401147F RID: 70783
		internal static int __PropertyOffset_0;

		// Token: 0x04011480 RID: 70784
		internal static int __PropertyOffset_1;

		// Token: 0x04011481 RID: 70785
		internal static int __PropertyOffset_2;

		// Token: 0x04011482 RID: 70786
		internal static int __PropertyOffset_3;
	}
}
