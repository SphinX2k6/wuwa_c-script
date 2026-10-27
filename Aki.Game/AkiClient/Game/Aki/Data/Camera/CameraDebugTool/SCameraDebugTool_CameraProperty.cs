using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003FBB RID: 16315
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraProperty.SCameraDebugTool_CameraProperty")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 21)]
	public class SCameraDebugTool_CameraProperty : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C3B RID: 171067 RVA: 0x009CC074 File Offset: 0x009CA274
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_CameraProperty._ScriptStructPtr != 0) ? SCameraDebugTool_CameraProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraProperty.SCameraDebugTool_CameraProperty", ref SCameraDebugTool_CameraProperty._ScriptStructPtr);
		}

		// Token: 0x1700652C RID: 25900
		// (get) Token: 0x06029C3C RID: 171068 RVA: 0x009CC098 File Offset: 0x009CA298
		// (set) Token: 0x06029C3D RID: 171069 RVA: 0x009CC0AC File Offset: 0x009CA2AC
		public unsafe string PropertyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700652D RID: 25901
		// (get) Token: 0x06029C3E RID: 171070 RVA: 0x009CC0C1 File Offset: 0x009CA2C1
		// (set) Token: 0x06029C3F RID: 171071 RVA: 0x009CC0D1 File Offset: 0x009CA2D1
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700652E RID: 25902
		// (get) Token: 0x06029C40 RID: 171072 RVA: 0x009CC0E2 File Offset: 0x009CA2E2
		// (set) Token: 0x06029C41 RID: 171073 RVA: 0x009CC0F2 File Offset: 0x009CA2F2
		public unsafe bool IsEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x06029C42 RID: 171074 RVA: 0x009CC103 File Offset: 0x009CA303
		public SCameraDebugTool_CameraProperty()
		{
		}

		// Token: 0x06029C43 RID: 171075 RVA: 0x009CC10B File Offset: 0x009CA30B
		public SCameraDebugTool_CameraProperty(string PropertyName, float Value, bool IsEffect)
		{
			this.PropertyName = PropertyName;
			this.Value = Value;
			this.IsEffect = IsEffect;
		}

		// Token: 0x06029C44 RID: 171076 RVA: 0x009CC128 File Offset: 0x009CA328
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_CameraProperty.StaticStruct();
		}

		// Token: 0x06029C45 RID: 171077 RVA: 0x009CC134 File Offset: 0x009CA334
		[NullableContext(2)]
		public SCameraDebugTool_CameraProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C46 RID: 171078 RVA: 0x009CC13E File Offset: 0x009CA33E
		public SCameraDebugTool_CameraProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C47 RID: 171079 RVA: 0x009CC149 File Offset: 0x009CA349
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_CameraProperty(Pointer, false, true);
		}

		// Token: 0x06029C48 RID: 171080 RVA: 0x009CC153 File Offset: 0x009CA353
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_CameraProperty(Pointer, MemoryOwner);
		}

		// Token: 0x0401572D RID: 87853
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraProperty.SCameraDebugTool_CameraProperty";

		// Token: 0x0401572E RID: 87854
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401572F RID: 87855
		internal static int __PropertyOffset_0;

		// Token: 0x04015730 RID: 87856
		internal static int __PropertyOffset_1;

		// Token: 0x04015731 RID: 87857
		internal static int __PropertyOffset_2;
	}
}
