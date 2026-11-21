using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E7 RID: 13287
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SFloatCurve.SFloatCurve")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SFloatCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021B2C RID: 138028 RVA: 0x00967352 File Offset: 0x00965552
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatCurve._ScriptStructPtr != 0) ? SFloatCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SFloatCurve.SFloatCurve", ref SFloatCurve._ScriptStructPtr);
		}

		// Token: 0x170045C0 RID: 17856
		// (get) Token: 0x06021B2D RID: 138029 RVA: 0x00967376 File Offset: 0x00965576
		// (set) Token: 0x06021B2E RID: 138030 RVA: 0x0096738A File Offset: 0x0096558A
		[Nullable(2)]
		public unsafe UCurveFloat FloatCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SFloatCurve.__PropertyOffset_FloatCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFloatCurve.__PropertyOffset_FloatCurve, value);
			}
		}

		// Token: 0x06021B2F RID: 138031 RVA: 0x0096739F File Offset: 0x0096559F
		public SFloatCurve()
		{
		}

		// Token: 0x06021B30 RID: 138032 RVA: 0x009673A7 File Offset: 0x009655A7
		protected override IntPtr GetUStructPtr()
		{
			return SFloatCurve.StaticStruct();
		}

		// Token: 0x06021B31 RID: 138033 RVA: 0x009673B3 File Offset: 0x009655B3
		[NullableContext(2)]
		public SFloatCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B32 RID: 138034 RVA: 0x009673BD File Offset: 0x009655BD
		public SFloatCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B33 RID: 138035 RVA: 0x009673C8 File Offset: 0x009655C8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatCurve(Pointer, false, true);
		}

		// Token: 0x06021B34 RID: 138036 RVA: 0x009673D2 File Offset: 0x009655D2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04012903 RID: 76035
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SFloatCurve.SFloatCurve";

		// Token: 0x04012904 RID: 76036
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012905 RID: 76037
		internal static int __PropertyOffset_FloatCurve;
	}
}
