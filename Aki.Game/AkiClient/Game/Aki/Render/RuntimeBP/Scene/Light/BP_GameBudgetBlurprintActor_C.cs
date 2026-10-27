using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B04 RID: 15108
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_GameBudgetBlurprintActor.BP_GameBudgetBlurprintActor_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_GameBudgetBlurprintActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D61 RID: 134497 RVA: 0x008DE6AF File Offset: 0x008DC8AF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GameBudgetBlurprintActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_GameBudgetBlurprintActor.BP_GameBudgetBlurprintActor_C");
			}
			return BP_GameBudgetBlurprintActor_C._ClassPtr;
		}

		// Token: 0x06020D62 RID: 134498 RVA: 0x008DE6D4 File Offset: 0x008DC8D4
		public BP_GameBudgetBlurprintActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_GameBudgetBlurprintActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D63 RID: 134499 RVA: 0x008DE6FC File Offset: 0x008DC8FC
		[NullableContext(1)]
		public BP_GameBudgetBlurprintActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GameBudgetBlurprintActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x06020D64 RID: 134500 RVA: 0x008DE72F File Offset: 0x008DC92F
		// (set) Token: 0x06020D65 RID: 134501 RVA: 0x008DE743 File Offset: 0x008DC943
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GameBudgetBlurprintActor_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GameBudgetBlurprintActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06020D66 RID: 134502 RVA: 0x008DE758 File Offset: 0x008DC958
		protected BP_GameBudgetBlurprintActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF45 RID: 65349
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_GameBudgetBlurprintActor.BP_GameBudgetBlurprintActor_C";

		// Token: 0x0400FF46 RID: 65350
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF47 RID: 65351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF48 RID: 65352
		internal static int __PropertyOffset_0;
	}
}
