using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003FB8 RID: 16312
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfo.SCameraDebugTool_CameraFrameInfo")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class SCameraDebugTool_CameraFrameInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C03 RID: 171011 RVA: 0x009CBB32 File Offset: 0x009C9D32
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_CameraFrameInfo._ScriptStructPtr != 0) ? SCameraDebugTool_CameraFrameInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfo.SCameraDebugTool_CameraFrameInfo", ref SCameraDebugTool_CameraFrameInfo._ScriptStructPtr);
		}

		// Token: 0x1700651C RID: 25884
		// (get) Token: 0x06029C04 RID: 171012 RVA: 0x009CBB56 File Offset: 0x009C9D56
		// (set) Token: 0x06029C05 RID: 171013 RVA: 0x009CBB66 File Offset: 0x009C9D66
		public unsafe long FrameNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700651D RID: 25885
		// (get) Token: 0x06029C06 RID: 171014 RVA: 0x009CBB78 File Offset: 0x009C9D78
		// (set) Token: 0x06029C07 RID: 171015 RVA: 0x009CBBBB File Offset: 0x009C9DBB
		public TMap<string, string> DesiredCameraProps
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._DesiredCameraProps) == null)
				{
					result = (this._DesiredCameraProps = new TMap<string, string>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DesiredCameraProps.CopyAssign(value);
			}
		}

		// Token: 0x1700651E RID: 25886
		// (get) Token: 0x06029C08 RID: 171016 RVA: 0x009CBBCC File Offset: 0x009C9DCC
		// (set) Token: 0x06029C09 RID: 171017 RVA: 0x009CBC0F File Offset: 0x009C9E0F
		public TArray<SCameraDebugTool_ControllerModification> ControllerModifications
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraDebugTool_ControllerModification> result;
				if ((result = this._ControllerModifications) == null)
				{
					result = (this._ControllerModifications = new TArray<SCameraDebugTool_ControllerModification>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ControllerModifications.CopyAssign(value);
			}
		}

		// Token: 0x1700651F RID: 25887
		// (get) Token: 0x06029C0A RID: 171018 RVA: 0x009CBC20 File Offset: 0x009C9E20
		// (set) Token: 0x06029C0B RID: 171019 RVA: 0x009CBC63 File Offset: 0x009C9E63
		public TArray<SCameraDebugTool_SubCameraModification> SubCameraModifications
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraDebugTool_SubCameraModification> result;
				if ((result = this._SubCameraModifications) == null)
				{
					result = (this._SubCameraModifications = new TArray<SCameraDebugTool_SubCameraModification>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubCameraModifications.CopyAssign(value);
			}
		}

		// Token: 0x17006520 RID: 25888
		// (get) Token: 0x06029C0C RID: 171020 RVA: 0x009CBC74 File Offset: 0x009C9E74
		// (set) Token: 0x06029C0D RID: 171021 RVA: 0x009CBCB7 File Offset: 0x009C9EB7
		public SCameraDebugTool_CameraModeInfo CamerModeInfo
		{
			get
			{
				base.FastCheckIsValid();
				SCameraDebugTool_CameraModeInfo result;
				if ((result = this._CamerModeInfo) == null)
				{
					result = (this._CamerModeInfo = new SCameraDebugTool_CameraModeInfo(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraDebugTool_CameraModeInfo.StaticStruct(), base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfo.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06029C0E RID: 171022 RVA: 0x009CBCD8 File Offset: 0x009C9ED8
		public SCameraDebugTool_CameraFrameInfo()
		{
		}

		// Token: 0x06029C0F RID: 171023 RVA: 0x009CBCE0 File Offset: 0x009C9EE0
		public SCameraDebugTool_CameraFrameInfo(long FrameNumber, TMap<string, string> DesiredCameraProps, TArray<SCameraDebugTool_ControllerModification> ControllerModifications, TArray<SCameraDebugTool_SubCameraModification> SubCameraModifications, SCameraDebugTool_CameraModeInfo CamerModeInfo)
		{
			this.FrameNumber = FrameNumber;
			this.DesiredCameraProps = DesiredCameraProps;
			this.ControllerModifications = ControllerModifications;
			this.SubCameraModifications = SubCameraModifications;
			this.CamerModeInfo = CamerModeInfo;
		}

		// Token: 0x06029C10 RID: 171024 RVA: 0x009CBD0D File Offset: 0x009C9F0D
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_CameraFrameInfo.StaticStruct();
		}

		// Token: 0x06029C11 RID: 171025 RVA: 0x009CBD19 File Offset: 0x009C9F19
		[NullableContext(2)]
		public SCameraDebugTool_CameraFrameInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C12 RID: 171026 RVA: 0x009CBD23 File Offset: 0x009C9F23
		public SCameraDebugTool_CameraFrameInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C13 RID: 171027 RVA: 0x009CBD2E File Offset: 0x009C9F2E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_CameraFrameInfo(Pointer, false, true);
		}

		// Token: 0x06029C14 RID: 171028 RVA: 0x009CBD38 File Offset: 0x009C9F38
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_CameraFrameInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04015711 RID: 87825
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfo.SCameraDebugTool_CameraFrameInfo";

		// Token: 0x04015712 RID: 87826
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015713 RID: 87827
		internal static int __PropertyOffset_0;

		// Token: 0x04015714 RID: 87828
		internal static int __PropertyOffset_1;

		// Token: 0x04015715 RID: 87829
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _DesiredCameraProps;

		// Token: 0x04015716 RID: 87830
		internal static int __PropertyOffset_2;

		// Token: 0x04015717 RID: 87831
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraDebugTool_ControllerModification> _ControllerModifications;

		// Token: 0x04015718 RID: 87832
		internal static int __PropertyOffset_3;

		// Token: 0x04015719 RID: 87833
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraDebugTool_SubCameraModification> _SubCameraModifications;

		// Token: 0x0401571A RID: 87834
		internal static int __PropertyOffset_4;

		// Token: 0x0401571B RID: 87835
		[Nullable(2)]
		private SCameraDebugTool_CameraModeInfo _CamerModeInfo;
	}
}
