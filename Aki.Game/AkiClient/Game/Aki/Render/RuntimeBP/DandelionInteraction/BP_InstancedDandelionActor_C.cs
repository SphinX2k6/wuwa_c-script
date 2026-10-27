using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.DandelionInteraction
{
	// Token: 0x02003DE8 RID: 15848
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_InstancedDandelionActor.BP_InstancedDandelionActor_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_InstancedDandelionActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278AE RID: 161966 RVA: 0x00994423 File Offset: 0x00992623
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InstancedDandelionActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_InstancedDandelionActor.BP_InstancedDandelionActor_C");
			}
			return BP_InstancedDandelionActor_C._ClassPtr;
		}

		// Token: 0x060278AF RID: 161967 RVA: 0x00994448 File Offset: 0x00992648
		public BP_InstancedDandelionActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_InstancedDandelionActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278B0 RID: 161968 RVA: 0x00994470 File Offset: 0x00992670
		[NullableContext(1)]
		public BP_InstancedDandelionActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InstancedDandelionActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058AF RID: 22703
		// (get) Token: 0x060278B1 RID: 161969 RVA: 0x009944A3 File Offset: 0x009926A3
		// (set) Token: 0x060278B2 RID: 161970 RVA: 0x009944B7 File Offset: 0x009926B7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InstancedDandelionActor_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InstancedDandelionActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x060278B3 RID: 161971 RVA: 0x009944CC File Offset: 0x009926CC
		protected BP_InstancedDandelionActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013FE6 RID: 81894
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/DandelionInteraction/BP_InstancedDandelionActor.BP_InstancedDandelionActor_C";

		// Token: 0x04013FE7 RID: 81895
		private static IntPtr _ClassPtr;

		// Token: 0x04013FE8 RID: 81896
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013FE9 RID: 81897
		internal static int __PropertyOffset_0;
	}
}
