using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Drawers
{
	// Token: 0x02003AB4 RID: 15028
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawComponent_Snow.BP_TrailDrawComponent_Snow_C")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 710)]
	public class BP_TrailDrawComponent_Snow_C : BP_TrailDrawComponent_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020385 RID: 131973 RVA: 0x008CCF24 File Offset: 0x008CB124
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailDrawComponent_Snow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawComponent_Snow.BP_TrailDrawComponent_Snow_C");
			}
			return BP_TrailDrawComponent_Snow_C._ClassPtr;
		}

		// Token: 0x06020386 RID: 131974 RVA: 0x008CCF48 File Offset: 0x008CB148
		public BP_TrailDrawComponent_Snow_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawComponent_Snow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020387 RID: 131975 RVA: 0x008CCF70 File Offset: 0x008CB170
		[NullableContext(1)]
		public BP_TrailDrawComponent_Snow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawComponent_Snow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x06020388 RID: 131976 RVA: 0x008CCFA3 File Offset: 0x008CB1A3
		// (set) Token: 0x06020389 RID: 131977 RVA: 0x008CCFB7 File Offset: 0x008CB1B7
		public unsafe UTexture SignetTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_Snow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_Snow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x0602038A RID: 131978 RVA: 0x008CCFCC File Offset: 0x008CB1CC
		// (set) Token: 0x0602038B RID: 131979 RVA: 0x008CCFE0 File Offset: 0x008CB1E0
		public unsafe AActor father
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_Snow_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_Snow_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0602038C RID: 131980 RVA: 0x008CCFF5 File Offset: 0x008CB1F5
		// (set) Token: 0x0602038D RID: 131981 RVA: 0x008CD009 File Offset: 0x008CB209
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0602038E RID: 131982 RVA: 0x008CD020 File Offset: 0x008CB220
		// (set) Token: 0x0602038F RID: 131983 RVA: 0x008CD059 File Offset: 0x008CB259
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
					result = (this._Object_Types = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_4, this));
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

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x06020390 RID: 131984 RVA: 0x008CD067 File Offset: 0x008CB267
		// (set) Token: 0x06020391 RID: 131985 RVA: 0x008CD077 File Offset: 0x008CB277
		public unsafe float SnowfieldThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x06020392 RID: 131986 RVA: 0x008CD088 File Offset: 0x008CB288
		// (set) Token: 0x06020393 RID: 131987 RVA: 0x008CD098 File Offset: 0x008CB298
		public unsafe bool UseBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x06020394 RID: 131988 RVA: 0x008CD0A9 File Offset: 0x008CB2A9
		// (set) Token: 0x06020395 RID: 131989 RVA: 0x008CD0B9 File Offset: 0x008CB2B9
		public unsafe bool IsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_Snow_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020396 RID: 131990 RVA: 0x008CD0CA File Offset: 0x008CB2CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_Snow_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06020397 RID: 131991 RVA: 0x008CD0DE File Offset: 0x008CB2DE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_Snow_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06020398 RID: 131992 RVA: 0x008CD0F2 File Offset: 0x008CB2F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_Snow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020399 RID: 131993 RVA: 0x008CD106 File Offset: 0x008CB306
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailDrawComponent_Snow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602039A RID: 131994 RVA: 0x008CD11C File Offset: 0x008CB31C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TrailDrawComponent_Snow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailDrawComponent_Snow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailDrawComponent_Snow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawComponent_Snow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_Snow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602039B RID: 131995 RVA: 0x008CD164 File Offset: 0x008CB364
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TrailDrawComponent_Snow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TrailDrawComponent_Snow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TrailDrawComponent_Snow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawComponent_Snow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TrailDrawComponent_Snow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602039C RID: 131996 RVA: 0x008CD1AB File Offset: 0x008CB3AB
		protected BP_TrailDrawComponent_Snow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F938 RID: 63800
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_TrailDrawComponent_Snow.BP_TrailDrawComponent_Snow_C";

		// Token: 0x0400F939 RID: 63801
		private static IntPtr _ClassPtr;

		// Token: 0x0400F93A RID: 63802
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F93B RID: 63803
		internal new static int __PropertyOffset_1;

		// Token: 0x0400F93C RID: 63804
		internal new static int __PropertyOffset_2;

		// Token: 0x0400F93D RID: 63805
		internal new static int __PropertyOffset_3;

		// Token: 0x0400F93E RID: 63806
		internal new static int __PropertyOffset_4;

		// Token: 0x0400F93F RID: 63807
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _Object_Types;

		// Token: 0x0400F940 RID: 63808
		internal new static int __PropertyOffset_5;

		// Token: 0x0400F941 RID: 63809
		internal new static int __PropertyOffset_6;

		// Token: 0x0400F942 RID: 63810
		internal static int __PropertyOffset_7;

		// Token: 0x0400F943 RID: 63811
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x0400F944 RID: 63812
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400F945 RID: 63813
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F946 RID: 63814
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B94 RID: 39828
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311E7 RID: 201191
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
