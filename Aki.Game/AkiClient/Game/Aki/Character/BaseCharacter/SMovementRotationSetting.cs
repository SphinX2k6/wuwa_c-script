using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004324 RID: 17188
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMovementRotationSetting.SMovementRotationSetting")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SMovementRotationSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C7FA RID: 182266 RVA: 0x00A21199 File Offset: 0x00A1F399
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovementRotationSetting._ScriptStructPtr != 0) ? SMovementRotationSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMovementRotationSetting.SMovementRotationSetting", ref SMovementRotationSetting._ScriptStructPtr);
		}

		// Token: 0x17006F89 RID: 28553
		// (get) Token: 0x0602C7FB RID: 182267 RVA: 0x00A211BD File Offset: 0x00A1F3BD
		// (set) Token: 0x0602C7FC RID: 182268 RVA: 0x00A211CD File Offset: 0x00A1F3CD
		public unsafe float 最小旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F8A RID: 28554
		// (get) Token: 0x0602C7FD RID: 182269 RVA: 0x00A211DE File Offset: 0x00A1F3DE
		// (set) Token: 0x0602C7FE RID: 182270 RVA: 0x00A211EE File Offset: 0x00A1F3EE
		public unsafe float 最大旋转速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F8B RID: 28555
		// (get) Token: 0x0602C7FF RID: 182271 RVA: 0x00A211FF File Offset: 0x00A1F3FF
		// (set) Token: 0x0602C800 RID: 182272 RVA: 0x00A2120F File Offset: 0x00A1F40F
		public unsafe float 最小角度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F8C RID: 28556
		// (get) Token: 0x0602C801 RID: 182273 RVA: 0x00A21220 File Offset: 0x00A1F420
		// (set) Token: 0x0602C802 RID: 182274 RVA: 0x00A21230 File Offset: 0x00A1F430
		public unsafe float 最大角度差
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F8D RID: 28557
		// (get) Token: 0x0602C803 RID: 182275 RVA: 0x00A21244 File Offset: 0x00A1F444
		// (set) Token: 0x0602C804 RID: 182276 RVA: 0x00A21287 File Offset: 0x00A1F487
		public SBaseCurve 渐变曲线
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._渐变曲线) == null)
				{
					result = (this._渐变曲线 = new SBaseCurve(base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SMovementRotationSetting.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C805 RID: 182277 RVA: 0x00A212A8 File Offset: 0x00A1F4A8
		public SMovementRotationSetting()
		{
		}

		// Token: 0x0602C806 RID: 182278 RVA: 0x00A212B0 File Offset: 0x00A1F4B0
		public SMovementRotationSetting(float 最小旋转速度, float 最大旋转速度, float 最小角度差, float 最大角度差, SBaseCurve 渐变曲线)
		{
			this.最小旋转速度 = 最小旋转速度;
			this.最大旋转速度 = 最大旋转速度;
			this.最小角度差 = 最小角度差;
			this.最大角度差 = 最大角度差;
			this.渐变曲线 = 渐变曲线;
		}

		// Token: 0x0602C807 RID: 182279 RVA: 0x00A212DD File Offset: 0x00A1F4DD
		protected override IntPtr GetUStructPtr()
		{
			return SMovementRotationSetting.StaticStruct();
		}

		// Token: 0x0602C808 RID: 182280 RVA: 0x00A212E9 File Offset: 0x00A1F4E9
		[NullableContext(2)]
		public SMovementRotationSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C809 RID: 182281 RVA: 0x00A212F3 File Offset: 0x00A1F4F3
		public SMovementRotationSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C80A RID: 182282 RVA: 0x00A212FE File Offset: 0x00A1F4FE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovementRotationSetting(Pointer, false, true);
		}

		// Token: 0x0602C80B RID: 182283 RVA: 0x00A21308 File Offset: 0x00A1F508
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovementRotationSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0401774C RID: 96076
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMovementRotationSetting.SMovementRotationSetting";

		// Token: 0x0401774D RID: 96077
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401774E RID: 96078
		internal static int __PropertyOffset_0;

		// Token: 0x0401774F RID: 96079
		internal static int __PropertyOffset_1;

		// Token: 0x04017750 RID: 96080
		internal static int __PropertyOffset_2;

		// Token: 0x04017751 RID: 96081
		internal static int __PropertyOffset_3;

		// Token: 0x04017752 RID: 96082
		internal static int __PropertyOffset_4;

		// Token: 0x04017753 RID: 96083
		[Nullable(2)]
		private SBaseCurve _渐变曲线;
	}
}
