using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.Render.Effect.Data
{
	// Token: 0x02003A0E RID: 14862
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class EffectModelNDC_C : UEffectModelNDC, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F293 RID: 127635 RVA: 0x008AE5A4 File Offset: 0x008AC7A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (EffectModelNDC_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C");
			}
			return EffectModelNDC_C._ClassPtr;
		}

		// Token: 0x0601F294 RID: 127636 RVA: 0x008AE5C8 File Offset: 0x008AC7C8
		public EffectModelNDC_C() : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F295 RID: 127637 RVA: 0x008AE5F0 File Offset: 0x008AC7F0
		[NullableContext(1)]
		public EffectModelNDC_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectModelNDC_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F296 RID: 127638 RVA: 0x008AE623 File Offset: 0x008AC823
		protected EffectModelNDC_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EEBE RID: 61118
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/Data/EffectModelNDC.EffectModelNDC_C";

		// Token: 0x0400EEBF RID: 61119
		private static IntPtr _ClassPtr;

		// Token: 0x0400EEC0 RID: 61120
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
