using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004369 RID: 17257
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneVisible.BP_SM_BindStateBoneVisible_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class BP_SM_BindStateBoneVisible_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBAA RID: 183210 RVA: 0x00A26FE5 File Offset: 0x00A251E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateBoneVisible_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneVisible.BP_SM_BindStateBoneVisible_C");
			}
			return BP_SM_BindStateBoneVisible_C._ClassPtr;
		}

		// Token: 0x0602CBAB RID: 183211 RVA: 0x00A2700C File Offset: 0x00A2520C
		public BP_SM_BindStateBoneVisible_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBoneVisible_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBAC RID: 183212 RVA: 0x00A27034 File Offset: 0x00A25234
		public BP_SM_BindStateBoneVisible_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateBoneVisible_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700709B RID: 28827
		// (get) Token: 0x0602CBAD RID: 183213 RVA: 0x00A27067 File Offset: 0x00A25267
		// (set) Token: 0x0602CBAE RID: 183214 RVA: 0x00A2707B File Offset: 0x00A2527B
		public unsafe string 骨骼名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateBoneVisible_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateBoneVisible_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700709C RID: 28828
		// (get) Token: 0x0602CBAF RID: 183215 RVA: 0x00A27090 File Offset: 0x00A25290
		// (set) Token: 0x0602CBB0 RID: 183216 RVA: 0x00A270A0 File Offset: 0x00A252A0
		public unsafe bool 显示
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateBoneVisible_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateBoneVisible_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CBB1 RID: 183217 RVA: 0x00A270B1 File Offset: 0x00A252B1
		protected BP_SM_BindStateBoneVisible_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017964 RID: 96612
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateBoneVisible.BP_SM_BindStateBoneVisible_C";

		// Token: 0x04017965 RID: 96613
		private static IntPtr _ClassPtr;

		// Token: 0x04017966 RID: 96614
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017967 RID: 96615
		internal static int __PropertyOffset_0;

		// Token: 0x04017968 RID: 96616
		internal static int __PropertyOffset_1;
	}
}
