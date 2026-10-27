using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043D3 RID: 17363
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_SpecificConfig.SSequenceCamera_SpecificConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 14)]
	public class SSequenceCamera_SpecificConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CFAF RID: 184239 RVA: 0x00A2DAA8 File Offset: 0x00A2BCA8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequenceCamera_SpecificConfig._ScriptStructPtr != 0) ? SSequenceCamera_SpecificConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_SpecificConfig.SSequenceCamera_SpecificConfig", ref SSequenceCamera_SpecificConfig._ScriptStructPtr);
		}

		// Token: 0x170071E6 RID: 29158
		// (get) Token: 0x0602CFB0 RID: 184240 RVA: 0x00A2DACC File Offset: 0x00A2BCCC
		// (set) Token: 0x0602CFB1 RID: 184241 RVA: 0x00A2DAE0 File Offset: 0x00A2BCE0
		public unsafe TEnumAsByte<ESequenceCameraSpecificType> SpecificType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170071E7 RID: 29159
		// (get) Token: 0x0602CFB2 RID: 184242 RVA: 0x00A2DAF5 File Offset: 0x00A2BCF5
		// (set) Token: 0x0602CFB3 RID: 184243 RVA: 0x00A2DB05 File Offset: 0x00A2BD05
		public unsafe float OverrideSequenceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170071E8 RID: 29160
		// (get) Token: 0x0602CFB4 RID: 184244 RVA: 0x00A2DB16 File Offset: 0x00A2BD16
		// (set) Token: 0x0602CFB5 RID: 184245 RVA: 0x00A2DB26 File Offset: 0x00A2BD26
		public unsafe float OverrideBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170071E9 RID: 29161
		// (get) Token: 0x0602CFB6 RID: 184246 RVA: 0x00A2DB37 File Offset: 0x00A2BD37
		// (set) Token: 0x0602CFB7 RID: 184247 RVA: 0x00A2DB4B File Offset: 0x00A2BD4B
		public unsafe TEnumAsByte<ESequenceCameraAnsEffectiveClientType> OverrideCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170071EA RID: 29162
		// (get) Token: 0x0602CFB8 RID: 184248 RVA: 0x00A2DB60 File Offset: 0x00A2BD60
		// (set) Token: 0x0602CFB9 RID: 184249 RVA: 0x00A2DB70 File Offset: 0x00A2BD70
		public unsafe bool IsRecoverRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CFBA RID: 184250 RVA: 0x00A2DB81 File Offset: 0x00A2BD81
		public SSequenceCamera_SpecificConfig()
		{
		}

		// Token: 0x0602CFBB RID: 184251 RVA: 0x00A2DB89 File Offset: 0x00A2BD89
		public SSequenceCamera_SpecificConfig(TEnumAsByte<ESequenceCameraSpecificType> SpecificType, float OverrideSequenceTime, float OverrideBlendOutTime, TEnumAsByte<ESequenceCameraAnsEffectiveClientType> OverrideCondition, bool IsRecoverRotation)
		{
			this.SpecificType = SpecificType;
			this.OverrideSequenceTime = OverrideSequenceTime;
			this.OverrideBlendOutTime = OverrideBlendOutTime;
			this.OverrideCondition = OverrideCondition;
			this.IsRecoverRotation = IsRecoverRotation;
		}

		// Token: 0x0602CFBC RID: 184252 RVA: 0x00A2DBB6 File Offset: 0x00A2BDB6
		protected override IntPtr GetUStructPtr()
		{
			return SSequenceCamera_SpecificConfig.StaticStruct();
		}

		// Token: 0x0602CFBD RID: 184253 RVA: 0x00A2DBC2 File Offset: 0x00A2BDC2
		[NullableContext(2)]
		public SSequenceCamera_SpecificConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CFBE RID: 184254 RVA: 0x00A2DBCC File Offset: 0x00A2BDCC
		public SSequenceCamera_SpecificConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CFBF RID: 184255 RVA: 0x00A2DBD7 File Offset: 0x00A2BDD7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequenceCamera_SpecificConfig(Pointer, false, true);
		}

		// Token: 0x0602CFC0 RID: 184256 RVA: 0x00A2DBE1 File Offset: 0x00A2BDE1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequenceCamera_SpecificConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04017DDE RID: 97758
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_SpecificConfig.SSequenceCamera_SpecificConfig";

		// Token: 0x04017DDF RID: 97759
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017DE0 RID: 97760
		internal static int __PropertyOffset_0;

		// Token: 0x04017DE1 RID: 97761
		internal static int __PropertyOffset_1;

		// Token: 0x04017DE2 RID: 97762
		internal static int __PropertyOffset_2;

		// Token: 0x04017DE3 RID: 97763
		internal static int __PropertyOffset_3;

		// Token: 0x04017DE4 RID: 97764
		internal static int __PropertyOffset_4;
	}
}
