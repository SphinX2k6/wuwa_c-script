using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043D4 RID: 17364
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SSettlementCamera.SSettlementCamera")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 460)]
	public class SSettlementCamera : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CFC1 RID: 184257 RVA: 0x00A2DBEA File Offset: 0x00A2BDEA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSettlementCamera._ScriptStructPtr != 0) ? SSettlementCamera._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SSettlementCamera.SSettlementCamera", ref SSettlementCamera._ScriptStructPtr);
		}

		// Token: 0x170071EB RID: 29163
		// (get) Token: 0x0602CFC2 RID: 184258 RVA: 0x00A2DC0E File Offset: 0x00A2BE0E
		// (set) Token: 0x0602CFC3 RID: 184259 RVA: 0x00A2DC1E File Offset: 0x00A2BE1E
		public unsafe float MinRandomPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170071EC RID: 29164
		// (get) Token: 0x0602CFC4 RID: 184260 RVA: 0x00A2DC2F File Offset: 0x00A2BE2F
		// (set) Token: 0x0602CFC5 RID: 184261 RVA: 0x00A2DC3F File Offset: 0x00A2BE3F
		public unsafe float MaxRandomPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170071ED RID: 29165
		// (get) Token: 0x0602CFC6 RID: 184262 RVA: 0x00A2DC50 File Offset: 0x00A2BE50
		// (set) Token: 0x0602CFC7 RID: 184263 RVA: 0x00A2DC60 File Offset: 0x00A2BE60
		public unsafe float TopAdditionZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170071EE RID: 29166
		// (get) Token: 0x0602CFC8 RID: 184264 RVA: 0x00A2DC71 File Offset: 0x00A2BE71
		// (set) Token: 0x0602CFC9 RID: 184265 RVA: 0x00A2DC81 File Offset: 0x00A2BE81
		public unsafe float BottomAdditionZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170071EF RID: 29167
		// (get) Token: 0x0602CFCA RID: 184266 RVA: 0x00A2DC92 File Offset: 0x00A2BE92
		// (set) Token: 0x0602CFCB RID: 184267 RVA: 0x00A2DCA2 File Offset: 0x00A2BEA2
		public unsafe float LeftMinYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170071F0 RID: 29168
		// (get) Token: 0x0602CFCC RID: 184268 RVA: 0x00A2DCB3 File Offset: 0x00A2BEB3
		// (set) Token: 0x0602CFCD RID: 184269 RVA: 0x00A2DCC3 File Offset: 0x00A2BEC3
		public unsafe float LeftMaxYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170071F1 RID: 29169
		// (get) Token: 0x0602CFCE RID: 184270 RVA: 0x00A2DCD4 File Offset: 0x00A2BED4
		// (set) Token: 0x0602CFCF RID: 184271 RVA: 0x00A2DCE4 File Offset: 0x00A2BEE4
		public unsafe float RightMinYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170071F2 RID: 29170
		// (get) Token: 0x0602CFD0 RID: 184272 RVA: 0x00A2DCF5 File Offset: 0x00A2BEF5
		// (set) Token: 0x0602CFD1 RID: 184273 RVA: 0x00A2DD05 File Offset: 0x00A2BF05
		public unsafe float RightMaxYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170071F3 RID: 29171
		// (get) Token: 0x0602CFD2 RID: 184274 RVA: 0x00A2DD16 File Offset: 0x00A2BF16
		// (set) Token: 0x0602CFD3 RID: 184275 RVA: 0x00A2DD26 File Offset: 0x00A2BF26
		public unsafe float MinValidYawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170071F4 RID: 29172
		// (get) Token: 0x0602CFD4 RID: 184276 RVA: 0x00A2DD38 File Offset: 0x00A2BF38
		// (set) Token: 0x0602CFD5 RID: 184277 RVA: 0x00A2DD7B File Offset: 0x00A2BF7B
		public SCameraModifier CameraModifier
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier result;
				if ((result = this._CameraModifier) == null)
				{
					result = (this._CameraModifier = new SCameraModifier(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier.StaticStruct(), base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071F5 RID: 29173
		// (get) Token: 0x0602CFD6 RID: 184278 RVA: 0x00A2DD9C File Offset: 0x00A2BF9C
		// (set) Token: 0x0602CFD7 RID: 184279 RVA: 0x00A2DDB0 File Offset: 0x00A2BFB0
		public unsafe FVector CharacterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSettlementCamera.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x0602CFD8 RID: 184280 RVA: 0x00A2DDC5 File Offset: 0x00A2BFC5
		public SSettlementCamera()
		{
		}

		// Token: 0x0602CFD9 RID: 184281 RVA: 0x00A2DDD0 File Offset: 0x00A2BFD0
		public SSettlementCamera(float MinRandomPitch, float MaxRandomPitch, float TopAdditionZ, float BottomAdditionZ, float LeftMinYawRange, float LeftMaxYawRange, float RightMinYawRange, float RightMaxYawRange, float MinValidYawRange, SCameraModifier CameraModifier, FVector CharacterOffset)
		{
			this.MinRandomPitch = MinRandomPitch;
			this.MaxRandomPitch = MaxRandomPitch;
			this.TopAdditionZ = TopAdditionZ;
			this.BottomAdditionZ = BottomAdditionZ;
			this.LeftMinYawRange = LeftMinYawRange;
			this.LeftMaxYawRange = LeftMaxYawRange;
			this.RightMinYawRange = RightMinYawRange;
			this.RightMaxYawRange = RightMaxYawRange;
			this.MinValidYawRange = MinValidYawRange;
			this.CameraModifier = CameraModifier;
			this.CharacterOffset = CharacterOffset;
		}

		// Token: 0x0602CFDA RID: 184282 RVA: 0x00A2DE38 File Offset: 0x00A2C038
		protected override IntPtr GetUStructPtr()
		{
			return SSettlementCamera.StaticStruct();
		}

		// Token: 0x0602CFDB RID: 184283 RVA: 0x00A2DE44 File Offset: 0x00A2C044
		[NullableContext(2)]
		public SSettlementCamera(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CFDC RID: 184284 RVA: 0x00A2DE4E File Offset: 0x00A2C04E
		public SSettlementCamera(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CFDD RID: 184285 RVA: 0x00A2DE59 File Offset: 0x00A2C059
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSettlementCamera(Pointer, false, true);
		}

		// Token: 0x0602CFDE RID: 184286 RVA: 0x00A2DE63 File Offset: 0x00A2C063
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSettlementCamera(Pointer, MemoryOwner);
		}

		// Token: 0x04017DE5 RID: 97765
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SSettlementCamera.SSettlementCamera";

		// Token: 0x04017DE6 RID: 97766
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017DE7 RID: 97767
		internal static int __PropertyOffset_0;

		// Token: 0x04017DE8 RID: 97768
		internal static int __PropertyOffset_1;

		// Token: 0x04017DE9 RID: 97769
		internal static int __PropertyOffset_2;

		// Token: 0x04017DEA RID: 97770
		internal static int __PropertyOffset_3;

		// Token: 0x04017DEB RID: 97771
		internal static int __PropertyOffset_4;

		// Token: 0x04017DEC RID: 97772
		internal static int __PropertyOffset_5;

		// Token: 0x04017DED RID: 97773
		internal static int __PropertyOffset_6;

		// Token: 0x04017DEE RID: 97774
		internal static int __PropertyOffset_7;

		// Token: 0x04017DEF RID: 97775
		internal static int __PropertyOffset_8;

		// Token: 0x04017DF0 RID: 97776
		internal static int __PropertyOffset_9;

		// Token: 0x04017DF1 RID: 97777
		[Nullable(2)]
		private SCameraModifier _CameraModifier;

		// Token: 0x04017DF2 RID: 97778
		internal static int __PropertyOffset_10;
	}
}
