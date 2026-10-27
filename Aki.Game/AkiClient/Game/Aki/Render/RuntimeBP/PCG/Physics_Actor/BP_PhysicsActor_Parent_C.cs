using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor
{
	// Token: 0x02003C38 RID: 15416
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Parent.BP_PhysicsActor_Parent_C")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class BP_PhysicsActor_Parent_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602376E RID: 145262 RVA: 0x009249AC File Offset: 0x00922BAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicsActor_Parent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Parent.BP_PhysicsActor_Parent_C");
			}
			return BP_PhysicsActor_Parent_C._ClassPtr;
		}

		// Token: 0x0602376F RID: 145263 RVA: 0x009249D0 File Offset: 0x00922BD0
		public BP_PhysicsActor_Parent_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_Parent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023770 RID: 145264 RVA: 0x009249F8 File Offset: 0x00922BF8
		[NullableContext(1)]
		public BP_PhysicsActor_Parent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicsActor_Parent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x06023771 RID: 145265 RVA: 0x00924A2B File Offset: 0x00922C2B
		// (set) Token: 0x06023772 RID: 145266 RVA: 0x00924A3F File Offset: 0x00922C3F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Parent_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicsActor_Parent_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06023773 RID: 145267 RVA: 0x00924A54 File Offset: 0x00922C54
		protected BP_PhysicsActor_Parent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401181D RID: 71709
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Physics_Actor/BP_PhysicsActor_Parent.BP_PhysicsActor_Parent_C";

		// Token: 0x0401181E RID: 71710
		private static IntPtr _ClassPtr;

		// Token: 0x0401181F RID: 71711
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011820 RID: 71712
		internal static int __PropertyOffset_0;
	}
}
