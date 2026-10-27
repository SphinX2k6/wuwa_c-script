using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FD7 RID: 16343
	[UnrealObjectPath("/Game/Aki/Core/BP_MainGameState.BP_MainGameState_C")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1176)]
	public class BP_MainGameState_C : AGameState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029DBC RID: 171452 RVA: 0x009CE071 File Offset: 0x009CC271
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MainGameState_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/BP_MainGameState.BP_MainGameState_C");
			}
			return BP_MainGameState_C._ClassPtr;
		}

		// Token: 0x06029DBD RID: 171453 RVA: 0x009CE098 File Offset: 0x009CC298
		public BP_MainGameState_C() : this(BuiltinUtils.AllocNativeUObject(BP_MainGameState_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029DBE RID: 171454 RVA: 0x009CE0C0 File Offset: 0x009CC2C0
		[NullableContext(1)]
		public BP_MainGameState_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MainGameState_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006596 RID: 26006
		// (get) Token: 0x06029DBF RID: 171455 RVA: 0x009CE0F3 File Offset: 0x009CC2F3
		// (set) Token: 0x06029DC0 RID: 171456 RVA: 0x009CE107 File Offset: 0x009CC307
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MainGameState_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MainGameState_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06029DC1 RID: 171457 RVA: 0x009CE11C File Offset: 0x009CC31C
		protected BP_MainGameState_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157EB RID: 88043
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Core/BP_MainGameState.BP_MainGameState_C";

		// Token: 0x040157EC RID: 88044
		private static IntPtr _ClassPtr;

		// Token: 0x040157ED RID: 88045
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157EE RID: 88046
		internal static int __PropertyOffset_0;
	}
}
