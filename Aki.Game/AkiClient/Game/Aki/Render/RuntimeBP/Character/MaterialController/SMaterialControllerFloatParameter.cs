using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003133 RID: 12595
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatParameter.SMaterialControllerFloatParameter")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 448)]
	public class SMaterialControllerFloatParameter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EFBB RID: 126907 RVA: 0x00922CC8 File Offset: 0x00920EC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerFloatParameter._ScriptStructPtr != 0) ? SMaterialControllerFloatParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatParameter.SMaterialControllerFloatParameter", ref SMaterialControllerFloatParameter._ScriptStructPtr);
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0601EFBC RID: 126908 RVA: 0x00922CEC File Offset: 0x00920EEC
		// (set) Token: 0x0601EFBD RID: 126909 RVA: 0x00922D00 File Offset: 0x00920F00
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMaterialControllerFloatParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMaterialControllerFloatParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0601EFBE RID: 126910 RVA: 0x00922D18 File Offset: 0x00920F18
		// (set) Token: 0x0601EFBF RID: 126911 RVA: 0x00922D5B File Offset: 0x00920F5B
		public SMaterialControllerFloatGroup ParameterValue
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._ParameterValue) == null)
				{
					result = (this._ParameterValue = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)SMaterialControllerFloatParameter.__PropertyOffset_ParameterValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerFloatParameter.__PropertyOffset_ParameterValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EFC0 RID: 126912 RVA: 0x00922D7C File Offset: 0x00920F7C
		public SMaterialControllerFloatParameter()
		{
		}

		// Token: 0x0601EFC1 RID: 126913 RVA: 0x00922D84 File Offset: 0x00920F84
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerFloatParameter.StaticStruct();
		}

		// Token: 0x0601EFC2 RID: 126914 RVA: 0x00922D90 File Offset: 0x00920F90
		[NullableContext(2)]
		public SMaterialControllerFloatParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFC3 RID: 126915 RVA: 0x00922D9A File Offset: 0x00920F9A
		public SMaterialControllerFloatParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFC4 RID: 126916 RVA: 0x00922DA5 File Offset: 0x00920FA5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerFloatParameter(Pointer, false, true);
		}

		// Token: 0x0601EFC5 RID: 126917 RVA: 0x00922DAF File Offset: 0x00920FAF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerFloatParameter(Pointer, MemoryOwner);
		}

		// Token: 0x040107F2 RID: 67570
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatParameter.SMaterialControllerFloatParameter";

		// Token: 0x040107F3 RID: 67571
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040107F4 RID: 67572
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040107F5 RID: 67573
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x040107F6 RID: 67574
		[Nullable(2)]
		private SMaterialControllerFloatGroup _ParameterValue;
	}
}
