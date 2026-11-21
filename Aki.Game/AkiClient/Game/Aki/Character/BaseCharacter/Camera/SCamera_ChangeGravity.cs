using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E5 RID: 13285
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCamera_ChangeGravity.SCamera_ChangeGravity")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 37)]
	public class SCamera_ChangeGravity : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021ACC RID: 137932 RVA: 0x00966CD7 File Offset: 0x00964ED7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCamera_ChangeGravity._ScriptStructPtr != 0) ? SCamera_ChangeGravity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCamera_ChangeGravity.SCamera_ChangeGravity", ref SCamera_ChangeGravity._ScriptStructPtr);
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x06021ACD RID: 137933 RVA: 0x00966CFB File Offset: 0x00964EFB
		// (set) Token: 0x06021ACE RID: 137934 RVA: 0x00966D0F File Offset: 0x00964F0F
		public unsafe TEnumAsByte<ECameraGravityMode> GravityMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_GravityMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_GravityMode) = value;
			}
		}

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x06021ACF RID: 137935 RVA: 0x00966D24 File Offset: 0x00964F24
		// (set) Token: 0x06021AD0 RID: 137936 RVA: 0x00966D38 File Offset: 0x00964F38
		public unsafe FVector TargetGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_TargetGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_TargetGravity) = value;
			}
		}

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x06021AD1 RID: 137937 RVA: 0x00966D4D File Offset: 0x00964F4D
		// (set) Token: 0x06021AD2 RID: 137938 RVA: 0x00966D61 File Offset: 0x00964F61
		public unsafe TEnumAsByte<ECameraGravityLerpMode> LerpMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_LerpMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_LerpMode) = value;
			}
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x06021AD3 RID: 137939 RVA: 0x00966D76 File Offset: 0x00964F76
		// (set) Token: 0x06021AD4 RID: 137940 RVA: 0x00966D86 File Offset: 0x00964F86
		public unsafe float LerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_LerpTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_LerpTime) = value;
			}
		}

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x06021AD5 RID: 137941 RVA: 0x00966D97 File Offset: 0x00964F97
		// (set) Token: 0x06021AD6 RID: 137942 RVA: 0x00966DAB File Offset: 0x00964FAB
		[Nullable(2)]
		public unsafe UCurveFloat LerpTimeCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SCamera_ChangeGravity.__PropertyOffset_LerpTimeCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCamera_ChangeGravity.__PropertyOffset_LerpTimeCurve, value);
			}
		}

		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x06021AD7 RID: 137943 RVA: 0x00966DC0 File Offset: 0x00964FC0
		// (set) Token: 0x06021AD8 RID: 137944 RVA: 0x00966DD0 File Offset: 0x00964FD0
		public unsafe float LerpAngleVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_LerpAngleVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_LerpAngleVelocity) = value;
			}
		}

		// Token: 0x1700459D RID: 17821
		// (get) Token: 0x06021AD9 RID: 137945 RVA: 0x00966DE1 File Offset: 0x00964FE1
		// (set) Token: 0x06021ADA RID: 137946 RVA: 0x00966DF1 File Offset: 0x00964FF1
		public unsafe bool LerpAngleWhenFinish
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_LerpAngleWhenFinish) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_LerpAngleWhenFinish) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021ADB RID: 137947 RVA: 0x00966E02 File Offset: 0x00965002
		public SCamera_ChangeGravity()
		{
		}

		// Token: 0x06021ADC RID: 137948 RVA: 0x00966E0A File Offset: 0x0096500A
		protected override IntPtr GetUStructPtr()
		{
			return SCamera_ChangeGravity.StaticStruct();
		}

		// Token: 0x06021ADD RID: 137949 RVA: 0x00966E16 File Offset: 0x00965016
		[NullableContext(2)]
		public SCamera_ChangeGravity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021ADE RID: 137950 RVA: 0x00966E20 File Offset: 0x00965020
		public SCamera_ChangeGravity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021ADF RID: 137951 RVA: 0x00966E2B File Offset: 0x0096502B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCamera_ChangeGravity(Pointer, false, true);
		}

		// Token: 0x06021AE0 RID: 137952 RVA: 0x00966E35 File Offset: 0x00965035
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCamera_ChangeGravity(Pointer, MemoryOwner);
		}

		// Token: 0x040128D5 RID: 75989
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCamera_ChangeGravity.SCamera_ChangeGravity";

		// Token: 0x040128D6 RID: 75990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128D7 RID: 75991
		internal static int __PropertyOffset_GravityMode;

		// Token: 0x040128D8 RID: 75992
		internal static int __PropertyOffset_TargetGravity;

		// Token: 0x040128D9 RID: 75993
		internal static int __PropertyOffset_LerpMode;

		// Token: 0x040128DA RID: 75994
		internal static int __PropertyOffset_LerpTime;

		// Token: 0x040128DB RID: 75995
		internal static int __PropertyOffset_LerpTimeCurve;

		// Token: 0x040128DC RID: 75996
		internal static int __PropertyOffset_LerpAngleVelocity;

		// Token: 0x040128DD RID: 75997
		internal static int __PropertyOffset_LerpAngleWhenFinish;
	}
}
