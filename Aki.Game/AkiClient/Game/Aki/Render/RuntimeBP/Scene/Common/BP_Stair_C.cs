using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B64 RID: 15204
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/BP_Stair.BP_Stair_C")]
	[UnrealStructLayout(1888, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1880)]
	public class BP_Stair_C : AKuroStair, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C1C RID: 138268 RVA: 0x008F50DD File Offset: 0x008F32DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Stair_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_Stair.BP_Stair_C");
			}
			return BP_Stair_C._ClassPtr;
		}

		// Token: 0x06021C1D RID: 138269 RVA: 0x008F5104 File Offset: 0x008F3304
		public BP_Stair_C() : this(BuiltinUtils.AllocNativeUObject(BP_Stair_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C1E RID: 138270 RVA: 0x008F512C File Offset: 0x008F332C
		[NullableContext(1)]
		public BP_Stair_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Stair_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x06021C1F RID: 138271 RVA: 0x008F515F File Offset: 0x008F335F
		// (set) Token: 0x06021C20 RID: 138272 RVA: 0x008F5173 File Offset: 0x008F3373
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Stair_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Stair_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021C21 RID: 138273 RVA: 0x008F5188 File Offset: 0x008F3388
		protected BP_Stair_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107A0 RID: 67488
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/BP_Stair.BP_Stair_C";

		// Token: 0x040107A1 RID: 67489
		private static IntPtr _ClassPtr;

		// Token: 0x040107A2 RID: 67490
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040107A3 RID: 67491
		internal static int __PropertyOffset_0;
	}
}
