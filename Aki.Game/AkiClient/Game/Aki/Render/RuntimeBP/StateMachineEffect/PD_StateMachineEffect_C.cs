using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x020030AC RID: 12460
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/PD_StateMachineEffect.PD_StateMachineEffect_C")]
	[UnrealStructLayout(1824, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1824)]
	public class PD_StateMachineEffect_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE08 RID: 122376 RVA: 0x00904903 File Offset: 0x00902B03
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_StateMachineEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/StateMachineEffect/PD_StateMachineEffect.PD_StateMachineEffect_C");
			}
			return PD_StateMachineEffect_C._ClassPtr;
		}

		// Token: 0x0601DE09 RID: 122377 RVA: 0x00904928 File Offset: 0x00902B28
		public PD_StateMachineEffect_C() : this(BuiltinUtils.AllocNativeUObject(PD_StateMachineEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE0A RID: 122378 RVA: 0x00904950 File Offset: 0x00902B50
		[NullableContext(1)]
		public PD_StateMachineEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_StateMachineEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE0B RID: 122379 RVA: 0x00904983 File Offset: 0x00902B83
		protected PD_StateMachineEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC56 RID: 64598
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/StateMachineEffect/PD_StateMachineEffect.PD_StateMachineEffect_C";

		// Token: 0x0400FC57 RID: 64599
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC58 RID: 64600
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
