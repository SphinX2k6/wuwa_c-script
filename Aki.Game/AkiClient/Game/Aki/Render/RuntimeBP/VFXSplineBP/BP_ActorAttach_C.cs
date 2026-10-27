using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.VFXSplineBP
{
	// Token: 0x02003A8E RID: 14990
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/VFXSplineBP/BP_ActorAttach.BP_ActorAttach_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_ActorAttach_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE58 RID: 130648 RVA: 0x008C563C File Offset: 0x008C383C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ActorAttach_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/VFXSplineBP/BP_ActorAttach.BP_ActorAttach_C");
			}
			return BP_ActorAttach_C._ClassPtr;
		}

		// Token: 0x0601FE59 RID: 130649 RVA: 0x008C5660 File Offset: 0x008C3860
		public BP_ActorAttach_C() : this(BuiltinUtils.AllocNativeUObject(BP_ActorAttach_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE5A RID: 130650 RVA: 0x008C5688 File Offset: 0x008C3888
		[NullableContext(1)]
		public BP_ActorAttach_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ActorAttach_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x0601FE5B RID: 130651 RVA: 0x008C56BB File Offset: 0x008C38BB
		// (set) Token: 0x0601FE5C RID: 130652 RVA: 0x008C56CF File Offset: 0x008C38CF
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ActorAttach_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ActorAttach_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0601FE5D RID: 130653 RVA: 0x008C56E4 File Offset: 0x008C38E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetActorPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ActorAttach_C.__GetActorPosition_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE5E RID: 130654 RVA: 0x008C56F8 File Offset: 0x008C38F8
		protected BP_ActorAttach_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F619 RID: 63001
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/VFXSplineBP/BP_ActorAttach.BP_ActorAttach_C";

		// Token: 0x0400F61A RID: 63002
		private static IntPtr _ClassPtr;

		// Token: 0x0400F61B RID: 63003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F61C RID: 63004
		internal static int __PropertyOffset_0;

		// Token: 0x0400F61D RID: 63005
		private static IntPtr __GetActorPosition_NativeFunctionPtr;
	}
}
