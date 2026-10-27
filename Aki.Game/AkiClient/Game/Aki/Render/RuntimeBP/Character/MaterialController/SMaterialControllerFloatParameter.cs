using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E1B RID: 15899
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatParameter.SMaterialControllerFloatParameter")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 448)]
	public class SMaterialControllerFloatParameter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027DAF RID: 163247 RVA: 0x0099D0ED File Offset: 0x0099B2ED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerFloatParameter._ScriptStructPtr != 0) ? SMaterialControllerFloatParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatParameter.SMaterialControllerFloatParameter", ref SMaterialControllerFloatParameter._ScriptStructPtr);
		}

		// Token: 0x17005A7B RID: 23163
		// (get) Token: 0x06027DB0 RID: 163248 RVA: 0x0099D111 File Offset: 0x0099B311
		// (set) Token: 0x06027DB1 RID: 163249 RVA: 0x0099D125 File Offset: 0x0099B325
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMaterialControllerFloatParameter.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMaterialControllerFloatParameter.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005A7C RID: 23164
		// (get) Token: 0x06027DB2 RID: 163250 RVA: 0x0099D13C File Offset: 0x0099B33C
		// (set) Token: 0x06027DB3 RID: 163251 RVA: 0x0099D17F File Offset: 0x0099B37F
		public SMaterialControllerFloatGroup ParameterValue
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerFloatGroup result;
				if ((result = this._ParameterValue) == null)
				{
					result = (this._ParameterValue = new SMaterialControllerFloatGroup(base.NativePtr + (IntPtr)SMaterialControllerFloatParameter.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerFloatParameter.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027DB4 RID: 163252 RVA: 0x0099D1A0 File Offset: 0x0099B3A0
		public SMaterialControllerFloatParameter()
		{
		}

		// Token: 0x06027DB5 RID: 163253 RVA: 0x0099D1A8 File Offset: 0x0099B3A8
		public SMaterialControllerFloatParameter(FName ParameterName, SMaterialControllerFloatGroup ParameterValue)
		{
			this.ParameterName = ParameterName;
			this.ParameterValue = ParameterValue;
		}

		// Token: 0x06027DB6 RID: 163254 RVA: 0x0099D1BE File Offset: 0x0099B3BE
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerFloatParameter.StaticStruct();
		}

		// Token: 0x06027DB7 RID: 163255 RVA: 0x0099D1CA File Offset: 0x0099B3CA
		[NullableContext(2)]
		public SMaterialControllerFloatParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027DB8 RID: 163256 RVA: 0x0099D1D4 File Offset: 0x0099B3D4
		public SMaterialControllerFloatParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027DB9 RID: 163257 RVA: 0x0099D1DF File Offset: 0x0099B3DF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerFloatParameter(Pointer, false, true);
		}

		// Token: 0x06027DBA RID: 163258 RVA: 0x0099D1E9 File Offset: 0x0099B3E9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerFloatParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04014347 RID: 82759
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerFloatParameter.SMaterialControllerFloatParameter";

		// Token: 0x04014348 RID: 82760
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014349 RID: 82761
		internal static int __PropertyOffset_0;

		// Token: 0x0401434A RID: 82762
		internal static int __PropertyOffset_1;

		// Token: 0x0401434B RID: 82763
		[Nullable(2)]
		private SMaterialControllerFloatGroup _ParameterValue;
	}
}
