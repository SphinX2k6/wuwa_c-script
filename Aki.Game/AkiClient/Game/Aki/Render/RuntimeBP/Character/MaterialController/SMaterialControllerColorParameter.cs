using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E19 RID: 15897
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorParameter.SMaterialControllerColorParameter")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1648)]
	public class SMaterialControllerColorParameter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027D95 RID: 163221 RVA: 0x0099CE3D File Offset: 0x0099B03D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerColorParameter._ScriptStructPtr != 0) ? SMaterialControllerColorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorParameter.SMaterialControllerColorParameter", ref SMaterialControllerColorParameter._ScriptStructPtr);
		}

		// Token: 0x17005A76 RID: 23158
		// (get) Token: 0x06027D96 RID: 163222 RVA: 0x0099CE61 File Offset: 0x0099B061
		// (set) Token: 0x06027D97 RID: 163223 RVA: 0x0099CE75 File Offset: 0x0099B075
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMaterialControllerColorParameter.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMaterialControllerColorParameter.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005A77 RID: 23159
		// (get) Token: 0x06027D98 RID: 163224 RVA: 0x0099CE8C File Offset: 0x0099B08C
		// (set) Token: 0x06027D99 RID: 163225 RVA: 0x0099CECF File Offset: 0x0099B0CF
		public SMaterialControllerColorGroup ParameterValue
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._ParameterValue) == null)
				{
					result = (this._ParameterValue = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)SMaterialControllerColorParameter.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerColorParameter.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027D9A RID: 163226 RVA: 0x0099CEF0 File Offset: 0x0099B0F0
		public SMaterialControllerColorParameter()
		{
		}

		// Token: 0x06027D9B RID: 163227 RVA: 0x0099CEF8 File Offset: 0x0099B0F8
		public SMaterialControllerColorParameter(FName ParameterName, SMaterialControllerColorGroup ParameterValue)
		{
			this.ParameterName = ParameterName;
			this.ParameterValue = ParameterValue;
		}

		// Token: 0x06027D9C RID: 163228 RVA: 0x0099CF0E File Offset: 0x0099B10E
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerColorParameter.StaticStruct();
		}

		// Token: 0x06027D9D RID: 163229 RVA: 0x0099CF1A File Offset: 0x0099B11A
		[NullableContext(2)]
		public SMaterialControllerColorParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027D9E RID: 163230 RVA: 0x0099CF24 File Offset: 0x0099B124
		public SMaterialControllerColorParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027D9F RID: 163231 RVA: 0x0099CF2F File Offset: 0x0099B12F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerColorParameter(Pointer, false, true);
		}

		// Token: 0x06027DA0 RID: 163232 RVA: 0x0099CF39 File Offset: 0x0099B139
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerColorParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0401433A RID: 82746
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorParameter.SMaterialControllerColorParameter";

		// Token: 0x0401433B RID: 82747
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401433C RID: 82748
		internal static int __PropertyOffset_0;

		// Token: 0x0401433D RID: 82749
		internal static int __PropertyOffset_1;

		// Token: 0x0401433E RID: 82750
		[Nullable(2)]
		private SMaterialControllerColorGroup _ParameterValue;
	}
}
