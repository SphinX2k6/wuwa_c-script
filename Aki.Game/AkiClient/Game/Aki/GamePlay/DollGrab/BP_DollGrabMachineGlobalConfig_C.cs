using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.DollGrab
{
	// Token: 0x02003159 RID: 12633
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/DollGrab/BP_DollGrabMachineGlobalConfig.BP_DollGrabMachineGlobalConfig_C")]
	[UnrealStructLayout(928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class BP_DollGrabMachineGlobalConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F169 RID: 127337 RVA: 0x00926141 File Offset: 0x00924341
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollGrabMachineGlobalConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/DollGrab/BP_DollGrabMachineGlobalConfig.BP_DollGrabMachineGlobalConfig_C");
			}
			return BP_DollGrabMachineGlobalConfig_C._ClassPtr;
		}

		// Token: 0x0601F16A RID: 127338 RVA: 0x00926168 File Offset: 0x00924368
		public BP_DollGrabMachineGlobalConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabMachineGlobalConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F16B RID: 127339 RVA: 0x00926190 File Offset: 0x00924390
		public BP_DollGrabMachineGlobalConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollGrabMachineGlobalConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0601F16C RID: 127340 RVA: 0x009261C3 File Offset: 0x009243C3
		// (set) Token: 0x0601F16D RID: 127341 RVA: 0x009261D3 File Offset: 0x009243D3
		public unsafe float 钩爪移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪移动速度) = value;
			}
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x0601F16E RID: 127342 RVA: 0x009261E4 File Offset: 0x009243E4
		// (set) Token: 0x0601F16F RID: 127343 RVA: 0x009261F4 File Offset: 0x009243F4
		public unsafe float 钩爪X轴移动距离限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪X轴移动距离限制);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪X轴移动距离限制) = value;
			}
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0601F170 RID: 127344 RVA: 0x00926205 File Offset: 0x00924405
		// (set) Token: 0x0601F171 RID: 127345 RVA: 0x00926215 File Offset: 0x00924415
		public unsafe float 钩爪X轴起始偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪X轴起始偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪X轴起始偏移) = value;
			}
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0601F172 RID: 127346 RVA: 0x00926226 File Offset: 0x00924426
		// (set) Token: 0x0601F173 RID: 127347 RVA: 0x00926236 File Offset: 0x00924436
		public unsafe float 钩爪Y轴移动距离限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪Y轴移动距离限制);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪Y轴移动距离限制) = value;
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0601F174 RID: 127348 RVA: 0x00926247 File Offset: 0x00924447
		// (set) Token: 0x0601F175 RID: 127349 RVA: 0x00926257 File Offset: 0x00924457
		public unsafe float 钩爪Y轴起始偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪Y轴起始偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪Y轴起始偏移) = value;
			}
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0601F176 RID: 127350 RVA: 0x00926268 File Offset: 0x00924468
		// (set) Token: 0x0601F177 RID: 127351 RVA: 0x00926278 File Offset: 0x00924478
		public unsafe float 钩爪下探距离限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪下探距离限制);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪下探距离限制) = value;
			}
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0601F178 RID: 127352 RVA: 0x00926289 File Offset: 0x00924489
		// (set) Token: 0x0601F179 RID: 127353 RVA: 0x00926299 File Offset: 0x00924499
		public unsafe float 钩爪下探速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪下探速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪下探速度) = value;
			}
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0601F17A RID: 127354 RVA: 0x009262AA File Offset: 0x009244AA
		// (set) Token: 0x0601F17B RID: 127355 RVA: 0x009262BA File Offset: 0x009244BA
		public unsafe float 钩爪上升速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪上升速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪上升速度) = value;
			}
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0601F17C RID: 127356 RVA: 0x009262CB File Offset: 0x009244CB
		// (set) Token: 0x0601F17D RID: 127357 RVA: 0x009262DF File Offset: 0x009244DF
		public unsafe FVector 相机位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_相机位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_相机位置) = value;
			}
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0601F17E RID: 127358 RVA: 0x009262F4 File Offset: 0x009244F4
		// (set) Token: 0x0601F17F RID: 127359 RVA: 0x00926308 File Offset: 0x00924508
		public unsafe FRotator 相机旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_相机旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_相机旋转) = value;
			}
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0601F180 RID: 127360 RVA: 0x0092631D File Offset: 0x0092451D
		// (set) Token: 0x0601F181 RID: 127361 RVA: 0x0092632D File Offset: 0x0092452D
		public unsafe float 淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_淡入时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_淡入时间) = value;
			}
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0601F182 RID: 127362 RVA: 0x0092633E File Offset: 0x0092453E
		// (set) Token: 0x0601F183 RID: 127363 RVA: 0x0092634E File Offset: 0x0092454E
		public unsafe float 淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_淡出时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_淡出时间) = value;
			}
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0601F184 RID: 127364 RVA: 0x0092635F File Offset: 0x0092455F
		// (set) Token: 0x0601F185 RID: 127365 RVA: 0x0092636F File Offset: 0x0092456F
		public unsafe bool 关闭镜头碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_关闭镜头碰撞) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_关闭镜头碰撞) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0601F186 RID: 127366 RVA: 0x00926380 File Offset: 0x00924580
		// (set) Token: 0x0601F187 RID: 127367 RVA: 0x00926390 File Offset: 0x00924590
		public unsafe bool 关闭镜头虚化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_关闭镜头虚化) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_关闭镜头虚化) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0601F188 RID: 127368 RVA: 0x009263A1 File Offset: 0x009245A1
		// (set) Token: 0x0601F189 RID: 127369 RVA: 0x009263B1 File Offset: 0x009245B1
		public unsafe float Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_Fov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_Fov) = value;
			}
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0601F18A RID: 127370 RVA: 0x009263C2 File Offset: 0x009245C2
		// (set) Token: 0x0601F18B RID: 127371 RVA: 0x009263D2 File Offset: 0x009245D2
		public unsafe float 履带移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_履带移动速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_履带移动速度) = value;
			}
		}

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0601F18C RID: 127372 RVA: 0x009263E3 File Offset: 0x009245E3
		// (set) Token: 0x0601F18D RID: 127373 RVA: 0x009263F3 File Offset: 0x009245F3
		public unsafe float 履带吸附距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_履带吸附距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_履带吸附距离) = value;
			}
		}

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0601F18E RID: 127374 RVA: 0x00926404 File Offset: 0x00924604
		// (set) Token: 0x0601F18F RID: 127375 RVA: 0x00926414 File Offset: 0x00924614
		public unsafe float 履带吸附速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_履带吸附速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_履带吸附速度) = value;
			}
		}

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0601F190 RID: 127376 RVA: 0x00926425 File Offset: 0x00924625
		// (set) Token: 0x0601F191 RID: 127377 RVA: 0x00926435 File Offset: 0x00924635
		public unsafe float 履带TriggerZ轴缩放值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_履带TriggerZ轴缩放值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_履带TriggerZ轴缩放值) = value;
			}
		}

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0601F192 RID: 127378 RVA: 0x00926446 File Offset: 0x00924646
		// (set) Token: 0x0601F193 RID: 127379 RVA: 0x0092645A File Offset: 0x0092465A
		public unsafe FVector 展示柜相机位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜相机位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜相机位置) = value;
			}
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0601F194 RID: 127380 RVA: 0x0092646F File Offset: 0x0092466F
		// (set) Token: 0x0601F195 RID: 127381 RVA: 0x00926483 File Offset: 0x00924683
		public unsafe FRotator 展示柜相机旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜相机旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜相机旋转) = value;
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0601F196 RID: 127382 RVA: 0x00926498 File Offset: 0x00924698
		// (set) Token: 0x0601F197 RID: 127383 RVA: 0x009264A8 File Offset: 0x009246A8
		public unsafe float 展示柜淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜淡入时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜淡入时间) = value;
			}
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0601F198 RID: 127384 RVA: 0x009264B9 File Offset: 0x009246B9
		// (set) Token: 0x0601F199 RID: 127385 RVA: 0x009264C9 File Offset: 0x009246C9
		public unsafe float 展示柜淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜淡出时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜淡出时间) = value;
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0601F19A RID: 127386 RVA: 0x009264DA File Offset: 0x009246DA
		// (set) Token: 0x0601F19B RID: 127387 RVA: 0x009264EA File Offset: 0x009246EA
		public unsafe bool 展示柜关闭镜头碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜关闭镜头碰撞) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜关闭镜头碰撞) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0601F19C RID: 127388 RVA: 0x009264FB File Offset: 0x009246FB
		// (set) Token: 0x0601F19D RID: 127389 RVA: 0x0092650B File Offset: 0x0092470B
		public unsafe bool 展示柜关闭镜头虚化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜关闭镜头虚化) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜关闭镜头虚化) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0601F19E RID: 127390 RVA: 0x0092651C File Offset: 0x0092471C
		// (set) Token: 0x0601F19F RID: 127391 RVA: 0x0092652C File Offset: 0x0092472C
		public unsafe float 展示柜Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜Fov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示柜Fov) = value;
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0601F1A0 RID: 127392 RVA: 0x0092653D File Offset: 0x0092473D
		// (set) Token: 0x0601F1A1 RID: 127393 RVA: 0x0092654D File Offset: 0x0092474D
		public unsafe float 钩爪延迟合上时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪延迟合上时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪延迟合上时间) = value;
			}
		}

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0601F1A2 RID: 127394 RVA: 0x0092655E File Offset: 0x0092475E
		// (set) Token: 0x0601F1A3 RID: 127395 RVA: 0x00926573 File Offset: 0x00924773
		public TSoftObjectPtr<ULevelSequence> 钩爪Seq
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪Seq, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪Seq, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0601F1A4 RID: 127396 RVA: 0x00926598 File Offset: 0x00924798
		// (set) Token: 0x0601F1A5 RID: 127397 RVA: 0x009265A8 File Offset: 0x009247A8
		public unsafe float 钩爪锁链缩放比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪锁链缩放比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪锁链缩放比例) = value;
			}
		}

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0601F1A6 RID: 127398 RVA: 0x009265B9 File Offset: 0x009247B9
		// (set) Token: 0x0601F1A7 RID: 127399 RVA: 0x009265C9 File Offset: 0x009247C9
		public unsafe float 钩爪复位时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪复位时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪复位时间) = value;
			}
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0601F1A8 RID: 127400 RVA: 0x009265DA File Offset: 0x009247DA
		// (set) Token: 0x0601F1A9 RID: 127401 RVA: 0x009265EA File Offset: 0x009247EA
		public unsafe float 溶解时长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_溶解时长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_溶解时长) = value;
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0601F1AA RID: 127402 RVA: 0x009265FB File Offset: 0x009247FB
		// (set) Token: 0x0601F1AB RID: 127403 RVA: 0x0092660B File Offset: 0x0092480B
		public unsafe float 溶解半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_溶解半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_溶解半径) = value;
			}
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0601F1AC RID: 127404 RVA: 0x0092661C File Offset: 0x0092481C
		// (set) Token: 0x0601F1AD RID: 127405 RVA: 0x0092662C File Offset: 0x0092482C
		public unsafe float 旋转阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_旋转阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_旋转阻尼) = value;
			}
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0601F1AE RID: 127406 RVA: 0x0092663D File Offset: 0x0092483D
		// (set) Token: 0x0601F1AF RID: 127407 RVA: 0x0092664D File Offset: 0x0092484D
		public unsafe float 平移阻尼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_平移阻尼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_平移阻尼) = value;
			}
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0601F1B0 RID: 127408 RVA: 0x0092665E File Offset: 0x0092485E
		// (set) Token: 0x0601F1B1 RID: 127409 RVA: 0x00926673 File Offset: 0x00924873
		public TSoftObjectPtr<UEffectModelGroup> 倒计时屏幕特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_倒计时屏幕特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_倒计时屏幕特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0601F1B2 RID: 127410 RVA: 0x00926698 File Offset: 0x00924898
		// (set) Token: 0x0601F1B3 RID: 127411 RVA: 0x009266AD File Offset: 0x009248AD
		public TSoftObjectPtr<UTexture> 钩爪松开按钮图标
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪松开按钮图标, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪松开按钮图标, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0601F1B4 RID: 127412 RVA: 0x009266D2 File Offset: 0x009248D2
		// (set) Token: 0x0601F1B5 RID: 127413 RVA: 0x009266E7 File Offset: 0x009248E7
		public TSoftObjectPtr<UTexture> 钩爪常态按钮图标
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪常态按钮图标, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪常态按钮图标, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0601F1B6 RID: 127414 RVA: 0x0092670C File Offset: 0x0092490C
		// (set) Token: 0x0601F1B7 RID: 127415 RVA: 0x00926721 File Offset: 0x00924921
		public TSoftObjectPtr<UTexture> 钩爪抓取按钮图标
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪抓取按钮图标, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪抓取按钮图标, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0601F1B8 RID: 127416 RVA: 0x00926746 File Offset: 0x00924946
		// (set) Token: 0x0601F1B9 RID: 127417 RVA: 0x0092675B File Offset: 0x0092495B
		public TSoftObjectPtr<UTexture> 投币按钮图标
		{
			get
			{
				return new TSoftObjectPtr<UTexture>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_投币按钮图标, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_投币按钮图标, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0601F1BA RID: 127418 RVA: 0x00926780 File Offset: 0x00924980
		// (set) Token: 0x0601F1BB RID: 127419 RVA: 0x00926794 File Offset: 0x00924994
		public unsafe FVector 投出口特效偏移位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_投出口特效偏移位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_投出口特效偏移位置) = value;
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0601F1BC RID: 127420 RVA: 0x009267A9 File Offset: 0x009249A9
		// (set) Token: 0x0601F1BD RID: 127421 RVA: 0x009267B9 File Offset: 0x009249B9
		public unsafe float 危险倒计时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_危险倒计时);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_危险倒计时) = value;
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0601F1BE RID: 127422 RVA: 0x009267CA File Offset: 0x009249CA
		// (set) Token: 0x0601F1BF RID: 127423 RVA: 0x009267DF File Offset: 0x009249DF
		public TSoftObjectPtr<ULGUITexturePackerSpriteData> 进度条安全
		{
			get
			{
				return new TSoftObjectPtr<ULGUITexturePackerSpriteData>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_进度条安全, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_进度条安全, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0601F1C0 RID: 127424 RVA: 0x00926804 File Offset: 0x00924A04
		// (set) Token: 0x0601F1C1 RID: 127425 RVA: 0x00926819 File Offset: 0x00924A19
		public TSoftObjectPtr<ULGUITexturePackerSpriteData> 进度条危险
		{
			get
			{
				return new TSoftObjectPtr<ULGUITexturePackerSpriteData>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_进度条危险, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_进度条危险, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0601F1C2 RID: 127426 RVA: 0x0092683E File Offset: 0x00924A3E
		// (set) Token: 0x0601F1C3 RID: 127427 RVA: 0x00926853 File Offset: 0x00924A53
		public TSoftObjectPtr<ULevelSequence> 常态灯光
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_常态灯光, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_常态灯光, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0601F1C4 RID: 127428 RVA: 0x00926878 File Offset: 0x00924A78
		// (set) Token: 0x0601F1C5 RID: 127429 RVA: 0x0092688D File Offset: 0x00924A8D
		public TSoftObjectPtr<ULevelSequence> 完成态灯光
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_完成态灯光, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_完成态灯光, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0601F1C6 RID: 127430 RVA: 0x009268B2 File Offset: 0x00924AB2
		// (set) Token: 0x0601F1C7 RID: 127431 RVA: 0x009268C7 File Offset: 0x00924AC7
		public TSoftObjectPtr<ULevelSequence> 开启玩法灯光
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_开启玩法灯光, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_开启玩法灯光, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0601F1C8 RID: 127432 RVA: 0x009268EC File Offset: 0x00924AEC
		// (set) Token: 0x0601F1C9 RID: 127433 RVA: 0x00926901 File Offset: 0x00924B01
		public TSoftObjectPtr<ULevelSequence> 玩法进行中灯光
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_玩法进行中灯光, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_玩法进行中灯光, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0601F1CA RID: 127434 RVA: 0x00926926 File Offset: 0x00924B26
		// (set) Token: 0x0601F1CB RID: 127435 RVA: 0x00926936 File Offset: 0x00924B36
		public unsafe float 钩爪松开时恢复移动时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪松开时恢复移动时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_钩爪松开时恢复移动时间) = value;
			}
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0601F1CC RID: 127436 RVA: 0x00926947 File Offset: 0x00924B47
		// (set) Token: 0x0601F1CD RID: 127437 RVA: 0x0092695C File Offset: 0x00924B5C
		public TSoftObjectPtr<ULevelSequence> 阿布展示Seq
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_阿布展示Seq, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_阿布展示Seq, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0601F1CE RID: 127438 RVA: 0x00926981 File Offset: 0x00924B81
		// (set) Token: 0x0601F1CF RID: 127439 RVA: 0x00926995 File Offset: 0x00924B95
		public unsafe FVectorDouble 阿布展示播放位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_阿布展示播放位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_阿布展示播放位置) = value;
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0601F1D0 RID: 127440 RVA: 0x009269AA File Offset: 0x00924BAA
		// (set) Token: 0x0601F1D1 RID: 127441 RVA: 0x009269BA File Offset: 0x00924BBA
		public unsafe float 黑幕淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_黑幕淡入时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_黑幕淡入时间) = value;
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0601F1D2 RID: 127442 RVA: 0x009269CB File Offset: 0x00924BCB
		// (set) Token: 0x0601F1D3 RID: 127443 RVA: 0x009269DB File Offset: 0x00924BDB
		public unsafe float 黑幕淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_黑幕淡出时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_黑幕淡出时间) = value;
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0601F1D4 RID: 127444 RVA: 0x009269EC File Offset: 0x00924BEC
		// (set) Token: 0x0601F1D5 RID: 127445 RVA: 0x009269FC File Offset: 0x00924BFC
		public unsafe float 黑幕持续时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_黑幕持续时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_黑幕持续时间) = value;
			}
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0601F1D6 RID: 127446 RVA: 0x00926A0D File Offset: 0x00924C0D
		// (set) Token: 0x0601F1D7 RID: 127447 RVA: 0x00926A1D File Offset: 0x00924C1D
		public unsafe float 展示动画播放速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示动画播放速率);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DollGrabMachineGlobalConfig_C.__PropertyOffset_展示动画播放速率) = value;
			}
		}

		// Token: 0x0601F1D8 RID: 127448 RVA: 0x00926A2E File Offset: 0x00924C2E
		protected BP_DollGrabMachineGlobalConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109C9 RID: 68041
		public new const string __ObjectPath = "/Game/Aki/GamePlay/DollGrab/BP_DollGrabMachineGlobalConfig.BP_DollGrabMachineGlobalConfig_C";

		// Token: 0x040109CA RID: 68042
		private static IntPtr _ClassPtr;

		// Token: 0x040109CB RID: 68043
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109CC RID: 68044
		internal static int __PropertyOffset_钩爪移动速度;

		// Token: 0x040109CD RID: 68045
		internal static int __PropertyOffset_钩爪X轴移动距离限制;

		// Token: 0x040109CE RID: 68046
		internal static int __PropertyOffset_钩爪X轴起始偏移;

		// Token: 0x040109CF RID: 68047
		internal static int __PropertyOffset_钩爪Y轴移动距离限制;

		// Token: 0x040109D0 RID: 68048
		internal static int __PropertyOffset_钩爪Y轴起始偏移;

		// Token: 0x040109D1 RID: 68049
		internal static int __PropertyOffset_钩爪下探距离限制;

		// Token: 0x040109D2 RID: 68050
		internal static int __PropertyOffset_钩爪下探速度;

		// Token: 0x040109D3 RID: 68051
		internal static int __PropertyOffset_钩爪上升速度;

		// Token: 0x040109D4 RID: 68052
		internal static int __PropertyOffset_相机位置;

		// Token: 0x040109D5 RID: 68053
		internal static int __PropertyOffset_相机旋转;

		// Token: 0x040109D6 RID: 68054
		internal static int __PropertyOffset_淡入时间;

		// Token: 0x040109D7 RID: 68055
		internal static int __PropertyOffset_淡出时间;

		// Token: 0x040109D8 RID: 68056
		internal static int __PropertyOffset_关闭镜头碰撞;

		// Token: 0x040109D9 RID: 68057
		internal static int __PropertyOffset_关闭镜头虚化;

		// Token: 0x040109DA RID: 68058
		internal static int __PropertyOffset_Fov;

		// Token: 0x040109DB RID: 68059
		internal static int __PropertyOffset_履带移动速度;

		// Token: 0x040109DC RID: 68060
		internal static int __PropertyOffset_履带吸附距离;

		// Token: 0x040109DD RID: 68061
		internal static int __PropertyOffset_履带吸附速度;

		// Token: 0x040109DE RID: 68062
		internal static int __PropertyOffset_履带TriggerZ轴缩放值;

		// Token: 0x040109DF RID: 68063
		internal static int __PropertyOffset_展示柜相机位置;

		// Token: 0x040109E0 RID: 68064
		internal static int __PropertyOffset_展示柜相机旋转;

		// Token: 0x040109E1 RID: 68065
		internal static int __PropertyOffset_展示柜淡入时间;

		// Token: 0x040109E2 RID: 68066
		internal static int __PropertyOffset_展示柜淡出时间;

		// Token: 0x040109E3 RID: 68067
		internal static int __PropertyOffset_展示柜关闭镜头碰撞;

		// Token: 0x040109E4 RID: 68068
		internal static int __PropertyOffset_展示柜关闭镜头虚化;

		// Token: 0x040109E5 RID: 68069
		internal static int __PropertyOffset_展示柜Fov;

		// Token: 0x040109E6 RID: 68070
		internal static int __PropertyOffset_钩爪延迟合上时间;

		// Token: 0x040109E7 RID: 68071
		internal static int __PropertyOffset_钩爪Seq;

		// Token: 0x040109E8 RID: 68072
		internal static int __PropertyOffset_钩爪锁链缩放比例;

		// Token: 0x040109E9 RID: 68073
		internal static int __PropertyOffset_钩爪复位时间;

		// Token: 0x040109EA RID: 68074
		internal static int __PropertyOffset_溶解时长;

		// Token: 0x040109EB RID: 68075
		internal static int __PropertyOffset_溶解半径;

		// Token: 0x040109EC RID: 68076
		internal static int __PropertyOffset_旋转阻尼;

		// Token: 0x040109ED RID: 68077
		internal static int __PropertyOffset_平移阻尼;

		// Token: 0x040109EE RID: 68078
		internal static int __PropertyOffset_倒计时屏幕特效;

		// Token: 0x040109EF RID: 68079
		internal static int __PropertyOffset_钩爪松开按钮图标;

		// Token: 0x040109F0 RID: 68080
		internal static int __PropertyOffset_钩爪常态按钮图标;

		// Token: 0x040109F1 RID: 68081
		internal static int __PropertyOffset_钩爪抓取按钮图标;

		// Token: 0x040109F2 RID: 68082
		internal static int __PropertyOffset_投币按钮图标;

		// Token: 0x040109F3 RID: 68083
		internal static int __PropertyOffset_投出口特效偏移位置;

		// Token: 0x040109F4 RID: 68084
		internal static int __PropertyOffset_危险倒计时;

		// Token: 0x040109F5 RID: 68085
		internal static int __PropertyOffset_进度条安全;

		// Token: 0x040109F6 RID: 68086
		internal static int __PropertyOffset_进度条危险;

		// Token: 0x040109F7 RID: 68087
		internal static int __PropertyOffset_常态灯光;

		// Token: 0x040109F8 RID: 68088
		internal static int __PropertyOffset_完成态灯光;

		// Token: 0x040109F9 RID: 68089
		internal static int __PropertyOffset_开启玩法灯光;

		// Token: 0x040109FA RID: 68090
		internal static int __PropertyOffset_玩法进行中灯光;

		// Token: 0x040109FB RID: 68091
		internal static int __PropertyOffset_钩爪松开时恢复移动时间;

		// Token: 0x040109FC RID: 68092
		internal static int __PropertyOffset_阿布展示Seq;

		// Token: 0x040109FD RID: 68093
		internal static int __PropertyOffset_阿布展示播放位置;

		// Token: 0x040109FE RID: 68094
		internal static int __PropertyOffset_黑幕淡入时间;

		// Token: 0x040109FF RID: 68095
		internal static int __PropertyOffset_黑幕淡出时间;

		// Token: 0x04010A00 RID: 68096
		internal static int __PropertyOffset_黑幕持续时间;

		// Token: 0x04010A01 RID: 68097
		internal static int __PropertyOffset_展示动画播放速率;
	}
}
