using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.CreatureTools;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Item
{
	// Token: 0x020032CC RID: 13004
	[UnrealObjectPath("/Game/Aki/Character/Item/BP_BaseItem.BP_BaseItem_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1100)]
	public class BP_BaseItem_C : __TsBaseItem_InheritProxy, IUnrealUObject, IUnrealObject, IBPI_CreatureInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06020F2A RID: 134954 RVA: 0x009533F7 File Offset: 0x009515F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseItem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Item/BP_BaseItem.BP_BaseItem_C");
			}
			return BP_BaseItem_C._ClassPtr;
		}

		// Token: 0x06020F2B RID: 134955 RVA: 0x0095341C File Offset: 0x0095161C
		public BP_BaseItem_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseItem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F2C RID: 134956 RVA: 0x00953444 File Offset: 0x00951644
		[NullableContext(1)]
		public BP_BaseItem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseItem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x06020F2D RID: 134957 RVA: 0x00953477 File Offset: 0x00951677
		// (set) Token: 0x06020F2E RID: 134958 RVA: 0x0095348B File Offset: 0x0095168B
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseItem_C.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseItem_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x06020F2F RID: 134959 RVA: 0x009534A0 File Offset: 0x009516A0
		// (set) Token: 0x06020F30 RID: 134960 RVA: 0x009534B4 File Offset: 0x009516B4
		[Nullable(2)]
		public unsafe USceneComponent Scene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseItem_C.__PropertyOffset_Scene);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BaseItem_C.__PropertyOffset_Scene, value);
			}
		}

		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x06020F31 RID: 134961 RVA: 0x009534C9 File Offset: 0x009516C9
		// (set) Token: 0x06020F32 RID: 134962 RVA: 0x009534D9 File Offset: 0x009516D9
		public unsafe int EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseItem_C.__PropertyOffset_EntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseItem_C.__PropertyOffset_EntityId) = value;
			}
		}

		// Token: 0x06020F33 RID: 134963 RVA: 0x009534EC File Offset: 0x009516EC
		[SkipLocalsInit]
		public unsafe virtual int GetEntityId()
		{
			BP_BaseItem_C.__GetEntityId_FunctionParams* ptr = stackalloc BP_BaseItem_C.__GetEntityId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseItem_C.__GetEntityId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseItem_C.__GetEntityId_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseItem_C.__GetEntityId_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020F34 RID: 134964 RVA: 0x00953534 File Offset: 0x00951734
		[SkipLocalsInit]
		public unsafe virtual void ApplyEntityId(int EntityId)
		{
			BP_BaseItem_C.__ApplyEntityId_FunctionParams* ptr = stackalloc BP_BaseItem_C.__ApplyEntityId_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseItem_C.__ApplyEntityId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseItem_C.__ApplyEntityId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseItem_C.__ApplyEntityId_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F35 RID: 134965 RVA: 0x0095357A File Offset: 0x0095177A
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseItem_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020F36 RID: 134966 RVA: 0x0095358E File Offset: 0x0095178E
		[SkipLocalsInit]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseItem_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020F37 RID: 134967 RVA: 0x009535A2 File Offset: 0x009517A2
		protected BP_BaseItem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D91 RID: 73105
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Item/BP_BaseItem.BP_BaseItem_C";

		// Token: 0x04011D92 RID: 73106
		private static IntPtr _ClassPtr;

		// Token: 0x04011D93 RID: 73107
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D94 RID: 73108
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04011D95 RID: 73109
		internal static int __PropertyOffset_Scene;

		// Token: 0x04011D96 RID: 73110
		internal static int __PropertyOffset_EntityId;

		// Token: 0x04011D97 RID: 73111
		private static IntPtr __GetEntityId_NativeFunctionPtr;

		// Token: 0x04011D98 RID: 73112
		private static IntPtr __ApplyEntityId_NativeFunctionPtr;

		// Token: 0x04011D99 RID: 73113
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008FEE RID: 36846
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetEntityId_FunctionParams
		{
			// Token: 0x0402CDA0 RID: 183712
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02008FEF RID: 36847
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ApplyEntityId_FunctionParams
		{
			// Token: 0x0402CDA1 RID: 183713
			[FieldOffset(0)]
			public int EntityId;
		}
	}
}
