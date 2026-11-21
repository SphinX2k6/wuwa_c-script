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
	// Token: 0x02003071 RID: 12401
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class BP_KuroMasterSeqEvent_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D89D RID: 120989 RVA: 0x008FA6AB File Offset: 0x008F88AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroMasterSeqEvent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C");
			}
			return BP_KuroMasterSeqEvent_C._ClassPtr;
		}

		// Token: 0x0601D89E RID: 120990 RVA: 0x008FA6D0 File Offset: 0x008F88D0
		public BP_KuroMasterSeqEvent_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroMasterSeqEvent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D89F RID: 120991 RVA: 0x008FA6F8 File Offset: 0x008F88F8
		[NullableContext(1)]
		public BP_KuroMasterSeqEvent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroMasterSeqEvent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x0601D8A0 RID: 120992 RVA: 0x008FA72B File Offset: 0x008F892B
		// (set) Token: 0x0601D8A1 RID: 120993 RVA: 0x008FA73F File Offset: 0x008F893F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMasterSeqEvent_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroMasterSeqEvent_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x0601D8A2 RID: 120994 RVA: 0x008FA754 File Offset: 0x008F8954
		// (set) Token: 0x0601D8A3 RID: 120995 RVA: 0x008FA764 File Offset: 0x008F8964
		public unsafe bool ModifiedNearClipPlane
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_ModifiedNearClipPlane) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_ModifiedNearClipPlane) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x0601D8A4 RID: 120996 RVA: 0x008FA778 File Offset: 0x008F8978
		// (set) Token: 0x0601D8A5 RID: 120997 RVA: 0x008FA7B1 File Offset: 0x008F89B1
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
					result = (this._OnScreenShotFade = new OnScreenShotFade(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_OnScreenShotFade, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_OnScreenShotFade, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x0601D8A6 RID: 120998 RVA: 0x008FA7D2 File Offset: 0x008F89D2
		// (set) Token: 0x0601D8A7 RID: 120999 RVA: 0x008FA7E2 File Offset: 0x008F89E2
		public unsafe int DelayMerge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_DelayMerge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_DelayMerge) = value;
			}
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x0601D8A8 RID: 121000 RVA: 0x008FA7F3 File Offset: 0x008F89F3
		// (set) Token: 0x0601D8A9 RID: 121001 RVA: 0x008FA803 File Offset: 0x008F8A03
		public unsafe float Icon透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_Icon透明度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_Icon透明度) = value;
			}
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x0601D8AA RID: 121002 RVA: 0x008FA814 File Offset: 0x008F8A14
		// (set) Token: 0x0601D8AB RID: 121003 RVA: 0x008FA824 File Offset: 0x008F8A24
		public unsafe float Icon遮罩透明度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_Icon遮罩透明度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_Icon遮罩透明度) = value;
			}
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x0601D8AC RID: 121004 RVA: 0x008FA835 File Offset: 0x008F8A35
		// (set) Token: 0x0601D8AD RID: 121005 RVA: 0x008FA845 File Offset: 0x008F8A45
		public unsafe int counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_counter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroMasterSeqEvent_C.__PropertyOffset_counter) = value;
			}
		}

		// Token: 0x0601D8AE RID: 121006 RVA: 0x008FA856 File Offset: 0x008F8A56
		[SkipLocalsInit]
		public virtual void Seq结束()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__Seq结束_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8AF RID: 121007 RVA: 0x008FA86A File Offset: 0x008F8A6A
		[SkipLocalsInit]
		public virtual void 显示按键()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__显示按键_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8B0 RID: 121008 RVA: 0x008FA880 File Offset: 0x008F8A80
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D8B1 RID: 121009 RVA: 0x008FA8F4 File Offset: 0x008F8AF4
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D8B2 RID: 121010 RVA: 0x008FA974 File Offset: 0x008F8B74
		[SkipLocalsInit]
		public unsafe virtual void 启用剧情交互按钮(bool bEnable)
		{
			BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__启用剧情交互按钮_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D8B3 RID: 121011 RVA: 0x008FA9BC File Offset: 0x008F8BBC
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D8B4 RID: 121012 RVA: 0x008FAA1D File Offset: 0x008F8C1D
		[SkipLocalsInit]
		public virtual void 额外Seq停止()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__额外Seq停止_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8B5 RID: 121013 RVA: 0x008FAA34 File Offset: 0x008F8C34
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D8B6 RID: 121014 RVA: 0x008FAAA0 File Offset: 0x008F8CA0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 背景Icon(bool 显示, UTexture2D Icon)
		{
			BP_KuroMasterSeqEvent_C.__背景Icon_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__背景Icon_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__背景Icon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__背景Icon_NativeFunctionPtr, (void*)ptr, 1);
			ptr->显示 = 显示;
			ptr->Icon = ((Icon != null) ? Icon.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__背景Icon_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D8B7 RID: 121015 RVA: 0x008FAAFC File Offset: 0x008F8CFC
		[SkipLocalsInit]
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

		// Token: 0x0601D8B8 RID: 121016 RVA: 0x008FAB74 File Offset: 0x008F8D74
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 关闭Spine动画(string spineName)
		{
			BP_KuroMasterSeqEvent_C.__关闭Spine动画_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__关闭Spine动画_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__关闭Spine动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__关闭Spine动画_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->spineName), spineName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__关闭Spine动画_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__关闭Spine动画_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D8B9 RID: 121017 RVA: 0x008FABD4 File Offset: 0x008F8DD4
		[SkipLocalsInit]
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

		// Token: 0x0601D8BA RID: 121018 RVA: 0x008FAC74 File Offset: 0x008F8E74
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D8BB RID: 121019 RVA: 0x008FACE8 File Offset: 0x008F8EE8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 播放Spine动画(string SpineName, bool needLoop)
		{
			BP_KuroMasterSeqEvent_C.__播放Spine动画_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__播放Spine动画_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__播放Spine动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__播放Spine动画_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SpineName), SpineName);
			ptr->needLoop = needLoop;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__播放Spine动画_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__播放Spine动画_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D8BC RID: 121020 RVA: 0x008FAD4C File Offset: 0x008F8F4C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 执行实体帧事件(string Key, int EntityId)
		{
			BP_KuroMasterSeqEvent_C.__执行实体帧事件_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__执行实体帧事件_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__执行实体帧事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__执行实体帧事件_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__执行实体帧事件_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__执行实体帧事件_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D8BD RID: 121021 RVA: 0x008FADB0 File Offset: 0x008F8FB0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 播放预览图动画(string seqName)
		{
			BP_KuroMasterSeqEvent_C.__播放预览图动画_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__播放预览图动画_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__播放预览图动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__播放预览图动画_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->seqName), seqName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__播放预览图动画_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__播放预览图动画_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D8BE RID: 121022 RVA: 0x008FAE0D File Offset: 0x008F900D
		[SkipLocalsInit]
		public virtual void 关闭预览图()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__关闭预览图_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8BF RID: 121023 RVA: 0x008FAE24 File Offset: 0x008F9024
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D8C0 RID: 121024 RVA: 0x008FAEE8 File Offset: 0x008F90E8
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D8C1 RID: 121025 RVA: 0x008FAF80 File Offset: 0x008F9180
		[SkipLocalsInit]
		public unsafe virtual void 展示游戏Logo(float time)
		{
			BP_KuroMasterSeqEvent_C.__展示游戏Logo_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__展示游戏Logo_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__展示游戏Logo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__展示游戏Logo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__展示游戏Logo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D8C2 RID: 121026 RVA: 0x008FAFC8 File Offset: 0x008F91C8
		[SkipLocalsInit]
		public unsafe virtual void 打开章节提示(int ChapterState, int ChapterId)
		{
			BP_KuroMasterSeqEvent_C.__打开章节提示_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__打开章节提示_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__打开章节提示_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__打开章节提示_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ChapterState = ChapterState;
			ptr->ChapterId = ChapterId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__打开章节提示_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D8C3 RID: 121027 RVA: 0x008FB015 File Offset: 0x008F9215
		[SkipLocalsInit]
		public virtual void 触发切镜()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__触发切镜_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8C4 RID: 121028 RVA: 0x008FB029 File Offset: 0x008F9229
		[SkipLocalsInit]
		public virtual void 开始叠化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__开始叠化_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8C5 RID: 121029 RVA: 0x008FB040 File Offset: 0x008F9240
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 执行流程行为(string key)
		{
			BP_KuroMasterSeqEvent_C.__执行流程行为_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__执行流程行为_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__执行流程行为_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__执行流程行为_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->key), key);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__执行流程行为_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_KuroMasterSeqEvent_C.__执行流程行为_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D8C6 RID: 121030 RVA: 0x008FB0A0 File Offset: 0x008F92A0
		[SkipLocalsInit]
		public unsafe virtual void 开关人物飘带(bool enable)
		{
			BP_KuroMasterSeqEvent_C.__开关人物飘带_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__开关人物飘带_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__开关人物飘带_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__开关人物飘带_NativeFunctionPtr, (void*)ptr, 1);
			ptr->enable = enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__开关人物飘带_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D8C7 RID: 121031 RVA: 0x008FB0E6 File Offset: 0x008F92E6
		[SkipLocalsInit]
		public virtual void 恢复镜头裁剪距离()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__恢复镜头裁剪距离_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8C8 RID: 121032 RVA: 0x008FB0FC File Offset: 0x008F92FC
		[SkipLocalsInit]
		public unsafe virtual void 调整镜头裁剪距离(int NearClip)
		{
			BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NearClip = NearClip;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__调整镜头裁剪距离_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D8C9 RID: 121033 RVA: 0x008FB142 File Offset: 0x008F9342
		[SkipLocalsInit]
		public virtual void 副触发切镜()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__副触发切镜_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8CA RID: 121034 RVA: 0x008FB158 File Offset: 0x008F9358
		[SkipLocalsInit]
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

		// Token: 0x0601D8CB RID: 121035 RVA: 0x008FB1B9 File Offset: 0x008F93B9
		[SkipLocalsInit]
		public virtual void 启用动态模糊()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__启用动态模糊_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8CC RID: 121036 RVA: 0x008FB1CD File Offset: 0x008F93CD
		[SkipLocalsInit]
		public virtual void 禁用动态模糊()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__禁用动态模糊_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8CD RID: 121037 RVA: 0x008FB1E4 File Offset: 0x008F93E4
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D8CE RID: 121038 RVA: 0x008FB22C File Offset: 0x008F942C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroMasterSeqEvent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroMasterSeqEvent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D8CF RID: 121039 RVA: 0x008FB272 File Offset: 0x008F9472
		[SkipLocalsInit]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8D0 RID: 121040 RVA: 0x008FB286 File Offset: 0x008F9486
		[SkipLocalsInit]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroMasterSeqEvent_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601D8D1 RID: 121041 RVA: 0x008FB29A File Offset: 0x008F949A
		protected BP_KuroMasterSeqEvent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8E5 RID: 63717
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C";

		// Token: 0x0400F8E6 RID: 63718
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8E7 RID: 63719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8E8 RID: 63720
		public static IntPtr __OnScreenShotFade__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400F8E9 RID: 63721
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F8EA RID: 63722
		internal static int __PropertyOffset_ModifiedNearClipPlane;

		// Token: 0x0400F8EB RID: 63723
		internal static int __PropertyOffset_OnScreenShotFade;

		// Token: 0x0400F8EC RID: 63724
		[Nullable(2)]
		private OnScreenShotFade _OnScreenShotFade;

		// Token: 0x0400F8ED RID: 63725
		internal static int __PropertyOffset_DelayMerge;

		// Token: 0x0400F8EE RID: 63726
		internal static int __PropertyOffset_Icon透明度;

		// Token: 0x0400F8EF RID: 63727
		internal static int __PropertyOffset_Icon遮罩透明度;

		// Token: 0x0400F8F0 RID: 63728
		internal static int __PropertyOffset_counter;

		// Token: 0x0400F8F1 RID: 63729
		private static IntPtr __Seq结束_NativeFunctionPtr;

		// Token: 0x0400F8F2 RID: 63730
		private static IntPtr __显示按键_NativeFunctionPtr;

		// Token: 0x0400F8F3 RID: 63731
		private static IntPtr __相机振动_NativeFunctionPtr;

		// Token: 0x0400F8F4 RID: 63732
		private static IntPtr __打开报幕界面_NativeFunctionPtr;

		// Token: 0x0400F8F5 RID: 63733
		private static IntPtr __启用剧情交互按钮_NativeFunctionPtr;

		// Token: 0x0400F8F6 RID: 63734
		private static IntPtr __绑定物品检视Actor_NativeFunctionPtr;

		// Token: 0x0400F8F7 RID: 63735
		private static IntPtr __额外Seq停止_NativeFunctionPtr;

		// Token: 0x0400F8F8 RID: 63736
		private static IntPtr __额外Seq播放_NativeFunctionPtr;

		// Token: 0x0400F8F9 RID: 63737
		private static IntPtr __背景Icon_NativeFunctionPtr;

		// Token: 0x0400F8FA RID: 63738
		private static IntPtr __关闭Spine动画_数组__NativeFunctionPtr;

		// Token: 0x0400F8FB RID: 63739
		private static IntPtr __关闭Spine动画_NativeFunctionPtr;

		// Token: 0x0400F8FC RID: 63740
		private static IntPtr __播放Spine动画_数组__NativeFunctionPtr;

		// Token: 0x0400F8FD RID: 63741
		private static IntPtr __播放Spine动画_性别__NativeFunctionPtr;

		// Token: 0x0400F8FE RID: 63742
		private static IntPtr __播放Spine动画_NativeFunctionPtr;

		// Token: 0x0400F8FF RID: 63743
		private static IntPtr __执行实体帧事件_NativeFunctionPtr;

		// Token: 0x0400F900 RID: 63744
		private static IntPtr __播放预览图动画_NativeFunctionPtr;

		// Token: 0x0400F901 RID: 63745
		private static IntPtr __关闭预览图_NativeFunctionPtr;

		// Token: 0x0400F902 RID: 63746
		private static IntPtr __显示预览图_数组__NativeFunctionPtr;

		// Token: 0x0400F903 RID: 63747
		private static IntPtr __显示预览图_NativeFunctionPtr;

		// Token: 0x0400F904 RID: 63748
		private static IntPtr __展示游戏Logo_NativeFunctionPtr;

		// Token: 0x0400F905 RID: 63749
		private static IntPtr __打开章节提示_NativeFunctionPtr;

		// Token: 0x0400F906 RID: 63750
		private static IntPtr __触发切镜_NativeFunctionPtr;

		// Token: 0x0400F907 RID: 63751
		private static IntPtr __开始叠化_NativeFunctionPtr;

		// Token: 0x0400F908 RID: 63752
		private static IntPtr __执行流程行为_NativeFunctionPtr;

		// Token: 0x0400F909 RID: 63753
		private static IntPtr __开关人物飘带_NativeFunctionPtr;

		// Token: 0x0400F90A RID: 63754
		private static IntPtr __恢复镜头裁剪距离_NativeFunctionPtr;

		// Token: 0x0400F90B RID: 63755
		private static IntPtr __调整镜头裁剪距离_NativeFunctionPtr;

		// Token: 0x0400F90C RID: 63756
		private static IntPtr __副触发切镜_NativeFunctionPtr;

		// Token: 0x0400F90D RID: 63757
		private static IntPtr __主触发切镜_NativeFunctionPtr;

		// Token: 0x0400F90E RID: 63758
		private static IntPtr __启用动态模糊_NativeFunctionPtr;

		// Token: 0x0400F90F RID: 63759
		private static IntPtr __禁用动态模糊_NativeFunctionPtr;

		// Token: 0x0400F910 RID: 63760
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F911 RID: 63761
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x02008D48 RID: 36168
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __相机振动_FunctionParams
		{
			// Token: 0x0402C8B8 RID: 182456
			[FieldOffset(0)]
			public bool 启用;

			// Token: 0x0402C8B9 RID: 182457
			[FieldOffset(8)]
			public byte 资产;
		}

		// Token: 0x02008D49 RID: 36169
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __打开报幕界面_FunctionParams
		{
			// Token: 0x0402C8BA RID: 182458
			[FieldOffset(0)]
			public FString uiPrefabId;

			// Token: 0x0402C8BB RID: 182459
			[FieldOffset(16)]
			public float duration;

			// Token: 0x0402C8BC RID: 182460
			[FieldOffset(24)]
			public FString uiStartAnimName;

			// Token: 0x0402C8BD RID: 182461
			[FieldOffset(40)]
			public FString uiEndAnimName;
		}

		// Token: 0x02008D4A RID: 36170
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __启用剧情交互按钮_FunctionParams
		{
			// Token: 0x0402C8BE RID: 182462
			[FieldOffset(0)]
			public bool bEnable;
		}

		// Token: 0x02008D4B RID: 36171
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __绑定物品检视Actor_FunctionParams
		{
			// Token: 0x0402C8BF RID: 182463
			[FieldOffset(0)]
			public byte binding;
		}

		// Token: 0x02008D4C RID: 36172
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __额外Seq播放_FunctionParams
		{
			// Token: 0x0402C8C0 RID: 182464
			[FieldOffset(0)]
			public IntPtr Seq;

			// Token: 0x0402C8C1 RID: 182465
			[FieldOffset(8)]
			public FName componentName;

			// Token: 0x0402C8C2 RID: 182466
			[FieldOffset(20)]
			public FName boneName;

			// Token: 0x0402C8C3 RID: 182467
			[FieldOffset(32)]
			public float frame;
		}

		// Token: 0x02008D4D RID: 36173
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __背景Icon_FunctionParams
		{
			// Token: 0x0402C8C4 RID: 182468
			[FieldOffset(0)]
			public bool 显示;

			// Token: 0x0402C8C5 RID: 182469
			[FieldOffset(8)]
			public IntPtr Icon;
		}

		// Token: 0x02008D4E RID: 36174
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __关闭Spine动画_数组__FunctionParams
		{
			// Token: 0x0402C8C6 RID: 182470
			[FieldOffset(0)]
			public byte spineArray;
		}

		// Token: 0x02008D4F RID: 36175
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __关闭Spine动画_FunctionParams
		{
			// Token: 0x0402C8C7 RID: 182471
			[FieldOffset(0)]
			public FString spineName;
		}

		// Token: 0x02008D50 RID: 36176
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __播放Spine动画_数组__FunctionParams
		{
			// Token: 0x0402C8C8 RID: 182472
			[FieldOffset(0)]
			public byte maleSpineArray;

			// Token: 0x0402C8C9 RID: 182473
			[FieldOffset(16)]
			public byte femaleSpineArray;
		}

		// Token: 0x02008D51 RID: 36177
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __播放Spine动画_性别__FunctionParams
		{
			// Token: 0x0402C8CA RID: 182474
			[FieldOffset(0)]
			public FString maleSpineName1;

			// Token: 0x0402C8CB RID: 182475
			[FieldOffset(16)]
			public FString femaleSpineName1;

			// Token: 0x0402C8CC RID: 182476
			[FieldOffset(32)]
			public bool needLoop;
		}

		// Token: 0x02008D52 RID: 36178
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __播放Spine动画_FunctionParams
		{
			// Token: 0x0402C8CD RID: 182477
			[FieldOffset(0)]
			public FString SpineName;

			// Token: 0x0402C8CE RID: 182478
			[FieldOffset(16)]
			public bool needLoop;
		}

		// Token: 0x02008D53 RID: 36179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __执行实体帧事件_FunctionParams
		{
			// Token: 0x0402C8CF RID: 182479
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x0402C8D0 RID: 182480
			[FieldOffset(16)]
			public int EntityId;
		}

		// Token: 0x02008D54 RID: 36180
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __播放预览图动画_FunctionParams
		{
			// Token: 0x0402C8D1 RID: 182481
			[FieldOffset(0)]
			public FString seqName;
		}

		// Token: 0x02008D55 RID: 36181
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __显示预览图_数组__FunctionParams
		{
			// Token: 0x0402C8D2 RID: 182482
			[FieldOffset(0)]
			public FString MaleAssetPath;

			// Token: 0x0402C8D3 RID: 182483
			[FieldOffset(16)]
			public FString FemaleAssetPath;

			// Token: 0x0402C8D4 RID: 182484
			[FieldOffset(32)]
			public byte maleSpineArray;

			// Token: 0x0402C8D5 RID: 182485
			[FieldOffset(48)]
			public byte femaleSpineArray;

			// Token: 0x0402C8D6 RID: 182486
			[FieldOffset(64)]
			public bool useFullscreenAdaptAnchor;
		}

		// Token: 0x02008D56 RID: 36182
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __显示预览图_FunctionParams
		{
			// Token: 0x0402C8D7 RID: 182487
			[FieldOffset(0)]
			public FString MaleAssetPath;

			// Token: 0x0402C8D8 RID: 182488
			[FieldOffset(16)]
			public FString FemaleAssetPath;

			// Token: 0x0402C8D9 RID: 182489
			[FieldOffset(32)]
			public FString maleSpineName;

			// Token: 0x0402C8DA RID: 182490
			[FieldOffset(48)]
			public FString femaleSpineName;

			// Token: 0x0402C8DB RID: 182491
			[FieldOffset(64)]
			public bool needLoop;

			// Token: 0x0402C8DC RID: 182492
			[FieldOffset(65)]
			public bool useFullscreenAdaptAnchor;
		}

		// Token: 0x02008D57 RID: 36183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __展示游戏Logo_FunctionParams
		{
			// Token: 0x0402C8DD RID: 182493
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02008D58 RID: 36184
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __打开章节提示_FunctionParams
		{
			// Token: 0x0402C8DE RID: 182494
			[FieldOffset(0)]
			public int ChapterState;

			// Token: 0x0402C8DF RID: 182495
			[FieldOffset(4)]
			public int ChapterId;
		}

		// Token: 0x02008D59 RID: 36185
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __执行流程行为_FunctionParams
		{
			// Token: 0x0402C8E0 RID: 182496
			[FieldOffset(0)]
			public FString key;
		}

		// Token: 0x02008D5A RID: 36186
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __开关人物飘带_FunctionParams
		{
			// Token: 0x0402C8E1 RID: 182497
			[FieldOffset(0)]
			public bool enable;
		}

		// Token: 0x02008D5B RID: 36187
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __调整镜头裁剪距离_FunctionParams
		{
			// Token: 0x0402C8E2 RID: 182498
			[FieldOffset(0)]
			public int NearClip;
		}

		// Token: 0x02008D5C RID: 36188
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __主触发切镜_FunctionParams
		{
			// Token: 0x0402C8E3 RID: 182499
			[FieldOffset(0)]
			public bool shouldBlend;

			// Token: 0x0402C8E4 RID: 182500
			[FieldOffset(4)]
			public float blendTime;

			// Token: 0x0402C8E5 RID: 182501
			[FieldOffset(8)]
			public TEnumAsByte<EViewTargetBlendFunction> blendFunction;

			// Token: 0x0402C8E6 RID: 182502
			[FieldOffset(12)]
			public float blendExp;
		}

		// Token: 0x02008D5D RID: 36189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C8E7 RID: 182503
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
