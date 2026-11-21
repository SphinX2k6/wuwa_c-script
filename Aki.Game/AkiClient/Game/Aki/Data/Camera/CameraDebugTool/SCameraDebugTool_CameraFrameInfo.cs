using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003240 RID: 12864
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfo.SCameraDebugTool_CameraFrameInfo")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class SCameraDebugTool_CameraFrameInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602022F RID: 131631 RVA: 0x0093E2C6 File Offset: 0x0093C4C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_CameraFrameInfo._ScriptStructPtr != 0) ? SCameraDebugTool_CameraFrameInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfo.SCameraDebugTool_CameraFrameInfo", ref SCameraDebugTool_CameraFrameInfo._ScriptStructPtr);
		}

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x06020230 RID: 131632 RVA: 0x0093E2EA File Offset: 0x0093C4EA
		// (set) Token: 0x06020231 RID: 131633 RVA: 0x0093E2FA File Offset: 0x0093C4FA
		public unsafe long FrameNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_FrameNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_FrameNumber) = value;
			}
		}

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x06020232 RID: 131634 RVA: 0x0093E30C File Offset: 0x0093C50C
		// (set) Token: 0x06020233 RID: 131635 RVA: 0x0093E34F File Offset: 0x0093C54F
		public TMap<string, string> DesiredCameraProps
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._DesiredCameraProps) == null)
				{
					result = (this._DesiredCameraProps = new TMap<string, string>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_DesiredCameraProps, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DesiredCameraProps.CopyAssign(value);
			}
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x06020234 RID: 131636 RVA: 0x0093E360 File Offset: 0x0093C560
		// (set) Token: 0x06020235 RID: 131637 RVA: 0x0093E3A3 File Offset: 0x0093C5A3
		public TArray<SCameraDebugTool_ControllerModification> ControllerModifications
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraDebugTool_ControllerModification> result;
				if ((result = this._ControllerModifications) == null)
				{
					result = (this._ControllerModifications = new TArray<SCameraDebugTool_ControllerModification>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_ControllerModifications, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ControllerModifications.CopyAssign(value);
			}
		}

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x06020236 RID: 131638 RVA: 0x0093E3B4 File Offset: 0x0093C5B4
		// (set) Token: 0x06020237 RID: 131639 RVA: 0x0093E3F7 File Offset: 0x0093C5F7
		public TArray<SCameraDebugTool_SubCameraModification> SubCameraModifications
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraDebugTool_SubCameraModification> result;
				if ((result = this._SubCameraModifications) == null)
				{
					result = (this._SubCameraModifications = new TArray<SCameraDebugTool_SubCameraModification>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_SubCameraModifications, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubCameraModifications.CopyAssign(value);
			}
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x06020238 RID: 131640 RVA: 0x0093E408 File Offset: 0x0093C608
		// (set) Token: 0x06020239 RID: 131641 RVA: 0x0093E44B File Offset: 0x0093C64B
		public SCameraDebugTool_CameraModeInfo CamerModeInfo
		{
			get
			{
				base.FastCheckIsValid();
				SCameraDebugTool_CameraModeInfo result;
				if ((result = this._CamerModeInfo) == null)
				{
					result = (this._CamerModeInfo = new SCameraDebugTool_CameraModeInfo(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_CamerModeInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraDebugTool_CameraModeInfo.StaticStruct(), base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_CamerModeInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602023A RID: 131642 RVA: 0x0093E46C File Offset: 0x0093C66C
		public SCameraDebugTool_CameraFrameInfo()
		{
		}

		// Token: 0x0602023B RID: 131643 RVA: 0x0093E474 File Offset: 0x0093C674
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_CameraFrameInfo.StaticStruct();
		}

		// Token: 0x0602023C RID: 131644 RVA: 0x0093E480 File Offset: 0x0093C680
		[NullableContext(2)]
		public SCameraDebugTool_CameraFrameInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602023D RID: 131645 RVA: 0x0093E48A File Offset: 0x0093C68A
		public SCameraDebugTool_CameraFrameInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602023E RID: 131646 RVA: 0x0093E495 File Offset: 0x0093C695
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_CameraFrameInfo(Pointer, false, true);
		}

		// Token: 0x0602023F RID: 131647 RVA: 0x0093E49F File Offset: 0x0093C69F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_CameraFrameInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040114B9 RID: 70841
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfo.SCameraDebugTool_CameraFrameInfo";

		// Token: 0x040114BA RID: 70842
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040114BB RID: 70843
		internal static int __PropertyOffset_FrameNumber;

		// Token: 0x040114BC RID: 70844
		internal static int __PropertyOffset_DesiredCameraProps;

		// Token: 0x040114BD RID: 70845
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _DesiredCameraProps;

		// Token: 0x040114BE RID: 70846
		internal static int __PropertyOffset_ControllerModifications;

		// Token: 0x040114BF RID: 70847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraDebugTool_ControllerModification> _ControllerModifications;

		// Token: 0x040114C0 RID: 70848
		internal static int __PropertyOffset_SubCameraModifications;

		// Token: 0x040114C1 RID: 70849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraDebugTool_SubCameraModification> _SubCameraModifications;

		// Token: 0x040114C2 RID: 70850
		internal static int __PropertyOffset_CamerModeInfo;

		// Token: 0x040114C3 RID: 70851
		[Nullable(2)]
		private SCameraDebugTool_CameraModeInfo _CamerModeInfo;
	}
}
