using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.YangYangBirds
{
	// Token: 0x02003A76 RID: 14966
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangyangBirdssss_Skill.BP_YangyangBirdssss_Skill_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class BP_YangyangBirdssss_Skill_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB1A RID: 129818 RVA: 0x008BFEB1 File Offset: 0x008BE0B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_YangyangBirdssss_Skill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangyangBirdssss_Skill.BP_YangyangBirdssss_Skill_C");
			}
			return BP_YangyangBirdssss_Skill_C._ClassPtr;
		}

		// Token: 0x0601FB1B RID: 129819 RVA: 0x008BFED8 File Offset: 0x008BE0D8
		public BP_YangyangBirdssss_Skill_C() : this(BuiltinUtils.AllocNativeUObject(BP_YangyangBirdssss_Skill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB1C RID: 129820 RVA: 0x008BFF00 File Offset: 0x008BE100
		[NullableContext(1)]
		public BP_YangyangBirdssss_Skill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_YangyangBirdssss_Skill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x0601FB1D RID: 129821 RVA: 0x008BFF33 File Offset: 0x008BE133
		// (set) Token: 0x0601FB1E RID: 129822 RVA: 0x008BFF47 File Offset: 0x008BE147
		public unsafe UNiagaraComponent NS_YY_Birds_Skill
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangyangBirdssss_Skill_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangyangBirdssss_Skill_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x0601FB1F RID: 129823 RVA: 0x008BFF5C File Offset: 0x008BE15C
		// (set) Token: 0x0601FB20 RID: 129824 RVA: 0x008BFF70 File Offset: 0x008BE170
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangyangBirdssss_Skill_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_YangyangBirdssss_Skill_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0601FB21 RID: 129825 RVA: 0x008BFF85 File Offset: 0x008BE185
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Deactivate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_YangyangBirdssss_Skill_C.__Deactivate_NativeFunctionPtr, null);
		}

		// Token: 0x0601FB22 RID: 129826 RVA: 0x008BFF99 File Offset: 0x008BE199
		protected BP_YangyangBirdssss_Skill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F431 RID: 62513
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/YangYangBirds/BP_YangyangBirdssss_Skill.BP_YangyangBirdssss_Skill_C";

		// Token: 0x0400F432 RID: 62514
		private static IntPtr _ClassPtr;

		// Token: 0x0400F433 RID: 62515
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F434 RID: 62516
		internal static int __PropertyOffset_1;

		// Token: 0x0400F435 RID: 62517
		internal static int __PropertyOffset_2;

		// Token: 0x0400F436 RID: 62518
		private static IntPtr __Deactivate_NativeFunctionPtr;
	}
}
