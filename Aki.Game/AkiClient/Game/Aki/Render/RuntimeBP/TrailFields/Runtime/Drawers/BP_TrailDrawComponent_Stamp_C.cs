using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Drawers
{
	// Token: 0x02003AB5 RID: 15029
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawComponent_Stamp.BP_TrailDrawComponent_Stamp_C")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 709)]
	public class BP_TrailDrawComponent_Stamp_C : BP_TrailDrawComponent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602039D RID: 131997 RVA: 0x008CD1B4 File Offset: 0x008CB3B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailDrawComponent_Stamp_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawComponent_Stamp.BP_TrailDrawComponent_Stamp_C");
			}
			return BP_TrailDrawComponent_Stamp_C._ClassPtr;
		}

		// Token: 0x0602039E RID: 131998 RVA: 0x008CD1D8 File Offset: 0x008CB3D8
		public BP_TrailDrawComponent_Stamp_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawComponent_Stamp_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602039F RID: 131999 RVA: 0x008CD200 File Offset: 0x008CB400
		[NullableContext(1)]
		public BP_TrailDrawComponent_Stamp_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawComponent_Stamp_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x060203A0 RID: 132000 RVA: 0x008CD233 File Offset: 0x008CB433
		// (set) Token: 0x060203A1 RID: 132001 RVA: 0x008CD247 File Offset: 0x008CB447
		public unsafe UTexture SignetTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_Stamp_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_Stamp_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x060203A2 RID: 132002 RVA: 0x008CD25C File Offset: 0x008CB45C
		// (set) Token: 0x060203A3 RID: 132003 RVA: 0x008CD270 File Offset: 0x008CB470
		public unsafe AActor father
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_Stamp_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_Stamp_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x060203A4 RID: 132004 RVA: 0x008CD285 File Offset: 0x008CB485
		// (set) Token: 0x060203A5 RID: 132005 RVA: 0x008CD299 File Offset: 0x008CB499
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Stamp_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Stamp_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x060203A6 RID: 132006 RVA: 0x008CD2B0 File Offset: 0x008CB4B0
		// (set) Token: 0x060203A7 RID: 132007 RVA: 0x008CD2E9 File Offset: 0x008CB4E9
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> Object_Types
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._Object_Types) == null)
				{
					result = (this._Object_Types = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Stamp_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Object_Types.CopyAssign(value);
			}
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x060203A8 RID: 132008 RVA: 0x008CD2F7 File Offset: 0x008CB4F7
		// (set) Token: 0x060203A9 RID: 132009 RVA: 0x008CD307 File Offset: 0x008CB507
		public unsafe float SnowfieldThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Stamp_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Stamp_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x060203AA RID: 132010 RVA: 0x008CD318 File Offset: 0x008CB518
		// (set) Token: 0x060203AB RID: 132011 RVA: 0x008CD328 File Offset: 0x008CB528
		public unsafe bool UseBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Stamp_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Stamp_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x060203AC RID: 132012 RVA: 0x008CD33C File Offset: 0x008CB53C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TrailDrawComponent_Stamp_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailDrawComponent_Stamp_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailDrawComponent_Stamp_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawComponent_Stamp_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_Stamp_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060203AD RID: 132013 RVA: 0x008CD384 File Offset: 0x008CB584
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TrailDrawComponent_Stamp_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailDrawComponent_Stamp_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailDrawComponent_Stamp_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawComponent_Stamp_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailDrawComponent_Stamp_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060203AE RID: 132014 RVA: 0x008CD3CB File Offset: 0x008CB5CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_Stamp_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060203AF RID: 132015 RVA: 0x008CD3DF File Offset: 0x008CB5DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailDrawComponent_Stamp_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060203B0 RID: 132016 RVA: 0x008CD3F4 File Offset: 0x008CB5F4
		protected BP_TrailDrawComponent_Stamp_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F947 RID: 63815
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawComponent_Stamp.BP_TrailDrawComponent_Stamp_C";

		// Token: 0x0400F948 RID: 63816
		private static IntPtr _ClassPtr;

		// Token: 0x0400F949 RID: 63817
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F94A RID: 63818
		internal new static int __PropertyOffset_1;

		// Token: 0x0400F94B RID: 63819
		internal new static int __PropertyOffset_2;

		// Token: 0x0400F94C RID: 63820
		internal new static int __PropertyOffset_3;

		// Token: 0x0400F94D RID: 63821
		internal new static int __PropertyOffset_4;

		// Token: 0x0400F94E RID: 63822
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _Object_Types;

		// Token: 0x0400F94F RID: 63823
		internal new static int __PropertyOffset_5;

		// Token: 0x0400F950 RID: 63824
		internal new static int __PropertyOffset_6;

		// Token: 0x0400F951 RID: 63825
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F952 RID: 63826
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009B95 RID: 39829
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311E8 RID: 201192
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
