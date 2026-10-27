using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AF9 RID: 15097
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CharacterPostOutline.BP_CharacterPostOutline_C")]
	[UnrealStructLayout(1768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1768)]
	public class BP_CharacterPostOutline_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B86 RID: 134022 RVA: 0x008DB691 File Offset: 0x008D9891
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterPostOutline_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CharacterPostOutline.BP_CharacterPostOutline_C");
			}
			return BP_CharacterPostOutline_C._ClassPtr;
		}

		// Token: 0x06020B87 RID: 134023 RVA: 0x008DB6B8 File Offset: 0x008D98B8
		public BP_CharacterPostOutline_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterPostOutline_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B88 RID: 134024 RVA: 0x008DB6E0 File Offset: 0x008D98E0
		[NullableContext(1)]
		public BP_CharacterPostOutline_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterPostOutline_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x06020B89 RID: 134025 RVA: 0x008DB713 File Offset: 0x008D9913
		// (set) Token: 0x06020B8A RID: 134026 RVA: 0x008DB727 File Offset: 0x008D9927
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x06020B8B RID: 134027 RVA: 0x008DB73C File Offset: 0x008D993C
		// (set) Token: 0x06020B8C RID: 134028 RVA: 0x008DB750 File Offset: 0x008D9950
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x06020B8D RID: 134029 RVA: 0x008DB765 File Offset: 0x008D9965
		// (set) Token: 0x06020B8E RID: 134030 RVA: 0x008DB779 File Offset: 0x008D9979
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x06020B8F RID: 134031 RVA: 0x008DB790 File Offset: 0x008D9990
		// (set) Token: 0x06020B90 RID: 134032 RVA: 0x008DB7C9 File Offset: 0x008D99C9
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_CharacterPostOutline_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x06020B91 RID: 134033 RVA: 0x008DB7D8 File Offset: 0x008D99D8
		// (set) Token: 0x06020B92 RID: 134034 RVA: 0x008DB811 File Offset: 0x008D9A11
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_CharacterPostOutline_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x06020B93 RID: 134035 RVA: 0x008DB820 File Offset: 0x008D9A20
		// (set) Token: 0x06020B94 RID: 134036 RVA: 0x008DB859 File Offset: 0x008D9A59
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_CharacterPostOutline_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x06020B95 RID: 134037 RVA: 0x008DB867 File Offset: 0x008D9A67
		// (set) Token: 0x06020B96 RID: 134038 RVA: 0x008DB87B File Offset: 0x008D9A7B
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x06020B97 RID: 134039 RVA: 0x008DB890 File Offset: 0x008D9A90
		// (set) Token: 0x06020B98 RID: 134040 RVA: 0x008DB8A0 File Offset: 0x008D9AA0
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterPostOutline_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterPostOutline_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x06020B99 RID: 134041 RVA: 0x008DB8B1 File Offset: 0x008D9AB1
		// (set) Token: 0x06020B9A RID: 134042 RVA: 0x008DB8C5 File Offset: 0x008D9AC5
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterPostOutline_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterPostOutline_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x06020B9B RID: 134043 RVA: 0x008DB8DA File Offset: 0x008D9ADA
		// (set) Token: 0x06020B9C RID: 134044 RVA: 0x008DB8EE File Offset: 0x008D9AEE
		public unsafe UTexture2D Tex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x06020B9D RID: 134045 RVA: 0x008DB903 File Offset: 0x008D9B03
		// (set) Token: 0x06020B9E RID: 134046 RVA: 0x008DB917 File Offset: 0x008D9B17
		public unsafe UTexture2D Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterPostOutline_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x06020B9F RID: 134047 RVA: 0x008DB92C File Offset: 0x008D9B2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterPostOutline_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06020BA0 RID: 134048 RVA: 0x008DB940 File Offset: 0x008D9B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterPostOutline_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020BA1 RID: 134049 RVA: 0x008DB954 File Offset: 0x008D9B54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterPostOutline_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020BA2 RID: 134050 RVA: 0x008DB969 File Offset: 0x008D9B69
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterPostOutline_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020BA3 RID: 134051 RVA: 0x008DB97D File Offset: 0x008D9B7D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterPostOutline_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020BA4 RID: 134052 RVA: 0x008DB994 File Offset: 0x008D9B94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CharacterPostOutline_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterPostOutline_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterPostOutline_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterPostOutline_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterPostOutline_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020BA5 RID: 134053 RVA: 0x008DB9DC File Offset: 0x008D9BDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CharacterPostOutline_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterPostOutline_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterPostOutline_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterPostOutline_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterPostOutline_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020BA6 RID: 134054 RVA: 0x008DBA23 File Offset: 0x008D9C23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterPostOutline_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020BA7 RID: 134055 RVA: 0x008DBA37 File Offset: 0x008D9C37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterPostOutline_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020BA8 RID: 134056 RVA: 0x008DBA4C File Offset: 0x008D9C4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CharacterPostOutline_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CharacterPostOutline_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterPostOutline_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterPostOutline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterPostOutline_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020BA9 RID: 134057 RVA: 0x008DBA94 File Offset: 0x008D9C94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CharacterPostOutline_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CharacterPostOutline_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterPostOutline_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterPostOutline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterPostOutline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020BAA RID: 134058 RVA: 0x008DBADB File Offset: 0x008D9CDB
		protected BP_CharacterPostOutline_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE36 RID: 65078
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CharacterPostOutline.BP_CharacterPostOutline_C";

		// Token: 0x0400FE37 RID: 65079
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE38 RID: 65080
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE39 RID: 65081
		internal static int __PropertyOffset_1;

		// Token: 0x0400FE3A RID: 65082
		internal static int __PropertyOffset_2;

		// Token: 0x0400FE3B RID: 65083
		internal static int __PropertyOffset_3;

		// Token: 0x0400FE3C RID: 65084
		internal static int __PropertyOffset_4;

		// Token: 0x0400FE3D RID: 65085
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0400FE3E RID: 65086
		internal static int __PropertyOffset_5;

		// Token: 0x0400FE3F RID: 65087
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0400FE40 RID: 65088
		internal static int __PropertyOffset_6;

		// Token: 0x0400FE41 RID: 65089
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0400FE42 RID: 65090
		internal static int __PropertyOffset_7;

		// Token: 0x0400FE43 RID: 65091
		internal static int __PropertyOffset_8;

		// Token: 0x0400FE44 RID: 65092
		internal static int __PropertyOffset_9;

		// Token: 0x0400FE45 RID: 65093
		internal static int __PropertyOffset_10;

		// Token: 0x0400FE46 RID: 65094
		internal static int __PropertyOffset_11;

		// Token: 0x0400FE47 RID: 65095
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0400FE48 RID: 65096
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FE49 RID: 65097
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE4A RID: 65098
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FE4B RID: 65099
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FE4C RID: 65100
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C2D RID: 39981
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312DD RID: 201437
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C2E RID: 39982
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312DE RID: 201438
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
