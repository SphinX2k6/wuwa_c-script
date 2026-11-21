using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020032A2 RID: 12962
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_OverShoulderModeConfig.BP_OverShoulderModeConfig_C")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class BP_OverShoulderModeConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020997 RID: 133527 RVA: 0x0094AA23 File Offset: 0x00948C23
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_OverShoulderModeConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_OverShoulderModeConfig.BP_OverShoulderModeConfig_C");
			}
			return BP_OverShoulderModeConfig_C._ClassPtr;
		}

		// Token: 0x06020998 RID: 133528 RVA: 0x0094AA48 File Offset: 0x00948C48
		public BP_OverShoulderModeConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_OverShoulderModeConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020999 RID: 133529 RVA: 0x0094AA70 File Offset: 0x00948C70
		public BP_OverShoulderModeConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_OverShoulderModeConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x0602099A RID: 133530 RVA: 0x0094AAA3 File Offset: 0x00948CA3
		// (set) Token: 0x0602099B RID: 133531 RVA: 0x0094AAB3 File Offset: 0x00948CB3
		public unsafe float MinTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_MinTurnSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_MinTurnSpeed) = value;
			}
		}

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x0602099C RID: 133532 RVA: 0x0094AAC4 File Offset: 0x00948CC4
		// (set) Token: 0x0602099D RID: 133533 RVA: 0x0094AAD4 File Offset: 0x00948CD4
		public unsafe float MaxTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_MaxTurnSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_MaxTurnSpeed) = value;
			}
		}

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x0602099E RID: 133534 RVA: 0x0094AAE5 File Offset: 0x00948CE5
		// (set) Token: 0x0602099F RID: 133535 RVA: 0x0094AAF5 File Offset: 0x00948CF5
		public unsafe float LerpBeginDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_LerpBeginDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_LerpBeginDeg) = value;
			}
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x060209A0 RID: 133536 RVA: 0x0094AB06 File Offset: 0x00948D06
		// (set) Token: 0x060209A1 RID: 133537 RVA: 0x0094AB1A File Offset: 0x00948D1A
		[Nullable(2)]
		public unsafe UCurveFloat LerpCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OverShoulderModeConfig_C.__PropertyOffset_LerpCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OverShoulderModeConfig_C.__PropertyOffset_LerpCurve, value);
			}
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x060209A2 RID: 133538 RVA: 0x0094AB2F File Offset: 0x00948D2F
		// (set) Token: 0x060209A3 RID: 133539 RVA: 0x0094AB3F File Offset: 0x00948D3F
		public unsafe float LerpPow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_LerpPow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_LerpPow) = value;
			}
		}

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x060209A4 RID: 133540 RVA: 0x0094AB50 File Offset: 0x00948D50
		// (set) Token: 0x060209A5 RID: 133541 RVA: 0x0094AB60 File Offset: 0x00948D60
		public unsafe float SprintExitInputDegAbs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_SprintExitInputDegAbs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_SprintExitInputDegAbs) = value;
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x060209A6 RID: 133542 RVA: 0x0094AB74 File Offset: 0x00948D74
		// (set) Token: 0x060209A7 RID: 133543 RVA: 0x0094ABAD File Offset: 0x00948DAD
		public FGameplayTagContainer TagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TagList) == null)
				{
					result = (this._TagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_TagList, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_OverShoulderModeConfig_C.__PropertyOffset_TagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060209A8 RID: 133544 RVA: 0x0094ABCE File Offset: 0x00948DCE
		protected BP_OverShoulderModeConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119F1 RID: 72177
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_OverShoulderModeConfig.BP_OverShoulderModeConfig_C";

		// Token: 0x040119F2 RID: 72178
		private static IntPtr _ClassPtr;

		// Token: 0x040119F3 RID: 72179
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119F4 RID: 72180
		internal static int __PropertyOffset_MinTurnSpeed;

		// Token: 0x040119F5 RID: 72181
		internal static int __PropertyOffset_MaxTurnSpeed;

		// Token: 0x040119F6 RID: 72182
		internal static int __PropertyOffset_LerpBeginDeg;

		// Token: 0x040119F7 RID: 72183
		internal static int __PropertyOffset_LerpCurve;

		// Token: 0x040119F8 RID: 72184
		internal static int __PropertyOffset_LerpPow;

		// Token: 0x040119F9 RID: 72185
		internal static int __PropertyOffset_SprintExitInputDegAbs;

		// Token: 0x040119FA RID: 72186
		internal static int __PropertyOffset_TagList;

		// Token: 0x040119FB RID: 72187
		[Nullable(2)]
		private FGameplayTagContainer _TagList;
	}
}
