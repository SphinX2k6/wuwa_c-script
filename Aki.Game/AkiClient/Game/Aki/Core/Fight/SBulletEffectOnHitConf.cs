using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200326E RID: 12910
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SBulletEffectOnHitConf.SBulletEffectOnHitConf")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SBulletEffectOnHitConf : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020377 RID: 131959 RVA: 0x009404E8 File Offset: 0x0093E6E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletEffectOnHitConf._ScriptStructPtr != 0) ? SBulletEffectOnHitConf._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SBulletEffectOnHitConf.SBulletEffectOnHitConf", ref SBulletEffectOnHitConf._ScriptStructPtr);
		}

		// Token: 0x17003DE4 RID: 15844
		// (get) Token: 0x06020378 RID: 131960 RVA: 0x0094050C File Offset: 0x0093E70C
		// (set) Token: 0x06020379 RID: 131961 RVA: 0x00940520 File Offset: 0x0093E720
		public unsafe TEnumAsByte<EBulletEffectOnHitType> 类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_类型) = value;
			}
		}

		// Token: 0x17003DE5 RID: 15845
		// (get) Token: 0x0602037A RID: 131962 RVA: 0x00940535 File Offset: 0x0093E735
		// (set) Token: 0x0602037B RID: 131963 RVA: 0x00940545 File Offset: 0x0093E745
		public unsafe bool 启用约束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_启用约束) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_启用约束) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003DE6 RID: 15846
		// (get) Token: 0x0602037C RID: 131964 RVA: 0x00940556 File Offset: 0x0093E756
		// (set) Token: 0x0602037D RID: 131965 RVA: 0x0094056A File Offset: 0x0093E76A
		public unsafe FVector2D 高度约束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_高度约束);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_高度约束) = value;
			}
		}

		// Token: 0x17003DE7 RID: 15847
		// (get) Token: 0x0602037E RID: 131966 RVA: 0x0094057F File Offset: 0x0093E77F
		// (set) Token: 0x0602037F RID: 131967 RVA: 0x00940593 File Offset: 0x0093E793
		public unsafe FVector 大小缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_大小缩放);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_大小缩放) = value;
			}
		}

		// Token: 0x06020380 RID: 131968 RVA: 0x009405A8 File Offset: 0x0093E7A8
		public SBulletEffectOnHitConf()
		{
		}

		// Token: 0x06020381 RID: 131969 RVA: 0x009405B0 File Offset: 0x0093E7B0
		protected override IntPtr GetUStructPtr()
		{
			return SBulletEffectOnHitConf.StaticStruct();
		}

		// Token: 0x06020382 RID: 131970 RVA: 0x009405BC File Offset: 0x0093E7BC
		[NullableContext(2)]
		public SBulletEffectOnHitConf(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020383 RID: 131971 RVA: 0x009405C6 File Offset: 0x0093E7C6
		public SBulletEffectOnHitConf(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020384 RID: 131972 RVA: 0x009405D1 File Offset: 0x0093E7D1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletEffectOnHitConf(Pointer, false, true);
		}

		// Token: 0x06020385 RID: 131973 RVA: 0x009405DB File Offset: 0x0093E7DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletEffectOnHitConf(Pointer, MemoryOwner);
		}

		// Token: 0x04011640 RID: 71232
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SBulletEffectOnHitConf.SBulletEffectOnHitConf";

		// Token: 0x04011641 RID: 71233
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011642 RID: 71234
		internal static int __PropertyOffset_类型;

		// Token: 0x04011643 RID: 71235
		internal static int __PropertyOffset_启用约束;

		// Token: 0x04011644 RID: 71236
		internal static int __PropertyOffset_高度约束;

		// Token: 0x04011645 RID: 71237
		internal static int __PropertyOffset_大小缩放;
	}
}
