using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E1F RID: 15903
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureParameter.SMaterialControllerTextureParameter")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SMaterialControllerTextureParameter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027DD7 RID: 163287 RVA: 0x0099D4A4 File Offset: 0x0099B6A4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerTextureParameter._ScriptStructPtr != 0) ? SMaterialControllerTextureParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureParameter.SMaterialControllerTextureParameter", ref SMaterialControllerTextureParameter._ScriptStructPtr);
		}

		// Token: 0x17005A80 RID: 23168
		// (get) Token: 0x06027DD8 RID: 163288 RVA: 0x0099D4C8 File Offset: 0x0099B6C8
		// (set) Token: 0x06027DD9 RID: 163289 RVA: 0x0099D4DC File Offset: 0x0099B6DC
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMaterialControllerTextureParameter.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMaterialControllerTextureParameter.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005A81 RID: 23169
		// (get) Token: 0x06027DDA RID: 163290 RVA: 0x0099D4F4 File Offset: 0x0099B6F4
		// (set) Token: 0x06027DDB RID: 163291 RVA: 0x0099D537 File Offset: 0x0099B737
		public SMaterialControllerTextureGroup ParameterValue
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerTextureGroup result;
				if ((result = this._ParameterValue) == null)
				{
					result = (this._ParameterValue = new SMaterialControllerTextureGroup(base.NativePtr + (IntPtr)SMaterialControllerTextureParameter.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerTextureGroup.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerTextureParameter.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027DDC RID: 163292 RVA: 0x0099D558 File Offset: 0x0099B758
		public SMaterialControllerTextureParameter()
		{
		}

		// Token: 0x06027DDD RID: 163293 RVA: 0x0099D560 File Offset: 0x0099B760
		public SMaterialControllerTextureParameter(FName ParameterName, SMaterialControllerTextureGroup ParameterValue)
		{
			this.ParameterName = ParameterName;
			this.ParameterValue = ParameterValue;
		}

		// Token: 0x06027DDE RID: 163294 RVA: 0x0099D576 File Offset: 0x0099B776
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerTextureParameter.StaticStruct();
		}

		// Token: 0x06027DDF RID: 163295 RVA: 0x0099D582 File Offset: 0x0099B782
		[NullableContext(2)]
		public SMaterialControllerTextureParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027DE0 RID: 163296 RVA: 0x0099D58C File Offset: 0x0099B78C
		public SMaterialControllerTextureParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027DE1 RID: 163297 RVA: 0x0099D597 File Offset: 0x0099B797
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerTextureParameter(Pointer, false, true);
		}

		// Token: 0x06027DE2 RID: 163298 RVA: 0x0099D5A1 File Offset: 0x0099B7A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerTextureParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0401435C RID: 82780
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerTextureParameter.SMaterialControllerTextureParameter";

		// Token: 0x0401435D RID: 82781
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401435E RID: 82782
		internal static int __PropertyOffset_0;

		// Token: 0x0401435F RID: 82783
		internal static int __PropertyOffset_1;

		// Token: 0x04014360 RID: 82784
		[Nullable(2)]
		private SMaterialControllerTextureGroup _ParameterValue;
	}
}
