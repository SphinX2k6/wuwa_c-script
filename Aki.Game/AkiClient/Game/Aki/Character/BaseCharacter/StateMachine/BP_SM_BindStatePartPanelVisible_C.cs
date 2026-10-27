using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004374 RID: 17268
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePartPanelVisible.BP_SM_BindStatePartPanelVisible_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class BP_SM_BindStatePartPanelVisible_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBFA RID: 183290 RVA: 0x00A27914 File Offset: 0x00A25B14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStatePartPanelVisible_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePartPanelVisible.BP_SM_BindStatePartPanelVisible_C");
			}
			return BP_SM_BindStatePartPanelVisible_C._ClassPtr;
		}

		// Token: 0x0602CBFB RID: 183291 RVA: 0x00A27938 File Offset: 0x00A25B38
		public BP_SM_BindStatePartPanelVisible_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStatePartPanelVisible_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBFC RID: 183292 RVA: 0x00A27960 File Offset: 0x00A25B60
		public BP_SM_BindStatePartPanelVisible_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStatePartPanelVisible_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070AD RID: 28845
		// (get) Token: 0x0602CBFD RID: 183293 RVA: 0x00A27993 File Offset: 0x00A25B93
		// (set) Token: 0x0602CBFE RID: 183294 RVA: 0x00A279A7 File Offset: 0x00A25BA7
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStatePartPanelVisible_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStatePartPanelVisible_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170070AE RID: 28846
		// (get) Token: 0x0602CBFF RID: 183295 RVA: 0x00A279BC File Offset: 0x00A25BBC
		// (set) Token: 0x0602CC00 RID: 183296 RVA: 0x00A279CC File Offset: 0x00A25BCC
		public unsafe bool 状态条显示
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStatePartPanelVisible_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStatePartPanelVisible_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CC01 RID: 183297 RVA: 0x00A279DD File Offset: 0x00A25BDD
		protected BP_SM_BindStatePartPanelVisible_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401799B RID: 96667
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePartPanelVisible.BP_SM_BindStatePartPanelVisible_C";

		// Token: 0x0401799C RID: 96668
		private static IntPtr _ClassPtr;

		// Token: 0x0401799D RID: 96669
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401799E RID: 96670
		internal static int __PropertyOffset_0;

		// Token: 0x0401799F RID: 96671
		internal static int __PropertyOffset_1;
	}
}
