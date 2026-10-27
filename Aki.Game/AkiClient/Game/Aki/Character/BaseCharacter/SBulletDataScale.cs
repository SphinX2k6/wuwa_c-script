using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042FA RID: 17146
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBulletDataScale.SBulletDataScale")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SBulletDataScale : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C4FC RID: 181500 RVA: 0x00A1CD3C File Offset: 0x00A1AF3C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBulletDataScale._ScriptStructPtr != 0) ? SBulletDataScale._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBulletDataScale.SBulletDataScale", ref SBulletDataScale._ScriptStructPtr);
		}

		// Token: 0x17006EAE RID: 28334
		// (get) Token: 0x0602C4FD RID: 181501 RVA: 0x00A1CD60 File Offset: 0x00A1AF60
		// (set) Token: 0x0602C4FE RID: 181502 RVA: 0x00A1CD74 File Offset: 0x00A1AF74
		public unsafe FVector 缩放倍率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBulletDataScale.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBulletDataScale.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006EAF RID: 28335
		// (get) Token: 0x0602C4FF RID: 181503 RVA: 0x00A1CD89 File Offset: 0x00A1AF89
		// (set) Token: 0x0602C500 RID: 181504 RVA: 0x00A1CD9D File Offset: 0x00A1AF9D
		[Nullable(2)]
		public unsafe UCurveVector 缩放倍率曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataScale.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBulletDataScale.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602C501 RID: 181505 RVA: 0x00A1CDB2 File Offset: 0x00A1AFB2
		public SBulletDataScale()
		{
		}

		// Token: 0x0602C502 RID: 181506 RVA: 0x00A1CDBA File Offset: 0x00A1AFBA
		[NullableContext(1)]
		public SBulletDataScale(FVector 缩放倍率, UCurveVector 缩放倍率曲线)
		{
			this.缩放倍率 = 缩放倍率;
			this.缩放倍率曲线 = 缩放倍率曲线;
		}

		// Token: 0x0602C503 RID: 181507 RVA: 0x00A1CDD0 File Offset: 0x00A1AFD0
		protected override IntPtr GetUStructPtr()
		{
			return SBulletDataScale.StaticStruct();
		}

		// Token: 0x0602C504 RID: 181508 RVA: 0x00A1CDDC File Offset: 0x00A1AFDC
		[NullableContext(2)]
		public SBulletDataScale(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C505 RID: 181509 RVA: 0x00A1CDE6 File Offset: 0x00A1AFE6
		public SBulletDataScale(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C506 RID: 181510 RVA: 0x00A1CDF1 File Offset: 0x00A1AFF1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBulletDataScale(Pointer, false, true);
		}

		// Token: 0x0602C507 RID: 181511 RVA: 0x00A1CDFB File Offset: 0x00A1AFFB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBulletDataScale(Pointer, MemoryOwner);
		}

		// Token: 0x040175DB RID: 95707
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBulletDataScale.SBulletDataScale";

		// Token: 0x040175DC RID: 95708
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040175DD RID: 95709
		internal static int __PropertyOffset_0;

		// Token: 0x040175DE RID: 95710
		internal static int __PropertyOffset_1;
	}
}
