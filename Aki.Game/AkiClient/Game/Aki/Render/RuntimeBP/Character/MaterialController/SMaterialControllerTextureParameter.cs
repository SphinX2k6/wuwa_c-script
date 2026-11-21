using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003136 RID: 12598
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureParameter.SMaterialControllerTextureParameter")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SMaterialControllerTextureParameter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EFDA RID: 126938 RVA: 0x00922F55 File Offset: 0x00921155
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerTextureParameter._ScriptStructPtr != 0) ? SMaterialControllerTextureParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureParameter.SMaterialControllerTextureParameter", ref SMaterialControllerTextureParameter._ScriptStructPtr);
		}

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0601EFDB RID: 126939 RVA: 0x00922F79 File Offset: 0x00921179
		// (set) Token: 0x0601EFDC RID: 126940 RVA: 0x00922F8D File Offset: 0x0092118D
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMaterialControllerTextureParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMaterialControllerTextureParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0601EFDD RID: 126941 RVA: 0x00922FA4 File Offset: 0x009211A4
		// (set) Token: 0x0601EFDE RID: 126942 RVA: 0x00922FE7 File Offset: 0x009211E7
		public SMaterialControllerTextureGroup ParameterValue
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerTextureGroup result;
				if ((result = this._ParameterValue) == null)
				{
					result = (this._ParameterValue = new SMaterialControllerTextureGroup(base.NativePtr + (IntPtr)SMaterialControllerTextureParameter.__PropertyOffset_ParameterValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerTextureGroup.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerTextureParameter.__PropertyOffset_ParameterValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EFDF RID: 126943 RVA: 0x00923008 File Offset: 0x00921208
		public SMaterialControllerTextureParameter()
		{
		}

		// Token: 0x0601EFE0 RID: 126944 RVA: 0x00923010 File Offset: 0x00921210
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerTextureParameter.StaticStruct();
		}

		// Token: 0x0601EFE1 RID: 126945 RVA: 0x0092301C File Offset: 0x0092121C
		[NullableContext(2)]
		public SMaterialControllerTextureParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFE2 RID: 126946 RVA: 0x00923026 File Offset: 0x00921226
		public SMaterialControllerTextureParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFE3 RID: 126947 RVA: 0x00923031 File Offset: 0x00921231
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerTextureParameter(Pointer, false, true);
		}

		// Token: 0x0601EFE4 RID: 126948 RVA: 0x0092303B File Offset: 0x0092123B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerTextureParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04010801 RID: 67585
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureParameter.SMaterialControllerTextureParameter";

		// Token: 0x04010802 RID: 67586
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010803 RID: 67587
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04010804 RID: 67588
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x04010805 RID: 67589
		[Nullable(2)]
		private SMaterialControllerTextureGroup _ParameterValue;
	}
}
