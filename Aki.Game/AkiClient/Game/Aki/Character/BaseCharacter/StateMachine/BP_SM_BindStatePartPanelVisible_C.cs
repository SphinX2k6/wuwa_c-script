using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003395 RID: 13205
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePartPanelVisible.BP_SM_BindStatePartPanelVisible_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 65)]
	public class BP_SM_BindStatePartPanelVisible_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021818 RID: 137240 RVA: 0x00962768 File Offset: 0x00960968
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStatePartPanelVisible_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePartPanelVisible.BP_SM_BindStatePartPanelVisible_C");
			}
			return BP_SM_BindStatePartPanelVisible_C._ClassPtr;
		}

		// Token: 0x06021819 RID: 137241 RVA: 0x0096278C File Offset: 0x0096098C
		public BP_SM_BindStatePartPanelVisible_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStatePartPanelVisible_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602181A RID: 137242 RVA: 0x009627B4 File Offset: 0x009609B4
		public BP_SM_BindStatePartPanelVisible_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStatePartPanelVisible_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044AF RID: 17583
		// (get) Token: 0x0602181B RID: 137243 RVA: 0x009627E7 File Offset: 0x009609E7
		// (set) Token: 0x0602181C RID: 137244 RVA: 0x009627FB File Offset: 0x009609FB
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStatePartPanelVisible_C.__PropertyOffset_部位名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStatePartPanelVisible_C.__PropertyOffset_部位名)), value);
			}
		}

		// Token: 0x170044B0 RID: 17584
		// (get) Token: 0x0602181D RID: 137245 RVA: 0x00962810 File Offset: 0x00960A10
		// (set) Token: 0x0602181E RID: 137246 RVA: 0x00962820 File Offset: 0x00960A20
		public unsafe bool 状态条显示
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStatePartPanelVisible_C.__PropertyOffset_状态条显示) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStatePartPanelVisible_C.__PropertyOffset_状态条显示) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602181F RID: 137247 RVA: 0x00962831 File Offset: 0x00960A31
		protected BP_SM_BindStatePartPanelVisible_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401251C RID: 75036
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePartPanelVisible.BP_SM_BindStatePartPanelVisible_C";

		// Token: 0x0401251D RID: 75037
		private static IntPtr _ClassPtr;

		// Token: 0x0401251E RID: 75038
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401251F RID: 75039
		internal static int __PropertyOffset_部位名;

		// Token: 0x04012520 RID: 75040
		internal static int __PropertyOffset_状态条显示;
	}
}
