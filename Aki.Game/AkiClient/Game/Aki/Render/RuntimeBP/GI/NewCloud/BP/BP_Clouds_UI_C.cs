using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D5B RID: 15707
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds_UI.BP_Clouds_UI_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class BP_Clouds_UI_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026671 RID: 157297 RVA: 0x009741EB File Offset: 0x009723EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Clouds_UI_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds_UI.BP_Clouds_UI_C");
			}
			return BP_Clouds_UI_C._ClassPtr;
		}

		// Token: 0x06026672 RID: 157298 RVA: 0x00974210 File Offset: 0x00972410
		public BP_Clouds_UI_C() : this(BuiltinUtils.AllocNativeUObject(BP_Clouds_UI_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026673 RID: 157299 RVA: 0x00974238 File Offset: 0x00972438
		[NullableContext(1)]
		public BP_Clouds_UI_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Clouds_UI_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170051FE RID: 20990
		// (get) Token: 0x06026674 RID: 157300 RVA: 0x0097426B File Offset: 0x0097246B
		// (set) Token: 0x06026675 RID: 157301 RVA: 0x0097427F File Offset: 0x0097247F
		[Nullable(2)]
		public unsafe UChildActorComponent Cloud02
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_UI_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_UI_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170051FF RID: 20991
		// (get) Token: 0x06026676 RID: 157302 RVA: 0x00974294 File Offset: 0x00972494
		// (set) Token: 0x06026677 RID: 157303 RVA: 0x009742A8 File Offset: 0x009724A8
		[Nullable(2)]
		public unsafe UChildActorComponent Cloud01
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_UI_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_UI_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005200 RID: 20992
		// (get) Token: 0x06026678 RID: 157304 RVA: 0x009742BD File Offset: 0x009724BD
		// (set) Token: 0x06026679 RID: 157305 RVA: 0x009742D1 File Offset: 0x009724D1
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_UI_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_UI_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005201 RID: 20993
		// (get) Token: 0x0602667A RID: 157306 RVA: 0x009742E6 File Offset: 0x009724E6
		// (set) Token: 0x0602667B RID: 157307 RVA: 0x009742FA File Offset: 0x009724FA
		public unsafe TEnumAsByte<E_Cloud_Presents> 当前云预设_不要改_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005202 RID: 20994
		// (get) Token: 0x0602667C RID: 157308 RVA: 0x0097430F File Offset: 0x0097250F
		// (set) Token: 0x0602667D RID: 157309 RVA: 0x00974323 File Offset: 0x00972523
		[Nullable(2)]
		public unsafe PD_CloudPreset_C CloudData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CloudPreset_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_UI_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Clouds_UI_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17005203 RID: 20995
		// (get) Token: 0x0602667E RID: 157310 RVA: 0x00974338 File Offset: 0x00972538
		// (set) Token: 0x0602667F RID: 157311 RVA: 0x00974348 File Offset: 0x00972548
		public unsafe bool Counting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005204 RID: 20996
		// (get) Token: 0x06026680 RID: 157312 RVA: 0x00974359 File Offset: 0x00972559
		// (set) Token: 0x06026681 RID: 157313 RVA: 0x0097436D File Offset: 0x0097256D
		public unsafe TEnumAsByte<E_Cloud_Presents> 默认进入云预设
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005205 RID: 20997
		// (get) Token: 0x06026682 RID: 157314 RVA: 0x00974382 File Offset: 0x00972582
		// (set) Token: 0x06026683 RID: 157315 RVA: 0x00974397 File Offset: 0x00972597
		[Nullable(1)]
		public TSoftObjectPtr<PD_CloudPrefab_C> CloudAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<PD_CloudPrefab_C>(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_8, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_8, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005206 RID: 20998
		// (get) Token: 0x06026684 RID: 157316 RVA: 0x009743BC File Offset: 0x009725BC
		// (set) Token: 0x06026685 RID: 157317 RVA: 0x009743F5 File Offset: 0x009725F5
		[Nullable(1)]
		public TArray<int> SortNumber
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SortNumber) == null)
				{
					result = (this._SortNumber = new TArray<int>(base.NativePtr + (IntPtr)BP_Clouds_UI_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SortNumber.CopyAssign(value);
			}
		}

		// Token: 0x06026686 RID: 157318 RVA: 0x00974403 File Offset: 0x00972603
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 岁光()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__岁光_NativeFunctionPtr, null);
		}

		// Token: 0x06026687 RID: 157319 RVA: 0x00974417 File Offset: 0x00972617
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _012夜晚异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___012夜晚异象_NativeFunctionPtr, null);
		}

		// Token: 0x06026688 RID: 157320 RVA: 0x0097442B File Offset: 0x0097262B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _011黄昏异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___011黄昏异象_NativeFunctionPtr, null);
		}

		// Token: 0x06026689 RID: 157321 RVA: 0x0097443F File Offset: 0x0097263F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 北落野副本()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__北落野副本_NativeFunctionPtr, null);
		}

		// Token: 0x0602668A RID: 157322 RVA: 0x00974453 File Offset: 0x00972653
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _010阴天异象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___010阴天异象_NativeFunctionPtr, null);
		}

		// Token: 0x0602668B RID: 157323 RVA: 0x00974467 File Offset: 0x00972667
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _09鸣潮天气()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___09鸣潮天气_NativeFunctionPtr, null);
		}

		// Token: 0x0602668C RID: 157324 RVA: 0x0097447B File Offset: 0x0097267B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _08漩涡云01()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___08漩涡云01_NativeFunctionPtr, null);
		}

		// Token: 0x0602668D RID: 157325 RVA: 0x0097448F File Offset: 0x0097268F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _07无音区05()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___07无音区05_NativeFunctionPtr, null);
		}

		// Token: 0x0602668E RID: 157326 RVA: 0x009744A3 File Offset: 0x009726A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _06无音区04()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___06无音区04_NativeFunctionPtr, null);
		}

		// Token: 0x0602668F RID: 157327 RVA: 0x009744B7 File Offset: 0x009726B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _05无音区03()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___05无音区03_NativeFunctionPtr, null);
		}

		// Token: 0x06026690 RID: 157328 RVA: 0x009744CB File Offset: 0x009726CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _04无音区02()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___04无音区02_NativeFunctionPtr, null);
		}

		// Token: 0x06026691 RID: 157329 RVA: 0x009744DF File Offset: 0x009726DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 原画测试用云()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__原画测试用云_NativeFunctionPtr, null);
		}

		// Token: 0x06026692 RID: 157330 RVA: 0x009744F4 File Offset: 0x009726F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetCloudParameters(PD_CloudPrefab_C CloudPrefeb, UChildActorComponent CloudActorComponent, float ChangeSpeed, int TransSortNumber)
		{
			BP_Clouds_UI_C.__SetCloudParameters_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__SetCloudParameters_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_Clouds_UI_C.__SetCloudParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__SetCloudParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPrefeb = ((CloudPrefeb != null) ? CloudPrefeb.NativePtr : IntPtr.Zero);
			ptr->CloudActorComponent = ((CloudActorComponent != null) ? CloudActorComponent.NativePtr : IntPtr.Zero);
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->TransSortNumber = TransSortNumber;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__SetCloudParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026693 RID: 157331 RVA: 0x0097456E File Offset: 0x0097276E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _04中曲台地()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___04中曲台地_NativeFunctionPtr, null);
		}

		// Token: 0x06026694 RID: 157332 RVA: 0x00974582 File Offset: 0x00972782
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Hidden_Old()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__Hidden_Old_NativeFunctionPtr, null);
		}

		// Token: 0x06026695 RID: 157333 RVA: 0x00974598 File Offset: 0x00972798
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SwitchCloudsSub(PD_CloudPrefab_C CloudPresents, float ChangeSpeed)
		{
			BP_Clouds_UI_C.__SwitchCloudsSub_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__SwitchCloudsSub_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_Clouds_UI_C.__SwitchCloudsSub_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__SwitchCloudsSub_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPresents = ((CloudPresents != null) ? CloudPresents.NativePtr : IntPtr.Zero);
			ptr->ChangeSpeed = ChangeSpeed;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__SwitchCloudsSub_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026696 RID: 157334 RVA: 0x009745F4 File Offset: 0x009727F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _03无音区01()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___03无音区01_NativeFunctionPtr, null);
		}

		// Token: 0x06026697 RID: 157335 RVA: 0x00974608 File Offset: 0x00972808
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _02无音区沉寂态()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___02无音区沉寂态_NativeFunctionPtr, null);
		}

		// Token: 0x06026698 RID: 157336 RVA: 0x0097461C File Offset: 0x0097281C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _01登录界面()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___01登录界面_NativeFunctionPtr, null);
		}

		// Token: 0x06026699 RID: 157337 RVA: 0x00974630 File Offset: 0x00972830
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _03无光之森()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___03无光之森_NativeFunctionPtr, null);
		}

		// Token: 0x0602669A RID: 157338 RVA: 0x00974644 File Offset: 0x00972844
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _02遗落原乡()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___02遗落原乡_NativeFunctionPtr, null);
		}

		// Token: 0x0602669B RID: 157339 RVA: 0x00974658 File Offset: 0x00972858
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void _01天城()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.___01天城_NativeFunctionPtr, null);
		}

		// Token: 0x0602669C RID: 157340 RVA: 0x0097466C File Offset: 0x0097286C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602669D RID: 157341 RVA: 0x00974680 File Offset: 0x00972880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_UI_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602669E RID: 157342 RVA: 0x00974698 File Offset: 0x00972898
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnLoaded_D7528C144F64E8F8F9F429A67D0EE541(UObject Loaded)
		{
			BP_Clouds_UI_C.__OnLoaded_D7528C144F64E8F8F9F429A67D0EE541_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__OnLoaded_D7528C144F64E8F8F9F429A67D0EE541_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_Clouds_UI_C.__OnLoaded_D7528C144F64E8F8F9F429A67D0EE541_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__OnLoaded_D7528C144F64E8F8F9F429A67D0EE541_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Loaded = ((Loaded != null) ? Loaded.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__OnLoaded_D7528C144F64E8F8F9F429A67D0EE541_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602669F RID: 157343 RVA: 0x009746ED File Offset: 0x009728ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060266A0 RID: 157344 RVA: 0x00974701 File Offset: 0x00972901
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_UI_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266A1 RID: 157345 RVA: 0x00974718 File Offset: 0x00972918
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Clouds_UI_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_UI_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266A2 RID: 157346 RVA: 0x00974760 File Offset: 0x00972960
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Clouds_UI_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_UI_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_UI_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266A3 RID: 157347 RVA: 0x009747A8 File Offset: 0x009729A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Clouds_UI_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_UI_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266A4 RID: 157348 RVA: 0x009747F0 File Offset: 0x009729F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Clouds_UI_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Clouds_UI_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Clouds_UI_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060266A5 RID: 157349 RVA: 0x00974837 File Offset: 0x00972A37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ChangeCloud()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__ChangeCloud_NativeFunctionPtr, null);
		}

		// Token: 0x060266A6 RID: 157350 RVA: 0x0097484C File Offset: 0x00972A4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Switch_Clouds(E_Cloud_Presents CloudPresents, float ChangeSpeed, bool IsInEditor)
		{
			BP_Clouds_UI_C.__Switch_Clouds_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__Switch_Clouds_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_Clouds_UI_C.__Switch_Clouds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__Switch_Clouds_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CloudPresents = CloudPresents;
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->IsInEditor = IsInEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__Switch_Clouds_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060266A7 RID: 157351 RVA: 0x009748A8 File Offset: 0x00972AA8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LoadAndSwitch(TSoftObjectPtr<UObject> Asset, float ChangeSpeed, bool IsInEditor)
		{
			BP_Clouds_UI_C.__LoadAndSwitch_FunctionParams* ptr = stackalloc BP_Clouds_UI_C.__LoadAndSwitch_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_Clouds_UI_C.__LoadAndSwitch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Clouds_UI_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr, 1);
			if (Asset != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->Asset, Asset.NativePtr, 1);
			}
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->IsInEditor = IsInEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Clouds_UI_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_Clouds_UI_C.__LoadAndSwitch_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060266A8 RID: 157352 RVA: 0x00974922 File Offset: 0x00972B22
		protected BP_Clouds_UI_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013426 RID: 78886
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Clouds_UI.BP_Clouds_UI_C";

		// Token: 0x04013427 RID: 78887
		private static IntPtr _ClassPtr;

		// Token: 0x04013428 RID: 78888
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013429 RID: 78889
		internal static int __PropertyOffset_1;

		// Token: 0x0401342A RID: 78890
		internal static int __PropertyOffset_2;

		// Token: 0x0401342B RID: 78891
		internal static int __PropertyOffset_3;

		// Token: 0x0401342C RID: 78892
		internal static int __PropertyOffset_4;

		// Token: 0x0401342D RID: 78893
		internal static int __PropertyOffset_5;

		// Token: 0x0401342E RID: 78894
		internal static int __PropertyOffset_6;

		// Token: 0x0401342F RID: 78895
		internal static int __PropertyOffset_7;

		// Token: 0x04013430 RID: 78896
		internal static int __PropertyOffset_8;

		// Token: 0x04013431 RID: 78897
		internal static int __PropertyOffset_9;

		// Token: 0x04013432 RID: 78898
		[Nullable(2)]
		private TArray<int> _SortNumber;

		// Token: 0x04013433 RID: 78899
		private static IntPtr __岁光_NativeFunctionPtr;

		// Token: 0x04013434 RID: 78900
		private static IntPtr ___012夜晚异象_NativeFunctionPtr;

		// Token: 0x04013435 RID: 78901
		private static IntPtr ___011黄昏异象_NativeFunctionPtr;

		// Token: 0x04013436 RID: 78902
		private static IntPtr __北落野副本_NativeFunctionPtr;

		// Token: 0x04013437 RID: 78903
		private static IntPtr ___010阴天异象_NativeFunctionPtr;

		// Token: 0x04013438 RID: 78904
		private static IntPtr ___09鸣潮天气_NativeFunctionPtr;

		// Token: 0x04013439 RID: 78905
		private static IntPtr ___08漩涡云01_NativeFunctionPtr;

		// Token: 0x0401343A RID: 78906
		private static IntPtr ___07无音区05_NativeFunctionPtr;

		// Token: 0x0401343B RID: 78907
		private static IntPtr ___06无音区04_NativeFunctionPtr;

		// Token: 0x0401343C RID: 78908
		private static IntPtr ___05无音区03_NativeFunctionPtr;

		// Token: 0x0401343D RID: 78909
		private static IntPtr ___04无音区02_NativeFunctionPtr;

		// Token: 0x0401343E RID: 78910
		private static IntPtr __原画测试用云_NativeFunctionPtr;

		// Token: 0x0401343F RID: 78911
		private static IntPtr __SetCloudParameters_NativeFunctionPtr;

		// Token: 0x04013440 RID: 78912
		private static IntPtr ___04中曲台地_NativeFunctionPtr;

		// Token: 0x04013441 RID: 78913
		private static IntPtr __Hidden_Old_NativeFunctionPtr;

		// Token: 0x04013442 RID: 78914
		private static IntPtr __SwitchCloudsSub_NativeFunctionPtr;

		// Token: 0x04013443 RID: 78915
		private static IntPtr ___03无音区01_NativeFunctionPtr;

		// Token: 0x04013444 RID: 78916
		private static IntPtr ___02无音区沉寂态_NativeFunctionPtr;

		// Token: 0x04013445 RID: 78917
		private static IntPtr ___01登录界面_NativeFunctionPtr;

		// Token: 0x04013446 RID: 78918
		private static IntPtr ___03无光之森_NativeFunctionPtr;

		// Token: 0x04013447 RID: 78919
		private static IntPtr ___02遗落原乡_NativeFunctionPtr;

		// Token: 0x04013448 RID: 78920
		private static IntPtr ___01天城_NativeFunctionPtr;

		// Token: 0x04013449 RID: 78921
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401344A RID: 78922
		private static IntPtr __OnLoaded_D7528C144F64E8F8F9F429A67D0EE541_NativeFunctionPtr;

		// Token: 0x0401344B RID: 78923
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401344C RID: 78924
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401344D RID: 78925
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401344E RID: 78926
		private static IntPtr __ChangeCloud_NativeFunctionPtr;

		// Token: 0x0401344F RID: 78927
		private static IntPtr __Switch_Clouds_NativeFunctionPtr;

		// Token: 0x04013450 RID: 78928
		private static IntPtr __LoadAndSwitch_NativeFunctionPtr;

		// Token: 0x0200A106 RID: 41222
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetCloudParameters_FunctionParams
		{
			// Token: 0x04031C70 RID: 203888
			[FieldOffset(0)]
			public IntPtr CloudPrefeb;

			// Token: 0x04031C71 RID: 203889
			[FieldOffset(8)]
			public IntPtr CloudActorComponent;

			// Token: 0x04031C72 RID: 203890
			[FieldOffset(16)]
			public float ChangeSpeed;

			// Token: 0x04031C73 RID: 203891
			[FieldOffset(20)]
			public int TransSortNumber;
		}

		// Token: 0x0200A107 RID: 41223
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SwitchCloudsSub_FunctionParams
		{
			// Token: 0x04031C74 RID: 203892
			[FieldOffset(0)]
			public IntPtr CloudPresents;

			// Token: 0x04031C75 RID: 203893
			[FieldOffset(8)]
			public float ChangeSpeed;
		}

		// Token: 0x0200A108 RID: 41224
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnLoaded_D7528C144F64E8F8F9F429A67D0EE541_FunctionParams
		{
			// Token: 0x04031C76 RID: 203894
			[FieldOffset(0)]
			public IntPtr Loaded;
		}

		// Token: 0x0200A109 RID: 41225
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031C77 RID: 203895
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A10A RID: 41226
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031C78 RID: 203896
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A10B RID: 41227
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Switch_Clouds_FunctionParams
		{
			// Token: 0x04031C79 RID: 203897
			[FieldOffset(0)]
			public TEnumAsByte<E_Cloud_Presents> CloudPresents;

			// Token: 0x04031C7A RID: 203898
			[FieldOffset(4)]
			public float ChangeSpeed;

			// Token: 0x04031C7B RID: 203899
			[FieldOffset(8)]
			public bool IsInEditor;
		}

		// Token: 0x0200A10C RID: 41228
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __LoadAndSwitch_FunctionParams
		{
			// Token: 0x04031C7C RID: 203900
			[FieldOffset(0)]
			public byte Asset;

			// Token: 0x04031C7D RID: 203901
			[FieldOffset(48)]
			public float ChangeSpeed;

			// Token: 0x04031C7E RID: 203902
			[FieldOffset(52)]
			public bool IsInEditor;
		}
	}
}
