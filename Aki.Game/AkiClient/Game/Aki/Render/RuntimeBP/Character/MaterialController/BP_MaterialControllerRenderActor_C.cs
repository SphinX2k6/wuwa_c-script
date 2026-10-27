using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E0D RID: 15885
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_MaterialControllerRenderActor.BP_MaterialControllerRenderActor_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_MaterialControllerRenderActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027CC6 RID: 163014 RVA: 0x0099B75A File Offset: 0x0099995A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MaterialControllerRenderActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_MaterialControllerRenderActor.BP_MaterialControllerRenderActor_C");
			}
			return BP_MaterialControllerRenderActor_C._ClassPtr;
		}

		// Token: 0x06027CC7 RID: 163015 RVA: 0x0099B780 File Offset: 0x00999980
		public BP_MaterialControllerRenderActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_MaterialControllerRenderActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027CC8 RID: 163016 RVA: 0x0099B7A8 File Offset: 0x009999A8
		[NullableContext(1)]
		public BP_MaterialControllerRenderActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MaterialControllerRenderActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005A1D RID: 23069
		// (get) Token: 0x06027CC9 RID: 163017 RVA: 0x0099B7DB File Offset: 0x009999DB
		// (set) Token: 0x06027CCA RID: 163018 RVA: 0x0099B7EF File Offset: 0x009999EF
		public unsafe CharRenderingComponent CharRenderingComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<CharRenderingComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005A1E RID: 23070
		// (get) Token: 0x06027CCB RID: 163019 RVA: 0x0099B804 File Offset: 0x00999A04
		// (set) Token: 0x06027CCC RID: 163020 RVA: 0x0099B818 File Offset: 0x00999A18
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005A1F RID: 23071
		// (get) Token: 0x06027CCD RID: 163021 RVA: 0x0099B82D File Offset: 0x00999A2D
		// (set) Token: 0x06027CCE RID: 163022 RVA: 0x0099B841 File Offset: 0x00999A41
		public unsafe AActor RefActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MaterialControllerRenderActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06027CCF RID: 163023 RVA: 0x0099B856 File Offset: 0x00999A56
		protected BP_MaterialControllerRenderActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401426C RID: 82540
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_MaterialControllerRenderActor.BP_MaterialControllerRenderActor_C";

		// Token: 0x0401426D RID: 82541
		private static IntPtr _ClassPtr;

		// Token: 0x0401426E RID: 82542
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401426F RID: 82543
		internal static int __PropertyOffset_0;

		// Token: 0x04014270 RID: 82544
		internal static int __PropertyOffset_1;

		// Token: 0x04014271 RID: 82545
		internal static int __PropertyOffset_2;
	}
}
