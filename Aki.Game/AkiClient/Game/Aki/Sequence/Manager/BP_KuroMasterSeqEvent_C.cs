using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Sequence.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A28 RID: 14888
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class BP_KuroMasterSeqEvent_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F51B RID: 128283 RVA: 0x008B4F42 File Offset: 0x008B3142
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroMasterSeqEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C");
			}
			return BP_KuroMasterSeqEvent_C._ClassPtr;
		}

		// Token: 0x0601F51C RID: 128284 RVA: 0x008B4F68 File Offset: 0x008B3168
		public BP_KuroMasterSeqEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroMasterSeqEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F51D RID: 128285 RVA: 0x008B4F90 File Offset: 0x008B3190
		[NullableContext(1)]
		public BP_KuroMasterSeqEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroMasterSeqEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x0601F51E RID: 128286 RVA: 0x008B4FC3 File Offset: 0x008B31C3
		// (set) Token: 0x0601F51F RID: 128287 RVA: 0x008B4FD7 File Offset: 0x008B31D7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMasterSeqEvent_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMasterSeqEvent_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0601F520 RID: 128288 RVA: 0x008B4FEC File Offset: 0x008B31EC
		// (set) Token: 0x0601F521 RID: 128289 RVA: 0x008B4FFC File Offset: 0x008B31FC
		public unsafe bool ModifiedNearClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0601F522 RID: 128290 RVA: 0x008B5010 File Offset: 0x008B3210
		// (set) Token: 0x0601F523 RID: 128291 RVA: 0x008B5049 File Offset: 0x008B3249
		[Nullable(1)]
		public OnScreenShotFade OnScreenShotFade
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				OnScreenShotFade result;
				if ((result = this._OnScreenShotFade) == null)
				{
					result = (this._OnScreenShotFade = new OnScreenShotFade(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_3, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x0601F524 RID: 128292 RVA: 0x008B506A File Offset: 0x008B326A
		// (set) Token: 0x0601F525 RID: 128293 RVA: 0x008B507A File Offset: 0x008B327A
		public unsafe int DelayMerge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x0601F526 RID: 128294 RVA: 0x008B508B File Offset: 0x008B328B
		// (set) Token: 0x0601F527 RID: 128295 RVA: 0x008B509B File Offset: 0x008B329B
		public unsafe float Icon透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x0601F528 RID: 128296 RVA: 0x008B50AC File Offset: 0x008B32AC
		// (set) Token: 0x0601F529 RID: 128297 RVA: 0x008B50BC File Offset: 0x008B32BC
		public unsafe float Icon遮罩透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x0601F52A RID: 128298 RVA: 0x008B50CD File Offset: 0x008B32CD
		// (set) Token: 0x0601F52B RID: 128299 RVA: 0x008B50DD File Offset: 0x008B32DD
		public unsafe int counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0601F52C RID: 128300 RVA: 0x008B50F0 File Offset: 0x008B32F0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 相机振动(bool 启用, TSoftClassPtr<UMatineeCameraShake> 资产)
		{
			BP_KuroMasterSeqEvent_C.__相机振动_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__相机振动_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__相机振动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__相机振动_NativeFunctionPtr, (void*)ptr, 1);
			ptr->启用 = 启用;
			if (资产 != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->资产, 资产.NativePtr, 1);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__相机振动_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__相机振动_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F52D RID: 128301 RVA: 0x008B5164 File Offset: 0x008B3364
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 打开报幕界面(string uiPrefabId, float duration, string uiStartAnimName, string uiEndAnimName)
		{
			BP_KuroMasterSeqEvent_C.__打开报幕界面_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__打开报幕界面_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__打开报幕界面_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__打开报幕界面_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->uiPrefabId), uiPrefabId);
			ptr->duration = duration;
			FString.CopyFrom((void*)(&ptr->uiStartAnimName), uiStartAnimName);
			FString.CopyFrom((void*)(&ptr->uiEndAnimName), uiEndAnimName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__打开报幕界面_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__打开报幕界面_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F52E RID: 128302 RVA: 0x008B51E4 File Offset: 0x008B33E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 启用剧情交互按钮(bool bEnable)
		{
			BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F52F RID: 128303 RVA: 0x008B522C File Offset: 0x008B342C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 绑定物品检视Actor(FMovieSceneObjectBindingID binding)
		{
			BP_KuroMasterSeqEvent_C.__绑定物品检视Actor_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__绑定物品检视Actor_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__绑定物品检视Actor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__绑定物品检视Actor_NativeFunctionPtr, (void*)ptr, 1);
			if (binding != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), &ptr->binding, binding.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__绑定物品检视Actor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F530 RID: 128304 RVA: 0x008B528D File Offset: 0x008B348D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 额外Seq停止()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__额外Seq停止_NativeFunctionPtr, null);
		}

		// Token: 0x0601F531 RID: 128305 RVA: 0x008B52A4 File Offset: 0x008B34A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 额外Seq播放(ULevelSequence Seq, FName componentName, FName boneName, float frame)
		{
			BP_KuroMasterSeqEvent_C.__额外Seq播放_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__额外Seq播放_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__额外Seq播放_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__额外Seq播放_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Seq = ((Seq != null) ? Seq.NativePtr : IntPtr.Zero);
			ptr->componentName = componentName;
			ptr->boneName = boneName;
			ptr->frame = frame;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__额外Seq播放_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F532 RID: 128306 RVA: 0x008B5310 File Offset: 0x008B3510
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 背景Icon(bool 显示, UTexture2D Icon)
		{
			BP_KuroMasterSeqEvent_C.__背景Icon_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__背景Icon_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__背景Icon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__背景Icon_NativeFunctionPtr, (void*)ptr, 1);
			ptr->显示 = 显示;
			ptr->Icon = ((Icon != null) ? Icon.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__背景Icon_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F533 RID: 128307 RVA: 0x008B536C File Offset: 0x008B356C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 关闭Spine动画_数组_([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> spineArray)
		{
			BP_KuroMasterSeqEvent_C.__关闭Spine动画_数组__FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__关闭Spine动画_数组__FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__关闭Spine动画_数组__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__关闭Spine动画_数组__NativeFunctionPtr, (void*)ptr, 1);
			TArray<string> tarray = spineArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->spineArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__关闭Spine动画_数组__NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = spineArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->spineArray);
			}
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__关闭Spine动画_数组__NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F534 RID: 128308 RVA: 0x008B53E4 File Offset: 0x008B35E4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 关闭Spine动画(string spineName)
		{
			BP_KuroMasterSeqEvent_C.__关闭Spine动画_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__关闭Spine动画_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__关闭Spine动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__关闭Spine动画_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->spineName), spineName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__关闭Spine动画_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__关闭Spine动画_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F535 RID: 128309 RVA: 0x008B5444 File Offset: 0x008B3644
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 播放Spine动画_数组_([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SpineThingsInfo> maleSpineArray, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SpineThingsInfo> femaleSpineArray)
		{
			BP_KuroMasterSeqEvent_C.__播放Spine动画_数组__FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__播放Spine动画_数组__FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__播放Spine动画_数组__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__播放Spine动画_数组__NativeFunctionPtr, (void*)ptr, 1);
			TArray<SpineThingsInfo> tarray = maleSpineArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->maleSpineArray);
			}
			TArray<SpineThingsInfo> tarray2 = femaleSpineArray;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->femaleSpineArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__播放Spine动画_数组__NativeFunctionPtr, (void*)ptr);
			TArray<SpineThingsInfo> tarray3 = maleSpineArray;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->maleSpineArray);
			}
			TArray<SpineThingsInfo> tarray4 = femaleSpineArray;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->femaleSpineArray);
			}
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__播放Spine动画_数组__NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F536 RID: 128310 RVA: 0x008B54E4 File Offset: 0x008B36E4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 播放Spine动画_性别_(string maleSpineName1, string femaleSpineName1, bool needLoop)
		{
			BP_KuroMasterSeqEvent_C.__播放Spine动画_性别__FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__播放Spine动画_性别__FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__播放Spine动画_性别__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__播放Spine动画_性别__NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->maleSpineName1), maleSpineName1);
			FString.CopyFrom((void*)(&ptr->femaleSpineName1), femaleSpineName1);
			ptr->needLoop = needLoop;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__播放Spine动画_性别__NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__播放Spine动画_性别__NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F537 RID: 128311 RVA: 0x008B5558 File Offset: 0x008B3758
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 播放Spine动画(string SpineName, bool needLoop)
		{
			BP_KuroMasterSeqEvent_C.__播放Spine动画_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__播放Spine动画_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__播放Spine动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__播放Spine动画_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SpineName), SpineName);
			ptr->needLoop = needLoop;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__播放Spine动画_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__播放Spine动画_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F538 RID: 128312 RVA: 0x008B55BC File Offset: 0x008B37BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 执行实体帧事件(string Key, int EntityId)
		{
			BP_KuroMasterSeqEvent_C.__执行实体帧事件_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__执行实体帧事件_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__执行实体帧事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__执行实体帧事件_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__执行实体帧事件_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__执行实体帧事件_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F539 RID: 128313 RVA: 0x008B5620 File Offset: 0x008B3820
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 播放预览图动画(string seqName)
		{
			BP_KuroMasterSeqEvent_C.__播放预览图动画_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__播放预览图动画_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__播放预览图动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__播放预览图动画_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->seqName), seqName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__播放预览图动画_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__播放预览图动画_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F53A RID: 128314 RVA: 0x008B567D File Offset: 0x008B387D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 关闭预览图()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__关闭预览图_NativeFunctionPtr, null);
		}

		// Token: 0x0601F53B RID: 128315 RVA: 0x008B5694 File Offset: 0x008B3894
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 显示预览图_数组_(string MaleAssetPath, string FemaleAssetPath, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SpineThingsInfo> maleSpineArray, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SpineThingsInfo> femaleSpineArray, bool useFullscreenAdaptAnchor)
		{
			BP_KuroMasterSeqEvent_C.__显示预览图_数组__FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__显示预览图_数组__FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__显示预览图_数组__FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__显示预览图_数组__NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MaleAssetPath), MaleAssetPath);
			FString.CopyFrom((void*)(&ptr->FemaleAssetPath), FemaleAssetPath);
			TArray<SpineThingsInfo> tarray = maleSpineArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->maleSpineArray);
			}
			TArray<SpineThingsInfo> tarray2 = femaleSpineArray;
			if (tarray2 != null)
			{
				tarray2.MoveTo(&ptr->femaleSpineArray);
			}
			ptr->useFullscreenAdaptAnchor = useFullscreenAdaptAnchor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__显示预览图_数组__NativeFunctionPtr, (void*)ptr);
			TArray<SpineThingsInfo> tarray3 = maleSpineArray;
			if (tarray3 != null)
			{
				tarray3.MoveAssign(&ptr->maleSpineArray);
			}
			TArray<SpineThingsInfo> tarray4 = femaleSpineArray;
			if (tarray4 != null)
			{
				tarray4.MoveAssign(&ptr->femaleSpineArray);
			}
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__显示预览图_数组__NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F53C RID: 128316 RVA: 0x008B5758 File Offset: 0x008B3958
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 显示预览图(string MaleAssetPath, string FemaleAssetPath, string maleSpineName, string femaleSpineName, bool needLoop, bool useFullscreenAdaptAnchor)
		{
			BP_KuroMasterSeqEvent_C.__显示预览图_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__显示预览图_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__显示预览图_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__显示预览图_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MaleAssetPath), MaleAssetPath);
			FString.CopyFrom((void*)(&ptr->FemaleAssetPath), FemaleAssetPath);
			FString.CopyFrom((void*)(&ptr->maleSpineName), maleSpineName);
			FString.CopyFrom((void*)(&ptr->femaleSpineName), femaleSpineName);
			ptr->needLoop = needLoop;
			ptr->useFullscreenAdaptAnchor = useFullscreenAdaptAnchor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__显示预览图_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__显示预览图_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F53D RID: 128317 RVA: 0x008B57F0 File Offset: 0x008B39F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 展示游戏Logo(float time)
		{
			BP_KuroMasterSeqEvent_C.__展示游戏Logo_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__展示游戏Logo_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__展示游戏Logo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__展示游戏Logo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__展示游戏Logo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F53E RID: 128318 RVA: 0x008B5838 File Offset: 0x008B3A38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 打开章节提示(int ChapterState, int ChapterId)
		{
			BP_KuroMasterSeqEvent_C.__打开章节提示_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__打开章节提示_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__打开章节提示_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__打开章节提示_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ChapterState = ChapterState;
			ptr->ChapterId = ChapterId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__打开章节提示_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F53F RID: 128319 RVA: 0x008B5885 File Offset: 0x008B3A85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 触发切镜()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__触发切镜_NativeFunctionPtr, null);
		}

		// Token: 0x0601F540 RID: 128320 RVA: 0x008B5899 File Offset: 0x008B3A99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 开始叠化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__开始叠化_NativeFunctionPtr, null);
		}

		// Token: 0x0601F541 RID: 128321 RVA: 0x008B58B0 File Offset: 0x008B3AB0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 执行流程行为(string key)
		{
			BP_KuroMasterSeqEvent_C.__执行流程行为_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__执行流程行为_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__执行流程行为_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__执行流程行为_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__执行流程行为_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__执行流程行为_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F542 RID: 128322 RVA: 0x008B5910 File Offset: 0x008B3B10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 开关人物飘带(bool enable)
		{
			BP_KuroMasterSeqEvent_C.__开关人物飘带_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__开关人物飘带_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__开关人物飘带_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__开关人物飘带_NativeFunctionPtr, (void*)ptr, 1);
			ptr->enable = enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__开关人物飘带_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F543 RID: 128323 RVA: 0x008B5956 File Offset: 0x008B3B56
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 恢复镜头裁剪距离()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__恢复镜头裁剪距离_NativeFunctionPtr, null);
		}

		// Token: 0x0601F544 RID: 128324 RVA: 0x008B596C File Offset: 0x008B3B6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 调整镜头裁剪距离(int NearClip)
		{
			BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NearClip = NearClip;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F545 RID: 128325 RVA: 0x008B59B2 File Offset: 0x008B3BB2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 副触发切镜()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__副触发切镜_NativeFunctionPtr, null);
		}

		// Token: 0x0601F546 RID: 128326 RVA: 0x008B59C8 File Offset: 0x008B3BC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 主触发切镜(bool shouldBlend, float blendTime, EViewTargetBlendFunction blendFunction, float blendExp)
		{
			BP_KuroMasterSeqEvent_C.__主触发切镜_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__主触发切镜_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__主触发切镜_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__主触发切镜_NativeFunctionPtr, (void*)ptr, 1);
			ptr->shouldBlend = shouldBlend;
			ptr->blendTime = blendTime;
			ptr->blendFunction = blendFunction;
			ptr->blendExp = blendExp;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__主触发切镜_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F547 RID: 128327 RVA: 0x008B5A29 File Offset: 0x008B3C29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 启用动态模糊()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__启用动态模糊_NativeFunctionPtr, null);
		}

		// Token: 0x0601F548 RID: 128328 RVA: 0x008B5A3D File Offset: 0x008B3C3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 禁用动态模糊()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__禁用动态模糊_NativeFunctionPtr, null);
		}

		// Token: 0x0601F549 RID: 128329 RVA: 0x008B5A54 File Offset: 0x008B3C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F54A RID: 128330 RVA: 0x008B5A9C File Offset: 0x008B3C9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F54B RID: 128331 RVA: 0x008B5AE3 File Offset: 0x008B3CE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601F54C RID: 128332 RVA: 0x008B5AF7 File Offset: 0x008B3CF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F54D RID: 128333 RVA: 0x008B5B0C File Offset: 0x008B3D0C
		protected BP_KuroMasterSeqEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F06B RID: 61547
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C";

		// Token: 0x0400F06C RID: 61548
		private static IntPtr _ClassPtr;

		// Token: 0x0400F06D RID: 61549
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F06E RID: 61550
		public static IntPtr __OnScreenShotFade__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F06F RID: 61551
		internal static int __PropertyOffset_1;

		// Token: 0x0400F070 RID: 61552
		internal static int __PropertyOffset_2;

		// Token: 0x0400F071 RID: 61553
		internal static int __PropertyOffset_3;

		// Token: 0x0400F072 RID: 61554
		[Nullable(2)]
		private OnScreenShotFade _OnScreenShotFade;

		// Token: 0x0400F073 RID: 61555
		internal static int __PropertyOffset_4;

		// Token: 0x0400F074 RID: 61556
		internal static int __PropertyOffset_5;

		// Token: 0x0400F075 RID: 61557
		internal static int __PropertyOffset_6;

		// Token: 0x0400F076 RID: 61558
		internal static int __PropertyOffset_7;

		// Token: 0x0400F077 RID: 61559
		private static IntPtr __相机振动_NativeFunctionPtr;

		// Token: 0x0400F078 RID: 61560
		private static IntPtr __打开报幕界面_NativeFunctionPtr;

		// Token: 0x0400F079 RID: 61561
		private static IntPtr __启用剧情交互按钮_NativeFunctionPtr;

		// Token: 0x0400F07A RID: 61562
		private static IntPtr __绑定物品检视Actor_NativeFunctionPtr;

		// Token: 0x0400F07B RID: 61563
		private static IntPtr __额外Seq停止_NativeFunctionPtr;

		// Token: 0x0400F07C RID: 61564
		private static IntPtr __额外Seq播放_NativeFunctionPtr;

		// Token: 0x0400F07D RID: 61565
		private static IntPtr __背景Icon_NativeFunctionPtr;

		// Token: 0x0400F07E RID: 61566
		private static IntPtr __关闭Spine动画_数组__NativeFunctionPtr;

		// Token: 0x0400F07F RID: 61567
		private static IntPtr __关闭Spine动画_NativeFunctionPtr;

		// Token: 0x0400F080 RID: 61568
		private static IntPtr __播放Spine动画_数组__NativeFunctionPtr;

		// Token: 0x0400F081 RID: 61569
		private static IntPtr __播放Spine动画_性别__NativeFunctionPtr;

		// Token: 0x0400F082 RID: 61570
		private static IntPtr __播放Spine动画_NativeFunctionPtr;

		// Token: 0x0400F083 RID: 61571
		private static IntPtr __执行实体帧事件_NativeFunctionPtr;

		// Token: 0x0400F084 RID: 61572
		private static IntPtr __播放预览图动画_NativeFunctionPtr;

		// Token: 0x0400F085 RID: 61573
		private static IntPtr __关闭预览图_NativeFunctionPtr;

		// Token: 0x0400F086 RID: 61574
		private static IntPtr __显示预览图_数组__NativeFunctionPtr;

		// Token: 0x0400F087 RID: 61575
		private static IntPtr __显示预览图_NativeFunctionPtr;

		// Token: 0x0400F088 RID: 61576
		private static IntPtr __展示游戏Logo_NativeFunctionPtr;

		// Token: 0x0400F089 RID: 61577
		private static IntPtr __打开章节提示_NativeFunctionPtr;

		// Token: 0x0400F08A RID: 61578
		private static IntPtr __触发切镜_NativeFunctionPtr;

		// Token: 0x0400F08B RID: 61579
		private static IntPtr __开始叠化_NativeFunctionPtr;

		// Token: 0x0400F08C RID: 61580
		private static IntPtr __执行流程行为_NativeFunctionPtr;

		// Token: 0x0400F08D RID: 61581
		private static IntPtr __开关人物飘带_NativeFunctionPtr;

		// Token: 0x0400F08E RID: 61582
		private static IntPtr __恢复镜头裁剪距离_NativeFunctionPtr;

		// Token: 0x0400F08F RID: 61583
		private static IntPtr __调整镜头裁剪距离_NativeFunctionPtr;

		// Token: 0x0400F090 RID: 61584
		private static IntPtr __副触发切镜_NativeFunctionPtr;

		// Token: 0x0400F091 RID: 61585
		private static IntPtr __主触发切镜_NativeFunctionPtr;

		// Token: 0x0400F092 RID: 61586
		private static IntPtr __启用动态模糊_NativeFunctionPtr;

		// Token: 0x0400F093 RID: 61587
		private static IntPtr __禁用动态模糊_NativeFunctionPtr;

		// Token: 0x0400F094 RID: 61588
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F095 RID: 61589
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02009AB9 RID: 39609
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __相机振动_FunctionParams
		{
			// Token: 0x04031045 RID: 200773
			[FieldOffset(0)]
			public bool 启用;

			// Token: 0x04031046 RID: 200774
			[FieldOffset(8)]
			public byte 资产;
		}

		// Token: 0x02009ABA RID: 39610
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __打开报幕界面_FunctionParams
		{
			// Token: 0x04031047 RID: 200775
			[FieldOffset(0)]
			public FString uiPrefabId;

			// Token: 0x04031048 RID: 200776
			[FieldOffset(16)]
			public float duration;

			// Token: 0x04031049 RID: 200777
			[FieldOffset(24)]
			public FString uiStartAnimName;

			// Token: 0x0403104A RID: 200778
			[FieldOffset(40)]
			public FString uiEndAnimName;
		}

		// Token: 0x02009ABB RID: 39611
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __启用剧情交互按钮_FunctionParams
		{
			// Token: 0x0403104B RID: 200779
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02009ABC RID: 39612
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __绑定物品检视Actor_FunctionParams
		{
			// Token: 0x0403104C RID: 200780
			[FieldOffset(0)]
			public byte binding;
		}

		// Token: 0x02009ABD RID: 39613
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __额外Seq播放_FunctionParams
		{
			// Token: 0x0403104D RID: 200781
			[FieldOffset(0)]
			public IntPtr Seq;

			// Token: 0x0403104E RID: 200782
			[FieldOffset(8)]
			public FName componentName;

			// Token: 0x0403104F RID: 200783
			[FieldOffset(20)]
			public FName boneName;

			// Token: 0x04031050 RID: 200784
			[FieldOffset(32)]
			public float frame;
		}

		// Token: 0x02009ABE RID: 39614
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __背景Icon_FunctionParams
		{
			// Token: 0x04031051 RID: 200785
			[FieldOffset(0)]
			public bool 显示;

			// Token: 0x04031052 RID: 200786
			[FieldOffset(8)]
			public IntPtr Icon;
		}

		// Token: 0x02009ABF RID: 39615
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __关闭Spine动画_数组__FunctionParams
		{
			// Token: 0x04031053 RID: 200787
			[FieldOffset(0)]
			public byte spineArray;
		}

		// Token: 0x02009AC0 RID: 39616
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __关闭Spine动画_FunctionParams
		{
			// Token: 0x04031054 RID: 200788
			[FieldOffset(0)]
			public FString spineName;
		}

		// Token: 0x02009AC1 RID: 39617
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __播放Spine动画_数组__FunctionParams
		{
			// Token: 0x04031055 RID: 200789
			[FieldOffset(0)]
			public byte maleSpineArray;

			// Token: 0x04031056 RID: 200790
			[FieldOffset(16)]
			public byte femaleSpineArray;
		}

		// Token: 0x02009AC2 RID: 39618
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __播放Spine动画_性别__FunctionParams
		{
			// Token: 0x04031057 RID: 200791
			[FieldOffset(0)]
			public FString maleSpineName1;

			// Token: 0x04031058 RID: 200792
			[FieldOffset(16)]
			public FString femaleSpineName1;

			// Token: 0x04031059 RID: 200793
			[FieldOffset(32)]
			public bool needLoop;
		}

		// Token: 0x02009AC3 RID: 39619
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __播放Spine动画_FunctionParams
		{
			// Token: 0x0403105A RID: 200794
			[FieldOffset(0)]
			public FString SpineName;

			// Token: 0x0403105B RID: 200795
			[FieldOffset(16)]
			public bool needLoop;
		}

		// Token: 0x02009AC4 RID: 39620
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __执行实体帧事件_FunctionParams
		{
			// Token: 0x0403105C RID: 200796
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x0403105D RID: 200797
			[FieldOffset(16)]
			public int EntityId;
		}

		// Token: 0x02009AC5 RID: 39621
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __播放预览图动画_FunctionParams
		{
			// Token: 0x0403105E RID: 200798
			[FieldOffset(0)]
			public FString seqName;
		}

		// Token: 0x02009AC6 RID: 39622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __显示预览图_数组__FunctionParams
		{
			// Token: 0x0403105F RID: 200799
			[FieldOffset(0)]
			public FString MaleAssetPath;

			// Token: 0x04031060 RID: 200800
			[FieldOffset(16)]
			public FString FemaleAssetPath;

			// Token: 0x04031061 RID: 200801
			[FieldOffset(32)]
			public byte maleSpineArray;

			// Token: 0x04031062 RID: 200802
			[FieldOffset(48)]
			public byte femaleSpineArray;

			// Token: 0x04031063 RID: 200803
			[FieldOffset(64)]
			public bool useFullscreenAdaptAnchor;
		}

		// Token: 0x02009AC7 RID: 39623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __显示预览图_FunctionParams
		{
			// Token: 0x04031064 RID: 200804
			[FieldOffset(0)]
			public FString MaleAssetPath;

			// Token: 0x04031065 RID: 200805
			[FieldOffset(16)]
			public FString FemaleAssetPath;

			// Token: 0x04031066 RID: 200806
			[FieldOffset(32)]
			public FString maleSpineName;

			// Token: 0x04031067 RID: 200807
			[FieldOffset(48)]
			public FString femaleSpineName;

			// Token: 0x04031068 RID: 200808
			[FieldOffset(64)]
			public bool needLoop;

			// Token: 0x04031069 RID: 200809
			[FieldOffset(65)]
			public bool useFullscreenAdaptAnchor;
		}

		// Token: 0x02009AC8 RID: 39624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __展示游戏Logo_FunctionParams
		{
			// Token: 0x0403106A RID: 200810
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009AC9 RID: 39625
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __打开章节提示_FunctionParams
		{
			// Token: 0x0403106B RID: 200811
			[FieldOffset(0)]
			public int ChapterState;

			// Token: 0x0403106C RID: 200812
			[FieldOffset(4)]
			public int ChapterId;
		}

		// Token: 0x02009ACA RID: 39626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __执行流程行为_FunctionParams
		{
			// Token: 0x0403106D RID: 200813
			[FieldOffset(0)]
			public FString key;
		}

		// Token: 0x02009ACB RID: 39627
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __开关人物飘带_FunctionParams
		{
			// Token: 0x0403106E RID: 200814
			[FieldOffset(0)]
			public bool enable;
		}

		// Token: 0x02009ACC RID: 39628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __调整镜头裁剪距离_FunctionParams
		{
			// Token: 0x0403106F RID: 200815
			[FieldOffset(0)]
			public int NearClip;
		}

		// Token: 0x02009ACD RID: 39629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __主触发切镜_FunctionParams
		{
			// Token: 0x04031070 RID: 200816
			[FieldOffset(0)]
			public bool shouldBlend;

			// Token: 0x04031071 RID: 200817
			[FieldOffset(4)]
			public float blendTime;

			// Token: 0x04031072 RID: 200818
			[FieldOffset(8)]
			public TEnumAsByte<EViewTargetBlendFunction> blendFunction;

			// Token: 0x04031073 RID: 200819
			[FieldOffset(12)]
			public float blendExp;
		}

		// Token: 0x02009ACE RID: 39630
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031074 RID: 200820
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
