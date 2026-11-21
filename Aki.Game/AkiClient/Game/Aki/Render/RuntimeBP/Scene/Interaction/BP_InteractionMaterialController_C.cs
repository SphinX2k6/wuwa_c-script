using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interaction
{
	// Token: 0x020030BC RID: 12476
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionMaterialController.BP_InteractionMaterialController_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class BP_InteractionMaterialController_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DFA7 RID: 122791 RVA: 0x009079B3 File Offset: 0x00905BB3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractionMaterialController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionMaterialController.BP_InteractionMaterialController_C");
			}
			return BP_InteractionMaterialController_C._ClassPtr;
		}

		// Token: 0x0601DFA8 RID: 122792 RVA: 0x009079D8 File Offset: 0x00905BD8
		public BP_InteractionMaterialController_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractionMaterialController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DFA9 RID: 122793 RVA: 0x00907A00 File Offset: 0x00905C00
		public BP_InteractionMaterialController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractionMaterialController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x0601DFAA RID: 122794 RVA: 0x00907A33 File Offset: 0x00905C33
		// (set) Token: 0x0601DFAB RID: 122795 RVA: 0x00907A47 File Offset: 0x00905C47
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionMaterialController_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractionMaterialController_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x0601DFAC RID: 122796 RVA: 0x00907A5C File Offset: 0x00905C5C
		// (set) Token: 0x0601DFAD RID: 122797 RVA: 0x00907A6C File Offset: 0x00905C6C
		public unsafe float Float
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_Float);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_Float) = value;
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x0601DFAE RID: 122798 RVA: 0x00907A7D File Offset: 0x00905C7D
		// (set) Token: 0x0601DFAF RID: 122799 RVA: 0x00907A91 File Offset: 0x00905C91
		public unsafe string ScalarName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_ScalarName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_ScalarName)), value);
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0601DFB0 RID: 122800 RVA: 0x00907AA8 File Offset: 0x00905CA8
		// (set) Token: 0x0601DFB1 RID: 122801 RVA: 0x00907AE1 File Offset: 0x00905CE1
		public TArray<AActor> Actor
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Actor) == null)
				{
					result = (this._Actor = new TArray<AActor>(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_Actor, this));
				}
				return result;
			}
			set
			{
				this.Actor.CopyAssign(value);
			}
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0601DFB2 RID: 122802 RVA: 0x00907AEF File Offset: 0x00905CEF
		// (set) Token: 0x0601DFB3 RID: 122803 RVA: 0x00907B03 File Offset: 0x00905D03
		public unsafe string VectorName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_VectorName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_VectorName)), value);
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0601DFB4 RID: 122804 RVA: 0x00907B18 File Offset: 0x00905D18
		// (set) Token: 0x0601DFB5 RID: 122805 RVA: 0x00907B2C File Offset: 0x00905D2C
		public unsafe FLinearColor Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractionMaterialController_C.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x0601DFB6 RID: 122806 RVA: 0x00907B44 File Offset: 0x00905D44
		[SkipLocalsInit]
		public unsafe virtual void ChangeVectorParameter(FLinearColor VectorParameter, string VectorParameterName)
		{
			BP_InteractionMaterialController_C.__ChangeVectorParameter_FunctionParams* ptr = stackalloc BP_InteractionMaterialController_C.__ChangeVectorParameter_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_InteractionMaterialController_C.__ChangeVectorParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionMaterialController_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->VectorParameter = VectorParameter;
			FString.CopyFrom((void*)(&ptr->VectorParameterName), VectorParameterName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_InteractionMaterialController_C.__ChangeVectorParameter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFB7 RID: 122807 RVA: 0x00907BA8 File Offset: 0x00905DA8
		[SkipLocalsInit]
		public unsafe virtual void ChangeScalarParameter(float FloatParameter, string FloatParameterName)
		{
			BP_InteractionMaterialController_C.__ChangeScalarParameter_FunctionParams* ptr = stackalloc BP_InteractionMaterialController_C.__ChangeScalarParameter_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_InteractionMaterialController_C.__ChangeScalarParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractionMaterialController_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FloatParameter = FloatParameter;
			FString.CopyFrom((void*)(&ptr->FloatParameterName), FloatParameterName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_InteractionMaterialController_C.__ChangeScalarParameter_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DFB8 RID: 122808 RVA: 0x00907C0C File Offset: 0x00905E0C
		[SkipLocalsInit]
		public virtual void ForEach()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ForEach_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFB9 RID: 122809 RVA: 0x00907C20 File Offset: 0x00905E20
		[SkipLocalsInit]
		public virtual void Test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__Test_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFBA RID: 122810 RVA: 0x00907C34 File Offset: 0x00905E34
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFBB RID: 122811 RVA: 0x00907C48 File Offset: 0x00905E48
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractionMaterialController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DFBC RID: 122812 RVA: 0x00907C5C File Offset: 0x00905E5C
		protected BP_InteractionMaterialController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD72 RID: 64882
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Interaction/BP_InteractionMaterialController.BP_InteractionMaterialController_C";

		// Token: 0x0400FD73 RID: 64883
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD74 RID: 64884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD75 RID: 64885
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FD76 RID: 64886
		internal static int __PropertyOffset_Float;

		// Token: 0x0400FD77 RID: 64887
		internal static int __PropertyOffset_ScalarName;

		// Token: 0x0400FD78 RID: 64888
		internal static int __PropertyOffset_Actor;

		// Token: 0x0400FD79 RID: 64889
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Actor;

		// Token: 0x0400FD7A RID: 64890
		internal static int __PropertyOffset_VectorName;

		// Token: 0x0400FD7B RID: 64891
		internal static int __PropertyOffset_Vector;

		// Token: 0x0400FD7C RID: 64892
		private static IntPtr __ChangeVectorParameter_NativeFunctionPtr;

		// Token: 0x0400FD7D RID: 64893
		private static IntPtr __ChangeScalarParameter_NativeFunctionPtr;

		// Token: 0x0400FD7E RID: 64894
		private static IntPtr __ForEach_NativeFunctionPtr;

		// Token: 0x0400FD7F RID: 64895
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x0400FD80 RID: 64896
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008DFD RID: 36349
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __ChangeVectorParameter_FunctionParams
		{
			// Token: 0x0402CA23 RID: 182819
			[FieldOffset(0)]
			public FLinearColor VectorParameter;

			// Token: 0x0402CA24 RID: 182820
			[FieldOffset(16)]
			public FString VectorParameterName;
		}

		// Token: 0x02008DFE RID: 36350
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __ChangeScalarParameter_FunctionParams
		{
			// Token: 0x0402CA25 RID: 182821
			[FieldOffset(0)]
			public float FloatParameter;

			// Token: 0x0402CA26 RID: 182822
			[FieldOffset(8)]
			public FString FloatParameterName;
		}
	}
}
