using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.CameraDebugTool
{
	// Token: 0x02003243 RID: 12867
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraProperty.SCameraDebugTool_CameraProperty")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 21)]
	public class SCameraDebugTool_CameraProperty : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020264 RID: 131684 RVA: 0x0093E76F File Offset: 0x0093C96F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraDebugTool_CameraProperty._ScriptStructPtr != 0) ? SCameraDebugTool_CameraProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraProperty.SCameraDebugTool_CameraProperty", ref SCameraDebugTool_CameraProperty._ScriptStructPtr);
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x06020265 RID: 131685 RVA: 0x0093E793 File Offset: 0x0093C993
		// (set) Token: 0x06020266 RID: 131686 RVA: 0x0093E7A7 File Offset: 0x0093C9A7
		public unsafe string PropertyName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_PropertyName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_PropertyName)), value);
			}
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x06020267 RID: 131687 RVA: 0x0093E7BC File Offset: 0x0093C9BC
		// (set) Token: 0x06020268 RID: 131688 RVA: 0x0093E7CC File Offset: 0x0093C9CC
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x06020269 RID: 131689 RVA: 0x0093E7DD File Offset: 0x0093C9DD
		// (set) Token: 0x0602026A RID: 131690 RVA: 0x0093E7ED File Offset: 0x0093C9ED
		public unsafe bool IsEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_IsEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraDebugTool_CameraProperty.__PropertyOffset_IsEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602026B RID: 131691 RVA: 0x0093E7FE File Offset: 0x0093C9FE
		public SCameraDebugTool_CameraProperty()
		{
		}

		// Token: 0x0602026C RID: 131692 RVA: 0x0093E806 File Offset: 0x0093CA06
		protected override IntPtr GetUStructPtr()
		{
			return SCameraDebugTool_CameraProperty.StaticStruct();
		}

		// Token: 0x0602026D RID: 131693 RVA: 0x0093E812 File Offset: 0x0093CA12
		[NullableContext(2)]
		public SCameraDebugTool_CameraProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602026E RID: 131694 RVA: 0x0093E81C File Offset: 0x0093CA1C
		public SCameraDebugTool_CameraProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602026F RID: 131695 RVA: 0x0093E827 File Offset: 0x0093CA27
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraDebugTool_CameraProperty(Pointer, false, true);
		}

		// Token: 0x06020270 RID: 131696 RVA: 0x0093E831 File Offset: 0x0093CA31
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraDebugTool_CameraProperty(Pointer, MemoryOwner);
		}

		// Token: 0x040114D5 RID: 70869
		public const string __ObjectPath = "/Game/Aki/Data/Camera/CameraDebugTool/SCameraDebugTool_CameraProperty.SCameraDebugTool_CameraProperty";

		// Token: 0x040114D6 RID: 70870
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040114D7 RID: 70871
		internal static int __PropertyOffset_PropertyName;

		// Token: 0x040114D8 RID: 70872
		internal static int __PropertyOffset_Value;

		// Token: 0x040114D9 RID: 70873
		internal static int __PropertyOffset_IsEffect;
	}
}
