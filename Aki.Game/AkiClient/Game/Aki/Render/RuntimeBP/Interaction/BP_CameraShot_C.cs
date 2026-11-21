using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030EE RID: 12526
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraShot.BP_CameraShot_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class BP_CameraShot_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E65A RID: 124506 RVA: 0x00912DD8 File Offset: 0x00910FD8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraShot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraShot.BP_CameraShot_C");
			}
			return BP_CameraShot_C._ClassPtr;
		}

		// Token: 0x0601E65B RID: 124507 RVA: 0x00912DFC File Offset: 0x00910FFC
		public BP_CameraShot_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraShot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E65C RID: 124508 RVA: 0x00912E24 File Offset: 0x00911024
		[NullableContext(1)]
		public BP_CameraShot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraShot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0601E65D RID: 124509 RVA: 0x00912E57 File Offset: 0x00911057
		// (set) Token: 0x0601E65E RID: 124510 RVA: 0x00912E6B File Offset: 0x0091106B
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_KuroPostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_KuroPostProcess, value);
			}
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0601E65F RID: 124511 RVA: 0x00912E80 File Offset: 0x00911080
		// (set) Token: 0x0601E660 RID: 124512 RVA: 0x00912E94 File Offset: 0x00911094
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0601E661 RID: 124513 RVA: 0x00912EA9 File Offset: 0x009110A9
		// (set) Token: 0x0601E662 RID: 124514 RVA: 0x00912EB9 File Offset: 0x009110B9
		public unsafe float BackgroundStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_BackgroundStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_BackgroundStrength) = value;
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0601E663 RID: 124515 RVA: 0x00912ECA File Offset: 0x009110CA
		// (set) Token: 0x0601E664 RID: 124516 RVA: 0x00912EDE File Offset: 0x009110DE
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0601E665 RID: 124517 RVA: 0x00912EF3 File Offset: 0x009110F3
		// (set) Token: 0x0601E666 RID: 124518 RVA: 0x00912F07 File Offset: 0x00911107
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_DynamicMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraShot_C.__PropertyOffset_DynamicMaterial, value);
			}
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0601E667 RID: 124519 RVA: 0x00912F1C File Offset: 0x0091111C
		// (set) Token: 0x0601E668 RID: 124520 RVA: 0x00912F2C File Offset: 0x0091112C
		public unsafe float RotationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_RotationAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_RotationAngle) = value;
			}
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0601E669 RID: 124521 RVA: 0x00912F3D File Offset: 0x0091113D
		// (set) Token: 0x0601E66A RID: 124522 RVA: 0x00912F4D File Offset: 0x0091114D
		public unsafe float BlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_BlurIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_BlurIntensity) = value;
			}
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0601E66B RID: 124523 RVA: 0x00912F5E File Offset: 0x0091115E
		// (set) Token: 0x0601E66C RID: 124524 RVA: 0x00912F6E File Offset: 0x0091116E
		public unsafe float CircleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_CircleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_CircleRadius) = value;
			}
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0601E66D RID: 124525 RVA: 0x00912F7F File Offset: 0x0091117F
		// (set) Token: 0x0601E66E RID: 124526 RVA: 0x00912F8F File Offset: 0x0091118F
		public unsafe float FrameThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_FrameThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_FrameThickness) = value;
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0601E66F RID: 124527 RVA: 0x00912FA0 File Offset: 0x009111A0
		// (set) Token: 0x0601E670 RID: 124528 RVA: 0x00912FB0 File Offset: 0x009111B0
		public unsafe float mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_mode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_mode) = value;
			}
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0601E671 RID: 124529 RVA: 0x00912FC1 File Offset: 0x009111C1
		// (set) Token: 0x0601E672 RID: 124530 RVA: 0x00912FD1 File Offset: 0x009111D1
		public unsafe float FrameX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_FrameX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_FrameX) = value;
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0601E673 RID: 124531 RVA: 0x00912FE2 File Offset: 0x009111E2
		// (set) Token: 0x0601E674 RID: 124532 RVA: 0x00912FF2 File Offset: 0x009111F2
		public unsafe float FrameY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_FrameY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_FrameY) = value;
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0601E675 RID: 124533 RVA: 0x00913003 File Offset: 0x00911203
		// (set) Token: 0x0601E676 RID: 124534 RVA: 0x00913013 File Offset: 0x00911213
		public unsafe float Line1X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_Line1X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_Line1X) = value;
			}
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0601E677 RID: 124535 RVA: 0x00913024 File Offset: 0x00911224
		// (set) Token: 0x0601E678 RID: 124536 RVA: 0x00913034 File Offset: 0x00911234
		public unsafe float Line1Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_Line1Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_Line1Y) = value;
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0601E679 RID: 124537 RVA: 0x00913045 File Offset: 0x00911245
		// (set) Token: 0x0601E67A RID: 124538 RVA: 0x00913055 File Offset: 0x00911255
		public unsafe float Line2X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_Line2X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_Line2X) = value;
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0601E67B RID: 124539 RVA: 0x00913066 File Offset: 0x00911266
		// (set) Token: 0x0601E67C RID: 124540 RVA: 0x00913076 File Offset: 0x00911276
		public unsafe float Line2Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_Line2Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_Line2Y) = value;
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0601E67D RID: 124541 RVA: 0x00913087 File Offset: 0x00911287
		// (set) Token: 0x0601E67E RID: 124542 RVA: 0x00913097 File Offset: 0x00911297
		public unsafe float LineAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_LineAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_LineAlpha) = value;
			}
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0601E67F RID: 124543 RVA: 0x009130A8 File Offset: 0x009112A8
		// (set) Token: 0x0601E680 RID: 124544 RVA: 0x009130B8 File Offset: 0x009112B8
		public unsafe float LineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_LineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_LineThickness) = value;
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0601E681 RID: 124545 RVA: 0x009130C9 File Offset: 0x009112C9
		// (set) Token: 0x0601E682 RID: 124546 RVA: 0x009130D9 File Offset: 0x009112D9
		public unsafe float EmissionPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_EmissionPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_EmissionPower) = value;
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0601E683 RID: 124547 RVA: 0x009130EA File Offset: 0x009112EA
		// (set) Token: 0x0601E684 RID: 124548 RVA: 0x009130FA File Offset: 0x009112FA
		public unsafe float EmissionRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_EmissionRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_EmissionRange) = value;
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0601E685 RID: 124549 RVA: 0x0091310B File Offset: 0x0091130B
		// (set) Token: 0x0601E686 RID: 124550 RVA: 0x0091311B File Offset: 0x0091131B
		public unsafe float EmissionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_EmissionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_EmissionStrength) = value;
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0601E687 RID: 124551 RVA: 0x0091312C File Offset: 0x0091132C
		// (set) Token: 0x0601E688 RID: 124552 RVA: 0x0091313C File Offset: 0x0091133C
		public unsafe float ShadowPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_ShadowPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_ShadowPower) = value;
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0601E689 RID: 124553 RVA: 0x0091314D File Offset: 0x0091134D
		// (set) Token: 0x0601E68A RID: 124554 RVA: 0x0091315D File Offset: 0x0091135D
		public unsafe float ShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_ShadowRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_ShadowRange) = value;
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0601E68B RID: 124555 RVA: 0x0091316E File Offset: 0x0091136E
		// (set) Token: 0x0601E68C RID: 124556 RVA: 0x0091317E File Offset: 0x0091137E
		public unsafe float ShadowStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_ShadowStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_ShadowStrength) = value;
			}
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0601E68D RID: 124557 RVA: 0x0091318F File Offset: 0x0091138F
		// (set) Token: 0x0601E68E RID: 124558 RVA: 0x0091319F File Offset: 0x0091139F
		public unsafe float MaskWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_MaskWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_MaskWidth) = value;
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0601E68F RID: 124559 RVA: 0x009131B0 File Offset: 0x009113B0
		// (set) Token: 0x0601E690 RID: 124560 RVA: 0x009131C0 File Offset: 0x009113C0
		public unsafe float MaskHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_MaskHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_MaskHeight) = value;
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0601E691 RID: 124561 RVA: 0x009131D1 File Offset: 0x009113D1
		// (set) Token: 0x0601E692 RID: 124562 RVA: 0x009131E5 File Offset: 0x009113E5
		public unsafe FColor MaskColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_MaskColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_MaskColor) = value;
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0601E693 RID: 124563 RVA: 0x009131FA File Offset: 0x009113FA
		// (set) Token: 0x0601E694 RID: 124564 RVA: 0x0091320E File Offset: 0x0091140E
		public unsafe FColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_EmissionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_EmissionColor) = value;
			}
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0601E695 RID: 124565 RVA: 0x00913223 File Offset: 0x00911423
		// (set) Token: 0x0601E696 RID: 124566 RVA: 0x00913237 File Offset: 0x00911437
		public unsafe FColor ShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_ShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraShot_C.__PropertyOffset_ShadowColor) = value;
			}
		}

		// Token: 0x0601E697 RID: 124567 RVA: 0x0091324C File Offset: 0x0091144C
		[SkipLocalsInit]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0601E698 RID: 124568 RVA: 0x00913260 File Offset: 0x00911460
		[SkipLocalsInit]
		public virtual void 纯色遮罩()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__纯色遮罩_NativeFunctionPtr, null);
		}

		// Token: 0x0601E699 RID: 124569 RVA: 0x00913274 File Offset: 0x00911474
		[SkipLocalsInit]
		public virtual void 默认()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__默认_NativeFunctionPtr, null);
		}

		// Token: 0x0601E69A RID: 124570 RVA: 0x00913288 File Offset: 0x00911488
		[SkipLocalsInit]
		public virtual void 艺术画框()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__艺术画框_NativeFunctionPtr, null);
		}

		// Token: 0x0601E69B RID: 124571 RVA: 0x0091329C File Offset: 0x0091149C
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E69C RID: 124572 RVA: 0x009132B0 File Offset: 0x009114B0
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraShot_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E69D RID: 124573 RVA: 0x009132C4 File Offset: 0x009114C4
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E69E RID: 124574 RVA: 0x009132D8 File Offset: 0x009114D8
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraShot_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E69F RID: 124575 RVA: 0x009132EC File Offset: 0x009114EC
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CameraShot_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraShot_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraShot_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraShot_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6A0 RID: 124576 RVA: 0x00913334 File Offset: 0x00911534
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CameraShot_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraShot_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraShot_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraShot_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraShot_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6A1 RID: 124577 RVA: 0x0091337C File Offset: 0x0091157C
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CameraShot_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraShot_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraShot_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraShot_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraShot_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6A2 RID: 124578 RVA: 0x009133C4 File Offset: 0x009115C4
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CameraShot_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraShot_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraShot_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraShot_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraShot_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E6A3 RID: 124579 RVA: 0x0091340A File Offset: 0x0091160A
		protected BP_CameraShot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401018F RID: 65935
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraShot.BP_CameraShot_C";

		// Token: 0x04010190 RID: 65936
		private static IntPtr _ClassPtr;

		// Token: 0x04010191 RID: 65937
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010192 RID: 65938
		internal static int __PropertyOffset_KuroPostProcess;

		// Token: 0x04010193 RID: 65939
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010194 RID: 65940
		internal static int __PropertyOffset_BackgroundStrength;

		// Token: 0x04010195 RID: 65941
		internal static int __PropertyOffset_Material;

		// Token: 0x04010196 RID: 65942
		internal static int __PropertyOffset_DynamicMaterial;

		// Token: 0x04010197 RID: 65943
		internal static int __PropertyOffset_RotationAngle;

		// Token: 0x04010198 RID: 65944
		internal static int __PropertyOffset_BlurIntensity;

		// Token: 0x04010199 RID: 65945
		internal static int __PropertyOffset_CircleRadius;

		// Token: 0x0401019A RID: 65946
		internal static int __PropertyOffset_FrameThickness;

		// Token: 0x0401019B RID: 65947
		internal static int __PropertyOffset_mode;

		// Token: 0x0401019C RID: 65948
		internal static int __PropertyOffset_FrameX;

		// Token: 0x0401019D RID: 65949
		internal static int __PropertyOffset_FrameY;

		// Token: 0x0401019E RID: 65950
		internal static int __PropertyOffset_Line1X;

		// Token: 0x0401019F RID: 65951
		internal static int __PropertyOffset_Line1Y;

		// Token: 0x040101A0 RID: 65952
		internal static int __PropertyOffset_Line2X;

		// Token: 0x040101A1 RID: 65953
		internal static int __PropertyOffset_Line2Y;

		// Token: 0x040101A2 RID: 65954
		internal static int __PropertyOffset_LineAlpha;

		// Token: 0x040101A3 RID: 65955
		internal static int __PropertyOffset_LineThickness;

		// Token: 0x040101A4 RID: 65956
		internal static int __PropertyOffset_EmissionPower;

		// Token: 0x040101A5 RID: 65957
		internal static int __PropertyOffset_EmissionRange;

		// Token: 0x040101A6 RID: 65958
		internal static int __PropertyOffset_EmissionStrength;

		// Token: 0x040101A7 RID: 65959
		internal static int __PropertyOffset_ShadowPower;

		// Token: 0x040101A8 RID: 65960
		internal static int __PropertyOffset_ShadowRange;

		// Token: 0x040101A9 RID: 65961
		internal static int __PropertyOffset_ShadowStrength;

		// Token: 0x040101AA RID: 65962
		internal static int __PropertyOffset_MaskWidth;

		// Token: 0x040101AB RID: 65963
		internal static int __PropertyOffset_MaskHeight;

		// Token: 0x040101AC RID: 65964
		internal static int __PropertyOffset_MaskColor;

		// Token: 0x040101AD RID: 65965
		internal static int __PropertyOffset_EmissionColor;

		// Token: 0x040101AE RID: 65966
		internal static int __PropertyOffset_ShadowColor;

		// Token: 0x040101AF RID: 65967
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x040101B0 RID: 65968
		private static IntPtr __纯色遮罩_NativeFunctionPtr;

		// Token: 0x040101B1 RID: 65969
		private static IntPtr __默认_NativeFunctionPtr;

		// Token: 0x040101B2 RID: 65970
		private static IntPtr __艺术画框_NativeFunctionPtr;

		// Token: 0x040101B3 RID: 65971
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040101B4 RID: 65972
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040101B5 RID: 65973
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040101B6 RID: 65974
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008E74 RID: 36468
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CAC1 RID: 182977
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E75 RID: 36469
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CAC2 RID: 182978
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
