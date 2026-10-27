using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003FB9 RID: 16313
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfoRegion.SCameraDebugTool_CameraFrameInfoRegion")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SCameraDebugTool_CameraFrameInfoRegion : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C15 RID: 171029 RVA: 0x009CBD41 File Offset: 0x009C9F41
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_CameraFrameInfoRegion._ScriptStructPtr != 0) ? SCameraDebugTool_CameraFrameInfoRegion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfoRegion.SCameraDebugTool_CameraFrameInfoRegion", ref SCameraDebugTool_CameraFrameInfoRegion._ScriptStructPtr);
		}

		// Token: 0x17006521 RID: 25889
		// (get) Token: 0x06029C16 RID: 171030 RVA: 0x009CBD65 File Offset: 0x009C9F65
		// (set) Token: 0x06029C17 RID: 171031 RVA: 0x009CBD75 File Offset: 0x009C9F75
		public unsafe long StartFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006522 RID: 25890
		// (get) Token: 0x06029C18 RID: 171032 RVA: 0x009CBD86 File Offset: 0x009C9F86
		// (set) Token: 0x06029C19 RID: 171033 RVA: 0x009CBD96 File Offset: 0x009C9F96
		public unsafe long EndFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006523 RID: 25891
		// (get) Token: 0x06029C1A RID: 171034 RVA: 0x009CBDA8 File Offset: 0x009C9FA8
		// (set) Token: 0x06029C1B RID: 171035 RVA: 0x009CBDEB File Offset: 0x009C9FEB
		public TArray<SCameraDebugTool_CameraFrameInfo> CameraFrameInfoArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraDebugTool_CameraFrameInfo> result;
				if ((result = this._CameraFrameInfoArray) == null)
				{
					result = (this._CameraFrameInfoArray = new TArray<SCameraDebugTool_CameraFrameInfo>(base.NativePtr + (IntPtr)SCameraDebugTool_CameraFrameInfoRegion.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CameraFrameInfoArray.CopyAssign(value);
			}
		}

		// Token: 0x06029C1C RID: 171036 RVA: 0x009CBDF9 File Offset: 0x009C9FF9
		public SCameraDebugTool_CameraFrameInfoRegion()
		{
		}

		// Token: 0x06029C1D RID: 171037 RVA: 0x009CBE01 File Offset: 0x009CA001
		public SCameraDebugTool_CameraFrameInfoRegion(long StartFrame, long EndFrame, TArray<SCameraDebugTool_CameraFrameInfo> CameraFrameInfoArray)
		{
			this.StartFrame = StartFrame;
			this.EndFrame = EndFrame;
			this.CameraFrameInfoArray = CameraFrameInfoArray;
		}

		// Token: 0x06029C1E RID: 171038 RVA: 0x009CBE1E File Offset: 0x009CA01E
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_CameraFrameInfoRegion.StaticStruct();
		}

		// Token: 0x06029C1F RID: 171039 RVA: 0x009CBE2A File Offset: 0x009CA02A
		[NullableContext(2)]
		public SCameraDebugTool_CameraFrameInfoRegion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C20 RID: 171040 RVA: 0x009CBE34 File Offset: 0x009CA034
		public SCameraDebugTool_CameraFrameInfoRegion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C21 RID: 171041 RVA: 0x009CBE3F File Offset: 0x009CA03F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_CameraFrameInfoRegion(Pointer, false, true);
		}

		// Token: 0x06029C22 RID: 171042 RVA: 0x009CBE49 File Offset: 0x009CA049
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_CameraFrameInfoRegion(Pointer, MemoryOwner);
		}

		// Token: 0x0401571C RID: 87836
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraFrameInfoRegion.SCameraDebugTool_CameraFrameInfoRegion";

		// Token: 0x0401571D RID: 87837
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401571E RID: 87838
		internal static int __PropertyOffset_0;

		// Token: 0x0401571F RID: 87839
		internal static int __PropertyOffset_1;

		// Token: 0x04015720 RID: 87840
		internal static int __PropertyOffset_2;

		// Token: 0x04015721 RID: 87841
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraDebugTool_CameraFrameInfo> _CameraFrameInfoArray;
	}
}
