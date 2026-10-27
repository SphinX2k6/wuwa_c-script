using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x0200442C RID: 17452
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_AudioSpace.BP_AudioSpace_C")]
	[UnrealStructLayout(1184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1178)]
	public class BP_AudioSpace_C : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D228 RID: 184872 RVA: 0x00A34350 File Offset: 0x00A32550
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AudioSpace_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_AudioSpace.BP_AudioSpace_C");
			}
			return BP_AudioSpace_C._ClassPtr;
		}

		// Token: 0x0602D229 RID: 184873 RVA: 0x00A34374 File Offset: 0x00A32574
		public BP_AudioSpace_C() : this(BuiltinUtils.AllocNativeUObject(BP_AudioSpace_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D22A RID: 184874 RVA: 0x00A3439C File Offset: 0x00A3259C
		[NullableContext(1)]
		public BP_AudioSpace_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AudioSpace_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700722F RID: 29231
		// (get) Token: 0x0602D22B RID: 184875 RVA: 0x00A343CF File Offset: 0x00A325CF
		// (set) Token: 0x0602D22C RID: 184876 RVA: 0x00A343E3 File Offset: 0x00A325E3
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17007230 RID: 29232
		// (get) Token: 0x0602D22D RID: 184877 RVA: 0x00A343F8 File Offset: 0x00A325F8
		// (set) Token: 0x0602D22E RID: 184878 RVA: 0x00A3440C File Offset: 0x00A3260C
		public unsafe UAkComponent AkComponentRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17007231 RID: 29233
		// (get) Token: 0x0602D22F RID: 184879 RVA: 0x00A34421 File Offset: 0x00A32621
		// (set) Token: 0x0602D230 RID: 184880 RVA: 0x00A34435 File Offset: 0x00A32635
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17007232 RID: 29234
		// (get) Token: 0x0602D231 RID: 184881 RVA: 0x00A3444A File Offset: 0x00A3264A
		// (set) Token: 0x0602D232 RID: 184882 RVA: 0x00A3445A File Offset: 0x00A3265A
		public unsafe float 触发距离长_半径_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17007233 RID: 29235
		// (get) Token: 0x0602D233 RID: 184883 RVA: 0x00A3446B File Offset: 0x00A3266B
		// (set) Token: 0x0602D234 RID: 184884 RVA: 0x00A3447B File Offset: 0x00A3267B
		public unsafe float 触发距离宽
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17007234 RID: 29236
		// (get) Token: 0x0602D235 RID: 184885 RVA: 0x00A3448C File Offset: 0x00A3268C
		// (set) Token: 0x0602D236 RID: 184886 RVA: 0x00A3449C File Offset: 0x00A3269C
		public unsafe float 触发高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17007235 RID: 29237
		// (get) Token: 0x0602D237 RID: 184887 RVA: 0x00A344AD File Offset: 0x00A326AD
		// (set) Token: 0x0602D238 RID: 184888 RVA: 0x00A344C1 File Offset: 0x00A326C1
		public unsafe FLinearColor 触发距离颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17007236 RID: 29238
		// (get) Token: 0x0602D239 RID: 184889 RVA: 0x00A344D6 File Offset: 0x00A326D6
		// (set) Token: 0x0602D23A RID: 184890 RVA: 0x00A344E6 File Offset: 0x00A326E6
		public unsafe bool 运行时显示区间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007237 RID: 29239
		// (get) Token: 0x0602D23B RID: 184891 RVA: 0x00A344F7 File Offset: 0x00A326F7
		// (set) Token: 0x0602D23C RID: 184892 RVA: 0x00A34507 File Offset: 0x00A32707
		public unsafe bool 编辑时显示区间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007238 RID: 29240
		// (get) Token: 0x0602D23D RID: 184893 RVA: 0x00A34518 File Offset: 0x00A32718
		// (set) Token: 0x0602D23E RID: 184894 RVA: 0x00A34528 File Offset: 0x00A32728
		public unsafe float 更新Editor文本框CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17007239 RID: 29241
		// (get) Token: 0x0602D23F RID: 184895 RVA: 0x00A34539 File Offset: 0x00A32739
		// (set) Token: 0x0602D240 RID: 184896 RVA: 0x00A34549 File Offset: 0x00A32749
		public unsafe float Editor检测间隔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700723A RID: 29242
		// (get) Token: 0x0602D241 RID: 184897 RVA: 0x00A3455A File Offset: 0x00A3275A
		// (set) Token: 0x0602D242 RID: 184898 RVA: 0x00A3456A File Offset: 0x00A3276A
		public unsafe float 运行时绘制时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700723B RID: 29243
		// (get) Token: 0x0602D243 RID: 184899 RVA: 0x00A3457B File Offset: 0x00A3277B
		// (set) Token: 0x0602D244 RID: 184900 RVA: 0x00A3458F File Offset: 0x00A3278F
		public unsafe UAkAudioEvent 进入声音事件
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x1700723C RID: 29244
		// (get) Token: 0x0602D245 RID: 184901 RVA: 0x00A345A4 File Offset: 0x00A327A4
		// (set) Token: 0x0602D246 RID: 184902 RVA: 0x00A345B8 File Offset: 0x00A327B8
		public unsafe UAkAudioEvent 离开声音事件
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AudioSpace_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x1700723D RID: 29245
		// (get) Token: 0x0602D247 RID: 184903 RVA: 0x00A345CD File Offset: 0x00A327CD
		// (set) Token: 0x0602D248 RID: 184904 RVA: 0x00A345DD File Offset: 0x00A327DD
		public unsafe bool 是否进入触发范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700723E RID: 29246
		// (get) Token: 0x0602D249 RID: 184905 RVA: 0x00A345F0 File Offset: 0x00A327F0
		// (set) Token: 0x0602D24A RID: 184906 RVA: 0x00A34629 File Offset: 0x00A32829
		[Nullable(1)]
		public TArray<BP_SAudioCondition> 音效条件
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<BP_SAudioCondition> result;
				if ((result = this._音效条件) == null)
				{
					result = (this._音效条件 = new TArray<BP_SAudioCondition>(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.音效条件.CopyAssign(value);
			}
		}

		// Token: 0x1700723F RID: 29247
		// (get) Token: 0x0602D24B RID: 184907 RVA: 0x00A34637 File Offset: 0x00A32837
		// (set) Token: 0x0602D24C RID: 184908 RVA: 0x00A34647 File Offset: 0x00A32847
		public unsafe bool 是否在视界内
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007240 RID: 29248
		// (get) Token: 0x0602D24D RID: 184909 RVA: 0x00A34658 File Offset: 0x00A32858
		// (set) Token: 0x0602D24E RID: 184910 RVA: 0x00A34668 File Offset: 0x00A32868
		public unsafe bool 是否播放进入战斗音效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AudioSpace_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602D24F RID: 184911 RVA: 0x00A34679 File Offset: 0x00A32879
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 离开重置播放标志()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__离开重置播放标志_NativeFunctionPtr, null);
		}

		// Token: 0x0602D250 RID: 184912 RVA: 0x00A34690 File Offset: 0x00A32890
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 战斗条件检测(ref UAkAudioEvent 指定进入音效, ref UAkAudioEvent 指定离开音效)
		{
			BP_AudioSpace_C.__战斗条件检测_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__战斗条件检测_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_AudioSpace_C.__战斗条件检测_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__战斗条件检测_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_AudioSpace_C.__战斗条件检测_FunctionParams ptr2 = ref *ptr;
			UAkAudioEvent uakAudioEvent = 指定进入音效;
			ptr2.指定进入音效 = ((uakAudioEvent != null) ? uakAudioEvent.NativePtr : IntPtr.Zero);
			ref BP_AudioSpace_C.__战斗条件检测_FunctionParams ptr3 = ref *ptr;
			UAkAudioEvent uakAudioEvent2 = 指定离开音效;
			ptr3.指定离开音效 = ((uakAudioEvent2 != null) ? uakAudioEvent2.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__战斗条件检测_NativeFunctionPtr, (void*)ptr);
			指定进入音效 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkAudioEvent>(ptr->指定进入音效);
			指定离开音效 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAkAudioEvent>(ptr->指定离开音效);
		}

		// Token: 0x0602D251 RID: 184913 RVA: 0x00A34719 File Offset: 0x00A32919
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 检测条件()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__检测条件_NativeFunctionPtr, null);
		}

		// Token: 0x0602D252 RID: 184914 RVA: 0x00A34730 File Offset: 0x00A32930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 玩家是否在矩形范围内(ref bool 玩家是否在范围内)
		{
			BP_AudioSpace_C.__玩家是否在矩形范围内_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__玩家是否在矩形范围内_FunctionParams[(UIntPtr)783] + 15L / (long)sizeof(BP_AudioSpace_C.__玩家是否在矩形范围内_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__玩家是否在矩形范围内_NativeFunctionPtr, (void*)ptr, 1);
			ptr->玩家是否在范围内 = 玩家是否在范围内;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__玩家是否在矩形范围内_NativeFunctionPtr, (void*)ptr);
			玩家是否在范围内 = ptr->玩家是否在范围内;
		}

		// Token: 0x0602D253 RID: 184915 RVA: 0x00A34784 File Offset: 0x00A32984
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 播放指定音效(UAkAudioEvent 指定音效)
		{
			BP_AudioSpace_C.__播放指定音效_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__播放指定音效_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_AudioSpace_C.__播放指定音效_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__播放指定音效_NativeFunctionPtr, (void*)ptr, 1);
			ptr->指定音效 = ((指定音效 != null) ? 指定音效.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__播放指定音效_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D254 RID: 184916 RVA: 0x00A347D9 File Offset: 0x00A329D9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 播放离开音效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__播放离开音效_NativeFunctionPtr, null);
		}

		// Token: 0x0602D255 RID: 184917 RVA: 0x00A347ED File Offset: 0x00A329ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 播放进入音效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__播放进入音效_NativeFunctionPtr, null);
		}

		// Token: 0x0602D256 RID: 184918 RVA: 0x00A34801 File Offset: 0x00A32A01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新触发范围()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__更新触发范围_NativeFunctionPtr, null);
		}

		// Token: 0x0602D257 RID: 184919 RVA: 0x00A34818 File Offset: 0x00A32A18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 玩家和音源点的距离(ref float 距离)
		{
			BP_AudioSpace_C.__玩家和音源点的距离_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__玩家和音源点的距离_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_AudioSpace_C.__玩家和音源点的距离_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__玩家和音源点的距离_NativeFunctionPtr, (void*)ptr, 1);
			ptr->距离 = 距离;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__玩家和音源点的距离_NativeFunctionPtr, (void*)ptr);
			距离 = ptr->距离;
		}

		// Token: 0x0602D258 RID: 184920 RVA: 0x00A34867 File Offset: 0x00A32A67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 绘制触发范围()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__绘制触发范围_NativeFunctionPtr, null);
		}

		// Token: 0x0602D259 RID: 184921 RVA: 0x00A3487C File Offset: 0x00A32A7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 绘制方形(FTransform 变换, float Duration)
		{
			BP_AudioSpace_C.__绘制方形_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__绘制方形_FunctionParams[(UIntPtr)319] + 15L / (long)sizeof(BP_AudioSpace_C.__绘制方形_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__绘制方形_NativeFunctionPtr, (void*)ptr, 1);
			ptr->变换 = 变换;
			ptr->Duration = Duration;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__绘制方形_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D25A RID: 184922 RVA: 0x00A348CC File Offset: 0x00A32ACC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 绘制柱形(FTransform 变换, FLinearColor 颜色, float Duration)
		{
			BP_AudioSpace_C.__绘制柱形_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__绘制柱形_FunctionParams[(UIntPtr)479] + 15L / (long)sizeof(BP_AudioSpace_C.__绘制柱形_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__绘制柱形_NativeFunctionPtr, (void*)ptr, 1);
			ptr->变换 = 变换;
			ptr->颜色 = 颜色;
			ptr->Duration = Duration;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__绘制柱形_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D25B RID: 184923 RVA: 0x00A34924 File Offset: 0x00A32B24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 绘制定点(FTransform 变换, float duration)
		{
			BP_AudioSpace_C.__绘制定点_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__绘制定点_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_AudioSpace_C.__绘制定点_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__绘制定点_NativeFunctionPtr, (void*)ptr, 1);
			ptr->变换 = 变换;
			ptr->duration = duration;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__绘制定点_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D25C RID: 184924 RVA: 0x00A34974 File Offset: 0x00A32B74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 描绘()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__描绘_NativeFunctionPtr, null);
		}

		// Token: 0x0602D25D RID: 184925 RVA: 0x00A34988 File Offset: 0x00A32B88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool 判断是否需要描绘(float DeltaSeconds)
		{
			BP_AudioSpace_C.__判断是否需要描绘_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__判断是否需要描绘_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_AudioSpace_C.__判断是否需要描绘_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__判断是否需要描绘_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__判断是否需要描绘_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602D25E RID: 184926 RVA: 0x00A349D8 File Offset: 0x00A32BD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_AudioSpace_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AudioSpace_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D25F RID: 184927 RVA: 0x00A34A20 File Offset: 0x00A32C20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_AudioSpace_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AudioSpace_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AudioSpace_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D260 RID: 184928 RVA: 0x00A34A68 File Offset: 0x00A32C68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_AudioSpace_C.__EditorTick_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AudioSpace_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D261 RID: 184929 RVA: 0x00A34AB0 File Offset: 0x00A32CB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_AudioSpace_C.__EditorTick_FunctionParams* ptr = stackalloc BP_AudioSpace_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AudioSpace_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AudioSpace_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AudioSpace_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D262 RID: 184930 RVA: 0x00A34AF7 File Offset: 0x00A32CF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 进入触发范围()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__进入触发范围_NativeFunctionPtr, null);
		}

		// Token: 0x0602D263 RID: 184931 RVA: 0x00A34B0B File Offset: 0x00A32D0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 离开触发范围()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AudioSpace_C.__离开触发范围_NativeFunctionPtr, null);
		}

		// Token: 0x0602D264 RID: 184932 RVA: 0x00A34B1F File Offset: 0x00A32D1F
		protected BP_AudioSpace_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017FA5 RID: 98213
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_AudioSpace.BP_AudioSpace_C";

		// Token: 0x04017FA6 RID: 98214
		private static IntPtr _ClassPtr;

		// Token: 0x04017FA7 RID: 98215
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017FA8 RID: 98216
		internal static int __PropertyOffset_1;

		// Token: 0x04017FA9 RID: 98217
		internal static int __PropertyOffset_2;

		// Token: 0x04017FAA RID: 98218
		internal static int __PropertyOffset_3;

		// Token: 0x04017FAB RID: 98219
		internal static int __PropertyOffset_4;

		// Token: 0x04017FAC RID: 98220
		internal static int __PropertyOffset_5;

		// Token: 0x04017FAD RID: 98221
		internal static int __PropertyOffset_6;

		// Token: 0x04017FAE RID: 98222
		internal static int __PropertyOffset_7;

		// Token: 0x04017FAF RID: 98223
		internal static int __PropertyOffset_8;

		// Token: 0x04017FB0 RID: 98224
		internal static int __PropertyOffset_9;

		// Token: 0x04017FB1 RID: 98225
		internal static int __PropertyOffset_10;

		// Token: 0x04017FB2 RID: 98226
		internal static int __PropertyOffset_11;

		// Token: 0x04017FB3 RID: 98227
		internal static int __PropertyOffset_12;

		// Token: 0x04017FB4 RID: 98228
		internal static int __PropertyOffset_13;

		// Token: 0x04017FB5 RID: 98229
		internal static int __PropertyOffset_14;

		// Token: 0x04017FB6 RID: 98230
		internal static int __PropertyOffset_15;

		// Token: 0x04017FB7 RID: 98231
		internal static int __PropertyOffset_16;

		// Token: 0x04017FB8 RID: 98232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_SAudioCondition> _音效条件;

		// Token: 0x04017FB9 RID: 98233
		internal static int __PropertyOffset_17;

		// Token: 0x04017FBA RID: 98234
		internal static int __PropertyOffset_18;

		// Token: 0x04017FBB RID: 98235
		private static IntPtr __离开重置播放标志_NativeFunctionPtr;

		// Token: 0x04017FBC RID: 98236
		private static IntPtr __战斗条件检测_NativeFunctionPtr;

		// Token: 0x04017FBD RID: 98237
		private static IntPtr __检测条件_NativeFunctionPtr;

		// Token: 0x04017FBE RID: 98238
		private static IntPtr __玩家是否在矩形范围内_NativeFunctionPtr;

		// Token: 0x04017FBF RID: 98239
		private static IntPtr __播放指定音效_NativeFunctionPtr;

		// Token: 0x04017FC0 RID: 98240
		private static IntPtr __播放离开音效_NativeFunctionPtr;

		// Token: 0x04017FC1 RID: 98241
		private static IntPtr __播放进入音效_NativeFunctionPtr;

		// Token: 0x04017FC2 RID: 98242
		private static IntPtr __更新触发范围_NativeFunctionPtr;

		// Token: 0x04017FC3 RID: 98243
		private static IntPtr __玩家和音源点的距离_NativeFunctionPtr;

		// Token: 0x04017FC4 RID: 98244
		private static IntPtr __绘制触发范围_NativeFunctionPtr;

		// Token: 0x04017FC5 RID: 98245
		private static IntPtr __绘制方形_NativeFunctionPtr;

		// Token: 0x04017FC6 RID: 98246
		private static IntPtr __绘制柱形_NativeFunctionPtr;

		// Token: 0x04017FC7 RID: 98247
		private static IntPtr __绘制定点_NativeFunctionPtr;

		// Token: 0x04017FC8 RID: 98248
		private static IntPtr __描绘_NativeFunctionPtr;

		// Token: 0x04017FC9 RID: 98249
		private static IntPtr __判断是否需要描绘_NativeFunctionPtr;

		// Token: 0x04017FCA RID: 98250
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04017FCB RID: 98251
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04017FCC RID: 98252
		private static IntPtr __进入触发范围_NativeFunctionPtr;

		// Token: 0x04017FCD RID: 98253
		private static IntPtr __离开触发范围_NativeFunctionPtr;

		// Token: 0x0200A6DA RID: 42714
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __战斗条件检测_FunctionParams
		{
			// Token: 0x040326C1 RID: 206529
			[FieldOffset(0)]
			public IntPtr 指定进入音效;

			// Token: 0x040326C2 RID: 206530
			[FieldOffset(8)]
			public IntPtr 指定离开音效;
		}

		// Token: 0x0200A6DB RID: 42715
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 768)]
		protected ref struct __玩家是否在矩形范围内_FunctionParams
		{
			// Token: 0x040326C3 RID: 206531
			[FieldOffset(0)]
			public bool 玩家是否在范围内;
		}

		// Token: 0x0200A6DC RID: 42716
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __播放指定音效_FunctionParams
		{
			// Token: 0x040326C4 RID: 206532
			[FieldOffset(0)]
			public IntPtr 指定音效;
		}

		// Token: 0x0200A6DD RID: 42717
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __玩家和音源点的距离_FunctionParams
		{
			// Token: 0x040326C5 RID: 206533
			[FieldOffset(0)]
			public float 距离;
		}

		// Token: 0x0200A6DE RID: 42718
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 304)]
		protected ref struct __绘制方形_FunctionParams
		{
			// Token: 0x040326C6 RID: 206534
			[FieldOffset(0)]
			public FTransform 变换;

			// Token: 0x040326C7 RID: 206535
			[FieldOffset(48)]
			public float Duration;
		}

		// Token: 0x0200A6DF RID: 42719
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 464)]
		protected ref struct __绘制柱形_FunctionParams
		{
			// Token: 0x040326C8 RID: 206536
			[FieldOffset(0)]
			public FTransform 变换;

			// Token: 0x040326C9 RID: 206537
			[FieldOffset(48)]
			public FLinearColor 颜色;

			// Token: 0x040326CA RID: 206538
			[FieldOffset(64)]
			public float Duration;
		}

		// Token: 0x0200A6E0 RID: 42720
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __绘制定点_FunctionParams
		{
			// Token: 0x040326CB RID: 206539
			[FieldOffset(0)]
			public FTransform 变换;

			// Token: 0x040326CC RID: 206540
			[FieldOffset(48)]
			public float duration;
		}

		// Token: 0x0200A6E1 RID: 42721
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __判断是否需要描绘_FunctionParams
		{
			// Token: 0x040326CD RID: 206541
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x040326CE RID: 206542
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x0200A6E2 RID: 42722
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040326CF RID: 206543
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A6E3 RID: 42723
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040326D0 RID: 206544
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
