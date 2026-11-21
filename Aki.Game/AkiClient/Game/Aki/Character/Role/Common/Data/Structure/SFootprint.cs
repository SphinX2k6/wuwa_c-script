using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020032A5 RID: 12965
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SFootprint.SFootprint")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 57)]
	public class SFootprint : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060209C0 RID: 133568 RVA: 0x0094ADEB File Offset: 0x00948FEB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFootprint._ScriptStructPtr != 0) ? SFootprint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SFootprint.SFootprint", ref SFootprint._ScriptStructPtr);
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x060209C1 RID: 133569 RVA: 0x0094AE0F File Offset: 0x0094900F
		// (set) Token: 0x060209C2 RID: 133570 RVA: 0x0094AE23 File Offset: 0x00949023
		public unsafe TEnumAsByte<EPhysicalSurface> SurfaceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_SurfaceType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_SurfaceType) = value;
			}
		}

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x060209C3 RID: 133571 RVA: 0x0094AE38 File Offset: 0x00949038
		// (set) Token: 0x060209C4 RID: 133572 RVA: 0x0094AE57 File Offset: 0x00949057
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_Effect, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_Effect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x060209C5 RID: 133573 RVA: 0x0094AE7C File Offset: 0x0094907C
		// (set) Token: 0x060209C6 RID: 133574 RVA: 0x0094AE8C File Offset: 0x0094908C
		public unsafe bool PriorToGlobal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_PriorToGlobal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_PriorToGlobal) = (value ? 1 : 0);
			}
		}

		// Token: 0x060209C7 RID: 133575 RVA: 0x0094AE9D File Offset: 0x0094909D
		public SFootprint()
		{
		}

		// Token: 0x060209C8 RID: 133576 RVA: 0x0094AEA5 File Offset: 0x009490A5
		protected override IntPtr GetUStructPtr()
		{
			return SFootprint.StaticStruct();
		}

		// Token: 0x060209C9 RID: 133577 RVA: 0x0094AEB1 File Offset: 0x009490B1
		[NullableContext(2)]
		public SFootprint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060209CA RID: 133578 RVA: 0x0094AEBB File Offset: 0x009490BB
		public SFootprint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060209CB RID: 133579 RVA: 0x0094AEC6 File Offset: 0x009490C6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFootprint(Pointer, false, true);
		}

		// Token: 0x060209CC RID: 133580 RVA: 0x0094AED0 File Offset: 0x009490D0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFootprint(Pointer, MemoryOwner);
		}

		// Token: 0x04011A08 RID: 72200
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SFootprint.SFootprint";

		// Token: 0x04011A09 RID: 72201
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011A0A RID: 72202
		internal static int __PropertyOffset_SurfaceType;

		// Token: 0x04011A0B RID: 72203
		internal static int __PropertyOffset_Effect;

		// Token: 0x04011A0C RID: 72204
		internal static int __PropertyOffset_PriorToGlobal;
	}
}
