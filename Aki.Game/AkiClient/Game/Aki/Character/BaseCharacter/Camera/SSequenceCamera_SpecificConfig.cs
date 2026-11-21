using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033EA RID: 13290
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_SpecificConfig.SSequenceCamera_SpecificConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 14)]
	public class SSequenceCamera_SpecificConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021B69 RID: 138089 RVA: 0x0096779C File Offset: 0x0096599C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSequenceCamera_SpecificConfig._ScriptStructPtr != 0) ? SSequenceCamera_SpecificConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_SpecificConfig.SSequenceCamera_SpecificConfig", ref SSequenceCamera_SpecificConfig._ScriptStructPtr);
		}

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x06021B6A RID: 138090 RVA: 0x009677C0 File Offset: 0x009659C0
		// (set) Token: 0x06021B6B RID: 138091 RVA: 0x009677D4 File Offset: 0x009659D4
		public unsafe TEnumAsByte<ESequenceCameraSpecificType> SpecificType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_SpecificType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_SpecificType) = value;
			}
		}

		// Token: 0x170045D5 RID: 17877
		// (get) Token: 0x06021B6C RID: 138092 RVA: 0x009677E9 File Offset: 0x009659E9
		// (set) Token: 0x06021B6D RID: 138093 RVA: 0x009677F9 File Offset: 0x009659F9
		public unsafe float OverrideSequenceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_OverrideSequenceTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_OverrideSequenceTime) = value;
			}
		}

		// Token: 0x170045D6 RID: 17878
		// (get) Token: 0x06021B6E RID: 138094 RVA: 0x0096780A File Offset: 0x00965A0A
		// (set) Token: 0x06021B6F RID: 138095 RVA: 0x0096781A File Offset: 0x00965A1A
		public unsafe float OverrideBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_OverrideBlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_OverrideBlendOutTime) = value;
			}
		}

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x06021B70 RID: 138096 RVA: 0x0096782B File Offset: 0x00965A2B
		// (set) Token: 0x06021B71 RID: 138097 RVA: 0x0096783F File Offset: 0x00965A3F
		public unsafe TEnumAsByte<ESequenceCameraAnsEffectiveClientType> OverrideCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_OverrideCondition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_OverrideCondition) = value;
			}
		}

		// Token: 0x170045D8 RID: 17880
		// (get) Token: 0x06021B72 RID: 138098 RVA: 0x00967854 File Offset: 0x00965A54
		// (set) Token: 0x06021B73 RID: 138099 RVA: 0x00967864 File Offset: 0x00965A64
		public unsafe bool IsRecoverRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_IsRecoverRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSequenceCamera_SpecificConfig.__PropertyOffset_IsRecoverRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021B74 RID: 138100 RVA: 0x00967875 File Offset: 0x00965A75
		public SSequenceCamera_SpecificConfig()
		{
		}

		// Token: 0x06021B75 RID: 138101 RVA: 0x0096787D File Offset: 0x00965A7D
		protected override IntPtr GetUStructPtr()
		{
			return SSequenceCamera_SpecificConfig.StaticStruct();
		}

		// Token: 0x06021B76 RID: 138102 RVA: 0x00967889 File Offset: 0x00965A89
		[NullableContext(2)]
		public SSequenceCamera_SpecificConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B77 RID: 138103 RVA: 0x00967893 File Offset: 0x00965A93
		public SSequenceCamera_SpecificConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B78 RID: 138104 RVA: 0x0096789E File Offset: 0x00965A9E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSequenceCamera_SpecificConfig(Pointer, false, true);
		}

		// Token: 0x06021B79 RID: 138105 RVA: 0x009678A8 File Offset: 0x00965AA8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSequenceCamera_SpecificConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401291F RID: 76063
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SSequenceCamera_SpecificConfig.SSequenceCamera_SpecificConfig";

		// Token: 0x04012920 RID: 76064
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012921 RID: 76065
		internal static int __PropertyOffset_SpecificType;

		// Token: 0x04012922 RID: 76066
		internal static int __PropertyOffset_OverrideSequenceTime;

		// Token: 0x04012923 RID: 76067
		internal static int __PropertyOffset_OverrideBlendOutTime;

		// Token: 0x04012924 RID: 76068
		internal static int __PropertyOffset_OverrideCondition;

		// Token: 0x04012925 RID: 76069
		internal static int __PropertyOffset_IsRecoverRotation;
	}
}
