using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003AE1 RID: 15073
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/ExecuteCommandsTool.ExecuteCommandsTool_C")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class ExecuteCommandsTool_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020937 RID: 133431 RVA: 0x008D6C44 File Offset: 0x008D4E44
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ExecuteCommandsTool_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/ExecuteCommandsTool.ExecuteCommandsTool_C");
			}
			return ExecuteCommandsTool_C._ClassPtr;
		}

		// Token: 0x06020938 RID: 133432 RVA: 0x008D6C68 File Offset: 0x008D4E68
		public ExecuteCommandsTool_C() : this(BuiltinUtils.AllocNativeUObject(ExecuteCommandsTool_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020939 RID: 133433 RVA: 0x008D6C90 File Offset: 0x008D4E90
		public ExecuteCommandsTool_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ExecuteCommandsTool_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0602093A RID: 133434 RVA: 0x008D6CC3 File Offset: 0x008D4EC3
		// (set) Token: 0x0602093B RID: 133435 RVA: 0x008D6CD7 File Offset: 0x008D4ED7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ExecuteCommandsTool_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ExecuteCommandsTool_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0602093C RID: 133436 RVA: 0x008D6CEC File Offset: 0x008D4EEC
		// (set) Token: 0x0602093D RID: 133437 RVA: 0x008D6CFC File Offset: 0x008D4EFC
		public unsafe bool NeedRunEndCommand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0602093E RID: 133438 RVA: 0x008D6D10 File Offset: 0x008D4F10
		// (set) Token: 0x0602093F RID: 133439 RVA: 0x008D6D49 File Offset: 0x008D4F49
		public TArray<string> StartCommandArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StartCommandArray) == null)
				{
					result = (this._StartCommandArray = new TArray<string>(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.StartCommandArray.CopyAssign(value);
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x06020940 RID: 133440 RVA: 0x008D6D58 File Offset: 0x008D4F58
		// (set) Token: 0x06020941 RID: 133441 RVA: 0x008D6D91 File Offset: 0x008D4F91
		public TArray<string> EndCommandArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EndCommandArray) == null)
				{
					result = (this._EndCommandArray = new TArray<string>(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.EndCommandArray.CopyAssign(value);
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x06020942 RID: 133442 RVA: 0x008D6DA0 File Offset: 0x008D4FA0
		// (set) Token: 0x06020943 RID: 133443 RVA: 0x008D6DD9 File Offset: 0x008D4FD9
		public TArray<float> OriginalValueArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._OriginalValueArray) == null)
				{
					result = (this._OriginalValueArray = new TArray<float>(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.OriginalValueArray.CopyAssign(value);
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x06020944 RID: 133444 RVA: 0x008D6DE7 File Offset: 0x008D4FE7
		// (set) Token: 0x06020945 RID: 133445 RVA: 0x008D6DF7 File Offset: 0x008D4FF7
		public unsafe bool 按平台执行指令
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x06020946 RID: 133446 RVA: 0x008D6E08 File Offset: 0x008D5008
		// (set) Token: 0x06020947 RID: 133447 RVA: 0x008D6E41 File Offset: 0x008D5041
		public TArray<string> StartCommandArrayMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StartCommandArrayMobile) == null)
				{
					result = (this._StartCommandArrayMobile = new TArray<string>(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.StartCommandArrayMobile.CopyAssign(value);
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x06020948 RID: 133448 RVA: 0x008D6E50 File Offset: 0x008D5050
		// (set) Token: 0x06020949 RID: 133449 RVA: 0x008D6E89 File Offset: 0x008D5089
		public TArray<string> EndCommandArrayMobile
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EndCommandArrayMobile) == null)
				{
					result = (this._EndCommandArrayMobile = new TArray<string>(base.NativePtr + (IntPtr)ExecuteCommandsTool_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.EndCommandArrayMobile.CopyAssign(value);
			}
		}

		// Token: 0x0602094A RID: 133450 RVA: 0x008D6E97 File Offset: 0x008D5097
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 清空指令数组_使用前先点这个_()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ExecuteCommandsTool_C.__清空指令数组_使用前先点这个__NativeFunctionPtr, null);
		}

		// Token: 0x0602094B RID: 133451 RVA: 0x008D6EAB File Offset: 0x008D50AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ExecuteCommandsTool_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602094C RID: 133452 RVA: 0x008D6EBF File Offset: 0x008D50BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ExecuteCommandsTool_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602094D RID: 133453 RVA: 0x008D6ED4 File Offset: 0x008D50D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ExecuteCommandsTool_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602094E RID: 133454 RVA: 0x008D6EE8 File Offset: 0x008D50E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ExecuteCommandsTool_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602094F RID: 133455 RVA: 0x008D6F00 File Offset: 0x008D5100
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			ExecuteCommandsTool_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc ExecuteCommandsTool_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ExecuteCommandsTool_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ExecuteCommandsTool_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ExecuteCommandsTool_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020950 RID: 133456 RVA: 0x008D6F4C File Offset: 0x008D514C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			ExecuteCommandsTool_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc ExecuteCommandsTool_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ExecuteCommandsTool_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ExecuteCommandsTool_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ExecuteCommandsTool_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020951 RID: 133457 RVA: 0x008D6F98 File Offset: 0x008D5198
		protected ExecuteCommandsTool_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCA8 RID: 64680
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/ExecuteCommandsTool.ExecuteCommandsTool_C";

		// Token: 0x0400FCA9 RID: 64681
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCAA RID: 64682
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCAB RID: 64683
		internal static int __PropertyOffset_1;

		// Token: 0x0400FCAC RID: 64684
		internal static int __PropertyOffset_2;

		// Token: 0x0400FCAD RID: 64685
		internal static int __PropertyOffset_3;

		// Token: 0x0400FCAE RID: 64686
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StartCommandArray;

		// Token: 0x0400FCAF RID: 64687
		internal static int __PropertyOffset_4;

		// Token: 0x0400FCB0 RID: 64688
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EndCommandArray;

		// Token: 0x0400FCB1 RID: 64689
		internal static int __PropertyOffset_5;

		// Token: 0x0400FCB2 RID: 64690
		[Nullable(2)]
		private TArray<float> _OriginalValueArray;

		// Token: 0x0400FCB3 RID: 64691
		internal static int __PropertyOffset_6;

		// Token: 0x0400FCB4 RID: 64692
		internal static int __PropertyOffset_7;

		// Token: 0x0400FCB5 RID: 64693
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StartCommandArrayMobile;

		// Token: 0x0400FCB6 RID: 64694
		internal static int __PropertyOffset_8;

		// Token: 0x0400FCB7 RID: 64695
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EndCommandArrayMobile;

		// Token: 0x0400FCB8 RID: 64696
		private static IntPtr __清空指令数组_使用前先点这个__NativeFunctionPtr;

		// Token: 0x0400FCB9 RID: 64697
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FCBA RID: 64698
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FCBB RID: 64699
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009BE0 RID: 39904
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031274 RID: 201332
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
