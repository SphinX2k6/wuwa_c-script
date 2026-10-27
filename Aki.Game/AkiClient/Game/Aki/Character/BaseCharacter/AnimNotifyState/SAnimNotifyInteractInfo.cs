using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.AnimNotifyState
{
	// Token: 0x020043E5 RID: 17381
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/AnimNotifyState/SAnimNotifyInteractInfo.SAnimNotifyInteractInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 26)]
	public class SAnimNotifyInteractInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D07B RID: 184443 RVA: 0x00A2EE3D File Offset: 0x00A2D03D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAnimNotifyInteractInfo._ScriptStructPtr != 0) ? SAnimNotifyInteractInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/AnimNotifyState/SAnimNotifyInteractInfo.SAnimNotifyInteractInfo", ref SAnimNotifyInteractInfo._ScriptStructPtr);
		}

		// Token: 0x17007221 RID: 29217
		// (get) Token: 0x0602D07C RID: 184444 RVA: 0x00A2EE61 File Offset: 0x00A2D061
		// (set) Token: 0x0602D07D RID: 184445 RVA: 0x00A2EE71 File Offset: 0x00A2D071
		public unsafe bool IsShowInteractUi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007222 RID: 29218
		// (get) Token: 0x0602D07E RID: 184446 RVA: 0x00A2EE82 File Offset: 0x00A2D082
		// (set) Token: 0x0602D07F RID: 184447 RVA: 0x00A2EE96 File Offset: 0x00A2D096
		[Nullable(1)]
		public unsafe string InteractText
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_1)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17007223 RID: 29219
		// (get) Token: 0x0602D080 RID: 184448 RVA: 0x00A2EEAB File Offset: 0x00A2D0AB
		// (set) Token: 0x0602D081 RID: 184449 RVA: 0x00A2EEBF File Offset: 0x00A2D0BF
		public unsafe TEnumAsByte<EExternalInteractIcon> InteractIconType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007224 RID: 29220
		// (get) Token: 0x0602D082 RID: 184450 RVA: 0x00A2EED4 File Offset: 0x00A2D0D4
		// (set) Token: 0x0602D083 RID: 184451 RVA: 0x00A2EEE8 File Offset: 0x00A2D0E8
		public unsafe TEnumAsByte<EInputAction> InputAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAnimNotifyInteractInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602D084 RID: 184452 RVA: 0x00A2EEFD File Offset: 0x00A2D0FD
		public SAnimNotifyInteractInfo()
		{
		}

		// Token: 0x0602D085 RID: 184453 RVA: 0x00A2EF05 File Offset: 0x00A2D105
		public SAnimNotifyInteractInfo(bool IsShowInteractUi, [Nullable(1)] string InteractText, TEnumAsByte<EExternalInteractIcon> InteractIconType, TEnumAsByte<EInputAction> InputAction)
		{
			this.IsShowInteractUi = IsShowInteractUi;
			this.InteractText = InteractText;
			this.InteractIconType = InteractIconType;
			this.InputAction = InputAction;
		}

		// Token: 0x0602D086 RID: 184454 RVA: 0x00A2EF2A File Offset: 0x00A2D12A
		protected override IntPtr GetUStructPtr()
		{
			return SAnimNotifyInteractInfo.StaticStruct();
		}

		// Token: 0x0602D087 RID: 184455 RVA: 0x00A2EF36 File Offset: 0x00A2D136
		[NullableContext(2)]
		public SAnimNotifyInteractInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D088 RID: 184456 RVA: 0x00A2EF40 File Offset: 0x00A2D140
		public SAnimNotifyInteractInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D089 RID: 184457 RVA: 0x00A2EF4B File Offset: 0x00A2D14B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAnimNotifyInteractInfo(Pointer, false, true);
		}

		// Token: 0x0602D08A RID: 184458 RVA: 0x00A2EF55 File Offset: 0x00A2D155
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAnimNotifyInteractInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04017E5A RID: 97882
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/AnimNotifyState/SAnimNotifyInteractInfo.SAnimNotifyInteractInfo";

		// Token: 0x04017E5B RID: 97883
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017E5C RID: 97884
		internal static int __PropertyOffset_0;

		// Token: 0x04017E5D RID: 97885
		internal static int __PropertyOffset_1;

		// Token: 0x04017E5E RID: 97886
		internal static int __PropertyOffset_2;

		// Token: 0x04017E5F RID: 97887
		internal static int __PropertyOffset_3;
	}
}
