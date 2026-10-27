using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003ADA RID: 15066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_MobileDeviceConsole.BP_MobileDeviceConsole_C")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1105)]
	public class BP_MobileDeviceConsole_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020885 RID: 133253 RVA: 0x008D55C5 File Offset: 0x008D37C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MobileDeviceConsole_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_MobileDeviceConsole.BP_MobileDeviceConsole_C");
			}
			return BP_MobileDeviceConsole_C._ClassPtr;
		}

		// Token: 0x06020886 RID: 133254 RVA: 0x008D55EC File Offset: 0x008D37EC
		public BP_MobileDeviceConsole_C() : this(BuiltinUtils.AllocNativeUObject(BP_MobileDeviceConsole_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020887 RID: 133255 RVA: 0x008D5614 File Offset: 0x008D3814
		public BP_MobileDeviceConsole_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MobileDeviceConsole_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700313B RID: 12603
		// (get) Token: 0x06020888 RID: 133256 RVA: 0x008D5647 File Offset: 0x008D3847
		// (set) Token: 0x06020889 RID: 133257 RVA: 0x008D565B File Offset: 0x008D385B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MobileDeviceConsole_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MobileDeviceConsole_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700313C RID: 12604
		// (get) Token: 0x0602088A RID: 133258 RVA: 0x008D5670 File Offset: 0x008D3870
		// (set) Token: 0x0602088B RID: 133259 RVA: 0x008D5680 File Offset: 0x008D3880
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0602088C RID: 133260 RVA: 0x008D5691 File Offset: 0x008D3891
		// (set) Token: 0x0602088D RID: 133261 RVA: 0x008D56A1 File Offset: 0x008D38A1
		public unsafe int NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700313E RID: 12606
		// (get) Token: 0x0602088E RID: 133262 RVA: 0x008D56B2 File Offset: 0x008D38B2
		// (set) Token: 0x0602088F RID: 133263 RVA: 0x008D56C6 File Offset: 0x008D38C6
		public unsafe string Command
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x06020890 RID: 133264 RVA: 0x008D56DC File Offset: 0x008D38DC
		// (set) Token: 0x06020891 RID: 133265 RVA: 0x008D5715 File Offset: 0x008D3915
		public TArray<string> TargetMobileDevice
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._TargetMobileDevice) == null)
				{
					result = (this._TargetMobileDevice = new TArray<string>(base.NativePtr + (IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.TargetMobileDevice.CopyAssign(value);
			}
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x06020892 RID: 133266 RVA: 0x008D5723 File Offset: 0x008D3923
		// (set) Token: 0x06020893 RID: 133267 RVA: 0x008D5733 File Offset: 0x008D3933
		public unsafe bool IsTargetDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MobileDeviceConsole_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020894 RID: 133268 RVA: 0x008D5744 File Offset: 0x008D3944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MobileDeviceConsole_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020895 RID: 133269 RVA: 0x008D5758 File Offset: 0x008D3958
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MobileDeviceConsole_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020896 RID: 133270 RVA: 0x008D5770 File Offset: 0x008D3970
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_MobileDeviceConsole_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MobileDeviceConsole_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MobileDeviceConsole_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MobileDeviceConsole_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MobileDeviceConsole_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020897 RID: 133271 RVA: 0x008D57BC File Offset: 0x008D39BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_MobileDeviceConsole_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_MobileDeviceConsole_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_MobileDeviceConsole_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MobileDeviceConsole_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MobileDeviceConsole_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020898 RID: 133272 RVA: 0x008D5808 File Offset: 0x008D3A08
		protected BP_MobileDeviceConsole_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC39 RID: 64569
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_MobileDeviceConsole.BP_MobileDeviceConsole_C";

		// Token: 0x0400FC3A RID: 64570
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC3B RID: 64571
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC3C RID: 64572
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC3D RID: 64573
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC3E RID: 64574
		internal static int __PropertyOffset_3;

		// Token: 0x0400FC3F RID: 64575
		internal static int __PropertyOffset_4;

		// Token: 0x0400FC40 RID: 64576
		internal static int __PropertyOffset_5;

		// Token: 0x0400FC41 RID: 64577
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _TargetMobileDevice;

		// Token: 0x0400FC42 RID: 64578
		internal static int __PropertyOffset_6;

		// Token: 0x0400FC43 RID: 64579
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC44 RID: 64580
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009BD3 RID: 39891
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031265 RID: 201317
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
