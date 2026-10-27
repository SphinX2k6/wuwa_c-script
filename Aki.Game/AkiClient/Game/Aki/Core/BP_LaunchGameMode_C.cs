using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FD6 RID: 16342
	[UnrealObjectPath("/Game/Aki/Core/BP_LaunchGameMode.BP_LaunchGameMode_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class BP_LaunchGameMode_C : AGameModeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029DB6 RID: 171446 RVA: 0x009CDFBE File Offset: 0x009CC1BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LaunchGameMode_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_LaunchGameMode.BP_LaunchGameMode_C");
			}
			return BP_LaunchGameMode_C._ClassPtr;
		}

		// Token: 0x06029DB7 RID: 171447 RVA: 0x009CDFE4 File Offset: 0x009CC1E4
		public BP_LaunchGameMode_C() : this(BuiltinUtils.AllocNativeUObject(BP_LaunchGameMode_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029DB8 RID: 171448 RVA: 0x009CE00C File Offset: 0x009CC20C
		[NullableContext(1)]
		public BP_LaunchGameMode_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LaunchGameMode_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006595 RID: 26005
		// (get) Token: 0x06029DB9 RID: 171449 RVA: 0x009CE03F File Offset: 0x009CC23F
		// (set) Token: 0x06029DBA RID: 171450 RVA: 0x009CE053 File Offset: 0x009CC253
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LaunchGameMode_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LaunchGameMode_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06029DBB RID: 171451 RVA: 0x009CE068 File Offset: 0x009CC268
		protected BP_LaunchGameMode_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157E7 RID: 88039
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_LaunchGameMode.BP_LaunchGameMode_C";

		// Token: 0x040157E8 RID: 88040
		private static IntPtr _ClassPtr;

		// Token: 0x040157E9 RID: 88041
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157EA RID: 88042
		internal static int __PropertyOffset_0;
	}
}
