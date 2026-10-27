using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MusicInteraction
{
	// Token: 0x02003C4C RID: 15436
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_MusicLight.BP_MusicLight_C")]
	[UnrealStructLayout(2544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2544)]
	public class BP_MusicLight_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023C0C RID: 146444 RVA: 0x0092BDE8 File Offset: 0x00929FE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MusicLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_MusicLight.BP_MusicLight_C");
			}
			return BP_MusicLight_C._ClassPtr;
		}

		// Token: 0x06023C0D RID: 146445 RVA: 0x0092BE0C File Offset: 0x0092A00C
		public BP_MusicLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_MusicLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023C0E RID: 146446 RVA: 0x0092BE34 File Offset: 0x0092A034
		[NullableContext(1)]
		public BP_MusicLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MusicLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x06023C0F RID: 146447 RVA: 0x0092BE67 File Offset: 0x0092A067
		// (set) Token: 0x06023C10 RID: 146448 RVA: 0x0092BE7B File Offset: 0x0092A07B
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700435F RID: 17247
		// (get) Token: 0x06023C11 RID: 146449 RVA: 0x0092BE90 File Offset: 0x0092A090
		// (set) Token: 0x06023C12 RID: 146450 RVA: 0x0092BEA4 File Offset: 0x0092A0A4
		public unsafe UChildActorComponent BP_VolumetricLightMonitor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004360 RID: 17248
		// (get) Token: 0x06023C13 RID: 146451 RVA: 0x0092BEB9 File Offset: 0x0092A0B9
		// (set) Token: 0x06023C14 RID: 146452 RVA: 0x0092BECD File Offset: 0x0092A0CD
		public unsafe USpotLightComponent SpotLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpotLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x06023C15 RID: 146453 RVA: 0x0092BEE2 File Offset: 0x0092A0E2
		// (set) Token: 0x06023C16 RID: 146454 RVA: 0x0092BEF6 File Offset: 0x0092A0F6
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004362 RID: 17250
		// (get) Token: 0x06023C17 RID: 146455 RVA: 0x0092BF0B File Offset: 0x0092A10B
		// (set) Token: 0x06023C18 RID: 146456 RVA: 0x0092BF1B File Offset: 0x0092A11B
		public unsafe bool 双拍触发
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004363 RID: 17251
		// (get) Token: 0x06023C19 RID: 146457 RVA: 0x0092BF2C File Offset: 0x0092A12C
		// (set) Token: 0x06023C1A RID: 146458 RVA: 0x0092BF65 File Offset: 0x0092A165
		[Nullable(1)]
		public FKuroCurveFloat 灯光强度
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._灯光强度) == null)
				{
					result = (this._灯光强度 = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004364 RID: 17252
		// (get) Token: 0x06023C1B RID: 146459 RVA: 0x0092BF88 File Offset: 0x0092A188
		// (set) Token: 0x06023C1C RID: 146460 RVA: 0x0092BFC1 File Offset: 0x0092A1C1
		[Nullable(1)]
		public FKuroCurveFloat 衰减半径
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._衰减半径) == null)
				{
					result = (this._衰减半径 = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004365 RID: 17253
		// (get) Token: 0x06023C1D RID: 146461 RVA: 0x0092BFE4 File Offset: 0x0092A1E4
		// (set) Token: 0x06023C1E RID: 146462 RVA: 0x0092C01D File Offset: 0x0092A21D
		[Nullable(1)]
		public FKuroCurveLinearColor 灯光颜色
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveLinearColor result;
				if ((result = this._灯光颜色) == null)
				{
					result = (this._灯光颜色 = new FKuroCurveLinearColor(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004366 RID: 17254
		// (get) Token: 0x06023C1F RID: 146463 RVA: 0x0092C03E File Offset: 0x0092A23E
		// (set) Token: 0x06023C20 RID: 146464 RVA: 0x0092C04E File Offset: 0x0092A24E
		public unsafe float 光源衰减指数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x06023C21 RID: 146465 RVA: 0x0092C05F File Offset: 0x0092A25F
		// (set) Token: 0x06023C22 RID: 146466 RVA: 0x0092C06F File Offset: 0x0092A26F
		public unsafe bool 启用聚光灯
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x06023C23 RID: 146467 RVA: 0x0092C080 File Offset: 0x0092A280
		// (set) Token: 0x06023C24 RID: 146468 RVA: 0x0092C090 File Offset: 0x0092A290
		public unsafe bool 聚光灯投射阴影
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x06023C25 RID: 146469 RVA: 0x0092C0A1 File Offset: 0x0092A2A1
		// (set) Token: 0x06023C26 RID: 146470 RVA: 0x0092C0B5 File Offset: 0x0092A2B5
		public unsafe FVector 聚光灯体积光缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x06023C27 RID: 146471 RVA: 0x0092C0CA File Offset: 0x0092A2CA
		// (set) Token: 0x06023C28 RID: 146472 RVA: 0x0092C0DA File Offset: 0x0092A2DA
		public unsafe float 聚光灯椎体内部角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x06023C29 RID: 146473 RVA: 0x0092C0EB File Offset: 0x0092A2EB
		// (set) Token: 0x06023C2A RID: 146474 RVA: 0x0092C0FB File Offset: 0x0092A2FB
		public unsafe float 聚光灯椎体外部角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x06023C2B RID: 146475 RVA: 0x0092C10C File Offset: 0x0092A30C
		// (set) Token: 0x06023C2C RID: 146476 RVA: 0x0092C145 File Offset: 0x0092A345
		[Nullable(1)]
		public FKuroCurveFloat 聚光灯摆动
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._聚光灯摆动) == null)
				{
					result = (this._聚光灯摆动 = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_15, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_15, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700436D RID: 17261
		// (get) Token: 0x06023C2D RID: 146477 RVA: 0x0092C166 File Offset: 0x0092A366
		// (set) Token: 0x06023C2E RID: 146478 RVA: 0x0092C176 File Offset: 0x0092A376
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x06023C2F RID: 146479 RVA: 0x0092C187 File Offset: 0x0092A387
		// (set) Token: 0x06023C30 RID: 146480 RVA: 0x0092C197 File Offset: 0x0092A397
		public unsafe float 单拍时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x06023C31 RID: 146481 RVA: 0x0092C1A8 File Offset: 0x0092A3A8
		// (set) Token: 0x06023C32 RID: 146482 RVA: 0x0092C1B8 File Offset: 0x0092A3B8
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x06023C33 RID: 146483 RVA: 0x0092C1C9 File Offset: 0x0092A3C9
		// (set) Token: 0x06023C34 RID: 146484 RVA: 0x0092C1D9 File Offset: 0x0092A3D9
		public unsafe float BeatTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x06023C35 RID: 146485 RVA: 0x0092C1EA File Offset: 0x0092A3EA
		// (set) Token: 0x06023C36 RID: 146486 RVA: 0x0092C1FA File Offset: 0x0092A3FA
		public unsafe int BeatNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MusicLight_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x06023C37 RID: 146487 RVA: 0x0092C20B File Offset: 0x0092A40B
		// (set) Token: 0x06023C38 RID: 146488 RVA: 0x0092C21F File Offset: 0x0092A41F
		public unsafe UPointLightComponent Light
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MusicLight_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x06023C39 RID: 146489 RVA: 0x0092C234 File Offset: 0x0092A434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MusicLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023C3A RID: 146490 RVA: 0x0092C248 File Offset: 0x0092A448
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MusicLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023C3B RID: 146491 RVA: 0x0092C260 File Offset: 0x0092A460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MusicLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MusicLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MusicLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MusicLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MusicLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023C3C RID: 146492 RVA: 0x0092C2A8 File Offset: 0x0092A4A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MusicLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MusicLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MusicLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MusicLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MusicLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023C3D RID: 146493 RVA: 0x0092C2F0 File Offset: 0x0092A4F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MusicLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MusicLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MusicLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MusicLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MusicLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023C3E RID: 146494 RVA: 0x0092C338 File Offset: 0x0092A538
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MusicLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MusicLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MusicLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MusicLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MusicLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023C3F RID: 146495 RVA: 0x0092C37F File Offset: 0x0092A57F
		protected BP_MusicLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AB2 RID: 72370
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MusicInteraction/BP_MusicLight.BP_MusicLight_C";

		// Token: 0x04011AB3 RID: 72371
		private static IntPtr _ClassPtr;

		// Token: 0x04011AB4 RID: 72372
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011AB5 RID: 72373
		internal static int __PropertyOffset_1;

		// Token: 0x04011AB6 RID: 72374
		internal static int __PropertyOffset_2;

		// Token: 0x04011AB7 RID: 72375
		internal static int __PropertyOffset_3;

		// Token: 0x04011AB8 RID: 72376
		internal static int __PropertyOffset_4;

		// Token: 0x04011AB9 RID: 72377
		internal static int __PropertyOffset_5;

		// Token: 0x04011ABA RID: 72378
		internal static int __PropertyOffset_6;

		// Token: 0x04011ABB RID: 72379
		private FKuroCurveFloat _灯光强度;

		// Token: 0x04011ABC RID: 72380
		internal static int __PropertyOffset_7;

		// Token: 0x04011ABD RID: 72381
		private FKuroCurveFloat _衰减半径;

		// Token: 0x04011ABE RID: 72382
		internal static int __PropertyOffset_8;

		// Token: 0x04011ABF RID: 72383
		private FKuroCurveLinearColor _灯光颜色;

		// Token: 0x04011AC0 RID: 72384
		internal static int __PropertyOffset_9;

		// Token: 0x04011AC1 RID: 72385
		internal static int __PropertyOffset_10;

		// Token: 0x04011AC2 RID: 72386
		internal static int __PropertyOffset_11;

		// Token: 0x04011AC3 RID: 72387
		internal static int __PropertyOffset_12;

		// Token: 0x04011AC4 RID: 72388
		internal static int __PropertyOffset_13;

		// Token: 0x04011AC5 RID: 72389
		internal static int __PropertyOffset_14;

		// Token: 0x04011AC6 RID: 72390
		internal static int __PropertyOffset_15;

		// Token: 0x04011AC7 RID: 72391
		private FKuroCurveFloat _聚光灯摆动;

		// Token: 0x04011AC8 RID: 72392
		internal static int __PropertyOffset_16;

		// Token: 0x04011AC9 RID: 72393
		internal static int __PropertyOffset_17;

		// Token: 0x04011ACA RID: 72394
		internal static int __PropertyOffset_18;

		// Token: 0x04011ACB RID: 72395
		internal static int __PropertyOffset_19;

		// Token: 0x04011ACC RID: 72396
		internal static int __PropertyOffset_20;

		// Token: 0x04011ACD RID: 72397
		internal static int __PropertyOffset_21;

		// Token: 0x04011ACE RID: 72398
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011ACF RID: 72399
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011AD0 RID: 72400
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E99 RID: 40601
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403175F RID: 202591
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E9A RID: 40602
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031760 RID: 202592
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
