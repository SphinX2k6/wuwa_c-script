using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrafficFlow
{
	// Token: 0x02003AB8 RID: 15032
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrafficFlow/BP_TrafficFlow.BP_TrafficFlow_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class BP_TrafficFlow_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060203D4 RID: 132052 RVA: 0x008CD840 File Offset: 0x008CBA40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrafficFlow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrafficFlow/BP_TrafficFlow.BP_TrafficFlow_C");
			}
			return BP_TrafficFlow_C._ClassPtr;
		}

		// Token: 0x060203D5 RID: 132053 RVA: 0x008CD864 File Offset: 0x008CBA64
		public BP_TrafficFlow_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrafficFlow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203D6 RID: 132054 RVA: 0x008CD88C File Offset: 0x008CBA8C
		[NullableContext(1)]
		public BP_TrafficFlow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrafficFlow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x060203D7 RID: 132055 RVA: 0x008CD8BF File Offset: 0x008CBABF
		// (set) Token: 0x060203D8 RID: 132056 RVA: 0x008CD8D3 File Offset: 0x008CBAD3
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrafficFlow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrafficFlow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x060203D9 RID: 132057 RVA: 0x008CD8E8 File Offset: 0x008CBAE8
		// (set) Token: 0x060203DA RID: 132058 RVA: 0x008CD8F8 File Offset: 0x008CBAF8
		public unsafe float 车流速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x060203DB RID: 132059 RVA: 0x008CD909 File Offset: 0x008CBB09
		// (set) Token: 0x060203DC RID: 132060 RVA: 0x008CD919 File Offset: 0x008CBB19
		public unsafe float 车流密度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x060203DD RID: 132061 RVA: 0x008CD92A File Offset: 0x008CBB2A
		// (set) Token: 0x060203DE RID: 132062 RVA: 0x008CD93E File Offset: 0x008CBB3E
		public unsafe UNiagaraSystem PC端资产
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrafficFlow_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrafficFlow_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x060203DF RID: 132063 RVA: 0x008CD953 File Offset: 0x008CBB53
		// (set) Token: 0x060203E0 RID: 132064 RVA: 0x008CD963 File Offset: 0x008CBB63
		public unsafe bool 移动端优化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x060203E1 RID: 132065 RVA: 0x008CD974 File Offset: 0x008CBB74
		// (set) Token: 0x060203E2 RID: 132066 RVA: 0x008CD988 File Offset: 0x008CBB88
		public unsafe UNiagaraSystem 移动端资产
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrafficFlow_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrafficFlow_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x060203E3 RID: 132067 RVA: 0x008CD9A0 File Offset: 0x008CBBA0
		// (set) Token: 0x060203E4 RID: 132068 RVA: 0x008CD9D9 File Offset: 0x008CBBD9
		[Nullable(1)]
		public TArray<TSoftObjectPtr<AActor>> 道路样条线
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<AActor>> result;
				if ((result = this._道路样条线) == null)
				{
					result = (this._道路样条线 = new TArray<TSoftObjectPtr<AActor>>(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.道路样条线.CopyAssign(value);
			}
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x060203E5 RID: 132069 RVA: 0x008CD9E7 File Offset: 0x008CBBE7
		// (set) Token: 0x060203E6 RID: 132070 RVA: 0x008CD9F7 File Offset: 0x008CBBF7
		public unsafe int Level
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x060203E7 RID: 132071 RVA: 0x008CDA08 File Offset: 0x008CBC08
		// (set) Token: 0x060203E8 RID: 132072 RVA: 0x008CDA18 File Offset: 0x008CBC18
		public unsafe int CurrentLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrafficFlow_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x060203E9 RID: 132073 RVA: 0x008CDA29 File Offset: 0x008CBC29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成车流()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrafficFlow_C.__生成车流_NativeFunctionPtr, null);
		}

		// Token: 0x060203EA RID: 132074 RVA: 0x008CDA3D File Offset: 0x008CBC3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrafficFlow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060203EB RID: 132075 RVA: 0x008CDA51 File Offset: 0x008CBC51
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrafficFlow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060203EC RID: 132076 RVA: 0x008CDA66 File Offset: 0x008CBC66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrafficFlow_C.__CustomEvent_Start_NativeFunctionPtr, null);
		}

		// Token: 0x060203ED RID: 132077 RVA: 0x008CDA7A File Offset: 0x008CBC7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_Manual()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrafficFlow_C.__CustomEvent_Manual_NativeFunctionPtr, null);
		}

		// Token: 0x060203EE RID: 132078 RVA: 0x008CDA8E File Offset: 0x008CBC8E
		protected BP_TrafficFlow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F967 RID: 63847
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrafficFlow/BP_TrafficFlow.BP_TrafficFlow_C";

		// Token: 0x0400F968 RID: 63848
		private static IntPtr _ClassPtr;

		// Token: 0x0400F969 RID: 63849
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F96A RID: 63850
		internal static int __PropertyOffset_1;

		// Token: 0x0400F96B RID: 63851
		internal static int __PropertyOffset_2;

		// Token: 0x0400F96C RID: 63852
		internal static int __PropertyOffset_3;

		// Token: 0x0400F96D RID: 63853
		internal static int __PropertyOffset_4;

		// Token: 0x0400F96E RID: 63854
		internal static int __PropertyOffset_5;

		// Token: 0x0400F96F RID: 63855
		internal static int __PropertyOffset_6;

		// Token: 0x0400F970 RID: 63856
		internal static int __PropertyOffset_7;

		// Token: 0x0400F971 RID: 63857
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<AActor>> _道路样条线;

		// Token: 0x0400F972 RID: 63858
		internal static int __PropertyOffset_8;

		// Token: 0x0400F973 RID: 63859
		internal static int __PropertyOffset_9;

		// Token: 0x0400F974 RID: 63860
		private static IntPtr __生成车流_NativeFunctionPtr;

		// Token: 0x0400F975 RID: 63861
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F976 RID: 63862
		private static IntPtr __CustomEvent_Start_NativeFunctionPtr;

		// Token: 0x0400F977 RID: 63863
		private static IntPtr __CustomEvent_Manual_NativeFunctionPtr;
	}
}
