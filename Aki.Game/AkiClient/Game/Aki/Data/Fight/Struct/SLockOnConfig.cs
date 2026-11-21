using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x0200320A RID: 12810
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnConfig.SLockOnConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SLockOnConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FE7D RID: 130685 RVA: 0x00938B4D File Offset: 0x00936D4D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnConfig._ScriptStructPtr != 0) ? SLockOnConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnConfig.SLockOnConfig", ref SLockOnConfig._ScriptStructPtr);
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0601FE7E RID: 130686 RVA: 0x00938B71 File Offset: 0x00936D71
		// (set) Token: 0x0601FE7F RID: 130687 RVA: 0x00938B81 File Offset: 0x00936D81
		public unsafe bool IsOpened
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_IsOpened) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_IsOpened) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0601FE80 RID: 130688 RVA: 0x00938B92 File Offset: 0x00936D92
		// (set) Token: 0x0601FE81 RID: 130689 RVA: 0x00938BA2 File Offset: 0x00936DA2
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0601FE82 RID: 130690 RVA: 0x00938BB3 File Offset: 0x00936DB3
		// (set) Token: 0x0601FE83 RID: 130691 RVA: 0x00938BC3 File Offset: 0x00936DC3
		public unsafe float UpDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_UpDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_UpDistance) = value;
			}
		}

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0601FE84 RID: 130692 RVA: 0x00938BD4 File Offset: 0x00936DD4
		// (set) Token: 0x0601FE85 RID: 130693 RVA: 0x00938BE4 File Offset: 0x00936DE4
		public unsafe float DownDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_DownDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnConfig.__PropertyOffset_DownDistance) = value;
			}
		}

		// Token: 0x0601FE86 RID: 130694 RVA: 0x00938BF5 File Offset: 0x00936DF5
		public SLockOnConfig()
		{
		}

		// Token: 0x0601FE87 RID: 130695 RVA: 0x00938BFD File Offset: 0x00936DFD
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnConfig.StaticStruct();
		}

		// Token: 0x0601FE88 RID: 130696 RVA: 0x00938C09 File Offset: 0x00936E09
		[NullableContext(2)]
		public SLockOnConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE89 RID: 130697 RVA: 0x00938C13 File Offset: 0x00936E13
		public SLockOnConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE8A RID: 130698 RVA: 0x00938C1E File Offset: 0x00936E1E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnConfig(Pointer, false, true);
		}

		// Token: 0x0601FE8B RID: 130699 RVA: 0x00938C28 File Offset: 0x00936E28
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04011227 RID: 70183
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnConfig.SLockOnConfig";

		// Token: 0x04011228 RID: 70184
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011229 RID: 70185
		internal static int __PropertyOffset_IsOpened;

		// Token: 0x0401122A RID: 70186
		internal static int __PropertyOffset_Distance;

		// Token: 0x0401122B RID: 70187
		internal static int __PropertyOffset_UpDistance;

		// Token: 0x0401122C RID: 70188
		internal static int __PropertyOffset_DownDistance;
	}
}
