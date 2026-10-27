using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004372 RID: 17266
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateMeshVisible.BP_SM_BindStateMeshVisible_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 66)]
	public class BP_SM_BindStateMeshVisible_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBE8 RID: 183272 RVA: 0x00A27724 File Offset: 0x00A25924
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateMeshVisible_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateMeshVisible.BP_SM_BindStateMeshVisible_C");
			}
			return BP_SM_BindStateMeshVisible_C._ClassPtr;
		}

		// Token: 0x0602CBE9 RID: 183273 RVA: 0x00A27748 File Offset: 0x00A25948
		public BP_SM_BindStateMeshVisible_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateMeshVisible_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBEA RID: 183274 RVA: 0x00A27770 File Offset: 0x00A25970
		public BP_SM_BindStateMeshVisible_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateMeshVisible_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070A8 RID: 28840
		// (get) Token: 0x0602CBEB RID: 183275 RVA: 0x00A277A3 File Offset: 0x00A259A3
		// (set) Token: 0x0602CBEC RID: 183276 RVA: 0x00A277B7 File Offset: 0x00A259B7
		public unsafe string Tag
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170070A9 RID: 28841
		// (get) Token: 0x0602CBED RID: 183277 RVA: 0x00A277CC File Offset: 0x00A259CC
		// (set) Token: 0x0602CBEE RID: 183278 RVA: 0x00A277DC File Offset: 0x00A259DC
		public unsafe bool 显示
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070AA RID: 28842
		// (get) Token: 0x0602CBEF RID: 183279 RVA: 0x00A277ED File Offset: 0x00A259ED
		// (set) Token: 0x0602CBF0 RID: 183280 RVA: 0x00A277FD File Offset: 0x00A259FD
		public unsafe bool 包含所有子节点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateMeshVisible_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CBF1 RID: 183281 RVA: 0x00A2780E File Offset: 0x00A25A0E
		protected BP_SM_BindStateMeshVisible_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017990 RID: 96656
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateMeshVisible.BP_SM_BindStateMeshVisible_C";

		// Token: 0x04017991 RID: 96657
		private static IntPtr _ClassPtr;

		// Token: 0x04017992 RID: 96658
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017993 RID: 96659
		internal static int __PropertyOffset_0;

		// Token: 0x04017994 RID: 96660
		internal static int __PropertyOffset_1;

		// Token: 0x04017995 RID: 96661
		internal static int __PropertyOffset_2;
	}
}
