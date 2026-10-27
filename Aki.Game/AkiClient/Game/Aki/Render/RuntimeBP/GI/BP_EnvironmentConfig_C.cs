using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D2B RID: 15659
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_EnvironmentConfig.BP_EnvironmentConfig_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class BP_EnvironmentConfig_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025B04 RID: 154372 RVA: 0x009606D0 File Offset: 0x0095E8D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EnvironmentConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_EnvironmentConfig.BP_EnvironmentConfig_C");
			}
			return BP_EnvironmentConfig_C._ClassPtr;
		}

		// Token: 0x06025B05 RID: 154373 RVA: 0x009606F4 File Offset: 0x0095E8F4
		public BP_EnvironmentConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_EnvironmentConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025B06 RID: 154374 RVA: 0x0096071C File Offset: 0x0095E91C
		public BP_EnvironmentConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EnvironmentConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004E12 RID: 19986
		// (get) Token: 0x06025B07 RID: 154375 RVA: 0x0096074F File Offset: 0x0095E94F
		// (set) Token: 0x06025B08 RID: 154376 RVA: 0x00960763 File Offset: 0x0095E963
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EnvironmentConfig_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EnvironmentConfig_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004E13 RID: 19987
		// (get) Token: 0x06025B09 RID: 154377 RVA: 0x00960778 File Offset: 0x0095E978
		// (set) Token: 0x06025B0A RID: 154378 RVA: 0x009607B1 File Offset: 0x0095E9B1
		public TArray<string> BeginCommandList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._BeginCommandList) == null)
				{
					result = (this._BeginCommandList = new TArray<string>(base.NativePtr + (IntPtr)BP_EnvironmentConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.BeginCommandList.CopyAssign(value);
			}
		}

		// Token: 0x17004E14 RID: 19988
		// (get) Token: 0x06025B0B RID: 154379 RVA: 0x009607C0 File Offset: 0x0095E9C0
		// (set) Token: 0x06025B0C RID: 154380 RVA: 0x009607F9 File Offset: 0x0095E9F9
		public TArray<string> EndCommandList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._EndCommandList) == null)
				{
					result = (this._EndCommandList = new TArray<string>(base.NativePtr + (IntPtr)BP_EnvironmentConfig_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.EndCommandList.CopyAssign(value);
			}
		}

		// Token: 0x06025B0D RID: 154381 RVA: 0x00960807 File Offset: 0x0095EA07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EnvironmentConfig_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025B0E RID: 154382 RVA: 0x0096081B File Offset: 0x0095EA1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EnvironmentConfig_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025B0F RID: 154383 RVA: 0x00960830 File Offset: 0x0095EA30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_EnvironmentConfig_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_EnvironmentConfig_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EnvironmentConfig_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EnvironmentConfig_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EnvironmentConfig_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025B10 RID: 154384 RVA: 0x0096087C File Offset: 0x0095EA7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_EnvironmentConfig_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_EnvironmentConfig_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_EnvironmentConfig_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EnvironmentConfig_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EnvironmentConfig_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025B11 RID: 154385 RVA: 0x009608C8 File Offset: 0x0095EAC8
		protected BP_EnvironmentConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012D3A RID: 77114
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_EnvironmentConfig.BP_EnvironmentConfig_C";

		// Token: 0x04012D3B RID: 77115
		private static IntPtr _ClassPtr;

		// Token: 0x04012D3C RID: 77116
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012D3D RID: 77117
		internal static int __PropertyOffset_1;

		// Token: 0x04012D3E RID: 77118
		internal static int __PropertyOffset_2;

		// Token: 0x04012D3F RID: 77119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _BeginCommandList;

		// Token: 0x04012D40 RID: 77120
		internal static int __PropertyOffset_3;

		// Token: 0x04012D41 RID: 77121
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _EndCommandList;

		// Token: 0x04012D42 RID: 77122
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012D43 RID: 77123
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A024 RID: 40996
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031ACD RID: 203469
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
