using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ToonDepthTool
{
	// Token: 0x02003ABB RID: 15035
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ToonDepthTool/ToonDepthCmdTool.ToonDepthCmdTool_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ToonDepthCmdTool_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020417 RID: 132119 RVA: 0x008CDE1C File Offset: 0x008CC01C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ToonDepthCmdTool_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ToonDepthTool/ToonDepthCmdTool.ToonDepthCmdTool_C");
			}
			return ToonDepthCmdTool_C._ClassPtr;
		}

		// Token: 0x06020418 RID: 132120 RVA: 0x008CDE40 File Offset: 0x008CC040
		public ToonDepthCmdTool_C() : this(BuiltinUtils.AllocNativeUObject(ToonDepthCmdTool_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020419 RID: 132121 RVA: 0x008CDE68 File Offset: 0x008CC068
		public ToonDepthCmdTool_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ToonDepthCmdTool_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0602041A RID: 132122 RVA: 0x008CDE9B File Offset: 0x008CC09B
		// (set) Token: 0x0602041B RID: 132123 RVA: 0x008CDEAF File Offset: 0x008CC0AF
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ToonDepthCmdTool_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ToonDepthCmdTool_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0602041C RID: 132124 RVA: 0x008CDEC4 File Offset: 0x008CC0C4
		// (set) Token: 0x0602041D RID: 132125 RVA: 0x008CDED4 File Offset: 0x008CC0D4
		public unsafe bool NeedRunEndCommand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ToonDepthCmdTool_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ToonDepthCmdTool_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0602041E RID: 132126 RVA: 0x008CDEE8 File Offset: 0x008CC0E8
		// (set) Token: 0x0602041F RID: 132127 RVA: 0x008CDF21 File Offset: 0x008CC121
		public TArray<string> StartCommandArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._StartCommandArray) == null)
				{
					result = (this._StartCommandArray = new TArray<string>(base.NativePtr + (IntPtr)ToonDepthCmdTool_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.StartCommandArray.CopyAssign(value);
			}
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x06020420 RID: 132128 RVA: 0x008CDF30 File Offset: 0x008CC130
		// (set) Token: 0x06020421 RID: 132129 RVA: 0x008CDF69 File Offset: 0x008CC169
		public TArray<string> EndCommandArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EndCommandArray) == null)
				{
					result = (this._EndCommandArray = new TArray<string>(base.NativePtr + (IntPtr)ToonDepthCmdTool_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.EndCommandArray.CopyAssign(value);
			}
		}

		// Token: 0x06020422 RID: 132130 RVA: 0x008CDF77 File Offset: 0x008CC177
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ToonDepthCmdTool_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020423 RID: 132131 RVA: 0x008CDF8B File Offset: 0x008CC18B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ToonDepthCmdTool_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020424 RID: 132132 RVA: 0x008CDFA0 File Offset: 0x008CC1A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ToonDepthCmdTool_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020425 RID: 132133 RVA: 0x008CDFB4 File Offset: 0x008CC1B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ToonDepthCmdTool_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020426 RID: 132134 RVA: 0x008CDFCC File Offset: 0x008CC1CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			ToonDepthCmdTool_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc ToonDepthCmdTool_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ToonDepthCmdTool_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ToonDepthCmdTool_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ToonDepthCmdTool_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020427 RID: 132135 RVA: 0x008CE018 File Offset: 0x008CC218
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			ToonDepthCmdTool_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc ToonDepthCmdTool_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ToonDepthCmdTool_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ToonDepthCmdTool_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ToonDepthCmdTool_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020428 RID: 132136 RVA: 0x008CE064 File Offset: 0x008CC264
		protected ToonDepthCmdTool_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F98D RID: 63885
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ToonDepthTool/ToonDepthCmdTool.ToonDepthCmdTool_C";

		// Token: 0x0400F98E RID: 63886
		private static IntPtr _ClassPtr;

		// Token: 0x0400F98F RID: 63887
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F990 RID: 63888
		internal static int __PropertyOffset_1;

		// Token: 0x0400F991 RID: 63889
		internal static int __PropertyOffset_2;

		// Token: 0x0400F992 RID: 63890
		internal static int __PropertyOffset_3;

		// Token: 0x0400F993 RID: 63891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _StartCommandArray;

		// Token: 0x0400F994 RID: 63892
		internal static int __PropertyOffset_4;

		// Token: 0x0400F995 RID: 63893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EndCommandArray;

		// Token: 0x0400F996 RID: 63894
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F997 RID: 63895
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F998 RID: 63896
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009B99 RID: 39833
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040311ED RID: 201197
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
