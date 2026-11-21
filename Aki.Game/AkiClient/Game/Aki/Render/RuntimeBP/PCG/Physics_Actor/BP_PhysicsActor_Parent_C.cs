using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor
{
	// Token: 0x020030E0 RID: 12512
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Parent.BP_PhysicsActor_Parent_C")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class BP_PhysicsActor_Parent_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E3DA RID: 123866 RVA: 0x0090EE15 File Offset: 0x0090D015
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsActor_Parent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Parent.BP_PhysicsActor_Parent_C");
			}
			return BP_PhysicsActor_Parent_C._ClassPtr;
		}

		// Token: 0x0601E3DB RID: 123867 RVA: 0x0090EE3C File Offset: 0x0090D03C
		public BP_PhysicsActor_Parent_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_Parent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E3DC RID: 123868 RVA: 0x0090EE64 File Offset: 0x0090D064
		[NullableContext(1)]
		public BP_PhysicsActor_Parent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_Parent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0601E3DD RID: 123869 RVA: 0x0090EE97 File Offset: 0x0090D097
		// (set) Token: 0x0601E3DE RID: 123870 RVA: 0x0090EEAB File Offset: 0x0090D0AB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Parent_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Parent_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601E3DF RID: 123871 RVA: 0x0090EEC0 File Offset: 0x0090D0C0
		protected BP_PhysicsActor_Parent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401000D RID: 65549
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Parent.BP_PhysicsActor_Parent_C";

		// Token: 0x0401000E RID: 65550
		private static IntPtr _ClassPtr;

		// Token: 0x0401000F RID: 65551
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010010 RID: 65552
		internal static int __PropertyOffset_DefaultSceneRoot;
	}
}
