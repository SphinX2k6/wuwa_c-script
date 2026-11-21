using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200335D RID: 13149
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMovementRotationSetting.SMovementRotationSetting")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SMovementRotationSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021503 RID: 136451 RVA: 0x0095DC0F File Offset: 0x0095BE0F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovementRotationSetting._ScriptStructPtr != 0) ? SMovementRotationSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMovementRotationSetting.SMovementRotationSetting", ref SMovementRotationSetting._ScriptStructPtr);
		}

		// Token: 0x170043B4 RID: 17332
		// (get) Token: 0x06021504 RID: 136452 RVA: 0x0095DC33 File Offset: 0x0095BE33
		// (set) Token: 0x06021505 RID: 136453 RVA: 0x0095DC43 File Offset: 0x0095BE43
		public unsafe float 最小旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_最小旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_最小旋转速度) = value;
			}
		}

		// Token: 0x170043B5 RID: 17333
		// (get) Token: 0x06021506 RID: 136454 RVA: 0x0095DC54 File Offset: 0x0095BE54
		// (set) Token: 0x06021507 RID: 136455 RVA: 0x0095DC64 File Offset: 0x0095BE64
		public unsafe float 最大旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_最大旋转速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_最大旋转速度) = value;
			}
		}

		// Token: 0x170043B6 RID: 17334
		// (get) Token: 0x06021508 RID: 136456 RVA: 0x0095DC75 File Offset: 0x0095BE75
		// (set) Token: 0x06021509 RID: 136457 RVA: 0x0095DC85 File Offset: 0x0095BE85
		public unsafe float 最小角度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_最小角度差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_最小角度差) = value;
			}
		}

		// Token: 0x170043B7 RID: 17335
		// (get) Token: 0x0602150A RID: 136458 RVA: 0x0095DC96 File Offset: 0x0095BE96
		// (set) Token: 0x0602150B RID: 136459 RVA: 0x0095DCA6 File Offset: 0x0095BEA6
		public unsafe float 最大角度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_最大角度差);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_最大角度差) = value;
			}
		}

		// Token: 0x170043B8 RID: 17336
		// (get) Token: 0x0602150C RID: 136460 RVA: 0x0095DCB8 File Offset: 0x0095BEB8
		// (set) Token: 0x0602150D RID: 136461 RVA: 0x0095DCFB File Offset: 0x0095BEFB
		public SBaseCurve 渐变曲线
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._渐变曲线) == null)
				{
					result = (this._渐变曲线 = new SBaseCurve(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_渐变曲线, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_渐变曲线, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602150E RID: 136462 RVA: 0x0095DD1C File Offset: 0x0095BF1C
		public SMovementRotationSetting()
		{
		}

		// Token: 0x0602150F RID: 136463 RVA: 0x0095DD24 File Offset: 0x0095BF24
		protected override IntPtr GetUStructPtr()
		{
			return SMovementRotationSetting.StaticStruct();
		}

		// Token: 0x06021510 RID: 136464 RVA: 0x0095DD30 File Offset: 0x0095BF30
		[NullableContext(2)]
		public SMovementRotationSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021511 RID: 136465 RVA: 0x0095DD3A File Offset: 0x0095BF3A
		public SMovementRotationSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021512 RID: 136466 RVA: 0x0095DD45 File Offset: 0x0095BF45
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovementRotationSetting(Pointer, false, true);
		}

		// Token: 0x06021513 RID: 136467 RVA: 0x0095DD4F File Offset: 0x0095BF4F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovementRotationSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04012350 RID: 74576
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMovementRotationSetting.SMovementRotationSetting";

		// Token: 0x04012351 RID: 74577
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012352 RID: 74578
		internal static int __PropertyOffset_最小旋转速度;

		// Token: 0x04012353 RID: 74579
		internal static int __PropertyOffset_最大旋转速度;

		// Token: 0x04012354 RID: 74580
		internal static int __PropertyOffset_最小角度差;

		// Token: 0x04012355 RID: 74581
		internal static int __PropertyOffset_最大角度差;

		// Token: 0x04012356 RID: 74582
		internal static int __PropertyOffset_渐变曲线;

		// Token: 0x04012357 RID: 74583
		[Nullable(2)]
		private SBaseCurve _渐变曲线;
	}
}
