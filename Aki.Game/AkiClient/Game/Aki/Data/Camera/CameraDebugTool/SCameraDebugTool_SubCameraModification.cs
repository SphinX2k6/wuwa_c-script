using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003245 RID: 12869
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_SubCameraModification.SCameraDebugTool_SubCameraModification")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SCameraDebugTool_SubCameraModification : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020280 RID: 131712 RVA: 0x0093E93E File Offset: 0x0093CB3E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_SubCameraModification._ScriptStructPtr != 0) ? SCameraDebugTool_SubCameraModification._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_SubCameraModification.SCameraDebugTool_SubCameraModification", ref SCameraDebugTool_SubCameraModification._ScriptStructPtr);
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x06020281 RID: 131713 RVA: 0x0093E962 File Offset: 0x0093CB62
		// (set) Token: 0x06020282 RID: 131714 RVA: 0x0093E976 File Offset: 0x0093CB76
		public unsafe string CameraTag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_CameraTag)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_CameraTag)), value);
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x06020283 RID: 131715 RVA: 0x0093E98B File Offset: 0x0093CB8B
		// (set) Token: 0x06020284 RID: 131716 RVA: 0x0093E99F File Offset: 0x0093CB9F
		public unsafe string CameraType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_CameraType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_CameraType)), value);
			}
		}

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x06020285 RID: 131717 RVA: 0x0093E9B4 File Offset: 0x0093CBB4
		// (set) Token: 0x06020286 RID: 131718 RVA: 0x0093E9C4 File Offset: 0x0093CBC4
		public unsafe int CameraPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_CameraPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_CameraPriority) = value;
			}
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x06020287 RID: 131719 RVA: 0x0093E9D8 File Offset: 0x0093CBD8
		// (set) Token: 0x06020288 RID: 131720 RVA: 0x0093EA1B File Offset: 0x0093CC1B
		public TArray<SCameraDebugTool_CameraProperty> ModifiedProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraDebugTool_CameraProperty> result;
				if ((result = this._ModifiedProperties) == null)
				{
					result = (this._ModifiedProperties = new TArray<SCameraDebugTool_CameraProperty>(base.NativePtr + (IntPtr)SCameraDebugTool_SubCameraModification.__PropertyOffset_ModifiedProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifiedProperties.CopyAssign(value);
			}
		}

		// Token: 0x06020289 RID: 131721 RVA: 0x0093EA29 File Offset: 0x0093CC29
		public SCameraDebugTool_SubCameraModification()
		{
		}

		// Token: 0x0602028A RID: 131722 RVA: 0x0093EA31 File Offset: 0x0093CC31
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_SubCameraModification.StaticStruct();
		}

		// Token: 0x0602028B RID: 131723 RVA: 0x0093EA3D File Offset: 0x0093CC3D
		[NullableContext(2)]
		public SCameraDebugTool_SubCameraModification(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602028C RID: 131724 RVA: 0x0093EA47 File Offset: 0x0093CC47
		public SCameraDebugTool_SubCameraModification(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602028D RID: 131725 RVA: 0x0093EA52 File Offset: 0x0093CC52
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_SubCameraModification(Pointer, false, true);
		}

		// Token: 0x0602028E RID: 131726 RVA: 0x0093EA5C File Offset: 0x0093CC5C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_SubCameraModification(Pointer, MemoryOwner);
		}

		// Token: 0x040114E0 RID: 70880
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_SubCameraModification.SCameraDebugTool_SubCameraModification";

		// Token: 0x040114E1 RID: 70881
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040114E2 RID: 70882
		internal static int __PropertyOffset_CameraTag;

		// Token: 0x040114E3 RID: 70883
		internal static int __PropertyOffset_CameraType;

		// Token: 0x040114E4 RID: 70884
		internal static int __PropertyOffset_CameraPriority;

		// Token: 0x040114E5 RID: 70885
		internal static int __PropertyOffset_ModifiedProperties;

		// Token: 0x040114E6 RID: 70886
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraDebugTool_CameraProperty> _ModifiedProperties;
	}
}
