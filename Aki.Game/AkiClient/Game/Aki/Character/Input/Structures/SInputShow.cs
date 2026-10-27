using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x0200425D RID: 16989
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/SInputShow.SInputShow")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 102)]
	public class SInputShow : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C072 RID: 180338 RVA: 0x00A122A0 File Offset: 0x00A104A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputShow._ScriptStructPtr != 0) ? SInputShow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/SInputShow.SInputShow", ref SInputShow._ScriptStructPtr);
		}

		// Token: 0x17006D5C RID: 27996
		// (get) Token: 0x0602C073 RID: 180339 RVA: 0x00A122C4 File Offset: 0x00A104C4
		// (set) Token: 0x0602C074 RID: 180340 RVA: 0x00A122D8 File Offset: 0x00A104D8
		[Nullable(0)]
		public unsafe TEnumAsByte<EInputAction> InputActionType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006D5D RID: 27997
		// (get) Token: 0x0602C075 RID: 180341 RVA: 0x00A122ED File Offset: 0x00A104ED
		// (set) Token: 0x0602C076 RID: 180342 RVA: 0x00A122FD File Offset: 0x00A104FD
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006D5E RID: 27998
		// (get) Token: 0x0602C077 RID: 180343 RVA: 0x00A12310 File Offset: 0x00A10510
		// (set) Token: 0x0602C078 RID: 180344 RVA: 0x00A12353 File Offset: 0x00A10553
		public FGameplayTagContainer BlockTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._BlockTag) == null)
				{
					result = (this._BlockTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006D5F RID: 27999
		// (get) Token: 0x0602C079 RID: 180345 RVA: 0x00A12374 File Offset: 0x00A10574
		// (set) Token: 0x0602C07A RID: 180346 RVA: 0x00A12384 File Offset: 0x00A10584
		public unsafe int ListenAttributeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006D60 RID: 28000
		// (get) Token: 0x0602C07B RID: 180347 RVA: 0x00A12395 File Offset: 0x00A10595
		// (set) Token: 0x0602C07C RID: 180348 RVA: 0x00A123A5 File Offset: 0x00A105A5
		public unsafe int ListenMaxAttributeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006D61 RID: 28001
		// (get) Token: 0x0602C07D RID: 180349 RVA: 0x00A123B6 File Offset: 0x00A105B6
		// (set) Token: 0x0602C07E RID: 180350 RVA: 0x00A123D5 File Offset: 0x00A105D5
		public TSoftObjectPtr<UNiagaraSystem> MaxAttributeEffect
		{
			get
			{
				return new TSoftObjectPtr<UNiagaraSystem>(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006D62 RID: 28002
		// (get) Token: 0x0602C07F RID: 180351 RVA: 0x00A123FA File Offset: 0x00A105FA
		// (set) Token: 0x0602C080 RID: 180352 RVA: 0x00A1240E File Offset: 0x00A1060E
		public unsafe FColor MaxAttributeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006D63 RID: 28003
		// (get) Token: 0x0602C081 RID: 180353 RVA: 0x00A12423 File Offset: 0x00A10623
		// (set) Token: 0x0602C082 RID: 180354 RVA: 0x00A12433 File Offset: 0x00A10633
		public unsafe bool bUseElementColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D64 RID: 28004
		// (get) Token: 0x0602C083 RID: 180355 RVA: 0x00A12444 File Offset: 0x00A10644
		// (set) Token: 0x0602C084 RID: 180356 RVA: 0x00A12454 File Offset: 0x00A10654
		public unsafe bool bLongPressControlCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputShow.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C085 RID: 180357 RVA: 0x00A12465 File Offset: 0x00A10665
		public SInputShow()
		{
		}

		// Token: 0x0602C086 RID: 180358 RVA: 0x00A12470 File Offset: 0x00A10670
		public SInputShow([Nullable(0)] TEnumAsByte<EInputAction> InputActionType, int SkillId, FGameplayTagContainer BlockTag, int ListenAttributeId, int ListenMaxAttributeId, TSoftObjectPtr<UNiagaraSystem> MaxAttributeEffect, FColor MaxAttributeColor, bool bUseElementColor, bool bLongPressControlCamera)
		{
			this.InputActionType = InputActionType;
			this.SkillId = SkillId;
			this.BlockTag = BlockTag;
			this.ListenAttributeId = ListenAttributeId;
			this.ListenMaxAttributeId = ListenMaxAttributeId;
			this.MaxAttributeEffect = MaxAttributeEffect;
			this.MaxAttributeColor = MaxAttributeColor;
			this.bUseElementColor = bUseElementColor;
			this.bLongPressControlCamera = bLongPressControlCamera;
		}

		// Token: 0x0602C087 RID: 180359 RVA: 0x00A124C8 File Offset: 0x00A106C8
		protected override IntPtr GetUStructPtr()
		{
			return SInputShow.StaticStruct();
		}

		// Token: 0x0602C088 RID: 180360 RVA: 0x00A124D4 File Offset: 0x00A106D4
		[NullableContext(2)]
		public SInputShow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C089 RID: 180361 RVA: 0x00A124DE File Offset: 0x00A106DE
		public SInputShow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C08A RID: 180362 RVA: 0x00A124E9 File Offset: 0x00A106E9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputShow(Pointer, false, true);
		}

		// Token: 0x0602C08B RID: 180363 RVA: 0x00A124F3 File Offset: 0x00A106F3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputShow(Pointer, MemoryOwner);
		}

		// Token: 0x04016FFE RID: 94206
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/SInputShow.SInputShow";

		// Token: 0x04016FFF RID: 94207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017000 RID: 94208
		internal static int __PropertyOffset_0;

		// Token: 0x04017001 RID: 94209
		internal static int __PropertyOffset_1;

		// Token: 0x04017002 RID: 94210
		internal static int __PropertyOffset_2;

		// Token: 0x04017003 RID: 94211
		[Nullable(2)]
		private FGameplayTagContainer _BlockTag;

		// Token: 0x04017004 RID: 94212
		internal static int __PropertyOffset_3;

		// Token: 0x04017005 RID: 94213
		internal static int __PropertyOffset_4;

		// Token: 0x04017006 RID: 94214
		internal static int __PropertyOffset_5;

		// Token: 0x04017007 RID: 94215
		internal static int __PropertyOffset_6;

		// Token: 0x04017008 RID: 94216
		internal static int __PropertyOffset_7;

		// Token: 0x04017009 RID: 94217
		internal static int __PropertyOffset_8;
	}
}
