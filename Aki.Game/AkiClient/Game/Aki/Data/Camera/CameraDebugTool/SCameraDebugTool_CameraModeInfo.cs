using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003242 RID: 12866
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraModeInfo.SCameraDebugTool_CameraModeInfo")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 132)]
	public class SCameraDebugTool_CameraModeInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602024D RID: 131661 RVA: 0x0093E59D File Offset: 0x0093C79D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_CameraModeInfo._ScriptStructPtr != 0) ? SCameraDebugTool_CameraModeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraModeInfo.SCameraDebugTool_CameraModeInfo", ref SCameraDebugTool_CameraModeInfo._ScriptStructPtr);
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0602024E RID: 131662 RVA: 0x0093E5C1 File Offset: 0x0093C7C1
		// (set) Token: 0x0602024F RID: 131663 RVA: 0x0093E5D5 File Offset: 0x0093C7D5
		public unsafe TEnumAsByte<ECustomCameraMode> CurrentCameraMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CurrentCameraMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CurrentCameraMode) = value;
			}
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x06020250 RID: 131664 RVA: 0x0093E5EC File Offset: 0x0093C7EC
		// (set) Token: 0x06020251 RID: 131665 RVA: 0x0093E62F File Offset: 0x0093C82F
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
					result = (this._CameraModeEnabledArray = new TArray<bool>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CameraModeEnabledArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CameraModeEnabledArray.CopyAssign(value);
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x06020252 RID: 131666 RVA: 0x0093E63D File Offset: 0x0093C83D
		// (set) Token: 0x06020253 RID: 131667 RVA: 0x0093E651 File Offset: 0x0093C851
		public unsafe TEnumAsByte<ECameraGravityMode> CurrentCameraGravityMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CurrentCameraGravityMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CurrentCameraGravityMode) = value;
			}
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x06020254 RID: 131668 RVA: 0x0093E666 File Offset: 0x0093C866
		// (set) Token: 0x06020255 RID: 131669 RVA: 0x0093E67A File Offset: 0x0093C87A
		public unsafe FVectorDouble CameraGravityDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CameraGravityDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CameraGravityDirect) = value;
			}
		}

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x06020256 RID: 131670 RVA: 0x0093E68F File Offset: 0x0093C88F
		// (set) Token: 0x06020257 RID: 131671 RVA: 0x0093E6A3 File Offset: 0x0093C8A3
		public unsafe FVectorDouble PlayerGravityDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_PlayerGravityDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_PlayerGravityDirect) = value;
			}
		}

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x06020258 RID: 131672 RVA: 0x0093E6B8 File Offset: 0x0093C8B8
		// (set) Token: 0x06020259 RID: 131673 RVA: 0x0093E6CC File Offset: 0x0093C8CC
		public unsafe FRotator CameraRotationInGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CameraRotationInGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_CameraRotationInGravity) = value;
			}
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0602025A RID: 131674 RVA: 0x0093E6E1 File Offset: 0x0093C8E1
		// (set) Token: 0x0602025B RID: 131675 RVA: 0x0093E6F5 File Offset: 0x0093C8F5
		public unsafe FVectorDouble PlayerLocationInGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_PlayerLocationInGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_PlayerLocationInGravity) = value;
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0602025C RID: 131676 RVA: 0x0093E70A File Offset: 0x0093C90A
		// (set) Token: 0x0602025D RID: 131677 RVA: 0x0093E71E File Offset: 0x0093C91E
		public unsafe FRotator PlayerRotatorInGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_PlayerRotatorInGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraModeInfo.__PropertyOffset_PlayerRotatorInGravity) = value;
			}
		}

		// Token: 0x0602025E RID: 131678 RVA: 0x0093E733 File Offset: 0x0093C933
		public SCameraDebugTool_CameraModeInfo()
		{
		}

		// Token: 0x0602025F RID: 131679 RVA: 0x0093E73B File Offset: 0x0093C93B
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_CameraModeInfo.StaticStruct();
		}

		// Token: 0x06020260 RID: 131680 RVA: 0x0093E747 File Offset: 0x0093C947
		[NullableContext(2)]
		public SCameraDebugTool_CameraModeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020261 RID: 131681 RVA: 0x0093E751 File Offset: 0x0093C951
		public SCameraDebugTool_CameraModeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020262 RID: 131682 RVA: 0x0093E75C File Offset: 0x0093C95C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_CameraModeInfo(Pointer, false, true);
		}

		// Token: 0x06020263 RID: 131683 RVA: 0x0093E766 File Offset: 0x0093C966
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_CameraModeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040114CA RID: 70858
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraModeInfo.SCameraDebugTool_CameraModeInfo";

		// Token: 0x040114CB RID: 70859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040114CC RID: 70860
		internal static int __PropertyOffset_CurrentCameraMode;

		// Token: 0x040114CD RID: 70861
		internal static int __PropertyOffset_CameraModeEnabledArray;

		// Token: 0x040114CE RID: 70862
		[Nullable(2)]
		private TArray<bool> _CameraModeEnabledArray;

		// Token: 0x040114CF RID: 70863
		internal static int __PropertyOffset_CurrentCameraGravityMode;

		// Token: 0x040114D0 RID: 70864
		internal static int __PropertyOffset_CameraGravityDirect;

		// Token: 0x040114D1 RID: 70865
		internal static int __PropertyOffset_PlayerGravityDirect;

		// Token: 0x040114D2 RID: 70866
		internal static int __PropertyOffset_CameraRotationInGravity;

		// Token: 0x040114D3 RID: 70867
		internal static int __PropertyOffset_PlayerLocationInGravity;

		// Token: 0x040114D4 RID: 70868
		internal static int __PropertyOffset_PlayerRotatorInGravity;
	}
}
