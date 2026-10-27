using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043CA RID: 17354
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCamera_ChangeGravity.SCamera_ChangeGravity")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 37)]
	public class SCamera_ChangeGravity : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CECA RID: 184010 RVA: 0x00A2C5D4 File Offset: 0x00A2A7D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCamera_ChangeGravity._ScriptStructPtr != 0) ? SCamera_ChangeGravity._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCamera_ChangeGravity.SCamera_ChangeGravity", ref SCamera_ChangeGravity._ScriptStructPtr);
		}

		// Token: 0x17007197 RID: 29079
		// (get) Token: 0x0602CECB RID: 184011 RVA: 0x00A2C5F8 File Offset: 0x00A2A7F8
		// (set) Token: 0x0602CECC RID: 184012 RVA: 0x00A2C60C File Offset: 0x00A2A80C
		public unsafe TEnumAsByte<ECameraGravityMode> GravityMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007198 RID: 29080
		// (get) Token: 0x0602CECD RID: 184013 RVA: 0x00A2C621 File Offset: 0x00A2A821
		// (set) Token: 0x0602CECE RID: 184014 RVA: 0x00A2C635 File Offset: 0x00A2A835
		public unsafe FVector TargetGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007199 RID: 29081
		// (get) Token: 0x0602CECF RID: 184015 RVA: 0x00A2C64A File Offset: 0x00A2A84A
		// (set) Token: 0x0602CED0 RID: 184016 RVA: 0x00A2C65E File Offset: 0x00A2A85E
		public unsafe TEnumAsByte<ECameraGravityLerpMode> LerpMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700719A RID: 29082
		// (get) Token: 0x0602CED1 RID: 184017 RVA: 0x00A2C673 File Offset: 0x00A2A873
		// (set) Token: 0x0602CED2 RID: 184018 RVA: 0x00A2C683 File Offset: 0x00A2A883
		public unsafe float LerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700719B RID: 29083
		// (get) Token: 0x0602CED3 RID: 184019 RVA: 0x00A2C694 File Offset: 0x00A2A894
		// (set) Token: 0x0602CED4 RID: 184020 RVA: 0x00A2C6A8 File Offset: 0x00A2A8A8
		[Nullable(2)]
		public unsafe UCurveFloat LerpTimeCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + SCamera_ChangeGravity.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCamera_ChangeGravity.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700719C RID: 29084
		// (get) Token: 0x0602CED5 RID: 184021 RVA: 0x00A2C6BD File Offset: 0x00A2A8BD
		// (set) Token: 0x0602CED6 RID: 184022 RVA: 0x00A2C6CD File Offset: 0x00A2A8CD
		public unsafe float LerpAngleVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700719D RID: 29085
		// (get) Token: 0x0602CED7 RID: 184023 RVA: 0x00A2C6DE File Offset: 0x00A2A8DE
		// (set) Token: 0x0602CED8 RID: 184024 RVA: 0x00A2C6EE File Offset: 0x00A2A8EE
		public unsafe bool LerpAngleWhenFinish
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_ChangeGravity.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CED9 RID: 184025 RVA: 0x00A2C6FF File Offset: 0x00A2A8FF
		public SCamera_ChangeGravity()
		{
		}

		// Token: 0x0602CEDA RID: 184026 RVA: 0x00A2C707 File Offset: 0x00A2A907
		public SCamera_ChangeGravity(TEnumAsByte<ECameraGravityMode> GravityMode, FVector TargetGravity, TEnumAsByte<ECameraGravityLerpMode> LerpMode, float LerpTime, [Nullable(1)] UCurveFloat LerpTimeCurve, float LerpAngleVelocity, bool LerpAngleWhenFinish)
		{
			this.GravityMode = GravityMode;
			this.TargetGravity = TargetGravity;
			this.LerpMode = LerpMode;
			this.LerpTime = LerpTime;
			this.LerpTimeCurve = LerpTimeCurve;
			this.LerpAngleVelocity = LerpAngleVelocity;
			this.LerpAngleWhenFinish = LerpAngleWhenFinish;
		}

		// Token: 0x0602CEDB RID: 184027 RVA: 0x00A2C744 File Offset: 0x00A2A944
		protected override IntPtr GetUStructPtr()
		{
			return SCamera_ChangeGravity.StaticStruct();
		}

		// Token: 0x0602CEDC RID: 184028 RVA: 0x00A2C750 File Offset: 0x00A2A950
		[NullableContext(2)]
		public SCamera_ChangeGravity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CEDD RID: 184029 RVA: 0x00A2C75A File Offset: 0x00A2A95A
		public SCamera_ChangeGravity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CEDE RID: 184030 RVA: 0x00A2C765 File Offset: 0x00A2A965
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCamera_ChangeGravity(Pointer, false, true);
		}

		// Token: 0x0602CEDF RID: 184031 RVA: 0x00A2C76F File Offset: 0x00A2A96F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCamera_ChangeGravity(Pointer, MemoryOwner);
		}

		// Token: 0x04017D6D RID: 97645
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCamera_ChangeGravity.SCamera_ChangeGravity";

		// Token: 0x04017D6E RID: 97646
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017D6F RID: 97647
		internal static int __PropertyOffset_0;

		// Token: 0x04017D70 RID: 97648
		internal static int __PropertyOffset_1;

		// Token: 0x04017D71 RID: 97649
		internal static int __PropertyOffset_2;

		// Token: 0x04017D72 RID: 97650
		internal static int __PropertyOffset_3;

		// Token: 0x04017D73 RID: 97651
		internal static int __PropertyOffset_4;

		// Token: 0x04017D74 RID: 97652
		internal static int __PropertyOffset_5;

		// Token: 0x04017D75 RID: 97653
		internal static int __PropertyOffset_6;
	}
}
