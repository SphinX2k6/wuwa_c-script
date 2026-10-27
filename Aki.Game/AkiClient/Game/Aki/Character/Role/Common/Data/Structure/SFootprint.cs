using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040B0 RID: 16560
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SFootprint.SFootprint")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 57)]
	public class SFootprint : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602AC70 RID: 175216 RVA: 0x009EB254 File Offset: 0x009E9454
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFootprint._ScriptStructPtr != 0) ? SFootprint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SFootprint.SFootprint", ref SFootprint._ScriptStructPtr);
		}

		// Token: 0x1700697B RID: 27003
		// (get) Token: 0x0602AC71 RID: 175217 RVA: 0x009EB278 File Offset: 0x009E9478
		// (set) Token: 0x0602AC72 RID: 175218 RVA: 0x009EB28C File Offset: 0x009E948C
		public unsafe TEnumAsByte<EPhysicalSurface> SurfaceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700697C RID: 27004
		// (get) Token: 0x0602AC73 RID: 175219 RVA: 0x009EB2A1 File Offset: 0x009E94A1
		// (set) Token: 0x0602AC74 RID: 175220 RVA: 0x009EB2C0 File Offset: 0x009E94C0
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700697D RID: 27005
		// (get) Token: 0x0602AC75 RID: 175221 RVA: 0x009EB2E5 File Offset: 0x009E94E5
		// (set) Token: 0x0602AC76 RID: 175222 RVA: 0x009EB2F5 File Offset: 0x009E94F5
		public unsafe bool PriorToGlobal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFootprint.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AC77 RID: 175223 RVA: 0x009EB306 File Offset: 0x009E9506
		public SFootprint()
		{
		}

		// Token: 0x0602AC78 RID: 175224 RVA: 0x009EB30E File Offset: 0x009E950E
		public SFootprint(TEnumAsByte<EPhysicalSurface> SurfaceType, [Nullable(1)] TSoftObjectPtr<UEffectModelBase> Effect, bool PriorToGlobal)
		{
			this.SurfaceType = SurfaceType;
			this.Effect = Effect;
			this.PriorToGlobal = PriorToGlobal;
		}

		// Token: 0x0602AC79 RID: 175225 RVA: 0x009EB32B File Offset: 0x009E952B
		protected override IntPtr GetUStructPtr()
		{
			return SFootprint.StaticStruct();
		}

		// Token: 0x0602AC7A RID: 175226 RVA: 0x009EB337 File Offset: 0x009E9537
		[NullableContext(2)]
		public SFootprint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602AC7B RID: 175227 RVA: 0x009EB341 File Offset: 0x009E9541
		public SFootprint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602AC7C RID: 175228 RVA: 0x009EB34C File Offset: 0x009E954C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFootprint(Pointer, false, true);
		}

		// Token: 0x0602AC7D RID: 175229 RVA: 0x009EB356 File Offset: 0x009E9556
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFootprint(Pointer, MemoryOwner);
		}

		// Token: 0x0401624B RID: 90699
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SFootprint.SFootprint";

		// Token: 0x0401624C RID: 90700
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401624D RID: 90701
		internal static int __PropertyOffset_0;

		// Token: 0x0401624E RID: 90702
		internal static int __PropertyOffset_1;

		// Token: 0x0401624F RID: 90703
		internal static int __PropertyOffset_2;
	}
}
