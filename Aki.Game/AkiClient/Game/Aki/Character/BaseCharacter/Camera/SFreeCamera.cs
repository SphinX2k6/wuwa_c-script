using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E8 RID: 13288
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SFreeCamera.SFreeCamera")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class SFreeCamera : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021B35 RID: 138037 RVA: 0x009673DB File Offset: 0x009655DB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFreeCamera._ScriptStructPtr != 0) ? SFreeCamera._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SFreeCamera.SFreeCamera", ref SFreeCamera._ScriptStructPtr);
		}

		// Token: 0x170045C1 RID: 17857
		// (get) Token: 0x06021B36 RID: 138038 RVA: 0x009673FF File Offset: 0x009655FF
		// (set) Token: 0x06021B37 RID: 138039 RVA: 0x0096740F File Offset: 0x0096560F
		public unsafe bool PC生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_PC生效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_PC生效) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045C2 RID: 17858
		// (get) Token: 0x06021B38 RID: 138040 RVA: 0x00967420 File Offset: 0x00965620
		// (set) Token: 0x06021B39 RID: 138041 RVA: 0x00967430 File Offset: 0x00965630
		public unsafe bool 手机生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_手机生效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_手机生效) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045C3 RID: 17859
		// (get) Token: 0x06021B3A RID: 138042 RVA: 0x00967441 File Offset: 0x00965641
		// (set) Token: 0x06021B3B RID: 138043 RVA: 0x00967455 File Offset: 0x00965655
		public unsafe FVector 初始位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_初始位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_初始位置) = value;
			}
		}

		// Token: 0x170045C4 RID: 17860
		// (get) Token: 0x06021B3C RID: 138044 RVA: 0x0096746A File Offset: 0x0096566A
		// (set) Token: 0x06021B3D RID: 138045 RVA: 0x0096747E File Offset: 0x0096567E
		public unsafe FRotator 初始旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_初始旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_初始旋转) = value;
			}
		}

		// Token: 0x170045C5 RID: 17861
		// (get) Token: 0x06021B3E RID: 138046 RVA: 0x00967493 File Offset: 0x00965693
		// (set) Token: 0x06021B3F RID: 138047 RVA: 0x009674A3 File Offset: 0x009656A3
		public unsafe float 初始FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_初始FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_初始FOV) = value;
			}
		}

		// Token: 0x170045C6 RID: 17862
		// (get) Token: 0x06021B40 RID: 138048 RVA: 0x009674B4 File Offset: 0x009656B4
		// (set) Token: 0x06021B41 RID: 138049 RVA: 0x009674C8 File Offset: 0x009656C8
		public unsafe TEnumAsByte<EFreeCameraInputMode> 初始输入模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_初始输入模式);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_初始输入模式) = value;
			}
		}

		// Token: 0x170045C7 RID: 17863
		// (get) Token: 0x06021B42 RID: 138050 RVA: 0x009674E0 File Offset: 0x009656E0
		// (set) Token: 0x06021B43 RID: 138051 RVA: 0x00967523 File Offset: 0x00965723
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFreeCameraLimit>, float> 限制
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFreeCameraLimit>, float> result;
				if ((result = this._限制) == null)
				{
					result = (this._限制 = new TMap<TEnumAsByte<EFreeCameraLimit>, float>(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_限制, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.限制.CopyAssign(value);
			}
		}

		// Token: 0x06021B44 RID: 138052 RVA: 0x00967531 File Offset: 0x00965731
		public SFreeCamera()
		{
		}

		// Token: 0x06021B45 RID: 138053 RVA: 0x00967539 File Offset: 0x00965739
		protected override IntPtr GetUStructPtr()
		{
			return SFreeCamera.StaticStruct();
		}

		// Token: 0x06021B46 RID: 138054 RVA: 0x00967545 File Offset: 0x00965745
		[NullableContext(2)]
		public SFreeCamera(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B47 RID: 138055 RVA: 0x0096754F File Offset: 0x0096574F
		public SFreeCamera(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B48 RID: 138056 RVA: 0x0096755A File Offset: 0x0096575A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFreeCamera(Pointer, false, true);
		}

		// Token: 0x06021B49 RID: 138057 RVA: 0x00967564 File Offset: 0x00965764
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFreeCamera(Pointer, MemoryOwner);
		}

		// Token: 0x04012906 RID: 76038
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SFreeCamera.SFreeCamera";

		// Token: 0x04012907 RID: 76039
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012908 RID: 76040
		internal static int __PropertyOffset_PC生效;

		// Token: 0x04012909 RID: 76041
		internal static int __PropertyOffset_手机生效;

		// Token: 0x0401290A RID: 76042
		internal static int __PropertyOffset_初始位置;

		// Token: 0x0401290B RID: 76043
		internal static int __PropertyOffset_初始旋转;

		// Token: 0x0401290C RID: 76044
		internal static int __PropertyOffset_初始FOV;

		// Token: 0x0401290D RID: 76045
		internal static int __PropertyOffset_初始输入模式;

		// Token: 0x0401290E RID: 76046
		internal static int __PropertyOffset_限制;

		// Token: 0x0401290F RID: 76047
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFreeCameraLimit>, float> _限制;
	}
}
