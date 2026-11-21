using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031FB RID: 12795
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SPanelQte.SPanelQte")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SPanelQte : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD51 RID: 130385 RVA: 0x00936E75 File Offset: 0x00935075
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPanelQte._ScriptStructPtr != 0) ? SPanelQte._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SPanelQte.SPanelQte", ref SPanelQte._ScriptStructPtr);
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0601FD52 RID: 130386 RVA: 0x00936E99 File Offset: 0x00935099
		// (set) Token: 0x0601FD53 RID: 130387 RVA: 0x00936EAD File Offset: 0x009350AD
		[Nullable(0)]
		public unsafe TEnumAsByte<EPanelQteViewType> ViewType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_ViewType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_ViewType) = value;
			}
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0601FD54 RID: 130388 RVA: 0x00936EC2 File Offset: 0x009350C2
		// (set) Token: 0x0601FD55 RID: 130389 RVA: 0x00936ED2 File Offset: 0x009350D2
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0601FD56 RID: 130390 RVA: 0x00936EE3 File Offset: 0x009350E3
		// (set) Token: 0x0601FD57 RID: 130391 RVA: 0x00936EF3 File Offset: 0x009350F3
		public unsafe float WorldTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_WorldTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_WorldTimeDilation) = value;
			}
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0601FD58 RID: 130392 RVA: 0x00936F04 File Offset: 0x00935104
		// (set) Token: 0x0601FD59 RID: 130393 RVA: 0x00936F14 File Offset: 0x00935114
		public unsafe int MinSuccessCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_MinSuccessCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_MinSuccessCount) = value;
			}
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0601FD5A RID: 130394 RVA: 0x00936F25 File Offset: 0x00935125
		// (set) Token: 0x0601FD5B RID: 130395 RVA: 0x00936F35 File Offset: 0x00935135
		public unsafe int MaxSuccessCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_MaxSuccessCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_MaxSuccessCount) = value;
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0601FD5C RID: 130396 RVA: 0x00936F46 File Offset: 0x00935146
		// (set) Token: 0x0601FD5D RID: 130397 RVA: 0x00936F56 File Offset: 0x00935156
		public unsafe bool HideAllBattleUi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_HideAllBattleUi) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_HideAllBattleUi) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0601FD5E RID: 130398 RVA: 0x00936F68 File Offset: 0x00935168
		// (set) Token: 0x0601FD5F RID: 130399 RVA: 0x00936FAB File Offset: 0x009351AB
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EBattleUIChild>> HideUIElement
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EBattleUIChild>> result;
				if ((result = this._HideUIElement) == null)
				{
					result = (this._HideUIElement = new TArray<TEnumAsByte<EBattleUIChild>>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_HideUIElement, base.MemoryOwner ?? this));
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
				this.HideUIElement.CopyAssign(value);
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0601FD60 RID: 130400 RVA: 0x00936FBC File Offset: 0x009351BC
		// (set) Token: 0x0601FD61 RID: 130401 RVA: 0x00936FFF File Offset: 0x009351FF
		public TArray<SPanelQteAction> SuccessActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPanelQteAction> result;
				if ((result = this._SuccessActions) == null)
				{
					result = (this._SuccessActions = new TArray<SPanelQteAction>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_SuccessActions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SuccessActions.CopyAssign(value);
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0601FD62 RID: 130402 RVA: 0x00937010 File Offset: 0x00935210
		// (set) Token: 0x0601FD63 RID: 130403 RVA: 0x00937053 File Offset: 0x00935253
		public TArray<SPanelQteAction> FailActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPanelQteAction> result;
				if ((result = this._FailActions) == null)
				{
					result = (this._FailActions = new TArray<SPanelQteAction>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_FailActions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FailActions.CopyAssign(value);
			}
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0601FD64 RID: 130404 RVA: 0x00937061 File Offset: 0x00935261
		// (set) Token: 0x0601FD65 RID: 130405 RVA: 0x00937071 File Offset: 0x00935271
		public unsafe long BuffOnInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_BuffOnInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_BuffOnInput) = value;
			}
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0601FD66 RID: 130406 RVA: 0x00937082 File Offset: 0x00935282
		// (set) Token: 0x0601FD67 RID: 130407 RVA: 0x00937092 File Offset: 0x00935292
		public unsafe float BuffCd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_BuffCd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_BuffCd) = value;
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0601FD68 RID: 130408 RVA: 0x009370A3 File Offset: 0x009352A3
		// (set) Token: 0x0601FD69 RID: 130409 RVA: 0x009370B3 File Offset: 0x009352B3
		public unsafe bool CameraShakeOnInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_CameraShakeOnInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_CameraShakeOnInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0601FD6A RID: 130410 RVA: 0x009370C4 File Offset: 0x009352C4
		// (set) Token: 0x0601FD6B RID: 130411 RVA: 0x009370E3 File Offset: 0x009352E3
		public TSoftClassPtr<UMatineeCameraShake> CameraShakeType
		{
			get
			{
				return new TSoftClassPtr<UMatineeCameraShake>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_CameraShakeType, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_CameraShakeType, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0601FD6C RID: 130412 RVA: 0x00937108 File Offset: 0x00935308
		// (set) Token: 0x0601FD6D RID: 130413 RVA: 0x0093711C File Offset: 0x0093531C
		public unsafe string Action
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPanelQte.__PropertyOffset_Action)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPanelQte.__PropertyOffset_Action)), value);
			}
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0601FD6E RID: 130414 RVA: 0x00937131 File Offset: 0x00935331
		// (set) Token: 0x0601FD6F RID: 130415 RVA: 0x00937150 File Offset: 0x00935350
		public TSoftObjectPtr<ULGUITexturePackerSpriteData> Icon
		{
			get
			{
				return new TSoftObjectPtr<ULGUITexturePackerSpriteData>(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_Icon, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SPanelQte.__PropertyOffset_Icon, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601FD70 RID: 130416 RVA: 0x00937175 File Offset: 0x00935375
		public SPanelQte()
		{
		}

		// Token: 0x0601FD71 RID: 130417 RVA: 0x0093717D File Offset: 0x0093537D
		protected override IntPtr GetUStructPtr()
		{
			return SPanelQte.StaticStruct();
		}

		// Token: 0x0601FD72 RID: 130418 RVA: 0x00937189 File Offset: 0x00935389
		[NullableContext(2)]
		public SPanelQte(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD73 RID: 130419 RVA: 0x00937193 File Offset: 0x00935393
		public SPanelQte(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD74 RID: 130420 RVA: 0x0093719E File Offset: 0x0093539E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPanelQte(Pointer, false, true);
		}

		// Token: 0x0601FD75 RID: 130421 RVA: 0x009371A8 File Offset: 0x009353A8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPanelQte(Pointer, MemoryOwner);
		}

		// Token: 0x0401117B RID: 70011
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SPanelQte.SPanelQte";

		// Token: 0x0401117C RID: 70012
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401117D RID: 70013
		internal static int __PropertyOffset_ViewType;

		// Token: 0x0401117E RID: 70014
		internal static int __PropertyOffset_Duration;

		// Token: 0x0401117F RID: 70015
		internal static int __PropertyOffset_WorldTimeDilation;

		// Token: 0x04011180 RID: 70016
		internal static int __PropertyOffset_MinSuccessCount;

		// Token: 0x04011181 RID: 70017
		internal static int __PropertyOffset_MaxSuccessCount;

		// Token: 0x04011182 RID: 70018
		internal static int __PropertyOffset_HideAllBattleUi;

		// Token: 0x04011183 RID: 70019
		internal static int __PropertyOffset_HideUIElement;

		// Token: 0x04011184 RID: 70020
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EBattleUIChild>> _HideUIElement;

		// Token: 0x04011185 RID: 70021
		internal static int __PropertyOffset_SuccessActions;

		// Token: 0x04011186 RID: 70022
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPanelQteAction> _SuccessActions;

		// Token: 0x04011187 RID: 70023
		internal static int __PropertyOffset_FailActions;

		// Token: 0x04011188 RID: 70024
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPanelQteAction> _FailActions;

		// Token: 0x04011189 RID: 70025
		internal static int __PropertyOffset_BuffOnInput;

		// Token: 0x0401118A RID: 70026
		internal static int __PropertyOffset_BuffCd;

		// Token: 0x0401118B RID: 70027
		internal static int __PropertyOffset_CameraShakeOnInput;

		// Token: 0x0401118C RID: 70028
		internal static int __PropertyOffset_CameraShakeType;

		// Token: 0x0401118D RID: 70029
		internal static int __PropertyOffset_Action;

		// Token: 0x0401118E RID: 70030
		internal static int __PropertyOffset_Icon;
	}
}
