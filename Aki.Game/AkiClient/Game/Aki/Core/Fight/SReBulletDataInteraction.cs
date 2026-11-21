using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x02003274 RID: 12916
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SReBulletDataInteraction.SReBulletDataInteraction")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SReBulletDataInteraction : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602042F RID: 132143 RVA: 0x009414E8 File Offset: 0x0093F6E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReBulletDataInteraction._ScriptStructPtr != 0) ? SReBulletDataInteraction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SReBulletDataInteraction.SReBulletDataInteraction", ref SReBulletDataInteraction._ScriptStructPtr);
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x06020430 RID: 132144 RVA: 0x0094150C File Offset: 0x0093F70C
		// (set) Token: 0x06020431 RID: 132145 RVA: 0x0094152B File Offset: 0x0093F72B
		public TSoftObjectPtr<BP_SceneBattleInteract_C> 场景物件交互
		{
			get
			{
				return new TSoftObjectPtr<BP_SceneBattleInteract_C>(base.NativePtr + (IntPtr)SReBulletDataInteraction.__PropertyOffset_场景物件交互, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReBulletDataInteraction.__PropertyOffset_场景物件交互, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06020432 RID: 132146 RVA: 0x00941550 File Offset: 0x0093F750
		public SReBulletDataInteraction()
		{
		}

		// Token: 0x06020433 RID: 132147 RVA: 0x00941558 File Offset: 0x0093F758
		protected override IntPtr GetUStructPtr()
		{
			return SReBulletDataInteraction.StaticStruct();
		}

		// Token: 0x06020434 RID: 132148 RVA: 0x00941564 File Offset: 0x0093F764
		[NullableContext(2)]
		public SReBulletDataInteraction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020435 RID: 132149 RVA: 0x0094156E File Offset: 0x0093F76E
		public SReBulletDataInteraction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020436 RID: 132150 RVA: 0x00941579 File Offset: 0x0093F779
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReBulletDataInteraction(Pointer, false, true);
		}

		// Token: 0x06020437 RID: 132151 RVA: 0x00941583 File Offset: 0x0093F783
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReBulletDataInteraction(Pointer, MemoryOwner);
		}

		// Token: 0x040116A6 RID: 71334
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SReBulletDataInteraction.SReBulletDataInteraction";

		// Token: 0x040116A7 RID: 71335
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040116A8 RID: 71336
		internal static int __PropertyOffset_场景物件交互;
	}
}
