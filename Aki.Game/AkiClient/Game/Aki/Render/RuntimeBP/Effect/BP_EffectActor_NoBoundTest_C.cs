using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect
{
	// Token: 0x02003DB6 RID: 15798
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor_NoBoundTest.BP_EffectActor_NoBoundTest_C")]
	[UnrealStructLayout(1360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1355)]
	public class BP_EffectActor_NoBoundTest_C : BP_EffectActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027452 RID: 160850 RVA: 0x0098CDAF File Offset: 0x0098AFAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectActor_NoBoundTest_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor_NoBoundTest.BP_EffectActor_NoBoundTest_C");
			}
			return BP_EffectActor_NoBoundTest_C._ClassPtr;
		}

		// Token: 0x06027453 RID: 160851 RVA: 0x0098CDD4 File Offset: 0x0098AFD4
		public BP_EffectActor_NoBoundTest_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectActor_NoBoundTest_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027454 RID: 160852 RVA: 0x0098CDFC File Offset: 0x0098AFFC
		[NullableContext(1)]
		public BP_EffectActor_NoBoundTest_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectActor_NoBoundTest_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027455 RID: 160853 RVA: 0x0098CE2F File Offset: 0x0098B02F
		protected BP_EffectActor_NoBoundTest_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013D06 RID: 81158
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectActor_NoBoundTest.BP_EffectActor_NoBoundTest_C";

		// Token: 0x04013D07 RID: 81159
		private static IntPtr _ClassPtr;

		// Token: 0x04013D08 RID: 81160
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
