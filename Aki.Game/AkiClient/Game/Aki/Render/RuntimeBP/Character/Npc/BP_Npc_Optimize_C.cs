using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003DFA RID: 15866
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/BP_Npc_Optimize.BP_Npc_Optimize_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_Npc_Optimize_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A55 RID: 162389 RVA: 0x00997638 File Offset: 0x00995838
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Npc_Optimize_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Npc/BP_Npc_Optimize.BP_Npc_Optimize_C");
			}
			return BP_Npc_Optimize_C._ClassPtr;
		}

		// Token: 0x06027A56 RID: 162390 RVA: 0x0099765C File Offset: 0x0099585C
		public BP_Npc_Optimize_C() : this(BuiltinUtils.AllocNativeUObject(BP_Npc_Optimize_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A57 RID: 162391 RVA: 0x00997684 File Offset: 0x00995884
		[NullableContext(1)]
		public BP_Npc_Optimize_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Npc_Optimize_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700592B RID: 22827
		// (get) Token: 0x06027A58 RID: 162392 RVA: 0x009976B7 File Offset: 0x009958B7
		// (set) Token: 0x06027A59 RID: 162393 RVA: 0x009976CB File Offset: 0x009958CB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Npc_Optimize_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Npc_Optimize_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06027A5A RID: 162394 RVA: 0x009976E0 File Offset: 0x009958E0
		protected BP_Npc_Optimize_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040140E4 RID: 82148
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Npc/BP_Npc_Optimize.BP_Npc_Optimize_C";

		// Token: 0x040140E5 RID: 82149
		private static IntPtr _ClassPtr;

		// Token: 0x040140E6 RID: 82150
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040140E7 RID: 82151
		internal static int __PropertyOffset_0;
	}
}
