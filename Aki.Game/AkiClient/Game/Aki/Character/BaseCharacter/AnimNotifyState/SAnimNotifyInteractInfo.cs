using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.AnimNotifyState
{
	// Token: 0x020033F8 RID: 13304
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/AnimNotifyState/SAnimNotifyInteractInfo.SAnimNotifyInteractInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 26)]
	public class SAnimNotifyInteractInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BF7 RID: 138231 RVA: 0x00968255 File Offset: 0x00966455
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAnimNotifyInteractInfo._ScriptStructPtr != 0) ? SAnimNotifyInteractInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/AnimNotifyState/SAnimNotifyInteractInfo.SAnimNotifyInteractInfo", ref SAnimNotifyInteractInfo._ScriptStructPtr);
		}

		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x06021BF8 RID: 138232 RVA: 0x00968279 File Offset: 0x00966479
		// (set) Token: 0x06021BF9 RID: 138233 RVA: 0x00968289 File Offset: 0x00966489
		public unsafe bool IsShowInteractUi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_IsShowInteractUi) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_IsShowInteractUi) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x06021BFA RID: 138234 RVA: 0x0096829A File Offset: 0x0096649A
		// (set) Token: 0x06021BFB RID: 138235 RVA: 0x009682AE File Offset: 0x009664AE
		[Nullable(1)]
		public unsafe string InteractText
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_InteractText)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_InteractText)), value);
			}
		}

		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x06021BFC RID: 138236 RVA: 0x009682C3 File Offset: 0x009664C3
		// (set) Token: 0x06021BFD RID: 138237 RVA: 0x009682D7 File Offset: 0x009664D7
		public unsafe TEnumAsByte<EExternalInteractIcon> InteractIconType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_InteractIconType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_InteractIconType) = value;
			}
		}

		// Token: 0x17004602 RID: 17922
		// (get) Token: 0x06021BFE RID: 138238 RVA: 0x009682EC File Offset: 0x009664EC
		// (set) Token: 0x06021BFF RID: 138239 RVA: 0x00968300 File Offset: 0x00966500
		public unsafe TEnumAsByte<EInputAction> InputAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_InputAction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_InputAction) = value;
			}
		}

		// Token: 0x06021C00 RID: 138240 RVA: 0x00968315 File Offset: 0x00966515
		public SAnimNotifyInteractInfo()
		{
		}

		// Token: 0x06021C01 RID: 138241 RVA: 0x0096831D File Offset: 0x0096651D
		protected override IntPtr GetUStructPtr()
		{
			return SAnimNotifyInteractInfo.StaticStruct();
		}

		// Token: 0x06021C02 RID: 138242 RVA: 0x00968329 File Offset: 0x00966529
		[NullableContext(2)]
		public SAnimNotifyInteractInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C03 RID: 138243 RVA: 0x00968333 File Offset: 0x00966533
		public SAnimNotifyInteractInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C04 RID: 138244 RVA: 0x0096833E File Offset: 0x0096653E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAnimNotifyInteractInfo(Pointer, false, true);
		}

		// Token: 0x06021C05 RID: 138245 RVA: 0x00968348 File Offset: 0x00966548
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAnimNotifyInteractInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401297A RID: 76154
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/AnimNotifyState/SAnimNotifyInteractInfo.SAnimNotifyInteractInfo";

		// Token: 0x0401297B RID: 76155
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401297C RID: 76156
		internal static int __PropertyOffset_IsShowInteractUi;

		// Token: 0x0401297D RID: 76157
		internal static int __PropertyOffset_InteractText;

		// Token: 0x0401297E RID: 76158
		internal static int __PropertyOffset_InteractIconType;

		// Token: 0x0401297F RID: 76159
		internal static int __PropertyOffset_InputAction;
	}
}
