using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D0A RID: 15626
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraShot.BP_CameraShot_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class BP_CameraShot_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602566E RID: 153198 RVA: 0x00958DB8 File Offset: 0x00956FB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraShot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraShot.BP_CameraShot_C");
			}
			return BP_CameraShot_C._ClassPtr;
		}

		// Token: 0x0602566F RID: 153199 RVA: 0x00958DDC File Offset: 0x00956FDC
		public BP_CameraShot_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraShot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025670 RID: 153200 RVA: 0x00958E04 File Offset: 0x00957004
		[NullableContext(1)]
		public BP_CameraShot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraShot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C74 RID: 19572
		// (get) Token: 0x06025671 RID: 153201 RVA: 0x00958E37 File Offset: 0x00957037
		// (set) Token: 0x06025672 RID: 153202 RVA: 0x00958E4B File Offset: 0x0095704B
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004C75 RID: 19573
		// (get) Token: 0x06025673 RID: 153203 RVA: 0x00958E60 File Offset: 0x00957060
		// (set) Token: 0x06025674 RID: 153204 RVA: 0x00958E74 File Offset: 0x00957074
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004C76 RID: 19574
		// (get) Token: 0x06025675 RID: 153205 RVA: 0x00958E89 File Offset: 0x00957089
		// (set) Token: 0x06025676 RID: 153206 RVA: 0x00958E9D File Offset: 0x0095709D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004C77 RID: 19575
		// (get) Token: 0x06025677 RID: 153207 RVA: 0x00958EB2 File Offset: 0x009570B2
		// (set) Token: 0x06025678 RID: 153208 RVA: 0x00958EC2 File Offset: 0x009570C2
		public unsafe float BackgroundStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004C78 RID: 19576
		// (get) Token: 0x06025679 RID: 153209 RVA: 0x00958ED3 File Offset: 0x009570D3
		// (set) Token: 0x0602567A RID: 153210 RVA: 0x00958EE7 File Offset: 0x009570E7
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x0602567B RID: 153211 RVA: 0x00958EFC File Offset: 0x009570FC
		// (set) Token: 0x0602567C RID: 153212 RVA: 0x00958F10 File Offset: 0x00957110
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x0602567D RID: 153213 RVA: 0x00958F25 File Offset: 0x00957125
		// (set) Token: 0x0602567E RID: 153214 RVA: 0x00958F35 File Offset: 0x00957135
		public unsafe float RotationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004C7B RID: 19579
		// (get) Token: 0x0602567F RID: 153215 RVA: 0x00958F46 File Offset: 0x00957146
		// (set) Token: 0x06025680 RID: 153216 RVA: 0x00958F56 File Offset: 0x00957156
		public unsafe float BlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004C7C RID: 19580
		// (get) Token: 0x06025681 RID: 153217 RVA: 0x00958F67 File Offset: 0x00957167
		// (set) Token: 0x06025682 RID: 153218 RVA: 0x00958F77 File Offset: 0x00957177
		public unsafe float CircleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x06025683 RID: 153219 RVA: 0x00958F88 File Offset: 0x00957188
		// (set) Token: 0x06025684 RID: 153220 RVA: 0x00958F98 File Offset: 0x00957198
		public unsafe float FrameThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x06025685 RID: 153221 RVA: 0x00958FA9 File Offset: 0x009571A9
		// (set) Token: 0x06025686 RID: 153222 RVA: 0x00958FB9 File Offset: 0x009571B9
		public unsafe float mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x06025687 RID: 153223 RVA: 0x00958FCA File Offset: 0x009571CA
		// (set) Token: 0x06025688 RID: 153224 RVA: 0x00958FDA File Offset: 0x009571DA
		public unsafe float FrameX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x06025689 RID: 153225 RVA: 0x00958FEB File Offset: 0x009571EB
		// (set) Token: 0x0602568A RID: 153226 RVA: 0x00958FFB File Offset: 0x009571FB
		public unsafe float FrameY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x0602568B RID: 153227 RVA: 0x0095900C File Offset: 0x0095720C
		// (set) Token: 0x0602568C RID: 153228 RVA: 0x0095901C File Offset: 0x0095721C
		public unsafe float Line1X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004C82 RID: 19586
		// (get) Token: 0x0602568D RID: 153229 RVA: 0x0095902D File Offset: 0x0095722D
		// (set) Token: 0x0602568E RID: 153230 RVA: 0x0095903D File Offset: 0x0095723D
		public unsafe float Line1Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004C83 RID: 19587
		// (get) Token: 0x0602568F RID: 153231 RVA: 0x0095904E File Offset: 0x0095724E
		// (set) Token: 0x06025690 RID: 153232 RVA: 0x0095905E File Offset: 0x0095725E
		public unsafe float Line2X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004C84 RID: 19588
		// (get) Token: 0x06025691 RID: 153233 RVA: 0x0095906F File Offset: 0x0095726F
		// (set) Token: 0x06025692 RID: 153234 RVA: 0x0095907F File Offset: 0x0095727F
		public unsafe float Line2Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x06025693 RID: 153235 RVA: 0x00959090 File Offset: 0x00957290
		// (set) Token: 0x06025694 RID: 153236 RVA: 0x009590A0 File Offset: 0x009572A0
		public unsafe float LineAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x06025695 RID: 153237 RVA: 0x009590B1 File Offset: 0x009572B1
		// (set) Token: 0x06025696 RID: 153238 RVA: 0x009590C1 File Offset: 0x009572C1
		public unsafe float LineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x06025697 RID: 153239 RVA: 0x009590D2 File Offset: 0x009572D2
		// (set) Token: 0x06025698 RID: 153240 RVA: 0x009590E2 File Offset: 0x009572E2
		public unsafe float EmissionPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x06025699 RID: 153241 RVA: 0x009590F3 File Offset: 0x009572F3
		// (set) Token: 0x0602569A RID: 153242 RVA: 0x00959103 File Offset: 0x00957303
		public unsafe float EmissionRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004C89 RID: 19593
		// (get) Token: 0x0602569B RID: 153243 RVA: 0x00959114 File Offset: 0x00957314
		// (set) Token: 0x0602569C RID: 153244 RVA: 0x00959124 File Offset: 0x00957324
		public unsafe float EmissionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004C8A RID: 19594
		// (get) Token: 0x0602569D RID: 153245 RVA: 0x00959135 File Offset: 0x00957335
		// (set) Token: 0x0602569E RID: 153246 RVA: 0x00959145 File Offset: 0x00957345
		public unsafe float ShadowPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004C8B RID: 19595
		// (get) Token: 0x0602569F RID: 153247 RVA: 0x00959156 File Offset: 0x00957356
		// (set) Token: 0x060256A0 RID: 153248 RVA: 0x00959166 File Offset: 0x00957366
		public unsafe float ShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004C8C RID: 19596
		// (get) Token: 0x060256A1 RID: 153249 RVA: 0x00959177 File Offset: 0x00957377
		// (set) Token: 0x060256A2 RID: 153250 RVA: 0x00959187 File Offset: 0x00957387
		public unsafe float ShadowStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x060256A3 RID: 153251 RVA: 0x00959198 File Offset: 0x00957398
		// (set) Token: 0x060256A4 RID: 153252 RVA: 0x009591A8 File Offset: 0x009573A8
		public unsafe float MaskWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x060256A5 RID: 153253 RVA: 0x009591B9 File Offset: 0x009573B9
		// (set) Token: 0x060256A6 RID: 153254 RVA: 0x009591C9 File Offset: 0x009573C9
		public unsafe float MaskHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004C8F RID: 19599
		// (get) Token: 0x060256A7 RID: 153255 RVA: 0x009591DA File Offset: 0x009573DA
		// (set) Token: 0x060256A8 RID: 153256 RVA: 0x009591EE File Offset: 0x009573EE
		public unsafe FColor MaskColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004C90 RID: 19600
		// (get) Token: 0x060256A9 RID: 153257 RVA: 0x00959203 File Offset: 0x00957403
		// (set) Token: 0x060256AA RID: 153258 RVA: 0x00959217 File Offset: 0x00957417
		public unsafe FColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004C91 RID: 19601
		// (get) Token: 0x060256AB RID: 153259 RVA: 0x0095922C File Offset: 0x0095742C
		// (set) Token: 0x060256AC RID: 153260 RVA: 0x00959240 File Offset: 0x00957440
		public unsafe FColor ShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x060256AD RID: 153261 RVA: 0x00959255 File Offset: 0x00957455
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x060256AE RID: 153262 RVA: 0x00959269 File Offset: 0x00957469
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 纯色遮罩()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__纯色遮罩_NativeFunctionPtr, null);
		}

		// Token: 0x060256AF RID: 153263 RVA: 0x0095927D File Offset: 0x0095747D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 默认()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__默认_NativeFunctionPtr, null);
		}

		// Token: 0x060256B0 RID: 153264 RVA: 0x00959291 File Offset: 0x00957491
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 艺术画框()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__艺术画框_NativeFunctionPtr, null);
		}

		// Token: 0x060256B1 RID: 153265 RVA: 0x009592A5 File Offset: 0x009574A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060256B2 RID: 153266 RVA: 0x009592B9 File Offset: 0x009574B9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraShot_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060256B3 RID: 153267 RVA: 0x009592CE File Offset: 0x009574CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060256B4 RID: 153268 RVA: 0x009592E2 File Offset: 0x009574E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraShot_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060256B5 RID: 153269 RVA: 0x009592F8 File Offset: 0x009574F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CameraShot_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraShot_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraShot_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraShot_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060256B6 RID: 153270 RVA: 0x00959340 File Offset: 0x00957540
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CameraShot_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraShot_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraShot_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraShot_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraShot_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256B7 RID: 153271 RVA: 0x00959388 File Offset: 0x00957588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CameraShot_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraShot_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraShot_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraShot_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060256B8 RID: 153272 RVA: 0x009593D0 File Offset: 0x009575D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CameraShot_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraShot_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraShot_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraShot_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraShot_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060256B9 RID: 153273 RVA: 0x00959417 File Offset: 0x00957617
		protected BP_CameraShot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A82 RID: 76418
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraShot.BP_CameraShot_C";

		// Token: 0x04012A83 RID: 76419
		private static IntPtr _ClassPtr;

		// Token: 0x04012A84 RID: 76420
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A85 RID: 76421
		internal static int __PropertyOffset_1;

		// Token: 0x04012A86 RID: 76422
		internal static int __PropertyOffset_2;

		// Token: 0x04012A87 RID: 76423
		internal static int __PropertyOffset_3;

		// Token: 0x04012A88 RID: 76424
		internal static int __PropertyOffset_4;

		// Token: 0x04012A89 RID: 76425
		internal static int __PropertyOffset_5;

		// Token: 0x04012A8A RID: 76426
		internal static int __PropertyOffset_6;

		// Token: 0x04012A8B RID: 76427
		internal static int __PropertyOffset_7;

		// Token: 0x04012A8C RID: 76428
		internal static int __PropertyOffset_8;

		// Token: 0x04012A8D RID: 76429
		internal static int __PropertyOffset_9;

		// Token: 0x04012A8E RID: 76430
		internal static int __PropertyOffset_10;

		// Token: 0x04012A8F RID: 76431
		internal static int __PropertyOffset_11;

		// Token: 0x04012A90 RID: 76432
		internal static int __PropertyOffset_12;

		// Token: 0x04012A91 RID: 76433
		internal static int __PropertyOffset_13;

		// Token: 0x04012A92 RID: 76434
		internal static int __PropertyOffset_14;

		// Token: 0x04012A93 RID: 76435
		internal static int __PropertyOffset_15;

		// Token: 0x04012A94 RID: 76436
		internal static int __PropertyOffset_16;

		// Token: 0x04012A95 RID: 76437
		internal static int __PropertyOffset_17;

		// Token: 0x04012A96 RID: 76438
		internal static int __PropertyOffset_18;

		// Token: 0x04012A97 RID: 76439
		internal static int __PropertyOffset_19;

		// Token: 0x04012A98 RID: 76440
		internal static int __PropertyOffset_20;

		// Token: 0x04012A99 RID: 76441
		internal static int __PropertyOffset_21;

		// Token: 0x04012A9A RID: 76442
		internal static int __PropertyOffset_22;

		// Token: 0x04012A9B RID: 76443
		internal static int __PropertyOffset_23;

		// Token: 0x04012A9C RID: 76444
		internal static int __PropertyOffset_24;

		// Token: 0x04012A9D RID: 76445
		internal static int __PropertyOffset_25;

		// Token: 0x04012A9E RID: 76446
		internal static int __PropertyOffset_26;

		// Token: 0x04012A9F RID: 76447
		internal static int __PropertyOffset_27;

		// Token: 0x04012AA0 RID: 76448
		internal static int __PropertyOffset_28;

		// Token: 0x04012AA1 RID: 76449
		internal static int __PropertyOffset_29;

		// Token: 0x04012AA2 RID: 76450
		internal static int __PropertyOffset_30;

		// Token: 0x04012AA3 RID: 76451
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x04012AA4 RID: 76452
		private static IntPtr __纯色遮罩_NativeFunctionPtr;

		// Token: 0x04012AA5 RID: 76453
		private static IntPtr __默认_NativeFunctionPtr;

		// Token: 0x04012AA6 RID: 76454
		private static IntPtr __艺术画框_NativeFunctionPtr;

		// Token: 0x04012AA7 RID: 76455
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012AA8 RID: 76456
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012AA9 RID: 76457
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012AAA RID: 76458
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009FF4 RID: 40948
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A8F RID: 203407
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FF5 RID: 40949
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A90 RID: 203408
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
