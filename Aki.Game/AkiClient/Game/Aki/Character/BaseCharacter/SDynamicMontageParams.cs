using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200430F RID: 17167
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SDynamicMontageParams.SDynamicMontageParams")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SDynamicMontageParams : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C67C RID: 181884 RVA: 0x00A1F11C File Offset: 0x00A1D31C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDynamicMontageParams._ScriptStructPtr != 0) ? SDynamicMontageParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SDynamicMontageParams.SDynamicMontageParams", ref SDynamicMontageParams._ScriptStructPtr);
		}

		// Token: 0x17006F1C RID: 28444
		// (get) Token: 0x0602C67D RID: 181885 RVA: 0x00A1F140 File Offset: 0x00A1D340
		// (set) Token: 0x0602C67E RID: 181886 RVA: 0x00A1F154 File Offset: 0x00A1D354
		[Nullable(2)]
		public unsafe UAnimSequenceBase 动画
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + SDynamicMontageParams.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SDynamicMontageParams.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006F1D RID: 28445
		// (get) Token: 0x0602C67F RID: 181887 RVA: 0x00A1F169 File Offset: 0x00A1D369
		// (set) Token: 0x0602C680 RID: 181888 RVA: 0x00A1F179 File Offset: 0x00A1D379
		public unsafe float 进入融合时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDynamicMontageParams.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDynamicMontageParams.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F1E RID: 28446
		// (get) Token: 0x0602C681 RID: 181889 RVA: 0x00A1F18A File Offset: 0x00A1D38A
		// (set) Token: 0x0602C682 RID: 181890 RVA: 0x00A1F19A File Offset: 0x00A1D39A
		public unsafe float 退出融合时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDynamicMontageParams.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDynamicMontageParams.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F1F RID: 28447
		// (get) Token: 0x0602C683 RID: 181891 RVA: 0x00A1F1AB File Offset: 0x00A1D3AB
		// (set) Token: 0x0602C684 RID: 181892 RVA: 0x00A1F1BB File Offset: 0x00A1D3BB
		public unsafe float 播放速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDynamicMontageParams.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDynamicMontageParams.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F20 RID: 28448
		// (get) Token: 0x0602C685 RID: 181893 RVA: 0x00A1F1CC File Offset: 0x00A1D3CC
		// (set) Token: 0x0602C686 RID: 181894 RVA: 0x00A1F1DC File Offset: 0x00A1D3DC
		public unsafe float 开始时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDynamicMontageParams.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDynamicMontageParams.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602C687 RID: 181895 RVA: 0x00A1F1ED File Offset: 0x00A1D3ED
		public SDynamicMontageParams()
		{
		}

		// Token: 0x0602C688 RID: 181896 RVA: 0x00A1F1F5 File Offset: 0x00A1D3F5
		[NullableContext(1)]
		public SDynamicMontageParams(UAnimSequenceBase 动画, float 进入融合时间, float 退出融合时间, float 播放速率, float 开始时间)
		{
			this.动画 = 动画;
			this.进入融合时间 = 进入融合时间;
			this.退出融合时间 = 退出融合时间;
			this.播放速率 = 播放速率;
			this.开始时间 = 开始时间;
		}

		// Token: 0x0602C689 RID: 181897 RVA: 0x00A1F222 File Offset: 0x00A1D422
		protected override IntPtr GetUStructPtr()
		{
			return SDynamicMontageParams.StaticStruct();
		}

		// Token: 0x0602C68A RID: 181898 RVA: 0x00A1F22E File Offset: 0x00A1D42E
		[NullableContext(2)]
		public SDynamicMontageParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C68B RID: 181899 RVA: 0x00A1F238 File Offset: 0x00A1D438
		public SDynamicMontageParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C68C RID: 181900 RVA: 0x00A1F243 File Offset: 0x00A1D443
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDynamicMontageParams(Pointer, false, true);
		}

		// Token: 0x0602C68D RID: 181901 RVA: 0x00A1F24D File Offset: 0x00A1D44D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDynamicMontageParams(Pointer, MemoryOwner);
		}

		// Token: 0x0401769B RID: 95899
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SDynamicMontageParams.SDynamicMontageParams";

		// Token: 0x0401769C RID: 95900
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401769D RID: 95901
		internal static int __PropertyOffset_0;

		// Token: 0x0401769E RID: 95902
		internal static int __PropertyOffset_1;

		// Token: 0x0401769F RID: 95903
		internal static int __PropertyOffset_2;

		// Token: 0x040176A0 RID: 95904
		internal static int __PropertyOffset_3;

		// Token: 0x040176A1 RID: 95905
		internal static int __PropertyOffset_4;
	}
}
