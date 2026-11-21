using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003241 RID: 12865
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfoRegion.SCameraDebugTool_CameraFrameInfoRegion")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SCameraDebugTool_CameraFrameInfoRegion : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020240 RID: 131648 RVA: 0x0093E4A8 File Offset: 0x0093C6A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_CameraFrameInfoRegion._ScriptStructPtr != 0) ? SCameraDebugTool_CameraFrameInfoRegion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfoRegion.SCameraDebugTool_CameraFrameInfoRegion", ref SCameraDebugTool_CameraFrameInfoRegion._ScriptStructPtr);
		}

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x06020241 RID: 131649 RVA: 0x0093E4CC File Offset: 0x0093C6CC
		// (set) Token: 0x06020242 RID: 131650 RVA: 0x0093E4DC File Offset: 0x0093C6DC
		public unsafe long StartFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_StartFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_StartFrame) = value;
			}
		}

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x06020243 RID: 131651 RVA: 0x0093E4ED File Offset: 0x0093C6ED
		// (set) Token: 0x06020244 RID: 131652 RVA: 0x0093E4FD File Offset: 0x0093C6FD
		public unsafe long EndFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_EndFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_EndFrame) = value;
			}
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x06020245 RID: 131653 RVA: 0x0093E510 File Offset: 0x0093C710
		// (set) Token: 0x06020246 RID: 131654 RVA: 0x0093E553 File Offset: 0x0093C753
		public TArray<SCameraDebugTool_CameraFrameInfo> CameraFrameInfoArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraDebugTool_CameraFrameInfo> result;
				if ((result = this._CameraFrameInfoArray) == null)
				{
					result = (this._CameraFrameInfoArray = new TArray<SCameraDebugTool_CameraFrameInfo>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_CameraFrameInfoArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CameraFrameInfoArray.CopyAssign(value);
			}
		}

		// Token: 0x06020247 RID: 131655 RVA: 0x0093E561 File Offset: 0x0093C761
		public SCameraDebugTool_CameraFrameInfoRegion()
		{
		}

		// Token: 0x06020248 RID: 131656 RVA: 0x0093E569 File Offset: 0x0093C769
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_CameraFrameInfoRegion.StaticStruct();
		}

		// Token: 0x06020249 RID: 131657 RVA: 0x0093E575 File Offset: 0x0093C775
		[NullableContext(2)]
		public SCameraDebugTool_CameraFrameInfoRegion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602024A RID: 131658 RVA: 0x0093E57F File Offset: 0x0093C77F
		public SCameraDebugTool_CameraFrameInfoRegion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602024B RID: 131659 RVA: 0x0093E58A File Offset: 0x0093C78A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_CameraFrameInfoRegion(Pointer, false, true);
		}

		// Token: 0x0602024C RID: 131660 RVA: 0x0093E594 File Offset: 0x0093C794
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_CameraFrameInfoRegion(Pointer, MemoryOwner);
		}

		// Token: 0x040114C4 RID: 70852
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfoRegion.SCameraDebugTool_CameraFrameInfoRegion";

		// Token: 0x040114C5 RID: 70853
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040114C6 RID: 70854
		internal static int __PropertyOffset_StartFrame;

		// Token: 0x040114C7 RID: 70855
		internal static int __PropertyOffset_EndFrame;

		// Token: 0x040114C8 RID: 70856
		internal static int __PropertyOffset_CameraFrameInfoArray;

		// Token: 0x040114C9 RID: 70857
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraDebugTool_CameraFrameInfo> _CameraFrameInfoArray;
	}
}
