using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003067 RID: 12391
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/PD_HolographicEffect.PD_HolographicEffect_C")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 290)]
	public class PD_HolographicEffect_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D713 RID: 120595 RVA: 0x008F6AC7 File Offset: 0x008F4CC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_HolographicEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/PD_HolographicEffect.PD_HolographicEffect_C");
			}
			return PD_HolographicEffect_C._ClassPtr;
		}

		// Token: 0x0601D714 RID: 120596 RVA: 0x008F6AEC File Offset: 0x008F4CEC
		public PD_HolographicEffect_C() : this(BuiltinUtils.AllocNativeUObject(PD_HolographicEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D715 RID: 120597 RVA: 0x008F6B14 File Offset: 0x008F4D14
		[NullableContext(1)]
		public PD_HolographicEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_HolographicEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x0601D716 RID: 120598 RVA: 0x008F6B47 File Offset: 0x008F4D47
		// (set) Token: 0x0601D717 RID: 120599 RVA: 0x008F6B57 File Offset: 0x008F4D57
		public unsafe float Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x0601D718 RID: 120600 RVA: 0x008F6B68 File Offset: 0x008F4D68
		// (set) Token: 0x0601D719 RID: 120601 RVA: 0x008F6B78 File Offset: 0x008F4D78
		public unsafe float Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_Loop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_Loop) = value;
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x0601D71A RID: 120602 RVA: 0x008F6B89 File Offset: 0x008F4D89
		// (set) Token: 0x0601D71B RID: 120603 RVA: 0x008F6B99 File Offset: 0x008F4D99
		public unsafe float End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0601D71C RID: 120604 RVA: 0x008F6BAA File Offset: 0x008F4DAA
		// (set) Token: 0x0601D71D RID: 120605 RVA: 0x008F6BBA File Offset: 0x008F4DBA
		public unsafe bool CanSkipLoopUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_CanSkipLoopUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_CanSkipLoopUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0601D71E RID: 120606 RVA: 0x008F6BCB File Offset: 0x008F4DCB
		// (set) Token: 0x0601D71F RID: 120607 RVA: 0x008F6BDB File Offset: 0x008F4DDB
		public unsafe bool ExtraUpdateOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_ExtraUpdateOnStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HolographicEffect_C.__PropertyOffset_ExtraUpdateOnStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D720 RID: 120608 RVA: 0x008F6BEC File Offset: 0x008F4DEC
		protected PD_HolographicEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7F4 RID: 63476
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/PD_HolographicEffect.PD_HolographicEffect_C";

		// Token: 0x0400F7F5 RID: 63477
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7F6 RID: 63478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7F7 RID: 63479
		internal static int __PropertyOffset_Start;

		// Token: 0x0400F7F8 RID: 63480
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400F7F9 RID: 63481
		internal static int __PropertyOffset_End;

		// Token: 0x0400F7FA RID: 63482
		internal static int __PropertyOffset_CanSkipLoopUpdate;

		// Token: 0x0400F7FB RID: 63483
		internal static int __PropertyOffset_ExtraUpdateOnStart;
	}
}
