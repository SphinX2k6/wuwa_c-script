using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio.AkTools.WorldPointSound
{
	// Token: 0x02004439 RID: 17465
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/AkTools/WorldPointSound/Audio_Multi_Base.Audio_Multi_Base_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1133)]
	public class Audio_Multi_Base_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D34A RID: 185162 RVA: 0x00A36154 File Offset: 0x00A34354
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Audio_Multi_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/AkTools/WorldPointSound/Audio_Multi_Base.Audio_Multi_Base_C");
			}
			return Audio_Multi_Base_C._ClassPtr;
		}

		// Token: 0x0602D34B RID: 185163 RVA: 0x00A36178 File Offset: 0x00A34378
		public Audio_Multi_Base_C() : this(BuiltinUtils.AllocNativeUObject(Audio_Multi_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D34C RID: 185164 RVA: 0x00A361A0 File Offset: 0x00A343A0
		[NullableContext(1)]
		public Audio_Multi_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Audio_Multi_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700728A RID: 29322
		// (get) Token: 0x0602D34D RID: 185165 RVA: 0x00A361D3 File Offset: 0x00A343D3
		// (set) Token: 0x0602D34E RID: 185166 RVA: 0x00A361E7 File Offset: 0x00A343E7
		public unsafe UInstancedStaticMeshComponent ISM可视化显示
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Audio_Multi_Base_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Audio_Multi_Base_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700728B RID: 29323
		// (get) Token: 0x0602D34F RID: 185167 RVA: 0x00A361FC File Offset: 0x00A343FC
		// (set) Token: 0x0602D350 RID: 185168 RVA: 0x00A36210 File Offset: 0x00A34410
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Audio_Multi_Base_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Audio_Multi_Base_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700728C RID: 29324
		// (get) Token: 0x0602D351 RID: 185169 RVA: 0x00A36225 File Offset: 0x00A34425
		// (set) Token: 0x0602D352 RID: 185170 RVA: 0x00A36239 File Offset: 0x00A34439
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Audio_Multi_Base_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Audio_Multi_Base_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700728D RID: 29325
		// (get) Token: 0x0602D353 RID: 185171 RVA: 0x00A3624E File Offset: 0x00A3444E
		// (set) Token: 0x0602D354 RID: 185172 RVA: 0x00A36262 File Offset: 0x00A34462
		public unsafe UAkAudioEvent Event
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + Audio_Multi_Base_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Audio_Multi_Base_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700728E RID: 29326
		// (get) Token: 0x0602D355 RID: 185173 RVA: 0x00A36277 File Offset: 0x00A34477
		// (set) Token: 0x0602D356 RID: 185174 RVA: 0x00A36287 File Offset: 0x00A34487
		public unsafe float 内径缩放因子系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700728F RID: 29327
		// (get) Token: 0x0602D357 RID: 185175 RVA: 0x00A36298 File Offset: 0x00A34498
		// (set) Token: 0x0602D358 RID: 185176 RVA: 0x00A362D1 File Offset: 0x00A344D1
		[Nullable(1)]
		public TArray<FTransform> MultiPos
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._MultiPos) == null)
				{
					result = (this._MultiPos = new TArray<FTransform>(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MultiPos.CopyAssign(value);
			}
		}

		// Token: 0x17007290 RID: 29328
		// (get) Token: 0x0602D359 RID: 185177 RVA: 0x00A362DF File Offset: 0x00A344DF
		// (set) Token: 0x0602D35A RID: 185178 RVA: 0x00A362EF File Offset: 0x00A344EF
		public unsafe float 流送距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17007291 RID: 29329
		// (get) Token: 0x0602D35B RID: 185179 RVA: 0x00A36300 File Offset: 0x00A34500
		// (set) Token: 0x0602D35C RID: 185180 RVA: 0x00A36310 File Offset: 0x00A34510
		public unsafe float 多点内径_不含缩放因子_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17007292 RID: 29330
		// (get) Token: 0x0602D35D RID: 185181 RVA: 0x00A36321 File Offset: 0x00A34521
		// (set) Token: 0x0602D35E RID: 185182 RVA: 0x00A36335 File Offset: 0x00A34535
		public unsafe FVector 材质颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17007293 RID: 29331
		// (get) Token: 0x0602D35F RID: 185183 RVA: 0x00A3634A File Offset: 0x00A3454A
		// (set) Token: 0x0602D360 RID: 185184 RVA: 0x00A3635A File Offset: 0x00A3455A
		public unsafe bool 是否在开始时播放声音
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Audio_Multi_Base_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602D361 RID: 185185 RVA: 0x00A3636B File Offset: 0x00A3456B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Hide()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__Hide_NativeFunctionPtr, null);
		}

		// Token: 0x0602D362 RID: 185186 RVA: 0x00A3637F File Offset: 0x00A3457F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Show()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__Show_NativeFunctionPtr, null);
		}

		// Token: 0x0602D363 RID: 185187 RVA: 0x00A36393 File Offset: 0x00A34593
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GamePlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__GamePlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602D364 RID: 185188 RVA: 0x00A363A7 File Offset: 0x00A345A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 重设中心点()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__重设中心点_NativeFunctionPtr, null);
		}

		// Token: 0x0602D365 RID: 185189 RVA: 0x00A363BB File Offset: 0x00A345BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 显示流送距离()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__显示流送距离_NativeFunctionPtr, null);
		}

		// Token: 0x0602D366 RID: 185190 RVA: 0x00A363D0 File Offset: 0x00A345D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取中心点(ref FVector 中心点)
		{
			Audio_Multi_Base_C.__获取中心点_FunctionParams* ptr = stackalloc Audio_Multi_Base_C.__获取中心点_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Audio_Multi_Base_C.__获取中心点_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Audio_Multi_Base_C.__获取中心点_NativeFunctionPtr, (void*)ptr, 1);
			ptr->中心点 = 中心点;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__获取中心点_NativeFunctionPtr, (void*)ptr);
			中心点 = ptr->中心点;
		}

		// Token: 0x0602D367 RID: 185191 RVA: 0x00A36427 File Offset: 0x00A34627
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 打印()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__打印_NativeFunctionPtr, null);
		}

		// Token: 0x0602D368 RID: 185192 RVA: 0x00A3643C File Offset: 0x00A3463C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 衰减半径缩放因子计算(ref float 衰减半径)
		{
			Audio_Multi_Base_C.__衰减半径缩放因子计算_FunctionParams* ptr = stackalloc Audio_Multi_Base_C.__衰减半径缩放因子计算_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(Audio_Multi_Base_C.__衰减半径缩放因子计算_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Audio_Multi_Base_C.__衰减半径缩放因子计算_NativeFunctionPtr, (void*)ptr, 1);
			ptr->衰减半径 = 衰减半径;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__衰减半径缩放因子计算_NativeFunctionPtr, (void*)ptr);
			衰减半径 = ptr->衰减半径;
		}

		// Token: 0x0602D369 RID: 185193 RVA: 0x00A3648B File Offset: 0x00A3468B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0602D36A RID: 185194 RVA: 0x00A3649F File Offset: 0x00A3469F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Play()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__Play_NativeFunctionPtr, null);
		}

		// Token: 0x0602D36B RID: 185195 RVA: 0x00A364B3 File Offset: 0x00A346B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 清除可视化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__清除可视化_NativeFunctionPtr, null);
		}

		// Token: 0x0602D36C RID: 185196 RVA: 0x00A364C7 File Offset: 0x00A346C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 流送距离计算()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__流送距离计算_NativeFunctionPtr, null);
		}

		// Token: 0x0602D36D RID: 185197 RVA: 0x00A364DB File Offset: 0x00A346DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 根据内径缩放衰减因子()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__根据内径缩放衰减因子_NativeFunctionPtr, null);
		}

		// Token: 0x0602D36E RID: 185198 RVA: 0x00A364EF File Offset: 0x00A346EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 可视化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__可视化_NativeFunctionPtr, null);
		}

		// Token: 0x0602D36F RID: 185199 RVA: 0x00A36503 File Offset: 0x00A34703
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602D370 RID: 185200 RVA: 0x00A36517 File Offset: 0x00A34717
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Audio_Multi_Base_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602D371 RID: 185201 RVA: 0x00A3652C File Offset: 0x00A3472C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			Audio_Multi_Base_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc Audio_Multi_Base_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(Audio_Multi_Base_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Audio_Multi_Base_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Audio_Multi_Base_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D372 RID: 185202 RVA: 0x00A36578 File Offset: 0x00A34778
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			Audio_Multi_Base_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc Audio_Multi_Base_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(Audio_Multi_Base_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Audio_Multi_Base_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Audio_Multi_Base_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D373 RID: 185203 RVA: 0x00A365C4 File Offset: 0x00A347C4
		protected Audio_Multi_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04018077 RID: 98423
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/AkTools/WorldPointSound/Audio_Multi_Base.Audio_Multi_Base_C";

		// Token: 0x04018078 RID: 98424
		private static IntPtr _ClassPtr;

		// Token: 0x04018079 RID: 98425
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401807A RID: 98426
		internal static int __PropertyOffset_1;

		// Token: 0x0401807B RID: 98427
		internal static int __PropertyOffset_2;

		// Token: 0x0401807C RID: 98428
		internal static int __PropertyOffset_3;

		// Token: 0x0401807D RID: 98429
		internal static int __PropertyOffset_4;

		// Token: 0x0401807E RID: 98430
		internal static int __PropertyOffset_5;

		// Token: 0x0401807F RID: 98431
		internal static int __PropertyOffset_6;

		// Token: 0x04018080 RID: 98432
		private TArray<FTransform> _MultiPos;

		// Token: 0x04018081 RID: 98433
		internal static int __PropertyOffset_7;

		// Token: 0x04018082 RID: 98434
		internal static int __PropertyOffset_8;

		// Token: 0x04018083 RID: 98435
		internal static int __PropertyOffset_9;

		// Token: 0x04018084 RID: 98436
		internal static int __PropertyOffset_10;

		// Token: 0x04018085 RID: 98437
		private static IntPtr __Hide_NativeFunctionPtr;

		// Token: 0x04018086 RID: 98438
		private static IntPtr __Show_NativeFunctionPtr;

		// Token: 0x04018087 RID: 98439
		private static IntPtr __GamePlay_NativeFunctionPtr;

		// Token: 0x04018088 RID: 98440
		private static IntPtr __重设中心点_NativeFunctionPtr;

		// Token: 0x04018089 RID: 98441
		private static IntPtr __显示流送距离_NativeFunctionPtr;

		// Token: 0x0401808A RID: 98442
		private static IntPtr __获取中心点_NativeFunctionPtr;

		// Token: 0x0401808B RID: 98443
		private static IntPtr __打印_NativeFunctionPtr;

		// Token: 0x0401808C RID: 98444
		private static IntPtr __衰减半径缩放因子计算_NativeFunctionPtr;

		// Token: 0x0401808D RID: 98445
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0401808E RID: 98446
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x0401808F RID: 98447
		private static IntPtr __清除可视化_NativeFunctionPtr;

		// Token: 0x04018090 RID: 98448
		private static IntPtr __流送距离计算_NativeFunctionPtr;

		// Token: 0x04018091 RID: 98449
		private static IntPtr __根据内径缩放衰减因子_NativeFunctionPtr;

		// Token: 0x04018092 RID: 98450
		private static IntPtr __可视化_NativeFunctionPtr;

		// Token: 0x04018093 RID: 98451
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04018094 RID: 98452
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A6EC RID: 42732
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __获取中心点_FunctionParams
		{
			// Token: 0x040326E0 RID: 206560
			[FieldOffset(0)]
			public FVector 中心点;
		}

		// Token: 0x0200A6ED RID: 42733
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __衰减半径缩放因子计算_FunctionParams
		{
			// Token: 0x040326E1 RID: 206561
			[FieldOffset(0)]
			public float 衰减半径;
		}

		// Token: 0x0200A6EE RID: 42734
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040326E2 RID: 206562
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
