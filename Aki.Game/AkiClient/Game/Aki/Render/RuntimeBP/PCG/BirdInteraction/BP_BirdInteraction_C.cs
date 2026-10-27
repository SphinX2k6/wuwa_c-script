using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BirdInteraction
{
	// Token: 0x02003CD1 RID: 15569
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BirdInteraction/BP_BirdInteraction.BP_BirdInteraction_C")]
	[UnrealStructLayout(2032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class BP_BirdInteraction_C : AKuroBirdInteraction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E93 RID: 151187 RVA: 0x0094BD24 File Offset: 0x00949F24
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BirdInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BirdInteraction/BP_BirdInteraction.BP_BirdInteraction_C");
			}
			return BP_BirdInteraction_C._ClassPtr;
		}

		// Token: 0x06024E94 RID: 151188 RVA: 0x0094BD48 File Offset: 0x00949F48
		public BP_BirdInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_BirdInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E95 RID: 151189 RVA: 0x0094BD70 File Offset: 0x00949F70
		[NullableContext(1)]
		public BP_BirdInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BirdInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024E96 RID: 151190 RVA: 0x0094BDA3 File Offset: 0x00949FA3
		protected BP_BirdInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125A2 RID: 75170
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BirdInteraction/BP_BirdInteraction.BP_BirdInteraction_C";

		// Token: 0x040125A3 RID: 75171
		private static IntPtr _ClassPtr;

		// Token: 0x040125A4 RID: 75172
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
