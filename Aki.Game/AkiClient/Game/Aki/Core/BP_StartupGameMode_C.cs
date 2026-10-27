using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FDA RID: 16346
	[UnrealObjectPath("/Game/Aki/Core/BP_StartupGameMode.BP_StartupGameMode_C")]
	[UnrealStructLayout(1296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1296)]
	public class BP_StartupGameMode_C : AGameMode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029DD2 RID: 171474 RVA: 0x009CE322 File Offset: 0x009CC522
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StartupGameMode_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_StartupGameMode.BP_StartupGameMode_C");
			}
			return BP_StartupGameMode_C._ClassPtr;
		}

		// Token: 0x06029DD3 RID: 171475 RVA: 0x009CE348 File Offset: 0x009CC548
		public BP_StartupGameMode_C() : this(BuiltinUtils.AllocNativeUObject(BP_StartupGameMode_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029DD4 RID: 171476 RVA: 0x009CE370 File Offset: 0x009CC570
		[NullableContext(1)]
		public BP_StartupGameMode_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StartupGameMode_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700659A RID: 26010
		// (get) Token: 0x06029DD5 RID: 171477 RVA: 0x009CE3A3 File Offset: 0x009CC5A3
		// (set) Token: 0x06029DD6 RID: 171478 RVA: 0x009CE3B7 File Offset: 0x009CC5B7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StartupGameMode_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StartupGameMode_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06029DD7 RID: 171479 RVA: 0x009CE3CC File Offset: 0x009CC5CC
		protected BP_StartupGameMode_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157FB RID: 88059
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_StartupGameMode.BP_StartupGameMode_C";

		// Token: 0x040157FC RID: 88060
		private static IntPtr _ClassPtr;

		// Token: 0x040157FD RID: 88061
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157FE RID: 88062
		internal static int __PropertyOffset_0;
	}
}
