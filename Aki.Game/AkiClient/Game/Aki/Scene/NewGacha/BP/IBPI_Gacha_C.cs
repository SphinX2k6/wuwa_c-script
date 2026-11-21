using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003085 RID: 12421
	[UnrealObjectPath("/Game/Aki/Scene/NewGacha/BP/BPI_Gacha.BPI_Gacha_C")]
	public interface IBPI_Gacha_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601DA41 RID: 121409 RVA: 0x008FD884 File Offset: 0x008FBA84
		[SkipLocalsInit]
		unsafe void ShowroomStart(int Frame, float Subtime)
		{
			IBPI_Gacha_C.__ShowroomStart_FunctionParams* ptr = stackalloc IBPI_Gacha_C.__ShowroomStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_Gacha_C.__ShowroomStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Gacha_C_ReflectionImplementationFields.__ShowroomStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Gacha_C_ReflectionImplementationFields.__ShowroomStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA42 RID: 121410 RVA: 0x008FD8D4 File Offset: 0x008FBAD4
		[SkipLocalsInit]
		unsafe void OutroStart(int Frame, float Subtime)
		{
			IBPI_Gacha_C.__OutroStart_FunctionParams* ptr = stackalloc IBPI_Gacha_C.__OutroStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_Gacha_C.__OutroStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Gacha_C_ReflectionImplementationFields.__OutroStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Gacha_C_ReflectionImplementationFields.__OutroStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA43 RID: 121411 RVA: 0x008FD924 File Offset: 0x008FBB24
		[SkipLocalsInit]
		unsafe void InteractStart(int Frame, float Subtime)
		{
			IBPI_Gacha_C.__InteractStart_FunctionParams* ptr = stackalloc IBPI_Gacha_C.__InteractStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_Gacha_C.__InteractStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Gacha_C_ReflectionImplementationFields.__InteractStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Gacha_C_ReflectionImplementationFields.__InteractStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA44 RID: 121412 RVA: 0x008FD974 File Offset: 0x008FBB74
		[SkipLocalsInit]
		unsafe void IntroStart(int Frame, float Subtime)
		{
			IBPI_Gacha_C.__IntroStart_FunctionParams* ptr = stackalloc IBPI_Gacha_C.__IntroStart_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(IBPI_Gacha_C.__IntroStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_Gacha_C_ReflectionImplementationFields.__IntroStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Frame = Frame;
			ptr->Subtime = Subtime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_Gacha_C_ReflectionImplementationFields.__IntroStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0400F9F7 RID: 63991
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BPI_Gacha.BPI_Gacha_C";

		// Token: 0x02008D6E RID: 36206
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ShowroomStart_FunctionParams
		{
			// Token: 0x0402C91A RID: 182554
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x0402C91B RID: 182555
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02008D6F RID: 36207
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OutroStart_FunctionParams
		{
			// Token: 0x0402C91C RID: 182556
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x0402C91D RID: 182557
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02008D70 RID: 36208
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __InteractStart_FunctionParams
		{
			// Token: 0x0402C91E RID: 182558
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x0402C91F RID: 182559
			[FieldOffset(4)]
			public float Subtime;
		}

		// Token: 0x02008D71 RID: 36209
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __IntroStart_FunctionParams
		{
			// Token: 0x0402C920 RID: 182560
			[FieldOffset(0)]
			public int Frame;

			// Token: 0x0402C921 RID: 182561
			[FieldOffset(4)]
			public float Subtime;
		}
	}
}
