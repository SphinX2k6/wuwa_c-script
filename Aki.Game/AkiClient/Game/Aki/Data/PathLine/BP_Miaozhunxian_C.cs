using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x020031A7 RID: 12711
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_Miaozhunxian.BP_Miaozhunxian_C")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1113)]
	public class BP_Miaozhunxian_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F61B RID: 128539 RVA: 0x0092C829 File Offset: 0x0092AA29
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Miaozhunxian_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_Miaozhunxian.BP_Miaozhunxian_C");
			}
			return BP_Miaozhunxian_C._ClassPtr;
		}

		// Token: 0x0601F61C RID: 128540 RVA: 0x0092C850 File Offset: 0x0092AA50
		public BP_Miaozhunxian_C() : this(BuiltinUtils.AllocNativeUObject(BP_Miaozhunxian_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F61D RID: 128541 RVA: 0x0092C878 File Offset: 0x0092AA78
		[NullableContext(1)]
		public BP_Miaozhunxian_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Miaozhunxian_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0601F61E RID: 128542 RVA: 0x0092C8AB File Offset: 0x0092AAAB
		// (set) Token: 0x0601F61F RID: 128543 RVA: 0x0092C8BF File Offset: 0x0092AABF
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_Spline);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0601F620 RID: 128544 RVA: 0x0092C8D4 File Offset: 0x0092AAD4
		// (set) Token: 0x0601F621 RID: 128545 RVA: 0x0092C8E8 File Offset: 0x0092AAE8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0601F622 RID: 128546 RVA: 0x0092C8FD File Offset: 0x0092AAFD
		// (set) Token: 0x0601F623 RID: 128547 RVA: 0x0092C911 File Offset: 0x0092AB11
		public unsafe UStaticMesh BasicStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_BasicStaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Miaozhunxian_C.__PropertyOffset_BasicStaticMesh, value);
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0601F624 RID: 128548 RVA: 0x0092C926 File Offset: 0x0092AB26
		// (set) Token: 0x0601F625 RID: 128549 RVA: 0x0092C936 File Offset: 0x0092AB36
		public unsafe float SamplingNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_SamplingNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_SamplingNum) = value;
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0601F626 RID: 128550 RVA: 0x0092C948 File Offset: 0x0092AB48
		// (set) Token: 0x0601F627 RID: 128551 RVA: 0x0092C981 File Offset: 0x0092AB81
		[Nullable(1)]
		public TArray<UStaticMeshComponent> BasicStaticMeshs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._BasicStaticMeshs) == null)
				{
					result = (this._BasicStaticMeshs = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_BasicStaticMeshs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BasicStaticMeshs.CopyAssign(value);
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0601F628 RID: 128552 RVA: 0x0092C98F File Offset: 0x0092AB8F
		// (set) Token: 0x0601F629 RID: 128553 RVA: 0x0092C99F File Offset: 0x0092AB9F
		public unsafe bool Showing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_Showing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Miaozhunxian_C.__PropertyOffset_Showing) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F62A RID: 128554 RVA: 0x0092C9B0 File Offset: 0x0092ABB0
		[SkipLocalsInit]
		public virtual void ShowMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__ShowMesh_NativeFunctionPtr, null);
		}

		// Token: 0x0601F62B RID: 128555 RVA: 0x0092C9C4 File Offset: 0x0092ABC4
		[SkipLocalsInit]
		public virtual void HideMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__HideMesh_NativeFunctionPtr, null);
		}

		// Token: 0x0601F62C RID: 128556 RVA: 0x0092C9D8 File Offset: 0x0092ABD8
		[SkipLocalsInit]
		public virtual void UpdateMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__UpdateMesh_NativeFunctionPtr, null);
		}

		// Token: 0x0601F62D RID: 128557 RVA: 0x0092C9EC File Offset: 0x0092ABEC
		[SkipLocalsInit]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x0601F62E RID: 128558 RVA: 0x0092CA00 File Offset: 0x0092AC00
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F62F RID: 128559 RVA: 0x0092CA14 File Offset: 0x0092AC14
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Miaozhunxian_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601F630 RID: 128560 RVA: 0x0092CA28 File Offset: 0x0092AC28
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Miaozhunxian_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Miaozhunxian_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Miaozhunxian_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Miaozhunxian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Miaozhunxian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F631 RID: 128561 RVA: 0x0092CA70 File Offset: 0x0092AC70
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Miaozhunxian_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Miaozhunxian_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Miaozhunxian_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Miaozhunxian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Miaozhunxian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F632 RID: 128562 RVA: 0x0092CAB6 File Offset: 0x0092ACB6
		protected BP_Miaozhunxian_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D21 RID: 68897
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_Miaozhunxian.BP_Miaozhunxian_C";

		// Token: 0x04010D22 RID: 68898
		private static IntPtr _ClassPtr;

		// Token: 0x04010D23 RID: 68899
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D24 RID: 68900
		internal static int __PropertyOffset_Spline;

		// Token: 0x04010D25 RID: 68901
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010D26 RID: 68902
		internal static int __PropertyOffset_BasicStaticMesh;

		// Token: 0x04010D27 RID: 68903
		internal static int __PropertyOffset_SamplingNum;

		// Token: 0x04010D28 RID: 68904
		internal static int __PropertyOffset_BasicStaticMeshs;

		// Token: 0x04010D29 RID: 68905
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _BasicStaticMeshs;

		// Token: 0x04010D2A RID: 68906
		internal static int __PropertyOffset_Showing;

		// Token: 0x04010D2B RID: 68907
		private static IntPtr __ShowMesh_NativeFunctionPtr;

		// Token: 0x04010D2C RID: 68908
		private static IntPtr __HideMesh_NativeFunctionPtr;

		// Token: 0x04010D2D RID: 68909
		private static IntPtr __UpdateMesh_NativeFunctionPtr;

		// Token: 0x04010D2E RID: 68910
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04010D2F RID: 68911
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010D30 RID: 68912
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008F23 RID: 36643
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CC55 RID: 183381
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
