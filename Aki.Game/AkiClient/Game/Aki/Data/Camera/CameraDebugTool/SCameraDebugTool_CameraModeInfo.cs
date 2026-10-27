using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003FBA RID: 16314
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraModeInfo.SCameraDebugTool_CameraModeInfo")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 132)]
	public class SCameraDebugTool_CameraModeInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C23 RID: 171043 RVA: 0x009CBE52 File Offset: 0x009CA052
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_CameraModeInfo._ScriptStructPtr != 0) ? SCameraDebugTool_CameraModeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraModeInfo.SCameraDebugTool_CameraModeInfo", ref SCameraDebugTool_CameraModeInfo._ScriptStructPtr);
		}

		// Token: 0x17006524 RID: 25892
		// (get) Token: 0x06029C24 RID: 171044 RVA: 0x009CBE76 File Offset: 0x009CA076
		// (set) Token: 0x06029C25 RID: 171045 RVA: 0x009CBE8A File Offset: 0x009CA08A
		public unsafe TEnumAsByte<ECustomCameraMode> CurrentCameraMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006525 RID: 25893
		// (get) Token: 0x06029C26 RID: 171046 RVA: 0x009CBEA0 File Offset: 0x009CA0A0
		// (set) Token: 0x06029C27 RID: 171047 RVA: 0x009CBEE3 File Offset: 0x009CA0E3
		[Nullable(1)]
		public TArray<bool> CameraModeEnabledArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._CameraModeEnabledArray) == null)
				{
					result = (this._CameraModeEnabledArray = new TArray<bool>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CameraModeEnabledArray.CopyAssign(value);
			}
		}

		// Token: 0x17006526 RID: 25894
		// (get) Token: 0x06029C28 RID: 171048 RVA: 0x009CBEF1 File Offset: 0x009CA0F1
		// (set) Token: 0x06029C29 RID: 171049 RVA: 0x009CBF05 File Offset: 0x009CA105
		public unsafe TEnumAsByte<ECameraGravityMode> CurrentCameraGravityMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006527 RID: 25895
		// (get) Token: 0x06029C2A RID: 171050 RVA: 0x009CBF1A File Offset: 0x009CA11A
		// (set) Token: 0x06029C2B RID: 171051 RVA: 0x009CBF2E File Offset: 0x009CA12E
		public unsafe FVectorDouble CameraGravityDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006528 RID: 25896
		// (get) Token: 0x06029C2C RID: 171052 RVA: 0x009CBF43 File Offset: 0x009CA143
		// (set) Token: 0x06029C2D RID: 171053 RVA: 0x009CBF57 File Offset: 0x009CA157
		public unsafe FVectorDouble PlayerGravityDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006529 RID: 25897
		// (get) Token: 0x06029C2E RID: 171054 RVA: 0x009CBF6C File Offset: 0x009CA16C
		// (set) Token: 0x06029C2F RID: 171055 RVA: 0x009CBF80 File Offset: 0x009CA180
		public unsafe FRotator CameraRotationInGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700652A RID: 25898
		// (get) Token: 0x06029C30 RID: 171056 RVA: 0x009CBF95 File Offset: 0x009CA195
		// (set) Token: 0x06029C31 RID: 171057 RVA: 0x009CBFA9 File Offset: 0x009CA1A9
		public unsafe FVectorDouble PlayerLocationInGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700652B RID: 25899
		// (get) Token: 0x06029C32 RID: 171058 RVA: 0x009CBFBE File Offset: 0x009CA1BE
		// (set) Token: 0x06029C33 RID: 171059 RVA: 0x009CBFD2 File Offset: 0x009CA1D2
		public unsafe FRotator PlayerRotatorInGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x06029C34 RID: 171060 RVA: 0x009CBFE7 File Offset: 0x009CA1E7
		public SCameraDebugTool_CameraModeInfo()
		{
		}

		// Token: 0x06029C35 RID: 171061 RVA: 0x009CBFF0 File Offset: 0x009CA1F0
		public SCameraDebugTool_CameraModeInfo(TEnumAsByte<ECustomCameraMode> CurrentCameraMode, [Nullable(1)] TArray<bool> CameraModeEnabledArray, TEnumAsByte<ECameraGravityMode> CurrentCameraGravityMode, FVectorDouble CameraGravityDirect, FVectorDouble PlayerGravityDirect, FRotator CameraRotationInGravity, FVectorDouble PlayerLocationInGravity, FRotator PlayerRotatorInGravity)
		{
			this.CurrentCameraMode = CurrentCameraMode;
			this.CameraModeEnabledArray = CameraModeEnabledArray;
			this.CurrentCameraGravityMode = CurrentCameraGravityMode;
			this.CameraGravityDirect = CameraGravityDirect;
			this.PlayerGravityDirect = PlayerGravityDirect;
			this.CameraRotationInGravity = CameraRotationInGravity;
			this.PlayerLocationInGravity = PlayerLocationInGravity;
			this.PlayerRotatorInGravity = PlayerRotatorInGravity;
		}

		// Token: 0x06029C36 RID: 171062 RVA: 0x009CC040 File Offset: 0x009CA240
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_CameraModeInfo.StaticStruct();
		}

		// Token: 0x06029C37 RID: 171063 RVA: 0x009CC04C File Offset: 0x009CA24C
		[NullableContext(2)]
		public SCameraDebugTool_CameraModeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C38 RID: 171064 RVA: 0x009CC056 File Offset: 0x009CA256
		public SCameraDebugTool_CameraModeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C39 RID: 171065 RVA: 0x009CC061 File Offset: 0x009CA261
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_CameraModeInfo(Pointer, false, true);
		}

		// Token: 0x06029C3A RID: 171066 RVA: 0x009CC06B File Offset: 0x009CA26B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_CameraModeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04015722 RID: 87842
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraModeInfo.SCameraDebugTool_CameraModeInfo";

		// Token: 0x04015723 RID: 87843
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015724 RID: 87844
		internal static int __PropertyOffset_0;

		// Token: 0x04015725 RID: 87845
		internal static int __PropertyOffset_1;

		// Token: 0x04015726 RID: 87846
		[Nullable(2)]
		private TArray<bool> _CameraModeEnabledArray;

		// Token: 0x04015727 RID: 87847
		internal static int __PropertyOffset_2;

		// Token: 0x04015728 RID: 87848
		internal static int __PropertyOffset_3;

		// Token: 0x04015729 RID: 87849
		internal static int __PropertyOffset_4;

		// Token: 0x0401572A RID: 87850
		internal static int __PropertyOffset_5;

		// Token: 0x0401572B RID: 87851
		internal static int __PropertyOffset_6;

		// Token: 0x0401572C RID: 87852
		internal static int __PropertyOffset_7;
	}
}
