using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043CE RID: 17358
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SFloatCurve.SFloatCurve")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SFloatCurve : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CF58 RID: 184152 RVA: 0x00A2D3B8 File Offset: 0x00A2B5B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatCurve._ScriptStructPtr != 0) ? SFloatCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SFloatCurve.SFloatCurve", ref SFloatCurve._ScriptStructPtr);
		}

		// Token: 0x170071CE RID: 29134
		// (get) Token: 0x0602CF59 RID: 184153 RVA: 0x00A2D3DC File Offset: 0x00A2B5DC
		// (set) Token: 0x0602CF5A RID: 184154 RVA: 0x00A2D3F0 File Offset: 0x00A2B5F0
		[Nullable(2)]
		public unsafe UCurveFloat FloatCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SFloatCurve.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SFloatCurve.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0602CF5B RID: 184155 RVA: 0x00A2D405 File Offset: 0x00A2B605
		public SFloatCurve()
		{
		}

		// Token: 0x0602CF5C RID: 184156 RVA: 0x00A2D40D File Offset: 0x00A2B60D
		[NullableContext(1)]
		public SFloatCurve(UCurveFloat FloatCurve)
		{
			this.FloatCurve = FloatCurve;
		}

		// Token: 0x0602CF5D RID: 184157 RVA: 0x00A2D41C File Offset: 0x00A2B61C
		protected override IntPtr GetUStructPtr()
		{
			return SFloatCurve.StaticStruct();
		}

		// Token: 0x0602CF5E RID: 184158 RVA: 0x00A2D428 File Offset: 0x00A2B628
		[NullableContext(2)]
		public SFloatCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CF5F RID: 184159 RVA: 0x00A2D432 File Offset: 0x00A2B632
		public SFloatCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CF60 RID: 184160 RVA: 0x00A2D43D File Offset: 0x00A2B63D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatCurve(Pointer, false, true);
		}

		// Token: 0x0602CF61 RID: 184161 RVA: 0x00A2D447 File Offset: 0x00A2B647
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04017DB8 RID: 97720
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SFloatCurve.SFloatCurve";

		// Token: 0x04017DB9 RID: 97721
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017DBA RID: 97722
		internal static int __PropertyOffset_0;
	}
}
