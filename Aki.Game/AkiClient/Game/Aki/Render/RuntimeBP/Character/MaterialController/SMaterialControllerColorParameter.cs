using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003131 RID: 12593
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorParameter.SMaterialControllerColorParameter")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1648)]
	public class SMaterialControllerColorParameter : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EFA3 RID: 126883 RVA: 0x00922A4C File Offset: 0x00920C4C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMaterialControllerColorParameter._ScriptStructPtr != 0) ? SMaterialControllerColorParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorParameter.SMaterialControllerColorParameter", ref SMaterialControllerColorParameter._ScriptStructPtr);
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0601EFA4 RID: 126884 RVA: 0x00922A70 File Offset: 0x00920C70
		// (set) Token: 0x0601EFA5 RID: 126885 RVA: 0x00922A84 File Offset: 0x00920C84
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMaterialControllerColorParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMaterialControllerColorParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0601EFA6 RID: 126886 RVA: 0x00922A9C File Offset: 0x00920C9C
		// (set) Token: 0x0601EFA7 RID: 126887 RVA: 0x00922ADF File Offset: 0x00920CDF
		public SMaterialControllerColorGroup ParameterValue
		{
			get
			{
				base.FastCheckIsValid();
				SMaterialControllerColorGroup result;
				if ((result = this._ParameterValue) == null)
				{
					result = (this._ParameterValue = new SMaterialControllerColorGroup(base.NativePtr + (IntPtr)SMaterialControllerColorParameter.__PropertyOffset_ParameterValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMaterialControllerColorGroup.StaticStruct(), base.NativePtr + (IntPtr)SMaterialControllerColorParameter.__PropertyOffset_ParameterValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601EFA8 RID: 126888 RVA: 0x00922B00 File Offset: 0x00920D00
		public SMaterialControllerColorParameter()
		{
		}

		// Token: 0x0601EFA9 RID: 126889 RVA: 0x00922B08 File Offset: 0x00920D08
		protected override IntPtr GetUStructPtr()
		{
			return SMaterialControllerColorParameter.StaticStruct();
		}

		// Token: 0x0601EFAA RID: 126890 RVA: 0x00922B14 File Offset: 0x00920D14
		[NullableContext(2)]
		public SMaterialControllerColorParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EFAB RID: 126891 RVA: 0x00922B1E File Offset: 0x00920D1E
		public SMaterialControllerColorParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EFAC RID: 126892 RVA: 0x00922B29 File Offset: 0x00920D29
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMaterialControllerColorParameter(Pointer, false, true);
		}

		// Token: 0x0601EFAD RID: 126893 RVA: 0x00922B33 File Offset: 0x00920D33
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMaterialControllerColorParameter(Pointer, MemoryOwner);
		}

		// Token: 0x040107E5 RID: 67557
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/SMaterialControllerColorParameter.SMaterialControllerColorParameter";

		// Token: 0x040107E6 RID: 67558
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040107E7 RID: 67559
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040107E8 RID: 67560
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x040107E9 RID: 67561
		[Nullable(2)]
		private SMaterialControllerColorGroup _ParameterValue;
	}
}
