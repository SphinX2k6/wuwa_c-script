using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints
{
	// Token: 0x02003ACF RID: 15055
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_LandscapeThickSnow.BP_LandscapeThickSnow_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_LandscapeThickSnow_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060206F0 RID: 132848 RVA: 0x008D2914 File Offset: 0x008D0B14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LandscapeThickSnow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_LandscapeThickSnow.BP_LandscapeThickSnow_C");
			}
			return BP_LandscapeThickSnow_C._ClassPtr;
		}

		// Token: 0x060206F1 RID: 132849 RVA: 0x008D2938 File Offset: 0x008D0B38
		public BP_LandscapeThickSnow_C() : this(BuiltinUtils.AllocNativeUObject(BP_LandscapeThickSnow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060206F2 RID: 132850 RVA: 0x008D2960 File Offset: 0x008D0B60
		public BP_LandscapeThickSnow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LandscapeThickSnow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x060206F3 RID: 132851 RVA: 0x008D2993 File Offset: 0x008D0B93
		// (set) Token: 0x060206F4 RID: 132852 RVA: 0x008D29A7 File Offset: 0x008D0BA7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LandscapeThickSnow_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LandscapeThickSnow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x060206F5 RID: 132853 RVA: 0x008D29BC File Offset: 0x008D0BBC
		// (set) Token: 0x060206F6 RID: 132854 RVA: 0x008D29CC File Offset: 0x008D0BCC
		public unsafe bool IsSetHeightArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x060206F7 RID: 132855 RVA: 0x008D29DD File Offset: 0x008D0BDD
		// (set) Token: 0x060206F8 RID: 132856 RVA: 0x008D29ED File Offset: 0x008D0BED
		public unsafe float OriginWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x060206F9 RID: 132857 RVA: 0x008D29FE File Offset: 0x008D0BFE
		// (set) Token: 0x060206FA RID: 132858 RVA: 0x008D2A0E File Offset: 0x008D0C0E
		public unsafe float ThickSnowHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x060206FB RID: 132859 RVA: 0x008D2A1F File Offset: 0x008D0C1F
		// (set) Token: 0x060206FC RID: 132860 RVA: 0x008D2A33 File Offset: 0x008D0C33
		public unsafe string WorldHeightName_
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x060206FD RID: 132861 RVA: 0x008D2A48 File Offset: 0x008D0C48
		// (set) Token: 0x060206FE RID: 132862 RVA: 0x008D2A5C File Offset: 0x008D0C5C
		public unsafe string EdgeWidthName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_6)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_6)), value);
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x060206FF RID: 132863 RVA: 0x008D2A74 File Offset: 0x008D0C74
		// (set) Token: 0x06020700 RID: 132864 RVA: 0x008D2AAD File Offset: 0x008D0CAD
		public TSet<string> PhysicMaterialSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._PhysicMaterialSet) == null)
				{
					result = (this._PhysicMaterialSet = new TSet<string>(base.NativePtr + (IntPtr)BP_LandscapeThickSnow_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.PhysicMaterialSet.CopyAssign(value);
			}
		}

		// Token: 0x06020701 RID: 132865 RVA: 0x008D2ABB File Offset: 0x008D0CBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LandscapeThickSnow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020702 RID: 132866 RVA: 0x008D2ACF File Offset: 0x008D0CCF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LandscapeThickSnow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020703 RID: 132867 RVA: 0x008D2AE4 File Offset: 0x008D0CE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LandscapeThickSnow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LandscapeThickSnow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LandscapeThickSnow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LandscapeThickSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LandscapeThickSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020704 RID: 132868 RVA: 0x008D2B2C File Offset: 0x008D0D2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LandscapeThickSnow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LandscapeThickSnow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LandscapeThickSnow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LandscapeThickSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LandscapeThickSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020705 RID: 132869 RVA: 0x008D2B73 File Offset: 0x008D0D73
		protected BP_LandscapeThickSnow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB4A RID: 64330
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_LandscapeThickSnow.BP_LandscapeThickSnow_C";

		// Token: 0x0400FB4B RID: 64331
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB4C RID: 64332
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FB4D RID: 64333
		internal static int __PropertyOffset_1;

		// Token: 0x0400FB4E RID: 64334
		internal static int __PropertyOffset_2;

		// Token: 0x0400FB4F RID: 64335
		internal static int __PropertyOffset_3;

		// Token: 0x0400FB50 RID: 64336
		internal static int __PropertyOffset_4;

		// Token: 0x0400FB51 RID: 64337
		internal static int __PropertyOffset_5;

		// Token: 0x0400FB52 RID: 64338
		internal static int __PropertyOffset_6;

		// Token: 0x0400FB53 RID: 64339
		internal static int __PropertyOffset_7;

		// Token: 0x0400FB54 RID: 64340
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _PhysicMaterialSet;

		// Token: 0x0400FB55 RID: 64341
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FB56 RID: 64342
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009BB5 RID: 39861
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031233 RID: 201267
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
