using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C4 RID: 17348
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier.SCameraModifier")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 408)]
	public class SCameraModifier : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CDE7 RID: 183783 RVA: 0x00A2AFB8 File Offset: 0x00A291B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier._ScriptStructPtr != 0) ? SCameraModifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier.SCameraModifier", ref SCameraModifier._ScriptStructPtr);
		}

		// Token: 0x1700713D RID: 28989
		// (get) Token: 0x0602CDE8 RID: 183784 RVA: 0x00A2AFDC File Offset: 0x00A291DC
		// (set) Token: 0x0602CDE9 RID: 183785 RVA: 0x00A2AFEC File Offset: 0x00A291EC
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700713E RID: 28990
		// (get) Token: 0x0602CDEA RID: 183786 RVA: 0x00A2AFFD File Offset: 0x00A291FD
		// (set) Token: 0x0602CDEB RID: 183787 RVA: 0x00A2B00D File Offset: 0x00A2920D
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700713F RID: 28991
		// (get) Token: 0x0602CDEC RID: 183788 RVA: 0x00A2B01E File Offset: 0x00A2921E
		// (set) Token: 0x0602CDED RID: 183789 RVA: 0x00A2B02E File Offset: 0x00A2922E
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007140 RID: 28992
		// (get) Token: 0x0602CDEE RID: 183790 RVA: 0x00A2B03F File Offset: 0x00A2923F
		// (set) Token: 0x0602CDEF RID: 183791 RVA: 0x00A2B04F File Offset: 0x00A2924F
		public unsafe float BreakBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17007141 RID: 28993
		// (get) Token: 0x0602CDF0 RID: 183792 RVA: 0x00A2B060 File Offset: 0x00A29260
		// (set) Token: 0x0602CDF1 RID: 183793 RVA: 0x00A2B0A3 File Offset: 0x00A292A3
		public SCameraModifier_Settings Settings
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new SCameraModifier_Settings(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007142 RID: 28994
		// (get) Token: 0x0602CDF2 RID: 183794 RVA: 0x00A2B0C4 File Offset: 0x00A292C4
		// (set) Token: 0x0602CDF3 RID: 183795 RVA: 0x00A2B107 File Offset: 0x00A29307
		public SBaseCurve BlendInCurve
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BlendInCurve) == null)
				{
					result = (this._BlendInCurve = new SBaseCurve(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007143 RID: 28995
		// (get) Token: 0x0602CDF4 RID: 183796 RVA: 0x00A2B128 File Offset: 0x00A29328
		// (set) Token: 0x0602CDF5 RID: 183797 RVA: 0x00A2B16B File Offset: 0x00A2936B
		public SBaseCurve BlendOutCurve
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BlendOutCurve) == null)
				{
					result = (this._BlendOutCurve = new SBaseCurve(base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602CDF6 RID: 183798 RVA: 0x00A2B18C File Offset: 0x00A2938C
		public SCameraModifier()
		{
		}

		// Token: 0x0602CDF7 RID: 183799 RVA: 0x00A2B194 File Offset: 0x00A29394
		public SCameraModifier(float Duration, float BlendInTime, float BlendOutTime, float BreakBlendOutTime, SCameraModifier_Settings Settings, SBaseCurve BlendInCurve, SBaseCurve BlendOutCurve)
		{
			this.Duration = Duration;
			this.BlendInTime = BlendInTime;
			this.BlendOutTime = BlendOutTime;
			this.BreakBlendOutTime = BreakBlendOutTime;
			this.Settings = Settings;
			this.BlendInCurve = BlendInCurve;
			this.BlendOutCurve = BlendOutCurve;
		}

		// Token: 0x0602CDF8 RID: 183800 RVA: 0x00A2B1D1 File Offset: 0x00A293D1
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier.StaticStruct();
		}

		// Token: 0x0602CDF9 RID: 183801 RVA: 0x00A2B1DD File Offset: 0x00A293DD
		[NullableContext(2)]
		public SCameraModifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CDFA RID: 183802 RVA: 0x00A2B1E7 File Offset: 0x00A293E7
		public SCameraModifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CDFB RID: 183803 RVA: 0x00A2B1F2 File Offset: 0x00A293F2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier(Pointer, false, true);
		}

		// Token: 0x0602CDFC RID: 183804 RVA: 0x00A2B1FC File Offset: 0x00A293FC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier(Pointer, MemoryOwner);
		}

		// Token: 0x04017CF2 RID: 97522
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier.SCameraModifier";

		// Token: 0x04017CF3 RID: 97523
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017CF4 RID: 97524
		internal static int __PropertyOffset_0;

		// Token: 0x04017CF5 RID: 97525
		internal static int __PropertyOffset_1;

		// Token: 0x04017CF6 RID: 97526
		internal static int __PropertyOffset_2;

		// Token: 0x04017CF7 RID: 97527
		internal static int __PropertyOffset_3;

		// Token: 0x04017CF8 RID: 97528
		internal static int __PropertyOffset_4;

		// Token: 0x04017CF9 RID: 97529
		[Nullable(2)]
		private SCameraModifier_Settings _Settings;

		// Token: 0x04017CFA RID: 97530
		internal static int __PropertyOffset_5;

		// Token: 0x04017CFB RID: 97531
		[Nullable(2)]
		private SBaseCurve _BlendInCurve;

		// Token: 0x04017CFC RID: 97532
		internal static int __PropertyOffset_6;

		// Token: 0x04017CFD RID: 97533
		[Nullable(2)]
		private SBaseCurve _BlendOutCurve;
	}
}
