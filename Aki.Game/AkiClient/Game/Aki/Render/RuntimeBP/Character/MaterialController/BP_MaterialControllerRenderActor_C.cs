using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003125 RID: 12581
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_MaterialControllerRenderActor.BP_MaterialControllerRenderActor_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_MaterialControllerRenderActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EED5 RID: 126677 RVA: 0x00921387 File Offset: 0x0091F587
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MaterialControllerRenderActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_MaterialControllerRenderActor.BP_MaterialControllerRenderActor_C");
			}
			return BP_MaterialControllerRenderActor_C._ClassPtr;
		}

		// Token: 0x0601EED6 RID: 126678 RVA: 0x009213AC File Offset: 0x0091F5AC
		public BP_MaterialControllerRenderActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_MaterialControllerRenderActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EED7 RID: 126679 RVA: 0x009213D4 File Offset: 0x0091F5D4
		[NullableContext(1)]
		public BP_MaterialControllerRenderActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MaterialControllerRenderActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0601EED8 RID: 126680 RVA: 0x00921407 File Offset: 0x0091F607
		// (set) Token: 0x0601EED9 RID: 126681 RVA: 0x0092141B File Offset: 0x0091F61B
		public unsafe CharRenderingComponent CharRenderingComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<CharRenderingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_CharRenderingComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_CharRenderingComponent, value);
			}
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0601EEDA RID: 126682 RVA: 0x00921430 File Offset: 0x0091F630
		// (set) Token: 0x0601EEDB RID: 126683 RVA: 0x00921444 File Offset: 0x0091F644
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0601EEDC RID: 126684 RVA: 0x00921459 File Offset: 0x0091F659
		// (set) Token: 0x0601EEDD RID: 126685 RVA: 0x0092146D File Offset: 0x0091F66D
		public unsafe AActor RefActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_RefActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_RefActor, value);
			}
		}

		// Token: 0x0601EEDE RID: 126686 RVA: 0x00921482 File Offset: 0x0091F682
		protected BP_MaterialControllerRenderActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010717 RID: 67351
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_MaterialControllerRenderActor.BP_MaterialControllerRenderActor_C";

		// Token: 0x04010718 RID: 67352
		private static IntPtr _ClassPtr;

		// Token: 0x04010719 RID: 67353
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401071A RID: 67354
		internal static int __PropertyOffset_CharRenderingComponent;

		// Token: 0x0401071B RID: 67355
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401071C RID: 67356
		internal static int __PropertyOffset_RefActor;
	}
}
