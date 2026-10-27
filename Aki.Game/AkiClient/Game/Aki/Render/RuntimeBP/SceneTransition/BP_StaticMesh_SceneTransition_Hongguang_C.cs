using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneTransition
{
	// Token: 0x02003BAF RID: 15279
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneTransition/BP_StaticMesh_SceneTransition_Hongguang.BP_StaticMesh_SceneTransition_Hongguang_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_StaticMesh_SceneTransition_Hongguang_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221B2 RID: 139698 RVA: 0x008FF5B8 File Offset: 0x008FD7B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StaticMesh_SceneTransition_Hongguang_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneTransition/BP_StaticMesh_SceneTransition_Hongguang.BP_StaticMesh_SceneTransition_Hongguang_C");
			}
			return BP_StaticMesh_SceneTransition_Hongguang_C._ClassPtr;
		}

		// Token: 0x060221B3 RID: 139699 RVA: 0x008FF5DC File Offset: 0x008FD7DC
		public BP_StaticMesh_SceneTransition_Hongguang_C() : this(BuiltinUtils.AllocNativeUObject(BP_StaticMesh_SceneTransition_Hongguang_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221B4 RID: 139700 RVA: 0x008FF604 File Offset: 0x008FD804
		[NullableContext(1)]
		public BP_StaticMesh_SceneTransition_Hongguang_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StaticMesh_SceneTransition_Hongguang_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x060221B5 RID: 139701 RVA: 0x008FF637 File Offset: 0x008FD837
		// (set) Token: 0x060221B6 RID: 139702 RVA: 0x008FF64B File Offset: 0x008FD84B
		public unsafe UStaticMeshComponent TransitionMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_SceneTransition_Hongguang_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_SceneTransition_Hongguang_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x060221B7 RID: 139703 RVA: 0x008FF660 File Offset: 0x008FD860
		// (set) Token: 0x060221B8 RID: 139704 RVA: 0x008FF674 File Offset: 0x008FD874
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_SceneTransition_Hongguang_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_SceneTransition_Hongguang_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x060221B9 RID: 139705 RVA: 0x008FF689 File Offset: 0x008FD889
		// (set) Token: 0x060221BA RID: 139706 RVA: 0x008FF69D File Offset: 0x008FD89D
		public unsafe BP_SceneTransitionComponent_Hongguang_C BP_SceneTransitionComponent_Hongguang
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneTransitionComponent_Hongguang_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_SceneTransition_Hongguang_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StaticMesh_SceneTransition_Hongguang_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x060221BB RID: 139707 RVA: 0x008FF6B2 File Offset: 0x008FD8B2
		protected BP_StaticMesh_SceneTransition_Hongguang_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B36 RID: 68406
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneTransition/BP_StaticMesh_SceneTransition_Hongguang.BP_StaticMesh_SceneTransition_Hongguang_C";

		// Token: 0x04010B37 RID: 68407
		private static IntPtr _ClassPtr;

		// Token: 0x04010B38 RID: 68408
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B39 RID: 68409
		internal static int __PropertyOffset_0;

		// Token: 0x04010B3A RID: 68410
		internal static int __PropertyOffset_1;

		// Token: 0x04010B3B RID: 68411
		internal static int __PropertyOffset_2;
	}
}
