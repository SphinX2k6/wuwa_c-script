using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033EB RID: 13291
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SSettlementCamera.SSettlementCamera")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 460)]
	public class SSettlementCamera : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021B7A RID: 138106 RVA: 0x009678B1 File Offset: 0x00965AB1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSettlementCamera._ScriptStructPtr != 0) ? SSettlementCamera._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SSettlementCamera.SSettlementCamera", ref SSettlementCamera._ScriptStructPtr);
		}

		// Token: 0x170045D9 RID: 17881
		// (get) Token: 0x06021B7B RID: 138107 RVA: 0x009678D5 File Offset: 0x00965AD5
		// (set) Token: 0x06021B7C RID: 138108 RVA: 0x009678E5 File Offset: 0x00965AE5
		public unsafe float MinRandomPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_MinRandomPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_MinRandomPitch) = value;
			}
		}

		// Token: 0x170045DA RID: 17882
		// (get) Token: 0x06021B7D RID: 138109 RVA: 0x009678F6 File Offset: 0x00965AF6
		// (set) Token: 0x06021B7E RID: 138110 RVA: 0x00967906 File Offset: 0x00965B06
		public unsafe float MaxRandomPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_MaxRandomPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_MaxRandomPitch) = value;
			}
		}

		// Token: 0x170045DB RID: 17883
		// (get) Token: 0x06021B7F RID: 138111 RVA: 0x00967917 File Offset: 0x00965B17
		// (set) Token: 0x06021B80 RID: 138112 RVA: 0x00967927 File Offset: 0x00965B27
		public unsafe float TopAdditionZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_TopAdditionZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_TopAdditionZ) = value;
			}
		}

		// Token: 0x170045DC RID: 17884
		// (get) Token: 0x06021B81 RID: 138113 RVA: 0x00967938 File Offset: 0x00965B38
		// (set) Token: 0x06021B82 RID: 138114 RVA: 0x00967948 File Offset: 0x00965B48
		public unsafe float BottomAdditionZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_BottomAdditionZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_BottomAdditionZ) = value;
			}
		}

		// Token: 0x170045DD RID: 17885
		// (get) Token: 0x06021B83 RID: 138115 RVA: 0x00967959 File Offset: 0x00965B59
		// (set) Token: 0x06021B84 RID: 138116 RVA: 0x00967969 File Offset: 0x00965B69
		public unsafe float LeftMinYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_LeftMinYawRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_LeftMinYawRange) = value;
			}
		}

		// Token: 0x170045DE RID: 17886
		// (get) Token: 0x06021B85 RID: 138117 RVA: 0x0096797A File Offset: 0x00965B7A
		// (set) Token: 0x06021B86 RID: 138118 RVA: 0x0096798A File Offset: 0x00965B8A
		public unsafe float LeftMaxYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_LeftMaxYawRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_LeftMaxYawRange) = value;
			}
		}

		// Token: 0x170045DF RID: 17887
		// (get) Token: 0x06021B87 RID: 138119 RVA: 0x0096799B File Offset: 0x00965B9B
		// (set) Token: 0x06021B88 RID: 138120 RVA: 0x009679AB File Offset: 0x00965BAB
		public unsafe float RightMinYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_RightMinYawRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_RightMinYawRange) = value;
			}
		}

		// Token: 0x170045E0 RID: 17888
		// (get) Token: 0x06021B89 RID: 138121 RVA: 0x009679BC File Offset: 0x00965BBC
		// (set) Token: 0x06021B8A RID: 138122 RVA: 0x009679CC File Offset: 0x00965BCC
		public unsafe float RightMaxYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_RightMaxYawRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_RightMaxYawRange) = value;
			}
		}

		// Token: 0x170045E1 RID: 17889
		// (get) Token: 0x06021B8B RID: 138123 RVA: 0x009679DD File Offset: 0x00965BDD
		// (set) Token: 0x06021B8C RID: 138124 RVA: 0x009679ED File Offset: 0x00965BED
		public unsafe float MinValidYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_MinValidYawRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_MinValidYawRange) = value;
			}
		}

		// Token: 0x170045E2 RID: 17890
		// (get) Token: 0x06021B8D RID: 138125 RVA: 0x00967A00 File Offset: 0x00965C00
		// (set) Token: 0x06021B8E RID: 138126 RVA: 0x00967A43 File Offset: 0x00965C43
		public SCameraModifier CameraModifier
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier result;
				if ((result = this._CameraModifier) == null)
				{
					result = (this._CameraModifier = new SCameraModifier(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_CameraModifier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier.StaticStruct(), base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_CameraModifier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045E3 RID: 17891
		// (get) Token: 0x06021B8F RID: 138127 RVA: 0x00967A64 File Offset: 0x00965C64
		// (set) Token: 0x06021B90 RID: 138128 RVA: 0x00967A78 File Offset: 0x00965C78
		public unsafe FVector CharacterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_CharacterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_CharacterOffset) = value;
			}
		}

		// Token: 0x06021B91 RID: 138129 RVA: 0x00967A8D File Offset: 0x00965C8D
		public SSettlementCamera()
		{
		}

		// Token: 0x06021B92 RID: 138130 RVA: 0x00967A95 File Offset: 0x00965C95
		protected override IntPtr GetUStructPtr()
		{
			return SSettlementCamera.StaticStruct();
		}

		// Token: 0x06021B93 RID: 138131 RVA: 0x00967AA1 File Offset: 0x00965CA1
		[NullableContext(2)]
		public SSettlementCamera(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B94 RID: 138132 RVA: 0x00967AAB File Offset: 0x00965CAB
		public SSettlementCamera(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B95 RID: 138133 RVA: 0x00967AB6 File Offset: 0x00965CB6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSettlementCamera(Pointer, false, true);
		}

		// Token: 0x06021B96 RID: 138134 RVA: 0x00967AC0 File Offset: 0x00965CC0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSettlementCamera(Pointer, MemoryOwner);
		}

		// Token: 0x04012926 RID: 76070
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SSettlementCamera.SSettlementCamera";

		// Token: 0x04012927 RID: 76071
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012928 RID: 76072
		internal static int __PropertyOffset_MinRandomPitch;

		// Token: 0x04012929 RID: 76073
		internal static int __PropertyOffset_MaxRandomPitch;

		// Token: 0x0401292A RID: 76074
		internal static int __PropertyOffset_TopAdditionZ;

		// Token: 0x0401292B RID: 76075
		internal static int __PropertyOffset_BottomAdditionZ;

		// Token: 0x0401292C RID: 76076
		internal static int __PropertyOffset_LeftMinYawRange;

		// Token: 0x0401292D RID: 76077
		internal static int __PropertyOffset_LeftMaxYawRange;

		// Token: 0x0401292E RID: 76078
		internal static int __PropertyOffset_RightMinYawRange;

		// Token: 0x0401292F RID: 76079
		internal static int __PropertyOffset_RightMaxYawRange;

		// Token: 0x04012930 RID: 76080
		internal static int __PropertyOffset_MinValidYawRange;

		// Token: 0x04012931 RID: 76081
		internal static int __PropertyOffset_CameraModifier;

		// Token: 0x04012932 RID: 76082
		[Nullable(2)]
		private SCameraModifier _CameraModifier;

		// Token: 0x04012933 RID: 76083
		internal static int __PropertyOffset_CharacterOffset;
	}
}
