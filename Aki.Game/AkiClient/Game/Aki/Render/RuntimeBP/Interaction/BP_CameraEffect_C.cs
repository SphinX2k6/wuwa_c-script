using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030ED RID: 12525
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraEffect.BP_CameraEffect_C")]
	[UnrealStructLayout(1704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1701)]
	public class BP_CameraEffect_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E5D0 RID: 124368 RVA: 0x009121B3 File Offset: 0x009103B3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CameraEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraEffect.BP_CameraEffect_C");
			}
			return BP_CameraEffect_C._ClassPtr;
		}

		// Token: 0x0601E5D1 RID: 124369 RVA: 0x009121D8 File Offset: 0x009103D8
		public BP_CameraEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_CameraEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E5D2 RID: 124370 RVA: 0x00912200 File Offset: 0x00910400
		[NullableContext(1)]
		public BP_CameraEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CameraEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0601E5D3 RID: 124371 RVA: 0x00912233 File Offset: 0x00910433
		// (set) Token: 0x0601E5D4 RID: 124372 RVA: 0x00912247 File Offset: 0x00910447
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_KuroPostProcess);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_KuroPostProcess, value);
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0601E5D5 RID: 124373 RVA: 0x0091225C File Offset: 0x0091045C
		// (set) Token: 0x0601E5D6 RID: 124374 RVA: 0x00912270 File Offset: 0x00910470
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0601E5D7 RID: 124375 RVA: 0x00912285 File Offset: 0x00910485
		// (set) Token: 0x0601E5D8 RID: 124376 RVA: 0x00912295 File Offset: 0x00910495
		public unsafe float 全局风方向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_全局风方向);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_全局风方向) = value;
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0601E5D9 RID: 124377 RVA: 0x009122A6 File Offset: 0x009104A6
		// (set) Token: 0x0601E5DA RID: 124378 RVA: 0x009122B6 File Offset: 0x009104B6
		public unsafe float 角色光照方向_水平_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照方向_水平_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照方向_水平_) = value;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0601E5DB RID: 124379 RVA: 0x009122C7 File Offset: 0x009104C7
		// (set) Token: 0x0601E5DC RID: 124380 RVA: 0x009122DB File Offset: 0x009104DB
		public unsafe UNiagaraComponent CurrentNS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_CurrentNS);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_CurrentNS, value);
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0601E5DD RID: 124381 RVA: 0x009122F0 File Offset: 0x009104F0
		// (set) Token: 0x0601E5DE RID: 124382 RVA: 0x00912300 File Offset: 0x00910500
		public unsafe float 集群特效密度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_集群特效密度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_集群特效密度) = value;
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0601E5DF RID: 124383 RVA: 0x00912311 File Offset: 0x00910511
		// (set) Token: 0x0601E5E0 RID: 124384 RVA: 0x00912321 File Offset: 0x00910521
		public unsafe float 全局风强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_全局风强度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_全局风强度) = value;
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0601E5E1 RID: 124385 RVA: 0x00912334 File Offset: 0x00910534
		// (set) Token: 0x0601E5E2 RID: 124386 RVA: 0x0091236D File Offset: 0x0091056D
		[Nullable(1)]
		public TArray<UNiagaraSystem> Niagara_System_Objects
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraSystem> result;
				if ((result = this._Niagara_System_Objects) == null)
				{
					result = (this._Niagara_System_Objects = new TArray<UNiagaraSystem>(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Niagara_System_Objects, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Niagara_System_Objects.CopyAssign(value);
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0601E5E3 RID: 124387 RVA: 0x0091237B File Offset: 0x0091057B
		// (set) Token: 0x0601E5E4 RID: 124388 RVA: 0x0091238B File Offset: 0x0091058B
		public unsafe float 角色光照亮部Hue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照亮部Hue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照亮部Hue) = value;
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0601E5E5 RID: 124389 RVA: 0x0091239C File Offset: 0x0091059C
		// (set) Token: 0x0601E5E6 RID: 124390 RVA: 0x009123AC File Offset: 0x009105AC
		public unsafe float 角色光照亮部Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照亮部Saturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照亮部Saturation) = value;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0601E5E7 RID: 124391 RVA: 0x009123BD File Offset: 0x009105BD
		// (set) Token: 0x0601E5E8 RID: 124392 RVA: 0x009123CD File Offset: 0x009105CD
		public unsafe float 角色光照亮部Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照亮部Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照亮部Value) = value;
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0601E5E9 RID: 124393 RVA: 0x009123DE File Offset: 0x009105DE
		// (set) Token: 0x0601E5EA RID: 124394 RVA: 0x009123EE File Offset: 0x009105EE
		public unsafe float 角色光照暗部Hue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照暗部Hue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照暗部Hue) = value;
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0601E5EB RID: 124395 RVA: 0x009123FF File Offset: 0x009105FF
		// (set) Token: 0x0601E5EC RID: 124396 RVA: 0x0091240F File Offset: 0x0091060F
		public unsafe float 角色光照暗部Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照暗部Saturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照暗部Saturation) = value;
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0601E5ED RID: 124397 RVA: 0x00912420 File Offset: 0x00910620
		// (set) Token: 0x0601E5EE RID: 124398 RVA: 0x00912430 File Offset: 0x00910630
		public unsafe float 角色光照暗部Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照暗部Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照暗部Value) = value;
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0601E5EF RID: 124399 RVA: 0x00912441 File Offset: 0x00910641
		// (set) Token: 0x0601E5F0 RID: 124400 RVA: 0x00912451 File Offset: 0x00910651
		public unsafe float 角色光照边缘光Hue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照边缘光Hue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照边缘光Hue) = value;
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0601E5F1 RID: 124401 RVA: 0x00912462 File Offset: 0x00910662
		// (set) Token: 0x0601E5F2 RID: 124402 RVA: 0x00912472 File Offset: 0x00910672
		public unsafe float 角色光照边缘光Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照边缘光Saturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照边缘光Saturation) = value;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0601E5F3 RID: 124403 RVA: 0x00912483 File Offset: 0x00910683
		// (set) Token: 0x0601E5F4 RID: 124404 RVA: 0x00912493 File Offset: 0x00910693
		public unsafe float 角色光照边缘光Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照边缘光Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_角色光照边缘光Value) = value;
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0601E5F5 RID: 124405 RVA: 0x009124A4 File Offset: 0x009106A4
		// (set) Token: 0x0601E5F6 RID: 124406 RVA: 0x009124B8 File Offset: 0x009106B8
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0601E5F7 RID: 124407 RVA: 0x009124CD File Offset: 0x009106CD
		// (set) Token: 0x0601E5F8 RID: 124408 RVA: 0x009124E1 File Offset: 0x009106E1
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_DynamicMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CameraEffect_C.__PropertyOffset_DynamicMaterial, value);
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0601E5F9 RID: 124409 RVA: 0x009124F6 File Offset: 0x009106F6
		// (set) Token: 0x0601E5FA RID: 124410 RVA: 0x00912506 File Offset: 0x00910706
		public unsafe float Mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Mode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Mode) = value;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0601E5FB RID: 124411 RVA: 0x00912517 File Offset: 0x00910717
		// (set) Token: 0x0601E5FC RID: 124412 RVA: 0x00912527 File Offset: 0x00910727
		public unsafe float BackgroundStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_BackgroundStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_BackgroundStrength) = value;
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0601E5FD RID: 124413 RVA: 0x00912538 File Offset: 0x00910738
		// (set) Token: 0x0601E5FE RID: 124414 RVA: 0x00912548 File Offset: 0x00910748
		public unsafe float RotationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_RotationAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_RotationAngle) = value;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0601E5FF RID: 124415 RVA: 0x00912559 File Offset: 0x00910759
		// (set) Token: 0x0601E600 RID: 124416 RVA: 0x00912569 File Offset: 0x00910769
		public unsafe float BlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_BlurIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_BlurIntensity) = value;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0601E601 RID: 124417 RVA: 0x0091257A File Offset: 0x0091077A
		// (set) Token: 0x0601E602 RID: 124418 RVA: 0x0091258A File Offset: 0x0091078A
		public unsafe float CircleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_CircleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_CircleRadius) = value;
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0601E603 RID: 124419 RVA: 0x0091259B File Offset: 0x0091079B
		// (set) Token: 0x0601E604 RID: 124420 RVA: 0x009125AB File Offset: 0x009107AB
		public unsafe float FrameThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_FrameThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_FrameThickness) = value;
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0601E605 RID: 124421 RVA: 0x009125BC File Offset: 0x009107BC
		// (set) Token: 0x0601E606 RID: 124422 RVA: 0x009125CC File Offset: 0x009107CC
		public unsafe float FrameX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_FrameX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_FrameX) = value;
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0601E607 RID: 124423 RVA: 0x009125DD File Offset: 0x009107DD
		// (set) Token: 0x0601E608 RID: 124424 RVA: 0x009125ED File Offset: 0x009107ED
		public unsafe float FrameY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_FrameY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_FrameY) = value;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0601E609 RID: 124425 RVA: 0x009125FE File Offset: 0x009107FE
		// (set) Token: 0x0601E60A RID: 124426 RVA: 0x0091260E File Offset: 0x0091080E
		public unsafe float Line1X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Line1X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Line1X) = value;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0601E60B RID: 124427 RVA: 0x0091261F File Offset: 0x0091081F
		// (set) Token: 0x0601E60C RID: 124428 RVA: 0x0091262F File Offset: 0x0091082F
		public unsafe float Line1Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Line1Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Line1Y) = value;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0601E60D RID: 124429 RVA: 0x00912640 File Offset: 0x00910840
		// (set) Token: 0x0601E60E RID: 124430 RVA: 0x00912650 File Offset: 0x00910850
		public unsafe float Line2X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Line2X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Line2X) = value;
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0601E60F RID: 124431 RVA: 0x00912661 File Offset: 0x00910861
		// (set) Token: 0x0601E610 RID: 124432 RVA: 0x00912671 File Offset: 0x00910871
		public unsafe float Line2Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Line2Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_Line2Y) = value;
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0601E611 RID: 124433 RVA: 0x00912682 File Offset: 0x00910882
		// (set) Token: 0x0601E612 RID: 124434 RVA: 0x00912692 File Offset: 0x00910892
		public unsafe float LineAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_LineAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_LineAlpha) = value;
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0601E613 RID: 124435 RVA: 0x009126A3 File Offset: 0x009108A3
		// (set) Token: 0x0601E614 RID: 124436 RVA: 0x009126B3 File Offset: 0x009108B3
		public unsafe float LineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_LineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_LineThickness) = value;
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0601E615 RID: 124437 RVA: 0x009126C4 File Offset: 0x009108C4
		// (set) Token: 0x0601E616 RID: 124438 RVA: 0x009126D4 File Offset: 0x009108D4
		public unsafe float EmissionPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_EmissionPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_EmissionPower) = value;
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0601E617 RID: 124439 RVA: 0x009126E5 File Offset: 0x009108E5
		// (set) Token: 0x0601E618 RID: 124440 RVA: 0x009126F5 File Offset: 0x009108F5
		public unsafe float EmissionRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_EmissionRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_EmissionRange) = value;
			}
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0601E619 RID: 124441 RVA: 0x00912706 File Offset: 0x00910906
		// (set) Token: 0x0601E61A RID: 124442 RVA: 0x00912716 File Offset: 0x00910916
		public unsafe float EmissionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_EmissionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_EmissionStrength) = value;
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0601E61B RID: 124443 RVA: 0x00912727 File Offset: 0x00910927
		// (set) Token: 0x0601E61C RID: 124444 RVA: 0x00912737 File Offset: 0x00910937
		public unsafe float ShadowPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_ShadowPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_ShadowPower) = value;
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0601E61D RID: 124445 RVA: 0x00912748 File Offset: 0x00910948
		// (set) Token: 0x0601E61E RID: 124446 RVA: 0x00912758 File Offset: 0x00910958
		public unsafe float ShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_ShadowRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_ShadowRange) = value;
			}
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0601E61F RID: 124447 RVA: 0x00912769 File Offset: 0x00910969
		// (set) Token: 0x0601E620 RID: 124448 RVA: 0x00912779 File Offset: 0x00910979
		public unsafe float ShadowStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_ShadowStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_ShadowStrength) = value;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0601E621 RID: 124449 RVA: 0x0091278A File Offset: 0x0091098A
		// (set) Token: 0x0601E622 RID: 124450 RVA: 0x0091279A File Offset: 0x0091099A
		public unsafe float MaskWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_MaskWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_MaskWidth) = value;
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0601E623 RID: 124451 RVA: 0x009127AB File Offset: 0x009109AB
		// (set) Token: 0x0601E624 RID: 124452 RVA: 0x009127BB File Offset: 0x009109BB
		public unsafe float MaskHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_MaskHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_MaskHeight) = value;
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0601E625 RID: 124453 RVA: 0x009127CC File Offset: 0x009109CC
		// (set) Token: 0x0601E626 RID: 124454 RVA: 0x009127E0 File Offset: 0x009109E0
		public unsafe FColor MaskColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_MaskColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_MaskColor) = value;
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0601E627 RID: 124455 RVA: 0x009127F5 File Offset: 0x009109F5
		// (set) Token: 0x0601E628 RID: 124456 RVA: 0x00912809 File Offset: 0x00910A09
		public unsafe FColor EmissionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_EmissionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_EmissionColor) = value;
			}
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0601E629 RID: 124457 RVA: 0x0091281E File Offset: 0x00910A1E
		// (set) Token: 0x0601E62A RID: 124458 RVA: 0x00912832 File Offset: 0x00910A32
		public unsafe FColor ShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_ShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_ShadowColor) = value;
			}
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0601E62B RID: 124459 RVA: 0x00912847 File Offset: 0x00910A47
		// (set) Token: 0x0601E62C RID: 124460 RVA: 0x00912857 File Offset: 0x00910A57
		public unsafe float RhombusRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_RhombusRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_RhombusRadius) = value;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0601E62D RID: 124461 RVA: 0x00912868 File Offset: 0x00910A68
		// (set) Token: 0x0601E62E RID: 124462 RVA: 0x00912878 File Offset: 0x00910A78
		public unsafe float PositionHorizon
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_PositionHorizon);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_PositionHorizon) = value;
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0601E62F RID: 124463 RVA: 0x00912889 File Offset: 0x00910A89
		// (set) Token: 0x0601E630 RID: 124464 RVA: 0x00912899 File Offset: 0x00910A99
		public unsafe float PositionVertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_PositionVertical);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_PositionVertical) = value;
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0601E631 RID: 124465 RVA: 0x009128AA File Offset: 0x00910AAA
		// (set) Token: 0x0601E632 RID: 124466 RVA: 0x009128BA File Offset: 0x00910ABA
		public unsafe float CircleMaskSoftness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_CircleMaskSoftness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_CircleMaskSoftness) = value;
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0601E633 RID: 124467 RVA: 0x009128CB File Offset: 0x00910ACB
		// (set) Token: 0x0601E634 RID: 124468 RVA: 0x009128DB File Offset: 0x00910ADB
		public unsafe float CircleMaskRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_CircleMaskRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_CircleMaskRadius) = value;
			}
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0601E635 RID: 124469 RVA: 0x009128EC File Offset: 0x00910AEC
		// (set) Token: 0x0601E636 RID: 124470 RVA: 0x009128FC File Offset: 0x00910AFC
		public unsafe int SavedDlssFixDof
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_SavedDlssFixDof);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_SavedDlssFixDof) = value;
			}
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0601E637 RID: 124471 RVA: 0x0091290D File Offset: 0x00910B0D
		// (set) Token: 0x0601E638 RID: 124472 RVA: 0x0091291D File Offset: 0x00910B1D
		public unsafe bool HasSavedDlssFixDof
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_HasSavedDlssFixDof) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CameraEffect_C.__PropertyOffset_HasSavedDlssFixDof) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E639 RID: 124473 RVA: 0x00912930 File Offset: 0x00910B30
		[SkipLocalsInit]
		public unsafe virtual void SetPPVWeatherDA(UKuroWeatherDataAsset WeatherDA)
		{
			BP_CameraEffect_C.__SetPPVWeatherDA_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__SetPPVWeatherDA_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CameraEffect_C.__SetPPVWeatherDA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__SetPPVWeatherDA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WeatherDA = ((WeatherDA != null) ? WeatherDA.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetPPVWeatherDA_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E63A RID: 124474 RVA: 0x00912988 File Offset: 0x00910B88
		[SkipLocalsInit]
		public unsafe virtual void SetPPVBlendWeight(float BlendWeight)
		{
			BP_CameraEffect_C.__SetPPVBlendWeight_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__SetPPVBlendWeight_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__SetPPVBlendWeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__SetPPVBlendWeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BlendWeight = BlendWeight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetPPVBlendWeight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E63B RID: 124475 RVA: 0x009129D0 File Offset: 0x00910BD0
		[SkipLocalsInit]
		public unsafe virtual void SetPPVPriority(float Priority)
		{
			BP_CameraEffect_C.__SetPPVPriority_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__SetPPVPriority_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__SetPPVPriority_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__SetPPVPriority_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Priority = Priority;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetPPVPriority_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E63C RID: 124476 RVA: 0x00912A18 File Offset: 0x00910C18
		[SkipLocalsInit]
		public unsafe virtual void SetNiagaraEffect(int Index)
		{
			BP_CameraEffect_C.__SetNiagaraEffect_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__SetNiagaraEffect_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CameraEffect_C.__SetNiagaraEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__SetNiagaraEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetNiagaraEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E63D RID: 124477 RVA: 0x00912A5E File Offset: 0x00910C5E
		[SkipLocalsInit]
		public virtual void 贴图画框()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__贴图画框_NativeFunctionPtr, null);
		}

		// Token: 0x0601E63E RID: 124478 RVA: 0x00912A72 File Offset: 0x00910C72
		[SkipLocalsInit]
		public virtual void 菱形遮罩()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__菱形遮罩_NativeFunctionPtr, null);
		}

		// Token: 0x0601E63F RID: 124479 RVA: 0x00912A86 File Offset: 0x00910C86
		[SkipLocalsInit]
		public virtual void 圆形遮罩()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__圆形遮罩_NativeFunctionPtr, null);
		}

		// Token: 0x0601E640 RID: 124480 RVA: 0x00912A9A File Offset: 0x00910C9A
		[SkipLocalsInit]
		public virtual void 纯色遮罩()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__纯色遮罩_NativeFunctionPtr, null);
		}

		// Token: 0x0601E641 RID: 124481 RVA: 0x00912AAE File Offset: 0x00910CAE
		[SkipLocalsInit]
		public virtual void 艺术画框()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__艺术画框_NativeFunctionPtr, null);
		}

		// Token: 0x0601E642 RID: 124482 RVA: 0x00912AC2 File Offset: 0x00910CC2
		[SkipLocalsInit]
		public virtual void 默认()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__默认_NativeFunctionPtr, null);
		}

		// Token: 0x0601E643 RID: 124483 RVA: 0x00912AD6 File Offset: 0x00910CD6
		[SkipLocalsInit]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0601E644 RID: 124484 RVA: 0x00912AEA File Offset: 0x00910CEA
		[SkipLocalsInit]
		public virtual void 关闭集群特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__关闭集群特效_NativeFunctionPtr, null);
		}

		// Token: 0x0601E645 RID: 124485 RVA: 0x00912AFE File Offset: 0x00910CFE
		[SkipLocalsInit]
		public virtual void _8彩带()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___8彩带_NativeFunctionPtr, null);
		}

		// Token: 0x0601E646 RID: 124486 RVA: 0x00912B12 File Offset: 0x00910D12
		[SkipLocalsInit]
		public virtual void _7蒲公英()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___7蒲公英_NativeFunctionPtr, null);
		}

		// Token: 0x0601E647 RID: 124487 RVA: 0x00912B26 File Offset: 0x00910D26
		[SkipLocalsInit]
		public virtual void _6樱花()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___6樱花_NativeFunctionPtr, null);
		}

		// Token: 0x0601E648 RID: 124488 RVA: 0x00912B3A File Offset: 0x00910D3A
		[SkipLocalsInit]
		public virtual void _5彼岸花()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___5彼岸花_NativeFunctionPtr, null);
		}

		// Token: 0x0601E649 RID: 124489 RVA: 0x00912B4E File Offset: 0x00910D4E
		[SkipLocalsInit]
		public virtual void _4竹叶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___4竹叶_NativeFunctionPtr, null);
		}

		// Token: 0x0601E64A RID: 124490 RVA: 0x00912B62 File Offset: 0x00910D62
		[SkipLocalsInit]
		public virtual void _3银杏叶()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___3银杏叶_NativeFunctionPtr, null);
		}

		// Token: 0x0601E64B RID: 124491 RVA: 0x00912B76 File Offset: 0x00910D76
		[SkipLocalsInit]
		public virtual void _2枫叶红()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___2枫叶红_NativeFunctionPtr, null);
		}

		// Token: 0x0601E64C RID: 124492 RVA: 0x00912B8A File Offset: 0x00910D8A
		[SkipLocalsInit]
		public virtual void _1枫叶橙()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.___1枫叶橙_NativeFunctionPtr, null);
		}

		// Token: 0x0601E64D RID: 124493 RVA: 0x00912B9E File Offset: 0x00910D9E
		[SkipLocalsInit]
		public virtual void UpdateCharacterLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__UpdateCharacterLight_NativeFunctionPtr, null);
		}

		// Token: 0x0601E64E RID: 124494 RVA: 0x00912BB2 File Offset: 0x00910DB2
		[SkipLocalsInit]
		public virtual void UpdateWindFieldDirectoin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__UpdateWindFieldDirectoin_NativeFunctionPtr, null);
		}

		// Token: 0x0601E64F RID: 124495 RVA: 0x00912BC6 File Offset: 0x00910DC6
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E650 RID: 124496 RVA: 0x00912BDA File Offset: 0x00910DDA
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E651 RID: 124497 RVA: 0x00912BEE File Offset: 0x00910DEE
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E652 RID: 124498 RVA: 0x00912C02 File Offset: 0x00910E02
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E653 RID: 124499 RVA: 0x00912C18 File Offset: 0x00910E18
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CameraEffect_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E654 RID: 124500 RVA: 0x00912C60 File Offset: 0x00910E60
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CameraEffect_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E655 RID: 124501 RVA: 0x00912CA8 File Offset: 0x00910EA8
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CameraEffect_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E656 RID: 124502 RVA: 0x00912CF0 File Offset: 0x00910EF0
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CameraEffect_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CameraEffect_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E657 RID: 124503 RVA: 0x00912D38 File Offset: 0x00910F38
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_CameraEffect_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CameraEffect_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E658 RID: 124504 RVA: 0x00912D84 File Offset: 0x00910F84
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_CameraEffect_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_CameraEffect_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_CameraEffect_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CameraEffect_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CameraEffect_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E659 RID: 124505 RVA: 0x00912DCF File Offset: 0x00910FCF
		protected BP_CameraEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401013D RID: 65853
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_CameraEffect.BP_CameraEffect_C";

		// Token: 0x0401013E RID: 65854
		private static IntPtr _ClassPtr;

		// Token: 0x0401013F RID: 65855
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010140 RID: 65856
		internal static int __PropertyOffset_KuroPostProcess;

		// Token: 0x04010141 RID: 65857
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010142 RID: 65858
		internal static int __PropertyOffset_全局风方向;

		// Token: 0x04010143 RID: 65859
		internal static int __PropertyOffset_角色光照方向_水平_;

		// Token: 0x04010144 RID: 65860
		internal static int __PropertyOffset_CurrentNS;

		// Token: 0x04010145 RID: 65861
		internal static int __PropertyOffset_集群特效密度;

		// Token: 0x04010146 RID: 65862
		internal static int __PropertyOffset_全局风强度;

		// Token: 0x04010147 RID: 65863
		internal static int __PropertyOffset_Niagara_System_Objects;

		// Token: 0x04010148 RID: 65864
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSystem> _Niagara_System_Objects;

		// Token: 0x04010149 RID: 65865
		internal static int __PropertyOffset_角色光照亮部Hue;

		// Token: 0x0401014A RID: 65866
		internal static int __PropertyOffset_角色光照亮部Saturation;

		// Token: 0x0401014B RID: 65867
		internal static int __PropertyOffset_角色光照亮部Value;

		// Token: 0x0401014C RID: 65868
		internal static int __PropertyOffset_角色光照暗部Hue;

		// Token: 0x0401014D RID: 65869
		internal static int __PropertyOffset_角色光照暗部Saturation;

		// Token: 0x0401014E RID: 65870
		internal static int __PropertyOffset_角色光照暗部Value;

		// Token: 0x0401014F RID: 65871
		internal static int __PropertyOffset_角色光照边缘光Hue;

		// Token: 0x04010150 RID: 65872
		internal static int __PropertyOffset_角色光照边缘光Saturation;

		// Token: 0x04010151 RID: 65873
		internal static int __PropertyOffset_角色光照边缘光Value;

		// Token: 0x04010152 RID: 65874
		internal static int __PropertyOffset_Material;

		// Token: 0x04010153 RID: 65875
		internal static int __PropertyOffset_DynamicMaterial;

		// Token: 0x04010154 RID: 65876
		internal static int __PropertyOffset_Mode;

		// Token: 0x04010155 RID: 65877
		internal static int __PropertyOffset_BackgroundStrength;

		// Token: 0x04010156 RID: 65878
		internal static int __PropertyOffset_RotationAngle;

		// Token: 0x04010157 RID: 65879
		internal static int __PropertyOffset_BlurIntensity;

		// Token: 0x04010158 RID: 65880
		internal static int __PropertyOffset_CircleRadius;

		// Token: 0x04010159 RID: 65881
		internal static int __PropertyOffset_FrameThickness;

		// Token: 0x0401015A RID: 65882
		internal static int __PropertyOffset_FrameX;

		// Token: 0x0401015B RID: 65883
		internal static int __PropertyOffset_FrameY;

		// Token: 0x0401015C RID: 65884
		internal static int __PropertyOffset_Line1X;

		// Token: 0x0401015D RID: 65885
		internal static int __PropertyOffset_Line1Y;

		// Token: 0x0401015E RID: 65886
		internal static int __PropertyOffset_Line2X;

		// Token: 0x0401015F RID: 65887
		internal static int __PropertyOffset_Line2Y;

		// Token: 0x04010160 RID: 65888
		internal static int __PropertyOffset_LineAlpha;

		// Token: 0x04010161 RID: 65889
		internal static int __PropertyOffset_LineThickness;

		// Token: 0x04010162 RID: 65890
		internal static int __PropertyOffset_EmissionPower;

		// Token: 0x04010163 RID: 65891
		internal static int __PropertyOffset_EmissionRange;

		// Token: 0x04010164 RID: 65892
		internal static int __PropertyOffset_EmissionStrength;

		// Token: 0x04010165 RID: 65893
		internal static int __PropertyOffset_ShadowPower;

		// Token: 0x04010166 RID: 65894
		internal static int __PropertyOffset_ShadowRange;

		// Token: 0x04010167 RID: 65895
		internal static int __PropertyOffset_ShadowStrength;

		// Token: 0x04010168 RID: 65896
		internal static int __PropertyOffset_MaskWidth;

		// Token: 0x04010169 RID: 65897
		internal static int __PropertyOffset_MaskHeight;

		// Token: 0x0401016A RID: 65898
		internal static int __PropertyOffset_MaskColor;

		// Token: 0x0401016B RID: 65899
		internal static int __PropertyOffset_EmissionColor;

		// Token: 0x0401016C RID: 65900
		internal static int __PropertyOffset_ShadowColor;

		// Token: 0x0401016D RID: 65901
		internal static int __PropertyOffset_RhombusRadius;

		// Token: 0x0401016E RID: 65902
		internal static int __PropertyOffset_PositionHorizon;

		// Token: 0x0401016F RID: 65903
		internal static int __PropertyOffset_PositionVertical;

		// Token: 0x04010170 RID: 65904
		internal static int __PropertyOffset_CircleMaskSoftness;

		// Token: 0x04010171 RID: 65905
		internal static int __PropertyOffset_CircleMaskRadius;

		// Token: 0x04010172 RID: 65906
		internal static int __PropertyOffset_SavedDlssFixDof;

		// Token: 0x04010173 RID: 65907
		internal static int __PropertyOffset_HasSavedDlssFixDof;

		// Token: 0x04010174 RID: 65908
		private static IntPtr __SetPPVWeatherDA_NativeFunctionPtr;

		// Token: 0x04010175 RID: 65909
		private static IntPtr __SetPPVBlendWeight_NativeFunctionPtr;

		// Token: 0x04010176 RID: 65910
		private static IntPtr __SetPPVPriority_NativeFunctionPtr;

		// Token: 0x04010177 RID: 65911
		private static IntPtr __SetNiagaraEffect_NativeFunctionPtr;

		// Token: 0x04010178 RID: 65912
		private static IntPtr __贴图画框_NativeFunctionPtr;

		// Token: 0x04010179 RID: 65913
		private static IntPtr __菱形遮罩_NativeFunctionPtr;

		// Token: 0x0401017A RID: 65914
		private static IntPtr __圆形遮罩_NativeFunctionPtr;

		// Token: 0x0401017B RID: 65915
		private static IntPtr __纯色遮罩_NativeFunctionPtr;

		// Token: 0x0401017C RID: 65916
		private static IntPtr __艺术画框_NativeFunctionPtr;

		// Token: 0x0401017D RID: 65917
		private static IntPtr __默认_NativeFunctionPtr;

		// Token: 0x0401017E RID: 65918
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0401017F RID: 65919
		private static IntPtr __关闭集群特效_NativeFunctionPtr;

		// Token: 0x04010180 RID: 65920
		private static IntPtr ___8彩带_NativeFunctionPtr;

		// Token: 0x04010181 RID: 65921
		private static IntPtr ___7蒲公英_NativeFunctionPtr;

		// Token: 0x04010182 RID: 65922
		private static IntPtr ___6樱花_NativeFunctionPtr;

		// Token: 0x04010183 RID: 65923
		private static IntPtr ___5彼岸花_NativeFunctionPtr;

		// Token: 0x04010184 RID: 65924
		private static IntPtr ___4竹叶_NativeFunctionPtr;

		// Token: 0x04010185 RID: 65925
		private static IntPtr ___3银杏叶_NativeFunctionPtr;

		// Token: 0x04010186 RID: 65926
		private static IntPtr ___2枫叶红_NativeFunctionPtr;

		// Token: 0x04010187 RID: 65927
		private static IntPtr ___1枫叶橙_NativeFunctionPtr;

		// Token: 0x04010188 RID: 65928
		private static IntPtr __UpdateCharacterLight_NativeFunctionPtr;

		// Token: 0x04010189 RID: 65929
		private static IntPtr __UpdateWindFieldDirectoin_NativeFunctionPtr;

		// Token: 0x0401018A RID: 65930
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401018B RID: 65931
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401018C RID: 65932
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401018D RID: 65933
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401018E RID: 65934
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008E6D RID: 36461
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetPPVWeatherDA_FunctionParams
		{
			// Token: 0x0402CABA RID: 182970
			[FieldOffset(0)]
			public IntPtr WeatherDA;
		}

		// Token: 0x02008E6E RID: 36462
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPPVBlendWeight_FunctionParams
		{
			// Token: 0x0402CABB RID: 182971
			[FieldOffset(0)]
			public float BlendWeight;
		}

		// Token: 0x02008E6F RID: 36463
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPPVPriority_FunctionParams
		{
			// Token: 0x0402CABC RID: 182972
			[FieldOffset(0)]
			public float Priority;
		}

		// Token: 0x02008E70 RID: 36464
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetNiagaraEffect_FunctionParams
		{
			// Token: 0x0402CABD RID: 182973
			[FieldOffset(0)]
			public int Index;
		}

		// Token: 0x02008E71 RID: 36465
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CABE RID: 182974
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E72 RID: 36466
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CABF RID: 182975
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E73 RID: 36467
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CAC0 RID: 182976
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
