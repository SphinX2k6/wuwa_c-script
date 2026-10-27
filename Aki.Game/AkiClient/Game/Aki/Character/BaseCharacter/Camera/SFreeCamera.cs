using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043CF RID: 17359
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SFreeCamera.SFreeCamera")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class SFreeCamera : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CF62 RID: 184162 RVA: 0x00A2D450 File Offset: 0x00A2B650
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFreeCamera._ScriptStructPtr != 0) ? SFreeCamera._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SFreeCamera.SFreeCamera", ref SFreeCamera._ScriptStructPtr);
		}

		// Token: 0x170071CF RID: 29135
		// (get) Token: 0x0602CF63 RID: 184163 RVA: 0x00A2D474 File Offset: 0x00A2B674
		// (set) Token: 0x0602CF64 RID: 184164 RVA: 0x00A2D484 File Offset: 0x00A2B684
		public unsafe bool PC生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071D0 RID: 29136
		// (get) Token: 0x0602CF65 RID: 184165 RVA: 0x00A2D495 File Offset: 0x00A2B695
		// (set) Token: 0x0602CF66 RID: 184166 RVA: 0x00A2D4A5 File Offset: 0x00A2B6A5
		public unsafe bool 手机生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071D1 RID: 29137
		// (get) Token: 0x0602CF67 RID: 184167 RVA: 0x00A2D4B6 File Offset: 0x00A2B6B6
		// (set) Token: 0x0602CF68 RID: 184168 RVA: 0x00A2D4CA File Offset: 0x00A2B6CA
		public unsafe FVector 初始位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170071D2 RID: 29138
		// (get) Token: 0x0602CF69 RID: 184169 RVA: 0x00A2D4DF File Offset: 0x00A2B6DF
		// (set) Token: 0x0602CF6A RID: 184170 RVA: 0x00A2D4F3 File Offset: 0x00A2B6F3
		public unsafe FRotator 初始旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170071D3 RID: 29139
		// (get) Token: 0x0602CF6B RID: 184171 RVA: 0x00A2D508 File Offset: 0x00A2B708
		// (set) Token: 0x0602CF6C RID: 184172 RVA: 0x00A2D518 File Offset: 0x00A2B718
		public unsafe float 初始FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170071D4 RID: 29140
		// (get) Token: 0x0602CF6D RID: 184173 RVA: 0x00A2D529 File Offset: 0x00A2B729
		// (set) Token: 0x0602CF6E RID: 184174 RVA: 0x00A2D53D File Offset: 0x00A2B73D
		public unsafe TEnumAsByte<EFreeCameraInputMode> 初始输入模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170071D5 RID: 29141
		// (get) Token: 0x0602CF6F RID: 184175 RVA: 0x00A2D552 File Offset: 0x00A2B752
		// (set) Token: 0x0602CF70 RID: 184176 RVA: 0x00A2D566 File Offset: 0x00A2B766
		public unsafe SFreeCameraDragInput 拖动输入
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170071D6 RID: 29142
		// (get) Token: 0x0602CF71 RID: 184177 RVA: 0x00A2D57C File Offset: 0x00A2B77C
		// (set) Token: 0x0602CF72 RID: 184178 RVA: 0x00A2D5BF File Offset: 0x00A2B7BF
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
					result = (this._限制 = new TMap<TEnumAsByte<EFreeCameraLimit>, float>(base.NativePtr + (IntPtr)SFreeCamera.__PropertyOffset_7, base.MemoryOwner ?? this));
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

		// Token: 0x0602CF73 RID: 184179 RVA: 0x00A2D5CD File Offset: 0x00A2B7CD
		public SFreeCamera()
		{
		}

		// Token: 0x0602CF74 RID: 184180 RVA: 0x00A2D5D8 File Offset: 0x00A2B7D8
		public SFreeCamera(bool PC生效, bool 手机生效, FVector 初始位置, FRotator 初始旋转, float 初始FOV, TEnumAsByte<EFreeCameraInputMode> 初始输入模式, SFreeCameraDragInput 拖动输入, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFreeCameraLimit>, float> 限制)
		{
			this.PC生效 = PC生效;
			this.手机生效 = 手机生效;
			this.初始位置 = 初始位置;
			this.初始旋转 = 初始旋转;
			this.初始FOV = 初始FOV;
			this.初始输入模式 = 初始输入模式;
			this.拖动输入 = 拖动输入;
			this.限制 = 限制;
		}

		// Token: 0x0602CF75 RID: 184181 RVA: 0x00A2D628 File Offset: 0x00A2B828
		protected override IntPtr GetUStructPtr()
		{
			return SFreeCamera.StaticStruct();
		}

		// Token: 0x0602CF76 RID: 184182 RVA: 0x00A2D634 File Offset: 0x00A2B834
		[NullableContext(2)]
		public SFreeCamera(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CF77 RID: 184183 RVA: 0x00A2D63E File Offset: 0x00A2B83E
		public SFreeCamera(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CF78 RID: 184184 RVA: 0x00A2D649 File Offset: 0x00A2B849
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFreeCamera(Pointer, false, true);
		}

		// Token: 0x0602CF79 RID: 184185 RVA: 0x00A2D653 File Offset: 0x00A2B853
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFreeCamera(Pointer, MemoryOwner);
		}

		// Token: 0x04017DBB RID: 97723
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SFreeCamera.SFreeCamera";

		// Token: 0x04017DBC RID: 97724
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017DBD RID: 97725
		internal static int __PropertyOffset_0;

		// Token: 0x04017DBE RID: 97726
		internal static int __PropertyOffset_1;

		// Token: 0x04017DBF RID: 97727
		internal static int __PropertyOffset_2;

		// Token: 0x04017DC0 RID: 97728
		internal static int __PropertyOffset_3;

		// Token: 0x04017DC1 RID: 97729
		internal static int __PropertyOffset_4;

		// Token: 0x04017DC2 RID: 97730
		internal static int __PropertyOffset_5;

		// Token: 0x04017DC3 RID: 97731
		internal static int __PropertyOffset_6;

		// Token: 0x04017DC4 RID: 97732
		internal static int __PropertyOffset_7;

		// Token: 0x04017DC5 RID: 97733
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFreeCameraLimit>, float> _限制;
	}
}
