using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F69 RID: 16233
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnConfig.SLockOnConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SLockOnConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060295F6 RID: 169462 RVA: 0x009C2A84 File Offset: 0x009C0C84
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnConfig._ScriptStructPtr != 0) ? SLockOnConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnConfig.SLockOnConfig", ref SLockOnConfig._ScriptStructPtr);
		}

		// Token: 0x170062DD RID: 25309
		// (get) Token: 0x060295F7 RID: 169463 RVA: 0x009C2AA8 File Offset: 0x009C0CA8
		// (set) Token: 0x060295F8 RID: 169464 RVA: 0x009C2AB8 File Offset: 0x009C0CB8
		public unsafe bool IsOpened
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062DE RID: 25310
		// (get) Token: 0x060295F9 RID: 169465 RVA: 0x009C2AC9 File Offset: 0x009C0CC9
		// (set) Token: 0x060295FA RID: 169466 RVA: 0x009C2AD9 File Offset: 0x009C0CD9
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170062DF RID: 25311
		// (get) Token: 0x060295FB RID: 169467 RVA: 0x009C2AEA File Offset: 0x009C0CEA
		// (set) Token: 0x060295FC RID: 169468 RVA: 0x009C2AFA File Offset: 0x009C0CFA
		public unsafe float UpDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170062E0 RID: 25312
		// (get) Token: 0x060295FD RID: 169469 RVA: 0x009C2B0B File Offset: 0x009C0D0B
		// (set) Token: 0x060295FE RID: 169470 RVA: 0x009C2B1B File Offset: 0x009C0D1B
		public unsafe float DownDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060295FF RID: 169471 RVA: 0x009C2B2C File Offset: 0x009C0D2C
		public SLockOnConfig()
		{
		}

		// Token: 0x06029600 RID: 169472 RVA: 0x009C2B34 File Offset: 0x009C0D34
		public SLockOnConfig(bool IsOpened, float Distance, float UpDistance, float DownDistance)
		{
			this.IsOpened = IsOpened;
			this.Distance = Distance;
			this.UpDistance = UpDistance;
			this.DownDistance = DownDistance;
		}

		// Token: 0x06029601 RID: 169473 RVA: 0x009C2B59 File Offset: 0x009C0D59
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnConfig.StaticStruct();
		}

		// Token: 0x06029602 RID: 169474 RVA: 0x009C2B65 File Offset: 0x009C0D65
		[NullableContext(2)]
		public SLockOnConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029603 RID: 169475 RVA: 0x009C2B6F File Offset: 0x009C0D6F
		public SLockOnConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029604 RID: 169476 RVA: 0x009C2B7A File Offset: 0x009C0D7A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnConfig(Pointer, false, true);
		}

		// Token: 0x06029605 RID: 169477 RVA: 0x009C2B84 File Offset: 0x009C0D84
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04015333 RID: 86835
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnConfig.SLockOnConfig";

		// Token: 0x04015334 RID: 86836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015335 RID: 86837
		internal static int __PropertyOffset_0;

		// Token: 0x04015336 RID: 86838
		internal static int __PropertyOffset_1;

		// Token: 0x04015337 RID: 86839
		internal static int __PropertyOffset_2;

		// Token: 0x04015338 RID: 86840
		internal static int __PropertyOffset_3;
	}
}
