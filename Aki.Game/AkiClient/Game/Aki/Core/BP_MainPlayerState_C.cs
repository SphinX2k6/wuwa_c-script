using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FD8 RID: 16344
	[UnrealObjectPath("/Game/Aki/Core/BP_MainPlayerState.BP_MainPlayerState_C")]
	[UnrealStructLayout(1320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1320)]
	public class BP_MainPlayerState_C : APlayerState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029DC2 RID: 171458 RVA: 0x009CE125 File Offset: 0x009CC325
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MainPlayerState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_MainPlayerState.BP_MainPlayerState_C");
			}
			return BP_MainPlayerState_C._ClassPtr;
		}

		// Token: 0x06029DC3 RID: 171459 RVA: 0x009CE14C File Offset: 0x009CC34C
		public BP_MainPlayerState_C() : this(BuiltinUtils.AllocNativeUObject(BP_MainPlayerState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029DC4 RID: 171460 RVA: 0x009CE174 File Offset: 0x009CC374
		[NullableContext(1)]
		public BP_MainPlayerState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MainPlayerState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006597 RID: 26007
		// (get) Token: 0x06029DC5 RID: 171461 RVA: 0x009CE1A7 File Offset: 0x009CC3A7
		// (set) Token: 0x06029DC6 RID: 171462 RVA: 0x009CE1BB File Offset: 0x009CC3BB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MainPlayerState_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MainPlayerState_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06029DC7 RID: 171463 RVA: 0x009CE1D0 File Offset: 0x009CC3D0
		protected BP_MainPlayerState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157EF RID: 88047
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_MainPlayerState.BP_MainPlayerState_C";

		// Token: 0x040157F0 RID: 88048
		private static IntPtr _ClassPtr;

		// Token: 0x040157F1 RID: 88049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157F2 RID: 88050
		internal static int __PropertyOffset_0;
	}
}
