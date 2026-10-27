using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight
{
	// Token: 0x0200400C RID: 16396
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Core/Fight/SBulletEffectOnHitConf.SBulletEffectOnHitConf")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SBulletEffectOnHitConf : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029FB7 RID: 171959 RVA: 0x009D299F File Offset: 0x009D0B9F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletEffectOnHitConf._ScriptStructPtr != 0) ? SBulletEffectOnHitConf._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Core/Fight/SBulletEffectOnHitConf.SBulletEffectOnHitConf", ref SBulletEffectOnHitConf._ScriptStructPtr);
		}

		// Token: 0x1700661B RID: 26139
		// (get) Token: 0x06029FB8 RID: 171960 RVA: 0x009D29C3 File Offset: 0x009D0BC3
		// (set) Token: 0x06029FB9 RID: 171961 RVA: 0x009D29D7 File Offset: 0x009D0BD7
		public unsafe TEnumAsByte<EBulletEffectOnHitType> 类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700661C RID: 26140
		// (get) Token: 0x06029FBA RID: 171962 RVA: 0x009D29EC File Offset: 0x009D0BEC
		// (set) Token: 0x06029FBB RID: 171963 RVA: 0x009D29FC File Offset: 0x009D0BFC
		public unsafe bool 启用约束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700661D RID: 26141
		// (get) Token: 0x06029FBC RID: 171964 RVA: 0x009D2A0D File Offset: 0x009D0C0D
		// (set) Token: 0x06029FBD RID: 171965 RVA: 0x009D2A21 File Offset: 0x009D0C21
		public unsafe FVector2D 高度约束
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700661E RID: 26142
		// (get) Token: 0x06029FBE RID: 171966 RVA: 0x009D2A36 File Offset: 0x009D0C36
		// (set) Token: 0x06029FBF RID: 171967 RVA: 0x009D2A4A File Offset: 0x009D0C4A
		public unsafe FVector 大小缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletEffectOnHitConf.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06029FC0 RID: 171968 RVA: 0x009D2A5F File Offset: 0x009D0C5F
		public SBulletEffectOnHitConf()
		{
		}

		// Token: 0x06029FC1 RID: 171969 RVA: 0x009D2A67 File Offset: 0x009D0C67
		public SBulletEffectOnHitConf(TEnumAsByte<EBulletEffectOnHitType> 类型, bool 启用约束, FVector2D 高度约束, FVector 大小缩放)
		{
			this.类型 = 类型;
			this.启用约束 = 启用约束;
			this.高度约束 = 高度约束;
			this.大小缩放 = 大小缩放;
		}

		// Token: 0x06029FC2 RID: 171970 RVA: 0x009D2A8C File Offset: 0x009D0C8C
		protected override IntPtr GetUStructPtr()
		{
			return SBulletEffectOnHitConf.StaticStruct();
		}

		// Token: 0x06029FC3 RID: 171971 RVA: 0x009D2A98 File Offset: 0x009D0C98
		[NullableContext(2)]
		public SBulletEffectOnHitConf(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029FC4 RID: 171972 RVA: 0x009D2AA2 File Offset: 0x009D0CA2
		public SBulletEffectOnHitConf(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029FC5 RID: 171973 RVA: 0x009D2AAD File Offset: 0x009D0CAD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletEffectOnHitConf(Pointer, false, true);
		}

		// Token: 0x06029FC6 RID: 171974 RVA: 0x009D2AB7 File Offset: 0x009D0CB7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletEffectOnHitConf(Pointer, MemoryOwner);
		}

		// Token: 0x040159E9 RID: 88553
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/SBulletEffectOnHitConf.SBulletEffectOnHitConf";

		// Token: 0x040159EA RID: 88554
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040159EB RID: 88555
		internal static int __PropertyOffset_0;

		// Token: 0x040159EC RID: 88556
		internal static int __PropertyOffset_1;

		// Token: 0x040159ED RID: 88557
		internal static int __PropertyOffset_2;

		// Token: 0x040159EE RID: 88558
		internal static int __PropertyOffset_3;
	}
}
