using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A47 RID: 14919
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/BPI_Gacha.BPI_Gacha_C")]
	public interface IBPI_Gacha_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F745 RID: 128837 RVA: 0x008B8C20 File Offset: 0x008B6E20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void ShowroomStart(int Frame, float Subtime)
		{
			IBPI_Gacha_C.__ShowroomStart_FunctionParams* ptr = stackalloc IBPI_Gacha_C.__ShowroomStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_Gacha_C.__ShowroomStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Gacha_C_ReflectionImplementationFields.__ShowroomStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Gacha_C_ReflectionImplementationFields.__ShowroomStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F746 RID: 128838 RVA: 0x008B8C70 File Offset: 0x008B6E70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void OutroStart(int Frame, float Subtime)
		{
			IBPI_Gacha_C.__OutroStart_FunctionParams* ptr = stackalloc IBPI_Gacha_C.__OutroStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_Gacha_C.__OutroStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Gacha_C_ReflectionImplementationFields.__OutroStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Gacha_C_ReflectionImplementationFields.__OutroStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F747 RID: 128839 RVA: 0x008B8CC0 File Offset: 0x008B6EC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void InteractStart(int Frame, float Subtime)
		{
			IBPI_Gacha_C.__InteractStart_FunctionParams* ptr = stackalloc IBPI_Gacha_C.__InteractStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_Gacha_C.__InteractStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Gacha_C_ReflectionImplementationFields.__InteractStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Gacha_C_ReflectionImplementationFields.__InteractStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F748 RID: 128840 RVA: 0x008B8D10 File Offset: 0x008B6F10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void IntroStart(int Frame, float Subtime)
		{
			IBPI_Gacha_C.__IntroStart_FunctionParams* ptr = stackalloc IBPI_Gacha_C.__IntroStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_Gacha_C.__IntroStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Gacha_C_ReflectionImplementationFields.__IntroStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Gacha_C_ReflectionImplementationFields.__IntroStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0400F1BF RID: 61887
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BPI_Gacha.BPI_Gacha_C";

		// Token: 0x02009ADF RID: 39647
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ShowroomStart_FunctionParams
		{
			// Token: 0x040310A7 RID: 200871
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x040310A8 RID: 200872
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02009AE0 RID: 39648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutroStart_FunctionParams
		{
			// Token: 0x040310A9 RID: 200873
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x040310AA RID: 200874
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02009AE1 RID: 39649
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InteractStart_FunctionParams
		{
			// Token: 0x040310AB RID: 200875
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x040310AC RID: 200876
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02009AE2 RID: 39650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IntroStart_FunctionParams
		{
			// Token: 0x040310AD RID: 200877
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x040310AE RID: 200878
			[FieldOffset(4)]
			public float Subtime;
		}
	}
}
