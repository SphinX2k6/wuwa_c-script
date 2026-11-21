using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033DF RID: 13279
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier.SCameraModifier")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 408)]
	public class SCameraModifier : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219EE RID: 137710 RVA: 0x009659C1 File Offset: 0x00963BC1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier._ScriptStructPtr != 0) ? SCameraModifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier.SCameraModifier", ref SCameraModifier._ScriptStructPtr);
		}

		// Token: 0x1700453D RID: 17725
		// (get) Token: 0x060219EF RID: 137711 RVA: 0x009659E5 File Offset: 0x00963BE5
		// (set) Token: 0x060219F0 RID: 137712 RVA: 0x009659F5 File Offset: 0x00963BF5
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x1700453E RID: 17726
		// (get) Token: 0x060219F1 RID: 137713 RVA: 0x00965A06 File Offset: 0x00963C06
		// (set) Token: 0x060219F2 RID: 137714 RVA: 0x00965A16 File Offset: 0x00963C16
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x1700453F RID: 17727
		// (get) Token: 0x060219F3 RID: 137715 RVA: 0x00965A27 File Offset: 0x00963C27
		// (set) Token: 0x060219F4 RID: 137716 RVA: 0x00965A37 File Offset: 0x00963C37
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BlendOutTime) = value;
			}
		}

		// Token: 0x17004540 RID: 17728
		// (get) Token: 0x060219F5 RID: 137717 RVA: 0x00965A48 File Offset: 0x00963C48
		// (set) Token: 0x060219F6 RID: 137718 RVA: 0x00965A58 File Offset: 0x00963C58
		public unsafe float BreakBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BreakBlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BreakBlendOutTime) = value;
			}
		}

		// Token: 0x17004541 RID: 17729
		// (get) Token: 0x060219F7 RID: 137719 RVA: 0x00965A6C File Offset: 0x00963C6C
		// (set) Token: 0x060219F8 RID: 137720 RVA: 0x00965AAF File Offset: 0x00963CAF
		public SCameraModifier_Settings Settings
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new SCameraModifier_Settings(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_Settings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004542 RID: 17730
		// (get) Token: 0x060219F9 RID: 137721 RVA: 0x00965AD0 File Offset: 0x00963CD0
		// (set) Token: 0x060219FA RID: 137722 RVA: 0x00965B13 File Offset: 0x00963D13
		public SBaseCurve BlendInCurve
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BlendInCurve) == null)
				{
					result = (this._BlendInCurve = new SBaseCurve(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BlendInCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BlendInCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004543 RID: 17731
		// (get) Token: 0x060219FB RID: 137723 RVA: 0x00965B34 File Offset: 0x00963D34
		// (set) Token: 0x060219FC RID: 137724 RVA: 0x00965B77 File Offset: 0x00963D77
		public SBaseCurve BlendOutCurve
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BlendOutCurve) == null)
				{
					result = (this._BlendOutCurve = new SBaseCurve(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BlendOutCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_BlendOutCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060219FD RID: 137725 RVA: 0x00965B98 File Offset: 0x00963D98
		public SCameraModifier()
		{
		}

		// Token: 0x060219FE RID: 137726 RVA: 0x00965BA0 File Offset: 0x00963DA0
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier.StaticStruct();
		}

		// Token: 0x060219FF RID: 137727 RVA: 0x00965BAC File Offset: 0x00963DAC
		[NullableContext(2)]
		public SCameraModifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021A00 RID: 137728 RVA: 0x00965BB6 File Offset: 0x00963DB6
		public SCameraModifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021A01 RID: 137729 RVA: 0x00965BC1 File Offset: 0x00963DC1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier(Pointer, false, true);
		}

		// Token: 0x06021A02 RID: 137730 RVA: 0x00965BCB File Offset: 0x00963DCB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier(Pointer, MemoryOwner);
		}

		// Token: 0x0401285A RID: 75866
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier.SCameraModifier";

		// Token: 0x0401285B RID: 75867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401285C RID: 75868
		internal static int __PropertyOffset_Duration;

		// Token: 0x0401285D RID: 75869
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x0401285E RID: 75870
		internal static int __PropertyOffset_BlendOutTime;

		// Token: 0x0401285F RID: 75871
		internal static int __PropertyOffset_BreakBlendOutTime;

		// Token: 0x04012860 RID: 75872
		internal static int __PropertyOffset_Settings;

		// Token: 0x04012861 RID: 75873
		[Nullable(2)]
		private SCameraModifier_Settings _Settings;

		// Token: 0x04012862 RID: 75874
		internal static int __PropertyOffset_BlendInCurve;

		// Token: 0x04012863 RID: 75875
		[Nullable(2)]
		private SBaseCurve _BlendInCurve;

		// Token: 0x04012864 RID: 75876
		internal static int __PropertyOffset_BlendOutCurve;

		// Token: 0x04012865 RID: 75877
		[Nullable(2)]
		private SBaseCurve _BlendOutCurve;
	}
}
